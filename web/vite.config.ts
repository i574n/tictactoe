import { defineConfig } from 'vite'
import solidPlugin from 'vite-plugin-solid'
import NodeGlobalsPolyfillPlugin from '@esbuild-plugins/node-globals-polyfill'

export default defineConfig({
  resolve: {
    alias: {
      path: 'path-browserify'
    },
  },
  define: {
    "process.env": process.env
  },
  plugins: [solidPlugin()],
  build: {
    target: 'esnext'
  },
  optimizeDeps: {
    esbuildOptions: {
      inject: ['./buffer_shim.ts'],
      define: {
        global: 'globalThis'
      },
      plugins: [
        NodeGlobalsPolyfillPlugin({
          buffer: true,
        })
      ]
    }
  },
  preview: {
    port: 3700
  },
  server: {
    host: true,
    https: true,
    port: 3700,
    hmr: {
      clientPort: 443
    }
  }
})
