import { defineConfig } from 'vite'
import solidPlugin from 'vite-plugin-solid'
import NodeGlobalsPolyfillPlugin from '@esbuild-plugins/node-globals-polyfill'

export default defineConfig({
  base: '/tictactoe_spiral/',
  resolve: {
    alias: {
      path: 'path-browserify'
    },
  },
  define: {
    "process.env": process.env
  },
  plugins: [solidPlugin() as any],
  build: {
    target: 'esnext'
  },
  optimizeDeps: {
    esbuildOptions: {
      define: {
        global: 'globalThis'
      },
      plugins: [
        NodeGlobalsPolyfillPlugin({
          buffer: true
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
