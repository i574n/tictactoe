import { defineConfig, splitVendorChunkPlugin } from 'vite'
import { resolve } from 'path'
import wasm from "vite-plugin-wasm"
import mkcert from 'vite-plugin-mkcert'
import NodeGlobalsPolyfillPlugin from '@esbuild-plugins/node-globals-polyfill'


export default defineConfig(async ({ }) => {
  return {
    base: '/tictactoe/',
    resolve: {
      alias: {
        path: 'path-browserify'
      },
    },
    define: {
      'process.env': process.env
    },
    plugins: [
      splitVendorChunkPlugin(),
      wasm(),
      mkcert()
    ],
    build: {
      target: 'esnext',
      emptyOutDir: true,
      rollupOptions: {
        input: {
          main: resolve(__dirname, 'index.html'),
          // extension_content_script: resolve(__dirname, 'src/extension_content_script.tsx')
        },
        output: {
          manualChunks: {
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
          }) as any
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
  }
})
