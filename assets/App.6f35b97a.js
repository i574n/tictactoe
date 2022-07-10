import{i as q,a as Y,k as Pt,s as W,l as V,m as It,f as Gt,h as Ct,n as Bt,j as J,S as Ht,u as ot,F as Ut,o as it,q as $t,r as wt,t as Mt}from"./solid.b88a951c.js";import{a as st}from"./algosdk.7ee7fe43.js";import{N as Lt}from"./gun.5c5f3c68.js";q();Y();var Jt=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],Xt=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...Jt]),Ft=new Set(["innerHTML","textContent","innerText","children"]),Kt={className:"class",htmlFor:"for"},bt={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},Vt=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),Wt={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function lt(h,_){return It(h,void 0,_?void 0:{equals:_})}function zt(h,_,n){let p=n.length,$=_.length,e=p,a=0,r=0,g=_[$-1].nextSibling,y=null;for(;a<$||r<e;){if(_[a]===n[r]){a++,r++;continue}for(;_[$-1]===n[e-1];)$--,e--;if($===a){const b=e<p?r?n[r-1].nextSibling:n[e-r]:g;for(;r<e;)h.insertBefore(n[r++],b)}else if(e===r)for(;a<$;)(!y||!y.has(_[a]))&&_[a].remove(),a++;else if(_[a]===n[e-1]&&n[r]===_[$-1]){const b=_[--$].nextSibling;h.insertBefore(n[r++],_[a++].nextSibling),h.insertBefore(n[--e],b),_[$]=n[e]}else{if(!y){y=new Map;let d=r;for(;d<e;)y.set(n[d],d++)}const b=y.get(_[a]);if(b!=null)if(r<b&&b<e){let d=a,s=1,S;for(;++d<$&&d<e&&!((S=y.get(_[d]))==null||S!==b+s);)s++;if(s>b-r){const E=_[a];for(;r<b;)h.insertBefore(n[r++],E)}else h.replaceChild(n[r++],_[a++])}else a++;else _[a++].remove()}}}var gt="_$DX_DELEGATE";function Ln(h,_,n){let p;return Pt($=>{p=$,_===document?h():L(_,h(),_.firstChild?null:void 0,n)}),()=>{p(),_.textContent=""}}function F(h,_,n){const p=document.createElement("template");p.innerHTML=h;let $=p.content.firstChild;return n&&($=$.firstChild),$}function xt(h,_=window.document){const n=_[gt]||(_[gt]=new Set);for(let p=0,$=h.length;p<$;p++){const e=h[p];n.has(e)||(n.add(e),_.addEventListener(e,en))}}function ft(h,_,n){n==null?h.removeAttribute(_):h.setAttribute(_,n)}function qt(h,_,n,p){p==null?h.removeAttributeNS(_,n):h.setAttributeNS(_,n,p)}function Yt(h,_){_==null?h.removeAttribute("class"):h.className=_}function Qt(h,_,n,p){p?Array.isArray(n)?(h[`$$${_}`]=n[0],h[`$$${_}Data`]=n[1]):h[`$$${_}`]=n:Array.isArray(n)?h.addEventListener(_,$=>n[0](n[1],$)):h.addEventListener(_,n)}function Zt(h,_,n={}){const p=Object.keys(_||{}),$=Object.keys(n);let e,a;for(e=0,a=$.length;e<a;e++){const r=$[e];!r||r==="undefined"||_[r]||(mt(h,r,!1),delete n[r])}for(e=0,a=p.length;e<a;e++){const r=p[e],g=!!_[r];!r||r==="undefined"||n[r]===g||!g||(mt(h,r,!0),n[r]=g)}return n}function Ot(h,_,n={}){const p=h.style,$=typeof n=="string";if(_==null&&$||typeof _=="string")return p.cssText=_;$&&(p.cssText=void 0,n={}),_||(_={});let e,a;for(a in n)_[a]==null&&p.removeProperty(a),delete n[a];for(a in _)e=_[a],e!==n[a]&&(p.setProperty(a,e),n[a]=e);return n}function yt(h,_,n,p){typeof _=="function"?V($=>kt(h,_(),$,n,p)):kt(h,_,void 0,n,p)}function L(h,_,n,p){if(n!==void 0&&!p&&(p=[]),typeof _!="function")return nt(h,_,p,n);V($=>nt(h,_(),$,n),p)}function tn(h,_,n,p,$={},e=!1){_||(_={});for(const a in $)if(!(a in _)){if(a==="children")continue;vt(h,a,null,$[a],n,e)}for(const a in _){if(a==="children"){p||nt(h,_.children);continue}const r=_[a];$[a]=vt(h,a,r,$[a],n,e)}}function nn(h){return h.toLowerCase().replace(/-([a-z])/g,(_,n)=>n.toUpperCase())}function mt(h,_,n){const p=_.trim().split(/\s+/);for(let $=0,e=p.length;$<e;$++)h.classList.toggle(p[$],n)}function vt(h,_,n,p,$,e){let a,r,g;if(_==="style")return Ot(h,n,p);if(_==="classList")return Zt(h,n,p);if(n===p)return p;if(_==="ref")e||n(h);else if(_.slice(0,3)==="on:")h.addEventListener(_.slice(3),n);else if(_.slice(0,10)==="oncapture:")h.addEventListener(_.slice(10),n,!0);else if(_.slice(0,2)==="on"){const y=_.slice(2).toLowerCase(),b=Vt.has(y);Qt(h,y,n,b),b&&xt([y])}else if((g=Ft.has(_))||!$&&(bt[_]||(r=Xt.has(_)))||(a=h.nodeName.includes("-")))_==="class"||_==="className"?Yt(h,n):a&&!r&&!g?h[nn(_)]=n:h[bt[_]||_]=n;else{const y=$&&_.indexOf(":")>-1&&Wt[_.split(":")[0]];y?qt(h,y,_,n):ft(h,Kt[_]||_,n)}return n}function en(h){const _=`$$${h.type}`;let n=h.composedPath&&h.composedPath()[0]||h.target;for(h.target!==n&&Object.defineProperty(h,"target",{configurable:!0,value:n}),Object.defineProperty(h,"currentTarget",{configurable:!0,get(){return n||document}}),W.registry&&!W.done&&(W.done=!0,document.querySelectorAll("[id^=pl-]").forEach(p=>p.remove()));n!==null;){const p=n[_];if(p&&!n.disabled){const $=n[`${_}Data`];if($!==void 0?p($,h):p(h),h.cancelBubble)return}n=n.host&&n.host!==n&&n.host instanceof Node?n.host:n.parentNode}}function kt(h,_,n={},p,$){return _||(_={}),!$&&"children"in _&&V(()=>n.children=nt(h,_.children,n.children)),_.ref&&_.ref(h),V(()=>tn(h,_,p,!0,n,!0)),n}function nt(h,_,n,p,$){for(W.context&&!n&&(n=[...h.childNodes]);typeof n=="function";)n=n();if(_===n)return n;const e=typeof _,a=p!==void 0;if(h=a&&n[0]&&n[0].parentNode||h,e==="string"||e==="number"){if(W.context)return n;if(e==="number"&&(_=_.toString()),a){let r=n[0];r&&r.nodeType===3?r.data=_:r=document.createTextNode(_),n=Z(h,n,p,r)}else n!==""&&typeof n=="string"?n=h.firstChild.data=_:n=h.textContent=_}else if(_==null||e==="boolean"){if(W.context)return n;n=Z(h,n,p)}else{if(e==="function")return V(()=>{let r=_();for(;typeof r=="function";)r=r();n=nt(h,r,n,p)}),()=>n;if(Array.isArray(_)){const r=[];if(dt(r,_,$))return V(()=>n=nt(h,r,n,p,!0)),()=>n;if(W.context){for(let g=0;g<r.length;g++)if(r[g].parentNode)return n=r}if(r.length===0){if(n=Z(h,n,p),a)return n}else Array.isArray(n)?n.length===0?St(h,r,p):zt(h,n,r):(n&&Z(h),St(h,r));n=r}else if(_ instanceof Node){if(W.context&&_.parentNode)return n=a?[_]:_;if(Array.isArray(n)){if(a)return n=Z(h,n,p,_);Z(h,n,null,_)}else n==null||n===""||!h.firstChild?h.appendChild(_):h.replaceChild(_,h.firstChild);n=_}}return n}function dt(h,_,n){let p=!1;for(let $=0,e=_.length;$<e;$++){let a=_[$],r;if(a instanceof Node)h.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))p=dt(h,a)||p;else if((r=typeof a)=="string")h.push(document.createTextNode(a));else if(r==="function")if(n){for(;typeof a=="function";)a=a();p=dt(h,Array.isArray(a)?a:[a])||p}else h.push(a),p=!0;else h.push(document.createTextNode(a.toString()))}return p}function St(h,_,n){for(let p=0,$=_.length;p<$;p++)h.insertBefore(_[p],n)}function Z(h,_,n,p){if(n===void 0)return h.textContent="";const $=p||document.createTextNode("");if(_.length){let e=!1;for(let a=_.length-1;a>=0;a--){const r=_[a];if($!==r){const g=r.parentNode===h;!e&&!a?g?h.replaceChild($,r):h.insertBefore($,n):g&&r.remove()}else e=!0}}else h.insertBefore($,n);return[$]}q();Y();var ct=h=>new Uint8Array(Buffer.from(h,"base64")),Et=(h,_,n)=>new st.Algodv2(h,_,n),Tt={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},rn=async(h,_,n,p,$,e=Tt)=>{try{const a=await h.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const r=await h.compile(p).do(),g=await h.compile($).do(),y=st.makeApplicationCreateTxnFromObject({suggestedParams:a,from:_,onComplete:st.OnApplicationComplete.NoOpOC,approvalProgram:ct(r.result),clearProgram:ct(g.result),...Tt,...e}),b=y.signTxn(ct(n)),{txId:d}=await h.sendRawTransaction(b).do(),s=await st.waitForConfirmation(h,d,5),S=s["application-index"];return{suggestedParams:a,applicationStartCompiled:r,clearProgramCompiled:g,txn:y,txnSigned:b,txId:d,transactionResponse:s,appId:S}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}};const on=`#pragma version 6
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
return`,an=`#pragma version 6
int 1
return`;var un="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",sn="http://localhost",ln=4001,fn=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}],cn=5,pn=4;q();Y();q();Y();q();Y();var dn=F('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),_n=F("<title></title>");function hn(h,_){return(()=>{const n=dn.cloneNode(!0);return yt(n,()=>h.a,!0,!0),yt(n,_,!0,!0),L(n,()=>h.c,null),L(n,(()=>{const p=lt(()=>!!_.title,!0);return()=>p()&&(()=>{const $=_n.cloneNode(!0);return L($,()=>_.title),$})()})(),null),V(p=>{const $=h.a.stroke,e={..._.style,overflow:"visible",color:_.color},a=_.size||"1em",r=_.size||"1em",g=h.c;return $!==p._v$&&ft(n,"stroke",p._v$=$),p._v$2=Ot(n,e,p._v$2),a!==p._v$3&&ft(n,"height",p._v$3=a),r!==p._v$4&&ft(n,"width",p._v$4=r),g!==p._v$5&&(n.innerHTML=p._v$5=g),p},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),n})()}function bn(h){return hn({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},h)}var gn=Gt({"node_modules/.pnpm/gun@0.2020.1237/node_modules/gun/gun.js"(h,_){q(),Y(),function(){function n($,e){return e?Ct($):$.slice?n[a($)]:function(r,g){$(r={exports:{}}),n[a(g)]=r.exports};function a(r){return r.split("/").slice(-1).toString().replace(".js","")}}if(typeof _<"u")var p=_;n(function($){String.random=function(a,r){var g="";for(a=a||24,r=r||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";a-- >0;)g+=r.charAt(Math.floor(Math.random()*r.length));return g},String.match=function(a,r){var g,y;return typeof a!="string"?!1:(typeof r=="string"&&(r={"=":r}),r=r||{},g=r["="]||r["*"]||r[">"]||r["<"],a===g?!0:y!==r["="]?!1:(g=r["*"]||r[">"],a.slice(0,(g||"").length)===g?!0:y!==r["*"]?!1:y!==r[">"]&&y!==r["<"]?a>=r[">"]&&a<=r["<"]:y!==r[">"]&&a>=r[">"]||y!==r["<"]&&a<=r["<"]))},String.hash=function(a,r){if(typeof a=="string"){if(r=r||0,!a.length)return r;for(var g=0,y=a.length,b;g<y;++g)b=a.charCodeAt(g),r=(r<<5)-r+b,r|=0;return r}};var e=Object.prototype.hasOwnProperty;Object.plain=function(a){return a?a instanceof Object&&a.constructor===Object||Object.prototype.toString.call(a).match(/^\[object (\w+)\]$/)[1]==="Object":!1},Object.empty=function(a,r){for(var g in a)if(e.call(a,g)&&(!r||r.indexOf(g)==-1))return!1;return!0},Object.keys=Object.keys||function(a){var r=[];for(var g in a)e.call(a,g)&&r.push(g);return r},function(){var a,r=setTimeout,g=0,y=0,b=typeof setImmediate!=""+a&&setImmediate||r;r.hold=r.hold||9,r.poll=r.poll||function(d){if(r.hold>=+new Date-g&&y++<3333){d();return}b(function(){g=+new Date,d()},y=0)}}(),function(){var a=setTimeout,r=a.turn=a.turn||function(S){g.push(S)==1&&y(s)},g=r.s=[],y=a.poll,b=0,d,s=function(){(d=g[b++])&&d(),(b==g.length||b==99)&&(g=r.s=g.slice(b),b=0),g.length&&y(s)}}(),function(){var a,r=setTimeout,g=r.turn;(r.each=r.each||function(y,b,d,s){s=s||9,function S(E,l,v){if(l=(E=(y||[]).splice(0,s)).length){for(var m=0;m<l&&a===(v=b(E[m]));m++);if(a===v){g(S);return}}d&&d(v)}()})()}()})(n,"./shim"),n(function($){$.exports=function e(d,r,g){if(!d)return{to:e};var y,b=typeof r=="function",d=(this.tag||(this.tag={}))[d]||b&&(this.tag[d]={tag:d,to:e._={next:function(S){var E;(E=this.to)&&E.next(S)}}});if(b){var s={off:e.off||(e.off=function(){if(this.next===e._.next)return!0;this===this.the.last&&(this.the.last=this.back),this.to.back=this.back,this.next=e._.next,this.back.to=this.to,this.the.last===this.the&&delete this.on.tag[this.the.tag]}),to:e._,next:r,the:d,on:this,as:g};return(s.back=d.last||d).to=s,d.last=s}return(d=d.to)&&y!==r&&d.next(r),d}})(n,"./onto"),n(function($){$.exports=function(e){return e===null||typeof e=="string"||typeof e=="boolean"||typeof e=="number"&&e!=1/0&&e!=-1/0&&e===e||!!e&&typeof e["#"]=="string"&&Object.keys(e).length===1&&e["#"]}})(n,"./valid"),n(function($){n("./shim");function e(){var d=+new Date;return y<d?(r=0,y=d+e.drift):y=d+(r+=1)/g+e.drift}e.drift=0;var a=-1/0,r=0,g=999,y=a,b;e.is=function(d,s,S){var E=s&&d&&d._&&d._[">"]||S;if(!!E)return typeof(E=E[s])=="number"?E:a},e.ify=function(d,s,S,E,l){(d=d||{})._=d._||{},l&&(d._["#"]=l);var v=d._[">"]||(d._[">"]={});return b!==s&&s!=="_"&&(typeof S=="number"&&(v[s]=S),b!==E&&(d[s]=E)),d},$.exports=e})(n,"./state"),n(function($){n("./shim");function e(a){var r={s:{}},g=r.s;a=a||{max:999,age:1e3*9},r.check=function(b){return g[b]?y(b):!1};var y=r.track=function(b){var d=g[b]||(g[b]={});return d.was=r.now=+new Date,r.to||(r.to=setTimeout(r.drop,a.age+9)),d};return r.drop=function(b){r.to=null,r.now=+new Date;var d=Object.keys(g);console.STAT&&console.STAT(r.now,+new Date-r.now,"dup drop keys"),setTimeout.each(d,function(s){var S=g[s];S&&(b||a.age)>r.now-S.was||delete g[s]},0,99)},r}$.exports=e})(n,"./dup"),n(function($){n("./onto"),$.exports=function(r,g){if(!!this.on){var y=(this.opt||{}).lack||9e3;if(typeof r!="function"){if(!r)return;var d=r["#"]||r,b=(this.tag||"")[d];return b?(g&&(b=this.on(d,g),clearTimeout(b.err),b.err=setTimeout(function(){b.off()},y)),!0):void 0}var d=g&&g["#"]||e(9);if(!r)return d;var s=this.on(d,r,g);return s.err=s.err||setTimeout(function(){s.off(),s.next({err:"Error: No ACK yet.",lack:!0})},y),d}};var e=String.random||function(){return Math.random().toString(36).slice(2)}})(n,"./ask"),n(function($){function e(l){return l instanceof e?(this._={$:this}).$:this instanceof e?e.create(this._={$:this,opt:l}):new e(l)}e.is=function(l){return l instanceof e||l&&l._&&l===l._.$||!1},e.version=.202,e.chain=e.prototype,e.chain.toJSON=function(){},n("./shim"),e.valid=n("./valid"),e.state=n("./state"),e.on=n("./onto"),e.dup=n("./dup"),e.ask=n("./ask"),function(){e.create=function(t){t.root=t.root||t,t.graph=t.graph||{},t.on=t.on||e.on,t.ask=t.ask||e.ask,t.dup=t.dup||e.dup();var f=t.$.opt(t.opt);return t.once||(t.on("in",l,t),t.on("out",l,t),t.on("put",N,t),e.on("create",t),t.on("create",t)),t.once=1,f};function l(t){if(!!t){if(t.out===l){this.to.next(t);return}var f=this,k=f.as,R=k.at||k,j=R.$,w=R.dup,I,G=t.DBG;if((I=t["#"])||(I=t["#"]=r(9)),!w.check(I)){if(w.track(I),I=t._,t._=typeof I=="function"?I:function(){},t.$&&t.$===(t.$._||"").$||(t.$=j),t["@"]&&!t.put&&u(t),!R.ask(t["@"],t))if(G&&(G.u=+new Date),t.put){v(t);return}else t.get&&e.on.get(t,j);G&&(G.uc=+new Date),f.to.next(t),G&&(G.ua=+new Date),!(t.nts||t.NTS)&&(t.out=l,R.on("out",t),G&&(G.ue=+new Date))}}}function v(t){if(!!t){var f=t._||"",k=f.root=((f.$=t.$||"")._||"").root;if(t["@"]&&f.faith&&!f.miss){t.out=l,k.on("out",t);return}f.latch=k.hatch,f.match=k.hatch=[];var R=t.put,j=f.DBG=t.DBG,w=+new Date;if(C=C||w,!(R["#"]&&R["."])){j&&(j.p=w),f["#"]=t["#"],f.msg=t,f.all=0,f.stun=1;var I=Object.keys(R);console.STAT&&console.STAT(w,((j||f).pk=+new Date)-w,"put sort");var G=0,B,H,U,M,X,K,et;(function Q(at){if(B!=G){if(B=G,!(U=I[G])){console.STAT&&console.STAT(w,((j||f).pd=+new Date)-w,"put"),T(f);return}(M=R[U])?(et=M._)?U!==et["#"]?K=c+O(U)+"soul not same.":(X=et[">"])||(K=c+O(U)+"no state."):K=c+O(U)+"no meta.":K=c+O(U)+"no node.",H=Object.keys(M||{})}if(K){t.err=f.err=K,T(f);return}var _t=0,z;for(at=at||0;at++<9&&(z=H[_t++]);)if(z!=="_"){var ut=M[z],ht=X[z];if(s===ht){K=c+O(z)+"on"+O(U)+"no state.";break}if(!y(ut)){K=c+O(z)+"on"+O(U)+"bad "+typeof ut+O(ut);break}m(ut,z,U,ht,t),++P}if((H=H.slice(_t)).length){g(Q);return}++G,H=null,Q(at)})()}}}e.on.put=v;function m(t,f,k,R,j){var w=j._||"",I=w.root,G=I.graph,B,H=G[k]||S,U=b(H,f,1),M=H[f],X=w.DBG;(B=console.STAT)&&(!G[k]||!M)&&(B.has=(B.has||0)+1);var K=x();if(R>K){setTimeout(function(){m(t,f,k,R,j)},(B=R-K)>D?D:B),console.STAT&&console.STAT((X||w).Hf=+new Date,B,"future");return}if(!(R<U&&!w.miss)&&!(!w.faith&&R===U&&(t===M||A(t)<=A(M))&&!w.miss)){w.stun++;var et=j["#"]+w.all++,Q={toString:function(){return et},_:w};Q.toJSON=Q.toString,X&&(X.ph=X.ph||+new Date),I.on("put",{"#":Q,"@":j["@"],put:{"#":k,".":f,":":t,">":R},_:w})}}function N(t){var f;(f=(t._||"").DBG)&&(f.pa=+new Date,f.pm=f.pm||+new Date);var k=this,R=k.as,j=R.graph,w=t._,I=t.put,G=I["#"],B=I["."],H=I[":"],U=I[">"];t["#"];var M;(M=w.msg)&&(M=M.put)&&(M=M[G])&&d(M,B,U,H,G),j[G]=d(j[G],B,U,H,G),(M=(R.next||"")[G])&&M.on("in",t),T(w),k.to.next(t)}function T(t,f){var k;if(!t.stop&&!(!t.err&&0<--t.stun)&&(t.stop=1,!!(k=t.root))){var R=t.match;R.end=1,R===k.hatch&&(!(R=t.latch)||R.end?delete k.hatch:k.hatch=R),t.hatch&&t.hatch(),setTimeout.each(t.match,function(j){j&&j()}),!(!(f=t.msg)||t.err||f.err)&&(f.out=l,t.root.on("out",f),i())}}function u(t){var f=t["@"]||"",k;!(k=f._)||(k.acks=(k.acks||0)+1,(k.err=t.err)&&(t["@"]=k["#"],T(k)),!k.stop&&!k.crack&&(k.crack=k.match&&k.match.push(function(){o(k)})),o(k))}function o(t){!t||!t.root||t.stun||t.acks!==t.all||t.root.on("in",{"@":t["#"],err:t.err,ok:t.err?s:{"":1}})}var c="Error: Invalid graph!",O=function(t){return" '"+(""+t).slice(0,9)+"...' "},A=JSON.stringify,D=2147483647,x=e.state,P=0,C,i=function(){P>999&&P/-(C-(C=+new Date))>1&&(e.window&&console.log("Warning: You're syncing 1K+ records a second, faster than DOM can update - consider limiting query."),i=function(){P=0})}}(),function(){e.on.get=function(v,m){var N=m._,T=v.get,u=T["#"],o=N.graph[u],c=T["."],O=N.next||(N.next={});O[u];var A=v._||{},D=A.DBG=v.DBG;if(D&&(D.g=+new Date),!o)return N.on("get",v);if(c){if(typeof c!="string"||s===o[c])return N.on("get",v);o=d({},c,b(o,c),o[c],u)}o&&l(v,o),N.on("get",v)};function l(v,m){var N=+new Date,T=v._||{},u=T.DBG=v.DBG,o=v["#"],c=r(9),O=Object.keys(m||"").sort(),A=((m||"")._||"")["#"];O.length;var D=v.$._.root,x=m===D.graph[A];console.STAT&&console.STAT(N,((u||T).gk=+new Date)-N,"got keys"),m&&function P(){N=+new Date;for(var C=0,i,t={},f;C<9&&(i=O[C++]);)d(t,i,b(m,i),m[i],A);O=O.slice(C),(f={})[A]=t,t=f;var k;x&&(k=function(){},k.ram=k.faith=!0),f=O.length,console.STAT&&console.STAT(N,-(N-(N=+new Date)),"got copied some"),u&&(u.ga=+new Date),D.on("in",{"@":o,"#":c,put:t,"%":f?c=r(9):s,$:D.$,_:k,DBG:u}),console.STAT&&console.STAT(N,+new Date-N,"got in"),f&&setTimeout.turn(P)}(),m||D.on("in",{"@":v["#"]})}e.on.get.ack=l}(),function(){e.chain.opt=function(l){l=l||{};var v=this,m=v._,N=l.peers||l;return Object.plain(l)||(l={}),Object.plain(m.opt)||(m.opt=l),typeof N=="string"&&(N=[N]),Object.plain(m.opt.peers)||(m.opt.peers={}),N instanceof Array&&(l.peers={},N.forEach(function(T){var u={};u.id=u.url=T,l.peers[T]=m.opt.peers[T]=m.opt.peers[T]||u})),a(l,function T(u){var o=this[u];if(this&&this.hasOwnProperty(u)||typeof o=="string"||Object.empty(o)){this[u]=o;return}o&&o.constructor!==Object&&!(o instanceof Array)||a(o,T)}),m.opt.from=l,e.on("opt",m),m.opt.uuid=m.opt.uuid||function(u){return e.state().toString(36).replace(".","")+String.random(u||12)},v}}();var a=function(l,v){Object.keys(l).forEach(v,l)},r=String.random,g=setTimeout.turn,y=e.valid,b=e.state.is,d=e.state.ify,s,S={},E;e.log=function(){return!e.log.off&&E.log.apply(E,arguments),[].slice.call(arguments).join(" ")},e.log.once=function(l,v,m){return(m=e.log.once)[l]=m[l]||0,m[l]++||e.log(v)},typeof window<"u"&&((window.GUN=window.Gun=e).window=window);try{typeof p<"u"&&(p.exports=e)}catch{}$.exports=e,(e.window||{}).console=(e.window||{}).console||{log:function(){}},(E=console).only=function(l,v){return E.only.i&&l===E.only.i&&E.only.i++&&(E.log.apply(E,arguments)||v)},e.log.once("welcome","Hello wonderful person! :) Thanks for using GUN, please ask for help on http://chat.gun.eco if anything takes you longer than 5min to figure out!")})(n,"./root"),n(function($){var e=n("./root");e.chain.back=function(g,y){var b;if(g=g||1,g===-1||g===1/0)return this._.root.$;if(g===1)return(this._.back||this._).$;var d=this,s=d._;if(typeof g=="string"&&(g=g.split(".")),g instanceof Array){var S=0,E=g.length,b=s;for(S;S<E;S++)b=(b||a)[g[S]];return r!==b?y?d:b:(b=s.back)?b.$.back(g,y):void 0}if(typeof g=="function"){for(var l,b={back:s};(b=b.back)&&r===(l=g(b,y)););return l}return typeof g=="number"?(s.back||s).$.back(g-1):this};var a={},r})(n,"./back"),n(function($){var e=n("./root");e.chain.chain=function(T){var u=this,o=u._,c=new(T||u).constructor(u),O=c._,A;return O.root=A=o.root,O.id=++A.once,O.back=u._,O.on=e.on,O.on("in",e.on.in,O),O.on("out",e.on.out,O),c};function a(T){var u,o=this.as,c=o.back,O=o.root,A;if(T.$||(T.$=o.$),this.to.next(T),o.err){o.on("in",{put:o.put=s,$:o.$});return}if(u=T.get){if(O.pass&&(O.pass[o.id]=o),o.lex&&Object.keys(o.lex).forEach(function(D){A[D]=o.lex[D]},A=T.get=T.get||{}),u["#"]||o.soul){if(u["#"]=u["#"]||o.soul,T["#"]||(T["#"]=S(9)),c=O.$.get(u["#"])._,u=u["."]){if(l(c.put,u)&&(A=c.ask&&c.ask[u],(c.ask||(c.ask={}))[u]=c.$.get(u)._,c.on("in",{get:u,put:{"#":c.soul,".":u,":":c.put[u],">":m(O.graph[c.soul],u)}}),A))return}else{if(A=c.ask&&c.ask[""],(c.ask||(c.ask={}))[""]=c,s!==c.put&&(c.on("in",c),A))return;T.$=c.$}return O.ask(b,T),O.on("in",T)}if(u["."])return o.get?(T={get:{".":o.get},$:o.$},(c.ask||(c.ask={}))[o.get]=T.$._,c.on("out",T)):(T={get:o.lex?T.get:{},$:o.$},c.on("out",T));if((o.ask||(o.ask={}))[""]=o,o.get)return u["."]=o.get,(c.ask||(c.ask={}))[o.get]=T.$._,c.on("out",T)}return c.on("out",T)}e.on.out=a;function r(T,u){u=u||this.as;var o=u.root,c=T.$||(T.$=u.$),O=(c||"")._||d,A=T.put||"",D=A["#"],x=A["."],P=s!==A["="]?A["="]:A[":"],C=A[">"]||-1/0,i;if(s!==T.put&&(s===A["#"]||s===A["."]||s===A[":"]&&s===A["="]||s===A[">"])){if(!E(A)){if(!(D=((A||"")._||"")["#"])){console.log("chain not yet supported for",A,"...",T,u);return}return c=u.root.$.get(D),setTimeout.each(Object.keys(A).sort(),function(t){t=="_"||s===(C=m(A,t))||u.on("in",{$:c,put:{"#":D,".":t,"=":A[t],">":C},VIA:T})})}u.on("in",{$:O.back.$,put:{"#":D=O.back.soul,".":x=O.has||O.get,"=":A,">":m(O.back.put,x)},via:T});return}(T.seen||"")[u.id]||((T.seen||(T.seen=function(){}))[u.id]=u,u!==O&&(Object.keys(T).forEach(function(t){A[t]=T[t]},A={}),A.get=u.get||A.get,!u.soul&&!u.has?A.$$$=A.$$$||u.$:O.soul&&(A.$=u.$,A.$$=A.$$||O.$),T=A),y(T,u),(u.soul||T.$$)&&C>=m(o.graph[D],x)&&((A=o.$.get(D)._).put=N(A.put,x,C,P,D)),!O.soul&&C>=m(o.graph[D],x)&&(i=(o.$.get(D)._.next||"")[x])&&(i.put=P,typeof(A=E(P))=="string"&&(i.put=o.$.get(A)._.put||P)),this.to&&this.to.next(T),u.any&&setTimeout.each(Object.keys(u.any),function(t){(t=u.any[t])&&t(T)},0,99),u.echo&&setTimeout.each(Object.keys(u.echo),function(t){(t=u.echo[t])&&t.on("in",T)},0,99),((T.$$||"")._||O).soul&&(i=u.next)&&(i=i[x])&&(A={},Object.keys(T).forEach(function(t){A[t]=T[t]}),A.$=(T.$$||T.$).get(A.get=x),delete A.$$,delete A.$$$,i.on("in",A)),g(T,u))}e.on.in=r;function g(T,u){if(u=u||this.as||T.$._,!(T.$$&&this!==e.on)&&!(!T.put||u.soul)){var o=T.put||"",c=o["="]||o[":"],x,O=u.root,A=O.$.get(o["#"]).get(o["."])._;if(typeof(c=E(c))!="string"){this===e.on&&((A.echo||(A.echo={}))[u.id]=u);return}if(!((A.echo||(A.echo={}))[u.id]&&!(O.pass||"")[u.id])){if(x=O.pass){if(x[c+u.id])return;x[c+u.id]=1}(A.echo||(A.echo={}))[u.id]=u,u.has&&(u.link=c);var D=O.$.get(A.link=c)._;(D.echo||(D.echo={}))[A.id]=A;var x=u.ask||"";(x[""]||u.lex)&&D.on("out",{get:{"#":c}}),setTimeout.each(Object.keys(x),function(P,C){!P||!(C=x[P])||C.on("out",{get:{"#":c,".":P}})},0,99)}}}e.on.link=g;function y(T,u){var o=T.put||"",c=s!==o["="]?o["="]:o[":"],O=u.root,A,D;if(s===c){if(u.soul&&s!==u.put||(D=(T.$$||T.$||"")._||"",T["@"]&&(s!==D.put||s!==u.put)))return;(A=u.link||T.linked)&&delete(O.$.get(A)._.echo||"")[u.id],u.has&&(u.link=null),u.put=s,setTimeout.each(Object.keys(u.next||""),function(x,P){!(P=u.next[x])||(A&&delete(O.$.get(A).get(x)._.echo||"")[P.id],P.on("in",{get:x,put:s,$:P.$}))},0,99);return}u.soul||T.$$||(A=E(c),D=T.$._||"",!((A===D.link||u.has&&!D.link)&&!((O.pass||"")[u.id]&&typeof A!="string"))&&(delete(D.echo||"")[u.id],y({get:u.get,put:s,$:T.$,linked:T.linked=T.linked||D.link},u)))}e.on.unlink=y;function b(T,u){var o=this.as,c=o.$._;c.root;var O=o.get||"",A=(T.put||"")[O["#"]]||"";if(!T.put||typeof O["."]=="string"&&s===A[O["."]]){if(s!==c.put||!c.soul&&!c.has)return;c.ack=(c.ack||0)+1,c.on("in",{get:c.get,put:c.put=s,$:c.$,"@":T["@"]});return}(T._||{}).miss=1,e.on.put(T)}var d={},s,S=String.random,E=e.valid,l=function(T,u){return T&&Object.prototype.hasOwnProperty.call(T,u)},v=e.state,m=v.is,N=v.ify})(n,"./chain"),n(function($){var e=n("./root");e.chain.get=function(s,S,E){var l,v;if(typeof s=="string"){if(s.length==0)return(l=this.chain())._.err={err:e.log("0 length key!",s)},S&&S.call(l,l._.err),l;var m=this,N=m._,T=N.next||y;(l=T[s])||(l=s&&a(s,m)),l=l&&l.$}else if(typeof s=="function"){let A=function(x,P,C){if(!A.stun&&!((j=o.pass)&&!j[c])){var i=x.$._,t=(x.$$||"")._,f=(t||i).put,k=!i.has&&!i.soul,R={},j;if((k||d===f)&&(f=d===((j=x.put)||"")["="]?d===(j||"")[":"]?j:j[":"]:j["="]),typeof(j=e.valid(f))=="string"&&(f=d===(j=o.$.get(j)._.put)?u.not?d:f:j),!(u.not&&d===f)){if(d===u.stun){if((j=o.stun)&&j.on&&(N.$.back(function(w){if(j.on(""+w.id,R={}),(R.run||0)<A.id)return R}),!R.run&&j.on(""+i.id,R={}),!R.run&&t&&j.on(""+t.id,R={}),A.id>R.run&&((!R.stun||R.stun.end)&&(R.stun=j.on("stun"),R.stun=R.stun&&R.stun.last),R.stun&&!R.stun.end))){(R.stun.add||(R.stun.add={}))[c]=function(){A(x,P,1)};return}if(d===f&&(C=0),(j=o.hatch)&&!j.end&&d===u.hatch&&!C){if(O[i.$._.id])return;O[i.$._.id]=1,j.push(function(){A(x,P,1)});return}O={}}if(o.pass){if(o.pass[c+i.id])return;o.pass[c+i.id]=1}if(u.on){u.ok.call(i.$,f,i.get,x,P||A);return}if(u.v2020){u.ok(x,P||A);return}Object.keys(x).forEach(function(w){j[w]=x[w]},j={}),x=j,x.put=f,u.ok.call(u.as,x,P||A)}}};if(S===!0)return r(this,s,S,E),this;l=this;var N=l._,u=S||{},o=N.root,c;u.at=N,u.ok=s;var O={};return A.at=N,(N.any||(N.any={}))[c=String.random(7)]=A,A.off=function(){A.stun=1,N.any&&delete N.any[c]},A.rid=g,A.id=u.run||++o.once,v=o.pass,(o.pass={})[c]=1,u.out=u.out||{get:{}},N.on("out",u.out),o.pass=v,l}else{if(typeof s=="number")return this.get(""+s,S,E);if(typeof(v=b(s))=="string")return this.get(v,S,E);(v=this.get.next)&&(l=v(this,s))}return l?(S&&typeof S=="function"&&l.get(S,E),l):((l=this.chain())._.err={err:e.log("Invalid get request!",s)},S&&S.call(l,l._.err),l)};function a(s,S){var E=S._,l=E.next,v=S.chain(),m=v._;return l||(l=E.next={}),l[m.get=s]=m,S===E.root.$?m.soul=s:(E.soul||E.has)&&(m.has=s),m}function r(s,S,E,l){var v=s._,m=0,N;return(N=v.soul||v.link)?S(N,l,v):v.jam?v.jam.push([S,l]):(v.jam=[[S,l]],s.get(function(u,o){if(!(d===u.put&&!v.root.opt.super&&(N=Object.keys(v.root.opt.peers).length)&&++m<=N)){o.rid(u);var c=(c=u.$)&&c._||{},O=0,A;for(N=v.jam,delete v.jam;A=N[O++];){var D=A[0];A=A[1],D&&D(c.link||c.soul||e.valid(u.put)||((u.put||{})._||{})["#"],A,u,o)}}},{out:{get:{".":!0}}}),s)}function g(s){var S=this.at||this.on;if(!s||S.soul||S.has)return this.off();if(!!(s=(s=(s=s.$||s)._||s).id)){S.map;var E;if((E=this.seen||(this.seen={}))[s])return!0;E[s]=!0}}var y={},b=e.valid,d})(n,"./get"),n(function($){var e=n("./root");e.chain.put=function(l,v,m){var N=this,T=N._,u=T.root;m=m||{},m.root=T.root,m.run||(m.run=u.once),a(m,T.id),m.ack=m.ack||v,m.via=m.via||N,m.data=m.data||l,m.soul||(m.soul=T.soul||typeof v=="string"&&v);var o=m.state=m.state||e.state();return typeof l=="function"?(l(function(c){m.data=c,N.put(b,b,m)}),N):m.soul?(m.$=u.$.get(m.soul),m.todo=[{it:m.data,ref:m.$}],m.turn=m.turn||s,m.ran=m.ran||r,function c(){var O=m.todo,A=O.pop(),D=A.it;A.ref&&A.ref._.id;var x,P,C,i,t;if(a(m,A.ref),(i=A.todo)&&(P=i.pop(),D=D[P],i.length&&O.push(A)),P&&(O.path||(O.path=[])).push(P),!(x=S(D))&&!(t=e.is(D))){if(!Object.plain(D)){r.err(m,"Invalid data: "+y(D)+" at "+(m.via.back(function(j){j.get&&i.push(j.get)},i=[])||i.join("."))+"."+(O.path||[]).join("."));return}for(var f=m.seen||(m.seen=[]),k=f.length;k--;)if(D===(i=f[k]).it){x=D=i.link;break}}if(P&&x)A.node=E(A.node,P,o,D);else{let j=function(w,I){var G=C.link["#"];I&&(I.off(),I.rid(w));var B=G||w.soul||(i=(w.$$||w.$)._||"").soul||i.link||((i=i.put||"")._||"")["#"]||i["#"]||((i=w.put||"")&&w.$$?i["#"]:(i["="]||i[":"]||"")["#"]);if(!G&&a(m,w.$),!B&&!A.link["#"]){(A.wait||(A.wait=[])).push(function(){j(w,I)});return}B||(B=[],(w.$$||w.$).back(function(H){if(i=H.soul||H.link)return B.push(i);B.push(H.get)}),B=B.reverse().join("/")),C.link["#"]=B,!t&&(((m.graph||(m.graph={}))[B]=C.node||(C.node={_:{}}))._["#"]=B),delete m.wait[R],C.wait&&setTimeout.each(C.wait,function(H){H&&H()}),m.ran(m)};if(!m.seen){r.err(m,"Data at root of graph must be a node (an object).");return}m.seen.push(C={it:D,link:{},todo:t?[]:Object.keys(D).sort().reverse(),path:(O.path||[]).slice(),up:A}),A.node=E(A.node,P,o,C.link),!t&&C.todo.length&&O.push(C);var R=m.seen.length;(m.wait||(m.wait={}))[R]="",i=(C.ref=t?D:P?A.ref.get(P):A.ref)._,(i=D&&(D._||"")["#"]||i.soul||i.link)?j({soul:i}):C.ref.get(j,{run:m.run,v2020:1,out:{get:{".":" "}}})}if(!O.length)return m.ran(m);m.turn(c)}(),N):(g(m),N)};function a(l,v){if(!!v){v=(v._||"").id||v;var m=l.root.stun||(l.root.stun={on:e.on}),N={},T;l.stun||(l.stun=m.on("stun",function(){})),(T=m.on(""+v))&&T.the.last.next(N),!(N.run>=l.run)&&m.on(""+v,function(u){if(l.stun.end){this.off(),this.to.next(u);return}u.run=u.run||l.run,u.stun=u.stun||l.stun})}}function r(l){if(l.err){r.end(l.stun,l.root);return}if(!(l.todo.length||l.end||!Object.empty(l.wait))){l.end=1;var v=l.$.back(-1)._,m=v.root,N=v.ask(function(c){m.on("ack",c),c.err&&e.log(c),++T>(l.acks||0)&&this.off(),l.ack&&l.ack(c,this)},l.opt),T=0,u=l.stun,o;(o=function(){!u||(r.end(u,m),setTimeout.each(Object.keys(u=u.add||""),function(c){(c=u[c])&&c()}))}).hatch=o,l.via._.on("out",{put:l.out=l.graph,opt:l.opt,"#":N,_:o})}}r.end=function(l,v){l.end=d,l.the.to===l&&l===l.the.last&&delete v.stun,l.off()},r.err=function(l,v){(l.ack||d).call(l,l.out={err:l.err=e.log(v)}),l.ran(l)};function g(l){var v=l.via._,m;l.via=l.via.back(function(N){if(N.soul||!N.get)return N.$;m=l.data,(l.data={})[N.get]=m}),(!l.via||!l.via._.soul)&&(l.via=v.root.$.get(((l.data||"")._||"")["#"]||v.$.back("opt.uuid")())),l.via.put(l.data,l.ack,l)}function y(l,v){return l&&(v=l.constructor)&&v.name||typeof l}var b,d=function(){},s=setTimeout.turn,S=e.valid,E=e.state.ify})(n,"./put"),n(function($){var e=n("./root");n("./chain"),n("./back"),n("./put"),n("./get"),$.exports=e})(n,"./index"),n(function($){var e=n("./index");e.chain.on=function(g,y,b,d){var s=this,S=s._;S.root;var E;if(typeof g=="string")return y?(E=S.on(g,y,b||S,d),b&&b.$&&(b.subs||(b.subs=[])).push(E),s):S.on(g);var l=y;return(l=l===!0?{change:!0}:l||{}).not=1,l.on=1,s.get(g,l),s},e.chain.once=function(g,y){if(y=y||{},!g)return a(this);var b=this,d=b._,s=d.root;d.put;var S=String.random(7),E;return b.get(function(l,v,m,N){var T=this,u=T._,o=u.one||(u.one={});if(N.stun||o[S]==="")return;if((E=e.valid(l))===!0){c();return}if(typeof E=="string")return;clearTimeout((d.one||"")[S]),clearTimeout(o[S]),o[S]=setTimeout(c,y.wait||99);function c(O){if(!u.has&&!u.soul&&(u={put:l,get:v}),r===(E=u.put)&&(E=((m.$$||"")._||"").put),typeof e.valid(E)=="string"&&(E=s.$.get(E)._.put,E===r&&!O)){o[S]=setTimeout(function(){c(1)},y.wait||99);return}N.stun||o[S]!==""&&(o[S]="",(d.soul||d.has)&&N.off(),g.call(T,E,u.get),clearTimeout(o[S]))}},{on:1}),b};function a(g,y,b){return e.log.once("valonce","Chainable val is experimental, its behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),(b=g.chain())._.nix=g.once(function(d,s){b._.on("in",this._)}),b._.lex=g._.lex,b}e.chain.off=function(){var g=this,y=g._,b,d=y.back;if(!!d)return y.ack=0,(b=d.next)&&b[y.get]&&delete b[y.get],(b=d.ask)&&delete b[y.get],(b=d.put)&&delete b[y.get],(b=y.soul)&&delete d.root.graph[b],(b=y.map)&&Object.keys(b).forEach(function(s,S){S=b[s],S.link&&d.root.$.get(S.link).off()}),(b=y.next)&&Object.keys(b).forEach(function(s,S){S=b[s],S.$.off()}),y.on("off",{}),g};var r})(n,"./on"),n(function($){var e=n("./index"),a=e.chain.get.next;e.chain.get.next=function(b,d){var s;return Object.plain(d)?(s=((s=d["#"])||"")["="]||s)?b.get(s):((s=b.chain()._).lex=d,b.on("in",function(S){String.match(S.get||(S.put||"")["."],d["."]||d["#"]||d)&&s.on("in",S),this.to.next(S)}),s.$):(a||g)(b,d)},e.chain.map=function(b,d,s){var S=this,E=S._,l,v;return Object.plain(b)&&(l=b["."]?b:{".":b},b=y),b?(e.log.once("mapfn","Map functions are experimental, their behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),v=S.chain(),S.map().on(function(m,N,T,u){var o=(b||g).call(this,m,N,T,u);if(y!==o){if(m===o)return v._.on("in",T);if(e.is(o))return v._.on("in",o._);var c={};Object.keys(T.put).forEach(function(O){c[O]=T.put[O]},c),c["="]=o,v._.on("in",{get:N,put:c})}}),v):((v=E.each)||((E.each=v=S.chain())._.lex=l||v._.lex||E.lex,v._.nix=S.back("nix"),S.on("in",r,v._)),v)};function r(b){this.to.next(b);var d=this.as,s=b.$,S=s._,E=b.put,l;!S.soul&&!b.$$||(l=d.lex)&&!String.match(b.get||(E||"")["."],l["."]||l["#"]||l)||e.on.link(b,d)}var g=function(){},y})(n,"./map"),n(function($){var e=n("./index");e.chain.set=function(a,r,g){var y=this,b=y.back(-1),d,s;return r=r||function(){},g=g||{},g.item=g.item||a,(d=((a||"")._||"")["#"])&&((a={})["#"]=d),typeof(s=e.valid(a))=="string"?y.get(d=s).put(a,r,g):e.is(a)?(y.put(function(S){a.get(function(E,l,v){if(!E)return r.call(y,{err:e.log('Only a node can be linked! Not "'+v.put+'"!')});(s={})[E]={"#":E},S(s)},!0)}),a):(Object.plain(a)&&(a=b.get(d=y.back("opt.uuid")()).put(a)),y.get(d||b.back("opt.uuid")(7)).put(a,r,g))}})(n,"./set"),n(function($){n("./shim");var e=function(){},a=JSON.parseAsync||function(b,d,s){var S,E=+new Date;try{d(S,JSON.parse(b,s),r.sucks(+new Date-E))}catch(l){d(l)}},r=JSON.stringifyAsync||function(b,d,s,S){var E,l=+new Date;try{d(E,JSON.stringify(b,s,S),r.sucks(+new Date-l))}catch(v){d(v)}};r.sucks=function(b){b>99&&(console.log("Warning: JSON blocking CPU detected. Add `gun/lib/yson.js` to fix."),r.sucks=e)};function g(b){var d=function(){},s=b.opt||{};s.log=s.log||console.log,s.gap=s.gap||s.wait||0,s.max=s.max||(s.memory?s.memory*999*999:3e8)*.3,s.pack=s.pack||s.max*.01*.01,s.puff=s.puff||9;var S=setTimeout.turn||setTimeout,E=b.dup,l=E.check,v=E.track,m=d.hear=function(o,c){if(!!o){if(s.max<=o.length)return d.say({dam:"!",err:"Message too big!"},c);d===this&&(m.d+=o.length||0,++m.c);var O=c.SH=+new Date,A=o[0],D;if(A==="["){a(o,function(x,P){if(x||!P)return d.say({dam:"!",err:"DAM JSON parse error."},c);console.STAT&&console.STAT(+new Date,P.length,"# on hear batch");var C=s.puff;(function i(){for(var t=+new Date,f=0,k;f<C&&(k=P[f++]);)d.hear(k,c);P=P.slice(f),console.STAT&&console.STAT(t,+new Date-t,"hear loop"),N(c),P.length&&S(i,0)})()}),o="";return}if(A==="{"||(o["#"]||Object.plain(o))&&(D=o)){if(D)return m.one(D,c,O);a(o,function(x,P){if(x||!P)return d.say({dam:"!",err:"DAM JSON parse error."},c);m.one(P,c,O)});return}}};m.one=function(o,c,i){var A,D,x,P,C;if(o.DBG&&(o.DBG=C={DBG:o.DBG}),C&&(C.h=i),C&&(C.hp=+new Date),(A=o["#"])||(A=o["#"]=String.random(9)),!(x=l(A))&&(D=o["##"],!(D&&(x=o["@"]||o.get&&A)&&E.check(P=x+D)))){if((o._=function(){}).via=d.leap=c,(x=o["><"])&&typeof x=="string"&&x.slice(0,99).split(",").forEach(function(t){this[t]=1},o._.yo={}),x=o.dam){(x=d.hear[x])&&x(o,c,b),v(A);return}var i=+new Date;C&&(C.is=i),c.SI=A,b.on("in",d.last=o),C&&(C.hd=+new Date),console.STAT&&console.STAT(i,+new Date-i,o.get?"msg get":o.put?"msg put":"msg"),(x=v(A)).via=c,o.get&&(x.it=o),P&&v(P),d.leap=d.last=null}},m.c=m.d=0,function(){var o=0,c;d.hash=function(D,x){var P,C,i,t=+new Date;r(D.put,function f(k,R){var j=(C||(C=i=R||"")).slice(0,32768);if(P=String.hash(j,P),C=C.slice(32768),C){S(f,0);return}console.STAT&&console.STAT(t,+new Date-t,"say json+hash"),D._.$put=i,D["##"]=P,d.say(D,x),delete D._.$put},O)};function O(D,x){var P;return x instanceof Object?(Object.keys(x).sort().forEach(A,{to:P={},on:x}),P):x}function A(D){this.to[D]=this.on[D]}d.say=function(D,x){var P;if((P=this)&&(P=P.to)&&P.next&&P.next(D),!D)return!1;var C,i,t=D["@"],f=D._||(D._=function(){}),k=D.DBG,R=+new Date;if(f.y=f.y||R,x||k&&(k.y=R),(C=D["#"])||(C=D["#"]=String.random(9)),!c&&v(C),D.put&&(D.err||(E.s[C]||"").err))return!1;if(!D["##"]&&y!==D.put&&!f.via&&t){d.hash(D,x);return}if(!x&&t&&(x=(P=E.s[t])&&(P.via||(P=P.it)&&(P=P._)&&P.via)||(P=d.last)&&t===P["#"]&&d.leap),!x&&t)return E.s[t]?void 0:(console.STAT&&console.STAT(+new Date,++o,"total no peer to ack to"),!1);if(!x&&d.way)return d.way(D);if(k&&(k.yh=+new Date),!(i=f.raw)){d.raw(D,x);return}if(k&&(k.yr=+new Date),!x||!x.id){if(!Object.plain(x||s.peers))return!1;var R=+new Date;s.puff;var j=s.peers,w=Object.keys(x||s.peers||{});console.STAT&&console.STAT(R,+new Date-R,"peer keys"),function B(){var H=+new Date;c=1;var U=f.raw;f.raw=i;for(var M=0,X;M<9&&(X=(w||"")[M++]);)!(X=j[X])||d.say(D,X);f.raw=U,c=0,w=w.slice(M),console.STAT&&console.STAT(H,+new Date-H,"say loop"),w.length&&(S(B,0),t&&v(t))}();return}if(!x.wire&&d.wire&&d.wire(x),C!==x.last){if(x.last=C,x===f.via||(P=f.yo)&&(P[x.url]||P[x.pid]||P[x.id]))return!1;if(console.STAT&&console.STAT(R,((k||f).yp=+new Date)-(f.y||R),"say prep"),!c&&t&&v(t),x.batch){if(x.tail=(P=x.tail||0)+i.length,x.tail<=s.pack){x.batch+=(P?",":"")+i;return}N(x)}x.batch="[";var I=+new Date;setTimeout(function(){console.STAT&&console.STAT(I,+new Date-I,"0ms TO"),N(x)},s.gap),T(i,x),console.STAT&&t===x.SI&&console.STAT(R,+new Date-x.SH,"say ack")}},d.say.c=d.say.d=0,d.raw=function(D,x){if(!D)return"";var P=D._||{},C,i;if(i=P.raw)return i;if(typeof D=="string")return D;var t=D["##"],f=D["@"];if(t&&f){if(!P.via&&l(f+t))return!1;if((i=(E.s[f]||"").it)||(i=d.last)&&f===i["#"]){if(t===i["##"])return!1;i["##"]||(i["##"]=t)}}if(!D.dam){var k=0,R=[];i=s.peers;for(var j in i){var w=i[j];if(R.push(w.url||w.pid||w.id),++k>6)break}k>1&&(D["><"]=R.join())}if(C=P.$put){i={},Object.keys(D).forEach(function(G){i[G]=D[G]}),i.put=":])([:",r(i,function(G,B){if(!G){var H=+new Date;i=B.indexOf('"put":":])([:"'),I(y,B=B.slice(0,i+6)+C+B.slice(i+14)),console.STAT&&console.STAT(H,+new Date-H,"say slice")}});return}r(D,I);function I(G,B){G||(P.raw=B,d.say(D,x))}}}();function N(o){var c=o.batch,O=typeof c=="string";if(O&&(c+="]"),o.batch=o.tail=null,!!c&&!(O?3>c.length:!c.length)){if(!O)try{c=c.length===1?c[0]:JSON.stringify(c)}catch(A){return s.log("DAM JSON stringify error",A)}!c||T(c,o)}}function T(o,c){try{var O=c.wire;c.say?c.say(o):O.send&&O.send(o),d.say.d+=o.length||0,++d.say.c}catch{(c.queue=c.queue||[]).push(o)}}d.hi=function(o){var c=o.wire,O;if(!c){d.wire(o.length&&{url:o}||o);return}o.id?s.peers[o.url||o.id]=o:(O=o.id=o.id||String.random(9),d.say({dam:"?",pid:b.opt.pid},s.peers[O]=o),delete E.s[o.last]),o.met=o.met||+new Date,c.hied||b.on(c.hied="hi",o),O=o.queue,o.queue=[],setTimeout.each(O||[],function(A){T(A,o)},0,9)},d.bye=function(o){b.on("bye",o);var c=+new Date;c=c-(o.met||c),d.bye.time=((d.bye.time||c)+c)/2},d.hear["!"]=function(o,c){s.log("Error:",o.err)},d.hear["?"]=function(o,c){o.pid&&(c.pid||(c.pid=o.pid),o["@"])||(d.say({dam:"?",pid:s.pid,"@":o["#"]},c),delete E.s[c.last])},b.on("create",function(o){o.opt.pid=o.opt.pid||String.random(9),this.to.next(o),o.on("out",d.say)}),b.on("bye",function(o,c){o=s.peers[o.id||o]||o,this.to.next(o),o.bye?o.bye():(c=o.wire)&&c.close&&c.close(),delete s.peers[o.id],o.wire=null});var u={};return b.on("bye",function(o,c){this.to.next(o),(c=console.STAT)&&(c.peers=(c.peers||0)-1),(c=o.url)&&(u[c]=!0,setTimeout(function(){delete u[c]},s.lack||9e3))}),b.on("hi",function(o,c){this.to.next(o),(c=console.STAT)&&(c.peers=(c.peers||0)+1),!(!(c=o.url)||!u[c])&&(delete u[c],!s.super&&setTimeout.each(Object.keys(b.next),function(O){b.next[O],c={},c[O]=b.graph[O],c=String.hash(c),d.say({"##":c,get:{"#":O}},o)}))}),d}var y;try{$.exports=g}catch{}})(n,"./mesh"),n(function($){var e=n("../index");e.Mesh=n("./mesh"),e.on("opt",function(r){if(this.to.next(r),r.once)return;var g=r.opt;if(g.WebSocket===!1)return;var y=e.window||{},b=g.WebSocket||y.WebSocket||y.webkitWebSocket||y.mozWebSocket;if(!b)return;g.WebSocket=b;var d=g.mesh=g.mesh||e.Mesh(r);d.wire||g.wire,d.wire=g.wire=s;function s(v){try{if(!v||!v.url)return N&&N(v);var m=v.url.replace(/^http/,"ws"),N=v.wire=new g.WebSocket(m);return N.onclose=function(){g.mesh.bye(v),E(v)},N.onerror=function(T){E(v)},N.onopen=function(){g.mesh.hi(v)},N.onmessage=function(T){!T||g.mesh.hear(T.data||T,v)},N}catch{}}setTimeout(function(){!g.super&&r.on("out",{dam:"hi"})},1);var S=2*999;function E(v){clearTimeout(v.defer),g.peers[v.url]&&(l&&v.retry<=0||(v.retry=(v.retry||g.retry+1||60)-(-v.tried+(v.tried=+new Date)<S*4?1:0),v.defer=setTimeout(function m(){if(l&&l.hidden)return setTimeout(m,S);s(v)},S)))}var l=""+a!=typeof document&&document});var a})(n,"./websocket"),n(function($){if(!(typeof Gun>"u")){var e=function(){},a;try{a=(Gun.window||e).localStorage}catch{}a||(Gun.log("Warning: No localStorage exists to persist data to!"),a={setItem:function(g,y){this[g]=y},removeItem:function(g){delete this[g]},getItem:function(g){return this[g]}});var r=JSON.stringifyAsync||function(g,y,b,d){var s;try{y(s,JSON.stringify(g,b,d))}catch(S){y(S)}};Gun.on("create",function g(y){this.to.next(y);var b=y.opt;y.graph;var d=[],s,S,E,l;if(b.localStorage===!1)return;b.prefix=b.file||"gun/";try{s=g[b.prefix]=g[b.prefix]||JSON.parse(E=a.getItem(b.prefix))||{}}catch{s=g[b.prefix]={}}E=(E||"").length,y.on("get",function(m){this.to.next(m);var N=m.get,T,u,o,c;!N||!(T=N["#"])||(u=s[T]||c,u&&(o=N["."])&&!Object.plain(o)&&(u=Gun.state.ify({},o,Gun.state.is(u,o),u[o],T)),Gun.on.get.ack(m,u))}),y.on("put",function(m){this.to.next(m);var N=m.put,T=N["#"],u=N["."],o=m["#"];if(s[T]=Gun.state.ify(s[T],u,N[">"],N[":"],T),l&&E>4999880){y.on("in",{"@":o,err:"localStorage max!"});return}m["@"]||d.push(o),!S&&(S=setTimeout(v,9+E/333))});function v(){if(!d.length&&((setTimeout.turn||"").s||"").length){setTimeout(v,99);return}var m=d;clearTimeout(S),S=!1,d=[],r(s,function(N,T){try{!N&&a.setItem(b.prefix,T)}catch(u){N=l=u||"localStorage failure"}N&&(Gun.log(N+" Consider using GUN's IndexedDB plugin for RAD for more storage space, https://gun.eco/docs/RAD#install"),y.on("localStorage:error",{err:N,get:b.prefix,put:s})),E=T.length,!(!N&&!Object.empty(b.peers))&&setTimeout.each(m,function(u){y.on("in",{"@":u,err:N,ok:0})},0,99)})}})}})(n,"./localStorage")}(),function(){var C;if(""+C!=typeof Gun){var n=function(i){console.warn("Warning! Deprecated internal utility will break in next version:",i)},p=Gun;p.fn=p.fn||{is:function(i){return n("fn"),!!i&&typeof i=="function"}},p.bi=p.bi||{is:function(i){return n("bi"),i instanceof Boolean||typeof i=="boolean"}},p.num=p.num||{is:function(i){return n("num"),!$(i)&&(i-parseFloat(i)+1>=0||i===1/0||i===-1/0)}},p.text=p.text||{is:function(i){return n("text"),typeof i=="string"}},p.text.ify=p.text.ify||function(i){return n("text.ify"),p.text.is(i)?i:typeof JSON<"u"?JSON.stringify(i):i&&i.toString?i.toString():i},p.text.random=p.text.random||function(i,t){n("text.random");var f="";for(i=i||24,t=t||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";i>0;)f+=t.charAt(Math.floor(Math.random()*t.length)),i--;return f},p.text.match=p.text.match||function(i,t){var f,k;return n("text.match"),typeof i!="string"?!1:(typeof t=="string"&&(t={"=":t}),t=t||{},f=t["="]||t["*"]||t[">"]||t["<"],i===f?!0:k!==t["="]?!1:(f=t["*"]||t[">"]||t["<"],i.slice(0,(f||"").length)===f?!0:k!==t["*"]?!1:k!==t[">"]&&k!==t["<"]?i>=t[">"]&&i<=t["<"]:k!==t[">"]&&i>=t[">"]||k!==t["<"]&&i<=t["<"]))},p.text.hash=p.text.hash||function(i,t){if(n("text.hash"),typeof i=="string"){if(t=t||0,!i.length)return t;for(var f=0,k=i.length,R;f<k;++f)R=i.charCodeAt(f),t=(t<<5)-t+R,t|=0;return t}},p.list=p.list||{is:function(i){return n("list"),i instanceof Array}},p.list.slit=p.list.slit||Array.prototype.slice,p.list.sort=p.list.sort||function(i){return n("list.sort"),function(t,f){return!t||!f?0:(t=t[i],f=f[i],t<f?-1:t>f?1:0)}},p.list.map=p.list.map||function(i,t,f){return n("list.map"),x(i,t,f)},p.list.index=1,p.obj=p.boj||{is:function(i){return n("obj"),i?i instanceof Object&&i.constructor===Object||Object.prototype.toString.call(i).match(/^\[object (\w+)\]$/)[1]==="Object":!1}},p.obj.put=p.obj.put||function(i,t,f){return n("obj.put"),(i||{})[t]=f,i},p.obj.has=p.obj.has||function(i,t){return n("obj.has"),i&&Object.prototype.hasOwnProperty.call(i,t)},p.obj.del=p.obj.del||function(i,t){if(n("obj.del"),!!i)return i[t]=null,delete i[t],i},p.obj.as=p.obj.as||function(i,t,f,k){return n("obj.as"),i[t]=i[t]||(k===f?{}:f)},p.obj.ify=p.obj.ify||function(i){if(n("obj.ify"),o(i))return i;try{i=JSON.parse(i)}catch{i={}}return i},function(){var i;function t(f,k){O(this,k)&&i!==this[k]||(this[k]=f)}p.obj.to=p.obj.to||function(f,k){return n("obj.to"),k=k||{},x(f,t,k),k}}(),p.obj.copy=p.obj.copy||function(i){return n("obj.copy"),i&&JSON.parse(JSON.stringify(i))},function(){function i(t,f){var k=this.n,R;if(!(k&&(f===k||o(k)&&O(k,f)))&&R!==f)return!0}p.obj.empty=p.obj.empty||function(t,f){return n("obj.empty"),t?!x(t,i,{n:f}):!0}}(),function(){function i(k,R){if(arguments.length===2){i.r=i.r||{},i.r[k]=R;return}i.r=i.r||[],i.r.push(k)}var t=Object.keys,f;Object.keys=Object.keys||function(k){return f(k,function(R,j,w){w(j)})},p.obj.map=f=p.obj.map||function(k,R,j){n("obj.map");var w,I=0,G,B,H,U,M=typeof R=="function";if(i.r=w,t&&o(k)&&(H=t(k),U=!0),j=j||{},$(k)||H)for(G=(H||k).length;I<G;I++){var X=I+p.list.index;if(M){if(B=U?R.call(j,k[H[I]],H[I],i):R.call(j,k[I],X,i),B!==w)return B}else if(R===k[U?H[I]:I])return H?H[I]:X}else for(I in k)if(M){if(O(k,I)&&(B=j?R.call(j,k[I],I,i):R(k[I],I,i),B!==w))return B}else if(R===k[I])return I;return M?i.r:p.list.index?0:-1}}(),p.time=p.time||{},p.time.is=p.time.is||function(i){return n("time"),i?i instanceof Date:+new Date().getTime()};var T=p.fn.is,$=p.list.is,u=p.obj,o=u.is,O=u.has,x=u.map,e={};e.is=function(i){return n("val.is"),i===C?!1:i===null?!0:i===1/0?!1:g(i)||r(i)||l(i)?!0:e.link.is(i)||!1},e.link=e.rel={_:"#"},function(){e.link.is=function(t){if(n("val.link.is"),t&&t[a]&&!t._&&o(t)){var f={};if(x(t,i,f),f.id)return f.id}return!1};function i(t,f){var k=this;if(k.id)return k.id=!1;if(f==a&&g(t))k.id=t;else return k.id=!1}}(),e.link.ify=function(i){return n("val.link.ify"),D({},a,i)},p.obj.has._=".";var a=e.link._,C,r=p.bi.is,l=p.num.is,g=p.text.is,u=p.obj,o=u.is,D=u.put,x=u.map;p.val=p.val||e;var y={_:"_"};y.soul=function(i,t){return n("node.soul"),i&&i._&&i._[t||s]},y.soul.ify=function(i,t){return n("node.soul.ify"),t=typeof t=="string"?{soul:t}:t||{},i=i||{},i._=i._||{},i._[s]=t.soul||i._[s]||d(),i},y.soul._=e.link._,function(){y.is=function(t,f,k){n("node.is");var R;return o(t)&&(R=y.soul(t))?!x(t,i,{as:k,cb:f,s:R,n:t}):!1};function i(t,f){if(f!==y._){if(!e.is(t))return!0;this.cb&&this.cb.call(this.as,t,f,this.n,this.s)}}}(),function(){y.ify=function(t,f,k){return n("node.ify"),f?typeof f=="string"?f={soul:f}:typeof f=="function"&&(f={map:f}):f={},f.map&&(f.node=f.map.call(k,t,C,f.node||{})),(f.node=y.soul.ify(f.node||{},f))&&x(t,i,{o:f,as:k}),f.node};function i(t,f){var k=this.o,R,j;if(k.map){R=k.map.call(this.as,t,""+f,k.node),j===R?c(k.node,f):k.node&&(k.node[f]=R);return}e.is(t)&&(k.node[f]=t)}}();var u=p.obj,o=u.is,c=u.del,x=u.map,b=p.text,d=b.random,s=y.soul._,C;p.node=p.node||y;var S=p.state;S.lex=function(){return n("state.lex"),S().toString(36).replace(".","")},S.to=function(i,t,f){n("state.to");var k=(i||{})[t];return o(k)&&(k=P(k)),S.ify(f,t,S.is(i,t),k,y.soul(i))},function(){S.map=function(t,f,k){n("state.map");var R,j=o(j=t||f)?j:null;return t=T(t=t||f)?t:null,j&&!t?(f=l(f)?f:S(),j[m]=j[m]||{},x(j,i,{o:j,s:f}),j):(k=k||o(f)?f:R,f=l(f)?f:S(),function(w,I,G,B){if(!t)return i.call({o:G,s:f},w,I),w;t.call(k||this||{},w,I,G,B),!(O(G,I)&&R===G[I])&&i.call({o:G,s:f},w,I)})};function i(t,f){m!==f&&S.ify(this.o,f,this.s)}}();var u=p.obj;u.as;var O=u.has,o=u.is,x=u.map,P=u.copy,E=p.num,l=E.is,v=p.fn,T=v.is,m=y._,C,N={};(function(){N.is=function(f,k,R,j){return n("graph.is"),!f||!o(f)||A(f)?!1:!x(f,i,{cb:k,fn:R,as:j})};function i(f,k){if(!f||k!==y.soul(f)||!y.is(f,this.fn,this.as))return!0;!this.cb||(t.n=f,t.as=this.as,this.cb.call(t.as,f,k,t))}function t(f){f&&y.is(t.n,f,t.as)}})(),function(){N.ify=function(j,w,I){n("graph.ify");var G={path:[],obj:j};return w?typeof w=="string"?w={soul:w}:typeof w=="function"&&(w.map=w):w={},typeof I=="string"&&(w.soul=w.soul||I,I=C),w.soul&&(G.link=e.link.ify(w.soul)),w.shell=(I||{}).shell,w.graph=w.graph||{},w.seen=w.seen||[],w.as=w.as||I,i(w,G),w.root=G.node,w.graph};function i(j,w){var I;return(I=R(j,w))?I:(w.env=j,w.soul=f,y.ify(w.obj,t,w)&&(w.link=w.link||e.link.ify(y.soul(w.node)),w.obj!==j.shell&&(j.graph[e.link.is(w.link)]=w.node)),w)}function t(j,w,I){var G=this,B=G.env,H,U;if(y._===w&&O(j,e.link._))return I._;if(!!(H=k(j,w,I,G,B))){if(w||(G.node=G.node||I||{},O(j,y._)&&y.soul(j)&&(G.node._=P(j._)),G.node=y.soul.ify(G.node,e.link.is(G.link)),G.link=G.link||e.link.ify(y.soul(G.node))),(U=B.map)&&(U.call(B.as||{},j,w,I,G),O(I,w))){if(j=I[w],C===j){c(I,w);return}if(!(H=k(j,w,I,G,B)))return}if(!w)return G.node;if(H===!0)return j;if(U=i(B,{obj:j,path:G.path.concat(w)}),!!U.node)return U.link}}function f(j){var w=this,I=e.link.is(w.link),G=w.env.graph;w.link=w.link||e.link.ify(j),w.link[e.link._]=j,w.node&&w.node[y._]&&(w.node[y._][e.link._]=j),O(G,I)&&(G[j]=G[I],c(G,I))}function k(j,w,I,G,B){var H;if(e.is(j))return!0;if(o(j))return 1;if(H=B.invalid)return j=H.call(B.as||{},j,w,I),k(j,w,I,G,B);B.err="Invalid value at '"+G.path.concat(w).join(".")+"'!",p.list.is(j)&&(B.err+=" Use `.set(item)` instead of an Array.")}function R(j,w){for(var I=j.seen,G=I.length,B;G--;)if(B=I[G],w.obj===B.obj)return B;I.push(w)}}(),N.node=function(i){n("graph.node");var t=y.soul(i);if(!!t)return D({},t,i)},function(){N.to=function(t,f,k){if(n("graph.to"),!!t){var R={};return k=k||{seen:{}},x(t[f],i,{obj:R,graph:t,opt:k}),R}};function i(t,f){var k,R;if(y._===f){if(A(t,e.link._))return;this.obj[f]=P(t);return}if(!(k=e.link.is(t))){this.obj[f]=t;return}if(R=this.opt.seen[k]){this.obj[f]=R;return}this.obj[f]=this.opt.seen[k]=N.to(this.graph,k,this.opt)}}();var T=p.fn.is,u=p.obj,o=u.is,c=u.del,O=u.has,A=u.empty,D=u.put,x=u.map,P=u.copy,C;p.graph=p.graph||N}}()}});q();Y();var pt=gn();const yn="_App_sggzw_1",mn="_TestnetBankContainer_sggzw_51",jt={App:yn,TestnetBankContainer:mn},Dt=F('<input type="text">'),vn=F('<table><tbody><tr><td><a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">https://github.com/fc1943s/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">https://fc1943s.github.io/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">https://fc1943s.github.io/tictactoe_spiral/docs</a></td></tr></tbody></table>'),kn=F("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),Sn=F("<table><tbody></tbody></table>"),Tn=F("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),An=F("<div><button>Load</button></div>"),$n=F("<div><button></button></div>"),wn=F('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),xn=F("<table><tbody><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),Nt=F("<div><button>Request</button><button>Clear</button><pre></pre></div>"),On=F("<div><table><tbody><tr><td>Links</td><td></td></tr><tr><td></td></tr><tr><td>Chain Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr><tr><td></td></tr><tr><td>Database Connection</td><td></td></tr><tr><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Deploy</td><td></td></tr></tbody></table></div>"),En=pt.__esModule?pt.default:pt,tt={npm_package_scripts_outdated_pre:"ncu --pre 1 -t greatest",DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_package_devDependencies__esbuild_plugins_node_globals_polyfill:"^0.1",npm_config_user_agent:"pnpm/6.33.0 npm/? node/v16.15.1 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_a8a615e1-068c-459c-9bea-1400de681ab8",PIPX_HOME:"/opt/pipx",npm_package_devDependencies_vite:"^3.0.0-beta.6",npm_node_execpath:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"",npm_package_scripts_playwright_install:"playwright install --with-deps && playwright install msedge",npm_package_scripts_serve:"vite preview",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",npm_package_dependencies_rusty_gun:"^0.1.2",npm_package_devDependencies_typescript:"^4.7",NVM_DIR:"/home/runner/.nvm",npm_package_devDependencies_playwright_core:"^1.22",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220626.1",npm_package_scripts_dev:"vite",npm_package_devDependencies__playwright_test:"^1.22",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",npm_package_dependencies_solid_js:"^1.4",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22253",GITHUB_WORKFLOW:"E2E + A11y Tests",_:"/home/runner/setup-pnpm/node_modules/.bin/pnpm",npm_package_dependencies_storeon:"^3.1",npm_config_registry:"https://registry.npmjs.org/",GITHUB_RUN_ID:"2645896251",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",npm_package_dependencies_algosdk:"^1.18",npm_package_devDependencies_path_browserify:"^1.0",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"",ImageOS:"ubuntu20",npm_package_scripts_start:"vite",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"",npm_config_node_gyp:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node_modules/node-gyp/bin/node-gyp.js",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/dist/node-gyp-bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.15.1/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_f28ee565-2cb8-4472-8aaf-6b9b0a323fd0",INVOCATION_ID:"fc7183d4e8574fa6b5a8d915dc17eed4",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",npm_package_name:"tictactoe_spiral_web",npm_package_scripts_extension:"vite build --outDir dist_extension && mkdir ./dist_extension/tictactoe_spiral && mv ./dist_extension/assets/content_script.*.js ./dist_extension/assets/content_script.js && mv ./dist_extension/assets/App.*.css ./dist_extension/assets/App.css && mv ./dist_extension/assets ./dist_extension/tictactoe_spiral/assets && cp background.js content_script.js ./dist_extension",NODE:"/opt/hostedtoolcache/node/16.15.1/x64/bin/node",GITHUB_ACTION:"__run_3",GITHUB_RUN_NUMBER:"16",RUNNER_ARCH:"X64",XDG_RUNTIME_DIR:"/run/user/1001",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",npm_package_dependencies_solid_icons:"^0.5",npm_package_devDependencies_axe_playwright:"^1.1",npm_package_devDependencies_vite_plugin_solid:"^2.2",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",npm_package_scripts_e2e:"playwright test",npm_lifecycle_script:"vite build --outDir dist",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",STATS_PFS:"true",NODE_PATH:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules:/home/runner/setup-pnpm/node_modules/.pnpm/node_modules:/home/runner/setup-pnpm/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/bin/node_modules:/home/runner/setup-pnpm/node_modules/pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",npm_package_version:"0.0.1",npm_package_devDependencies_npm_check_updates:"^15.0",npm_lifecycle_event:"build",GITHUB_REF_PROTECTED:"false",npm_package_scripts_build:"vite build --outDir dist",npm_package_dependencies_buffer:"^6.0",npm_config_argv:'{"remain":["run","build"],"cooked":["run","build"],"original":["run","build"]}',GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"0bf860082c7f4912fb20ba2a24c9ac99fbb355a4",GITHUB_RUN_ATTEMPT:"1",npm_package_dependencies__storeon_solidjs:"^3.0",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_a8a615e1-068c-459c-9bea-1400de681ab8",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",npm_package_devDependencies_esbuild_plugin_wasm:"^1.0.0",npm_execpath:"/home/runner/setup-pnpm/node_modules/.pnpm/pnpm@6.33.0/node_modules/pnpm/bin/pnpm.cjs",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",npm_package_devDependencies_esbuild:"^0.14",PNPM_SCRIPT_SRC_DIR:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",npm_package_dependencies_gun:"^0.2020.1237",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_a8a615e1-068c-459c-9bea-1400de681ab8",INIT_CWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",NODE_ENV:"production"}.CODESPACE_NAME,jn={token:un,chainUrl:tt?`http://${tt}-4001.githubpreview.dev`:sn,chainPort:tt?80:ln,dbUrl:tt?`ws://${tt}-8765.githubpreview.dev`:"ws://localhost",dbPort:tt?80:8765,accounts:fn,status:[],deploy:[]},Rt=h=>(..._)=>{console.log("@@@ %c%s %c%s","font-weight: bold; color: #888",JSON.stringify(_),"font-weight: bold; color: #444",JSON.stringify(h()))},Dn=Bt([h=>{h.on("@init",()=>jn),h.on("set",(_,n)=>n)}]);function rt({key:h}){const[_,n]=ot();return(()=>{const p=Dt.cloneNode(!0);return p.$$input=$=>n("set",{[h]:$.currentTarget.value}),V(()=>p.value=_[h]),p})()}function Nn(){return vn.cloneNode(!0)}function Rn(){return(()=>{const h=kn.cloneNode(!0),_=h.firstChild,n=_.firstChild,p=n.firstChild,$=p.nextSibling,e=n.nextSibling,a=e.firstChild,r=a.nextSibling,g=e.nextSibling,y=g.firstChild,b=y.nextSibling;return L($,J(rt,{key:"token"})),L(r,J(rt,{key:"chainUrl"})),L(b,J(rt,{key:"chainPort"})),h})()}function At({key:h,account:_}){const[n,p]=ot();return(()=>{const $=Dt.cloneNode(!0);return $.$$input=e=>p("set",{accounts:n.accounts.map(a=>a.alias===_.alias?{...a,[h]:e.currentTarget.value}:a)}),V(()=>$.value=_[h]),$})()}function Pn(){const[h]=ot();return(()=>{const _=Sn.cloneNode(!0),n=_.firstChild;return L(n,J(Ut,{get each(){return h.accounts},children:p=>(()=>{const $=Tn.cloneNode(!0),e=$.firstChild,a=e.nextSibling,r=a.firstChild,g=r.firstChild,y=g.firstChild,b=y.firstChild,d=b.nextSibling,s=y.nextSibling,S=s.firstChild,E=S.nextSibling;return L(e,()=>p.alias),L(d,J(At,{account:p,key:"address"})),L(E,J(At,{account:p,key:"privateKey"})),$})()})),_})()}function In(){const[h,_]=it(!1),[n,p]=it(!1);return $t(wt(()=>[n()],()=>n()&&p(!1))),lt((()=>{const $=lt(()=>!h(),!0);return()=>$()?(()=>{const e=An.cloneNode(!0),a=e.firstChild;return a.$$click=()=>_(!0),e})():(()=>{const e=$n.cloneNode(!0),a=e.firstChild;return a.$$click=()=>p(!0),L(a,J(bn,{size:"24px"})),L(e,(()=>{const r=lt(()=>!n(),!0);return()=>r()&&wn.cloneNode(!0)})(),null),V(()=>e.className=jt.TestnetBankContainer),e})()})())}function Gn(){return(()=>{const h=xn.cloneNode(!0),_=h.firstChild,n=_.firstChild,p=n.firstChild,$=p.nextSibling,e=n.nextSibling,a=e.firstChild,r=a.nextSibling;return L($,J(rt,{key:"dbUrl"})),L(r,J(rt,{key:"dbPort"})),h})()}function Cn(){const[h,_]=ot(),[n,p]=it(null),[$,e]=it(null),[a,r]=it(-1),y=Rt(()=>({status:Object.entries(h.status),gunRs:n(),gunJs:$(),subscriptionRs:a()}));y("App.Status()"),$t(wt(()=>[],()=>{y("App.Status.createEffect() callback");const s=new Lt(`${h.dbUrl}:${h.dbPort}/gun`);p(s);const S=new En(`${h.dbUrl}:${h.dbPort}/gun`);e(S);const E=l=>{let v=l;for(;typeof v=="string";)v=JSON.parse(v);return Array.isArray(v)?v:[v]};setTimeout(()=>{y("App.Status.createEffect() callback .setTimeout() callback"),r(s.get("app").get("status").on((l,v)=>{const m=E(l);y("App.Status.createEffect() callback _gunRs.on() callback",{k:v,v:l,status:m}),_("set",{status:m})})),S.get("app").get("status").on((l,v)=>{const m=E(l);y("App.Status.createEffect() callback _gunJs.on() callback",{k:v,v:l,status:m}),_("set",{status:m})})},1e3)})),Mt(()=>{y("App.Status.onCleanup() callback");const s=n();s&&s.get("app").get("status").off(a());const S=$();S&&S.get("app").get("status").off()});const b=async()=>{y("App.Status.request()");const s=Et(h.token,h.chainUrl,h.chainPort),S=n(),E=$();let l;try{const v=await s.status().do();l=[...h.status,v]}catch(v){l=[...h.status,v]}_("set",{status:l}),S&&S.get("app").get("status").put(l),E&&E.get("app").get("status").put(l)},d=async()=>{y("App.Status.clear()"),_("set",{status:[]});const s=n(),S=$();s&&s.get("app").get("status").put([]),S&&S.get("app").get("status").put([])};return(()=>{const s=Nt.cloneNode(!0),S=s.firstChild,E=S.nextSibling,l=E.nextSibling;return S.$$click=b,E.$$click=d,L(l,()=>JSON.stringify(h.status,null,2)),s})()}function Bn(){const[h,_]=ot(),p=Rt(()=>({status:Object.entries(h.status)}));p("App.Deploy()");const $=async()=>{const a=h.accounts[0]?.address,r=h.accounts[0]?.privateKey;if(p("App.Deploy.request()"),a&&r){const g=Et(h.token,h.chainUrl,h.chainPort);try{const y=await rn(g,a,r,on,an,{numGlobalByteSlices:cn,numGlobalInts:pn});_("set",{deploy:[...h.deploy,y]})}catch(y){_("set",{deploy:[...h.deploy,y]})}}else alert("Invalid admin account")},e=async()=>{p("App.Deploy.clear()"),_("set",{deploy:[]})};return(()=>{const a=Nt.cloneNode(!0),r=a.firstChild,g=r.nextSibling,y=g.nextSibling;return r.$$click=$,g.$$click=e,L(y,()=>JSON.stringify(h.deploy,null,2)),a})()}function Jn(){return J(Ht,{store:Dn,get children(){const h=On.cloneNode(!0),_=h.firstChild,n=_.firstChild,p=n.firstChild,$=p.firstChild,e=$.nextSibling,a=p.nextSibling,r=a.nextSibling,g=r.firstChild,y=g.nextSibling,b=r.nextSibling,d=b.firstChild,s=d.nextSibling,S=b.nextSibling,E=S.firstChild,l=E.nextSibling,v=S.nextSibling,m=v.nextSibling,N=m.firstChild,T=N.nextSibling,u=m.nextSibling,o=u.nextSibling,c=o.firstChild,O=c.nextSibling,A=o.nextSibling,D=A.firstChild,x=D.nextSibling;return L(e,J(Nn,{})),L(y,J(Rn,{})),L(s,J(Pn,{})),L(l,J(In,{})),L(T,J(Gn,{})),L(O,J(Cn,{})),L(x,J(Bn,{})),V(()=>h.className=jt.App),h}})}xt(["input","click"]);export{Jn as A,Ln as r};
