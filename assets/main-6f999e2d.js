var B=(e,n)=>()=>(n||e((n={exports:{}}).exports,n),n.exports);var Z=B((tn,T)=>{(function(){const n=document.createElement("link").relList;if(n&&n.supports&&n.supports("modulepreload"))return;for(const o of document.querySelectorAll('link[rel="modulepreload"]'))r(o);new MutationObserver(o=>{for(const c of o)if(c.type==="childList")for(const s of c.addedNodes)s.tagName==="LINK"&&s.rel==="modulepreload"&&r(s)}).observe(document,{childList:!0,subtree:!0});function t(o){const c={};return o.integrity&&(c.integrity=o.integrity),o.referrerpolicy&&(c.referrerPolicy=o.referrerpolicy),o.crossorigin==="use-credentials"?c.credentials="include":o.crossorigin==="anonymous"?c.credentials="omit":c.credentials="same-origin",c}function r(o){if(o.ep)return;o.ep=!0;const c=t(o);fetch(o.href,c)}})();let f;const v=new Array(128).fill(void 0);v.push(void 0,null,!0,!1);function u(e){return v[e]}let E=v.length;function N(e){e<132||(v[e]=E,E=e)}function S(e){const n=u(e);return N(e),n}function p(e){if(typeof e!="boolean")throw new Error("expected a boolean argument")}const F=new TextDecoder("utf-8",{ignoreBOM:!0,fatal:!0});F.decode();let k=null;function R(){return(k===null||k.byteLength===0)&&(k=new Uint8Array(f.memory.buffer)),k}function j(e,n){return F.decode(R().subarray(e,e+n))}function i(e){E===v.length&&v.push(v.length+1);const n=E;if(E=v[n],typeof E!="number")throw new Error("corrupt heap");return v[n]=e,n}let y=0;const O=new TextEncoder("utf-8"),U=typeof O.encodeInto=="function"?function(e,n){return O.encodeInto(e,n)}:function(e,n){const t=O.encode(e);return n.set(t),{read:e.length,written:t.length}};function h(e,n,t){if(typeof e!="string")throw new Error("expected a string argument");if(t===void 0){const g=O.encode(e),m=n(g.length);return R().subarray(m,m+g.length).set(g),y=g.length,m}let r=e.length,o=n(r);const c=R();let s=0;for(;s<r;s++){const g=e.charCodeAt(s);if(g>127)break;c[o+s]=g}if(s!==r){s!==0&&(e=e.slice(s)),o=t(o,r,r=s+e.length*3);const g=R().subarray(o+s,o+r),m=U(e,g);if(m.read!==e.length)throw new Error("failed to pass whole string");s+=m.written}return y=s,o}function d(e){return e==null}let A=null;function w(){return(A===null||A.byteLength===0)&&(A=new Int32Array(f.memory.buffer)),A}function I(e){const n=typeof e;if(n=="number"||n=="boolean"||e==null)return`${e}`;if(n=="string")return`"${e}"`;if(n=="symbol"){const o=e.description;return o==null?"Symbol":`Symbol(${o})`}if(n=="function"){const o=e.name;return typeof o=="string"&&o.length>0?`Function(${o})`:"Function"}if(Array.isArray(e)){const o=e.length;let c="[";o>0&&(c+=I(e[0]));for(let s=1;s<o;s++)c+=", "+I(e[s]);return c+="]",c}const t=/\[object ([^\]]+)\]/.exec(toString.call(e));let r;if(t.length>1)r=t[1];else return toString.call(e);if(r=="Object")try{return"Object("+JSON.stringify(e)+")"}catch{return"Object"}return e instanceof Error?`${e.name}: ${e.message}
${e.stack}`:r}function x(e,n,t,r){const o={a:e,b:n,cnt:1,dtor:t},c=(...s)=>{o.cnt++;const g=o.a;o.a=0;try{return r(g,o.b,...s)}finally{--o.cnt===0?f.__wbindgen_export_2.get(o.dtor)(g,o.b):o.a=g}};return c.original=o,c}function _(e,n){try{return e.apply(this,n)}catch(t){let r=function(){try{return t instanceof Error?`${t.message}

Stack:
${t.stack}`:t.toString()}catch{return"<failed to stringify thrown value>"}}();throw console.error("wasm-bindgen: imported JS function that was not marked as `catch` threw an error:",r),t}}function l(e){if(typeof e!="number")throw new Error("expected a number argument")}function P(e,n,t){try{const c=f.__wbindgen_add_to_stack_pointer(-16);l(e),l(n),f._dyn_core__ops__function__FnMut__A____Output___R_as_wasm_bindgen__closure__WasmClosure___describe__invoke__h58c369822b050cc5(c,e,n,i(t));var r=w()[c/4+0],o=w()[c/4+1];if(o)throw S(r)}finally{f.__wbindgen_add_to_stack_pointer(16)}}function L(e,n,t,r){const o={a:e,b:n,cnt:1,dtor:t},c=(...s)=>{o.cnt++;try{return r(o.a,o.b,...s)}finally{--o.cnt===0&&(f.__wbindgen_export_2.get(o.dtor)(o.a,o.b),o.a=0)}};return c.original=o,c}function $(e,n,t){l(e),l(n),f._dyn_core__ops__function__Fn__A____Output___R_as_wasm_bindgen__closure__WasmClosure___describe__invoke__hac0b64257ddad0a6(e,n,i(t))}function H(e,n){l(e),l(n),f._dyn_core__ops__function__Fn_____Output___R_as_wasm_bindgen__closure__WasmClosure___describe__invoke__h8984bfa73a61ca4b(e,n)}let W=128;function q(e){if(W==1)throw new Error("out of js stack");return v[--W]=e,W}function V(e,n,t){try{l(e),l(n),f._dyn_core__ops__function__FnMut___A____Output___R_as_wasm_bindgen__closure__WasmClosure___describe__invoke__hdb5f851c0bc2279a(e,n,q(t))}finally{v[W++]=void 0}}function G(e,n,t){l(e),l(n),f._dyn_core__ops__function__FnMut__A____Output___R_as_wasm_bindgen__closure__WasmClosure___describe__invoke__hcf931b553e742a0d(e,n,i(t))}function J(){f.client()}function b(e,n){return e===0?u(n):j(e,n)}function a(e,n){try{return e.apply(this,n)}catch(t){f.__wbindgen_exn_store(i(t))}}function z(e,n){return R().subarray(e/1,e/1+n)}async function K(e,n){if(typeof Response=="function"&&e instanceof Response){if(typeof WebAssembly.instantiateStreaming=="function")try{return await WebAssembly.instantiateStreaming(e,n)}catch(r){if(e.headers.get("Content-Type")!="application/wasm")console.warn("`WebAssembly.instantiateStreaming` failed because your server does not serve wasm with `application/wasm` MIME type. Falling back to `WebAssembly.instantiate` which is slower. Original error:\n",r);else throw r}const t=await e.arrayBuffer();return await WebAssembly.instantiate(t,n)}else{const t=await WebAssembly.instantiate(e,n);return t instanceof WebAssembly.Instance?{instance:t,module:e}:t}}function Q(){const e={};return e.wbg={},e.wbg.__wbindgen_cb_drop=function(n){const t=S(n).original;if(t.cnt--==1)return t.a=0,!0;const r=!1;return p(r),r},e.wbg.__wbindgen_string_new=function(n,t){const r=j(n,t);return i(r)},e.wbg.__wbindgen_object_clone_ref=function(n){const t=u(n);return i(t)},e.wbg.__wbg_error_f851667af71bcfc6=function(){return _(function(n,t){var r=b(n,t);n!==0&&f.__wbindgen_free(n,t),console.error(r)},arguments)},e.wbg.__wbg_new_abda76e883ba8a5f=function(){return _(function(){const n=new Error;return i(n)},arguments)},e.wbg.__wbg_stack_658279fe44541cf6=function(){return _(function(n,t){const r=u(t).stack,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbindgen_string_get=function(n,t){const r=u(t),o=typeof r=="string"?r:void 0;var c=d(o)?0:h(o,f.__wbindgen_malloc,f.__wbindgen_realloc),s=y;w()[n/4+1]=s,w()[n/4+0]=c},e.wbg.__wbindgen_is_undefined=function(n){const t=u(n)===void 0;return p(t),t},e.wbg.__wbg_Window_2323448e22bf340f=function(){return _(function(n){const t=u(n).Window;return i(t)},arguments)},e.wbg.__wbg_WorkerGlobalScope_4f52a4f4757baa51=function(){return _(function(n){const t=u(n).WorkerGlobalScope;return i(t)},arguments)},e.wbg.__wbg_global_bb13ba737d1fd37d=function(){return _(function(n){const t=u(n).global;return i(t)},arguments)},e.wbg.__wbg_indexedDB_553c6eee256a5956=function(){return a(function(n){const t=u(n).indexedDB;return d(t)?0:i(t)},arguments)},e.wbg.__wbindgen_is_object=function(n){const t=u(n),r=typeof t=="object"&&t!==null;return p(r),r},e.wbg.__wbg_instanceof_Window_e266f02eee43b570=function(){return _(function(n){let t;try{t=u(n)instanceof Window}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_document_950215a728589a2d=function(){return _(function(n){const t=u(n).document;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_localStorage_42608208af988a02=function(){return a(function(n){const t=u(n).localStorage;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_indexedDB_47544d523ac2a208=function(){return a(function(n){const t=u(n).indexedDB;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_fetch_465e8cb61a0f43ea=function(){return _(function(n,t){const r=u(n).fetch(u(t));return i(r)},arguments)},e.wbg.__wbg_location_0e4257c972d74a3c=function(){return _(function(n){const t=u(n).location;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_body_be46234bb33edd63=function(){return _(function(n){const t=u(n).body;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_head_a7ca4abdb52f6a3f=function(){return _(function(n){const t=u(n).head;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_createElement_e2a0e21263eb5416=function(){return a(function(n,t,r){var o=b(t,r);const c=u(n).createElement(o);return i(c)},arguments)},e.wbg.__wbg_settype_4f66c5d3844bd98f=function(){return _(function(n,t,r){var o=b(t,r);u(n).type=o},arguments)},e.wbg.__wbg_sheet_7840cf74c51ee7bd=function(){return _(function(n){const t=u(n).sheet;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_appendChild_b8199dc1655c852d=function(){return a(function(n,t){const r=u(n).appendChild(u(t));return i(r)},arguments)},e.wbg.__wbg_indexedDB_83385e4ce65e9054=function(){return a(function(n){const t=u(n).indexedDB;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_getPropertyValue_05e910529ab6e32a=function(){return a(function(n,t,r,o){var c=b(r,o);const s=u(t).getPropertyValue(c),g=h(s,f.__wbindgen_malloc,f.__wbindgen_realloc),m=y;w()[n/4+1]=m,w()[n/4+0]=g},arguments)},e.wbg.__wbg_removeProperty_d94b45fd3a758db4=function(){return a(function(n,t,r,o){var c=b(r,o);const s=u(t).removeProperty(c),g=h(s,f.__wbindgen_malloc,f.__wbindgen_realloc),m=y;w()[n/4+1]=m,w()[n/4+0]=g},arguments)},e.wbg.__wbg_setProperty_141523e2ee28f516=function(){return a(function(n,t,r,o,c,s,g){var m=b(t,r),C=b(o,c),D=b(s,g);u(n).setProperty(m,C,D)},arguments)},e.wbg.__wbg_setonabort_0e116e0f6f9fc3a6=function(){return _(function(n,t){u(n).onabort=u(t)},arguments)},e.wbg.__wbg_setoncomplete_f32167d3f84be687=function(){return _(function(n,t){u(n).oncomplete=u(t)},arguments)},e.wbg.__wbg_setonerror_7cbe775a0abc7a8e=function(){return _(function(n,t){u(n).onerror=u(t)},arguments)},e.wbg.__wbg_objectStore_cdc69f65ad4a71eb=function(){return a(function(n,t,r){var o=b(t,r);const c=u(n).objectStore(o);return i(c)},arguments)},e.wbg.__wbg_href_bb86bb94d1c6861b=function(){return a(function(n,t){const r=u(t).href,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbg_getItem_f0d43fc4e780b652=function(){return a(function(n,t,r,o){var c=b(r,o);const s=u(t).getItem(c);var g=d(s)?0:h(s,f.__wbindgen_malloc,f.__wbindgen_realloc),m=y;w()[n/4+1]=m,w()[n/4+0]=g},arguments)},e.wbg.__wbg_removeItem_793faa7edf21ad57=function(){return a(function(n,t,r){var o=b(t,r);u(n).removeItem(o)},arguments)},e.wbg.__wbg_setItem_f645824d6eface62=function(){return a(function(n,t,r,o,c){var s=b(t,r),g=b(o,c);u(n).setItem(s,g)},arguments)},e.wbg.__wbg_instanceof_HtmlIFrameElement_ca66007558e06f29=function(){return _(function(n){let t;try{t=u(n)instanceof HTMLIFrameElement}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_contentDocument_cac75a0be7c3a413=function(){return _(function(n){const t=u(n).contentDocument;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_contentWindow_59cb914a9e109a49=function(){return _(function(n){const t=u(n).contentWindow;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_newwithmessage_ff6e8502f3396299=function(){return a(function(n,t){var r=b(n,t);const o=new DOMException(r);return i(o)},arguments)},e.wbg.__wbg_item_d5de7e3394624329=function(){return _(function(n,t,r){const o=u(t).item(r>>>0);var c=d(o)?0:h(o,f.__wbindgen_malloc,f.__wbindgen_realloc),s=y;w()[n/4+1]=s,w()[n/4+0]=c},arguments)},e.wbg.__wbg_set_a5d34c36a1a4ebd1=function(){return a(function(n,t,r,o,c){var s=b(t,r),g=b(o,c);u(n).set(s,g)},arguments)},e.wbg.__wbg_name_31ef05f12c1d72c6=function(){return _(function(n,t){const r=u(t).name,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbg_objectStoreNames_f0884fed45ebc81c=function(){return _(function(n){const t=u(n).objectStoreNames;return i(t)},arguments)},e.wbg.__wbg_setonversionchange_fd71954420371ad8=function(){return _(function(n,t){u(n).onversionchange=u(t)},arguments)},e.wbg.__wbg_close_98f3a5ab91060b8b=function(){return _(function(n){u(n).close()},arguments)},e.wbg.__wbg_createObjectStore_ebb17df1a43fd925=function(){return a(function(n,t,r){var o=b(t,r);const c=u(n).createObjectStore(o);return i(c)},arguments)},e.wbg.__wbg_transaction_6d097d62f550220d=function(){return a(function(n,t,r,o){var c=b(t,r);const s=u(n).transaction(c,S(o));return i(s)},arguments)},e.wbg.__wbg_put_fdcda25ee2a99b60=function(){return a(function(n,t,r){const o=u(n).put(u(t),u(r));return i(o)},arguments)},e.wbg.__wbg_setonblocked_78e53418c43a7090=function(){return _(function(n,t){u(n).onblocked=u(t)},arguments)},e.wbg.__wbg_setonupgradeneeded_8961be061344d04a=function(){return _(function(n,t){u(n).onupgradeneeded=u(t)},arguments)},e.wbg.__wbg_classList_c4ebb3813d3a2f5d=function(){return _(function(n){const t=u(n).classList;return i(t)},arguments)},e.wbg.__wbg_setAttribute_79c9562d32d05e66=function(){return a(function(n,t,r,o,c){var s=b(t,r),g=b(o,c);u(n).setAttribute(s,g)},arguments)},e.wbg.__wbg_instanceof_HtmlElement_9e442d53bb553421=function(){return _(function(n){let t;try{t=u(n)instanceof HTMLElement}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_add_73f794d491a0e44f=function(){return a(function(n,t,r){var o=b(t,r);u(n).add(o)},arguments)},e.wbg.__wbg_deleteDatabase_f360deb7283ea232=function(){return a(function(n,t,r){var o=b(t,r);const c=u(n).deleteDatabase(o);return i(c)},arguments)},e.wbg.__wbg_open_2f9bdc2df25fc92e=function(){return a(function(n,t,r,o){var c=b(t,r);const s=u(n).open(c,o>>>0);return i(s)},arguments)},e.wbg.__wbg_result_3a1fef332bc47038=function(){return a(function(n){const t=u(n).result;return i(t)},arguments)},e.wbg.__wbg_error_f64b8d41ed4d2fdc=function(){return a(function(n){const t=u(n).error;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_readyState_d9cf5eb3487e31d6=function(){return _(function(n){const t=u(n).readyState;return i(t)},arguments)},e.wbg.__wbg_setonsuccess_925a7718d3f62bc1=function(){return _(function(n,t){u(n).onsuccess=u(t)},arguments)},e.wbg.__wbg_setonerror_019196fbce756cc0=function(){return _(function(n,t){u(n).onerror=u(t)},arguments)},e.wbg.__wbg_instanceof_Response_fb3a4df648c1859b=function(){return _(function(n){let t;try{t=u(n)instanceof Response}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_url_8ec2534cdfacb103=function(){return _(function(n,t){const r=u(t).url,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbg_status_d483a4ac847f380a=function(){return _(function(n){const t=u(n).status;return l(t),t},arguments)},e.wbg.__wbg_ok_1cd4c5ee1ccf4e0f=function(){return _(function(n){const t=u(n).ok;return p(t),t},arguments)},e.wbg.__wbg_statusText_9674693c2eb731fa=function(){return _(function(n,t){const r=u(t).statusText,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbg_headers_6093927dc359903e=function(){return _(function(n){const t=u(n).headers;return i(t)},arguments)},e.wbg.__wbg_arrayBuffer_cb886e06a9e36e4d=function(){return a(function(n){const t=u(n).arrayBuffer();return i(t)},arguments)},e.wbg.__wbg_log_05aae26cc6b31dd7=function(){return _(function(n){console.log(...u(n))},arguments)},e.wbg.__wbg_log_7bb108d119bafbc1=function(){return _(function(n){console.log(u(n))},arguments)},e.wbg.__wbg_length_cb56788f94a79587=function(){return _(function(n){const t=u(n).length;return l(t),t},arguments)},e.wbg.__wbg_get_745417bfe3c81a91=function(){return _(function(n,t){const r=u(n)[t>>>0];return d(r)?0:i(r)},arguments)},e.wbg.__wbg_target_b629c177f9bee3da=function(){return _(function(n){const t=u(n).target;return d(t)?0:i(t)},arguments)},e.wbg.__wbg_instanceof_HtmlInputElement_5c9d54338207f061=function(){return _(function(n){let t;try{t=u(n)instanceof HTMLInputElement}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_value_1f2c9e357d18d3ea=function(){return _(function(n,t){const r=u(t).value,o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},arguments)},e.wbg.__wbg_headers_ab5251d2727ac41e=function(){return _(function(n){const t=u(n).headers;return i(t)},arguments)},e.wbg.__wbg_newwithstrandinit_c45f0dc6da26fd03=function(){return a(function(n,t,r){var o=b(n,t);const c=new Request(o,u(r));return i(c)},arguments)},e.wbg.__wbg_addEventListener_cf5b03cd29763277=function(){return a(function(n,t,r,o,c){var s=b(t,r);u(n).addEventListener(s,u(o),u(c))},arguments)},e.wbg.__wbg_removeEventListener_b25f5db74f767386=function(){return a(function(n,t,r,o,c){var s=b(t,r);u(n).removeEventListener(s,u(o),c!==0)},arguments)},e.wbg.__wbg_style_71d307158ce61414=function(){return _(function(n){const t=u(n).style;return i(t)},arguments)},e.wbg.__wbg_cssRules_d2d7f924cdcf6c4c=function(){return a(function(n){const t=u(n).cssRules;return i(t)},arguments)},e.wbg.__wbg_insertRule_34e421ae258979f7=function(){return a(function(n,t,r){var o=b(t,r);const c=u(n).insertRule(o);return l(c),c},arguments)},e.wbg.__wbg_insertRule_3f23d77db11d4819=function(){return a(function(n,t,r,o){var c=b(t,r);const s=u(n).insertRule(c,o>>>0);return l(s),s},arguments)},e.wbg.__wbindgen_is_string=function(n){const t=typeof u(n)=="string";return p(t),t},e.wbg.__wbg_crypto_e1d53a1d73fb10b8=function(){return _(function(n){const t=u(n).crypto;return i(t)},arguments)},e.wbg.__wbg_msCrypto_6e7d3e1f92610cbb=function(){return _(function(n){const t=u(n).msCrypto;return i(t)},arguments)},e.wbg.__wbg_getRandomValues_805f1c3d65988a5a=function(){return a(function(n,t){u(n).getRandomValues(u(t))},arguments)},e.wbg.__wbg_randomFillSync_6894564c2c334c42=function(){return a(function(n,t,r){u(n).randomFillSync(z(t,r))},arguments)},e.wbg.__wbg_require_78a3dcfbdba9cbce=function(){return a(function(){const n=T.require;return i(n)},arguments)},e.wbg.__wbg_process_038c26bf42b093f8=function(){return _(function(n){const t=u(n).process;return i(t)},arguments)},e.wbg.__wbg_versions_ab37218d2f0b24a8=function(){return _(function(n){const t=u(n).versions;return i(t)},arguments)},e.wbg.__wbg_node_080f4b19d15bc1fe=function(){return _(function(n){const t=u(n).node;return i(t)},arguments)},e.wbg.__wbg_new_b525de17f44a8943=function(){return _(function(){const n=new Array;return i(n)},arguments)},e.wbg.__wbg_get_27fe3dac1c4d0224=function(){return _(function(n,t){const r=u(n)[t>>>0];return i(r)},arguments)},e.wbg.__wbg_set_17224bc548dd1d7b=function(){return _(function(n,t,r){u(n)[t>>>0]=S(r)},arguments)},e.wbg.__wbg_from_67ca20fa722467e6=function(){return _(function(n){const t=Array.from(u(n));return i(t)},arguments)},e.wbg.__wbg_length_e498fbc24f9c1d4f=function(){return _(function(n){const t=u(n).length;return l(t),t},arguments)},e.wbg.__wbg_instanceof_Error_749a7378f4439ee0=function(){return _(function(n){let t;try{t=u(n)instanceof Error}catch{t=!1}const r=t;return p(r),r},arguments)},e.wbg.__wbg_message_a95c3ef248e4b57a=function(){return _(function(n){const t=u(n).message;return i(t)},arguments)},e.wbg.__wbg_newnoargs_2b8b6bd7753c76ba=function(){return _(function(n,t){var r=b(n,t);const o=new Function(r);return i(o)},arguments)},e.wbg.__wbg_call_95d1ea488d03e4e8=function(){return a(function(n,t){const r=u(n).call(u(t));return i(r)},arguments)},e.wbg.__wbg_call_9495de66fdbe016b=function(){return a(function(n,t,r){const o=u(n).call(u(t),u(r));return i(o)},arguments)},e.wbg.__wbg_next_88560ec06a094dea=function(){return a(function(n){const t=u(n).next();return i(t)},arguments)},e.wbg.__wbg_next_b7d530c04fd8b217=function(){return _(function(n){const t=u(n).next;return i(t)},arguments)},e.wbg.__wbg_done_1ebec03bbd919843=function(){return _(function(n){const t=u(n).done;return p(t),t},arguments)},e.wbg.__wbg_value_6ac8da5cc5b3efda=function(){return _(function(n){const t=u(n).value;return i(t)},arguments)},e.wbg.__wbg_getTime_7c59072d1651a3cf=function(){return _(function(n){return u(n).getTime()},arguments)},e.wbg.__wbg_new0_25059e40b1c02766=function(){return _(function(){const n=new Date;return i(n)},arguments)},e.wbg.__wbg_new_f9876326328f45ed=function(){return _(function(){const n=new Object;return i(n)},arguments)},e.wbg.__wbg_iterator_55f114446221aa5a=function(){return _(function(){return i(Symbol.iterator)},arguments)},e.wbg.__wbg_resolve_fd40f858d9db1a04=function(){return _(function(n){const t=Promise.resolve(u(n));return i(t)},arguments)},e.wbg.__wbg_then_ec5db6d509eb475f=function(){return _(function(n,t){const r=u(n).then(u(t));return i(r)},arguments)},e.wbg.__wbg_then_f753623316e2873a=function(){return _(function(n,t,r){const o=u(n).then(u(t),u(r));return i(o)},arguments)},e.wbg.__wbg_globalThis_87cbb8506fecf3a9=function(){return a(function(){const n=globalThis.globalThis;return i(n)},arguments)},e.wbg.__wbg_self_e7c1f827057f6584=function(){return a(function(){const n=self.self;return i(n)},arguments)},e.wbg.__wbg_window_a09ec664e14b1b81=function(){return a(function(){const n=window.window;return i(n)},arguments)},e.wbg.__wbg_global_c85a9259e621f3db=function(){return a(function(){const n=global.global;return i(n)},arguments)},e.wbg.__wbg_new_537b7341ce90bb31=function(){return _(function(n){const t=new Uint8Array(u(n));return i(t)},arguments)},e.wbg.__wbg_newwithlength_b56c882b57805732=function(){return _(function(n){const t=new Uint8Array(n>>>0);return i(t)},arguments)},e.wbg.__wbg_newwithbyteoffsetandlength_9fb2f11355ecadf5=function(){return _(function(n,t,r){const o=new Uint8Array(u(n),t>>>0,r>>>0);return i(o)},arguments)},e.wbg.__wbg_subarray_7526649b91a252a6=function(){return _(function(n,t,r){const o=u(n).subarray(t>>>0,r>>>0);return i(o)},arguments)},e.wbg.__wbg_length_27a2afe8ab42b09f=function(){return _(function(n){const t=u(n).length;return l(t),t},arguments)},e.wbg.__wbg_set_17499e8aa4003ebd=function(){return _(function(n,t,r){u(n).set(u(t),r>>>0)},arguments)},e.wbg.__wbg_get_baf4855f9a986186=function(){return a(function(n,t){const r=Reflect.get(u(n),u(t));return i(r)},arguments)},e.wbg.__wbg_set_6aa458a4ebdb65cb=function(){return a(function(n,t,r){const o=Reflect.set(u(n),u(t),u(r));return p(o),o},arguments)},e.wbg.__wbindgen_is_function=function(n){const t=typeof u(n)=="function";return p(t),t},e.wbg.__wbg_buffer_cf65c07de34b9a08=function(){return _(function(n){const t=u(n).buffer;return i(t)},arguments)},e.wbg.__wbindgen_debug_string=function(n,t){const r=I(u(t)),o=h(r,f.__wbindgen_malloc,f.__wbindgen_realloc),c=y;w()[n/4+1]=c,w()[n/4+0]=o},e.wbg.__wbindgen_object_drop_ref=function(n){S(n)},e.wbg.__wbindgen_throw=function(n,t){throw new Error(j(n,t))},e.wbg.__wbindgen_memory=function(){const n=f.memory;return i(n)},e.wbg.__wbindgen_closure_wrapper1354=function(){return _(function(n,t,r){const o=x(n,t,17,P);return i(o)},arguments)},e.wbg.__wbindgen_closure_wrapper2443=function(){return _(function(n,t,r){const o=L(n,t,189,$);return i(o)},arguments)},e.wbg.__wbindgen_closure_wrapper2445=function(){return _(function(n,t,r){const o=L(n,t,185,H);return i(o)},arguments)},e.wbg.__wbindgen_closure_wrapper8165=function(){return _(function(n,t,r){const o=x(n,t,492,V);return i(o)},arguments)},e.wbg.__wbindgen_closure_wrapper8611=function(){return _(function(n,t,r){const o=x(n,t,501,G);return i(o)},arguments)},e}function X(e,n){return f=e.exports,M.__wbindgen_wasm_module=n,A=null,k=null,f}async function M(e){typeof e>"u"&&(e=new URL("/tictactoe/assets/client_bg-f1e4a128.wasm",self.location));const n=Q();(typeof e=="string"||typeof Request=="function"&&e instanceof Request||typeof URL=="function"&&e instanceof URL)&&(e=fetch(e));const{instance:t,module:r}=await K(await e,n);return X(t,r)}async function Y(){await M(),J()}Y()});export default Z();