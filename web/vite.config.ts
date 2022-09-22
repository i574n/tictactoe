import { defineConfig, splitVendorChunkPlugin } from 'vite'
import { resolve } from 'path'
import solidPlugin from 'vite-plugin-solid'
import wasm from "vite-plugin-wasm"
import mkcert from 'vite-plugin-mkcert'
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
        extension_content_script: resolve(__dirname, 'src/extension_content_script.tsx')
      },
      output: {
        manualChunks: {
          'rusty-gun': ['rusty-gun'],
          'gun': ['gun'],

          'solid-js': ['solid-js'],
          'solid-icons': ['solid-icons'],
          'storeon': ['storeon'],
          'storeon-solidjs': ['@storeon/solidjs'],

          'hope-ui': ['@hope-ui/solid'],
          'stitches': ['@stitches/core'],
          'solid-transition-group': ['solid-transition-group'],

          'buffer': ['buffer'],
          'algosdk': ['algosdk']
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
})
