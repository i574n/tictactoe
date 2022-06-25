import{i as S,a as O,h as q,s as y,j as b,k as Q,l as Z,m as u,S as ee,u as E,n as U,o as M,F as ne,q as te}from"./solid.c72074b0.js";import{a as x,b as ie}from"./algosdk.5e772e3d.js";const oe=function(){const n=document.createElement("link").relList;if(n&&n.supports&&n.supports("modulepreload"))return;for(const o of document.querySelectorAll('link[rel="modulepreload"]'))i(o);new MutationObserver(o=>{for(const l of o)if(l.type==="childList")for(const a of l.addedNodes)a.tagName==="LINK"&&a.rel==="modulepreload"&&i(a)}).observe(document,{childList:!0,subtree:!0});function e(o){const l={};return o.integrity&&(l.integrity=o.integrity),o.referrerpolicy&&(l.referrerPolicy=o.referrerpolicy),o.crossorigin==="use-credentials"?l.credentials="include":o.crossorigin==="anonymous"?l.credentials="omit":l.credentials="same-origin",l}function i(o){if(o.ep)return;o.ep=!0;const l=e(o);fetch(o.href,l)}};oe();S();O();var ae=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],le=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...ae]),se=new Set(["innerHTML","textContent","innerText","children"]),re={className:"class",htmlFor:"for"},P={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},_e=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),de={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function X(t,n){return Q(t,void 0,n?void 0:{equals:n})}function ce(t,n,e){let i=e.length,o=n.length,l=i,a=0,s=0,r=n[o-1].nextSibling,_=null;for(;a<o||s<l;){if(n[a]===e[s]){a++,s++;continue}for(;n[o-1]===e[l-1];)o--,l--;if(o===a){const d=l<i?s?e[s-1].nextSibling:e[l-s]:r;for(;s<l;)t.insertBefore(e[s++],d)}else if(l===s)for(;a<o;)(!_||!_.has(n[a]))&&n[a].remove(),a++;else if(n[a]===e[l-1]&&e[s]===n[o-1]){const d=n[--o].nextSibling;t.insertBefore(e[s++],n[a++].nextSibling),t.insertBefore(e[--l],d),n[o]=e[l]}else{if(!_){_=new Map;let p=s;for(;p<l;)_.set(e[p],p++)}const d=_.get(n[a]);if(d!=null)if(s<d&&d<l){let p=a,m=1,f;for(;++p<o&&p<l&&!((f=_.get(n[p]))==null||f!==d+m);)m++;if(m>d-s){const T=n[a];for(;s<d;)t.insertBefore(e[s++],T)}else t.replaceChild(e[s++],n[a++])}else a++;else n[a++].remove()}}}var k="_$DX_DELEGATE";function pe(t,n,e){let i;return q(o=>{i=o,n===document?t():c(n,t(),n.firstChild?null:void 0,e)}),()=>{i(),n.textContent=""}}function g(t,n,e){const i=document.createElement("template");i.innerHTML=t;let o=i.content.firstChild;return e&&(o=o.firstChild),o}function F(t,n=window.document){const e=n[k]||(n[k]=new Set);for(let i=0,o=t.length;i<o;i++){const l=t[i];e.has(l)||(e.add(l),n.addEventListener(l,he))}}function N(t,n,e){e==null?t.removeAttribute(n):t.setAttribute(n,e)}function ue(t,n,e,i){i==null?t.removeAttributeNS(n,e):t.setAttributeNS(n,e,i)}function me(t,n){n==null?t.removeAttribute("class"):t.className=n}function be(t,n,e,i){i?Array.isArray(e)?(t[`$$${n}`]=e[0],t[`$$${n}Data`]=e[1]):t[`$$${n}`]=e:Array.isArray(e)?t.addEventListener(n,o=>e[0](e[1],o)):t.addEventListener(n,e)}function ge(t,n,e={}){const i=Object.keys(n||{}),o=Object.keys(e);let l,a;for(l=0,a=o.length;l<a;l++){const s=o[l];!s||s==="undefined"||n[s]||($(t,s,!1),delete e[s])}for(l=0,a=i.length;l<a;l++){const s=i[l],r=!!n[s];!s||s==="undefined"||e[s]===r||!r||($(t,s,!0),e[s]=r)}return e}function K(t,n,e={}){const i=t.style,o=typeof e=="string";if(n==null&&o||typeof n=="string")return i.cssText=n;o&&(i.cssText=void 0,e={}),n||(n={});let l,a;for(a in e)n[a]==null&&i.removeProperty(a),delete e[a];for(a in n)l=n[a],l!==e[a]&&(i.setProperty(a,l),e[a]=l);return e}function I(t,n,e,i){typeof n=="function"?b(o=>H(t,n(),o,e,i)):H(t,n,void 0,e,i)}function c(t,n,e,i){if(e!==void 0&&!i&&(i=[]),typeof n!="function")return A(t,n,i,e);b(o=>A(t,n(),o,e),i)}function fe(t,n,e,i,o={},l=!1){n||(n={});for(const a in o)if(!(a in n)){if(a==="children")continue;C(t,a,null,o[a],e,l)}for(const a in n){if(a==="children"){i||A(t,n.children);continue}const s=n[a];o[a]=C(t,a,s,o[a],e,l)}}function ye(t){return t.toLowerCase().replace(/-([a-z])/g,(n,e)=>e.toUpperCase())}function $(t,n,e){const i=n.trim().split(/\s+/);for(let o=0,l=i.length;o<l;o++)t.classList.toggle(i[o],e)}function C(t,n,e,i,o,l){let a,s,r;if(n==="style")return K(t,e,i);if(n==="classList")return ge(t,e,i);if(e===i)return i;if(n==="ref")l||e(t);else if(n.slice(0,3)==="on:")t.addEventListener(n.slice(3),e);else if(n.slice(0,10)==="oncapture:")t.addEventListener(n.slice(10),e,!0);else if(n.slice(0,2)==="on"){const _=n.slice(2).toLowerCase(),d=_e.has(_);be(t,_,e,d),d&&F([_])}else if((r=se.has(n))||!o&&(P[n]||(s=le.has(n)))||(a=t.nodeName.includes("-")))n==="class"||n==="className"?me(t,e):a&&!s&&!r?t[ye(n)]=e:t[P[n]||n]=e;else{const _=o&&n.indexOf(":")>-1&&de[n.split(":")[0]];_?ue(t,_,n,e):N(t,re[n]||n,e)}return e}function he(t){const n=`$$${t.type}`;let e=t.composedPath&&t.composedPath()[0]||t.target;for(t.target!==e&&Object.defineProperty(t,"target",{configurable:!0,value:e}),Object.defineProperty(t,"currentTarget",{configurable:!0,get(){return e||document}}),y.registry&&!y.done&&(y.done=!0,document.querySelectorAll("[id^=pl-]").forEach(i=>i.remove()));e!==null;){const i=e[n];if(i&&!e.disabled){const o=e[`${n}Data`];if(o!==void 0?i(o,t):i(t),t.cancelBubble)return}e=e.host&&e.host!==e&&e.host instanceof Node?e.host:e.parentNode}}function H(t,n,e={},i,o){return n||(n={}),!o&&"children"in n&&b(()=>e.children=A(t,n.children,e.children)),n.ref&&n.ref(t),b(()=>fe(t,n,i,!0,e,!0)),e}function A(t,n,e,i,o){for(y.context&&!e&&(e=[...t.childNodes]);typeof e=="function";)e=e();if(n===e)return e;const l=typeof n,a=i!==void 0;if(t=a&&e[0]&&e[0].parentNode||t,l==="string"||l==="number"){if(y.context)return e;if(l==="number"&&(n=n.toString()),a){let s=e[0];s&&s.nodeType===3?s.data=n:s=document.createTextNode(n),e=h(t,e,i,s)}else e!==""&&typeof e=="string"?e=t.firstChild.data=n:e=t.textContent=n}else if(n==null||l==="boolean"){if(y.context)return e;e=h(t,e,i)}else{if(l==="function")return b(()=>{let s=n();for(;typeof s=="function";)s=s();e=A(t,s,e,i)}),()=>e;if(Array.isArray(n)){const s=[];if(R(s,n,o))return b(()=>e=A(t,s,e,i,!0)),()=>e;if(y.context){for(let r=0;r<s.length;r++)if(s[r].parentNode)return e=s}if(s.length===0){if(e=h(t,e,i),a)return e}else Array.isArray(e)?e.length===0?B(t,s,i):ce(t,e,s):(e&&h(t),B(t,s));e=s}else if(n instanceof Node){if(y.context&&n.parentNode)return e=a?[n]:n;if(Array.isArray(e)){if(a)return e=h(t,e,i,n);h(t,e,null,n)}else e==null||e===""||!t.firstChild?t.appendChild(n):t.replaceChild(n,t.firstChild);e=n}}return e}function R(t,n,e){let i=!1;for(let o=0,l=n.length;o<l;o++){let a=n[o],s;if(a instanceof Node)t.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))i=R(t,a)||i;else if((s=typeof a)=="string")t.push(document.createTextNode(a));else if(s==="function")if(e){for(;typeof a=="function";)a=a();i=R(t,Array.isArray(a)?a:[a])||i}else t.push(a),i=!0;else t.push(document.createTextNode(a.toString()))}return i}function B(t,n,e){for(let i=0,o=n.length;i<o;i++)t.insertBefore(n[i],e)}function h(t,n,e,i){if(e===void 0)return t.textContent="";const o=i||document.createTextNode("");if(n.length){let l=!1;for(let a=n.length-1;a>=0;a--){const s=n[a];if(o!==s){const r=s.parentNode===t;!l&&!a?r?t.replaceChild(o,s):t.insertBefore(o,e):r&&s.remove()}else l=!0}}else t.insertBefore(o,e);return[o]}S();O();var w=t=>new Uint8Array(Buffer.from(t,"base64")),V=(t,n,e)=>new x.Algodv2(t,n,e),G={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},Ae=async(t,n,e,i,o,l=G)=>{try{const a=await t.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const s=await t.compile(i).do(),r=await t.compile(o).do(),_=x.makeApplicationCreateTxnFromObject({suggestedParams:a,from:n,onComplete:x.OnApplicationComplete.NoOpOC,approvalProgram:w(s.result),clearProgram:w(r.result),...G,...l}),d=_.signTxn(w(e)),{txId:p}=await t.sendRawTransaction(d).do(),m=await x.waitForConfirmation(t,p,5),f=m["application-index"];return{suggestedParams:a,applicationStartCompiled:s,clearProgramCompiled:r,txn:_,txnSigned:d,txId:p,transactionResponse:m,appId:f}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}};const Ee=`#pragma version 6
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
return`,Te=`#pragma version 6
int 1
return`;var Se="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",Oe="http://localhost",xe=4001,Ne=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}],we=5,ve=4;const Re="_App_1hsfq_1",Pe="_TestnetBankContainer_1hsfq_47",z={App:Re,TestnetBankContainer:Pe};S();O();S();O();S();O();var ke=g('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),Ie=g("<title></title>");function $e(t,n){return(()=>{const e=ke.cloneNode(!0);return I(e,()=>t.a,!0,!0),I(e,n,!0,!0),c(e,(()=>{const i=X(()=>!!n.title,!0);return()=>i()&&(()=>{const o=Ie.cloneNode(!0);return c(o,()=>n.title),o})()})()),b(i=>{const o=t.a.stroke,l={...n.style,overflow:"visible",color:n.color},a=n.size||"1em",s=n.size||"1em",r=t.c;return o!==i._v$&&N(e,"stroke",i._v$=o),i._v$2=K(e,l,i._v$2),a!==i._v$3&&N(e,"height",i._v$3=a),s!==i._v$4&&N(e,"width",i._v$4=s),r!==i._v$5&&(e.innerHTML=i._v$5=r),i},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),e})()}function Ce(t){return $e({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},t)}const j=g('<input type="text">'),He=g("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>Server</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),Be=g("<table><tbody></tbody></table>"),Ge=g("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),De=g("<div><div>Deploy:</div><pre></pre><button>Deploy</button></div>"),Le=g("<div><pre></pre><button>Request</button></div>"),Ue=g("<div><button></button></div>"),Me=g('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),Xe=g("<div><table><tbody><tr><td>Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Game</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr></tbody></table></div>"),Fe={token:Se,server:Oe,port:xe,accounts:Ne,status:{},deploy:{}},Ke=Z([t=>{t.on("@init",()=>Fe),t.on("set",(n,e)=>e)}]);function v({key:t}){const[n,e]=E();return(()=>{const i=j.cloneNode(!0);return i.$$input=o=>e("set",{[t]:o.currentTarget.value}),b(()=>i.value=n[t]),i})()}const D={npm_package_scripts_outdated_pre:"ncu --pre 1 -t greatest",DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_package_devDependencies__esbuild_plugins_node_globals_polyfill:"^0.1",npm_config_user_agent:"pnpm/6.32.24 npm/? node/v16.15.1 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_b1433b74-81c2-42a6-a740-e3127e8e1fe1",PIPX_HOME:"/opt/pipx",npm_package_devDependencies_vite:"^3.0.0-beta.1",npm_node_execpath:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"",npm_package_scripts_playwright_install:"playwright install --with-deps && playwright install msedge",npm_package_scripts_serve:"vite preview",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",npm_package_devDependencies_typescript:"^4.7",NVM_DIR:"/home/runner/.nvm",npm_package_devDependencies_playwright_core:"^1.22",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220619.1",npm_package_scripts_dev:"vite",npm_package_devDependencies__playwright_test:"^1.22",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",npm_package_dependencies_solid_js:"^1.4",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22876",GITHUB_WORKFLOW:"E2E + A11y Tests",_:"/home/runner/setup-pnpm/node_modules/.bin/pnpm",npm_package_dependencies_storeon:"^3.1",npm_config_registry:"https://registry.npmjs.org/",GITHUB_RUN_ID:"2561608482",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",npm_package_dependencies_algosdk:"^1.18",npm_package_devDependencies_path_browserify:"^1.0",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"",ImageOS:"ubuntu20",npm_package_scripts_start:"vite",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"",npm_config_node_gyp:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules/pnpm/dist/node_modules/node-gyp/bin/node-gyp.js",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules/pnpm/dist/node-gyp-bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.15.1/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_dd99fbaf-1fd7-4fc0-a556-a76745d83afd",INVOCATION_ID:"9dc4b9674ab94c0bac216eb27fbeccb3",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",npm_package_name:"tictactoe_spiral_web",npm_package_scripts_extension:"rm -rf ./dist_extension && cp -r ./dist ./dist_extension && mkdir ./dist_extension/tictactoe_spiral && mv ./dist_extension/assets ./dist_extension/tictactoe_spiral/assets",NODE:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",GITHUB_ACTION:"__run_3",GITHUB_RUN_NUMBER:"9",RUNNER_ARCH:"X64",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",npm_package_dependencies_solid_icons:"^0.4",npm_package_devDependencies_axe_playwright:"^1.1",npm_package_devDependencies_vite_plugin_solid:"^2.2",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",npm_package_scripts_e2e:"playwright test",npm_lifecycle_script:"vite build",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",STATS_PFS:"true",NODE_PATH:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules/pnpm/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/node_modules:/home/runner/setup-pnpm/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.1/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.1/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.1/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",npm_package_version:"0.0.1",npm_package_devDependencies_npm_check_updates:"^14.1",npm_lifecycle_event:"build",GITHUB_REF_PROTECTED:"false",npm_package_scripts_build:"vite build",npm_package_dependencies_buffer:"^6.0",npm_config_argv:'{"remain":["run","build"],"cooked":["run","build"],"original":["run","build"]}',GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"f7e71f3fce35feb431176295ddc466beaca830bf",GITHUB_RUN_ATTEMPT:"1",npm_package_dependencies__storeon_solidjs:"^3.0",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_b1433b74-81c2-42a6-a740-e3127e8e1fe1",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",npm_execpath:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.32.24/node_modules/pnpm/bin/pnpm.cjs",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",npm_package_devDependencies_esbuild:"^0.14",PNPM_SCRIPT_SRC_DIR:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_b1433b74-81c2-42a6-a740-e3127e8e1fe1",INIT_CWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",NODE_ENV:"production"}.CODESPACE_NAME;function Ve(){const[t,n]=E();return U(M(()=>[],()=>{D&&n("set",{server:`http://${D}-4001.githubpreview.dev`,port:80})})),(()=>{const e=He.cloneNode(!0),i=e.firstChild,o=i.firstChild,l=o.firstChild,a=l.nextSibling,s=o.nextSibling,r=s.firstChild,_=r.nextSibling,d=s.nextSibling,p=d.firstChild,m=p.nextSibling;return c(a,u(v,{key:"token"})),c(_,u(v,{key:"server"})),c(m,u(v,{key:"port"})),e})()}function L({key:t,account:n}){const[e,i]=E();return(()=>{const o=j.cloneNode(!0);return o.$$input=l=>i("set",{accounts:e.accounts.map(a=>a.alias===n.alias?{...a,[t]:l.currentTarget.value}:a)}),b(()=>o.value=n[t]),o})()}function ze(){const[t]=E();return(()=>{const n=Be.cloneNode(!0),e=n.firstChild;return c(e,u(ne,{get each(){return t.accounts},children:i=>(()=>{const o=Ge.cloneNode(!0),l=o.firstChild,a=l.nextSibling,s=a.firstChild,r=s.firstChild,_=r.firstChild,d=_.firstChild,p=d.nextSibling,m=_.nextSibling,f=m.firstChild,T=f.nextSibling;return c(l,()=>i.alias),c(p,u(L,{account:i,key:"address"})),c(T,u(L,{account:i,key:"privateKey"})),o})()})),n})()}const je=()=>{const[t,n]=E(),e=async()=>{const i=t.accounts[0]?.address,o=t.accounts[0]?.privateKey;if(i&&o){const l=V(t.token,t.server,t.port);try{const a=await Ae(l,i,o,Ee,Te,{numGlobalByteSlices:we,numGlobalInts:ve});n("set",{deploy:a})}catch(a){n("set",{deploy:a})}}else alert("Invalid admin account")};return(()=>{const i=De.cloneNode(!0),o=i.firstChild,l=o.nextSibling,a=l.nextSibling;return c(l,()=>JSON.stringify(t.deploy,null,2)),a.$$click=e,i})()},Je=()=>{const[t,n]=E(),e=async()=>{const i=V(t.token,t.server,t.port);try{const o=await i.status().do();n("set",{status:o})}catch(o){n("set",{status:o})}};return(()=>{const i=Le.cloneNode(!0),o=i.firstChild,l=o.nextSibling;return c(o,()=>JSON.stringify(t.status,null,2)),l.$$click=e,i})()},We=()=>{const[t,n]=te(!1);return U(M(()=>[t()],()=>t()&&n(!1))),(()=>{const e=Ue.cloneNode(!0),i=e.firstChild;return i.$$click=()=>n(!0),c(i,u(Ce,{size:"24px"})),c(e,(()=>{const o=X(()=>!t(),!0);return()=>o()&&Me.cloneNode(!0)})(),null),b(()=>e.className=z.TestnetBankContainer),e})()},Ye=()=>u(ee,{store:Ke,get children(){const t=Xe.cloneNode(!0),n=t.firstChild,e=n.firstChild,i=e.firstChild,o=i.firstChild,l=o.nextSibling,a=i.nextSibling,s=a.firstChild,r=s.nextSibling,_=a.nextSibling,d=_.firstChild,p=d.nextSibling,m=_.nextSibling,f=m.firstChild,T=f.nextSibling,J=m.nextSibling,W=J.firstChild,Y=W.nextSibling;return c(l,u(Ve,{})),c(r,u(ze,{})),c(p,u(Je,{})),c(T,u(je,{})),c(Y,u(We,{})),b(()=>t.className=z.App),t}});F(["input","click"]);pe(()=>u(Ye,{}),document.getElementById("root"));const qe=ie.Buffer;window.Buffer=qe;
