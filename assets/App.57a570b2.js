import{a as ae,s as y,b as g,d as le,e as oe,c as p,S as se,u as O,F as re,f as v,g as K,o as F,h as _e}from"./solid.8b99bd87.js";import{i as N,a as x,N as de}from"./gun.3797e87e.js";import{a as R}from"./algosdk.06b5fc7c.js";N();x();var ce=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],pe=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...ce]),ue=new Set(["innerHTML","textContent","innerText","children"]),me={className:"class",htmlFor:"for"},I={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},be=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),ge={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function V(t,n){return le(t,void 0,n?void 0:{equals:n})}function fe(t,n,e){let i=e.length,l=n.length,s=i,a=0,o=0,r=n[l-1].nextSibling,_=null;for(;a<l||o<s;){if(n[a]===e[o]){a++,o++;continue}for(;n[l-1]===e[s-1];)l--,s--;if(l===a){const c=s<i?o?e[o-1].nextSibling:e[s-o]:r;for(;o<s;)t.insertBefore(e[o++],c)}else if(s===o)for(;a<l;)(!_||!_.has(n[a]))&&n[a].remove(),a++;else if(n[a]===e[s-1]&&e[o]===n[l-1]){const c=n[--l].nextSibling;t.insertBefore(e[o++],n[a++].nextSibling),t.insertBefore(e[--s],c),n[l]=e[s]}else{if(!_){_=new Map;let u=o;for(;u<s;)_.set(e[u],u++)}const c=_.get(n[a]);if(c!=null)if(o<c&&c<s){let u=a,b=1,f;for(;++u<l&&u<s&&!((f=_.get(n[u]))==null||f!==c+b);)b++;if(b>c-o){const S=n[a];for(;o<c;)t.insertBefore(e[o++],S)}else t.replaceChild(e[o++],n[a++])}else a++;else n[a++].remove()}}}var D="_$DX_DELEGATE";function _n(t,n,e){let i;return ae(l=>{i=l,n===document?t():d(n,t(),n.firstChild?null:void 0,e)}),()=>{i(),n.textContent=""}}function m(t,n,e){const i=document.createElement("template");i.innerHTML=t;let l=i.content.firstChild;return e&&(l=l.firstChild),l}function j(t,n=window.document){const e=n[D]||(n[D]=new Set);for(let i=0,l=t.length;i<l;i++){const s=t[i];e.has(s)||(e.add(s),n.addEventListener(s,Oe))}}function w(t,n,e){e==null?t.removeAttribute(n):t.setAttribute(n,e)}function ye(t,n,e,i){i==null?t.removeAttributeNS(n,e):t.setAttributeNS(n,e,i)}function he(t,n){n==null?t.removeAttribute("class"):t.className=n}function Ae(t,n,e,i){i?Array.isArray(e)?(t[`$$${n}`]=e[0],t[`$$${n}Data`]=e[1]):t[`$$${n}`]=e:Array.isArray(e)?t.addEventListener(n,l=>e[0](e[1],l)):t.addEventListener(n,e)}function Ee(t,n,e={}){const i=Object.keys(n||{}),l=Object.keys(e);let s,a;for(s=0,a=l.length;s<a;s++){const o=l[s];!o||o==="undefined"||n[o]||(H(t,o,!1),delete e[o])}for(s=0,a=i.length;s<a;s++){const o=i[s],r=!!n[o];!o||o==="undefined"||e[o]===r||!r||(H(t,o,!0),e[o]=r)}return e}function z(t,n,e={}){const i=t.style,l=typeof e=="string";if(n==null&&l||typeof n=="string")return i.cssText=n;l&&(i.cssText=void 0,e={}),n||(n={});let s,a;for(a in e)n[a]==null&&i.removeProperty(a),delete e[a];for(a in n)s=n[a],s!==e[a]&&(i.setProperty(a,s),e[a]=s);return e}function G(t,n,e,i){typeof n=="function"?g(l=>U(t,n(),l,e,i)):U(t,n,void 0,e,i)}function d(t,n,e,i){if(e!==void 0&&!i&&(i=[]),typeof n!="function")return E(t,n,i,e);g(l=>E(t,n(),l,e),i)}function Se(t,n,e,i,l={},s=!1){n||(n={});for(const a in l)if(!(a in n)){if(a==="children")continue;B(t,a,null,l[a],e,s)}for(const a in n){if(a==="children"){i||E(t,n.children);continue}const o=n[a];l[a]=B(t,a,o,l[a],e,s)}}function Te(t){return t.toLowerCase().replace(/-([a-z])/g,(n,e)=>e.toUpperCase())}function H(t,n,e){const i=n.trim().split(/\s+/);for(let l=0,s=i.length;l<s;l++)t.classList.toggle(i[l],e)}function B(t,n,e,i,l,s){let a,o,r;if(n==="style")return z(t,e,i);if(n==="classList")return Ee(t,e,i);if(e===i)return i;if(n==="ref")s||e(t);else if(n.slice(0,3)==="on:")t.addEventListener(n.slice(3),e);else if(n.slice(0,10)==="oncapture:")t.addEventListener(n.slice(10),e,!0);else if(n.slice(0,2)==="on"){const _=n.slice(2).toLowerCase(),c=be.has(_);Ae(t,_,e,c),c&&j([_])}else if((r=ue.has(n))||!l&&(I[n]||(o=pe.has(n)))||(a=t.nodeName.includes("-")))n==="class"||n==="className"?he(t,e):a&&!o&&!r?t[Te(n)]=e:t[I[n]||n]=e;else{const _=l&&n.indexOf(":")>-1&&ge[n.split(":")[0]];_?ye(t,_,n,e):w(t,me[n]||n,e)}return e}function Oe(t){const n=`$$${t.type}`;let e=t.composedPath&&t.composedPath()[0]||t.target;for(t.target!==e&&Object.defineProperty(t,"target",{configurable:!0,value:e}),Object.defineProperty(t,"currentTarget",{configurable:!0,get(){return e||document}}),y.registry&&!y.done&&(y.done=!0,document.querySelectorAll("[id^=pl-]").forEach(i=>i.remove()));e!==null;){const i=e[n];if(i&&!e.disabled){const l=e[`${n}Data`];if(l!==void 0?i(l,t):i(t),t.cancelBubble)return}e=e.host&&e.host!==e&&e.host instanceof Node?e.host:e.parentNode}}function U(t,n,e={},i,l){return n||(n={}),!l&&"children"in n&&g(()=>e.children=E(t,n.children,e.children)),n.ref&&n.ref(t),g(()=>Se(t,n,i,!0,e,!0)),e}function E(t,n,e,i,l){for(y.context&&!e&&(e=[...t.childNodes]);typeof e=="function";)e=e();if(n===e)return e;const s=typeof n,a=i!==void 0;if(t=a&&e[0]&&e[0].parentNode||t,s==="string"||s==="number"){if(y.context)return e;if(s==="number"&&(n=n.toString()),a){let o=e[0];o&&o.nodeType===3?o.data=n:o=document.createTextNode(n),e=h(t,e,i,o)}else e!==""&&typeof e=="string"?e=t.firstChild.data=n:e=t.textContent=n}else if(n==null||s==="boolean"){if(y.context)return e;e=h(t,e,i)}else{if(s==="function")return g(()=>{let o=n();for(;typeof o=="function";)o=o();e=E(t,o,e,i)}),()=>e;if(Array.isArray(n)){const o=[];if($(o,n,l))return g(()=>e=E(t,o,e,i,!0)),()=>e;if(y.context){for(let r=0;r<o.length;r++)if(o[r].parentNode)return e=o}if(o.length===0){if(e=h(t,e,i),a)return e}else Array.isArray(e)?e.length===0?L(t,o,i):fe(t,e,o):(e&&h(t),L(t,o));e=o}else if(n instanceof Node){if(y.context&&n.parentNode)return e=a?[n]:n;if(Array.isArray(e)){if(a)return e=h(t,e,i,n);h(t,e,null,n)}else e==null||e===""||!t.firstChild?t.appendChild(n):t.replaceChild(n,t.firstChild);e=n}}return e}function $(t,n,e){let i=!1;for(let l=0,s=n.length;l<s;l++){let a=n[l],o;if(a instanceof Node)t.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))i=$(t,a)||i;else if((o=typeof a)=="string")t.push(document.createTextNode(a));else if(o==="function")if(e){for(;typeof a=="function";)a=a();i=$(t,Array.isArray(a)?a:[a])||i}else t.push(a),i=!0;else t.push(document.createTextNode(a.toString()))}return i}function L(t,n,e){for(let i=0,l=n.length;i<l;i++)t.insertBefore(n[i],e)}function h(t,n,e,i){if(e===void 0)return t.textContent="";const l=i||document.createTextNode("");if(n.length){let s=!1;for(let a=n.length-1;a>=0;a--){const o=n[a];if(l!==o){const r=o.parentNode===t;!s&&!a?r?t.replaceChild(l,o):t.insertBefore(l,e):r&&o.remove()}else s=!0}}else t.insertBefore(l,e);return[l]}N();x();var P=t=>new Uint8Array(Buffer.from(t,"base64")),J=(t,n,e)=>new R.Algodv2(t,n,e),M={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},Ne=async(t,n,e,i,l,s=M)=>{try{const a=await t.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const o=await t.compile(i).do(),r=await t.compile(l).do(),_=R.makeApplicationCreateTxnFromObject({suggestedParams:a,from:n,onComplete:R.OnApplicationComplete.NoOpOC,approvalProgram:P(o.result),clearProgram:P(r.result),...M,...s}),c=_.signTxn(P(e)),{txId:u}=await t.sendRawTransaction(c).do(),b=await R.waitForConfirmation(t,u,5),f=b["application-index"];return{suggestedParams:a,applicationStartCompiled:o,clearProgramCompiled:r,txn:_,txnSigned:c,txId:u,transactionResponse:b,appId:f}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}};const xe=`#pragma version 6
txn ApplicationID
int 0
==
bnz main_l34
txna ApplicationArgs 0
byte "SetupPlayers"
==
bnz main_l31
txna ApplicationArgs 0
byte "ActionMove"
==
global GroupSize
int 1
==
&&
bnz main_l13
txna ApplicationArgs 0
byte "MoneyRefund"
==
bnz main_l5
err
main_l5:
gtxn 1 TypeEnum
int pay
==
assert
gtxn 1 Sender
byte "FundsEscrowAddress"
app_global_get
==
assert
byte "GameState"
app_global_get
int 1
==
byte "GameState"
app_global_get
int 0
==
global LatestTimestamp
byte "ActionTimeout"
app_global_get
>
&&
byte "PlayerTurnAddress"
app_global_get
byte "PlayerOAddress"
app_global_get
==
&&
||
bnz main_l12
byte "GameState"
app_global_get
int 2
==
byte "GameState"
app_global_get
int 0
==
global LatestTimestamp
byte "ActionTimeout"
app_global_get
>
&&
byte "PlayerTurnAddress"
app_global_get
byte "PlayerXAddress"
app_global_get
==
&&
||
bnz main_l11
byte "GameState"
app_global_get
int 3
==
bnz main_l9
err
main_l9:
gtxn 1 Receiver
byte "PlayerXAddress"
app_global_get
==
assert
gtxn 1 Amount
byte "BetAmount"
app_global_get
==
assert
gtxn 2 TypeEnum
int pay
==
assert
gtxn 2 Sender
byte "FundsEscrowAddress"
app_global_get
==
assert
gtxn 2 Receiver
byte "PlayerOAddress"
app_global_get
==
assert
gtxn 2 Amount
byte "BetAmount"
app_global_get
==
assert
main_l10:
int 1
return
main_l11:
gtxn 1 Receiver
byte "PlayerOAddress"
app_global_get
==
assert
gtxn 1 Amount
int 2
byte "BetAmount"
app_global_get
*
==
assert
byte "GameState"
int 2
app_global_put
b main_l10
main_l12:
gtxn 1 Receiver
byte "PlayerXAddress"
app_global_get
==
assert
gtxn 1 Amount
int 2
byte "BetAmount"
app_global_get
*
==
assert
byte "GameState"
int 1
app_global_put
b main_l10
main_l13:
txna ApplicationArgs 1
btoi
int 0
>=
assert
txna ApplicationArgs 1
btoi
int 8
<=
assert
global LatestTimestamp
byte "ActionTimeout"
app_global_get
<=
assert
byte "GameState"
app_global_get
int 0
==
assert
txn Sender
byte "PlayerTurnAddress"
app_global_get
==
assert
byte "PlayerXState"
app_global_get
int 1
txna ApplicationArgs 1
btoi
shl
&
int 0
==
byte "PlayerOState"
app_global_get
int 1
txna ApplicationArgs 1
btoi
shl
&
int 0
==
&&
assert
txn Sender
byte "PlayerXAddress"
app_global_get
==
bnz main_l25
txn Sender
byte "PlayerOAddress"
app_global_get
==
bnz main_l16
err
main_l16:
byte "PlayerOState"
byte "PlayerOState"
app_global_get
int 1
txna ApplicationArgs 1
btoi
shl
|
app_global_put
byte "PlayerOState"
app_global_get
int 448
&
int 448
==
byte "PlayerOState"
app_global_get
int 56
&
int 56
==
||
byte "PlayerOState"
app_global_get
int 7
&
int 7
==
||
byte "PlayerOState"
app_global_get
int 292
&
int 292
==
||
byte "PlayerOState"
app_global_get
int 146
&
int 146
==
||
byte "PlayerOState"
app_global_get
int 73
&
int 73
==
||
byte "PlayerOState"
app_global_get
int 273
&
int 273
==
||
byte "PlayerOState"
app_global_get
int 84
&
int 84
==
||
bnz main_l24
int 0
main_l18:
bnz main_l23
main_l19:
byte "PlayerTurnAddress"
byte "PlayerXAddress"
app_global_get
app_global_put
main_l20:
int 511
byte "PlayerXState"
app_global_get
byte "PlayerOState"
app_global_get
|
==
bnz main_l22
main_l21:
int 1
return
main_l22:
byte "GameState"
int 3
app_global_put
b main_l21
main_l23:
byte "GameState"
int 2
app_global_put
b main_l19
main_l24:
int 1
b main_l18
main_l25:
byte "PlayerXState"
byte "PlayerXState"
app_global_get
int 1
txna ApplicationArgs 1
btoi
shl
|
app_global_put
byte "PlayerXState"
app_global_get
int 448
&
int 448
==
byte "PlayerXState"
app_global_get
int 56
&
int 56
==
||
byte "PlayerXState"
app_global_get
int 7
&
int 7
==
||
byte "PlayerXState"
app_global_get
int 292
&
int 292
==
||
byte "PlayerXState"
app_global_get
int 146
&
int 146
==
||
byte "PlayerXState"
app_global_get
int 73
&
int 73
==
||
byte "PlayerXState"
app_global_get
int 273
&
int 273
==
||
byte "PlayerXState"
app_global_get
int 84
&
int 84
==
||
bnz main_l30
int 0
main_l27:
bnz main_l29
main_l28:
byte "PlayerTurnAddress"
byte "PlayerOAddress"
app_global_get
app_global_put
b main_l20
main_l29:
byte "GameState"
int 1
app_global_put
b main_l28
main_l30:
int 1
b main_l27
main_l31:
int 0
byte "PlayerXAddress"
app_global_get_ex
store 1
store 0
int 0
byte "PlayerOAddress"
app_global_get_ex
store 3
store 2
load 1
load 3
||
bnz main_l33
gtxn 1 TypeEnum
int pay
==
assert
gtxn 2 TypeEnum
int pay
==
assert
gtxn 1 Receiver
gtxn 2 Receiver
==
assert
gtxn 1 Amount
byte "BetAmount"
app_global_get
==
assert
gtxn 2 Amount
byte "BetAmount"
app_global_get
==
assert
byte "PlayerXAddress"
gtxn 1 Sender
app_global_put
byte "PlayerOAddress"
gtxn 2 Sender
app_global_put
byte "PlayerTurnAddress"
gtxn 1 Sender
app_global_put
byte "FundsEscrowAddress"
gtxn 1 Receiver
app_global_put
byte "ActionTimeout"
global LatestTimestamp
int 3600
+
app_global_put
int 1
return
main_l33:
int 0
return
main_l34:
byte "PlayerXState"
int 0
app_global_put
byte "PlayerOState"
int 0
app_global_put
byte "GameState"
int 0
app_global_put
byte "BetAmount"
int 1000000
app_global_put
int 1
return`,Re=`#pragma version 6
int 1
return`;var we="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",Pe="http://localhost",ve=4001,$e=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}],ke=5,Ce=4;N();x();N();x();N();x();var Ie=m('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),De=m("<title></title>");function Ge(t,n){return(()=>{const e=Ie.cloneNode(!0);return G(e,()=>t.a,!0,!0),G(e,n,!0,!0),d(e,()=>t.c,null),d(e,(()=>{const i=V(()=>!!n.title,!0);return()=>i()&&(()=>{const l=De.cloneNode(!0);return d(l,()=>n.title),l})()})(),null),g(i=>{const l=t.a.stroke,s={...n.style,overflow:"visible",color:n.color},a=n.size||"1em",o=n.size||"1em",r=t.c;return l!==i._v$&&w(e,"stroke",i._v$=l),i._v$2=z(e,s,i._v$2),a!==i._v$3&&w(e,"height",i._v$3=a),o!==i._v$4&&w(e,"width",i._v$4=o),r!==i._v$5&&(e.innerHTML=i._v$5=r),i},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),e})()}function He(t){return Ge({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},t)}const Be="_App_sggzw_1",Ue="_TestnetBankContainer_sggzw_51",W={App:Be,TestnetBankContainer:Ue},Y=m('<input type="text">'),Le=m("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),Me=m("<table><tbody><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),Xe=m("<table><tbody></tbody></table>"),Ke=m("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),Fe=m("<div><div>Deploy:</div><pre></pre><button>Deploy</button></div>"),Ve=m("<div><pre></pre><button>Request</button></div>"),je=m("<div><button></button></div>"),ze=m('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),Je=m('<table><tbody><tr><td><a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">https://github.com/fc1943s/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">https://fc1943s.github.io/tictactoe_spiral</a></td></tr></tbody></table>'),We=m("<div><table><tbody><tr><td>Chain Connection</td><td></td></tr><tr><td>Database Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Game</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr><tr><td>Links</td><td></td></tr></tbody></table></div>"),A={npm_package_scripts_outdated_pre:"ncu --pre 1 -t greatest",DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_package_devDependencies__esbuild_plugins_node_globals_polyfill:"^0.1",npm_config_user_agent:"pnpm/6.33.0 npm/? node/v16.15.1 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_23c95d10-8470-4c04-b79e-ea01fe0b2cd7",PIPX_HOME:"/opt/pipx",npm_package_devDependencies_vite:"^3.0.0-beta.6",npm_node_execpath:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"",npm_package_scripts_playwright_install:"playwright install --with-deps && playwright install msedge",npm_package_scripts_serve:"vite preview",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",npm_package_dependencies_rusty_gun:"^0.1.2",npm_package_devDependencies_typescript:"^4.7",NVM_DIR:"/home/runner/.nvm",npm_package_devDependencies_playwright_core:"^1.22",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220626.1",npm_package_scripts_dev:"vite",npm_package_devDependencies__playwright_test:"^1.22",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",npm_package_dependencies_solid_js:"^1.4",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22588",GITHUB_WORKFLOW:"E2E + A11y Tests",_:"/home/runner/setup-pnpm/node_modules/.bin/pnpm",npm_package_dependencies_storeon:"^3.1",npm_config_registry:"https://registry.npmjs.org/",GITHUB_RUN_ID:"2633580231",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",npm_package_dependencies_algosdk:"^1.18",npm_package_devDependencies_path_browserify:"^1.0",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"",ImageOS:"ubuntu20",npm_package_scripts_start:"vite",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"",npm_config_node_gyp:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node_modules/node-gyp/bin/node-gyp.js",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node-gyp-bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.15.1/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_279fe1e6-d8c3-4771-bd26-fc4a4dc84752",INVOCATION_ID:"5f9a61cbde8f46b1a9a5e1ae5c60f72a",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",npm_package_name:"tictactoe_spiral_web",npm_package_scripts_extension:"vite build --outDir dist_extension && mkdir ./dist_extension/tictactoe_spiral && mv ./dist_extension/assets/content_script.*.js ./dist_extension/assets/content_script.js && mv ./dist_extension/assets/App.*.css ./dist_extension/assets/App.css && mv ./dist_extension/assets ./dist_extension/tictactoe_spiral/assets && cp background.js content_script.js ./dist_extension",NODE:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",GITHUB_ACTION:"__run_3",GITHUB_RUN_NUMBER:"12",RUNNER_ARCH:"X64",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",npm_package_dependencies_solid_icons:"^0.5",npm_package_devDependencies_axe_playwright:"^1.1",npm_package_devDependencies_vite_plugin_solid:"^2.2",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",npm_package_scripts_e2e:"playwright test",npm_lifecycle_script:"vite build --outDir dist",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",STATS_PFS:"true",NODE_PATH:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/node_modules:/home/runner/setup-pnpm/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",npm_package_version:"0.0.1",npm_package_devDependencies_npm_check_updates:"^15.0",npm_lifecycle_event:"build",GITHUB_REF_PROTECTED:"false",npm_package_scripts_build:"vite build --outDir dist",npm_package_dependencies_buffer:"^6.0",npm_config_argv:'{"remain":["run","build"],"cooked":["run","build"],"original":["run","build"]}',GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"e90783c2249338173f1114c0b03c04c48aea688f",GITHUB_RUN_ATTEMPT:"1",npm_package_dependencies__storeon_solidjs:"^3.0",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_23c95d10-8470-4c04-b79e-ea01fe0b2cd7",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",npm_package_devDependencies_esbuild_plugin_wasm:"^1.0.0",npm_execpath:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/pnpm.cjs",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",npm_package_devDependencies_esbuild:"^0.14",PNPM_SCRIPT_SRC_DIR:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_23c95d10-8470-4c04-b79e-ea01fe0b2cd7",INIT_CWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",NODE_ENV:"production"}.CODESPACE_NAME,Ye={token:we,chainUrl:A?`http://${A}-4001.githubpreview.dev`:Pe,chainPort:A?80:ve,dbUrl:A?`ws://${A}-8765.githubpreview.dev`:"ws://localhost",dbPort:A?80:8765,accounts:$e,status:{},deploy:{}},Qe=oe([t=>{t.on("@init",()=>Ye),t.on("set",(n,e)=>e)}]);function T({key:t}){const[n,e]=O();return(()=>{const i=Y.cloneNode(!0);return i.$$input=l=>e("set",{[t]:l.currentTarget.value}),g(()=>i.value=n[t]),i})()}function qe(){return(()=>{const t=Le.cloneNode(!0),n=t.firstChild,e=n.firstChild,i=e.firstChild,l=i.nextSibling,s=e.nextSibling,a=s.firstChild,o=a.nextSibling,r=s.nextSibling,_=r.firstChild,c=_.nextSibling;return d(l,p(T,{key:"token"})),d(o,p(T,{key:"chainUrl"})),d(c,p(T,{key:"chainPort"})),t})()}function Ze(){return(()=>{const t=Me.cloneNode(!0),n=t.firstChild,e=n.firstChild,i=e.firstChild,l=i.nextSibling,s=e.nextSibling,a=s.firstChild,o=a.nextSibling;return d(l,p(T,{key:"dbUrl"})),d(o,p(T,{key:"dbPort"})),t})()}function X({key:t,account:n}){const[e,i]=O();return(()=>{const l=Y.cloneNode(!0);return l.$$input=s=>i("set",{accounts:e.accounts.map(a=>a.alias===n.alias?{...a,[t]:s.currentTarget.value}:a)}),g(()=>l.value=n[t]),l})()}function en(){const[t]=O();return(()=>{const n=Xe.cloneNode(!0),e=n.firstChild;return d(e,p(re,{get each(){return t.accounts},children:i=>(()=>{const l=Ke.cloneNode(!0),s=l.firstChild,a=s.nextSibling,o=a.firstChild,r=o.firstChild,_=r.firstChild,c=_.firstChild,u=c.nextSibling,b=_.nextSibling,f=b.firstChild,S=f.nextSibling;return d(s,()=>i.alias),d(u,p(X,{account:i,key:"address"})),d(S,p(X,{account:i,key:"privateKey"})),l})()})),n})()}function nn(){const[t,n]=O(),e=async()=>{const i=t.accounts[0]?.address,l=t.accounts[0]?.privateKey;if(i&&l){const s=J(t.token,t.chainUrl,t.chainPort);try{const a=await Ne(s,i,l,xe,Re,{numGlobalByteSlices:ke,numGlobalInts:Ce});n("set",{deploy:a})}catch(a){n("set",{deploy:a})}}else alert("Invalid admin account")};return(()=>{const i=Fe.cloneNode(!0),l=i.firstChild,s=l.nextSibling,a=s.nextSibling;return d(s,()=>JSON.stringify(t.deploy,null,2)),a.$$click=e,i})()}function tn(){const[t,n]=O(),[e,i]=v(null),[l,s]=v(-1);K(F(()=>[],()=>{console.log(`${t.dbUrl}:${t.dbPort}/gun`);const o=new de(`${t.dbUrl}:${t.dbPort}/gun`);i(o),setTimeout(()=>{o&&s(o.get("app").get("status").on((r,_)=>{n("set",{status:JSON.parse(r)})}))},1e3)})),_e(()=>{const o=e();o&&o.get("app").get("status").off(l())});const a=async()=>{const o=J(t.token,t.chainUrl,t.chainPort),r=e();try{const _=await o.status().do();n("set",{status:_}),r&&r.get("app").get("status").put(_)}catch(_){n("set",{status:_}),r&&r.get("app").get("status").put(_)}};return(()=>{const o=Ve.cloneNode(!0),r=o.firstChild,_=r.nextSibling;return d(r,()=>JSON.stringify(t.status,null,2)),_.$$click=a,o})()}function an(){const[t,n]=v(!1);return K(F(()=>[t()],()=>t()&&n(!1))),(()=>{const e=je.cloneNode(!0),i=e.firstChild;return i.$$click=()=>n(!0),d(i,p(He,{size:"24px"})),d(e,(()=>{const l=V(()=>!t(),!0);return()=>l()&&ze.cloneNode(!0)})(),null),g(()=>e.className=W.TestnetBankContainer),e})()}function ln(){return Je.cloneNode(!0)}function dn(){return p(se,{store:Qe,get children(){const t=We.cloneNode(!0),n=t.firstChild,e=n.firstChild,i=e.firstChild,l=i.firstChild,s=l.nextSibling,a=i.nextSibling,o=a.firstChild,r=o.nextSibling,_=a.nextSibling,c=_.firstChild,u=c.nextSibling,b=_.nextSibling,f=b.firstChild,S=f.nextSibling,k=b.nextSibling,Q=k.firstChild,q=Q.nextSibling,C=k.nextSibling,Z=C.firstChild,ee=Z.nextSibling,ne=C.nextSibling,te=ne.firstChild,ie=te.nextSibling;return d(s,p(qe,{})),d(r,p(Ze,{})),d(u,p(en,{})),d(S,p(tn,{})),d(q,p(nn,{})),d(ee,p(an,{})),d(ie,p(ln,{})),g(()=>t.className=W.App),t}})}j(["input","click"]);export{dn as A,_n as r};
