import{i as q,a as Y,k as Nt,s as W,l as V,m as Rt,f as Pt,h as It,n as Gt,j as J,S as Ct,u as ot,F as Bt,o as it,q as wt,r as $t,t as Ht}from"./solid.7102f897.js";import{a as lt}from"./algosdk.e8b6bf43.js";import{N as Ut}from"./gun.341640a9.js";q();Y();var Mt=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],Lt=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...Mt]),Jt=new Set(["innerHTML","textContent","innerText","children"]),Xt={className:"class",htmlFor:"for"},bt={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},Ft=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),Kt={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function st(b,_){return Rt(b,void 0,_?void 0:{equals:_})}function Vt(b,_,n){let f=n.length,w=_.length,e=f,a=0,o=0,g=_[w-1].nextSibling,y=null;for(;a<w||o<e;){if(_[a]===n[o]){a++,o++;continue}for(;_[w-1]===n[e-1];)w--,e--;if(w===a){const h=e<f?o?n[o-1].nextSibling:n[e-o]:g;for(;o<e;)b.insertBefore(n[o++],h)}else if(e===o)for(;a<w;)(!y||!y.has(_[a]))&&_[a].remove(),a++;else if(_[a]===n[e-1]&&n[o]===_[w-1]){const h=_[--w].nextSibling;b.insertBefore(n[o++],_[a++].nextSibling),b.insertBefore(n[--e],h),_[w]=n[e]}else{if(!y){y=new Map;let s=o;for(;s<e;)y.set(n[s],s++)}const h=y.get(_[a]);if(h!=null)if(o<h&&h<e){let s=a,l=1,k;for(;++s<w&&s<e&&!((k=y.get(_[s]))==null||k!==h+l);)l++;if(l>h-o){const D=_[a];for(;o<h;)b.insertBefore(n[o++],D)}else b.replaceChild(n[o++],_[a++])}else a++;else _[a++].remove()}}}var gt="_$DX_DELEGATE";function Ln(b,_,n){let f;return Nt(w=>{f=w,_===document?b():L(_,b(),_.firstChild?null:void 0,n)}),()=>{f(),_.textContent=""}}function F(b,_,n){const f=document.createElement("template");f.innerHTML=b;let w=f.content.firstChild;return n&&(w=w.firstChild),w}function xt(b,_=window.document){const n=_[gt]||(_[gt]=new Set);for(let f=0,w=b.length;f<w;f++){const e=b[f];n.has(e)||(n.add(e),_.addEventListener(e,tn))}}function ft(b,_,n){n==null?b.removeAttribute(_):b.setAttribute(_,n)}function Wt(b,_,n,f){f==null?b.removeAttributeNS(_,n):b.setAttributeNS(_,n,f)}function zt(b,_){_==null?b.removeAttribute("class"):b.className=_}function qt(b,_,n,f){f?Array.isArray(n)?(b[`$$${_}`]=n[0],b[`$$${_}Data`]=n[1]):b[`$$${_}`]=n:Array.isArray(n)?b.addEventListener(_,w=>n[0](n[1],w)):b.addEventListener(_,n)}function Yt(b,_,n={}){const f=Object.keys(_||{}),w=Object.keys(n);let e,a;for(e=0,a=w.length;e<a;e++){const o=w[e];!o||o==="undefined"||_[o]||(mt(b,o,!1),delete n[o])}for(e=0,a=f.length;e<a;e++){const o=f[e],g=!!_[o];!o||o==="undefined"||n[o]===g||!g||(mt(b,o,!0),n[o]=g)}return n}function Ot(b,_,n={}){const f=b.style,w=typeof n=="string";if(_==null&&w||typeof _=="string")return f.cssText=_;w&&(f.cssText=void 0,n={}),_||(_={});let e,a;for(a in n)_[a]==null&&f.removeProperty(a),delete n[a];for(a in _)e=_[a],e!==n[a]&&(f.setProperty(a,e),n[a]=e);return n}function yt(b,_,n,f){typeof _=="function"?V(w=>kt(b,_(),w,n,f)):kt(b,_,void 0,n,f)}function L(b,_,n,f){if(n!==void 0&&!f&&(f=[]),typeof _!="function")return nt(b,_,f,n);V(w=>nt(b,_(),w,n),f)}function Qt(b,_,n,f,w={},e=!1){_||(_={});for(const a in w)if(!(a in _)){if(a==="children")continue;vt(b,a,null,w[a],n,e)}for(const a in _){if(a==="children"){f||nt(b,_.children);continue}const o=_[a];w[a]=vt(b,a,o,w[a],n,e)}}function Zt(b){return b.toLowerCase().replace(/-([a-z])/g,(_,n)=>n.toUpperCase())}function mt(b,_,n){const f=_.trim().split(/\s+/);for(let w=0,e=f.length;w<e;w++)b.classList.toggle(f[w],n)}function vt(b,_,n,f,w,e){let a,o,g;if(_==="style")return Ot(b,n,f);if(_==="classList")return Yt(b,n,f);if(n===f)return f;if(_==="ref")e||n(b);else if(_.slice(0,3)==="on:")b.addEventListener(_.slice(3),n);else if(_.slice(0,10)==="oncapture:")b.addEventListener(_.slice(10),n,!0);else if(_.slice(0,2)==="on"){const y=_.slice(2).toLowerCase(),h=Ft.has(y);qt(b,y,n,h),h&&xt([y])}else if((g=Jt.has(_))||!w&&(bt[_]||(o=Lt.has(_)))||(a=b.nodeName.includes("-")))_==="class"||_==="className"?zt(b,n):a&&!o&&!g?b[Zt(_)]=n:b[bt[_]||_]=n;else{const y=w&&_.indexOf(":")>-1&&Kt[_.split(":")[0]];y?Wt(b,y,_,n):ft(b,Xt[_]||_,n)}return n}function tn(b){const _=`$$${b.type}`;let n=b.composedPath&&b.composedPath()[0]||b.target;for(b.target!==n&&Object.defineProperty(b,"target",{configurable:!0,value:n}),Object.defineProperty(b,"currentTarget",{configurable:!0,get(){return n||document}}),W.registry&&!W.done&&(W.done=!0,document.querySelectorAll("[id^=pl-]").forEach(f=>f.remove()));n!==null;){const f=n[_];if(f&&!n.disabled){const w=n[`${_}Data`];if(w!==void 0?f(w,b):f(b),b.cancelBubble)return}n=n.host&&n.host!==n&&n.host instanceof Node?n.host:n.parentNode}}function kt(b,_,n={},f,w){return _||(_={}),!w&&"children"in _&&V(()=>n.children=nt(b,_.children,n.children)),_.ref&&_.ref(b),V(()=>Qt(b,_,f,!0,n,!0)),n}function nt(b,_,n,f,w){for(W.context&&!n&&(n=[...b.childNodes]);typeof n=="function";)n=n();if(_===n)return n;const e=typeof _,a=f!==void 0;if(b=a&&n[0]&&n[0].parentNode||b,e==="string"||e==="number"){if(W.context)return n;if(e==="number"&&(_=_.toString()),a){let o=n[0];o&&o.nodeType===3?o.data=_:o=document.createTextNode(_),n=Z(b,n,f,o)}else n!==""&&typeof n=="string"?n=b.firstChild.data=_:n=b.textContent=_}else if(_==null||e==="boolean"){if(W.context)return n;n=Z(b,n,f)}else{if(e==="function")return V(()=>{let o=_();for(;typeof o=="function";)o=o();n=nt(b,o,n,f)}),()=>n;if(Array.isArray(_)){const o=[];if(dt(o,_,w))return V(()=>n=nt(b,o,n,f,!0)),()=>n;if(W.context){for(let g=0;g<o.length;g++)if(o[g].parentNode)return n=o}if(o.length===0){if(n=Z(b,n,f),a)return n}else Array.isArray(n)?n.length===0?Tt(b,o,f):Vt(b,n,o):(n&&Z(b),Tt(b,o));n=o}else if(_ instanceof Node){if(W.context&&_.parentNode)return n=a?[_]:_;if(Array.isArray(n)){if(a)return n=Z(b,n,f,_);Z(b,n,null,_)}else n==null||n===""||!b.firstChild?b.appendChild(_):b.replaceChild(_,b.firstChild);n=_}}return n}function dt(b,_,n){let f=!1;for(let w=0,e=_.length;w<e;w++){let a=_[w],o;if(a instanceof Node)b.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))f=dt(b,a)||f;else if((o=typeof a)=="string")b.push(document.createTextNode(a));else if(o==="function")if(n){for(;typeof a=="function";)a=a();f=dt(b,Array.isArray(a)?a:[a])||f}else b.push(a),f=!0;else b.push(document.createTextNode(a.toString()))}return f}function Tt(b,_,n){for(let f=0,w=_.length;f<w;f++)b.insertBefore(_[f],n)}function Z(b,_,n,f){if(n===void 0)return b.textContent="";const w=f||document.createTextNode("");if(_.length){let e=!1;for(let a=_.length-1;a>=0;a--){const o=_[a];if(w!==o){const g=o.parentNode===b;!e&&!a?g?b.replaceChild(w,o):b.insertBefore(w,n):g&&o.remove()}else e=!0}}else b.insertBefore(w,n);return[w]}q();Y();var ct=b=>new Uint8Array(Buffer.from(b,"base64")),Et=(b,_,n)=>new lt.Algodv2(b,_,n),St={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},nn=async(b,_,n,f,w,e=St)=>{try{const a=await b.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const o=await b.compile(f).do(),g=await b.compile(w).do(),y=lt.makeApplicationCreateTxnFromObject({suggestedParams:a,from:_,onComplete:lt.OnApplicationComplete.NoOpOC,approvalProgram:ct(o.result),clearProgram:ct(g.result),...St,...e}),h=y.signTxn(ct(n)),{txId:s}=await b.sendRawTransaction(h).do(),l=await lt.waitForConfirmation(b,s,5),k=l["application-index"];return{suggestedParams:a,applicationStartCompiled:o,clearProgramCompiled:g,txn:y,txnSigned:h,txId:s,transactionResponse:l,appId:k}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}};const en=`#pragma version 6
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
return`,rn=`#pragma version 6
int 1
return`;var on="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",an="http://localhost",un=4001,ln=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}],sn=5,fn=4;q();Y();q();Y();q();Y();var cn=F('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),pn=F("<title></title>");function dn(b,_){return(()=>{const n=cn.cloneNode(!0);return yt(n,()=>b.a,!0,!0),yt(n,_,!0,!0),L(n,()=>b.c,null),L(n,(()=>{const f=st(()=>!!_.title,!0);return()=>f()&&(()=>{const w=pn.cloneNode(!0);return L(w,()=>_.title),w})()})(),null),V(f=>{const w=b.a.stroke,e={..._.style,overflow:"visible",color:_.color},a=_.size||"1em",o=_.size||"1em",g=b.c;return w!==f._v$&&ft(n,"stroke",f._v$=w),f._v$2=Ot(n,e,f._v$2),a!==f._v$3&&ft(n,"height",f._v$3=a),o!==f._v$4&&ft(n,"width",f._v$4=o),g!==f._v$5&&(n.innerHTML=f._v$5=g),f},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),n})()}function _n(b){return dn({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},b)}var hn=Pt({"node_modules/.pnpm/gun@0.2020.1237/node_modules/gun/gun.js"(b,_){q(),Y(),function(){function n(w,e){return e?It(w):w.slice?n[a(w)]:function(o,g){w(o={exports:{}}),n[a(g)]=o.exports};function a(o){return o.split("/").slice(-1).toString().replace(".js","")}}if(typeof _<"u")var f=_;n(function(w){String.random=function(a,o){var g="";for(a=a||24,o=o||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";a-- >0;)g+=o.charAt(Math.floor(Math.random()*o.length));return g},String.match=function(a,o){var g,y;return typeof a!="string"?!1:(typeof o=="string"&&(o={"=":o}),o=o||{},g=o["="]||o["*"]||o[">"]||o["<"],a===g?!0:y!==o["="]?!1:(g=o["*"]||o[">"],a.slice(0,(g||"").length)===g?!0:y!==o["*"]?!1:y!==o[">"]&&y!==o["<"]?a>=o[">"]&&a<=o["<"]:y!==o[">"]&&a>=o[">"]||y!==o["<"]&&a<=o["<"]))},String.hash=function(a,o){if(typeof a=="string"){if(o=o||0,!a.length)return o;for(var g=0,y=a.length,h;g<y;++g)h=a.charCodeAt(g),o=(o<<5)-o+h,o|=0;return o}};var e=Object.prototype.hasOwnProperty;Object.plain=function(a){return a?a instanceof Object&&a.constructor===Object||Object.prototype.toString.call(a).match(/^\[object (\w+)\]$/)[1]==="Object":!1},Object.empty=function(a,o){for(var g in a)if(e.call(a,g)&&(!o||o.indexOf(g)==-1))return!1;return!0},Object.keys=Object.keys||function(a){var o=[];for(var g in a)e.call(a,g)&&o.push(g);return o},function(){var a,o=setTimeout,g=0,y=0,h=typeof setImmediate!=""+a&&setImmediate||o;o.hold=o.hold||9,o.poll=o.poll||function(s){if(o.hold>=+new Date-g&&y++<3333){s();return}h(function(){g=+new Date,s()},y=0)}}(),function(){var a=setTimeout,o=a.turn=a.turn||function(k){g.push(k)==1&&y(l)},g=o.s=[],y=a.poll,h=0,s,l=function(){(s=g[h++])&&s(),(h==g.length||h==99)&&(g=o.s=g.slice(h),h=0),g.length&&y(l)}}(),function(){var a,o=setTimeout,g=o.turn;(o.each=o.each||function(y,h,s,l){l=l||9,function k(D,d,A){if(d=(D=(y||[]).splice(0,l)).length){for(var v=0;v<d&&a===(A=h(D[v]));v++);if(a===A){g(k);return}}s&&s(A)}()})()}()})(n,"./shim"),n(function(w){w.exports=function e(s,o,g){if(!s)return{to:e};var y,h=typeof o=="function",s=(this.tag||(this.tag={}))[s]||h&&(this.tag[s]={tag:s,to:e._={next:function(k){var D;(D=this.to)&&D.next(k)}}});if(h){var l={off:e.off||(e.off=function(){if(this.next===e._.next)return!0;this===this.the.last&&(this.the.last=this.back),this.to.back=this.back,this.next=e._.next,this.back.to=this.to,this.the.last===this.the&&delete this.on.tag[this.the.tag]}),to:e._,next:o,the:s,on:this,as:g};return(l.back=s.last||s).to=l,s.last=l}return(s=s.to)&&y!==o&&s.next(o),s}})(n,"./onto"),n(function(w){w.exports=function(e){return e===null||typeof e=="string"||typeof e=="boolean"||typeof e=="number"&&e!=1/0&&e!=-1/0&&e===e||!!e&&typeof e["#"]=="string"&&Object.keys(e).length===1&&e["#"]}})(n,"./valid"),n(function(w){n("./shim");function e(){var s=+new Date;return y<s?(o=0,y=s+e.drift):y=s+(o+=1)/g+e.drift}e.drift=0;var a=-1/0,o=0,g=999,y=a,h;e.is=function(s,l,k){var D=l&&s&&s._&&s._[">"]||k;if(!!D)return typeof(D=D[l])=="number"?D:a},e.ify=function(s,l,k,D,d){(s=s||{})._=s._||{},d&&(s._["#"]=d);var A=s._[">"]||(s._[">"]={});return h!==l&&l!=="_"&&(typeof k=="number"&&(A[l]=k),h!==D&&(s[l]=D)),s},w.exports=e})(n,"./state"),n(function(w){n("./shim");function e(a){var o={s:{}},g=o.s;a=a||{max:999,age:1e3*9},o.check=function(h){return g[h]?y(h):!1};var y=o.track=function(h){var s=g[h]||(g[h]={});return s.was=o.now=+new Date,o.to||(o.to=setTimeout(o.drop,a.age+9)),s};return o.drop=function(h){o.to=null,o.now=+new Date;var s=Object.keys(g);console.STAT&&console.STAT(o.now,+new Date-o.now,"dup drop keys"),setTimeout.each(s,function(l){var k=g[l];k&&(h||a.age)>o.now-k.was||delete g[l]},0,99)},o}w.exports=e})(n,"./dup"),n(function(w){n("./onto"),w.exports=function(o,g){if(!!this.on){var y=(this.opt||{}).lack||9e3;if(typeof o!="function"){if(!o)return;var s=o["#"]||o,h=(this.tag||"")[s];return h?(g&&(h=this.on(s,g),clearTimeout(h.err),h.err=setTimeout(function(){h.off()},y)),!0):void 0}var s=g&&g["#"]||e(9);if(!o)return s;var l=this.on(s,o,g);return l.err=l.err||setTimeout(function(){l.off(),l.next({err:"Error: No ACK yet.",lack:!0})},y),s}};var e=String.random||function(){return Math.random().toString(36).slice(2)}})(n,"./ask"),n(function(w){function e(d){return d instanceof e?(this._={$:this}).$:this instanceof e?e.create(this._={$:this,opt:d}):new e(d)}e.is=function(d){return d instanceof e||d&&d._&&d===d._.$||!1},e.version=.202,e.chain=e.prototype,e.chain.toJSON=function(){},n("./shim"),e.valid=n("./valid"),e.state=n("./state"),e.on=n("./onto"),e.dup=n("./dup"),e.ask=n("./ask"),function(){e.create=function(t){t.root=t.root||t,t.graph=t.graph||{},t.on=t.on||e.on,t.ask=t.ask||e.ask,t.dup=t.dup||e.dup();var c=t.$.opt(t.opt);return t.once||(t.on("in",d,t),t.on("out",d,t),t.on("put",j,t),e.on("create",t),t.on("create",t)),t.once=1,c};function d(t){if(!!t){if(t.out===d){this.to.next(t);return}var c=this,m=c.as,R=m.at||m,E=R.$,$=R.dup,I,G=t.DBG;if((I=t["#"])||(I=t["#"]=o(9)),!$.check(I)){if($.track(I),I=t._,t._=typeof I=="function"?I:function(){},t.$&&t.$===(t.$._||"").$||(t.$=E),t["@"]&&!t.put&&u(t),!R.ask(t["@"],t))if(G&&(G.u=+new Date),t.put){A(t);return}else t.get&&e.on.get(t,E);G&&(G.uc=+new Date),c.to.next(t),G&&(G.ua=+new Date),!(t.nts||t.NTS)&&(t.out=d,R.on("out",t),G&&(G.ue=+new Date))}}}function A(t){if(!!t){var c=t._||"",m=c.root=((c.$=t.$||"")._||"").root;if(t["@"]&&c.faith&&!c.miss){t.out=d,m.on("out",t);return}c.latch=m.hatch,c.match=m.hatch=[];var R=t.put,E=c.DBG=t.DBG,$=+new Date;if(C=C||$,!(R["#"]&&R["."])){E&&(E.p=$),c["#"]=t["#"],c.msg=t,c.all=0,c.stun=1;var I=Object.keys(R);console.STAT&&console.STAT($,((E||c).pk=+new Date)-$,"put sort");var G=0,B,H,U,M,X,K,et;(function Q(at){if(B!=G){if(B=G,!(U=I[G])){console.STAT&&console.STAT($,((E||c).pd=+new Date)-$,"put"),T(c);return}(M=R[U])?(et=M._)?U!==et["#"]?K=p+x(U)+"soul not same.":(X=et[">"])||(K=p+x(U)+"no state."):K=p+x(U)+"no meta.":K=p+x(U)+"no node.",H=Object.keys(M||{})}if(K){t.err=c.err=K,T(c);return}var _t=0,z;for(at=at||0;at++<9&&(z=H[_t++]);)if(z!=="_"){var ut=M[z],ht=X[z];if(l===ht){K=p+x(z)+"on"+x(U)+"no state.";break}if(!y(ut)){K=p+x(z)+"on"+x(U)+"bad "+typeof ut+x(ut);break}v(ut,z,U,ht,t),++P}if((H=H.slice(_t)).length){g(Q);return}++G,H=null,Q(at)})()}}}e.on.put=A;function v(t,c,m,R,E){var $=E._||"",I=$.root,G=I.graph,B,H=G[m]||k,U=h(H,c,1),M=H[c],X=$.DBG;(B=console.STAT)&&(!G[m]||!M)&&(B.has=(B.has||0)+1);var K=O();if(R>K){setTimeout(function(){v(t,c,m,R,E)},(B=R-K)>N?N:B),console.STAT&&console.STAT((X||$).Hf=+new Date,B,"future");return}if(!(R<U&&!$.miss)&&!(!$.faith&&R===U&&(t===M||S(t)<=S(M))&&!$.miss)){$.stun++;var et=E["#"]+$.all++,Q={toString:function(){return et},_:$};Q.toJSON=Q.toString,X&&(X.ph=X.ph||+new Date),I.on("put",{"#":Q,"@":E["@"],put:{"#":m,".":c,":":t,">":R},_:$})}}function j(t){var c;(c=(t._||"").DBG)&&(c.pa=+new Date,c.pm=c.pm||+new Date);var m=this,R=m.as,E=R.graph,$=t._,I=t.put,G=I["#"],B=I["."],H=I[":"],U=I[">"];t["#"];var M;(M=$.msg)&&(M=M.put)&&(M=M[G])&&s(M,B,U,H,G),E[G]=s(E[G],B,U,H,G),(M=(R.next||"")[G])&&M.on("in",t),T($),m.to.next(t)}function T(t,c){var m;if(!t.stop&&!(!t.err&&0<--t.stun)&&(t.stop=1,!!(m=t.root))){var R=t.match;R.end=1,R===m.hatch&&(!(R=t.latch)||R.end?delete m.hatch:m.hatch=R),t.hatch&&t.hatch(),setTimeout.each(t.match,function(E){E&&E()}),!(!(c=t.msg)||t.err||c.err)&&(c.out=d,t.root.on("out",c),i())}}function u(t){var c=t["@"]||"",m;!(m=c._)||(m.acks=(m.acks||0)+1,(m.err=t.err)&&(t["@"]=m["#"],T(m)),!m.stop&&!m.crack&&(m.crack=m.match&&m.match.push(function(){r(m)})),r(m))}function r(t){!t||!t.root||t.stun||t.acks!==t.all||t.root.on("in",{"@":t["#"],err:t.err,ok:t.err?l:{"":1}})}var p="Error: Invalid graph!",x=function(t){return" '"+(""+t).slice(0,9)+"...' "},S=JSON.stringify,N=2147483647,O=e.state,P=0,C,i=function(){P>999&&P/-(C-(C=+new Date))>1&&(e.window&&console.log("Warning: You're syncing 1K+ records a second, faster than DOM can update - consider limiting query."),i=function(){P=0})}}(),function(){e.on.get=function(A,v){var j=v._,T=A.get,u=T["#"],r=j.graph[u],p=T["."],x=j.next||(j.next={});x[u];var S=A._||{},N=S.DBG=A.DBG;if(N&&(N.g=+new Date),!r)return j.on("get",A);if(p){if(typeof p!="string"||l===r[p])return j.on("get",A);r=s({},p,h(r,p),r[p],u)}r&&d(A,r),j.on("get",A)};function d(A,v){var j=+new Date,T=A._||{},u=T.DBG=A.DBG,r=A["#"],p=o(9),x=Object.keys(v||"").sort(),S=((v||"")._||"")["#"];x.length;var N=A.$._.root,O=v===N.graph[S];console.STAT&&console.STAT(j,((u||T).gk=+new Date)-j,"got keys"),v&&function P(){j=+new Date;for(var C=0,i,t={},c;C<9&&(i=x[C++]);)s(t,i,h(v,i),v[i],S);x=x.slice(C),(c={})[S]=t,t=c;var m;O&&(m=function(){},m.ram=m.faith=!0),c=x.length,console.STAT&&console.STAT(j,-(j-(j=+new Date)),"got copied some"),u&&(u.ga=+new Date),N.on("in",{"@":r,"#":p,put:t,"%":c?p=o(9):l,$:N.$,_:m,DBG:u}),console.STAT&&console.STAT(j,+new Date-j,"got in"),c&&setTimeout.turn(P)}(),v||N.on("in",{"@":A["#"]})}e.on.get.ack=d}(),function(){e.chain.opt=function(d){d=d||{};var A=this,v=A._,j=d.peers||d;return Object.plain(d)||(d={}),Object.plain(v.opt)||(v.opt=d),typeof j=="string"&&(j=[j]),Object.plain(v.opt.peers)||(v.opt.peers={}),j instanceof Array&&(d.peers={},j.forEach(function(T){var u={};u.id=u.url=T,d.peers[T]=v.opt.peers[T]=v.opt.peers[T]||u})),a(d,function T(u){var r=this[u];if(this&&this.hasOwnProperty(u)||typeof r=="string"||Object.empty(r)){this[u]=r;return}r&&r.constructor!==Object&&!(r instanceof Array)||a(r,T)}),v.opt.from=d,e.on("opt",v),v.opt.uuid=v.opt.uuid||function(u){return e.state().toString(36).replace(".","")+String.random(u||12)},A}}();var a=function(d,A){Object.keys(d).forEach(A,d)},o=String.random,g=setTimeout.turn,y=e.valid,h=e.state.is,s=e.state.ify,l,k={},D;e.log=function(){return!e.log.off&&D.log.apply(D,arguments),[].slice.call(arguments).join(" ")},e.log.once=function(d,A,v){return(v=e.log.once)[d]=v[d]||0,v[d]++||e.log(A)},typeof window<"u"&&((window.GUN=window.Gun=e).window=window);try{typeof f<"u"&&(f.exports=e)}catch{}w.exports=e,(e.window||{}).console=(e.window||{}).console||{log:function(){}},(D=console).only=function(d,A){return D.only.i&&d===D.only.i&&D.only.i++&&(D.log.apply(D,arguments)||A)},e.log.once("welcome","Hello wonderful person! :) Thanks for using GUN, please ask for help on http://chat.gun.eco if anything takes you longer than 5min to figure out!")})(n,"./root"),n(function(w){var e=n("./root");e.chain.back=function(g,y){var h;if(g=g||1,g===-1||g===1/0)return this._.root.$;if(g===1)return(this._.back||this._).$;var s=this,l=s._;if(typeof g=="string"&&(g=g.split(".")),g instanceof Array){var k=0,D=g.length,h=l;for(k;k<D;k++)h=(h||a)[g[k]];return o!==h?y?s:h:(h=l.back)?h.$.back(g,y):void 0}if(typeof g=="function"){for(var d,h={back:l};(h=h.back)&&o===(d=g(h,y)););return d}return typeof g=="number"?(l.back||l).$.back(g-1):this};var a={},o})(n,"./back"),n(function(w){var e=n("./root");e.chain.chain=function(T){var u=this,r=u._,p=new(T||u).constructor(u),x=p._,S;return x.root=S=r.root,x.id=++S.once,x.back=u._,x.on=e.on,x.on("in",e.on.in,x),x.on("out",e.on.out,x),p};function a(T){var u,r=this.as,p=r.back,x=r.root,S;if(T.$||(T.$=r.$),this.to.next(T),r.err){r.on("in",{put:r.put=l,$:r.$});return}if(u=T.get){if(x.pass&&(x.pass[r.id]=r),r.lex&&Object.keys(r.lex).forEach(function(N){S[N]=r.lex[N]},S=T.get=T.get||{}),u["#"]||r.soul){if(u["#"]=u["#"]||r.soul,T["#"]||(T["#"]=k(9)),p=x.$.get(u["#"])._,u=u["."]){if(d(p.put,u)&&(S=p.ask&&p.ask[u],(p.ask||(p.ask={}))[u]=p.$.get(u)._,p.on("in",{get:u,put:{"#":p.soul,".":u,":":p.put[u],">":v(x.graph[p.soul],u)}}),S))return}else{if(S=p.ask&&p.ask[""],(p.ask||(p.ask={}))[""]=p,l!==p.put&&(p.on("in",p),S))return;T.$=p.$}return x.ask(h,T),x.on("in",T)}if(u["."])return r.get?(T={get:{".":r.get},$:r.$},(p.ask||(p.ask={}))[r.get]=T.$._,p.on("out",T)):(T={get:r.lex?T.get:{},$:r.$},p.on("out",T));if((r.ask||(r.ask={}))[""]=r,r.get)return u["."]=r.get,(p.ask||(p.ask={}))[r.get]=T.$._,p.on("out",T)}return p.on("out",T)}e.on.out=a;function o(T,u){u=u||this.as;var r=u.root,p=T.$||(T.$=u.$),x=(p||"")._||s,S=T.put||"",N=S["#"],O=S["."],P=l!==S["="]?S["="]:S[":"],C=S[">"]||-1/0,i;if(l!==T.put&&(l===S["#"]||l===S["."]||l===S[":"]&&l===S["="]||l===S[">"])){if(!D(S)){if(!(N=((S||"")._||"")["#"])){console.log("chain not yet supported for",S,"...",T,u);return}return p=u.root.$.get(N),setTimeout.each(Object.keys(S).sort(),function(t){t=="_"||l===(C=v(S,t))||u.on("in",{$:p,put:{"#":N,".":t,"=":S[t],">":C},VIA:T})})}u.on("in",{$:x.back.$,put:{"#":N=x.back.soul,".":O=x.has||x.get,"=":S,">":v(x.back.put,O)},via:T});return}(T.seen||"")[u.id]||((T.seen||(T.seen=function(){}))[u.id]=u,u!==x&&(Object.keys(T).forEach(function(t){S[t]=T[t]},S={}),S.get=u.get||S.get,!u.soul&&!u.has?S.$$$=S.$$$||u.$:x.soul&&(S.$=u.$,S.$$=S.$$||x.$),T=S),y(T,u),(u.soul||T.$$)&&C>=v(r.graph[N],O)&&((S=r.$.get(N)._).put=j(S.put,O,C,P,N)),!x.soul&&C>=v(r.graph[N],O)&&(i=(r.$.get(N)._.next||"")[O])&&(i.put=P,typeof(S=D(P))=="string"&&(i.put=r.$.get(S)._.put||P)),this.to&&this.to.next(T),u.any&&setTimeout.each(Object.keys(u.any),function(t){(t=u.any[t])&&t(T)},0,99),u.echo&&setTimeout.each(Object.keys(u.echo),function(t){(t=u.echo[t])&&t.on("in",T)},0,99),((T.$$||"")._||x).soul&&(i=u.next)&&(i=i[O])&&(S={},Object.keys(T).forEach(function(t){S[t]=T[t]}),S.$=(T.$$||T.$).get(S.get=O),delete S.$$,delete S.$$$,i.on("in",S)),g(T,u))}e.on.in=o;function g(T,u){if(u=u||this.as||T.$._,!(T.$$&&this!==e.on)&&!(!T.put||u.soul)){var r=T.put||"",p=r["="]||r[":"],O,x=u.root,S=x.$.get(r["#"]).get(r["."])._;if(typeof(p=D(p))!="string"){this===e.on&&((S.echo||(S.echo={}))[u.id]=u);return}if(!((S.echo||(S.echo={}))[u.id]&&!(x.pass||"")[u.id])){if(O=x.pass){if(O[p+u.id])return;O[p+u.id]=1}(S.echo||(S.echo={}))[u.id]=u,u.has&&(u.link=p);var N=x.$.get(S.link=p)._;(N.echo||(N.echo={}))[S.id]=S;var O=u.ask||"";(O[""]||u.lex)&&N.on("out",{get:{"#":p}}),setTimeout.each(Object.keys(O),function(P,C){!P||!(C=O[P])||C.on("out",{get:{"#":p,".":P}})},0,99)}}}e.on.link=g;function y(T,u){var r=T.put||"",p=l!==r["="]?r["="]:r[":"],x=u.root,S,N;if(l===p){if(u.soul&&l!==u.put||(N=(T.$$||T.$||"")._||"",T["@"]&&(l!==N.put||l!==u.put)))return;(S=u.link||T.linked)&&delete(x.$.get(S)._.echo||"")[u.id],u.has&&(u.link=null),u.put=l,setTimeout.each(Object.keys(u.next||""),function(O,P){!(P=u.next[O])||(S&&delete(x.$.get(S).get(O)._.echo||"")[P.id],P.on("in",{get:O,put:l,$:P.$}))},0,99);return}u.soul||T.$$||(S=D(p),N=T.$._||"",!((S===N.link||u.has&&!N.link)&&!((x.pass||"")[u.id]&&typeof S!="string"))&&(delete(N.echo||"")[u.id],y({get:u.get,put:l,$:T.$,linked:T.linked=T.linked||N.link},u)))}e.on.unlink=y;function h(T,u){var r=this.as,p=r.$._;p.root;var x=r.get||"",S=(T.put||"")[x["#"]]||"";if(!T.put||typeof x["."]=="string"&&l===S[x["."]]){if(l!==p.put||!p.soul&&!p.has)return;p.ack=(p.ack||0)+1,p.on("in",{get:p.get,put:p.put=l,$:p.$,"@":T["@"]});return}(T._||{}).miss=1,e.on.put(T)}var s={},l,k=String.random,D=e.valid,d=function(T,u){return T&&Object.prototype.hasOwnProperty.call(T,u)},A=e.state,v=A.is,j=A.ify})(n,"./chain"),n(function(w){var e=n("./root");e.chain.get=function(l,k,D){var d,A;if(typeof l=="string"){if(l.length==0)return(d=this.chain())._.err={err:e.log("0 length key!",l)},k&&k.call(d,d._.err),d;var v=this,j=v._,T=j.next||y;(d=T[l])||(d=l&&a(l,v)),d=d&&d.$}else if(typeof l=="function"){let S=function(O,P,C){if(!S.stun&&!((E=r.pass)&&!E[p])){var i=O.$._,t=(O.$$||"")._,c=(t||i).put,m=!i.has&&!i.soul,R={},E;if((m||s===c)&&(c=s===((E=O.put)||"")["="]?s===(E||"")[":"]?E:E[":"]:E["="]),typeof(E=e.valid(c))=="string"&&(c=s===(E=r.$.get(E)._.put)?u.not?s:c:E),!(u.not&&s===c)){if(s===u.stun){if((E=r.stun)&&E.on&&(j.$.back(function($){if(E.on(""+$.id,R={}),(R.run||0)<S.id)return R}),!R.run&&E.on(""+i.id,R={}),!R.run&&t&&E.on(""+t.id,R={}),S.id>R.run&&((!R.stun||R.stun.end)&&(R.stun=E.on("stun"),R.stun=R.stun&&R.stun.last),R.stun&&!R.stun.end))){(R.stun.add||(R.stun.add={}))[p]=function(){S(O,P,1)};return}if(s===c&&(C=0),(E=r.hatch)&&!E.end&&s===u.hatch&&!C){if(x[i.$._.id])return;x[i.$._.id]=1,E.push(function(){S(O,P,1)});return}x={}}if(r.pass){if(r.pass[p+i.id])return;r.pass[p+i.id]=1}if(u.on){u.ok.call(i.$,c,i.get,O,P||S);return}if(u.v2020){u.ok(O,P||S);return}Object.keys(O).forEach(function($){E[$]=O[$]},E={}),O=E,O.put=c,u.ok.call(u.as,O,P||S)}}};if(k===!0)return o(this,l,k,D),this;d=this;var j=d._,u=k||{},r=j.root,p;u.at=j,u.ok=l;var x={};return S.at=j,(j.any||(j.any={}))[p=String.random(7)]=S,S.off=function(){S.stun=1,j.any&&delete j.any[p]},S.rid=g,S.id=u.run||++r.once,A=r.pass,(r.pass={})[p]=1,u.out=u.out||{get:{}},j.on("out",u.out),r.pass=A,d}else{if(typeof l=="number")return this.get(""+l,k,D);if(typeof(A=h(l))=="string")return this.get(A,k,D);(A=this.get.next)&&(d=A(this,l))}return d?(k&&typeof k=="function"&&d.get(k,D),d):((d=this.chain())._.err={err:e.log("Invalid get request!",l)},k&&k.call(d,d._.err),d)};function a(l,k){var D=k._,d=D.next,A=k.chain(),v=A._;return d||(d=D.next={}),d[v.get=l]=v,k===D.root.$?v.soul=l:(D.soul||D.has)&&(v.has=l),v}function o(l,k,D,d){var A=l._,v=0,j;return(j=A.soul||A.link)?k(j,d,A):A.jam?A.jam.push([k,d]):(A.jam=[[k,d]],l.get(function(u,r){if(!(s===u.put&&!A.root.opt.super&&(j=Object.keys(A.root.opt.peers).length)&&++v<=j)){r.rid(u);var p=(p=u.$)&&p._||{},x=0,S;for(j=A.jam,delete A.jam;S=j[x++];){var N=S[0];S=S[1],N&&N(p.link||p.soul||e.valid(u.put)||((u.put||{})._||{})["#"],S,u,r)}}},{out:{get:{".":!0}}}),l)}function g(l){var k=this.at||this.on;if(!l||k.soul||k.has)return this.off();if(!!(l=(l=(l=l.$||l)._||l).id)){k.map;var D;if((D=this.seen||(this.seen={}))[l])return!0;D[l]=!0}}var y={},h=e.valid,s})(n,"./get"),n(function(w){var e=n("./root");e.chain.put=function(d,A,v){var j=this,T=j._,u=T.root;v=v||{},v.root=T.root,v.run||(v.run=u.once),a(v,T.id),v.ack=v.ack||A,v.via=v.via||j,v.data=v.data||d,v.soul||(v.soul=T.soul||typeof A=="string"&&A);var r=v.state=v.state||e.state();return typeof d=="function"?(d(function(p){v.data=p,j.put(h,h,v)}),j):v.soul?(v.$=u.$.get(v.soul),v.todo=[{it:v.data,ref:v.$}],v.turn=v.turn||l,v.ran=v.ran||o,function p(){var x=v.todo,S=x.pop(),N=S.it;S.ref&&S.ref._.id;var O,P,C,i,t;if(a(v,S.ref),(i=S.todo)&&(P=i.pop(),N=N[P],i.length&&x.push(S)),P&&(x.path||(x.path=[])).push(P),!(O=k(N))&&!(t=e.is(N))){if(!Object.plain(N)){o.err(v,"Invalid data: "+y(N)+" at "+(v.via.back(function(E){E.get&&i.push(E.get)},i=[])||i.join("."))+"."+(x.path||[]).join("."));return}for(var c=v.seen||(v.seen=[]),m=c.length;m--;)if(N===(i=c[m]).it){O=N=i.link;break}}if(P&&O)S.node=D(S.node,P,r,N);else{let E=function($,I){var G=C.link["#"];I&&(I.off(),I.rid($));var B=G||$.soul||(i=($.$$||$.$)._||"").soul||i.link||((i=i.put||"")._||"")["#"]||i["#"]||((i=$.put||"")&&$.$$?i["#"]:(i["="]||i[":"]||"")["#"]);if(!G&&a(v,$.$),!B&&!S.link["#"]){(S.wait||(S.wait=[])).push(function(){E($,I)});return}B||(B=[],($.$$||$.$).back(function(H){if(i=H.soul||H.link)return B.push(i);B.push(H.get)}),B=B.reverse().join("/")),C.link["#"]=B,!t&&(((v.graph||(v.graph={}))[B]=C.node||(C.node={_:{}}))._["#"]=B),delete v.wait[R],C.wait&&setTimeout.each(C.wait,function(H){H&&H()}),v.ran(v)};if(!v.seen){o.err(v,"Data at root of graph must be a node (an object).");return}v.seen.push(C={it:N,link:{},todo:t?[]:Object.keys(N).sort().reverse(),path:(x.path||[]).slice(),up:S}),S.node=D(S.node,P,r,C.link),!t&&C.todo.length&&x.push(C);var R=v.seen.length;(v.wait||(v.wait={}))[R]="",i=(C.ref=t?N:P?S.ref.get(P):S.ref)._,(i=N&&(N._||"")["#"]||i.soul||i.link)?E({soul:i}):C.ref.get(E,{run:v.run,v2020:1,out:{get:{".":" "}}})}if(!x.length)return v.ran(v);v.turn(p)}(),j):(g(v),j)};function a(d,A){if(!!A){A=(A._||"").id||A;var v=d.root.stun||(d.root.stun={on:e.on}),j={},T;d.stun||(d.stun=v.on("stun",function(){})),(T=v.on(""+A))&&T.the.last.next(j),!(j.run>=d.run)&&v.on(""+A,function(u){if(d.stun.end){this.off(),this.to.next(u);return}u.run=u.run||d.run,u.stun=u.stun||d.stun})}}function o(d){if(d.err){o.end(d.stun,d.root);return}if(!(d.todo.length||d.end||!Object.empty(d.wait))){d.end=1;var A=d.$.back(-1)._,v=A.root,j=A.ask(function(p){v.on("ack",p),p.err&&e.log(p),++T>(d.acks||0)&&this.off(),d.ack&&d.ack(p,this)},d.opt),T=0,u=d.stun,r;(r=function(){!u||(o.end(u,v),setTimeout.each(Object.keys(u=u.add||""),function(p){(p=u[p])&&p()}))}).hatch=r,d.via._.on("out",{put:d.out=d.graph,opt:d.opt,"#":j,_:r})}}o.end=function(d,A){d.end=s,d.the.to===d&&d===d.the.last&&delete A.stun,d.off()},o.err=function(d,A){(d.ack||s).call(d,d.out={err:d.err=e.log(A)}),d.ran(d)};function g(d){var A=d.via._,v;d.via=d.via.back(function(j){if(j.soul||!j.get)return j.$;v=d.data,(d.data={})[j.get]=v}),(!d.via||!d.via._.soul)&&(d.via=A.root.$.get(((d.data||"")._||"")["#"]||A.$.back("opt.uuid")())),d.via.put(d.data,d.ack,d)}function y(d,A){return d&&(A=d.constructor)&&A.name||typeof d}var h,s=function(){},l=setTimeout.turn,k=e.valid,D=e.state.ify})(n,"./put"),n(function(w){var e=n("./root");n("./chain"),n("./back"),n("./put"),n("./get"),w.exports=e})(n,"./index"),n(function(w){var e=n("./index");e.chain.on=function(g,y,h,s){var l=this,k=l._;k.root;var D;if(typeof g=="string")return y?(D=k.on(g,y,h||k,s),h&&h.$&&(h.subs||(h.subs=[])).push(D),l):k.on(g);var d=y;return(d=d===!0?{change:!0}:d||{}).not=1,d.on=1,l.get(g,d),l},e.chain.once=function(g,y){if(y=y||{},!g)return a(this);var h=this,s=h._,l=s.root;s.put;var k=String.random(7),D;return h.get(function(d,A,v,j){var T=this,u=T._,r=u.one||(u.one={});if(j.stun||r[k]==="")return;if((D=e.valid(d))===!0){p();return}if(typeof D=="string")return;clearTimeout((s.one||"")[k]),clearTimeout(r[k]),r[k]=setTimeout(p,y.wait||99);function p(x){if(!u.has&&!u.soul&&(u={put:d,get:A}),o===(D=u.put)&&(D=((v.$$||"")._||"").put),typeof e.valid(D)=="string"&&(D=l.$.get(D)._.put,D===o&&!x)){r[k]=setTimeout(function(){p(1)},y.wait||99);return}j.stun||r[k]!==""&&(r[k]="",(s.soul||s.has)&&j.off(),g.call(T,D,u.get),clearTimeout(r[k]))}},{on:1}),h};function a(g,y,h){return e.log.once("valonce","Chainable val is experimental, its behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),(h=g.chain())._.nix=g.once(function(s,l){h._.on("in",this._)}),h._.lex=g._.lex,h}e.chain.off=function(){var g=this,y=g._,h,s=y.back;if(!!s)return y.ack=0,(h=s.next)&&h[y.get]&&delete h[y.get],(h=s.ask)&&delete h[y.get],(h=s.put)&&delete h[y.get],(h=y.soul)&&delete s.root.graph[h],(h=y.map)&&Object.keys(h).forEach(function(l,k){k=h[l],k.link&&s.root.$.get(k.link).off()}),(h=y.next)&&Object.keys(h).forEach(function(l,k){k=h[l],k.$.off()}),y.on("off",{}),g};var o})(n,"./on"),n(function(w){var e=n("./index"),a=e.chain.get.next;e.chain.get.next=function(h,s){var l;return Object.plain(s)?(l=((l=s["#"])||"")["="]||l)?h.get(l):((l=h.chain()._).lex=s,h.on("in",function(k){String.match(k.get||(k.put||"")["."],s["."]||s["#"]||s)&&l.on("in",k),this.to.next(k)}),l.$):(a||g)(h,s)},e.chain.map=function(h,s,l){var k=this,D=k._,d,A;return Object.plain(h)&&(d=h["."]?h:{".":h},h=y),h?(e.log.once("mapfn","Map functions are experimental, their behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),A=k.chain(),k.map().on(function(v,j,T,u){var r=(h||g).call(this,v,j,T,u);if(y!==r){if(v===r)return A._.on("in",T);if(e.is(r))return A._.on("in",r._);var p={};Object.keys(T.put).forEach(function(x){p[x]=T.put[x]},p),p["="]=r,A._.on("in",{get:j,put:p})}}),A):((A=D.each)||((D.each=A=k.chain())._.lex=d||A._.lex||D.lex,A._.nix=k.back("nix"),k.on("in",o,A._)),A)};function o(h){this.to.next(h);var s=this.as,l=h.$,k=l._,D=h.put,d;!k.soul&&!h.$$||(d=s.lex)&&!String.match(h.get||(D||"")["."],d["."]||d["#"]||d)||e.on.link(h,s)}var g=function(){},y})(n,"./map"),n(function(w){var e=n("./index");e.chain.set=function(a,o,g){var y=this,h=y.back(-1),s,l;return o=o||function(){},g=g||{},g.item=g.item||a,(s=((a||"")._||"")["#"])&&((a={})["#"]=s),typeof(l=e.valid(a))=="string"?y.get(s=l).put(a,o,g):e.is(a)?(y.put(function(k){a.get(function(D,d,A){if(!D)return o.call(y,{err:e.log('Only a node can be linked! Not "'+A.put+'"!')});(l={})[D]={"#":D},k(l)},!0)}),a):(Object.plain(a)&&(a=h.get(s=y.back("opt.uuid")()).put(a)),y.get(s||h.back("opt.uuid")(7)).put(a,o,g))}})(n,"./set"),n(function(w){n("./shim");var e=function(){},a=JSON.parseAsync||function(h,s,l){var k,D=+new Date;try{s(k,JSON.parse(h,l),o.sucks(+new Date-D))}catch(d){s(d)}},o=JSON.stringifyAsync||function(h,s,l,k){var D,d=+new Date;try{s(D,JSON.stringify(h,l,k),o.sucks(+new Date-d))}catch(A){s(A)}};o.sucks=function(h){h>99&&(console.log("Warning: JSON blocking CPU detected. Add `gun/lib/yson.js` to fix."),o.sucks=e)};function g(h){var s=function(){},l=h.opt||{};l.log=l.log||console.log,l.gap=l.gap||l.wait||0,l.max=l.max||(l.memory?l.memory*999*999:3e8)*.3,l.pack=l.pack||l.max*.01*.01,l.puff=l.puff||9;var k=setTimeout.turn||setTimeout,D=h.dup,d=D.check,A=D.track,v=s.hear=function(r,p){if(!!r){if(l.max<=r.length)return s.say({dam:"!",err:"Message too big!"},p);s===this&&(v.d+=r.length||0,++v.c);var x=p.SH=+new Date,S=r[0],N;if(S==="["){a(r,function(O,P){if(O||!P)return s.say({dam:"!",err:"DAM JSON parse error."},p);console.STAT&&console.STAT(+new Date,P.length,"# on hear batch");var C=l.puff;(function i(){for(var t=+new Date,c=0,m;c<C&&(m=P[c++]);)s.hear(m,p);P=P.slice(c),console.STAT&&console.STAT(t,+new Date-t,"hear loop"),j(p),P.length&&k(i,0)})()}),r="";return}if(S==="{"||(r["#"]||Object.plain(r))&&(N=r)){if(N)return v.one(N,p,x);a(r,function(O,P){if(O||!P)return s.say({dam:"!",err:"DAM JSON parse error."},p);v.one(P,p,x)});return}}};v.one=function(r,p,i){var S,N,O,P,C;if(r.DBG&&(r.DBG=C={DBG:r.DBG}),C&&(C.h=i),C&&(C.hp=+new Date),(S=r["#"])||(S=r["#"]=String.random(9)),!(O=d(S))&&(N=r["##"],!(N&&(O=r["@"]||r.get&&S)&&D.check(P=O+N)))){if((r._=function(){}).via=s.leap=p,(O=r["><"])&&typeof O=="string"&&O.slice(0,99).split(",").forEach(function(t){this[t]=1},r._.yo={}),O=r.dam){(O=s.hear[O])&&O(r,p,h),A(S);return}var i=+new Date;C&&(C.is=i),p.SI=S,h.on("in",s.last=r),C&&(C.hd=+new Date),console.STAT&&console.STAT(i,+new Date-i,r.get?"msg get":r.put?"msg put":"msg"),(O=A(S)).via=p,r.get&&(O.it=r),P&&A(P),s.leap=s.last=null}},v.c=v.d=0,function(){var r=0,p;s.hash=function(N,O){var P,C,i,t=+new Date;o(N.put,function c(m,R){var E=(C||(C=i=R||"")).slice(0,32768);if(P=String.hash(E,P),C=C.slice(32768),C){k(c,0);return}console.STAT&&console.STAT(t,+new Date-t,"say json+hash"),N._.$put=i,N["##"]=P,s.say(N,O),delete N._.$put},x)};function x(N,O){var P;return O instanceof Object?(Object.keys(O).sort().forEach(S,{to:P={},on:O}),P):O}function S(N){this.to[N]=this.on[N]}s.say=function(N,O){var P;if((P=this)&&(P=P.to)&&P.next&&P.next(N),!N)return!1;var C,i,t=N["@"],c=N._||(N._=function(){}),m=N.DBG,R=+new Date;if(c.y=c.y||R,O||m&&(m.y=R),(C=N["#"])||(C=N["#"]=String.random(9)),!p&&A(C),N.put&&(N.err||(D.s[C]||"").err))return!1;if(!N["##"]&&y!==N.put&&!c.via&&t){s.hash(N,O);return}if(!O&&t&&(O=(P=D.s[t])&&(P.via||(P=P.it)&&(P=P._)&&P.via)||(P=s.last)&&t===P["#"]&&s.leap),!O&&t)return D.s[t]?void 0:(console.STAT&&console.STAT(+new Date,++r,"total no peer to ack to"),!1);if(!O&&s.way)return s.way(N);if(m&&(m.yh=+new Date),!(i=c.raw)){s.raw(N,O);return}if(m&&(m.yr=+new Date),!O||!O.id){if(!Object.plain(O||l.peers))return!1;var R=+new Date;l.puff;var E=l.peers,$=Object.keys(O||l.peers||{});console.STAT&&console.STAT(R,+new Date-R,"peer keys"),function B(){var H=+new Date;p=1;var U=c.raw;c.raw=i;for(var M=0,X;M<9&&(X=($||"")[M++]);)!(X=E[X])||s.say(N,X);c.raw=U,p=0,$=$.slice(M),console.STAT&&console.STAT(H,+new Date-H,"say loop"),$.length&&(k(B,0),t&&A(t))}();return}if(!O.wire&&s.wire&&s.wire(O),C!==O.last){if(O.last=C,O===c.via||(P=c.yo)&&(P[O.url]||P[O.pid]||P[O.id]))return!1;if(console.STAT&&console.STAT(R,((m||c).yp=+new Date)-(c.y||R),"say prep"),!p&&t&&A(t),O.batch){if(O.tail=(P=O.tail||0)+i.length,O.tail<=l.pack){O.batch+=(P?",":"")+i;return}j(O)}O.batch="[";var I=+new Date;setTimeout(function(){console.STAT&&console.STAT(I,+new Date-I,"0ms TO"),j(O)},l.gap),T(i,O),console.STAT&&t===O.SI&&console.STAT(R,+new Date-O.SH,"say ack")}},s.say.c=s.say.d=0,s.raw=function(N,O){if(!N)return"";var P=N._||{},C,i;if(i=P.raw)return i;if(typeof N=="string")return N;var t=N["##"],c=N["@"];if(t&&c){if(!P.via&&d(c+t))return!1;if((i=(D.s[c]||"").it)||(i=s.last)&&c===i["#"]){if(t===i["##"])return!1;i["##"]||(i["##"]=t)}}if(!N.dam){var m=0,R=[];i=l.peers;for(var E in i){var $=i[E];if(R.push($.url||$.pid||$.id),++m>6)break}m>1&&(N["><"]=R.join())}if(C=P.$put){i={},Object.keys(N).forEach(function(G){i[G]=N[G]}),i.put=":])([:",o(i,function(G,B){if(!G){var H=+new Date;i=B.indexOf('"put":":])([:"'),I(y,B=B.slice(0,i+6)+C+B.slice(i+14)),console.STAT&&console.STAT(H,+new Date-H,"say slice")}});return}o(N,I);function I(G,B){G||(P.raw=B,s.say(N,O))}}}();function j(r){var p=r.batch,x=typeof p=="string";if(x&&(p+="]"),r.batch=r.tail=null,!!p&&!(x?3>p.length:!p.length)){if(!x)try{p=p.length===1?p[0]:JSON.stringify(p)}catch(S){return l.log("DAM JSON stringify error",S)}!p||T(p,r)}}function T(r,p){try{var x=p.wire;p.say?p.say(r):x.send&&x.send(r),s.say.d+=r.length||0,++s.say.c}catch{(p.queue=p.queue||[]).push(r)}}s.hi=function(r){var p=r.wire,x;if(!p){s.wire(r.length&&{url:r}||r);return}r.id?l.peers[r.url||r.id]=r:(x=r.id=r.id||String.random(9),s.say({dam:"?",pid:h.opt.pid},l.peers[x]=r),delete D.s[r.last]),r.met=r.met||+new Date,p.hied||h.on(p.hied="hi",r),x=r.queue,r.queue=[],setTimeout.each(x||[],function(S){T(S,r)},0,9)},s.bye=function(r){h.on("bye",r);var p=+new Date;p=p-(r.met||p),s.bye.time=((s.bye.time||p)+p)/2},s.hear["!"]=function(r,p){l.log("Error:",r.err)},s.hear["?"]=function(r,p){r.pid&&(p.pid||(p.pid=r.pid),r["@"])||(s.say({dam:"?",pid:l.pid,"@":r["#"]},p),delete D.s[p.last])},h.on("create",function(r){r.opt.pid=r.opt.pid||String.random(9),this.to.next(r),r.on("out",s.say)}),h.on("bye",function(r,p){r=l.peers[r.id||r]||r,this.to.next(r),r.bye?r.bye():(p=r.wire)&&p.close&&p.close(),delete l.peers[r.id],r.wire=null});var u={};return h.on("bye",function(r,p){this.to.next(r),(p=console.STAT)&&(p.peers=(p.peers||0)-1),(p=r.url)&&(u[p]=!0,setTimeout(function(){delete u[p]},l.lack||9e3))}),h.on("hi",function(r,p){this.to.next(r),(p=console.STAT)&&(p.peers=(p.peers||0)+1),!(!(p=r.url)||!u[p])&&(delete u[p],!l.super&&setTimeout.each(Object.keys(h.next),function(x){h.next[x],p={},p[x]=h.graph[x],p=String.hash(p),s.say({"##":p,get:{"#":x}},r)}))}),s}var y;try{w.exports=g}catch{}})(n,"./mesh"),n(function(w){var e=n("../index");e.Mesh=n("./mesh"),e.on("opt",function(o){if(this.to.next(o),o.once)return;var g=o.opt;if(g.WebSocket===!1)return;var y=e.window||{},h=g.WebSocket||y.WebSocket||y.webkitWebSocket||y.mozWebSocket;if(!h)return;g.WebSocket=h;var s=g.mesh=g.mesh||e.Mesh(o);s.wire||g.wire,s.wire=g.wire=l;function l(A){try{if(!A||!A.url)return j&&j(A);var v=A.url.replace(/^http/,"ws"),j=A.wire=new g.WebSocket(v);return j.onclose=function(){g.mesh.bye(A),D(A)},j.onerror=function(T){D(A)},j.onopen=function(){g.mesh.hi(A)},j.onmessage=function(T){!T||g.mesh.hear(T.data||T,A)},j}catch{}}setTimeout(function(){!g.super&&o.on("out",{dam:"hi"})},1);var k=2*999;function D(A){clearTimeout(A.defer),g.peers[A.url]&&(d&&A.retry<=0||(A.retry=(A.retry||g.retry+1||60)-(-A.tried+(A.tried=+new Date)<k*4?1:0),A.defer=setTimeout(function v(){if(d&&d.hidden)return setTimeout(v,k);l(A)},k)))}var d=""+a!=typeof document&&document});var a})(n,"./websocket"),n(function(w){if(!(typeof Gun>"u")){var e=function(){},a;try{a=(Gun.window||e).localStorage}catch{}a||(Gun.log("Warning: No localStorage exists to persist data to!"),a={setItem:function(g,y){this[g]=y},removeItem:function(g){delete this[g]},getItem:function(g){return this[g]}});var o=JSON.stringifyAsync||function(g,y,h,s){var l;try{y(l,JSON.stringify(g,h,s))}catch(k){y(k)}};Gun.on("create",function g(y){this.to.next(y);var h=y.opt;y.graph;var s=[],l,k,D,d;if(h.localStorage===!1)return;h.prefix=h.file||"gun/";try{l=g[h.prefix]=g[h.prefix]||JSON.parse(D=a.getItem(h.prefix))||{}}catch{l=g[h.prefix]={}}D=(D||"").length,y.on("get",function(v){this.to.next(v);var j=v.get,T,u,r,p;!j||!(T=j["#"])||(u=l[T]||p,u&&(r=j["."])&&!Object.plain(r)&&(u=Gun.state.ify({},r,Gun.state.is(u,r),u[r],T)),Gun.on.get.ack(v,u))}),y.on("put",function(v){this.to.next(v);var j=v.put,T=j["#"],u=j["."],r=v["#"];if(l[T]=Gun.state.ify(l[T],u,j[">"],j[":"],T),d&&D>4999880){y.on("in",{"@":r,err:"localStorage max!"});return}v["@"]||s.push(r),!k&&(k=setTimeout(A,9+D/333))});function A(){if(!s.length&&((setTimeout.turn||"").s||"").length){setTimeout(A,99);return}var v=s;clearTimeout(k),k=!1,s=[],o(l,function(j,T){try{!j&&a.setItem(h.prefix,T)}catch(u){j=d=u||"localStorage failure"}j&&(Gun.log(j+" Consider using GUN's IndexedDB plugin for RAD for more storage space, https://gun.eco/docs/RAD#install"),y.on("localStorage:error",{err:j,get:h.prefix,put:l})),D=T.length,!(!j&&!Object.empty(h.peers))&&setTimeout.each(v,function(u){y.on("in",{"@":u,err:j,ok:0})},0,99)})}})}})(n,"./localStorage")}(),function(){var C;if(""+C!=typeof Gun){var n=function(i){console.warn("Warning! Deprecated internal utility will break in next version:",i)},f=Gun;f.fn=f.fn||{is:function(i){return n("fn"),!!i&&typeof i=="function"}},f.bi=f.bi||{is:function(i){return n("bi"),i instanceof Boolean||typeof i=="boolean"}},f.num=f.num||{is:function(i){return n("num"),!w(i)&&(i-parseFloat(i)+1>=0||i===1/0||i===-1/0)}},f.text=f.text||{is:function(i){return n("text"),typeof i=="string"}},f.text.ify=f.text.ify||function(i){return n("text.ify"),f.text.is(i)?i:typeof JSON<"u"?JSON.stringify(i):i&&i.toString?i.toString():i},f.text.random=f.text.random||function(i,t){n("text.random");var c="";for(i=i||24,t=t||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";i>0;)c+=t.charAt(Math.floor(Math.random()*t.length)),i--;return c},f.text.match=f.text.match||function(i,t){var c,m;return n("text.match"),typeof i!="string"?!1:(typeof t=="string"&&(t={"=":t}),t=t||{},c=t["="]||t["*"]||t[">"]||t["<"],i===c?!0:m!==t["="]?!1:(c=t["*"]||t[">"]||t["<"],i.slice(0,(c||"").length)===c?!0:m!==t["*"]?!1:m!==t[">"]&&m!==t["<"]?i>=t[">"]&&i<=t["<"]:m!==t[">"]&&i>=t[">"]||m!==t["<"]&&i<=t["<"]))},f.text.hash=f.text.hash||function(i,t){if(n("text.hash"),typeof i=="string"){if(t=t||0,!i.length)return t;for(var c=0,m=i.length,R;c<m;++c)R=i.charCodeAt(c),t=(t<<5)-t+R,t|=0;return t}},f.list=f.list||{is:function(i){return n("list"),i instanceof Array}},f.list.slit=f.list.slit||Array.prototype.slice,f.list.sort=f.list.sort||function(i){return n("list.sort"),function(t,c){return!t||!c?0:(t=t[i],c=c[i],t<c?-1:t>c?1:0)}},f.list.map=f.list.map||function(i,t,c){return n("list.map"),O(i,t,c)},f.list.index=1,f.obj=f.boj||{is:function(i){return n("obj"),i?i instanceof Object&&i.constructor===Object||Object.prototype.toString.call(i).match(/^\[object (\w+)\]$/)[1]==="Object":!1}},f.obj.put=f.obj.put||function(i,t,c){return n("obj.put"),(i||{})[t]=c,i},f.obj.has=f.obj.has||function(i,t){return n("obj.has"),i&&Object.prototype.hasOwnProperty.call(i,t)},f.obj.del=f.obj.del||function(i,t){if(n("obj.del"),!!i)return i[t]=null,delete i[t],i},f.obj.as=f.obj.as||function(i,t,c,m){return n("obj.as"),i[t]=i[t]||(m===c?{}:c)},f.obj.ify=f.obj.ify||function(i){if(n("obj.ify"),r(i))return i;try{i=JSON.parse(i)}catch{i={}}return i},function(){var i;function t(c,m){x(this,m)&&i!==this[m]||(this[m]=c)}f.obj.to=f.obj.to||function(c,m){return n("obj.to"),m=m||{},O(c,t,m),m}}(),f.obj.copy=f.obj.copy||function(i){return n("obj.copy"),i&&JSON.parse(JSON.stringify(i))},function(){function i(t,c){var m=this.n,R;if(!(m&&(c===m||r(m)&&x(m,c)))&&R!==c)return!0}f.obj.empty=f.obj.empty||function(t,c){return n("obj.empty"),t?!O(t,i,{n:c}):!0}}(),function(){function i(m,R){if(arguments.length===2){i.r=i.r||{},i.r[m]=R;return}i.r=i.r||[],i.r.push(m)}var t=Object.keys,c;Object.keys=Object.keys||function(m){return c(m,function(R,E,$){$(E)})},f.obj.map=c=f.obj.map||function(m,R,E){n("obj.map");var $,I=0,G,B,H,U,M=typeof R=="function";if(i.r=$,t&&r(m)&&(H=t(m),U=!0),E=E||{},w(m)||H)for(G=(H||m).length;I<G;I++){var X=I+f.list.index;if(M){if(B=U?R.call(E,m[H[I]],H[I],i):R.call(E,m[I],X,i),B!==$)return B}else if(R===m[U?H[I]:I])return H?H[I]:X}else for(I in m)if(M){if(x(m,I)&&(B=E?R.call(E,m[I],I,i):R(m[I],I,i),B!==$))return B}else if(R===m[I])return I;return M?i.r:f.list.index?0:-1}}(),f.time=f.time||{},f.time.is=f.time.is||function(i){return n("time"),i?i instanceof Date:+new Date().getTime()};var T=f.fn.is,w=f.list.is,u=f.obj,r=u.is,x=u.has,O=u.map,e={};e.is=function(i){return n("val.is"),i===C?!1:i===null?!0:i===1/0?!1:g(i)||o(i)||d(i)?!0:e.link.is(i)||!1},e.link=e.rel={_:"#"},function(){e.link.is=function(t){if(n("val.link.is"),t&&t[a]&&!t._&&r(t)){var c={};if(O(t,i,c),c.id)return c.id}return!1};function i(t,c){var m=this;if(m.id)return m.id=!1;if(c==a&&g(t))m.id=t;else return m.id=!1}}(),e.link.ify=function(i){return n("val.link.ify"),N({},a,i)},f.obj.has._=".";var a=e.link._,C,o=f.bi.is,d=f.num.is,g=f.text.is,u=f.obj,r=u.is,N=u.put,O=u.map;f.val=f.val||e;var y={_:"_"};y.soul=function(i,t){return n("node.soul"),i&&i._&&i._[t||l]},y.soul.ify=function(i,t){return n("node.soul.ify"),t=typeof t=="string"?{soul:t}:t||{},i=i||{},i._=i._||{},i._[l]=t.soul||i._[l]||s(),i},y.soul._=e.link._,function(){y.is=function(t,c,m){n("node.is");var R;return r(t)&&(R=y.soul(t))?!O(t,i,{as:m,cb:c,s:R,n:t}):!1};function i(t,c){if(c!==y._){if(!e.is(t))return!0;this.cb&&this.cb.call(this.as,t,c,this.n,this.s)}}}(),function(){y.ify=function(t,c,m){return n("node.ify"),c?typeof c=="string"?c={soul:c}:typeof c=="function"&&(c={map:c}):c={},c.map&&(c.node=c.map.call(m,t,C,c.node||{})),(c.node=y.soul.ify(c.node||{},c))&&O(t,i,{o:c,as:m}),c.node};function i(t,c){var m=this.o,R,E;if(m.map){R=m.map.call(this.as,t,""+c,m.node),E===R?p(m.node,c):m.node&&(m.node[c]=R);return}e.is(t)&&(m.node[c]=t)}}();var u=f.obj,r=u.is,p=u.del,O=u.map,h=f.text,s=h.random,l=y.soul._,C;f.node=f.node||y;var k=f.state;k.lex=function(){return n("state.lex"),k().toString(36).replace(".","")},k.to=function(i,t,c){n("state.to");var m=(i||{})[t];return r(m)&&(m=P(m)),k.ify(c,t,k.is(i,t),m,y.soul(i))},function(){k.map=function(t,c,m){n("state.map");var R,E=r(E=t||c)?E:null;return t=T(t=t||c)?t:null,E&&!t?(c=d(c)?c:k(),E[v]=E[v]||{},O(E,i,{o:E,s:c}),E):(m=m||r(c)?c:R,c=d(c)?c:k(),function($,I,G,B){if(!t)return i.call({o:G,s:c},$,I),$;t.call(m||this||{},$,I,G,B),!(x(G,I)&&R===G[I])&&i.call({o:G,s:c},$,I)})};function i(t,c){v!==c&&k.ify(this.o,c,this.s)}}();var u=f.obj;u.as;var x=u.has,r=u.is,O=u.map,P=u.copy,D=f.num,d=D.is,A=f.fn,T=A.is,v=y._,C,j={};(function(){j.is=function(c,m,R,E){return n("graph.is"),!c||!r(c)||S(c)?!1:!O(c,i,{cb:m,fn:R,as:E})};function i(c,m){if(!c||m!==y.soul(c)||!y.is(c,this.fn,this.as))return!0;!this.cb||(t.n=c,t.as=this.as,this.cb.call(t.as,c,m,t))}function t(c){c&&y.is(t.n,c,t.as)}})(),function(){j.ify=function(E,$,I){n("graph.ify");var G={path:[],obj:E};return $?typeof $=="string"?$={soul:$}:typeof $=="function"&&($.map=$):$={},typeof I=="string"&&($.soul=$.soul||I,I=C),$.soul&&(G.link=e.link.ify($.soul)),$.shell=(I||{}).shell,$.graph=$.graph||{},$.seen=$.seen||[],$.as=$.as||I,i($,G),$.root=G.node,$.graph};function i(E,$){var I;return(I=R(E,$))?I:($.env=E,$.soul=c,y.ify($.obj,t,$)&&($.link=$.link||e.link.ify(y.soul($.node)),$.obj!==E.shell&&(E.graph[e.link.is($.link)]=$.node)),$)}function t(E,$,I){var G=this,B=G.env,H,U;if(y._===$&&x(E,e.link._))return I._;if(!!(H=m(E,$,I,G,B))){if($||(G.node=G.node||I||{},x(E,y._)&&y.soul(E)&&(G.node._=P(E._)),G.node=y.soul.ify(G.node,e.link.is(G.link)),G.link=G.link||e.link.ify(y.soul(G.node))),(U=B.map)&&(U.call(B.as||{},E,$,I,G),x(I,$))){if(E=I[$],C===E){p(I,$);return}if(!(H=m(E,$,I,G,B)))return}if(!$)return G.node;if(H===!0)return E;if(U=i(B,{obj:E,path:G.path.concat($)}),!!U.node)return U.link}}function c(E){var $=this,I=e.link.is($.link),G=$.env.graph;$.link=$.link||e.link.ify(E),$.link[e.link._]=E,$.node&&$.node[y._]&&($.node[y._][e.link._]=E),x(G,I)&&(G[E]=G[I],p(G,I))}function m(E,$,I,G,B){var H;if(e.is(E))return!0;if(r(E))return 1;if(H=B.invalid)return E=H.call(B.as||{},E,$,I),m(E,$,I,G,B);B.err="Invalid value at '"+G.path.concat($).join(".")+"'!",f.list.is(E)&&(B.err+=" Use `.set(item)` instead of an Array.")}function R(E,$){for(var I=E.seen,G=I.length,B;G--;)if(B=I[G],$.obj===B.obj)return B;I.push($)}}(),j.node=function(i){n("graph.node");var t=y.soul(i);if(!!t)return N({},t,i)},function(){j.to=function(t,c,m){if(n("graph.to"),!!t){var R={};return m=m||{seen:{}},O(t[c],i,{obj:R,graph:t,opt:m}),R}};function i(t,c){var m,R;if(y._===c){if(S(t,e.link._))return;this.obj[c]=P(t);return}if(!(m=e.link.is(t))){this.obj[c]=t;return}if(R=this.opt.seen[m]){this.obj[c]=R;return}this.obj[c]=this.opt.seen[m]=j.to(this.graph,m,this.opt)}}();var T=f.fn.is,u=f.obj,r=u.is,p=u.del,x=u.has,S=u.empty,N=u.put,O=u.map,P=u.copy,C;f.graph=f.graph||j}}()}});q();Y();var pt=hn();const bn="_App_sggzw_1",gn="_TestnetBankContainer_sggzw_51",jt={App:bn,TestnetBankContainer:gn},Dt=F('<input type="text">'),yn=F("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),mn=F("<table><tbody><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),vn=F("<table><tbody></tbody></table>"),kn=F("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),Tn=F("<div><div>Deploy:</div><pre></pre><button>Deploy</button></div>"),Sn=F("<div><pre></pre><button>Request</button></div>"),An=F("<div><button>Load</button></div>"),wn=F("<div><button></button></div>"),$n=F('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),xn=F('<table><tbody><tr><td><a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">https://github.com/fc1943s/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">https://fc1943s.github.io/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">https://fc1943s.github.io/tictactoe_spiral/docs</a></td></tr></tbody></table>'),On=F("<div><table><tbody><tr><td>Chain Connection</td><td></td></tr><tr><td>Database Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Game</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr><tr><td>Links</td><td></td></tr></tbody></table></div>"),En=pt.__esModule?pt.default:pt,tt={npm_package_scripts_outdated_pre:"ncu --pre 1 -t greatest",DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_package_devDependencies__esbuild_plugins_node_globals_polyfill:"^0.1",npm_config_user_agent:"pnpm/6.33.0 npm/? node/v16.15.1 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_da71803f-bef6-466a-909f-181be7448da3",PIPX_HOME:"/opt/pipx",npm_package_devDependencies_vite:"^3.0.0-beta.6",npm_node_execpath:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"",npm_package_scripts_playwright_install:"playwright install --with-deps && playwright install msedge",npm_package_scripts_serve:"vite preview",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",npm_package_dependencies_rusty_gun:"^0.1.2",npm_package_devDependencies_typescript:"^4.7",NVM_DIR:"/home/runner/.nvm",npm_package_devDependencies_playwright_core:"^1.22",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220626.1",npm_package_scripts_dev:"vite",npm_package_devDependencies__playwright_test:"^1.22",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",npm_package_dependencies_solid_js:"^1.4",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22798",GITHUB_WORKFLOW:"E2E + A11y Tests",_:"/home/runner/setup-pnpm/node_modules/.bin/pnpm",npm_package_dependencies_storeon:"^3.1",npm_config_registry:"https://registry.npmjs.org/",GITHUB_RUN_ID:"2639529307",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",npm_package_dependencies_algosdk:"^1.18",npm_package_devDependencies_path_browserify:"^1.0",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"",ImageOS:"ubuntu20",npm_package_scripts_start:"vite",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"",npm_config_node_gyp:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node_modules/node-gyp/bin/node-gyp.js",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node-gyp-bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.15.1/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_22ece1d5-17b5-4a83-851c-2eae2b800bbe",INVOCATION_ID:"ee3b9d009197456c879c40d39f75b752",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",npm_package_name:"tictactoe_spiral_web",npm_package_scripts_extension:"vite build --outDir dist_extension && mkdir ./dist_extension/tictactoe_spiral && mv ./dist_extension/assets/content_script.*.js ./dist_extension/assets/content_script.js && mv ./dist_extension/assets/App.*.css ./dist_extension/assets/App.css && mv ./dist_extension/assets ./dist_extension/tictactoe_spiral/assets && cp background.js content_script.js ./dist_extension",NODE:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",GITHUB_ACTION:"__run_3",GITHUB_RUN_NUMBER:"13",RUNNER_ARCH:"X64",XDG_RUNTIME_DIR:"/run/user/1001",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",npm_package_dependencies_solid_icons:"^0.5",npm_package_devDependencies_axe_playwright:"^1.1",npm_package_devDependencies_vite_plugin_solid:"^2.2",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",npm_package_scripts_e2e:"playwright test",npm_lifecycle_script:"vite build --outDir dist",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",STATS_PFS:"true",NODE_PATH:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/node_modules:/home/runner/setup-pnpm/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",npm_package_version:"0.0.1",npm_package_devDependencies_npm_check_updates:"^15.0",npm_lifecycle_event:"build",GITHUB_REF_PROTECTED:"false",npm_package_scripts_build:"vite build --outDir dist",npm_package_dependencies_buffer:"^6.0",npm_config_argv:'{"remain":["run","build"],"cooked":["run","build"],"original":["run","build"]}',GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"834adde0fae99246dc19a19e2c055f716624b8b8",GITHUB_RUN_ATTEMPT:"1",npm_package_dependencies__storeon_solidjs:"^3.0",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_da71803f-bef6-466a-909f-181be7448da3",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",npm_package_devDependencies_esbuild_plugin_wasm:"^1.0.0",npm_execpath:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/pnpm.cjs",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",npm_package_devDependencies_esbuild:"^0.14",PNPM_SCRIPT_SRC_DIR:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",npm_package_dependencies_gun:"^0.2020.1237",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_da71803f-bef6-466a-909f-181be7448da3",INIT_CWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",NODE_ENV:"production"}.CODESPACE_NAME,jn={token:on,chainUrl:tt?`http://${tt}-4001.githubpreview.dev`:an,chainPort:tt?80:un,dbUrl:tt?`ws://${tt}-8765.githubpreview.dev`:"ws://localhost",dbPort:tt?80:8765,accounts:ln,status:{},deploy:{}},Dn=Gt([b=>{b.on("@init",()=>jn),b.on("set",(_,n)=>n)}]);function rt({key:b}){const[_,n]=ot();return(()=>{const f=Dt.cloneNode(!0);return f.$$input=w=>n("set",{[b]:w.currentTarget.value}),V(()=>f.value=_[b]),f})()}function Nn(){return(()=>{const b=yn.cloneNode(!0),_=b.firstChild,n=_.firstChild,f=n.firstChild,w=f.nextSibling,e=n.nextSibling,a=e.firstChild,o=a.nextSibling,g=e.nextSibling,y=g.firstChild,h=y.nextSibling;return L(w,J(rt,{key:"token"})),L(o,J(rt,{key:"chainUrl"})),L(h,J(rt,{key:"chainPort"})),b})()}function Rn(){return(()=>{const b=mn.cloneNode(!0),_=b.firstChild,n=_.firstChild,f=n.firstChild,w=f.nextSibling,e=n.nextSibling,a=e.firstChild,o=a.nextSibling;return L(w,J(rt,{key:"dbUrl"})),L(o,J(rt,{key:"dbPort"})),b})()}function At({key:b,account:_}){const[n,f]=ot();return(()=>{const w=Dt.cloneNode(!0);return w.$$input=e=>f("set",{accounts:n.accounts.map(a=>a.alias===_.alias?{...a,[b]:e.currentTarget.value}:a)}),V(()=>w.value=_[b]),w})()}function Pn(){const[b]=ot();return(()=>{const _=vn.cloneNode(!0),n=_.firstChild;return L(n,J(Bt,{get each(){return b.accounts},children:f=>(()=>{const w=kn.cloneNode(!0),e=w.firstChild,a=e.nextSibling,o=a.firstChild,g=o.firstChild,y=g.firstChild,h=y.firstChild,s=h.nextSibling,l=y.nextSibling,k=l.firstChild,D=k.nextSibling;return L(e,()=>f.alias),L(s,J(At,{account:f,key:"address"})),L(D,J(At,{account:f,key:"privateKey"})),w})()})),_})()}function In(){const[b,_]=ot(),n=async()=>{const f=b.accounts[0]?.address,w=b.accounts[0]?.privateKey;if(f&&w){const e=Et(b.token,b.chainUrl,b.chainPort);try{const a=await nn(e,f,w,en,rn,{numGlobalByteSlices:sn,numGlobalInts:fn});_("set",{deploy:a})}catch(a){_("set",{deploy:a})}}else alert("Invalid admin account")};return(()=>{const f=Tn.cloneNode(!0),w=f.firstChild,e=w.nextSibling,a=e.nextSibling;return L(e,()=>JSON.stringify(b.deploy,null,2)),a.$$click=n,f})()}function Gn(){const[b,_]=ot(),[n,f]=it(null),[w,e]=it(null),[a,o]=it(-1),g=()=>({status:Object.entries(b.status),gunRs:n(),gunJs:w(),subscriptionRs:a()}),y=(...s)=>{console.log("@@@",...s,g())};y("App.Status()"),wt($t(()=>[],()=>{y("App.Status.createEffect() callback");const s=new Ut(`${b.dbUrl}:${b.dbPort}/gun`);f(s);const l=new En(`${b.dbUrl}:${b.dbPort}/gun`);e(l),setTimeout(()=>{y("App.Status.createEffect() callback .setTimeout() callback"),o(s.get("app").get("status").on((k,D)=>{y("App.Status.createEffect() callback _gunRs.on() callback",{k:D,v:k}),_("set",{status:typeof k=="string"?JSON.parse(k):k})})),l.get("app").get("status").on((k,D)=>{y("App.Status.createEffect() callback _gunJs.on() callback",{k:D,v:k}),_("set",{status:typeof k=="string"?JSON.parse(k):k})})},1e3)})),Ht(()=>{y("App.Status.onCleanup() callback");const s=n();s&&s.get("app").get("status").off(a());const l=w();l&&l.get("app").get("status").off()});const h=async()=>{y("App.Status.request()");const s=Et(b.token,b.chainUrl,b.chainPort),l=n();try{const k=await s.status().do();_("set",{status:k}),l&&l.get("app").get("status").put(k)}catch(k){_("set",{status:k}),l&&l.get("app").get("status").put(k)}};return(()=>{const s=Sn.cloneNode(!0),l=s.firstChild,k=l.nextSibling;return L(l,()=>JSON.stringify(b.status,null,2)),k.$$click=h,s})()}function Cn(){const[b,_]=it(!1),[n,f]=it(!1);return wt($t(()=>[n()],()=>n()&&f(!1))),st((()=>{const w=st(()=>!b(),!0);return()=>w()?(()=>{const e=An.cloneNode(!0),a=e.firstChild;return a.$$click=()=>_(!0),e})():(()=>{const e=wn.cloneNode(!0),a=e.firstChild;return a.$$click=()=>f(!0),L(a,J(_n,{size:"24px"})),L(e,(()=>{const o=st(()=>!n(),!0);return()=>o()&&$n.cloneNode(!0)})(),null),V(()=>e.className=jt.TestnetBankContainer),e})()})())}function Bn(){return xn.cloneNode(!0)}function Jn(){return J(Ct,{store:Dn,get children(){const b=On.cloneNode(!0),_=b.firstChild,n=_.firstChild,f=n.firstChild,w=f.firstChild,e=w.nextSibling,a=f.nextSibling,o=a.firstChild,g=o.nextSibling,y=a.nextSibling,h=y.firstChild,s=h.nextSibling,l=y.nextSibling,k=l.firstChild,D=k.nextSibling,d=l.nextSibling,A=d.firstChild,v=A.nextSibling,j=d.nextSibling,T=j.firstChild,u=T.nextSibling,r=j.nextSibling,p=r.firstChild,x=p.nextSibling;return L(e,J(Nn,{})),L(g,J(Rn,{})),L(s,J(Pn,{})),L(D,J(Gn,{})),L(v,J(In,{})),L(u,J(Cn,{})),L(x,J(Bn,{})),V(()=>b.className=jt.App),b}})}xt(["input","click"]);export{Jn as A,Ln as r};
