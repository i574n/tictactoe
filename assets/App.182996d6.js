import{i as Z,a as tt,k as Ht,s as z,l as V,m as Lt,f as Ut,h as Mt,n as Jt,j as J,S as Ft,u as q,F as Xt,o as dt,q as jt,r as Nt,t as Rt}from"./solid.5c468d33.js";import{a as st}from"./algosdk.97bf8f01.js";import{N as Kt}from"./gun.cd840e95.js";Z();tt();var Vt=["allowfullscreen","async","autofocus","autoplay","checked","controls","default","disabled","formnovalidate","hidden","indeterminate","ismap","loop","multiple","muted","nomodule","novalidate","open","playsinline","readonly","required","reversed","seamless","selected"],Wt=new Set(["className","value","readOnly","formNoValidate","isMap","noModule","playsInline",...Vt]),zt=new Set(["innerHTML","textContent","innerText","children"]),qt={className:"class",htmlFor:"for"},St={class:"className",formnovalidate:"formNoValidate",ismap:"isMap",nomodule:"noModule",playsinline:"playsInline",readonly:"readOnly"},Yt=new Set(["beforeinput","click","dblclick","contextmenu","focusin","focusout","input","keydown","keyup","mousedown","mousemove","mouseout","mouseover","mouseup","pointerdown","pointermove","pointerout","pointerover","pointerup","touchend","touchmove","touchstart"]),Qt={xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace"};function ft(p,_){return Lt(p,void 0,_?void 0:{equals:_})}function Zt(p,_,t){let l=t.length,$=_.length,e=l,a=0,i=0,g=_[$-1].nextSibling,S=null;for(;a<$||i<e;){if(_[a]===t[i]){a++,i++;continue}for(;_[$-1]===t[e-1];)$--,e--;if($===a){const b=e<l?i?t[i-1].nextSibling:t[e-i]:g;for(;i<e;)p.insertBefore(t[i++],b)}else if(e===i)for(;a<$;)(!S||!S.has(_[a]))&&_[a].remove(),a++;else if(_[a]===t[e-1]&&t[i]===_[$-1]){const b=_[--$].nextSibling;p.insertBefore(t[i++],_[a++].nextSibling),p.insertBefore(t[--e],b),_[$]=t[e]}else{if(!S){S=new Map;let s=i;for(;s<e;)S.set(t[s],s++)}const b=S.get(_[a]);if(b!=null)if(i<b&&b<e){let s=a,d=1,w;for(;++s<$&&s<e&&!((w=S.get(_[s]))==null||w!==b+d);)d++;if(d>b-i){const R=_[a];for(;i<b;)p.insertBefore(t[i++],R)}else p.replaceChild(t[i++],_[a++])}else a++;else _[a++].remove()}}}var Tt="_$DX_DELEGATE";function Kn(p,_,t){let l;return Ht($=>{l=$,_===document?p():U(_,p(),_.firstChild?null:void 0,t)}),()=>{l(),_.textContent=""}}function X(p,_,t){const l=document.createElement("template");l.innerHTML=p;let $=l.content.firstChild;return t&&($=$.firstChild),$}function Dt(p,_=window.document){const t=_[Tt]||(_[Tt]=new Set);for(let l=0,$=p.length;l<$;l++){const e=p[l];t.has(e)||(t.add(e),_.addEventListener(e,an))}}function ct(p,_,t){t==null?p.removeAttribute(_):p.setAttribute(_,t)}function tn(p,_,t,l){l==null?p.removeAttributeNS(_,t):p.setAttributeNS(_,t,l)}function nn(p,_){_==null?p.removeAttribute("class"):p.className=_}function Q(p,_,t,l){l?Array.isArray(t)?(p[`$$${_}`]=t[0],p[`$$${_}Data`]=t[1]):p[`$$${_}`]=t:Array.isArray(t)?p.addEventListener(_,$=>t[0](t[1],$)):p.addEventListener(_,t)}function en(p,_,t={}){const l=Object.keys(_||{}),$=Object.keys(t);let e,a;for(e=0,a=$.length;e<a;e++){const i=$[e];!i||i==="undefined"||_[i]||(At(p,i,!1),delete t[i])}for(e=0,a=l.length;e<a;e++){const i=l[e],g=!!_[i];!i||i==="undefined"||t[i]===g||!g||(At(p,i,!0),t[i]=g)}return t}function It(p,_,t={}){const l=p.style,$=typeof t=="string";if(_==null&&$||typeof _=="string")return l.cssText=_;$&&(l.cssText=void 0,t={}),_||(_={});let e,a;for(a in t)_[a]==null&&l.removeProperty(a),delete t[a];for(a in _)e=_[a],e!==t[a]&&(l.setProperty(a,e),t[a]=e);return t}function $t(p,_,t,l){typeof _=="function"?V($=>wt(p,_(),$,t,l)):wt(p,_,void 0,t,l)}function U(p,_,t,l){if(t!==void 0&&!l&&(l=[]),typeof _!="function")return rt(p,_,l,t);V($=>rt(p,_(),$,t),l)}function rn(p,_,t,l,$={},e=!1){_||(_={});for(const a in $)if(!(a in _)){if(a==="children")continue;kt(p,a,null,$[a],t,e)}for(const a in _){if(a==="children"){l||rt(p,_.children);continue}const i=_[a];$[a]=kt(p,a,i,$[a],t,e)}}function on(p){return p.toLowerCase().replace(/-([a-z])/g,(_,t)=>t.toUpperCase())}function At(p,_,t){const l=_.trim().split(/\s+/);for(let $=0,e=l.length;$<e;$++)p.classList.toggle(l[$],t)}function kt(p,_,t,l,$,e){let a,i,g;if(_==="style")return It(p,t,l);if(_==="classList")return en(p,t,l);if(t===l)return l;if(_==="ref")e||t(p);else if(_.slice(0,3)==="on:")p.addEventListener(_.slice(3),t);else if(_.slice(0,10)==="oncapture:")p.addEventListener(_.slice(10),t,!0);else if(_.slice(0,2)==="on"){const S=_.slice(2).toLowerCase(),b=Yt.has(S);Q(p,S,t,b),b&&Dt([S])}else if((g=zt.has(_))||!$&&(St[_]||(i=Wt.has(_)))||(a=p.nodeName.includes("-")))_==="class"||_==="className"?nn(p,t):a&&!i&&!g?p[on(_)]=t:p[St[_]||_]=t;else{const S=$&&_.indexOf(":")>-1&&Qt[_.split(":")[0]];S?tn(p,S,_,t):ct(p,qt[_]||_,t)}return t}function an(p){const _=`$$${p.type}`;let t=p.composedPath&&p.composedPath()[0]||p.target;for(p.target!==t&&Object.defineProperty(p,"target",{configurable:!0,value:t}),Object.defineProperty(p,"currentTarget",{configurable:!0,get(){return t||document}}),z.registry&&!z.done&&(z.done=!0,document.querySelectorAll("[id^=pl-]").forEach(l=>l.remove()));t!==null;){const l=t[_];if(l&&!t.disabled){const $=t[`${_}Data`];if($!==void 0?l($,p):l(p),p.cancelBubble)return}t=t.host&&t.host!==t&&t.host instanceof Node?t.host:t.parentNode}}function wt(p,_,t={},l,$){return _||(_={}),!$&&"children"in _&&V(()=>t.children=rt(p,_.children,t.children)),_.ref&&_.ref(p),V(()=>rn(p,_,l,!0,t,!0)),t}function rt(p,_,t,l,$){for(z.context&&!t&&(t=[...p.childNodes]);typeof t=="function";)t=t();if(_===t)return t;const e=typeof _,a=l!==void 0;if(p=a&&t[0]&&t[0].parentNode||p,e==="string"||e==="number"){if(z.context)return t;if(e==="number"&&(_=_.toString()),a){let i=t[0];i&&i.nodeType===3?i.data=_:i=document.createTextNode(_),t=et(p,t,l,i)}else t!==""&&typeof t=="string"?t=p.firstChild.data=_:t=p.textContent=_}else if(_==null||e==="boolean"){if(z.context)return t;t=et(p,t,l)}else{if(e==="function")return V(()=>{let i=_();for(;typeof i=="function";)i=i();t=rt(p,i,t,l)}),()=>t;if(Array.isArray(_)){const i=[];if(_t(i,_,$))return V(()=>t=rt(p,i,t,l,!0)),()=>t;if(z.context){for(let g=0;g<i.length;g++)if(i[g].parentNode)return t=i}if(i.length===0){if(t=et(p,t,l),a)return t}else Array.isArray(t)?t.length===0?Ot(p,i,l):Zt(p,t,i):(t&&et(p),Ot(p,i));t=i}else if(_ instanceof Node){if(z.context&&_.parentNode)return t=a?[_]:_;if(Array.isArray(t)){if(a)return t=et(p,t,l,_);et(p,t,null,_)}else t==null||t===""||!p.firstChild?p.appendChild(_):p.replaceChild(_,p.firstChild);t=_}}return t}function _t(p,_,t){let l=!1;for(let $=0,e=_.length;$<e;$++){let a=_[$],i;if(a instanceof Node)p.push(a);else if(!(a==null||a===!0||a===!1))if(Array.isArray(a))l=_t(p,a)||l;else if((i=typeof a)=="string")p.push(document.createTextNode(a));else if(i==="function")if(t){for(;typeof a=="function";)a=a();l=_t(p,Array.isArray(a)?a:[a])||l}else p.push(a),l=!0;else p.push(document.createTextNode(a.toString()))}return l}function Ot(p,_,t){for(let l=0,$=_.length;l<$;l++)p.insertBefore(_[l],t)}function et(p,_,t,l){if(t===void 0)return p.textContent="";const $=l||document.createTextNode("");if(_.length){let e=!1;for(let a=_.length-1;a>=0;a--){const i=_[a];if($!==i){const g=i.parentNode===p;!e&&!a?g?p.replaceChild($,i):p.insertBefore($,t):g&&i.remove()}else e=!0}}else p.insertBefore($,t);return[$]}Z();tt();var pt=p=>new Uint8Array(Buffer.from(p,"base64")),un=(p,_,t)=>new st.Algodv2(p,_,t),xt={numGlobalByteSlices:0,numGlobalInts:0,numLocalByteSlices:0,numLocalInts:0},ln=async(p,_,t,l,$,e=xt)=>{try{const a=await p.getTransactionParams().do();a.flatFee=!0,a.fee=1e3;const i=await p.compile(l).do(),g=await p.compile($).do(),S=st.makeApplicationCreateTxnFromObject({suggestedParams:a,from:_,onComplete:st.OnApplicationComplete.NoOpOC,approvalProgram:pt(i.result),clearProgram:pt(g.result),...xt,...e}),b=S.signTxn(pt(t)),{txId:s}=await p.sendRawTransaction(b).do(),d=await st.waitForConfirmation(p,s,5),w=d["application-index"];return{suggestedParams:a,applicationStartCompiled:i,clearProgramCompiled:g,txn:S,txnSigned:b,txId:s,transactionResponse:d,appId:w}}catch(a){throw console.log(`algo_network.deployApplication() rethrowing error: ${a}`),a}},sn=5,fn=4,cn="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",dn="http://localhost",pn=4001,hn=[{alias:"admin",privateKey:"OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg==",address:"4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M",mnemonic:"poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"},{alias:"x",privateKey:"lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ==",address:"Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ",mnemonic:"crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"},{alias:"o",privateKey:"0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w==",address:"KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI",mnemonic:"key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"}];const _n=`#pragma version 6
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
return`,bn=`#pragma version 6
int 1
return`;Z();tt();Z();tt();Z();tt();var gn=X('<svg fill="currentColor" strokeWidth="0" xmlns="http://www.w3.org/2000/svg"></svg>'),yn=X("<title></title>");function mn(p,_){return(()=>{const t=gn.cloneNode(!0);return $t(t,()=>p.a,!0,!0),$t(t,_,!0,!0),U(t,()=>p.c,null),U(t,(()=>{const l=ft(()=>!!_.title,!0);return()=>l()&&(()=>{const $=yn.cloneNode(!0);return U($,()=>_.title),$})()})(),null),V(l=>{const $=p.a.stroke,e={..._.style,overflow:"visible",color:_.color},a=_.size||"1em",i=_.size||"1em",g=p.c;return $!==l._v$&&ct(t,"stroke",l._v$=$),l._v$2=It(t,e,l._v$2),a!==l._v$3&&ct(t,"height",l._v$3=a),i!==l._v$4&&ct(t,"width",l._v$4=i),g!==l._v$5&&(t.innerHTML=l._v$5=g),l},{_v$:void 0,_v$2:void 0,_v$3:void 0,_v$4:void 0,_v$5:void 0}),t})()}function vn(p){return mn({a:{stroke:"none",viewBox:"0 0 24 24"},c:'<path d="M10 11H7.101l.001-.009a4.956 4.956 0 0 1 .752-1.787 5.054 5.054 0 0 1 2.2-1.811c.302-.128.617-.226.938-.291a5.078 5.078 0 0 1 2.018 0 4.978 4.978 0 0 1 2.525 1.361l1.416-1.412a7.036 7.036 0 0 0-2.224-1.501 6.921 6.921 0 0 0-1.315-.408 7.079 7.079 0 0 0-2.819 0 6.94 6.94 0 0 0-1.316.409 7.04 7.04 0 0 0-3.08 2.534 6.978 6.978 0 0 0-1.054 2.505c-.028.135-.043.273-.063.41H2l4 4 4-4zm4 2h2.899l-.001.008a4.976 4.976 0 0 1-2.103 3.138 4.943 4.943 0 0 1-1.787.752 5.073 5.073 0 0 1-2.017 0 4.956 4.956 0 0 1-1.787-.752 5.072 5.072 0 0 1-.74-.61L7.05 16.95a7.032 7.032 0 0 0 2.225 1.5c.424.18.867.317 1.315.408a7.07 7.07 0 0 0 2.818 0 7.031 7.031 0 0 0 4.395-2.945 6.974 6.974 0 0 0 1.053-2.503c.027-.135.043-.273.063-.41H22l-4-4-4 4z"></path>'},p)}var Sn=Ut({"node_modules/.pnpm/gun@0.2020.1237/node_modules/gun/gun.js"(p,_){Z(),tt(),function(){function t($,e){return e?Mt($):$.slice?t[a($)]:function(i,g){$(i={exports:{}}),t[a(g)]=i.exports};function a(i){return i.split("/").slice(-1).toString().replace(".js","")}}if(typeof _<"u")var l=_;t(function($){String.random=function(a,i){var g="";for(a=a||24,i=i||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";a-- >0;)g+=i.charAt(Math.floor(Math.random()*i.length));return g},String.match=function(a,i){var g,S;return typeof a!="string"?!1:(typeof i=="string"&&(i={"=":i}),i=i||{},g=i["="]||i["*"]||i[">"]||i["<"],a===g?!0:S!==i["="]?!1:(g=i["*"]||i[">"],a.slice(0,(g||"").length)===g?!0:S!==i["*"]?!1:S!==i[">"]&&S!==i["<"]?a>=i[">"]&&a<=i["<"]:S!==i[">"]&&a>=i[">"]||S!==i["<"]&&a<=i["<"]))},String.hash=function(a,i){if(typeof a=="string"){if(i=i||0,!a.length)return i;for(var g=0,S=a.length,b;g<S;++g)b=a.charCodeAt(g),i=(i<<5)-i+b,i|=0;return i}};var e=Object.prototype.hasOwnProperty;Object.plain=function(a){return a?a instanceof Object&&a.constructor===Object||Object.prototype.toString.call(a).match(/^\[object (\w+)\]$/)[1]==="Object":!1},Object.empty=function(a,i){for(var g in a)if(e.call(a,g)&&(!i||i.indexOf(g)==-1))return!1;return!0},Object.keys=Object.keys||function(a){var i=[];for(var g in a)e.call(a,g)&&i.push(g);return i},function(){var a,i=setTimeout,g=0,S=0,b=typeof setImmediate!=""+a&&setImmediate||i;i.hold=i.hold||9,i.poll=i.poll||function(s){if(i.hold>=+new Date-g&&S++<3333){s();return}b(function(){g=+new Date,s()},S=0)}}(),function(){var a=setTimeout,i=a.turn=a.turn||function(w){g.push(w)==1&&S(d)},g=i.s=[],S=a.poll,b=0,s,d=function(){(s=g[b++])&&s(),(b==g.length||b==99)&&(g=i.s=g.slice(b),b=0),g.length&&S(d)}}(),function(){var a,i=setTimeout,g=i.turn;(i.each=i.each||function(S,b,s,d){d=d||9,function w(R,h,A){if(h=(R=(S||[]).splice(0,d)).length){for(var v=0;v<h&&a===(A=b(R[v]));v++);if(a===A){g(w);return}}s&&s(A)}()})()}()})(t,"./shim"),t(function($){$.exports=function e(s,i,g){if(!s)return{to:e};var S,b=typeof i=="function",s=(this.tag||(this.tag={}))[s]||b&&(this.tag[s]={tag:s,to:e._={next:function(w){var R;(R=this.to)&&R.next(w)}}});if(b){var d={off:e.off||(e.off=function(){if(this.next===e._.next)return!0;this===this.the.last&&(this.the.last=this.back),this.to.back=this.back,this.next=e._.next,this.back.to=this.to,this.the.last===this.the&&delete this.on.tag[this.the.tag]}),to:e._,next:i,the:s,on:this,as:g};return(d.back=s.last||s).to=d,s.last=d}return(s=s.to)&&S!==i&&s.next(i),s}})(t,"./onto"),t(function($){$.exports=function(e){return e===null||typeof e=="string"||typeof e=="boolean"||typeof e=="number"&&e!=1/0&&e!=-1/0&&e===e||!!e&&typeof e["#"]=="string"&&Object.keys(e).length===1&&e["#"]}})(t,"./valid"),t(function($){t("./shim");function e(){var s=+new Date;return S<s?(i=0,S=s+e.drift):S=s+(i+=1)/g+e.drift}e.drift=0;var a=-1/0,i=0,g=999,S=a,b;e.is=function(s,d,w){var R=d&&s&&s._&&s._[">"]||w;if(!!R)return typeof(R=R[d])=="number"?R:a},e.ify=function(s,d,w,R,h){(s=s||{})._=s._||{},h&&(s._["#"]=h);var A=s._[">"]||(s._[">"]={});return b!==d&&d!=="_"&&(typeof w=="number"&&(A[d]=w),b!==R&&(s[d]=R)),s},$.exports=e})(t,"./state"),t(function($){t("./shim");function e(a){var i={s:{}},g=i.s;a=a||{max:999,age:1e3*9},i.check=function(b){return g[b]?S(b):!1};var S=i.track=function(b){var s=g[b]||(g[b]={});return s.was=i.now=+new Date,i.to||(i.to=setTimeout(i.drop,a.age+9)),s};return i.drop=function(b){i.to=null,i.now=+new Date;var s=Object.keys(g);console.STAT&&console.STAT(i.now,+new Date-i.now,"dup drop keys"),setTimeout.each(s,function(d){var w=g[d];w&&(b||a.age)>i.now-w.was||delete g[d]},0,99)},i}$.exports=e})(t,"./dup"),t(function($){t("./onto"),$.exports=function(i,g){if(!!this.on){var S=(this.opt||{}).lack||9e3;if(typeof i!="function"){if(!i)return;var s=i["#"]||i,b=(this.tag||"")[s];return b?(g&&(b=this.on(s,g),clearTimeout(b.err),b.err=setTimeout(function(){b.off()},S)),!0):void 0}var s=g&&g["#"]||e(9);if(!i)return s;var d=this.on(s,i,g);return d.err=d.err||setTimeout(function(){d.off(),d.next({err:"Error: No ACK yet.",lack:!0})},S),s}};var e=String.random||function(){return Math.random().toString(36).slice(2)}})(t,"./ask"),t(function($){function e(h){return h instanceof e?(this._={$:this}).$:this instanceof e?e.create(this._={$:this,opt:h}):new e(h)}e.is=function(h){return h instanceof e||h&&h._&&h===h._.$||!1},e.version=.202,e.chain=e.prototype,e.chain.toJSON=function(){},t("./shim"),e.valid=t("./valid"),e.state=t("./state"),e.on=t("./onto"),e.dup=t("./dup"),e.ask=t("./ask"),function(){e.create=function(n){n.root=n.root||n,n.graph=n.graph||{},n.on=n.on||e.on,n.ask=n.ask||e.ask,n.dup=n.dup||e.dup();var c=n.$.opt(n.opt);return n.once||(n.on("in",h,n),n.on("out",h,n),n.on("put",x,n),e.on("create",n),n.on("create",n)),n.once=1,c};function h(n){if(!!n){if(n.out===h){this.to.next(n);return}var c=this,T=c.as,D=T.at||T,N=D.$,O=D.dup,P,C=n.DBG;if((P=n["#"])||(P=n["#"]=i(9)),!O.check(P)){if(O.track(P),P=n._,n._=typeof P=="function"?P:function(){},n.$&&n.$===(n.$._||"").$||(n.$=N),n["@"]&&!n.put&&u(n),!D.ask(n["@"],n))if(C&&(C.u=+new Date),n.put){A(n);return}else n.get&&e.on.get(n,N);C&&(C.uc=+new Date),c.to.next(n),C&&(C.ua=+new Date),!(n.nts||n.NTS)&&(n.out=h,D.on("out",n),C&&(C.ue=+new Date))}}}function A(n){if(!!n){var c=n._||"",T=c.root=((c.$=n.$||"")._||"").root;if(n["@"]&&c.faith&&!c.miss){n.out=h,T.on("out",n);return}c.latch=T.hatch,c.match=T.hatch=[];var D=n.put,N=c.DBG=n.DBG,O=+new Date;if(G=G||O,!(D["#"]&&D["."])){N&&(N.p=O),c["#"]=n["#"],c.msg=n,c.all=0,c.stun=1;var P=Object.keys(D);console.STAT&&console.STAT(O,((N||c).pk=+new Date)-O,"put sort");var C=0,B,H,L,M,F,K,ot;(function nt(ut){if(B!=C){if(B=C,!(L=P[C])){console.STAT&&console.STAT(O,((N||c).pd=+new Date)-O,"put"),y(c);return}(M=D[L])?(ot=M._)?L!==ot["#"]?K=f+k(L)+"soul not same.":(F=ot[">"])||(K=f+k(L)+"no state."):K=f+k(L)+"no meta.":K=f+k(L)+"no node.",H=Object.keys(M||{})}if(K){n.err=c.err=K,y(c);return}var mt=0,Y;for(ut=ut||0;ut++<9&&(Y=H[mt++]);)if(Y!=="_"){var lt=M[Y],vt=F[Y];if(d===vt){K=f+k(Y)+"on"+k(L)+"no state.";break}if(!S(lt)){K=f+k(Y)+"on"+k(L)+"bad "+typeof lt+k(lt);break}v(lt,Y,L,vt,n),++I}if((H=H.slice(mt)).length){g(nt);return}++C,H=null,nt(ut)})()}}}e.on.put=A;function v(n,c,T,D,N){var O=N._||"",P=O.root,C=P.graph,B,H=C[T]||w,L=b(H,c,1),M=H[c],F=O.DBG;(B=console.STAT)&&(!C[T]||!M)&&(B.has=(B.has||0)+1);var K=E();if(D>K){setTimeout(function(){v(n,c,T,D,N)},(B=D-K)>j?j:B),console.STAT&&console.STAT((F||O).Hf=+new Date,B,"future");return}if(!(D<L&&!O.miss)&&!(!O.faith&&D===L&&(n===M||m(n)<=m(M))&&!O.miss)){O.stun++;var ot=N["#"]+O.all++,nt={toString:function(){return ot},_:O};nt.toJSON=nt.toString,F&&(F.ph=F.ph||+new Date),P.on("put",{"#":nt,"@":N["@"],put:{"#":T,".":c,":":n,">":D},_:O})}}function x(n){var c;(c=(n._||"").DBG)&&(c.pa=+new Date,c.pm=c.pm||+new Date);var T=this,D=T.as,N=D.graph,O=n._,P=n.put,C=P["#"],B=P["."],H=P[":"],L=P[">"];n["#"];var M;(M=O.msg)&&(M=M.put)&&(M=M[C])&&s(M,B,L,H,C),N[C]=s(N[C],B,L,H,C),(M=(D.next||"")[C])&&M.on("in",n),y(O),T.to.next(n)}function y(n,c){var T;if(!n.stop&&!(!n.err&&0<--n.stun)&&(n.stop=1,!!(T=n.root))){var D=n.match;D.end=1,D===T.hatch&&(!(D=n.latch)||D.end?delete T.hatch:T.hatch=D),n.hatch&&n.hatch(),setTimeout.each(n.match,function(N){N&&N()}),!(!(c=n.msg)||n.err||c.err)&&(c.out=h,n.root.on("out",c),o())}}function u(n){var c=n["@"]||"",T;!(T=c._)||(T.acks=(T.acks||0)+1,(T.err=n.err)&&(n["@"]=T["#"],y(T)),!T.stop&&!T.crack&&(T.crack=T.match&&T.match.push(function(){r(T)})),r(T))}function r(n){!n||!n.root||n.stun||n.acks!==n.all||n.root.on("in",{"@":n["#"],err:n.err,ok:n.err?d:{"":1}})}var f="Error: Invalid graph!",k=function(n){return" '"+(""+n).slice(0,9)+"...' "},m=JSON.stringify,j=2147483647,E=e.state,I=0,G,o=function(){I>999&&I/-(G-(G=+new Date))>1&&(e.window&&console.log("Warning: You're syncing 1K+ records a second, faster than DOM can update - consider limiting query."),o=function(){I=0})}}(),function(){e.on.get=function(A,v){var x=v._,y=A.get,u=y["#"],r=x.graph[u],f=y["."],k=x.next||(x.next={});k[u];var m=A._||{},j=m.DBG=A.DBG;if(j&&(j.g=+new Date),!r)return x.on("get",A);if(f){if(typeof f!="string"||d===r[f])return x.on("get",A);r=s({},f,b(r,f),r[f],u)}r&&h(A,r),x.on("get",A)};function h(A,v){var x=+new Date,y=A._||{},u=y.DBG=A.DBG,r=A["#"],f=i(9),k=Object.keys(v||"").sort(),m=((v||"")._||"")["#"];k.length;var j=A.$._.root,E=v===j.graph[m];console.STAT&&console.STAT(x,((u||y).gk=+new Date)-x,"got keys"),v&&function I(){x=+new Date;for(var G=0,o,n={},c;G<9&&(o=k[G++]);)s(n,o,b(v,o),v[o],m);k=k.slice(G),(c={})[m]=n,n=c;var T;E&&(T=function(){},T.ram=T.faith=!0),c=k.length,console.STAT&&console.STAT(x,-(x-(x=+new Date)),"got copied some"),u&&(u.ga=+new Date),j.on("in",{"@":r,"#":f,put:n,"%":c?f=i(9):d,$:j.$,_:T,DBG:u}),console.STAT&&console.STAT(x,+new Date-x,"got in"),c&&setTimeout.turn(I)}(),v||j.on("in",{"@":A["#"]})}e.on.get.ack=h}(),function(){e.chain.opt=function(h){h=h||{};var A=this,v=A._,x=h.peers||h;return Object.plain(h)||(h={}),Object.plain(v.opt)||(v.opt=h),typeof x=="string"&&(x=[x]),Object.plain(v.opt.peers)||(v.opt.peers={}),x instanceof Array&&(h.peers={},x.forEach(function(y){var u={};u.id=u.url=y,h.peers[y]=v.opt.peers[y]=v.opt.peers[y]||u})),a(h,function y(u){var r=this[u];if(this&&this.hasOwnProperty(u)||typeof r=="string"||Object.empty(r)){this[u]=r;return}r&&r.constructor!==Object&&!(r instanceof Array)||a(r,y)}),v.opt.from=h,e.on("opt",v),v.opt.uuid=v.opt.uuid||function(u){return e.state().toString(36).replace(".","")+String.random(u||12)},A}}();var a=function(h,A){Object.keys(h).forEach(A,h)},i=String.random,g=setTimeout.turn,S=e.valid,b=e.state.is,s=e.state.ify,d,w={},R;e.log=function(){return!e.log.off&&R.log.apply(R,arguments),[].slice.call(arguments).join(" ")},e.log.once=function(h,A,v){return(v=e.log.once)[h]=v[h]||0,v[h]++||e.log(A)},typeof window<"u"&&((window.GUN=window.Gun=e).window=window);try{typeof l<"u"&&(l.exports=e)}catch{}$.exports=e,(e.window||{}).console=(e.window||{}).console||{log:function(){}},(R=console).only=function(h,A){return R.only.i&&h===R.only.i&&R.only.i++&&(R.log.apply(R,arguments)||A)},e.log.once("welcome","Hello wonderful person! :) Thanks for using GUN, please ask for help on http://chat.gun.eco if anything takes you longer than 5min to figure out!")})(t,"./root"),t(function($){var e=t("./root");e.chain.back=function(g,S){var b;if(g=g||1,g===-1||g===1/0)return this._.root.$;if(g===1)return(this._.back||this._).$;var s=this,d=s._;if(typeof g=="string"&&(g=g.split(".")),g instanceof Array){var w=0,R=g.length,b=d;for(w;w<R;w++)b=(b||a)[g[w]];return i!==b?S?s:b:(b=d.back)?b.$.back(g,S):void 0}if(typeof g=="function"){for(var h,b={back:d};(b=b.back)&&i===(h=g(b,S)););return h}return typeof g=="number"?(d.back||d).$.back(g-1):this};var a={},i})(t,"./back"),t(function($){var e=t("./root");e.chain.chain=function(y){var u=this,r=u._,f=new(y||u).constructor(u),k=f._,m;return k.root=m=r.root,k.id=++m.once,k.back=u._,k.on=e.on,k.on("in",e.on.in,k),k.on("out",e.on.out,k),f};function a(y){var u,r=this.as,f=r.back,k=r.root,m;if(y.$||(y.$=r.$),this.to.next(y),r.err){r.on("in",{put:r.put=d,$:r.$});return}if(u=y.get){if(k.pass&&(k.pass[r.id]=r),r.lex&&Object.keys(r.lex).forEach(function(j){m[j]=r.lex[j]},m=y.get=y.get||{}),u["#"]||r.soul){if(u["#"]=u["#"]||r.soul,y["#"]||(y["#"]=w(9)),f=k.$.get(u["#"])._,u=u["."]){if(h(f.put,u)&&(m=f.ask&&f.ask[u],(f.ask||(f.ask={}))[u]=f.$.get(u)._,f.on("in",{get:u,put:{"#":f.soul,".":u,":":f.put[u],">":v(k.graph[f.soul],u)}}),m))return}else{if(m=f.ask&&f.ask[""],(f.ask||(f.ask={}))[""]=f,d!==f.put&&(f.on("in",f),m))return;y.$=f.$}return k.ask(b,y),k.on("in",y)}if(u["."])return r.get?(y={get:{".":r.get},$:r.$},(f.ask||(f.ask={}))[r.get]=y.$._,f.on("out",y)):(y={get:r.lex?y.get:{},$:r.$},f.on("out",y));if((r.ask||(r.ask={}))[""]=r,r.get)return u["."]=r.get,(f.ask||(f.ask={}))[r.get]=y.$._,f.on("out",y)}return f.on("out",y)}e.on.out=a;function i(y,u){u=u||this.as;var r=u.root,f=y.$||(y.$=u.$),k=(f||"")._||s,m=y.put||"",j=m["#"],E=m["."],I=d!==m["="]?m["="]:m[":"],G=m[">"]||-1/0,o;if(d!==y.put&&(d===m["#"]||d===m["."]||d===m[":"]&&d===m["="]||d===m[">"])){if(!R(m)){if(!(j=((m||"")._||"")["#"])){console.log("chain not yet supported for",m,"...",y,u);return}return f=u.root.$.get(j),setTimeout.each(Object.keys(m).sort(),function(n){n=="_"||d===(G=v(m,n))||u.on("in",{$:f,put:{"#":j,".":n,"=":m[n],">":G},VIA:y})})}u.on("in",{$:k.back.$,put:{"#":j=k.back.soul,".":E=k.has||k.get,"=":m,">":v(k.back.put,E)},via:y});return}(y.seen||"")[u.id]||((y.seen||(y.seen=function(){}))[u.id]=u,u!==k&&(Object.keys(y).forEach(function(n){m[n]=y[n]},m={}),m.get=u.get||m.get,!u.soul&&!u.has?m.$$$=m.$$$||u.$:k.soul&&(m.$=u.$,m.$$=m.$$||k.$),y=m),S(y,u),(u.soul||y.$$)&&G>=v(r.graph[j],E)&&((m=r.$.get(j)._).put=x(m.put,E,G,I,j)),!k.soul&&G>=v(r.graph[j],E)&&(o=(r.$.get(j)._.next||"")[E])&&(o.put=I,typeof(m=R(I))=="string"&&(o.put=r.$.get(m)._.put||I)),this.to&&this.to.next(y),u.any&&setTimeout.each(Object.keys(u.any),function(n){(n=u.any[n])&&n(y)},0,99),u.echo&&setTimeout.each(Object.keys(u.echo),function(n){(n=u.echo[n])&&n.on("in",y)},0,99),((y.$$||"")._||k).soul&&(o=u.next)&&(o=o[E])&&(m={},Object.keys(y).forEach(function(n){m[n]=y[n]}),m.$=(y.$$||y.$).get(m.get=E),delete m.$$,delete m.$$$,o.on("in",m)),g(y,u))}e.on.in=i;function g(y,u){if(u=u||this.as||y.$._,!(y.$$&&this!==e.on)&&!(!y.put||u.soul)){var r=y.put||"",f=r["="]||r[":"],E,k=u.root,m=k.$.get(r["#"]).get(r["."])._;if(typeof(f=R(f))!="string"){this===e.on&&((m.echo||(m.echo={}))[u.id]=u);return}if(!((m.echo||(m.echo={}))[u.id]&&!(k.pass||"")[u.id])){if(E=k.pass){if(E[f+u.id])return;E[f+u.id]=1}(m.echo||(m.echo={}))[u.id]=u,u.has&&(u.link=f);var j=k.$.get(m.link=f)._;(j.echo||(j.echo={}))[m.id]=m;var E=u.ask||"";(E[""]||u.lex)&&j.on("out",{get:{"#":f}}),setTimeout.each(Object.keys(E),function(I,G){!I||!(G=E[I])||G.on("out",{get:{"#":f,".":I}})},0,99)}}}e.on.link=g;function S(y,u){var r=y.put||"",f=d!==r["="]?r["="]:r[":"],k=u.root,m,j;if(d===f){if(u.soul&&d!==u.put||(j=(y.$$||y.$||"")._||"",y["@"]&&(d!==j.put||d!==u.put)))return;(m=u.link||y.linked)&&delete(k.$.get(m)._.echo||"")[u.id],u.has&&(u.link=null),u.put=d,setTimeout.each(Object.keys(u.next||""),function(E,I){!(I=u.next[E])||(m&&delete(k.$.get(m).get(E)._.echo||"")[I.id],I.on("in",{get:E,put:d,$:I.$}))},0,99);return}u.soul||y.$$||(m=R(f),j=y.$._||"",!((m===j.link||u.has&&!j.link)&&!((k.pass||"")[u.id]&&typeof m!="string"))&&(delete(j.echo||"")[u.id],S({get:u.get,put:d,$:y.$,linked:y.linked=y.linked||j.link},u)))}e.on.unlink=S;function b(y,u){var r=this.as,f=r.$._;f.root;var k=r.get||"",m=(y.put||"")[k["#"]]||"";if(!y.put||typeof k["."]=="string"&&d===m[k["."]]){if(d!==f.put||!f.soul&&!f.has)return;f.ack=(f.ack||0)+1,f.on("in",{get:f.get,put:f.put=d,$:f.$,"@":y["@"]});return}(y._||{}).miss=1,e.on.put(y)}var s={},d,w=String.random,R=e.valid,h=function(y,u){return y&&Object.prototype.hasOwnProperty.call(y,u)},A=e.state,v=A.is,x=A.ify})(t,"./chain"),t(function($){var e=t("./root");e.chain.get=function(d,w,R){var h,A;if(typeof d=="string"){if(d.length==0)return(h=this.chain())._.err={err:e.log("0 length key!",d)},w&&w.call(h,h._.err),h;var v=this,x=v._,y=x.next||S;(h=y[d])||(h=d&&a(d,v)),h=h&&h.$}else if(typeof d=="function"){let m=function(E,I,G){if(!m.stun&&!((N=r.pass)&&!N[f])){var o=E.$._,n=(E.$$||"")._,c=(n||o).put,T=!o.has&&!o.soul,D={},N;if((T||s===c)&&(c=s===((N=E.put)||"")["="]?s===(N||"")[":"]?N:N[":"]:N["="]),typeof(N=e.valid(c))=="string"&&(c=s===(N=r.$.get(N)._.put)?u.not?s:c:N),!(u.not&&s===c)){if(s===u.stun){if((N=r.stun)&&N.on&&(x.$.back(function(O){if(N.on(""+O.id,D={}),(D.run||0)<m.id)return D}),!D.run&&N.on(""+o.id,D={}),!D.run&&n&&N.on(""+n.id,D={}),m.id>D.run&&((!D.stun||D.stun.end)&&(D.stun=N.on("stun"),D.stun=D.stun&&D.stun.last),D.stun&&!D.stun.end))){(D.stun.add||(D.stun.add={}))[f]=function(){m(E,I,1)};return}if(s===c&&(G=0),(N=r.hatch)&&!N.end&&s===u.hatch&&!G){if(k[o.$._.id])return;k[o.$._.id]=1,N.push(function(){m(E,I,1)});return}k={}}if(r.pass){if(r.pass[f+o.id])return;r.pass[f+o.id]=1}if(u.on){u.ok.call(o.$,c,o.get,E,I||m);return}if(u.v2020){u.ok(E,I||m);return}Object.keys(E).forEach(function(O){N[O]=E[O]},N={}),E=N,E.put=c,u.ok.call(u.as,E,I||m)}}};if(w===!0)return i(this,d,w,R),this;h=this;var x=h._,u=w||{},r=x.root,f;u.at=x,u.ok=d;var k={};return m.at=x,(x.any||(x.any={}))[f=String.random(7)]=m,m.off=function(){m.stun=1,x.any&&delete x.any[f]},m.rid=g,m.id=u.run||++r.once,A=r.pass,(r.pass={})[f]=1,u.out=u.out||{get:{}},x.on("out",u.out),r.pass=A,h}else{if(typeof d=="number")return this.get(""+d,w,R);if(typeof(A=b(d))=="string")return this.get(A,w,R);(A=this.get.next)&&(h=A(this,d))}return h?(w&&typeof w=="function"&&h.get(w,R),h):((h=this.chain())._.err={err:e.log("Invalid get request!",d)},w&&w.call(h,h._.err),h)};function a(d,w){var R=w._,h=R.next,A=w.chain(),v=A._;return h||(h=R.next={}),h[v.get=d]=v,w===R.root.$?v.soul=d:(R.soul||R.has)&&(v.has=d),v}function i(d,w,R,h){var A=d._,v=0,x;return(x=A.soul||A.link)?w(x,h,A):A.jam?A.jam.push([w,h]):(A.jam=[[w,h]],d.get(function(u,r){if(!(s===u.put&&!A.root.opt.super&&(x=Object.keys(A.root.opt.peers).length)&&++v<=x)){r.rid(u);var f=(f=u.$)&&f._||{},k=0,m;for(x=A.jam,delete A.jam;m=x[k++];){var j=m[0];m=m[1],j&&j(f.link||f.soul||e.valid(u.put)||((u.put||{})._||{})["#"],m,u,r)}}},{out:{get:{".":!0}}}),d)}function g(d){var w=this.at||this.on;if(!d||w.soul||w.has)return this.off();if(!!(d=(d=(d=d.$||d)._||d).id)){w.map;var R;if((R=this.seen||(this.seen={}))[d])return!0;R[d]=!0}}var S={},b=e.valid,s})(t,"./get"),t(function($){var e=t("./root");e.chain.put=function(h,A,v){var x=this,y=x._,u=y.root;v=v||{},v.root=y.root,v.run||(v.run=u.once),a(v,y.id),v.ack=v.ack||A,v.via=v.via||x,v.data=v.data||h,v.soul||(v.soul=y.soul||typeof A=="string"&&A);var r=v.state=v.state||e.state();return typeof h=="function"?(h(function(f){v.data=f,x.put(b,b,v)}),x):v.soul?(v.$=u.$.get(v.soul),v.todo=[{it:v.data,ref:v.$}],v.turn=v.turn||d,v.ran=v.ran||i,function f(){var k=v.todo,m=k.pop(),j=m.it;m.ref&&m.ref._.id;var E,I,G,o,n;if(a(v,m.ref),(o=m.todo)&&(I=o.pop(),j=j[I],o.length&&k.push(m)),I&&(k.path||(k.path=[])).push(I),!(E=w(j))&&!(n=e.is(j))){if(!Object.plain(j)){i.err(v,"Invalid data: "+S(j)+" at "+(v.via.back(function(N){N.get&&o.push(N.get)},o=[])||o.join("."))+"."+(k.path||[]).join("."));return}for(var c=v.seen||(v.seen=[]),T=c.length;T--;)if(j===(o=c[T]).it){E=j=o.link;break}}if(I&&E)m.node=R(m.node,I,r,j);else{let N=function(O,P){var C=G.link["#"];P&&(P.off(),P.rid(O));var B=C||O.soul||(o=(O.$$||O.$)._||"").soul||o.link||((o=o.put||"")._||"")["#"]||o["#"]||((o=O.put||"")&&O.$$?o["#"]:(o["="]||o[":"]||"")["#"]);if(!C&&a(v,O.$),!B&&!m.link["#"]){(m.wait||(m.wait=[])).push(function(){N(O,P)});return}B||(B=[],(O.$$||O.$).back(function(H){if(o=H.soul||H.link)return B.push(o);B.push(H.get)}),B=B.reverse().join("/")),G.link["#"]=B,!n&&(((v.graph||(v.graph={}))[B]=G.node||(G.node={_:{}}))._["#"]=B),delete v.wait[D],G.wait&&setTimeout.each(G.wait,function(H){H&&H()}),v.ran(v)};if(!v.seen){i.err(v,"Data at root of graph must be a node (an object).");return}v.seen.push(G={it:j,link:{},todo:n?[]:Object.keys(j).sort().reverse(),path:(k.path||[]).slice(),up:m}),m.node=R(m.node,I,r,G.link),!n&&G.todo.length&&k.push(G);var D=v.seen.length;(v.wait||(v.wait={}))[D]="",o=(G.ref=n?j:I?m.ref.get(I):m.ref)._,(o=j&&(j._||"")["#"]||o.soul||o.link)?N({soul:o}):G.ref.get(N,{run:v.run,v2020:1,out:{get:{".":" "}}})}if(!k.length)return v.ran(v);v.turn(f)}(),x):(g(v),x)};function a(h,A){if(!!A){A=(A._||"").id||A;var v=h.root.stun||(h.root.stun={on:e.on}),x={},y;h.stun||(h.stun=v.on("stun",function(){})),(y=v.on(""+A))&&y.the.last.next(x),!(x.run>=h.run)&&v.on(""+A,function(u){if(h.stun.end){this.off(),this.to.next(u);return}u.run=u.run||h.run,u.stun=u.stun||h.stun})}}function i(h){if(h.err){i.end(h.stun,h.root);return}if(!(h.todo.length||h.end||!Object.empty(h.wait))){h.end=1;var A=h.$.back(-1)._,v=A.root,x=A.ask(function(f){v.on("ack",f),f.err&&e.log(f),++y>(h.acks||0)&&this.off(),h.ack&&h.ack(f,this)},h.opt),y=0,u=h.stun,r;(r=function(){!u||(i.end(u,v),setTimeout.each(Object.keys(u=u.add||""),function(f){(f=u[f])&&f()}))}).hatch=r,h.via._.on("out",{put:h.out=h.graph,opt:h.opt,"#":x,_:r})}}i.end=function(h,A){h.end=s,h.the.to===h&&h===h.the.last&&delete A.stun,h.off()},i.err=function(h,A){(h.ack||s).call(h,h.out={err:h.err=e.log(A)}),h.ran(h)};function g(h){var A=h.via._,v;h.via=h.via.back(function(x){if(x.soul||!x.get)return x.$;v=h.data,(h.data={})[x.get]=v}),(!h.via||!h.via._.soul)&&(h.via=A.root.$.get(((h.data||"")._||"")["#"]||A.$.back("opt.uuid")())),h.via.put(h.data,h.ack,h)}function S(h,A){return h&&(A=h.constructor)&&A.name||typeof h}var b,s=function(){},d=setTimeout.turn,w=e.valid,R=e.state.ify})(t,"./put"),t(function($){var e=t("./root");t("./chain"),t("./back"),t("./put"),t("./get"),$.exports=e})(t,"./index"),t(function($){var e=t("./index");e.chain.on=function(g,S,b,s){var d=this,w=d._;w.root;var R;if(typeof g=="string")return S?(R=w.on(g,S,b||w,s),b&&b.$&&(b.subs||(b.subs=[])).push(R),d):w.on(g);var h=S;return(h=h===!0?{change:!0}:h||{}).not=1,h.on=1,d.get(g,h),d},e.chain.once=function(g,S){if(S=S||{},!g)return a(this);var b=this,s=b._,d=s.root;s.put;var w=String.random(7),R;return b.get(function(h,A,v,x){var y=this,u=y._,r=u.one||(u.one={});if(x.stun||r[w]==="")return;if((R=e.valid(h))===!0){f();return}if(typeof R=="string")return;clearTimeout((s.one||"")[w]),clearTimeout(r[w]),r[w]=setTimeout(f,S.wait||99);function f(k){if(!u.has&&!u.soul&&(u={put:h,get:A}),i===(R=u.put)&&(R=((v.$$||"")._||"").put),typeof e.valid(R)=="string"&&(R=d.$.get(R)._.put,R===i&&!k)){r[w]=setTimeout(function(){f(1)},S.wait||99);return}x.stun||r[w]!==""&&(r[w]="",(s.soul||s.has)&&x.off(),g.call(y,R,u.get),clearTimeout(r[w]))}},{on:1}),b};function a(g,S,b){return e.log.once("valonce","Chainable val is experimental, its behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),(b=g.chain())._.nix=g.once(function(s,d){b._.on("in",this._)}),b._.lex=g._.lex,b}e.chain.off=function(){var g=this,S=g._,b,s=S.back;if(!!s)return S.ack=0,(b=s.next)&&b[S.get]&&delete b[S.get],(b=s.ask)&&delete b[S.get],(b=s.put)&&delete b[S.get],(b=S.soul)&&delete s.root.graph[b],(b=S.map)&&Object.keys(b).forEach(function(d,w){w=b[d],w.link&&s.root.$.get(w.link).off()}),(b=S.next)&&Object.keys(b).forEach(function(d,w){w=b[d],w.$.off()}),S.on("off",{}),g};var i})(t,"./on"),t(function($){var e=t("./index"),a=e.chain.get.next;e.chain.get.next=function(b,s){var d;return Object.plain(s)?(d=((d=s["#"])||"")["="]||d)?b.get(d):((d=b.chain()._).lex=s,b.on("in",function(w){String.match(w.get||(w.put||"")["."],s["."]||s["#"]||s)&&d.on("in",w),this.to.next(w)}),d.$):(a||g)(b,s)},e.chain.map=function(b,s,d){var w=this,R=w._,h,A;return Object.plain(b)&&(h=b["."]?b:{".":b},b=S),b?(e.log.once("mapfn","Map functions are experimental, their behavior and API may change moving forward. Please play with it and report bugs and ideas on how to improve it."),A=w.chain(),w.map().on(function(v,x,y,u){var r=(b||g).call(this,v,x,y,u);if(S!==r){if(v===r)return A._.on("in",y);if(e.is(r))return A._.on("in",r._);var f={};Object.keys(y.put).forEach(function(k){f[k]=y.put[k]},f),f["="]=r,A._.on("in",{get:x,put:f})}}),A):((A=R.each)||((R.each=A=w.chain())._.lex=h||A._.lex||R.lex,A._.nix=w.back("nix"),w.on("in",i,A._)),A)};function i(b){this.to.next(b);var s=this.as,d=b.$,w=d._,R=b.put,h;!w.soul&&!b.$$||(h=s.lex)&&!String.match(b.get||(R||"")["."],h["."]||h["#"]||h)||e.on.link(b,s)}var g=function(){},S})(t,"./map"),t(function($){var e=t("./index");e.chain.set=function(a,i,g){var S=this,b=S.back(-1),s,d;return i=i||function(){},g=g||{},g.item=g.item||a,(s=((a||"")._||"")["#"])&&((a={})["#"]=s),typeof(d=e.valid(a))=="string"?S.get(s=d).put(a,i,g):e.is(a)?(S.put(function(w){a.get(function(R,h,A){if(!R)return i.call(S,{err:e.log('Only a node can be linked! Not "'+A.put+'"!')});(d={})[R]={"#":R},w(d)},!0)}),a):(Object.plain(a)&&(a=b.get(s=S.back("opt.uuid")()).put(a)),S.get(s||b.back("opt.uuid")(7)).put(a,i,g))}})(t,"./set"),t(function($){t("./shim");var e=function(){},a=JSON.parseAsync||function(b,s,d){var w,R=+new Date;try{s(w,JSON.parse(b,d),i.sucks(+new Date-R))}catch(h){s(h)}},i=JSON.stringifyAsync||function(b,s,d,w){var R,h=+new Date;try{s(R,JSON.stringify(b,d,w),i.sucks(+new Date-h))}catch(A){s(A)}};i.sucks=function(b){b>99&&(console.log("Warning: JSON blocking CPU detected. Add `gun/lib/yson.js` to fix."),i.sucks=e)};function g(b){var s=function(){},d=b.opt||{};d.log=d.log||console.log,d.gap=d.gap||d.wait||0,d.max=d.max||(d.memory?d.memory*999*999:3e8)*.3,d.pack=d.pack||d.max*.01*.01,d.puff=d.puff||9;var w=setTimeout.turn||setTimeout,R=b.dup,h=R.check,A=R.track,v=s.hear=function(r,f){if(!!r){if(d.max<=r.length)return s.say({dam:"!",err:"Message too big!"},f);s===this&&(v.d+=r.length||0,++v.c);var k=f.SH=+new Date,m=r[0],j;if(m==="["){a(r,function(E,I){if(E||!I)return s.say({dam:"!",err:"DAM JSON parse error."},f);console.STAT&&console.STAT(+new Date,I.length,"# on hear batch");var G=d.puff;(function o(){for(var n=+new Date,c=0,T;c<G&&(T=I[c++]);)s.hear(T,f);I=I.slice(c),console.STAT&&console.STAT(n,+new Date-n,"hear loop"),x(f),I.length&&w(o,0)})()}),r="";return}if(m==="{"||(r["#"]||Object.plain(r))&&(j=r)){if(j)return v.one(j,f,k);a(r,function(E,I){if(E||!I)return s.say({dam:"!",err:"DAM JSON parse error."},f);v.one(I,f,k)});return}}};v.one=function(r,f,o){var m,j,E,I,G;if(r.DBG&&(r.DBG=G={DBG:r.DBG}),G&&(G.h=o),G&&(G.hp=+new Date),(m=r["#"])||(m=r["#"]=String.random(9)),!(E=h(m))&&(j=r["##"],!(j&&(E=r["@"]||r.get&&m)&&R.check(I=E+j)))){if((r._=function(){}).via=s.leap=f,(E=r["><"])&&typeof E=="string"&&E.slice(0,99).split(",").forEach(function(n){this[n]=1},r._.yo={}),E=r.dam){(E=s.hear[E])&&E(r,f,b),A(m);return}var o=+new Date;G&&(G.is=o),f.SI=m,b.on("in",s.last=r),G&&(G.hd=+new Date),console.STAT&&console.STAT(o,+new Date-o,r.get?"msg get":r.put?"msg put":"msg"),(E=A(m)).via=f,r.get&&(E.it=r),I&&A(I),s.leap=s.last=null}},v.c=v.d=0,function(){var r=0,f;s.hash=function(j,E){var I,G,o,n=+new Date;i(j.put,function c(T,D){var N=(G||(G=o=D||"")).slice(0,32768);if(I=String.hash(N,I),G=G.slice(32768),G){w(c,0);return}console.STAT&&console.STAT(n,+new Date-n,"say json+hash"),j._.$put=o,j["##"]=I,s.say(j,E),delete j._.$put},k)};function k(j,E){var I;return E instanceof Object?(Object.keys(E).sort().forEach(m,{to:I={},on:E}),I):E}function m(j){this.to[j]=this.on[j]}s.say=function(j,E){var I;if((I=this)&&(I=I.to)&&I.next&&I.next(j),!j)return!1;var G,o,n=j["@"],c=j._||(j._=function(){}),T=j.DBG,D=+new Date;if(c.y=c.y||D,E||T&&(T.y=D),(G=j["#"])||(G=j["#"]=String.random(9)),!f&&A(G),j.put&&(j.err||(R.s[G]||"").err))return!1;if(!j["##"]&&S!==j.put&&!c.via&&n){s.hash(j,E);return}if(!E&&n&&(E=(I=R.s[n])&&(I.via||(I=I.it)&&(I=I._)&&I.via)||(I=s.last)&&n===I["#"]&&s.leap),!E&&n)return R.s[n]?void 0:(console.STAT&&console.STAT(+new Date,++r,"total no peer to ack to"),!1);if(!E&&s.way)return s.way(j);if(T&&(T.yh=+new Date),!(o=c.raw)){s.raw(j,E);return}if(T&&(T.yr=+new Date),!E||!E.id){if(!Object.plain(E||d.peers))return!1;var D=+new Date;d.puff;var N=d.peers,O=Object.keys(E||d.peers||{});console.STAT&&console.STAT(D,+new Date-D,"peer keys"),function B(){var H=+new Date;f=1;var L=c.raw;c.raw=o;for(var M=0,F;M<9&&(F=(O||"")[M++]);)!(F=N[F])||s.say(j,F);c.raw=L,f=0,O=O.slice(M),console.STAT&&console.STAT(H,+new Date-H,"say loop"),O.length&&(w(B,0),n&&A(n))}();return}if(!E.wire&&s.wire&&s.wire(E),G!==E.last){if(E.last=G,E===c.via||(I=c.yo)&&(I[E.url]||I[E.pid]||I[E.id]))return!1;if(console.STAT&&console.STAT(D,((T||c).yp=+new Date)-(c.y||D),"say prep"),!f&&n&&A(n),E.batch){if(E.tail=(I=E.tail||0)+o.length,E.tail<=d.pack){E.batch+=(I?",":"")+o;return}x(E)}E.batch="[";var P=+new Date;setTimeout(function(){console.STAT&&console.STAT(P,+new Date-P,"0ms TO"),x(E)},d.gap),y(o,E),console.STAT&&n===E.SI&&console.STAT(D,+new Date-E.SH,"say ack")}},s.say.c=s.say.d=0,s.raw=function(j,E){if(!j)return"";var I=j._||{},G,o;if(o=I.raw)return o;if(typeof j=="string")return j;var n=j["##"],c=j["@"];if(n&&c){if(!I.via&&h(c+n))return!1;if((o=(R.s[c]||"").it)||(o=s.last)&&c===o["#"]){if(n===o["##"])return!1;o["##"]||(o["##"]=n)}}if(!j.dam){var T=0,D=[];o=d.peers;for(var N in o){var O=o[N];if(D.push(O.url||O.pid||O.id),++T>6)break}T>1&&(j["><"]=D.join())}if(G=I.$put){o={},Object.keys(j).forEach(function(C){o[C]=j[C]}),o.put=":])([:",i(o,function(C,B){if(!C){var H=+new Date;o=B.indexOf('"put":":])([:"'),P(S,B=B.slice(0,o+6)+G+B.slice(o+14)),console.STAT&&console.STAT(H,+new Date-H,"say slice")}});return}i(j,P);function P(C,B){C||(I.raw=B,s.say(j,E))}}}();function x(r){var f=r.batch,k=typeof f=="string";if(k&&(f+="]"),r.batch=r.tail=null,!!f&&!(k?3>f.length:!f.length)){if(!k)try{f=f.length===1?f[0]:JSON.stringify(f)}catch(m){return d.log("DAM JSON stringify error",m)}!f||y(f,r)}}function y(r,f){try{var k=f.wire;f.say?f.say(r):k.send&&k.send(r),s.say.d+=r.length||0,++s.say.c}catch{(f.queue=f.queue||[]).push(r)}}s.hi=function(r){var f=r.wire,k;if(!f){s.wire(r.length&&{url:r}||r);return}r.id?d.peers[r.url||r.id]=r:(k=r.id=r.id||String.random(9),s.say({dam:"?",pid:b.opt.pid},d.peers[k]=r),delete R.s[r.last]),r.met=r.met||+new Date,f.hied||b.on(f.hied="hi",r),k=r.queue,r.queue=[],setTimeout.each(k||[],function(m){y(m,r)},0,9)},s.bye=function(r){b.on("bye",r);var f=+new Date;f=f-(r.met||f),s.bye.time=((s.bye.time||f)+f)/2},s.hear["!"]=function(r,f){d.log("Error:",r.err)},s.hear["?"]=function(r,f){r.pid&&(f.pid||(f.pid=r.pid),r["@"])||(s.say({dam:"?",pid:d.pid,"@":r["#"]},f),delete R.s[f.last])},b.on("create",function(r){r.opt.pid=r.opt.pid||String.random(9),this.to.next(r),r.on("out",s.say)}),b.on("bye",function(r,f){r=d.peers[r.id||r]||r,this.to.next(r),r.bye?r.bye():(f=r.wire)&&f.close&&f.close(),delete d.peers[r.id],r.wire=null});var u={};return b.on("bye",function(r,f){this.to.next(r),(f=console.STAT)&&(f.peers=(f.peers||0)-1),(f=r.url)&&(u[f]=!0,setTimeout(function(){delete u[f]},d.lack||9e3))}),b.on("hi",function(r,f){this.to.next(r),(f=console.STAT)&&(f.peers=(f.peers||0)+1),!(!(f=r.url)||!u[f])&&(delete u[f],!d.super&&setTimeout.each(Object.keys(b.next),function(k){b.next[k],f={},f[k]=b.graph[k],f=String.hash(f),s.say({"##":f,get:{"#":k}},r)}))}),s}var S;try{$.exports=g}catch{}})(t,"./mesh"),t(function($){var e=t("../index");e.Mesh=t("./mesh"),e.on("opt",function(i){if(this.to.next(i),i.once)return;var g=i.opt;if(g.WebSocket===!1)return;var S=e.window||{},b=g.WebSocket||S.WebSocket||S.webkitWebSocket||S.mozWebSocket;if(!b)return;g.WebSocket=b;var s=g.mesh=g.mesh||e.Mesh(i);s.wire||g.wire,s.wire=g.wire=d;function d(A){try{if(!A||!A.url)return x&&x(A);var v=A.url.replace(/^http/,"ws"),x=A.wire=new g.WebSocket(v);return x.onclose=function(){g.mesh.bye(A),R(A)},x.onerror=function(y){R(A)},x.onopen=function(){g.mesh.hi(A)},x.onmessage=function(y){!y||g.mesh.hear(y.data||y,A)},x}catch{}}setTimeout(function(){!g.super&&i.on("out",{dam:"hi"})},1);var w=2*999;function R(A){clearTimeout(A.defer),g.peers[A.url]&&(h&&A.retry<=0||(A.retry=(A.retry||g.retry+1||60)-(-A.tried+(A.tried=+new Date)<w*4?1:0),A.defer=setTimeout(function v(){if(h&&h.hidden)return setTimeout(v,w);d(A)},w)))}var h=""+a!=typeof document&&document});var a})(t,"./websocket"),t(function($){if(!(typeof Gun>"u")){var e=function(){},a;try{a=(Gun.window||e).localStorage}catch{}a||(Gun.log("Warning: No localStorage exists to persist data to!"),a={setItem:function(g,S){this[g]=S},removeItem:function(g){delete this[g]},getItem:function(g){return this[g]}});var i=JSON.stringifyAsync||function(g,S,b,s){var d;try{S(d,JSON.stringify(g,b,s))}catch(w){S(w)}};Gun.on("create",function g(S){this.to.next(S);var b=S.opt;S.graph;var s=[],d,w,R,h;if(b.localStorage===!1)return;b.prefix=b.file||"gun/";try{d=g[b.prefix]=g[b.prefix]||JSON.parse(R=a.getItem(b.prefix))||{}}catch{d=g[b.prefix]={}}R=(R||"").length,S.on("get",function(v){this.to.next(v);var x=v.get,y,u,r,f;!x||!(y=x["#"])||(u=d[y]||f,u&&(r=x["."])&&!Object.plain(r)&&(u=Gun.state.ify({},r,Gun.state.is(u,r),u[r],y)),Gun.on.get.ack(v,u))}),S.on("put",function(v){this.to.next(v);var x=v.put,y=x["#"],u=x["."],r=v["#"];if(d[y]=Gun.state.ify(d[y],u,x[">"],x[":"],y),h&&R>4999880){S.on("in",{"@":r,err:"localStorage max!"});return}v["@"]||s.push(r),!w&&(w=setTimeout(A,9+R/333))});function A(){if(!s.length&&((setTimeout.turn||"").s||"").length){setTimeout(A,99);return}var v=s;clearTimeout(w),w=!1,s=[],i(d,function(x,y){try{!x&&a.setItem(b.prefix,y)}catch(u){x=h=u||"localStorage failure"}x&&(Gun.log(x+" Consider using GUN's IndexedDB plugin for RAD for more storage space, https://gun.eco/docs/RAD#install"),S.on("localStorage:error",{err:x,get:b.prefix,put:d})),R=y.length,!(!x&&!Object.empty(b.peers))&&setTimeout.each(v,function(u){S.on("in",{"@":u,err:x,ok:0})},0,99)})}})}})(t,"./localStorage")}(),function(){var G;if(""+G!=typeof Gun){var t=function(o){console.warn("Warning! Deprecated internal utility will break in next version:",o)},l=Gun;l.fn=l.fn||{is:function(o){return t("fn"),!!o&&typeof o=="function"}},l.bi=l.bi||{is:function(o){return t("bi"),o instanceof Boolean||typeof o=="boolean"}},l.num=l.num||{is:function(o){return t("num"),!$(o)&&(o-parseFloat(o)+1>=0||o===1/0||o===-1/0)}},l.text=l.text||{is:function(o){return t("text"),typeof o=="string"}},l.text.ify=l.text.ify||function(o){return t("text.ify"),l.text.is(o)?o:typeof JSON<"u"?JSON.stringify(o):o&&o.toString?o.toString():o},l.text.random=l.text.random||function(o,n){t("text.random");var c="";for(o=o||24,n=n||"0123456789ABCDEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz";o>0;)c+=n.charAt(Math.floor(Math.random()*n.length)),o--;return c},l.text.match=l.text.match||function(o,n){var c,T;return t("text.match"),typeof o!="string"?!1:(typeof n=="string"&&(n={"=":n}),n=n||{},c=n["="]||n["*"]||n[">"]||n["<"],o===c?!0:T!==n["="]?!1:(c=n["*"]||n[">"]||n["<"],o.slice(0,(c||"").length)===c?!0:T!==n["*"]?!1:T!==n[">"]&&T!==n["<"]?o>=n[">"]&&o<=n["<"]:T!==n[">"]&&o>=n[">"]||T!==n["<"]&&o<=n["<"]))},l.text.hash=l.text.hash||function(o,n){if(t("text.hash"),typeof o=="string"){if(n=n||0,!o.length)return n;for(var c=0,T=o.length,D;c<T;++c)D=o.charCodeAt(c),n=(n<<5)-n+D,n|=0;return n}},l.list=l.list||{is:function(o){return t("list"),o instanceof Array}},l.list.slit=l.list.slit||Array.prototype.slice,l.list.sort=l.list.sort||function(o){return t("list.sort"),function(n,c){return!n||!c?0:(n=n[o],c=c[o],n<c?-1:n>c?1:0)}},l.list.map=l.list.map||function(o,n,c){return t("list.map"),E(o,n,c)},l.list.index=1,l.obj=l.boj||{is:function(o){return t("obj"),o?o instanceof Object&&o.constructor===Object||Object.prototype.toString.call(o).match(/^\[object (\w+)\]$/)[1]==="Object":!1}},l.obj.put=l.obj.put||function(o,n,c){return t("obj.put"),(o||{})[n]=c,o},l.obj.has=l.obj.has||function(o,n){return t("obj.has"),o&&Object.prototype.hasOwnProperty.call(o,n)},l.obj.del=l.obj.del||function(o,n){if(t("obj.del"),!!o)return o[n]=null,delete o[n],o},l.obj.as=l.obj.as||function(o,n,c,T){return t("obj.as"),o[n]=o[n]||(T===c?{}:c)},l.obj.ify=l.obj.ify||function(o){if(t("obj.ify"),r(o))return o;try{o=JSON.parse(o)}catch{o={}}return o},function(){var o;function n(c,T){k(this,T)&&o!==this[T]||(this[T]=c)}l.obj.to=l.obj.to||function(c,T){return t("obj.to"),T=T||{},E(c,n,T),T}}(),l.obj.copy=l.obj.copy||function(o){return t("obj.copy"),o&&JSON.parse(JSON.stringify(o))},function(){function o(n,c){var T=this.n,D;if(!(T&&(c===T||r(T)&&k(T,c)))&&D!==c)return!0}l.obj.empty=l.obj.empty||function(n,c){return t("obj.empty"),n?!E(n,o,{n:c}):!0}}(),function(){function o(T,D){if(arguments.length===2){o.r=o.r||{},o.r[T]=D;return}o.r=o.r||[],o.r.push(T)}var n=Object.keys,c;Object.keys=Object.keys||function(T){return c(T,function(D,N,O){O(N)})},l.obj.map=c=l.obj.map||function(T,D,N){t("obj.map");var O,P=0,C,B,H,L,M=typeof D=="function";if(o.r=O,n&&r(T)&&(H=n(T),L=!0),N=N||{},$(T)||H)for(C=(H||T).length;P<C;P++){var F=P+l.list.index;if(M){if(B=L?D.call(N,T[H[P]],H[P],o):D.call(N,T[P],F,o),B!==O)return B}else if(D===T[L?H[P]:P])return H?H[P]:F}else for(P in T)if(M){if(k(T,P)&&(B=N?D.call(N,T[P],P,o):D(T[P],P,o),B!==O))return B}else if(D===T[P])return P;return M?o.r:l.list.index?0:-1}}(),l.time=l.time||{},l.time.is=l.time.is||function(o){return t("time"),o?o instanceof Date:+new Date().getTime()};var y=l.fn.is,$=l.list.is,u=l.obj,r=u.is,k=u.has,E=u.map,e={};e.is=function(o){return t("val.is"),o===G?!1:o===null?!0:o===1/0?!1:g(o)||i(o)||h(o)?!0:e.link.is(o)||!1},e.link=e.rel={_:"#"},function(){e.link.is=function(n){if(t("val.link.is"),n&&n[a]&&!n._&&r(n)){var c={};if(E(n,o,c),c.id)return c.id}return!1};function o(n,c){var T=this;if(T.id)return T.id=!1;if(c==a&&g(n))T.id=n;else return T.id=!1}}(),e.link.ify=function(o){return t("val.link.ify"),j({},a,o)},l.obj.has._=".";var a=e.link._,G,i=l.bi.is,h=l.num.is,g=l.text.is,u=l.obj,r=u.is,j=u.put,E=u.map;l.val=l.val||e;var S={_:"_"};S.soul=function(o,n){return t("node.soul"),o&&o._&&o._[n||d]},S.soul.ify=function(o,n){return t("node.soul.ify"),n=typeof n=="string"?{soul:n}:n||{},o=o||{},o._=o._||{},o._[d]=n.soul||o._[d]||s(),o},S.soul._=e.link._,function(){S.is=function(n,c,T){t("node.is");var D;return r(n)&&(D=S.soul(n))?!E(n,o,{as:T,cb:c,s:D,n}):!1};function o(n,c){if(c!==S._){if(!e.is(n))return!0;this.cb&&this.cb.call(this.as,n,c,this.n,this.s)}}}(),function(){S.ify=function(n,c,T){return t("node.ify"),c?typeof c=="string"?c={soul:c}:typeof c=="function"&&(c={map:c}):c={},c.map&&(c.node=c.map.call(T,n,G,c.node||{})),(c.node=S.soul.ify(c.node||{},c))&&E(n,o,{o:c,as:T}),c.node};function o(n,c){var T=this.o,D,N;if(T.map){D=T.map.call(this.as,n,""+c,T.node),N===D?f(T.node,c):T.node&&(T.node[c]=D);return}e.is(n)&&(T.node[c]=n)}}();var u=l.obj,r=u.is,f=u.del,E=u.map,b=l.text,s=b.random,d=S.soul._,G;l.node=l.node||S;var w=l.state;w.lex=function(){return t("state.lex"),w().toString(36).replace(".","")},w.to=function(o,n,c){t("state.to");var T=(o||{})[n];return r(T)&&(T=I(T)),w.ify(c,n,w.is(o,n),T,S.soul(o))},function(){w.map=function(n,c,T){t("state.map");var D,N=r(N=n||c)?N:null;return n=y(n=n||c)?n:null,N&&!n?(c=h(c)?c:w(),N[v]=N[v]||{},E(N,o,{o:N,s:c}),N):(T=T||r(c)?c:D,c=h(c)?c:w(),function(O,P,C,B){if(!n)return o.call({o:C,s:c},O,P),O;n.call(T||this||{},O,P,C,B),!(k(C,P)&&D===C[P])&&o.call({o:C,s:c},O,P)})};function o(n,c){v!==c&&w.ify(this.o,c,this.s)}}();var u=l.obj;u.as;var k=u.has,r=u.is,E=u.map,I=u.copy,R=l.num,h=R.is,A=l.fn,y=A.is,v=S._,G,x={};(function(){x.is=function(c,T,D,N){return t("graph.is"),!c||!r(c)||m(c)?!1:!E(c,o,{cb:T,fn:D,as:N})};function o(c,T){if(!c||T!==S.soul(c)||!S.is(c,this.fn,this.as))return!0;!this.cb||(n.n=c,n.as=this.as,this.cb.call(n.as,c,T,n))}function n(c){c&&S.is(n.n,c,n.as)}})(),function(){x.ify=function(N,O,P){t("graph.ify");var C={path:[],obj:N};return O?typeof O=="string"?O={soul:O}:typeof O=="function"&&(O.map=O):O={},typeof P=="string"&&(O.soul=O.soul||P,P=G),O.soul&&(C.link=e.link.ify(O.soul)),O.shell=(P||{}).shell,O.graph=O.graph||{},O.seen=O.seen||[],O.as=O.as||P,o(O,C),O.root=C.node,O.graph};function o(N,O){var P;return(P=D(N,O))?P:(O.env=N,O.soul=c,S.ify(O.obj,n,O)&&(O.link=O.link||e.link.ify(S.soul(O.node)),O.obj!==N.shell&&(N.graph[e.link.is(O.link)]=O.node)),O)}function n(N,O,P){var C=this,B=C.env,H,L;if(S._===O&&k(N,e.link._))return P._;if(!!(H=T(N,O,P,C,B))){if(O||(C.node=C.node||P||{},k(N,S._)&&S.soul(N)&&(C.node._=I(N._)),C.node=S.soul.ify(C.node,e.link.is(C.link)),C.link=C.link||e.link.ify(S.soul(C.node))),(L=B.map)&&(L.call(B.as||{},N,O,P,C),k(P,O))){if(N=P[O],G===N){f(P,O);return}if(!(H=T(N,O,P,C,B)))return}if(!O)return C.node;if(H===!0)return N;if(L=o(B,{obj:N,path:C.path.concat(O)}),!!L.node)return L.link}}function c(N){var O=this,P=e.link.is(O.link),C=O.env.graph;O.link=O.link||e.link.ify(N),O.link[e.link._]=N,O.node&&O.node[S._]&&(O.node[S._][e.link._]=N),k(C,P)&&(C[N]=C[P],f(C,P))}function T(N,O,P,C,B){var H;if(e.is(N))return!0;if(r(N))return 1;if(H=B.invalid)return N=H.call(B.as||{},N,O,P),T(N,O,P,C,B);B.err="Invalid value at '"+C.path.concat(O).join(".")+"'!",l.list.is(N)&&(B.err+=" Use `.set(item)` instead of an Array.")}function D(N,O){for(var P=N.seen,C=P.length,B;C--;)if(B=P[C],O.obj===B.obj)return B;P.push(O)}}(),x.node=function(o){t("graph.node");var n=S.soul(o);if(!!n)return j({},n,o)},function(){x.to=function(n,c,T){if(t("graph.to"),!!n){var D={};return T=T||{seen:{}},E(n[c],o,{obj:D,graph:n,opt:T}),D}};function o(n,c){var T,D;if(S._===c){if(m(n,e.link._))return;this.obj[c]=I(n);return}if(!(T=e.link.is(n))){this.obj[c]=n;return}if(D=this.opt.seen[T]){this.obj[c]=D;return}this.obj[c]=this.opt.seen[T]=x.to(this.graph,T,this.opt)}}();var y=l.fn.is,u=l.obj,r=u.is,f=u.del,k=u.has,m=u.empty,j=u.put,E=u.map,I=u.copy,G;l.graph=l.graph||x}}()}});Z();tt();var ht=Sn();const Tn="_App_sggzw_1",$n="_TestnetBankContainer_sggzw_51",Pt={App:Tn,TestnetBankContainer:$n},Gt=X('<input type="text">'),An=X('<table><tbody><tr><td><a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">https://github.com/fc1943s/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">https://fc1943s.github.io/tictactoe_spiral</a></td></tr><tr><td><a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">https://fc1943s.github.io/tictactoe_spiral/docs</a></td></tr></tbody></table>'),kn=X("<table><tbody><tr><td>Token</td><td></td></tr><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),wn=X("<table><tbody></tbody></table>"),On=X("<tr><td></td><td><table><tbody><tr><td>Address</td><td></td></tr><tr><td>Private Key</td><td></td></tr></tbody></table></td></tr>"),xn=X("<div><button>Load</button></div>"),En=X("<div><button></button></div>"),jn=X('<iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700"></iframe>'),Nn=X("<table><tbody><tr><td>URL</td><td></td></tr><tr><td>Port</td><td></td></tr></tbody></table>"),bt=X("<div><button>Request</button><button>Clear</button><pre></pre></div>"),Rn=X("<div><table><tbody><tr><td>Links</td><td></td></tr><tr><td></td></tr><tr><td>Chain Connection</td><td></td></tr><tr><td>Accounts</td><td></td></tr><tr><td>Testnet Bank Dispenser</td><td></td></tr><tr><td></td></tr><tr><td>Database Connection</td><td></td></tr><tr><td></td></tr><tr><td>Counter</td><td></td></tr><tr><td></td></tr><tr><td>Status</td><td></td></tr><tr><td>Deploy</td><td></td></tr></tbody></table></div>"),Dn=ht.__esModule?ht.default:ht,W="app",it={DEPLOYMENT_BASEPATH:"/opt/runner",DOTNET_NOLOGO:"1",USER:"runner",npm_config_user_agent:"bun/0.1.4 npm/? node/v16.14.0 linux x64",CI:"true",GITHUB_ENV:"/home/runner/work/_temp/_runner_file_commands/set_env_fdc5ea03-ae00-4c8f-bd47-843f5007a84d",PIPX_HOME:"/opt/pipx",BUN_INSTALL:"~/.bun",npm_node_execpath:"/opt/hostedtoolcache/node/16.16.0/x64/bin/node",JAVA_HOME_8_X64:"/usr/lib/jvm/temurin-8-jdk-amd64",SHLVL:"1",HOME:"/home/runner",OLDPWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",RUNNER_TEMP:"/home/runner/work/_temp",GITHUB_EVENT_PATH:"/home/runner/work/_temp/_github_workflow/event.json",npm_package_json:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/package.json",JAVA_HOME_11_X64:"/usr/lib/jvm/temurin-11-jdk-amd64",PIPX_BIN_DIR:"/opt/pipx_bin",GRAALVM_11_ROOT:"/usr/local/graalvm/graalvm-ce-java11-22.1.0",GITHUB_REPOSITORY_OWNER:"fc1943s",GRADLE_HOME:"/usr/share/gradle-7.4.2",HOMEBREW_PREFIX:"/home/linuxbrew/.linuxbrew",ANDROID_NDK_LATEST_HOME:"/usr/local/lib/android/sdk/ndk/24.0.8215888",GITHUB_RETENTION_DAYS:"90",npm_config_local_prefix:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/",POWERSHELL_DISTRIBUTION_CHANNEL:"GitHub-Actions-ubuntu20",AZURE_EXTENSION_DIR:"/opt/az/azcliextensions",GITHUB_HEAD_REF:"=",GITHUB_GRAPHQL_URL:"https://api.github.com/graphql",NVM_DIR:"/home/runner/.nvm",DOTNET_SKIP_FIRST_TIME_EXPERIENCE:"1",JAVA_HOME_17_X64:"/usr/lib/jvm/temurin-17-jdk-amd64",ImageVersion:"20220710.1",RUNNER_OS:"Linux",GITHUB_API_URL:"https://api.github.com",SWIFT_PATH:"/usr/share/swift/usr/bin",_:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin/vite",RUNNER_USER:"runner",CHROMEWEBDRIVER:"/usr/local/share/chrome_driver",JOURNAL_STREAM:"8:22742",GITHUB_WORKFLOW:"E2E + A11y Tests",GITHUB_RUN_ID:"2674522796",GOROOT_1_16_X64:"/opt/hostedtoolcache/go/1.16.15/x64",GOROOT_1_17_X64:"/opt/hostedtoolcache/go/1.17.11/x64",GITHUB_REF_TYPE:"branch",BOOTSTRAP_HASKELL_NONINTERACTIVE:"1",GITHUB_BASE_REF:"=",ImageOS:"ubuntu20",PERFLOG_LOCATION_SETTING:"RUNNER_PERFLOG",GOROOT_1_18_X64:"/opt/hostedtoolcache/go/1.18.3/x64",GITHUB_ACTION_REPOSITORY:"=",PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.bin:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules/.bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.16.0/x64/bin:~/.bun/bin:/home/runner/setup-pnpm/node_modules/.bin:/opt/hostedtoolcache/node/16.16.0/x64/bin:/home/linuxbrew/.linuxbrew/bin:/home/linuxbrew/.linuxbrew/sbin:/home/runner/.local/bin:/opt/pipx_bin:/home/runner/.cargo/bin:/home/runner/.config/composer/vendor/bin:/usr/local/.ghcup/bin:/home/runner/.dotnet/tools:/snap/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin:/usr/games:/usr/local/games:/snap/bin",NODE:"/opt/hostedtoolcache/node/16.16.0/x64/bin/node",ANT_HOME:"/usr/share/ant",DOTNET_MULTILEVEL_LOOKUP:"0",RUNNER_TRACKING_ID:"github_7e844a6d-98d9-41c2-91f1-723e0114db21",INVOCATION_ID:"a78bfde2bdf544eeb6cfd25d504ad680",npm_package_name:"tictactoe_spiral_web",HOMEBREW_CELLAR:"/home/linuxbrew/.linuxbrew/Cellar",RUNNER_TOOL_CACHE:"/opt/hostedtoolcache",GITHUB_ACTION:"__run_7",GITHUB_RUN_NUMBER:"19",RUNNER_ARCH:"X64",XDG_RUNTIME_DIR:"/run/user/1001",AGENT_TOOLSDIRECTORY:"/opt/hostedtoolcache",LANG:"C.UTF-8",VCPKG_INSTALLATION_ROOT:"/usr/local/share/vcpkg",CONDA:"/usr/share/miniconda",RUNNER_NAME:"Hosted Agent",XDG_CONFIG_HOME:"/home/runner/.config",GITHUB_REF_NAME:"main",GITHUB_REPOSITORY:"fc1943s/tictactoe_spiral",ANDROID_NDK_ROOT:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_ACTION_REF:"=",DEBIAN_FRONTEND:"noninteractive",GITHUB_ACTIONS:"true",STATS_KEEPALIVE:"false",npm_package_version:"0.0.1",STATS_PFS:"true",NODE_PATH:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules/vite/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/vite@3.0.0-beta.6/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/.pnpm/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/node_modules:/home/runner/work/tictactoe_spiral/node_modules:/home/runner/work/node_modules:/home/runner/node_modules:/home/node_modules:/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/bin/node_modules:/home/runner/work/tictactoe_spiral/tictactoe_spiral/web/node_modules/vite/node_modules",GITHUB_REF_PROTECTED:"false",GITHUB_WORKSPACE:"/home/runner/work/tictactoe_spiral/tictactoe_spiral",ACCEPT_EULA:"Y",GITHUB_JOB:"build",RUNNER_PERFLOG:"/home/runner/perflog",GITHUB_SHA:"658da84a27e1d2f7bac197c987728c1799c6c231",GITHUB_RUN_ATTEMPT:"1",GITHUB_REF:"refs/heads/main",GITHUB_ACTOR:"fc1943s",ANDROID_SDK_ROOT:"/usr/local/lib/android/sdk",LEIN_HOME:"/usr/local/lib/lein",GITHUB_PATH:"/home/runner/work/_temp/_runner_file_commands/add_path_fdc5ea03-ae00-4c8f-bd47-843f5007a84d",JAVA_HOME:"/usr/lib/jvm/temurin-11-jdk-amd64",PWD:"/home/runner/work/tictactoe_spiral/tictactoe_spiral/web",npm_execpath:"/home/runner/.bun/bin/bun",RUNNER_WORKSPACE:"/home/runner/work/tictactoe_spiral",HOMEBREW_CLEANUP_PERIODIC_FULL_DAYS:"3650",GITHUB_EVENT_NAME:"push",HOMEBREW_NO_AUTO_UPDATE:"1",ANDROID_HOME:"/usr/local/lib/android/sdk",GITHUB_SERVER_URL:"https://github.com",GECKOWEBDRIVER:"/usr/local/share/gecko_driver",LEIN_JAR:"/usr/local/lib/lein/self-installs/leiningen-2.9.8-standalone.jar",EDGEWEBDRIVER:"/usr/local/share/edge_driver",HOMEBREW_REPOSITORY:"/home/linuxbrew/.linuxbrew/Homebrew",SGX_AESM_ADDR:"1",CHROME_BIN:"/usr/bin/google-chrome",SELENIUM_JAR_PATH:"/usr/share/java/selenium-server.jar",PNPM_HOME:"/home/runner/setup-pnpm/node_modules/.bin",ANDROID_NDK_HOME:"/usr/local/lib/android/sdk/ndk-bundle",GITHUB_STEP_SUMMARY:"/home/runner/work/_temp/_runner_file_commands/step_summary_fdc5ea03-ae00-4c8f-bd47-843f5007a84d",NODE_ENV:"production"}.CODESPACE_NAME,Ct={token:cn,chainUrl:it?`http://${it}-4001.githubpreview.dev`:dn,chainPort:it?80:pn,dbUrl:it?`ws://${it}-8765.githubpreview.dev`:"ws://localhost",dbPort:it?80:8765,accounts:hn,status:[],deploy:[],gunRs:{},gunJs:{},counter:[]},Bt=(p,_="#888")=>(...t)=>{console.log("@@@ %c%s %c%s",`font-weight: bold; color: ${_}`,JSON.stringify(t),"font-weight: bold; color: #444",JSON.stringify(p()))},gt=Jt([p=>{p.on("@init",()=>Ct),p.on("set",(_,t)=>t)}]);function at({key:p}){const[_,t]=q();return(()=>{const l=Gt.cloneNode(!0);return l.$$input=$=>t("set",{[p]:$.currentTarget.value}),V(()=>l.value=_[p]),l})()}function In(){return An.cloneNode(!0)}function Pn(){return(()=>{const p=kn.cloneNode(!0),_=p.firstChild,t=_.firstChild,l=t.firstChild,$=l.nextSibling,e=t.nextSibling,a=e.firstChild,i=a.nextSibling,g=e.nextSibling,S=g.firstChild,b=S.nextSibling;return U($,J(at,{key:"token"})),U(i,J(at,{key:"chainUrl"})),U(b,J(at,{key:"chainPort"})),p})()}function Et({key:p,account:_}){const[t,l]=q();return(()=>{const $=Gt.cloneNode(!0);return $.$$input=e=>l("set",{accounts:t.accounts.map(a=>a.alias===_.alias?{...a,[p]:e.currentTarget.value}:a)}),V(()=>$.value=_[p]),$})()}function Gn(){const[p]=q();return(()=>{const _=wn.cloneNode(!0),t=_.firstChild;return U(t,J(Xt,{get each(){return p.accounts},children:l=>(()=>{const $=On.cloneNode(!0),e=$.firstChild,a=e.nextSibling,i=a.firstChild,g=i.firstChild,S=g.firstChild,b=S.firstChild,s=b.nextSibling,d=S.nextSibling,w=d.firstChild,R=w.nextSibling;return U(e,()=>l.alias),U(s,J(Et,{account:l,key:"address"})),U(R,J(Et,{account:l,key:"privateKey"})),$})()})),_})()}function Cn(){const[p,_]=dt(!1),[t,l]=dt(!1);return jt(Nt(()=>[t()],()=>t()&&l(!1))),ft((()=>{const $=ft(()=>!p(),!0);return()=>$()?(()=>{const e=xn.cloneNode(!0),a=e.firstChild;return a.$$click=()=>_(!0),e})():(()=>{const e=En.cloneNode(!0),a=e.firstChild;return a.$$click=()=>l(!0),U(a,J(vn,{size:"24px"})),U(e,(()=>{const i=ft(()=>!t(),!0);return()=>i()&&jn.cloneNode(!0)})(),null),V(()=>e.className=Pt.TestnetBankContainer),e})()})())}function Bn(){return(()=>{const p=Nn.cloneNode(!0),_=p.firstChild,t=_.firstChild,l=t.firstChild,$=l.nextSibling,e=t.nextSibling,a=e.firstChild,i=a.nextSibling;return U($,J(at,{key:"dbUrl"})),U(i,J(at,{key:"dbPort"})),p})()}function Hn(){const[p,_]=q(),l=Bt(()=>({gunRs:Object.keys(p.gunRs).length,gunJs:Object.keys(p.gunJs).length}),"#cf1100");l("GunListener()");const $=()=>{const a=`${p.dbUrl}:${p.dbPort}/gun`,i=p.gunRs[a]||new Kt(a);p.gunJs[a]||new Dn(a),_("set",{gunRs:{...p.gunRs,[a]:i},gunJs:p.gunJs})};let e=gt.on("@changed",(a,i)=>{l("GunListener.store.@changed",{changed:Object.keys(i)}),(i.dbUrl||i.dbPort)&&$()});return Rt(()=>e()),jt(Nt(()=>[],()=>{l("GunListener.createEffect() callback"),$()})),[]}function yt(p,_){const[t,l]=q(),[$,e]=dt({}),[a,i]=dt({}),g=()=>({key:p,[`state.${p}.length`]:t[p].length,gunRs:Object.keys(t.gunRs).length,gunJs:Object.keys(t.gunJs).length,subscriptionRs:Object.values($()),subscriptionJs:Object.keys(a()).length}),b={...Object.keys(Ct).reduce((x,y)=>({...x,[y]:"#00cf2d"}),{}),status:"#cf6800",deploy:"#cccf00"},s=Bt(g,b[p]);s("useFetch()");let d=null;const w=(x,y)=>{s("useFetch.subscribe()");const u=k=>{let m=k;for(;typeof m=="string";)m=JSON.parse(m);return Array.isArray(m)?m:[m]},r=Object.entries(x).map(([k,m])=>{const j=m.get(W).get(p).on((E,I)=>{d&&clearInterval(d);const G=u(E);s("useFetch.subscribe _gunRs.on() callback",{k:I,subscription:j,length:G.length}),l("set",{[p]:G})});return s("useFetch.subscribe() gunRs",{subscription:j}),{url:k,subscription:j}});e({...$(),...r.reduce((k,{url:m,subscription:j})=>({...k,[m]:j}),{})});const f=Object.entries(y).map(([k,m])=>(m.get(W).get(p).on((j,E)=>{d&&clearInterval(d);const I=u(j);s("useFetch.subscribe _gunJs.on() callback",{k:E,length:I.length}),l("set",{[p]:I})}),s("useFetch.subscribe() gunJs"),k));i({...a(),...f.reduce((k,m)=>({...k,[m]:!0}),{})})},R=x=>{const y=$();Object.entries(y).forEach(([r,f])=>{s("useFetch.unsubscribe() subscriptionRs",{subscription:f});const k=x.gunRs[r];k&&k.get(W).get(p).off(f)}),e({});const u=a();Object.entries(u).forEach(([r,f])=>{s("useFetch.unsubscribe() subscriptionJs");const k=x.gunJs[r];k&&k.get(W).get(p).off()}),i({})};let h=gt.on("@changed",(x,y)=>{(y.gunRs||y.gunJs)&&(s("useFetch.store.@changed",{changed:Object.keys(y)}),d&&clearInterval(d),d=setInterval(()=>{s("useFetch.createEffect() callback setTimeout subscribe..."),R(x),w(y.gunRs,y.gunJs)},2e3))});return Rt(()=>{h(),R(t)}),{request:async()=>{s("useFetch.request()");const x=un(t.token,t.chainUrl,t.chainPort);let y;try{const u=await _(x);y=[...t[p],u]}catch(u){y=[...t[p],u]}l("set",{[p]:y}),Object.entries(t.gunRs).forEach(([u,r])=>{s("useFetch.request() gunRs"),r.get(W).get(p).put(y)}),Object.entries(t.gunJs).forEach(([u,r])=>{s("useFetch.request() gunJs"),r.get(W).get(p).put(y)})},clear:async()=>{s("useFetch.clear()"),l("set",{[p]:[]}),Object.entries(t.gunRs).forEach(([x,y])=>{s("useFetch.clear() gunRs"),y.get(W).get(p).put([])}),Object.entries(t.gunJs).forEach(([x,y])=>{s("useFetch.clear() gunJs"),y.get(W).get(p).put([])})}}}function Ln(){const[p,_]=q(),{request:t,clear:l}=yt("counter",async $=>p.counter.length);return(()=>{const $=bt.cloneNode(!0),e=$.firstChild,a=e.nextSibling,i=a.nextSibling;return Q(e,"click",t,!0),Q(a,"click",l,!0),U(i,()=>JSON.stringify(p.counter,null,2)),$})()}function Un(){const[p,_]=q(),{request:t,clear:l}=yt("status",$=>$.status().do());return(()=>{const $=bt.cloneNode(!0),e=$.firstChild,a=e.nextSibling,i=a.nextSibling;return Q(e,"click",t,!0),Q(a,"click",l,!0),U(i,()=>JSON.stringify(p.status,null,2)),$})()}function Mn(){const[p,_]=q(),{request:t,clear:l}=yt("deploy",async $=>{const e=p.accounts[0]?.address,a=p.accounts[0]?.privateKey;if(e&&a)try{return await ln($,e,a,_n,bn,{numGlobalByteSlices:sn,numGlobalInts:fn})}catch(i){return i}else return"Invalid admin account"});return(()=>{const $=bt.cloneNode(!0),e=$.firstChild,a=e.nextSibling,i=a.nextSibling;return Q(e,"click",t,!0),Q(a,"click",l,!0),U(i,()=>JSON.stringify(p.deploy,null,2)),$})()}function Vn(){return J(Ft,{store:gt,get children(){return[J(Hn,{}),(()=>{const p=Rn.cloneNode(!0),_=p.firstChild,t=_.firstChild,l=t.firstChild,$=l.firstChild,e=$.nextSibling,a=l.nextSibling,i=a.nextSibling,g=i.firstChild,S=g.nextSibling,b=i.nextSibling,s=b.firstChild,d=s.nextSibling,w=b.nextSibling,R=w.firstChild,h=R.nextSibling,A=w.nextSibling,v=A.nextSibling,x=v.firstChild,y=x.nextSibling,u=v.nextSibling,r=u.nextSibling,f=r.firstChild,k=f.nextSibling,m=r.nextSibling,j=m.nextSibling,E=j.firstChild,I=E.nextSibling,G=j.nextSibling,o=G.firstChild,n=o.nextSibling;return U(e,J(In,{})),U(S,J(Pn,{})),U(d,J(Gn,{})),U(h,J(Cn,{})),U(y,J(Bn,{})),U(k,J(Ln,{})),U(I,J(Un,{})),U(n,J(Mn,{})),V(()=>p.className=Pt.App),p})()]}})}Dt(["input","click"]);export{Vn as A,Kn as r};
