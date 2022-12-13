namespace PeerSignalR

open System
open System.IO
open FsClr
open FsCore
open FSharp.Control
open System.Threading
open Fable.SignalR
open PeerSignalR
open System.Collections.Generic
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting


module Stream =
    let sendToClient
        update
        rootPath
        (msg: Peer.UH0)
        (hubContext: FableHub<Peer.UH0, Peer.UH1>)
        =
        update rootPath msg (Some hubContext)
        |> Async.AwaitTask
        |> Async.initAsyncSeq
        |> AsyncSeq.toAsyncEnum

    let getFromClient
        (clientStream: IAsyncEnumerable<_>)
        (hubContext: FableHub<Peer.UH0, Peer.UH1>)
        =
        AsyncSeq.ofAsyncEnum<_> clientStream
        |> AsyncSeq.iterAsync (function
            | message -> async {
                let getLocals () = $"message={message} {getLocals ()}"
                Logger.logDebug (fun () -> "Stream.getFromClient") getLocals
                // | StreamTo.Action.GiveInt i ->
                //     hubContext.Clients.Caller.Send(Response.NewCount i)
                //     |> Async.AwaitTask)
            })
        |> Async.StartAsTask

    type HubService<'Request, 'Response when 'Request: not struct and 'Response: not struct>
        (
            hub: FableHubCaller<'Request, 'Response>,
            fn,
            dispose
        ) =
        let cts = new CancellationTokenSource ()

        interface IHostedService with
            member _.StartAsync ct =
                async { Async.Start (fn hub, cts.Token) }
                |> Async.startAsTask ct

            member _.StopAsync ct =
                async {
                    dispose ()
                    cts.Cancel ()
                }
                |> Async.startAsTask ct

    // type Ticker (hub, fn, dispose) =
    //     inherit HubService<Peer.UH0, Peer.UH1> (hub, fn, dispose)

    //     static member Create (services: IServiceCollection, fn, dispose) =
    //         services.AddHostedService
    //             (fun (serviceProvider: IServiceProvider) ->
    //                 let hub =
    //                     serviceProvider.GetRequiredService<FableHubCaller<Peer.UH0, Peer.UH1>> ()
    //                 Ticker (hub, fn, dispose))

    type FileWatcher (hub, fn, dispose) =
        inherit HubService<Peer.UH0, Peer.UH1> (hub, fn, dispose)

        static member Create (services: IServiceCollection, fn, dispose) =
            services.AddHostedService
                (fun (serviceProvider: IServiceProvider) ->
                    let hub =
                        serviceProvider.GetRequiredService<FableHubCaller<Peer.UH0, Peer.UH1>> ()
                    FileWatcher (hub, fn, dispose))

    // let withTicker fn serviceCollection =
    //     Ticker.Create (
    //         serviceCollection,
    //         (fun hub ->
    //             AsyncSeq.intervalMs 2000
    //             |> AsyncSeq.iterAsync
    //                 (fun date ->
    //                     let getLocals () = $"ticks={date.Ticks} {getLocals ()}"
    //                     Logger.logDebug (fun () -> "Stream.withTicker / onTick") getLocals
    //                     fn hub |> Async.AwaitTask)),
    //         fun () -> Logger.logDebug (fun () -> "Stream.withTicker / dispose") getLocals
    //     )

    let withFileWatcher rootPath fn serviceCollection =
        let watch, disposable = FileSystem.watch rootPath

        let getLocals () = $"rootPath={rootPath} {getLocals ()}"

        Logger.logTrace (fun () -> "Stream.withFileWatcher / creating FileWatcher") getLocals

        FileWatcher.Create (
            serviceCollection,
            (fun hub ->
                watch
                |> AsyncSeq.iterAsync
                    (fun (ticks, event) ->
                        async {
                            let getLocals () =
                                $"ticks={ticks} event={event} {getLocals ()}"

                            Logger.logTrace (fun () -> "Stream.withFileWatcher / fn") getLocals
                            fn (hub, ticks, event)
                        })),
            (fun () ->
                Logger.logDebug (fun () -> "Stream.withWileWatcher / dispose") getLocals
                disposable.Dispose ())
        )
