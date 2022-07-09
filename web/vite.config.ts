import { defineConfig, splitVendorChunkPlugin } from 'vite'
import { resolve } from 'path'
import solidPlugin from 'vite-plugin-solid'
import wasmLoader from 'esbuild-plugin-wasm'
import NodeGlobalsPolyfillPlugin from '@esbuild-plugins/node-globals-polyfill'

export default defineConfig({
  base: '/tictactoe_spiral/',
  resolve: {
    alias: {
      path: 'path-browserify',
      '@': resolve(__dirname, 'src')
    },
  },
  define: {
    'process.env': process.env
  },
  plugins: [
    solidPlugin() as any,
    splitVendorChunkPlugin()
  ],
  build: {
    target: 'esnext',
    emptyOutDir: true,
    rollupOptions: {
      input: {
        main: resolve(__dirname, 'index.html'),
        content_script: resolve(__dirname, 'src/content_script.tsx')
      },
      output: {
        manualChunks: {
          'solid': ['solid-js', 'solid-icons', '@storeon/solidjs', 'storeon'],
          'gun': ['rusty-gun', 'gun'],
          'algosdk': ['algosdk', 'buffer']
        }
      }
    }
  },
  optimizeDeps: {
    esbuildOptions: {
      format: 'esm',
      target: ['esnext'],
      define: {
        global: 'globalThis'
      },
      plugins: [
        NodeGlobalsPolyfillPlugin({
          buffer: true
        }) as any,
        wasmLoader({
          mode: 'embedded'
        })
      ]
    }
  },
  preview: {
    port: 3700
  },
  server: {
    fs: {
      allow: ['..'],
    },
    host: true,
    https: true,
    port: 3700,
    hmr: {
      clientPort: 443
    }
  }
})
