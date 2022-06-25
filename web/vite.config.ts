import { defineConfig, splitVendorChunkPlugin } from 'vite'
import { resolve } from 'path'
import solidPlugin from 'vite-plugin-solid'
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
        main: resolve(__dirname, 'index.html')
      },
      output: {
        manualChunks: {
          'solid': ['solid-js', 'solid-icons', '@storeon/solidjs', 'storeon'],
          'algosdk': ['algosdk', 'buffer']
        }
      }
    }
  },
  optimizeDeps: {
    esbuildOptions: {
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
})
