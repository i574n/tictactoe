import{i as Q,a as Z,k as Ht,s as W,l as V,m as Lt,f as Ut,h as Mt,n as Jt,j as J,S as Ft,u as z,F as Xt,o as ct,q as bt,r as gt,t as ht}from"./solid.34dc2fa6.js";import{a as lt}from"./algosdk.15cb4a09.js";import{N as $t}from"./gun.0a33b3da.js";Q();Z();var Kt=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],Vt=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...Kt]),Wt=new Set(["innerHTML","textContent","innerText","children"]),zt={className:"class",htmlFor:"for"},At={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},qt=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),Yt={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function st(d,_){return Lt(d,void 0,_?void 0:{equals:_})}function Qt(d,_,t){let s=t.length,T=_.length,e=s,a=0,i=0,g=_[T-1].nextSibling,v=null;for(;a<T||i<e;){if(_[a]===t[i]){a++,i++;continue}for(;_[T-1]===t[e-1];)T--,e--;if(T===a){const b=e<s?i?t[i-1].nextSibling:t[e-i]:g;for(;i<e;)d.insertBefore(t[i++],b)}else if(e===i)for(;a<T;)(!v||!v.has(_[a]))&&_[a].remove(),a++;else if(_[a]===t[e-1]&&t[i]===_[T-1]){const b=_[--T].nextSibling;d.insertBefore(t[i++],_[a++].nextSibling),d.insertBefore(t[--e],b),_[T]=t[e]}else{if(!v){v=new Map;let f=i;for(;f<e;)v.set(t[f],f++)}const b=v.get(_[a]);if(b!=null)if(i<b&&b<e){let f=a,p=1,w;for(;++f<T&&f<e&&!((w=v.get(_[f]))==null||w!==b+p);)p++;if(p>b-i){const D=_[a];for(;i<b;)d.insertBefore(t[i++],D)}else d.replaceChild(t[i++],_[a++])}else a++;else _[a++].remove()}}}var wt="_$DX_DELEGATE";function Fn(d,_,t){let s;return Ht(T=>{s=T,_===document?d():U(_,d(),_.firstChild?null:void 0,t)}),()=>{s(),_.textContent=""}}function X(d,_,t){const s=document.createElement("template");s.innerHTML=d;let T=s.content.firstChild;return t&&(T=T.firstChild),T}function Rt(d,_=window.document){const t=_[wt]||(_[wt]=new Set);for(let s=0,T=d.length;s<T;s++){const e=d[s];t.has(e)||(t.add(e),_.addEventListener(e,on))}}function ft(d,_,t){t==null?d.removeAttribute(_):d.setAttribute(_,t)}function Zt(d,_,t,s){s==null?d.removeAttributeNS(_,t):d.setAttributeNS(_,t,s)}function tn(d,_){_==null?d.removeAttribute("class"):d.className=_}function Y(d,_,t,s){s?Array.isArray(t)?(d[`$$${_}`]=t[0],d[`$$${_}Data`]=t[1]):d[`$$${_}`]=t:Array.isArray(t)?d.addEventListener(_,T=>t[0](t[1],T)):d.addEventListener(_,t)}function nn(d,_,t={}){const s=Object.keys(_||{}),T=Object.keys(t);let e,a;for(e=0,a=T.length;e<a;e++){const i=T[e];!i||i==="undefined"||_[i]||(xt(d,i,!1),delete t[i])}for(e=0,a=s.length;e<a;e++){const i=s[e],g=!!_[i];!i||i==="undefined"||t[i]===g||!g||(xt(d,i,!0),t[i]=g)}return t}function It(d,_,t={}){const s=d.style,T=typeof t=="string";if(_==null&&T||typeof _=="string")return s.cssText=_;T&&(s.cssText=void 0,t={}),_||(_={});let e,a;for(a in t)_[a]==null&&s.removeProperty(a),delete t[a];for(a in _)e=_[a],e!==t[a]&&(s.setProperty(a,e),t[a]=e);return t}function kt(d,_,t,s){typeof _=="function"?V(T=>Et(d,_(),T,t,s)):Et(d,_,void 0,t,s)}function U(d,_,t,s){if(t!==void 0&&!s&&(s=[]),typeof _!="function")return it(d,_,s,t);V(T=>it(d,_(),T,t),s)}function en(d,_,t,s,T={},e=!1){_||(_={});for(const a in T)if(!(a in _)){if(a==="children")continue;Ot(d,a,null,T[a],t,e)}for(const a in _){if(a==="children"){s||it(d,_.children);continue}const i=_[a];T[a]=Ot(d,a,i,T[a],t,e)}}function rn(d){return d.toLowerCase().replace(/-([a-z])/g,(_,t)=>t.toUpperCase())}function xt(d,_,t){const s=_.trim().split(/\s+/);for(let T=0,e=s.length;T<e;T++)d.classList.toggle(s[T],t)}function Ot(d,_,t,s,T,e){let a,i,g;if(_==="style")return It(d,t,s);if(_==="classList")return nn(d,t,s);if(t===s)return s;if(_==="ref")e||t(d);else if(_.slice(0,3)==="on:")d.addEventListener(_.slice(3),t);else if(_.slice(0,10)==="oncapture:")d.addEventListener(_.slice(10),t,!0);else if(_.slice(0,2)==="on"){const v=_.slice(2).toLowerCase(),b=qt.has(v);Y(d,v,t,b),b&&Rt([v])}else if((g=Wt.has(_))||!T&&(At[_]||(i=Vt.has(_)))||(a=d.nodeName.includes("-")))_==="class"||_==="className"?tn(d,t):a&&!i&&!g?d[rn(_)]=t:d[At[_]||_]=t;else{const v=T&&_.indexOf(":")>-1&&Yt[_.split(":")[0]];v?Zt(d,v,_,t):ft(d,zt[_]||_,t)}return t}function on(d){const _=`$$${d.type}`;let t=d.composedPath&&d.composedPath()[0]||d.target;for(d.target!==t&&Object.defineProperty(d,"target",{configurable:!0,value:t}),Object.defineProperty(d,"currentTarget",{configurable:!0,get(){return t||document}}),W.registry&&!W.done&&(W.done=!0,document.querySelectorAll("[id^=pl-]").forEach(s=>s.remove()));t!==null;){const s=t[_];if(s&&!t.disabled){const T=t[`${_}Data`];if(T!==void 0?s(T,d):s(d),d.cancelBubble)return}t=t.host&&t.host!==t&&t.host instanceof Node?t.host:t.parentNode}}function Et(d,_,t={},s,T){return _||(_={}),!T&&"children"in _&&V(()=>t.children=it(d,_.children,t.children)),_.ref&&_.ref(d),V(()=>en(d,_,s,!0,t,!0)),t}function it(d,_,t,s,T){for(W.context&&!t&&(t=[...d.childNodes]);typeof t=="function";)t=t();if(_===t)return t;const e=typeof _,a=s!==void 0;if(d=a&&t[0]&&t[0].parentNode||d,e==="string"||e==="number"){if(W.context)return t;if(e==="number"&&(_=_.toString()),a){let i=t[0];i&&i.nodeType===3?i.data=_:i=document.createTextNode(_),t=nt(d,t,s,i)}else t!==""&&typeof t=="string"?t=d.firstChild.data=_:t=d.textContent=_}else if(_==null||e==="boolean"){if(W.context)return t;t=nt(d,t,s)}else{if(e==="function")return V(()=>{let i=_();for(;typeof i=="function";)i=i();t=it(d,i,t,s)}),()=>t;if(Array.isArray(_)){const i=[];if(_t(i,_,T))return V(()=>t=it(d,i,t,s,!0)),()=>t;if(W.context){for(let g=0;g<i.length;g++)if(i[g].parentNode)return t=i}if(i.length===0){if(t=nt(d,t,s),a)return t}else Array.isArray(t)?t.length===0?Nt(d,i,s):Qt(d,t,i):(t&&nt(d),Nt(d,i));t=i}else if(_ instanceof Node){if(W.context&&_.parentNode)return t=a?[_]:_;if(Array.isArray(t)){if(a)return t=nt(d,t,s,_);nt(d,t,null,_)}else t==null||t===""||!d.firstChild?d.appendChild(_):d.replaceChild(_,d.firstChild);t=_}}return t}function _t(d,_,t){let s=!1;for(let T=0,e=_.length;T<e;T++){let a=_[T],i;if(a instanceof Node)d.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))s=_t(d,a)||s;else if((i=typeof a)=="string")d.push(document.createTextNode(a));else if(i==="function")if(t){for(;typeof a=="function";)a=a();s=_t(d,Array.isArray(a)?a:[a])||s}else d.push(a),s=!0;else d.push(document.createTextNode(a.toString()))}return s}function Nt(d,_,t){for(let s=0,T=_.length;s<T;s++)d.insertBefore(_[s],t)}function nt(d,_,t,s){if(t===void 0)return d.textContent="";const T=s||document.createTextNode("");if(_.length){let e=!1;for(let a=_.length-1;a>=0;a--){const i=_[a];if(T!==i){const g=i.parentNode===d;!e&&!a?g?d.replaceChild(T,i):d.insertBefore(T,t):g&&i.remove()}else e=!0}}else d.insertBefore(T,t);return[T]}Q();Z();var dt=d=>new Uint8Array(Buffer.from(d,"base64")),an=(d,_,t)=>new lt.Algodv2(d,_,t),jt={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},un=async(d,_,t,s,T,e=jt)=>{try{const a=await d.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const i=await d.compile(s).do(),g=await d.compile(T).do(),v=lt.makeApplicationCreateTxnFromObject({suggestedParams:a,from:_,onComplete:lt.OnApplicationComplete.NoOpOC,approvalProgram:dt(i.result),clearProgram:dt(g.result),...jt,...e}),b=v.signTxn(dt(t)),{txId:f}=await d.sendRawTransaction(b).do(),p=await lt.waitForConfirmation(d,f,5),w=p["application-index"];return{suggestedParams:a,applicationStartCompiled:i,clearProgramCompiled:g,txn:v,txnSigned:b,txId:f,transactionResponse:p,appId:w}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}},ln=5,sn=4,fn="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",cn="http://localhost",dn=4001,pn=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}];const hn=`#pragma version 6
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
return`,_n=`#pragma version 6
int 1
return`;Q();Z();Q();Z();Q();Z();var bn=X('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),gn=X("<title></title>");function yn(d,_){return(()=>{const t=bn.cloneNode(!0);return kt(t,()=>d.a,!0,!0),kt(t,_,!0,!0),U(t,()=>d.c,null),U(t,(()=>{const s=st(()=>!!_.title,!0);return()=>s()&&(()=>{const T=gn.cloneNode(!0);return U(T,()=>_.title),T})()})(),null),V(s=>{const T=d.a.stroke,e={..._.style,overflow:"visible",color:_.color},a=_.size||"1em",i=_.size||"1em",g=d.c;return T!==s._v$&&ft(t,"stroke",s._v$=T),s._v$2=It(t,e,s._v$2),a!==s._v$3&&ft(t,"height",s._v$3=a),i!==s._v$4&&ft(t,"width",s._v$4=i),g!==s._v$5&&(t.innerHTML=s._v$5=g),s},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),t})()}function mn(d){return yn({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},d)}var vn=Ut({"node_modules/.pnpm/gun@0.2020.1237/node_modules/gun/gun.js"(d,_){Q(),Z(),function(){function t(T,e){return e?Mt(T):T.slice?t[a(T)]:function(i,g){T(i={exports:{}}),t[a(g)]=i.exports};function a(i){return i.split("/").slice(-1).toString().replace(".js","")}}if(typeof _<"u")var s=_;t(function(T){String.random=function(a,i){var g="";for(a=a||24,i=i||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";a-- >0;)g+=i.charAt(Math.floor(Math.random()*i.length));return g},String.match=function(a,i){var g,v;return typeof a!="string"?!1:(typeof i=="string"&&(i={"=":i}),i=i||{},g=i["="]||i["*"]||i[">"]||i["<"],a===g?!0:v!==i["="]?!1:(g=i["*"]||i[">"],a.slice(0,(g||"").length)===g?!0:v!==i["*"]?!1:v!==i[">"]&&v!==i["<"]?a>=i[">"]&&a<=i["<"]:v!==i[">"]&&a>=i[">"]||v!==i["<"]&&a<=i["<"]))},String.hash=function(a,i){if(typeof a=="string"){if(i=i||0,!a.length)return i;for(var g=0,v=a.length,b;g<v;++g)b=a.charCodeAt(g),i=(i<<5)-i+b,i|=0;return i}};var e=Object.prototype.hasOwnProperty;Object.plain=function(a){return a?a instanceof Object&&a.constructor===Object||Object.prototype.toString.call(a).match(/^\[object (\w+)\]$/)[1]==="Object":!1},Object.empty=function(a,i){for(var g in a)if(e.call(a,g)&&(!i||i.indexOf(g)==-1))return!1;return!0},Object.keys=Object.keys||function(a){var i=[];for(var g in a)e.call(a,g)&&i.push(g);return i},function(){var a,i=setTimeout,g=0,v=0,b=typeof setImmediate!=""+a&&setImmediate||i;i.hold=i.hold||9,i.poll=i.poll||function(f){if(i.hold>=+new Date-g&&v++<3333){f();return}b(function(){g=+new Date,f()},v=0)}}(),function(){var a=setTimeout,i=a.turn=a.turn||function(w){g.push(w)==1&&v(p)},g=i.s=[],v=a.poll,b=0,f,p=function(){(f=g[b++])&&f(),(b==g.length||b==99)&&(g=i.s=g.slice(b),b=0),g.length&&v(p)}}(),function(){var a,i=setTimeout,g=i.turn;(i.each=i.each||function(v,b,f,p){p=p||9,function w(D,h,A){if(h=(D=(v||[]).splice(0,p)).length){for(var m=0;m<h&&a===(A=b(D[m]));m++);if(a===A){g(w);return}}f&&f(A)}()})()}()})(t,"./shim"),t(function(T){T.exports=function e(f,i,g){if(!f)return{to:e};var v,b=typeof i=="function",f=(this.tag||(this.tag={}))[f]||b&&(this.tag[f]={tag:f,to:e._={next:function(w){var D;(D=this.to)&&D.next(w)}}});if(b){var p={off:e.off||(e.off=function(){if(this.next===e._.next)return!0;this===this.the.last&&(this.the.last=this.back),this.to.back=this.back,this.next=e._.next,this.back.to=this.to,this.the.last===this.the&&delete this.on.tag[this.the.tag]}),to:e._,next:i,the:f,on:this,as:g};return(p.back=f.last||f).to=p,f.last=p}return(f=f.to)&&v!==i&&f.next(i),f}})(t,"./onto"),t(function(T){T.exports=function(e){return e===null||typeof e=="string"||typeof e=="boolean"||typeof e=="number"&&e!=1/0&&e!=-1/0&&e===e||!!e&&typeof e["#"]=="string"&&Object.keys(e).length===1&&e["#"]}})(t,"./valid"),t(function(T){t("./shim");function e(){var f=+new Date;return v<f?(i=0,v=f+e.drift):v=f+(i+=1)/g+e.drift}e.drift=0;var a=-1/0,i=0,g=999,v=a,b;e.is=function(f,p,w){var D=p&&f&&f._&&f._[">"]||w;if(!!D)return typeof(D=D[p])=="number"?D:a},e.ify=function(f,p,w,D,h){(f=f||{})._=f._||{},h&&(f._["#"]=h);var A=f._[">"]||(f._[">"]={});return b!==p&&p!=="_"&&(typeof w=="number"&&(A[p]=w),b!==D&&(f[p]=D)),f},T.exports=e})(t,"./state"),t(function(T){t("./shim");function e(a){var i={s:{}},g=i.s;a=a||{max:999,age:1e3*9},i.check=function(b){return g[b]?v(b):!1};var v=i.track=function(b){var f=g[b]||(g[b]={});return f.was=i.now=+new Date,i.to||(i.to=setTimeout(i.drop,a.age+9)),f};return i.drop=function(b){i.to=null,i.now=+new Date;var f=Object.keys(g);console.STAT&&console.STAT(i.now,+new Date-i.now,"dup drop keys"),setTimeout.each(f,function(p){var w=g[p];w&&(b||a.age)>i.now-w.was||delete g[p]},0,99)},i}T.exports=e})(t,"./dup"),t(function(T){t("./onto"),T.exports=function(i,g){if(!!this.on){var v=(this.opt||{}).lack||9e3;if(typeof i!="function"){if(!i)return;var f=i["#"]||i,b=(this.tag||"")[f];return b?(g&&(b=this.on(f,g),clearTimeout(b.err),b.err=setTimeout(function(){b.off()},v)),!0):void 0}var f=g&&g["#"]||e(9);if(!i)return f;var p=this.on(f,i,g);return p.err=p.err||setTimeout(function(){p.off(),p.next({err:"Error: No ACK yet.",lack:!0})},v),f}};var e=String.random||function(){return Math.random().toString(36).slice(2)}})(t,"./ask"),t(function(T){function e(h){return h instanceof e?(this._={$:this}).$:this instanceof e?e.create(this._={$:this,opt:h}):new e(h)}e.is=function(h){return h instanceof e||h&&h._&&h===h._.$||!1},e.version=.202,e.chain=e.prototype,e.chain.toJSON=function(){},t("./shim"),e.valid=t("./valid"),e.state=t("./state"),e.on=t("./onto"),e.dup=t("./dup"),e.ask=t("./ask"),function(){e.create=function(n){n.root=n.root||n,n.graph=n.graph||{},n.on=n.on||e.on,n.ask=n.ask||e.ask,n.dup=n.dup||e.dup();var c=n.$.opt(n.opt);return n.once||(n.on("in",h,n),n.on("out",h,n),n.on("put",O,n),e.on("create",n),n.on("create",n)),n.once=1,c};function h(n){if(!!n){if(n.out===h){this.to.next(n);return}var c=this,S=c.as,R=S.at||S,N=R.$,k=R.dup,P,C=n.DBG;if((P=n["#"])||(P=n["#"]=i(9)),!k.check(P)){if(k.track(P),P=n._,n._=typeof P=="function"?P:function(){},n.$&&n.$===(n.$._||"").$||(n.$=N),n["@"]&&!n.put&&u(n),!R.ask(n["@"],n))if(C&&(C.u=+new Date),n.put){A(n);return}else n.get&&e.on.get(n,N);C&&(C.uc=+new Date),c.to.next(n),C&&(C.ua=+new Date),!(n.nts||n.NTS)&&(n.out=h,R.on("out",n),C&&(C.ue=+new Date))}}}function A(n){if(!!n){var c=n._||"",S=c.root=((c.$=n.$||"")._||"").root;if(n["@"]&&c.faith&&!c.miss){n.out=h,S.on("out",n);return}c.latch=S.hatch,c.match=S.hatch=[];var R=n.put,N=c.DBG=n.DBG,k=+new Date;if(G=G||k,!(R["#"]&&R["."])){N&&(N.p=k),c["#"]=n["#"],c.msg=n,c.all=0,c.stun=1;var P=Object.keys(R);console.STAT&&console.STAT(k,((N||c).pk=+new Date)-k,"put sort");var C=0,B,H,L,M,F,K,rt;(function tt(at){if(B!=C){if(B=C,!(L=P[C])){console.STAT&&console.STAT(k,((N||c).pd=+new Date)-k,"put"),y(c);return}(M=R[L])?(rt=M._)?L!==rt["#"]?K=l+x(L)+"soul not same.":(F=rt[">"])||(K=l+x(L)+"no state."):K=l+x(L)+"no meta.":K=l+x(L)+"no node.",H=Object.keys(M||{})}if(K){n.err=c.err=K,y(c);return}var St=0,q;for(at=at||0;at++<9&&(q=H[St++]);)if(q!=="_"){var ut=M[q],Tt=F[q];if(p===Tt){K=l+x(q)+"on"+x(L)+"no state.";break}if(!v(ut)){K=l+x(q)+"on"+x(L)+"bad "+typeof ut+x(ut);break}m(ut,q,L,Tt,n),++I}if((H=H.slice(St)).length){g(tt);return}++C,H=null,tt(at)})()}}}e.on.put=A;function m(n,c,S,R,N){var k=N._||"",P=k.root,C=P.graph,B,H=C[S]||w,L=b(H,c,1),M=H[c],F=k.DBG;(B=console.STAT)&&(!C[S]||!M)&&(B.has=(B.has||0)+1);var K=E();if(R>K){setTimeout(function(){m(n,c,S,R,N)},(B=R-K)>j?j:B),console.STAT&&console.STAT((F||k).Hf=+new Date,B,"future");return}if(!(R<L&&!k.miss)&&!(!k.faith&&R===L&&(n===M||$(n)<=$(M))&&!k.miss)){k.stun++;var rt=N["#"]+k.all++,tt={toString:function(){return rt},_:k};tt.toJSON=tt.toString,F&&(F.ph=F.ph||+new Date),P.on("put",{"#":tt,"@":N["@"],put:{"#":S,".":c,":":n,">":R},_:k})}}function O(n){var c;(c=(n._||"").DBG)&&(c.pa=+new Date,c.pm=c.pm||+new Date);var S=this,R=S.as,N=R.graph,k=n._,P=n.put,C=P["#"],B=P["."],H=P[":"],L=P[">"];n["#"];var M;(M=k.msg)&&(M=M.put)&&(M=M[C])&&f(M,B,L,H,C),N[C]=f(N[C],B,L,H,C),(M=(R.next||"")[C])&&M.on("in",n),y(k),S.to.next(n)}function y(n,c){var S;if(!n.stop&&!(!n.err&&0<--n.stun)&&(n.stop=1,!!(S=n.root))){var R=n.match;R.end=1,R===S.hatch&&(!(R=n.latch)||R.end?delete S.hatch:S.hatch=R),n.hatch&&n.hatch(),setTimeout.each(n.match,function(N){N&&N()}),!(!(c=n.msg)||n.err||c.err)&&(c.out=h,n.root.on("out",c),r())}}function u(n){var c=n["@"]||"",S;!(S=c._)||(S.acks=(S.acks||0)+1,(S.err=n.err)&&(n["@"]=S["#"],y(S)),!S.stop&&!S.crack&&(S.crack=S.match&&S.match.push(function(){o(S)})),o(S))}function o(n){!n||!n.root||n.stun||n.acks!==n.all||n.root.on("in",{"@":n["#"],err:n.err,ok:n.err?p:{"":1}})}var l="Error: Invalid graph!",x=function(n){return" '"+(""+n).slice(0,9)+"...' "},$=JSON.stringify,j=2147483647,E=e.state,I=0,G,r=function(){I>999&&I/-(G-(G=+new Date))>1&&(e.window&&console.log("Warning: You're syncing 1K+ records a second, faster than DOM can update - consider limiting query."),r=function(){I=0})}}(),function(){e.on.get=function(A,m){var O=m._,y=A.get,u=y["#"],o=O.graph[u],l=y["."],x=O.next||(O.next={});x[u];var $=A._||{},j=$.DBG=A.DBG;if(j&&(j.g=+new Date),!o)return O.on("get",A);if(l){if(typeof l!="string"||p===o[l])return O.on("get",A);o=f({},l,b(o,l),o[l],u)}o&&h(A,o),O.on("get",A)};function h(A,m){var O=+new Date,y=A._||{},u=y.DBG=A.DBG,o=A["#"],l=i(9),x=Object.keys(m||"").sort(),$=((m||"")._||"")["#"];x.length;var j=A.$._.root,E=m===j.graph[$];console.STAT&&console.STAT(O,((u||y).gk=+new Date)-O,"got keys"),m&&function I(){O=+new Date;for(var G=0,r,n={},c;G<9&&(r=x[G++]);)f(n,r,b(m,r),m[r],$);x=x.slice(G),(c={})[$]=n,n=c;var S;E&&(S=function(){},S.ram=S.faith=!0),c=x.length,console.STAT&&console.STAT(O,-(O-(O=+new Date)),"got copied some"),u&&(u.ga=+new Date),j.on("in",{"@":o,"#":l,put:n,"%":c?l=i(9):p,$:j.$,_:S,DBG:u}),console.STAT&&console.STAT(O,+new Date-O,"got in"),c&&setTimeout.turn(I)}(),m||j.on("in",{"@":A["#"]})}e.on.get.ack=h}(),function(){e.chain.opt=function(h){h=h||{};var A=this,m=A._,O=h.peers||h;return Object.plain(h)||(h={}),Object.plain(m.opt)||(m.opt=h),typeof O=="string"&&(O=[O]),Object.plain(m.opt.peers)||(m.opt.peers={}),O instanceof Array&&(h.peers={},O.forEach(function(y){var u={};u.id=u.url=y,h.peers[y]=m.opt.peers[y]=m.opt.peers[y]||u})),a(h,function y(u){var o=this[u];if(this&&this.hasOwnProperty(u)||typeof o=="string"||Object.empty(o)){this[u]=o;return}o&&o.constructor!==Object&&!(o instanceof Array)||a(o,y)}),m.opt.from=h,e.on("opt",m),m.opt.uuid=m.opt.uuid||function(u){return e.state().toString(36).replace(".","")+String.random(u||12)},A}}();var a=function(h,A){Object.keys(h).forEach(A,h)},i=String.random,g=setTimeout.turn,v=e.valid,b=e.state.is,f=e.state.ify,p,w={},D;e.log=function(){return!e.log.off&&D.log.apply(D,arguments),[].slice.call(arguments).join(" ")},e.log.once=function(h,A,m){return(m=e.log.once)[h]=m[h]||0,m[h]++||e.log(A)},typeof window<"u"&&((window.GUN=window.Gun=e).window=window);try{typeof s<"u"&&(s.exports=e)}catch{}T.exports=e,(e.window||{}).console=(e.window||{}).console||{log:function(){}},(D=console).only=function(h,A){return D.only.i&&h===D.only.i&&D.only.i++&&(D.log.apply(D,arguments)||A)},e.log.once("welcome","Hello wonderful person! :) Thanks for using GUN, please ask for help on http://chat.gun.eco if anything takes you longer than 5min to figure out!")})(t,"./root"),t(function(T){var e=t("./root");e.chain.back=function(g,v){var b;if(g=g||1,g===-1||g===1/0)return this._.root.$;if(g===1)return(this._.back||this._).$;var f=this,p=f._;if(typeof g=="string"&&(g=g.split(".")),g instanceof Array){var w=0,D=g.length,b=p;for(w;w<D;w++)b=(b||a)[g[w]];return i!==b?v?f:b:(b=p.back)?b.$.back(g,v):void 0}if(typeof g=="function"){for(var h,b={back:p};(b=b.back)&&i===(h=g(b,v)););return h}return typeof g=="number"?(p.back||p).$.back(g-1):this};var a={},i})(t,"./back"),t(function(T){var e=t("./root");e.chain.chain=function(y){var u=this,o=u._,l=new(y||u).constructor(u),x=l._,$;return x.root=$=o.root,x.id=++$.once,x.back=u._,x.on=e.on,x.on("in",e.on.in,x),x.on("out",e.on.out,x),l};function a(y){var u,o=this.as,l=o.back,x=o.root,$;if(y.$||(y.$=o.$),this.to.next(y),o.err){o.on("in",{put:o.put=p,$:o.$});return}if(u=y.get){if(x.pass&&(x.pass[o.id]=o),o.lex&&Object.keys(o.lex).forEach(function(j){$[j]=o.lex[j]},$=y.get=y.get||{}),u["#"]||o.soul){if(u["#"]=u["#"]||o.soul,y["#"]||(y["#"]=w(9)),l=x.$.get(u["#"])._,u=u["."]){if(h(l.put,u)&&($=l.ask&&l.ask[u],(l.ask||(l.ask={}))[u]=l.$.get(u)._,l.on("in",{get:u,put:{"#":l.soul,".":u,":":l.put[u],">":m(x.graph[l.soul],u)}}),$))return}else{if($=l.ask&&l.ask[""],(l.ask||(l.ask={}))[""]=l,p!==l.put&&(l.on("in",l),$))return;y.$=l.$}return x.ask(b,y),x.on("in",y)}if(u["."])return o.get?(y={get:{".":o.get},$:o.$},(l.ask||(l.ask={}))[o.get]=y.$._,l.on("out",y)):(y={get:o.lex?y.get:{},$:o.$},l.on("out",y));if((o.ask||(o.ask={}))[""]=o,o.get)return u["."]=o.get,(l.ask||(l.ask={}))[o.get]=y.$._,l.on("out",y)}return l.on("out",y)}e.on.out=a;function i(y,u){u=u||this.as;var o=u.root,l=y.$||(y.$=u.$),x=(l||"")._||f,$=y.put||"",j=$["#"],E=$["."],I=p!==$["="]?$["="]:$[":"],G=$[">"]||-1/0,r;if(p!==y.put&&(p===$["#"]||p===$["."]||p===$[":"]&&p===$["="]||p===$[">"])){if(!D($)){if(!(j=(($||"")._||"")["#"])){console.log("chain not yet supported for",$,"...",y,u);return}return l=u.root.$.get(j),setTimeout.each(Object.keys($).sort(),function(n){n=="_"||p===(G=m($,n))||u.on("in",{$:l,put:{"#":j,".":n,"=":$[n],">":G},VIA:y})})}u.on("in",{$:x.back.$,put:{"#":j=x.back.soul,".":E=x.has||x.get,"=":$,">":m(x.back.put,E)},via:y});return}(y.seen||"")[u.id]||((y.seen||(y.seen=function(){}))[u.id]=u,u!==x&&(Object.keys(y).forEach(function(n){$[n]=y[n]},$={}),$.get=u.get||$.get,!u.soul&&!u.has?$.$$$=$.$$$||u.$:x.soul&&($.$=u.$,$.$$=$.$$||x.$),y=$),v(y,u),(u.soul||y.$$)&&G>=m(o.graph[j],E)&&(($=o.$.get(j)._).put=O($.put,E,G,I,j)),!x.soul&&G>=m(o.graph[j],E)&&(r=(o.$.get(j)._.next||"")[E])&&(r.put=I,typeof($=D(I))=="string"&&(r.put=o.$.get($)._.put||I)),this.to&&this.to.next(y),u.any&&setTimeout.each(Object.keys(u.any),function(n){(n=u.any[n])&&n(y)},0,99),u.echo&&setTimeout.each(Object.keys(u.echo),function(n){(n=u.echo[n])&&n.on("in",y)},0,99),((y.$$||"")._||x).soul&&(r=u.next)&&(r=r[E])&&($={},Object.keys(y).forEach(function(n){$[n]=y[n]}),$.$=(y.$$||y.$).get($.get=E),delete $.$$,delete $.$$$,r.on("in",$)),g(y,u))}e.on.in=i;function g(y,u){if(u=u||this.as||y.$._,!(y.$$&&this!==e.on)&&!(!y.put||u.soul)){var o=y.put||"",l=o["="]||o[":"],E,x=u.root,$=x.$.get(o["#"]).get(o["."])._;if(typeof(l=D(l))!="string"){this===e.on&&(($.echo||($.echo={}))[u.id]=u);return}if(!(($.echo||($.echo={}))[u.id]&&!(x.pass||"")[u.id])){if(E=x.pass){if(E[l+u.id])return;E[l+u.id]=1}($.echo||($.echo={}))[u.id]=u,u.has&&(u.link=l);var j=x.$.get($.link=l)._;(j.echo||(j.echo={}))[$.id]=$;var E=u.ask||"";(E[""]||u.lex)&&j.on("out",{get:{"#":l}}),setTimeout.each(Object.keys(E),function(I,G){!I||!(G=E[I])||G.on("out",{get:{"#":l,".":I}})},0,99)}}}e.on.link=g;function v(y,u){var o=y.put||"",l=p!==o["="]?o["="]:o[":"],x=u.root,$,j;if(p===l){if(u.soul&&p!==u.put||(j=(y.$$||y.$||"")._||"",y["@"]&&(p!==j.put||p!==u.put)))return;($=u.link||y.linked)&&delete(x.$.get($)._.echo||"")[u.id],u.has&&(u.link=null),u.put=p,setTimeout.each(Object.keys(u.next||""),function(E,I){!(I=u.next[E])||($&&delete(x.$.get($).get(E)._.echo||"")[I.id],I.on("in",{get:E,put:p,$:I.$}))},0,99);return}u.soul||y.$$||($=D(l),j=y.$._||"",!(($===j.link||u.has&&!j.link)&&!((x.pass||"")[u.id]&&typeof $!="string"))&&(delete(j.echo||"")[u.id],v({get:u.get,put:p,$:y.$,linked:y.linked=y.linked||j.link},u)))}e.on.unlink=v;function b(y,u){var o=this.as,l=o.$._;l.root;var x=o.get||"",$=(y.put||"")[x["#"]]||"";if(!y.put||typeof x["."]=="string"&&p===$[x["."]]){if(p!==l.put||!l.soul&&!l.has)return;l.ack=(l.ack||0)+1,l.on("in",{get:l.get,put:l.put=p,$:l.$,"@":y["@"]});return}(y._||{}).miss=1,e.on.put(y)}var f={},p,w=String.random,D=e.valid,h=function(y,u){return y&&Object.prototype.hasOwnProperty.call(y,u)},A=e.state,m=A.is,O=A.ify})(t,"./chain"),t(function(T){var e=t("./root");e.chain.get=function(p,w,D){var h,A;if(typeof p=="string"){if(p.length==0)return(h=this.chain())._.err={err:e.log("0 length key!",p)},w&&w.call(h,h._.err),h;var m=this,O=m._,y=O.next||v;(h=y[p])||(h=p&&a(p,m)),h=h&&h.$}else if(typeof p=="function"){let $=function(E,I,G){if(!$.stun&&!((N=o.pass)&&!N[l])){var r=E.$._,n=(E.$$||"")._,c=(n||r).put,S=!r.has&&!r.soul,R={},N;if((S||f===c)&&(c=f===((N=E.put)||"")["="]?f===(N||"")[":"]?N:N[":"]:N["="]),typeof(N=e.valid(c))=="string"&&(c=f===(N=o.$.get(N)._.put)?u.not?f:c:N),!(u.not&&f===c)){if(f===u.stun){if((N=o.stun)&&N.on&&(O.$.back(function(k){if(N.on(""+k.id,R={}),(R.run||0)<$.id)return R}),!R.run&&N.on(""+r.id,R={}),!R.run&&n&&N.on(""+n.id,R={}),$.id>R.run&&((!R.stun||R.stun.end)&&(R.stun=N.on("stun"),R.stun=R.stun&&R.stun.last),R.stun&&!R.stun.end))){(R.stun.add||(R.stun.add={}))[l]=function(){$(E,I,1)};return}if(f===c&&(G=0),(N=o.hatch)&&!N.end&&f===u.hatch&&!G){if(x[r.$._.id])return;x[r.$._.id]=1,N.push(function(){$(E,I,1)});return}x={}}if(o.pass){if(o.pass[l+r.id])return;o.pass[l+r.id]=1}if(u.on){u.ok.call(r.$,c,r.get,E,I||$);return}if(u.v2020){u.ok(E,I||$);return}Object.keys(E).forEach(function(k){N[k]=E[k]},N={}),E=N,E.put=c,u.ok.call(u.as,E,I||$)}}};if(w===!0)return i(this,p,w,D),this;h=this;var O=h._,u=w||{},o=O.root,l;u.at=O,u.ok=p;var x={};return $.at=O,(O.any||(O.any={}))[l=String.random(7)]=$,$.off=function(){$.stun=1,O.any&&delete O.any[l]},$.rid=g,$.id=u.run||++o.once,A=o.pass,(o.pass={})[l]=1,u.out=u.out||{get:{}},O.on("out",u.out),o.pass=A,h}else{if(typeof p=="number")return this.get(""+p,w,D);if(typeof(A=b(p))=="string")return this.get(A,w,D);(A=this.get.next)&&(h=A(this,p))}return h?(w&&typeof w=="function"&&h.get(w,D),h):((h=this.chain())._.err={err:e.log("Invalid get request!",p)},w&&w.call(h,h._.err),h)};function a(p,w){var D=w._,h=D.next,A=w.chain(),m=A._;return h||(h=D.next={}),h[m.get=p]=m,w===D.root.$?m.soul=p:(D.soul||D.has)&&(m.has=p),m}function i(p,w,D,h){var A=p._,m=0,O;return(O=A.soul||A.link)?w(O,h,A):A.jam?A.jam.push([w,h]):(A.jam=[[w,h]],p.get(function(u,o){if(!(f===u.put&&!A.root.opt.super&&(O=Object.keys(A.root.opt.peers).length)&&++m<=O)){o.rid(u);var l=(l=u.$)&&l._||{},x=0,$;for(O=A.jam,delete A.jam;$=O[x++];){var j=$[0];$=$[1],j&&j(l.link||l.soul||e.valid(u.put)||((u.put||{})._||{})["#"],$,u,o)}}},{out:{get:{".":!0}}}),p)}function g(p){var w=this.at||this.on;if(!p||w.soul||w.has)return this.off();if(!!(p=(p=(p=p.$||p)._||p).id)){w.map;var D;if((D=this.seen||(this.seen={}))[p])return!0;D[p]=!0}}var v={},b=e.valid,f})(t,"./get"),t(function(T){var e=t("./root");e.chain.put=function(h,A,m){var O=this,y=O._,u=y.root;m=m||{},m.root=y.root,m.run||(m.run=u.once),a(m,y.id),m.ack=m.ack||A,m.via=m.via||O,m.data=m.data||h,m.soul||(m.soul=y.soul||typeof A=="string"&&A);var o=m.state=m.state||e.state();return typeof h=="function"?(h(function(l){m.data=l,O.put(b,b,m)}),O):m.soul?(m.$=u.$.get(m.soul),m.todo=[{it:m.data,ref:m.$}],m.turn=m.turn||p,m.ran=m.ran||i,function l(){var x=m.todo,$=x.pop(),j=$.it;$.ref&&$.ref._.id;var E,I,G,r,n;if(a(m,$.ref),(r=$.todo)&&(I=r.pop(),j=j[I],r.length&&x.push($)),I&&(x.path||(x.path=[])).push(I),!(E=w(j))&&!(n=e.is(j))){if(!Object.plain(j)){i.err(m,"Invalid data: "+v(j)+" at "+(m.via.back(function(N){N.get&&r.push(N.get)},r=[])||r.join("."))+"."+(x.path||[]).join("."));return}for(var c=m.seen||(m.seen=[]),S=c.length;S--;)if(j===(r=c[S]).it){E=j=r.link;break}}if(I&&E)$.node=D($.node,I,o,j);else{let N=function(k,P){var C=G.link["#"];P&&(P.off(),P.rid(k));var B=C||k.soul||(r=(k.$$||k.$)._||"").soul||r.link||((r=r.put||"")._||"")["#"]||r["#"]||((r=k.put||"")&&k.$$?r["#"]:(r["="]||r[":"]||"")["#"]);if(!C&&a(m,k.$),!B&&!$.link["#"]){($.wait||($.wait=[])).push(function(){N(k,P)});return}B||(B=[],(k.$$||k.$).back(function(H){if(r=H.soul||H.link)return B.push(r);B.push(H.get)}),B=B.reverse().join("/")),G.link["#"]=B,!n&&(((m.graph||(m.graph={}))[B]=G.node||(G.node={_:{}}))._["#"]=B),delete m.wait[R],G.wait&&setTimeout.each(G.wait,function(H){H&&H()}),m.ran(m)};if(!m.seen){i.err(m,"Data at root of graph must be a node (an object).");return}m.seen.push(G={it:j,link:{},todo:n?[]:Object.keys(j).sort().reverse(),path:(x.path||[]).slice(),up:$}),$.node=D($.node,I,o,G.link),!n&&G.todo.length&&x.push(G);var R=m.seen.length;(m.wait||(m.wait={}))[R]="",r=(G.ref=n?j:I?$.ref.get(I):$.ref)._,(r=j&&(j._||"")["#"]||r.soul||r.link)?N({soul:r}):G.ref.get(N,{run:m.run,v2020:1,out:{get:{".":" "}}})}if(!x.length)return m.ran(m);m.turn(l)}(),O):(g(m),O)};function a(h,A){if(!!A){A=(A._||"").id||A;var m=h.root.stun||(h.root.stun={on:e.on}),O={},y;h.stun||(h.stun=m.on("stun",function(){})),(y=m.on(""+A))&&y.the.last.next(O),!(O.run>=h.run)&&m.on(""+A,function(u){if(h.stun.end){this.off(),this.to.next(u);return}u.run=u.run||h.run,u.stun=u.stun||h.stun})}}function i(h){if(h.err){i.end(h.stun,h.root);return}if(!(h.todo.length||h.end||!Object.empty(h.wait))){h.end=1;var A=h.$.back(-1)._,m=A.root,O=A.ask(function(l){m.on("ack",l),l.err&&e.log(l),++y>(h.acks||0)&&this.off(),h.ack&&h.ack(l,this)},h.opt),y=0,u=h.stun,o;(o=function(){!u||(i.end(u,m),setTimeout.each(Object.keys(u=u.add||""),function(l){(l=u[l])&&l()}))}).hatch=o,h.via._.on("out",{put:h.out=h.graph,opt:h.opt,"#":O,_:o})}}i.end=function(h,A){h.end=f,h.the.to===h&&h===h.the.last&&delete A.stun,h.off()},i.err=function(h,A){(h.ack||f).call(h,h.out={err:h.err=e.log(A)}),h.ran(h)};function g(h){var A=h.via._,m;h.via=h.via.back(function(O){if(O.soul||!O.get)return O.$;m=h.data,(h.data={})[O.get]=m}),(!h.via||!h.via._.soul)&&(h.via=A.root.$.get(((h.data||"")._||"")["#"]||A.$.back("opt.uuid")())),h.via.put(h.data,h.ack,h)}function v(h,A){return h&&(A=h.constructor)&&A.name||typeof h}var b,f=function(){},p=setTimeout.turn,w=e.valid,D=e.state.ify})(t,"./put"),t(function(T){var e=t("./root");t("./chain"),t("./back"),t("./put"),t("./get"),T.exports=e})(t,"./index"),t(function(T){var e=t("./index");e.chain.on=function(g,v,b,f){var p=this,w=p._;w.root;var D;if(typeof g=="string")return v?(D=w.on(g,v,b||w,f),b&&b.$&&(b.subs||(b.subs=[])).push(D),p):w.on(g);var h=v;return(h=h===!0?{change:!0}:h||{}).not=1,h.on=1,p.get(g,h),p},e.chain.once=function(g,v){if(v=v||{},!g)return a(this);var b=this,f=b._,p=f.root;f.put;var w=String.random(7),D;return b.get(function(h,A,m,O){var y=this,u=y._,o=u.one||(u.one={});if(O.stun||o[w]==="")return;if((D=e.valid(h))===!0){l();return}if(typeof D=="string")return;clearTimeout((f.one||"")[w]),clearTimeout(o[w]),o[w]=setTimeout(l,v.wait||99);function l(x){if(!u.has&&!u.soul&&(u={put:h,get:A}),i===(D=u.put)&&(D=((m.$$||"")._||"").put),typeof e.valid(D)=="string"&&(D=p.$.get(D)._.put,D===i&&!x)){o[w]=setTimeout(function(){l(1)},v.wait||99);return}O.stun||o[w]!==""&&(o[w]="",(f.soul||f.has)&&O.off(),g.call(y,D,u.get),clearTimeout(o[w]))}},{on:1}),b};function a(g,v,b){return e.log.once("valonce","Chainable val is experimental, its behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),(b=g.chain())._.nix=g.once(function(f,p){b._.on("in",this._)}),b._.lex=g._.lex,b}e.chain.off=function(){var g=this,v=g._,b,f=v.back;if(!!f)return v.ack=0,(b=f.next)&&b[v.get]&&delete b[v.get],(b=f.ask)&&delete b[v.get],(b=f.put)&&delete b[v.get],(b=v.soul)&&delete f.root.graph[b],(b=v.map)&&Object.keys(b).forEach(function(p,w){w=b[p],w.link&&f.root.$.get(w.link).off()}),(b=v.next)&&Object.keys(b).forEach(function(p,w){w=b[p],w.$.off()}),v.on("off",{}),g};var i})(t,"./on"),t(function(T){var e=t("./index"),a=e.chain.get.next;e.chain.get.next=function(b,f){var p;return Object.plain(f)?(p=((p=f["#"])||"")["="]||p)?b.get(p):((p=b.chain()._).lex=f,b.on("in",function(w){String.match(w.get||(w.put||"")["."],f["."]||f["#"]||f)&&p.on("in",w),this.to.next(w)}),p.$):(a||g)(b,f)},e.chain.map=function(b,f,p){var w=this,D=w._,h,A;return Object.plain(b)&&(h=b["."]?b:{".":b},b=v),b?(e.log.once("mapfn","Map functions are experimental, their behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),A=w.chain(),w.map().on(function(m,O,y,u){var o=(b||g).call(this,m,O,y,u);if(v!==o){if(m===o)return A._.on("in",y);if(e.is(o))return A._.on("in",o._);var l={};Object.keys(y.put).forEach(function(x){l[x]=y.put[x]},l),l["="]=o,A._.on("in",{get:O,put:l})}}),A):((A=D.each)||((D.each=A=w.chain())._.lex=h||A._.lex||D.lex,A._.nix=w.back("nix"),w.on("in",i,A._)),A)};function i(b){this.to.next(b);var f=this.as,p=b.$,w=p._,D=b.put,h;!w.soul&&!b.$$||(h=f.lex)&&!String.match(b.get||(D||"")["."],h["."]||h["#"]||h)||e.on.link(b,f)}var g=function(){},v})(t,"./map"),t(function(T){var e=t("./index");e.chain.set=function(a,i,g){var v=this,b=v.back(-1),f,p;return i=i||function(){},g=g||{},g.item=g.item||a,(f=((a||"")._||"")["#"])&&((a={})["#"]=f),typeof(p=e.valid(a))=="string"?v.get(f=p).put(a,i,g):e.is(a)?(v.put(function(w){a.get(function(D,h,A){if(!D)return i.call(v,{err:e.log('Only a node can be linked! Not "'+A.put+'"!')});(p={})[D]={"#":D},w(p)},!0)}),a):(Object.plain(a)&&(a=b.get(f=v.back("opt.uuid")()).put(a)),v.get(f||b.back("opt.uuid")(7)).put(a,i,g))}})(t,"./set"),t(function(T){t("./shim");var e=function(){},a=JSON.parseAsync||function(b,f,p){var w,D=+new Date;try{f(w,JSON.parse(b,p),i.sucks(+new Date-D))}catch(h){f(h)}},i=JSON.stringifyAsync||function(b,f,p,w){var D,h=+new Date;try{f(D,JSON.stringify(b,p,w),i.sucks(+new Date-h))}catch(A){f(A)}};i.sucks=function(b){b>99&&(console.log("Warning: JSON blocking CPU detected. Add `gun/lib/yson.js` to fix."),i.sucks=e)};function g(b){var f=function(){},p=b.opt||{};p.log=p.log||console.log,p.gap=p.gap||p.wait||0,p.max=p.max||(p.memory?p.memory*999*999:3e8)*.3,p.pack=p.pack||p.max*.01*.01,p.puff=p.puff||9;var w=setTimeout.turn||setTimeout,D=b.dup,h=D.check,A=D.track,m=f.hear=function(o,l){if(!!o){if(p.max<=o.length)return f.say({dam:"!",err:"Message too big!"},l);f===this&&(m.d+=o.length||0,++m.c);var x=l.SH=+new Date,$=o[0],j;if($==="["){a(o,function(E,I){if(E||!I)return f.say({dam:"!",err:"DAM JSON parse error."},l);console.STAT&&console.STAT(+new Date,I.length,"# on hear batch");var G=p.puff;(function r(){for(var n=+new Date,c=0,S;c<G&&(S=I[c++]);)f.hear(S,l);I=I.slice(c),console.STAT&&console.STAT(n,+new Date-n,"hear loop"),O(l),I.length&&w(r,0)})()}),o="";return}if($==="{"||(o["#"]||Object.plain(o))&&(j=o)){if(j)return m.one(j,l,x);a(o,function(E,I){if(E||!I)return f.say({dam:"!",err:"DAM JSON parse error."},l);m.one(I,l,x)});return}}};m.one=function(o,l,r){var $,j,E,I,G;if(o.DBG&&(o.DBG=G={DBG:o.DBG}),G&&(G.h=r),G&&(G.hp=+new Date),($=o["#"])||($=o["#"]=String.random(9)),!(E=h($))&&(j=o["##"],!(j&&(E=o["@"]||o.get&&$)&&D.check(I=E+j)))){if((o._=function(){}).via=f.leap=l,(E=o["><"])&&typeof E=="string"&&E.slice(0,99).split(",").forEach(function(n){this[n]=1},o._.yo={}),E=o.dam){(E=f.hear[E])&&E(o,l,b),A($);return}var r=+new Date;G&&(G.is=r),l.SI=$,b.on("in",f.last=o),G&&(G.hd=+new Date),console.STAT&&console.STAT(r,+new Date-r,o.get?"msg get":o.put?"msg put":"msg"),(E=A($)).via=l,o.get&&(E.it=o),I&&A(I),f.leap=f.last=null}},m.c=m.d=0,function(){var o=0,l;f.hash=function(j,E){var I,G,r,n=+new Date;i(j.put,function c(S,R){var N=(G||(G=r=R||"")).slice(0,32768);if(I=String.hash(N,I),G=G.slice(32768),G){w(c,0);return}console.STAT&&console.STAT(n,+new Date-n,"say json+hash"),j._.$put=r,j["##"]=I,f.say(j,E),delete j._.$put},x)};function x(j,E){var I;return E instanceof Object?(Object.keys(E).sort().forEach($,{to:I={},on:E}),I):E}function $(j){this.to[j]=this.on[j]}f.say=function(j,E){var I;if((I=this)&&(I=I.to)&&I.next&&I.next(j),!j)return!1;var G,r,n=j["@"],c=j._||(j._=function(){}),S=j.DBG,R=+new Date;if(c.y=c.y||R,E||S&&(S.y=R),(G=j["#"])||(G=j["#"]=String.random(9)),!l&&A(G),j.put&&(j.err||(D.s[G]||"").err))return!1;if(!j["##"]&&v!==j.put&&!c.via&&n){f.hash(j,E);return}if(!E&&n&&(E=(I=D.s[n])&&(I.via||(I=I.it)&&(I=I._)&&I.via)||(I=f.last)&&n===I["#"]&&f.leap),!E&&n)return D.s[n]?void 0:(console.STAT&&console.STAT(+new Date,++o,"total no peer to ack to"),!1);if(!E&&f.way)return f.way(j);if(S&&(S.yh=+new Date),!(r=c.raw)){f.raw(j,E);return}if(S&&(S.yr=+new Date),!E||!E.id){if(!Object.plain(E||p.peers))return!1;var R=+new Date;p.puff;var N=p.peers,k=Object.keys(E||p.peers||{});console.STAT&&console.STAT(R,+new Date-R,"peer keys"),function B(){var H=+new Date;l=1;var L=c.raw;c.raw=r;for(var M=0,F;M<9&&(F=(k||"")[M++]);)!(F=N[F])||f.say(j,F);c.raw=L,l=0,k=k.slice(M),console.STAT&&console.STAT(H,+new Date-H,"say loop"),k.length&&(w(B,0),n&&A(n))}();return}if(!E.wire&&f.wire&&f.wire(E),G!==E.last){if(E.last=G,E===c.via||(I=c.yo)&&(I[E.url]||I[E.pid]||I[E.id]))return!1;if(console.STAT&&console.STAT(R,((S||c).yp=+new Date)-(c.y||R),"say prep"),!l&&n&&A(n),E.batch){if(E.tail=(I=E.tail||0)+r.length,E.tail<=p.pack){E.batch+=(I?",":"")+r;return}O(E)}E.batch="[";var P=+new Date;setTimeout(function(){console.STAT&&console.STAT(P,+new Date-P,"0ms TO"),O(E)},p.gap),y(r,E),console.STAT&&n===E.SI&&console.STAT(R,+new Date-E.SH,"say ack")}},f.say.c=f.say.d=0,f.raw=function(j,E){if(!j)return"";var I=j._||{},G,r;if(r=I.raw)return r;if(typeof j=="string")return j;var n=j["##"],c=j["@"];if(n&&c){if(!I.via&&h(c+n))return!1;if((r=(D.s[c]||"").it)||(r=f.last)&&c===r["#"]){if(n===r["##"])return!1;r["##"]||(r["##"]=n)}}if(!j.dam){var S=0,R=[];r=p.peers;for(var N in r){var k=r[N];if(R.push(k.url||k.pid||k.id),++S>6)break}S>1&&(j["><"]=R.join())}if(G=I.$put){r={},Object.keys(j).forEach(function(C){r[C]=j[C]}),r.put=":])([:",i(r,function(C,B){if(!C){var H=+new Date;r=B.indexOf('"put":":])([:"'),P(v,B=B.slice(0,r+6)+G+B.slice(r+14)),console.STAT&&console.STAT(H,+new Date-H,"say slice")}});return}i(j,P);function P(C,B){C||(I.raw=B,f.say(j,E))}}}();function O(o){var l=o.batch,x=typeof l=="string";if(x&&(l+="]"),o.batch=o.tail=null,!!l&&!(x?3>l.length:!l.length)){if(!x)try{l=l.length===1?l[0]:JSON.stringify(l)}catch($){return p.log("DAM JSON stringify error",$)}!l||y(l,o)}}function y(o,l){try{var x=l.wire;l.say?l.say(o):x.send&&x.send(o),f.say.d+=o.length||0,++f.say.c}catch{(l.queue=l.queue||[]).push(o)}}f.hi=function(o){var l=o.wire,x;if(!l){f.wire(o.length&&{url:o}||o);return}o.id?p.peers[o.url||o.id]=o:(x=o.id=o.id||String.random(9),f.say({dam:"?",pid:b.opt.pid},p.peers[x]=o),delete D.s[o.last]),o.met=o.met||+new Date,l.hied||b.on(l.hied="hi",o),x=o.queue,o.queue=[],setTimeout.each(x||[],function($){y($,o)},0,9)},f.bye=function(o){b.on("bye",o);var l=+new Date;l=l-(o.met||l),f.bye.time=((f.bye.time||l)+l)/2},f.hear["!"]=function(o,l){p.log("Error:",o.err)},f.hear["?"]=function(o,l){o.pid&&(l.pid||(l.pid=o.pid),o["@"])||(f.say({dam:"?",pid:p.pid,"@":o["#"]},l),delete D.s[l.last])},b.on("create",function(o){o.opt.pid=o.opt.pid||String.random(9),this.to.next(o),o.on("out",f.say)}),b.on("bye",function(o,l){o=p.peers[o.id||o]||o,this.to.next(o),o.bye?o.bye():(l=o.wire)&&l.close&&l.close(),delete p.peers[o.id],o.wire=null});var u={};return b.on("bye",function(o,l){this.to.next(o),(l=console.STAT)&&(l.peers=(l.peers||0)-1),(l=o.url)&&(u[l]=!0,setTimeout(function(){delete u[l]},p.lack||9e3))}),b.on("hi",function(o,l){this.to.next(o),(l=console.STAT)&&(l.peers=(l.peers||0)+1),!(!(l=o.url)||!u[l])&&(delete u[l],!p.super&&setTimeout.each(Object.keys(b.next),function(x){b.next[x],l={},l[x]=b.graph[x],l=String.hash(l),f.say({"##":l,get:{"#":x}},o)}))}),f}var v;try{T.exports=g}catch{}})(t,"./mesh"),t(function(T){var e=t("../index");e.Mesh=t("./mesh"),e.on("opt",function(i){if(this.to.next(i),i.once)return;var g=i.opt;if(g.WebSocket===!1)return;var v=e.window||{},b=g.WebSocket||v.WebSocket||v.webkitWebSocket||v.mozWebSocket;if(!b)return;g.WebSocket=b;var f=g.mesh=g.mesh||e.Mesh(i);f.wire||g.wire,f.wire=g.wire=p;function p(A){try{if(!A||!A.url)return O&&O(A);var m=A.url.replace(/^http/,"ws"),O=A.wire=new g.WebSocket(m);return O.onclose=function(){g.mesh.bye(A),D(A)},O.onerror=function(y){D(A)},O.onopen=function(){g.mesh.hi(A)},O.onmessage=function(y){!y||g.mesh.hear(y.data||y,A)},O}catch{}}setTimeout(function(){!g.super&&i.on("out",{dam:"hi"})},1);var w=2*999;function D(A){clearTimeout(A.defer),g.peers[A.url]&&(h&&A.retry<=0||(A.retry=(A.retry||g.retry+1||60)-(-A.tried+(A.tried=+new Date)<w*4?1:0),A.defer=setTimeout(function m(){if(h&&h.hidden)return setTimeout(m,w);p(A)},w)))}var h=""+a!=typeof document&&document});var a})(t,"./websocket"),t(function(T){if(!(typeof Gun>"u")){var e=function(){},a;try{a=(Gun.window||e).localStorage}catch{}a||(Gun.log("Warning: No localStorage exists to persist data to!"),a={setItem:function(g,v){this[g]=v},removeItem:function(g){delete this[g]},getItem:function(g){return this[g]}});var i=JSON.stringifyAsync||function(g,v,b,f){var p;try{v(p,JSON.stringify(g,b,f))}catch(w){v(w)}};Gun.on("create",function g(v){this.to.next(v);var b=v.opt;v.graph;var f=[],p,w,D,h;if(b.localStorage===!1)return;b.prefix=b.file||"gun/";try{p=g[b.prefix]=g[b.prefix]||JSON.parse(D=a.getItem(b.prefix))||{}}catch{p=g[b.prefix]={}}D=(D||"").length,v.on("get",function(m){this.to.next(m);var O=m.get,y,u,o,l;!O||!(y=O["#"])||(u=p[y]||l,u&&(o=O["."])&&!Object.plain(o)&&(u=Gun.state.ify({},o,Gun.state.is(u,o),u[o],y)),Gun.on.get.ack(m,u))}),v.on("put",function(m){this.to.next(m);var O=m.put,y=O["#"],u=O["."],o=m["#"];if(p[y]=Gun.state.ify(p[y],u,O[">"],O[":"],y),h&&D>4999880){v.on("in",{"@":o,err:"localStorage max!"});return}m["@"]||f.push(o),!w&&(w=setTimeout(A,9+D/333))});function A(){if(!f.length&&((setTimeout.turn||"").s||"").length){setTimeout(A,99);return}var m=f;clearTimeout(w),w=!1,f=[],i(p,function(O,y){try{!O&&a.setItem(b.prefix,y)}catch(u){O=h=u||"localStorage failure"}O&&(Gun.log(O+" Consider using GUN's IndexedDB plugin for RAD for more storage space, https://gun.eco/docs/RAD#install"),v.on("localStorage:error",{err:O,get:b.prefix,put:p})),D=y.length,!(!O&&!Object.empty(b.peers))&&setTimeout.each(m,function(u){v.on("in",{"@":u,err:O,ok:0})},0,99)})}})}})(t,"./localStorage")}(),function(){var G;if(""+G!=typeof Gun){var t=function(r){console.warn("Warning! Deprecated internal utility will break in next version:",r)},s=Gun;s.fn=s.fn||{is:function(r){return t("fn"),!!r&&typeof r=="function"}},s.bi=s.bi||{is:function(r){return t("bi"),r instanceof Boolean||typeof r=="boolean"}},s.num=s.num||{is:function(r){return t("num"),!T(r)&&(r-parseFloat(r)+1>=0||r===1/0||r===-1/0)}},s.text=s.text||{is:function(r){return t("text"),typeof r=="string"}},s.text.ify=s.text.ify||function(r){return t("text.ify"),s.text.is(r)?r:typeof JSON<"u"?JSON.stringify(r):r&&r.toString?r.toString():r},s.text.random=s.text.random||function(r,n){t("text.random");var c="";for(r=r||24,n=n||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";r>0;)c+=n.charAt(Math.floor(Math.random()*n.length)),r--;return c},s.text.match=s.text.match||function(r,n){var c,S;return t("text.match"),typeof r!="string"?!1:(typeof n=="string"&&(n={"=":n}),n=n||{},c=n["="]||n["*"]||n[">"]||n["<"],r===c?!0:S!==n["="]?!1:(c=n["*"]||n[">"]||n["<"],r.slice(0,(c||"").length)===c?!0:S!==n["*"]?!1:S!==n[">"]&&S!==n["<"]?r>=n[">"]&&r<=n["<"]:S!==n[">"]&&r>=n[">"]||S!==n["<"]&&r<=n["<"]))},s.text.hash=s.text.hash||function(r,n){if(t("text.hash"),typeof r=="string"){if(n=n||0,!r.length)return n;for(var c=0,S=r.length,R;c<S;++c)R=r.charCodeAt(c),n=(n<<5)-n+R,n|=0;return n}},s.list=s.list||{is:function(r){return t("list"),r instanceof Array}},s.list.slit=s.list.slit||Array.prototype.slice,s.list.sort=s.list.sort||function(r){return t("list.sort"),function(n,c){return!n||!c?0:(n=n[r],c=c[r],n<c?-1:n>c?1:0)}},s.list.map=s.list.map||function(r,n,c){return t("list.map"),E(r,n,c)},s.list.index=1,s.obj=s.boj||{is:function(r){return t("obj"),r?r instanceof Object&&r.constructor===Object||Object.prototype.toString.call(r).match(/^\[object (\w+)\]$/)[1]==="Object":!1}},s.obj.put=s.obj.put||function(r,n,c){return t("obj.put"),(r||{})[n]=c,r},s.obj.has=s.obj.has||function(r,n){return t("obj.has"),r&&Object.prototype.hasOwnProperty.call(r,n)},s.obj.del=s.obj.del||function(r,n){if(t("obj.del"),!!r)return r[n]=null,delete r[n],r},s.obj.as=s.obj.as||function(r,n,c,S){return t("obj.as"),r[n]=r[n]||(S===c?{}:c)},s.obj.ify=s.obj.ify||function(r){if(t("obj.ify"),o(r))return r;try{r=JSON.parse(r)}catch{r={}}return r},function(){var r;function n(c,S){x(this,S)&&r!==this[S]||(this[S]=c)}s.obj.to=s.obj.to||function(c,S){return t("obj.to"),S=S||{},E(c,n,S),S}}(),s.obj.copy=s.obj.copy||function(r){return t("obj.copy"),r&&JSON.parse(JSON.stringify(r))},function(){function r(n,c){var S=this.n,R;if(!(S&&(c===S||o(S)&&x(S,c)))&&R!==c)return!0}s.obj.empty=s.obj.empty||function(n,c){return t("obj.empty"),n?!E(n,r,{n:c}):!0}}(),function(){function r(S,R){if(arguments.length===2){r.r=r.r||{},r.r[S]=R;return}r.r=r.r||[],r.r.push(S)}var n=Object.keys,c;Object.keys=Object.keys||function(S){return c(S,function(R,N,k){k(N)})},s.obj.map=c=s.obj.map||function(S,R,N){t("obj.map");var k,P=0,C,B,H,L,M=typeof R=="function";if(r.r=k,n&&o(S)&&(H=n(S),L=!0),N=N||{},T(S)||H)for(C=(H||S).length;P<C;P++){var F=P+s.list.index;if(M){if(B=L?R.call(N,S[H[P]],H[P],r):R.call(N,S[P],F,r),B!==k)return B}else if(R===S[L?H[P]:P])return H?H[P]:F}else for(P in S)if(M){if(x(S,P)&&(B=N?R.call(N,S[P],P,r):R(S[P],P,r),B!==k))return B}else if(R===S[P])return P;return M?r.r:s.list.index?0:-1}}(),s.time=s.time||{},s.time.is=s.time.is||function(r){return t("time"),r?r instanceof Date:+new Date().getTime()};var y=s.fn.is,T=s.list.is,u=s.obj,o=u.is,x=u.has,E=u.map,e={};e.is=function(r){return t("val.is"),r===G?!1:r===null?!0:r===1/0?!1:g(r)||i(r)||h(r)?!0:e.link.is(r)||!1},e.link=e.rel={_:"#"},function(){e.link.is=function(n){if(t("val.link.is"),n&&n[a]&&!n._&&o(n)){var c={};if(E(n,r,c),c.id)return c.id}return!1};function r(n,c){var S=this;if(S.id)return S.id=!1;if(c==a&&g(n))S.id=n;else return S.id=!1}}(),e.link.ify=function(r){return t("val.link.ify"),j({},a,r)},s.obj.has._=".";var a=e.link._,G,i=s.bi.is,h=s.num.is,g=s.text.is,u=s.obj,o=u.is,j=u.put,E=u.map;s.val=s.val||e;var v={_:"_"};v.soul=function(r,n){return t("node.soul"),r&&r._&&r._[n||p]},v.soul.ify=function(r,n){return t("node.soul.ify"),n=typeof n=="string"?{soul:n}:n||{},r=r||{},r._=r._||{},r._[p]=n.soul||r._[p]||f(),r},v.soul._=e.link._,function(){v.is=function(n,c,S){t("node.is");var R;return o(n)&&(R=v.soul(n))?!E(n,r,{as:S,cb:c,s:R,n}):!1};function r(n,c){if(c!==v._){if(!e.is(n))return!0;this.cb&&this.cb.call(this.as,n,c,this.n,this.s)}}}(),function(){v.ify=function(n,c,S){return t("node.ify"),c?typeof c=="string"?c={soul:c}:typeof c=="function"&&(c={map:c}):c={},c.map&&(c.node=c.map.call(S,n,G,c.node||{})),(c.node=v.soul.ify(c.node||{},c))&&E(n,r,{o:c,as:S}),c.node};function r(n,c){var S=this.o,R,N;if(S.map){R=S.map.call(this.as,n,""+c,S.node),N===R?l(S.node,c):S.node&&(S.node[c]=R);return}e.is(n)&&(S.node[c]=n)}}();var u=s.obj,o=u.is,l=u.del,E=u.map,b=s.text,f=b.random,p=v.soul._,G;s.node=s.node||v;var w=s.state;w.lex=function(){return t("state.lex"),w().toString(36).replace(".","")},w.to=function(r,n,c){t("state.to");var S=(r||{})[n];return o(S)&&(S=I(S)),w.ify(c,n,w.is(r,n),S,v.soul(r))},function(){w.map=function(n,c,S){t("state.map");var R,N=o(N=n||c)?N:null;return n=y(n=n||c)?n:null,N&&!n?(c=h(c)?c:w(),N[m]=N[m]||{},E(N,r,{o:N,s:c}),N):(S=S||o(c)?c:R,c=h(c)?c:w(),function(k,P,C,B){if(!n)return r.call({o:C,s:c},k,P),k;n.call(S||this||{},k,P,C,B),!(x(C,P)&&R===C[P])&&r.call({o:C,s:c},k,P)})};function r(n,c){m!==c&&w.ify(this.o,c,this.s)}}();var u=s.obj;u.as;var x=u.has,o=u.is,E=u.map,I=u.copy,D=s.num,h=D.is,A=s.fn,y=A.is,m=v._,G,O={};(function(){O.is=function(c,S,R,N){return t("graph.is"),!c||!o(c)||$(c)?!1:!E(c,r,{cb:S,fn:R,as:N})};function r(c,S){if(!c||S!==v.soul(c)||!v.is(c,this.fn,this.as))return!0;!this.cb||(n.n=c,n.as=this.as,this.cb.call(n.as,c,S,n))}function n(c){c&&v.is(n.n,c,n.as)}})(),function(){O.ify=function(N,k,P){t("graph.ify");var C={path:[],obj:N};return k?typeof k=="string"?k={soul:k}:typeof k=="function"&&(k.map=k):k={},typeof P=="string"&&(k.soul=k.soul||P,P=G),k.soul&&(C.link=e.link.ify(k.soul)),k.shell=(P||{}).shell,k.graph=k.graph||{},k.seen=k.seen||[],k.as=k.as||P,r(k,C),k.root=C.node,k.graph};function r(N,k){var P;return(P=R(N,k))?P:(k.env=N,k.soul=c,v.ify(k.obj,n,k)&&(k.link=k.link||e.link.ify(v.soul(k.node)),k.obj!==N.shell&&(N.graph[e.link.is(k.link)]=k.node)),k)}function n(N,k,P){var C=this,B=C.env,H,L;if(v._===k&&x(N,e.link._))return P._;if(!!(H=S(N,k,P,C,B))){if(k||(C.node=C.node||P||{},x(N,v._)&&v.soul(N)&&(C.node._=I(N._)),C.node=v.soul.ify(C.node,e.link.is(C.link)),C.link=C.link||e.link.ify(v.soul(C.node))),(L=B.map)&&(L.call(B.as||{},N,k,P,C),x(P,k))){if(N=P[k],G===N){l(P,k);return}if(!(H=S(N,k,P,C,B)))return}if(!k)return C.node;if(H===!0)return N;if(L=r(B,{obj:N,path:C.path.concat(k)}),!!L.node)return L.link}}function c(N){var k=this,P=e.link.is(k.link),C=k.env.graph;k.link=k.link||e.link.ify(N),k.link[e.link._]=N,k.node&&k.node[v._]&&(k.node[v._][e.link._]=N),x(C,P)&&(C[N]=C[P],l(C,P))}function S(N,k,P,C,B){var H;if(e.is(N))return!0;if(o(N))return 1;if(H=B.invalid)return N=H.call(B.as||{},N,k,P),S(N,k,P,C,B);B.err="Invalid value at '"+C.path.concat(k).join(".")+"'!",s.list.is(N)&&(B.err+=" Use `.set(item)` instead of an Array.")}function R(N,k){for(var P=N.seen,C=P.length,B;C--;)if(B=P[C],k.obj===B.obj)return B;P.push(k)}}(),O.node=function(r){t("graph.node");var n=v.soul(r);if(!!n)return j({},n,r)},function(){O.to=function(n,c,S){if(t("graph.to"),!!n){var R={};return S=S||{seen:{}},E(n[c],r,{obj:R,graph:n,opt:S}),R}};function r(n,c){var S,R;if(v._===c){if($(n,e.link._))return;this.obj[c]=I(n);return}if(!(S=e.link.is(n))){this.obj[c]=n;return}if(R=this.opt.seen[S]){this.obj[c]=R;return}this.obj[c]=this.opt.seen[S]=O.to(this.graph,S,this.opt)}}();var y=s.fn.is,u=s.obj,o=u.is,l=u.del,x=u.has,$=u.empty,j=u.put,E=u.map,I=u.copy,G;s.graph=s.graph||O}}()}});Q();Z();var pt=vn();const Sn="_App_sggzw_1",Tn="_TestnetBankContainer_sggzw_51",Pt={App:Sn,TestnetBankContainer:Tn},Gt=X('<input type="text">'),$n=X('<table><tbody><tr><td><a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">https://github.com/fc1943s/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">https://fc1943s.github.io/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">https://fc1943s.github.io/tictactoe_spiral/docs</a></td></tr></tbody></table>'),An=X("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),wn=X("<table><tbody></tbody></table>"),kn=X("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),xn=X("<div><button>Load</button></div>"),On=X("<div><button></button></div>"),En=X('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),Nn=X("<table><tbody><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),yt=X("<div><button>Request</button><button>Clear</button><pre></pre></div>"),jn=X("<div><table><tbody><tr><td>Links</td><td></td></tr><tr><td></td></tr><tr><td>Chain Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr><tr><td></td></tr><tr><td>Database Connection</td><td></td></tr><tr><td></td></tr><tr><td>Counter</td><td></td></tr><tr><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Deploy</td><td></td></tr></tbody></table></div>");pt.__esModule&&pt.default;const et={DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_config_user_agent:"bun/0.1.4 npm/? node/v16.14.0 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_aab92414-8914-4f8c-abfe-4a18af5cdab8",PIPX_HOME:"/opt/pipx",BUN_INSTALL:"~/.bun",npm_node_execpath:"/opt/hostedtoolcache/node/16.16.0/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",npm_package_json:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/package.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",npm_config_local_prefix:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"=",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",NVM_DIR:"/home/runner/.nvm",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220710.1",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",_:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin/vite",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22462",GITHUB_WORKFLOW:"E2E + A11y Tests",GITHUB_RUN_ID:"2665067924",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"=",ImageOS:"ubuntu20",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"=",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.16.0/x64/bin:~/.bun/bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.16.0/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",NODE:"/opt/hostedtoolcache/node/16.16.0/x64/bin/node",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_219ad359-a0e5-4068-89fe-e3a66f9e0930",INVOCATION_ID:"1b29546473094331b25d36772581372b",npm_package_name:"tictactoe_spiral_web",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",GITHUB_ACTION:"__run_7",GITHUB_RUN_NUMBER:"18",RUNNER_ARCH:"X64",XDG_RUNTIME_DIR:"/run/user/1001",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"=",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",npm_package_version:"0.0.1",STATS_PFS:"true",NODE_PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",GITHUB_REF_PROTECTED:"false",GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"d4789a73ca921b4228f30a29529dbf153f74d638",GITHUB_RUN_ATTEMPT:"1",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_aab92414-8914-4f8c-abfe-4a18af5cdab8",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",npm_execpath:"/home/runner/.bun/bin/bun",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",EDGEWEBDRIVER:"/usr/local/share/edge_driver",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_aab92414-8914-4f8c-abfe-4a18af5cdab8",NODE_ENV:"production"}.CODESPACE_NAME,Ct={token:fn,chainUrl:et?`http://${et}-4001.githubpreview.dev`:cn,chainPort:et?80:dn,dbUrl:et?`ws://${et}-8765.githubpreview.dev`:"ws://localhost",dbPort:et?80:8765,accounts:pn,status:[],deploy:[],gunJs:null,gunRs:null,counter:[]},Bt=(d,_="#888")=>(...t)=>{console.log("@@@ %c%s %c%s",`font-weight: bold; color: ${_}`,JSON.stringify(t),"font-weight: bold; color: #444",JSON.stringify(d()))},mt=Jt([d=>{d.on("@init",()=>Ct),d.on("set",(_,t)=>t)}]);function ot({key:d}){const[_,t]=z();return(()=>{const s=Gt.cloneNode(!0);return s.$$input=T=>t("set",{[d]:T.currentTarget.value}),V(()=>s.value=_[d]),s})()}function Dn(){return $n.cloneNode(!0)}function Rn(){return(()=>{const d=An.cloneNode(!0),_=d.firstChild,t=_.firstChild,s=t.firstChild,T=s.nextSibling,e=t.nextSibling,a=e.firstChild,i=a.nextSibling,g=e.nextSibling,v=g.firstChild,b=v.nextSibling;return U(T,J(ot,{key:"token"})),U(i,J(ot,{key:"chainUrl"})),U(b,J(ot,{key:"chainPort"})),d})()}function Dt({key:d,account:_}){const[t,s]=z();return(()=>{const T=Gt.cloneNode(!0);return T.$$input=e=>s("set",{accounts:t.accounts.map(a=>a.alias===_.alias?{...a,[d]:e.currentTarget.value}:a)}),V(()=>T.value=_[d]),T})()}function In(){const[d]=z();return(()=>{const _=wn.cloneNode(!0),t=_.firstChild;return U(t,J(Xt,{get each(){return d.accounts},children:s=>(()=>{const T=kn.cloneNode(!0),e=T.firstChild,a=e.nextSibling,i=a.firstChild,g=i.firstChild,v=g.firstChild,b=v.firstChild,f=b.nextSibling,p=v.nextSibling,w=p.firstChild,D=w.nextSibling;return U(e,()=>s.alias),U(f,J(Dt,{account:s,key:"address"})),U(D,J(Dt,{account:s,key:"privateKey"})),T})()})),_})()}function Pn(){const[d,_]=ct(!1),[t,s]=ct(!1);return bt(gt(()=>[t()],()=>t()&&s(!1))),st((()=>{const T=st(()=>!d(),!0);return()=>T()?(()=>{const e=xn.cloneNode(!0),a=e.firstChild;return a.$$click=()=>_(!0),e})():(()=>{const e=On.cloneNode(!0),a=e.firstChild;return a.$$click=()=>s(!0),U(a,J(mn,{size:"24px"})),U(e,(()=>{const i=st(()=>!t(),!0);return()=>i()&&En.cloneNode(!0)})(),null),V(()=>e.className=Pt.TestnetBankContainer),e})()})())}function Gn(){return(()=>{const d=Nn.cloneNode(!0),_=d.firstChild,t=_.firstChild,s=t.firstChild,T=s.nextSibling,e=t.nextSibling,a=e.firstChild,i=a.nextSibling;return U(T,J(ot,{key:"dbUrl"})),U(i,J(ot,{key:"dbPort"})),d})()}function Cn(){const[d,_]=z(),s=Bt(()=>({gunRs:!!d.gunRs,gunJs:!!d.gunJs}),"#cf1100");s("GunListener()");let T=mt.on("@changed",(e,a)=>{if(s("GunListener.store.@changed",{changed:Object.keys(a)}),a.dbUrl||a.dbPort){const i=new $t(`${d.dbUrl}:${d.dbPort}/gun`);_("set",{gunRs:i,gunJs:void 0})}});return ht(()=>T()),bt(gt(()=>[],()=>{s("GunListener.createEffect() callback");const e=d.gunRs||new $t(`${d.dbUrl}:${d.dbPort}/gun`);_("set",{gunRs:e,gunJs:void 0})})),[]}function vt(d,_){const[t,s]=z(),[T,e]=ct(-1),[a,i]=ct(!1),g=()=>({key:d,[`state.${d}.length`]:t[d].length,gunRs:!!t.gunRs,gunJs:!!t.gunJs,subscriptionRs:T(),subscriptionJs:a()}),b={...Object.keys(Ct).reduce((O,y)=>({...O,[y]:"#00cf2d"}),{}),status:"#cf6800",deploy:"#cccf00"},f=Bt(g,b[d]);f("useFetch()");let p=null;const w=(O,y)=>{f("useFetch.subscribe()");const u=o=>{let l=o;for(;typeof l=="string";)l=JSON.parse(l);return Array.isArray(l)?l:[l]};O&&e(O.get("app").get(d).on((o,l)=>{p&&clearInterval(p);const x=u(o);f("useFetch.subscribe _gunRs.on() callback",{k:l,length:x.length}),s("set",{[d]:x})})),y&&(y.get("app").get(d).on((o,l)=>{const x=u(o);f("useFetch.subscribe _gunJs.on() callback",{k:l,length:x.length}),s("set",{[d]:x})}),i(!0))},D=()=>{const O=T();t.gunRs&&O!==-1&&(f("useFetch.unsubscribe()"),t.gunRs.get("app").get(d).off(O));const y=a();t.gunJs&&y&&(f("useFetch.unsubscribe()"),t.gunJs.get("app").get(d).off())};let h=mt.on("@changed",(O,y)=>{(y.gunRs||y.gunJs)&&(f("useFetch.store.@changed",{changed:Object.keys(y)}),D(),w(t.gunRs,t.gunJs))});return ht(()=>h()),bt(gt(()=>[],()=>{f("useFetch.createEffect() callback. setTimeout..."),p=setInterval(()=>{f("useFetch.createEffect() callback setTimeout subscribe..."),D(),w(t.gunRs,t.gunJs)},2e3)})),ht(D),{request:async()=>{f("useFetch.request()");const O=an(t.token,t.chainUrl,t.chainPort);let y;try{const u=await _(O);y=[...t[d],u]}catch(u){y=[...t[d],u]}s("set",{[d]:y}),t.gunRs&&t.gunRs.get("app").get(d).put(y),t.gunJs&&t.gunJs.get("app").get(d).put(y)},clear:async()=>{f("useFetch.clear()"),s("set",{[d]:[]}),t.gunRs&&t.gunRs.get("app").get(d).put([]),t.gunJs&&t.gunJs.get("app").get(d).put([])}}}function Bn(){const[d,_]=z(),{request:t,clear:s}=vt("counter",async T=>d.counter.length);return(()=>{const T=yt.cloneNode(!0),e=T.firstChild,a=e.nextSibling,i=a.nextSibling;return Y(e,"click",t,!0),Y(a,"click",s,!0),U(i,()=>JSON.stringify(d.counter,null,2)),T})()}function Hn(){const[d,_]=z(),{request:t,clear:s}=vt("status",T=>T.status().do());return(()=>{const T=yt.cloneNode(!0),e=T.firstChild,a=e.nextSibling,i=a.nextSibling;return Y(e,"click",t,!0),Y(a,"click",s,!0),U(i,()=>JSON.stringify(d.status,null,2)),T})()}function Ln(){const[d,_]=z(),{request:t,clear:s}=vt("deploy",async T=>{const e=d.accounts[0]?.address,a=d.accounts[0]?.privateKey;if(e&&a)try{return await un(T,e,a,hn,_n,{numGlobalByteSlices:ln,numGlobalInts:sn})}catch(i){return i}else return"Invalid admin account"});return(()=>{const T=yt.cloneNode(!0),e=T.firstChild,a=e.nextSibling,i=a.nextSibling;return Y(e,"click",t,!0),Y(a,"click",s,!0),U(i,()=>JSON.stringify(d.deploy,null,2)),T})()}function Xn(){return J(Ft,{store:mt,get children(){return[J(Cn,{}),(()=>{const d=jn.cloneNode(!0),_=d.firstChild,t=_.firstChild,s=t.firstChild,T=s.firstChild,e=T.nextSibling,a=s.nextSibling,i=a.nextSibling,g=i.firstChild,v=g.nextSibling,b=i.nextSibling,f=b.firstChild,p=f.nextSibling,w=b.nextSibling,D=w.firstChild,h=D.nextSibling,A=w.nextSibling,m=A.nextSibling,O=m.firstChild,y=O.nextSibling,u=m.nextSibling,o=u.nextSibling,l=o.firstChild,x=l.nextSibling,$=o.nextSibling,j=$.nextSibling,E=j.firstChild,I=E.nextSibling,G=j.nextSibling,r=G.firstChild,n=r.nextSibling;return U(e,J(Dn,{})),U(v,J(Rn,{})),U(p,J(In,{})),U(h,J(Pn,{})),U(y,J(Gn,{})),U(x,J(Bn,{})),U(I,J(Hn,{})),U(n,J(Ln,{})),V(()=>d.className=Pt.App),d})()]}})}Rt(["input","click"]);export{Xn as A,Fn as r};
