const B={};function _(e){B.context=e}const ee=(e,t)=>e===t,pe=Symbol("solid-proxy"),te=Symbol("solid-track"),I={equals:ee};let G=X;const y=1,N=2,H={owned:null,cleanups:null,context:null,owner:null};var a=null;let d=null,o=null,p=null,g=null,D=0;function j(e,t){const s=o,n=a,r=e.length===0,u=r?H:{owned:null,cleanups:null,context:null,owner:t||n},i=r?e:()=>e(()=>S(()=>$(u)));a=u,o=null;try{return E(i,!0)}finally{o=s,a=n}}function ne(e,t){t=t?Object.assign({},I,t):I;const s={value:e,observers:null,observerSlots:null,comparator:t.equals||void 0},n=r=>(typeof r=="function"&&(r=r(s.value)),W(s,r));return[Q.bind(s),n]}function se(e,t,s){const n=M(e,t,!1,y);T(n)}function he(e,t,s){G=Y;const n=M(e,t,!1,y);n.user=!0,g?g.push(n):T(n)}function F(e,t,s){s=s?Object.assign({},I,s):I;const n=M(e,t,!0,0);return n.observers=null,n.observerSlots=null,n.comparator=s.equals||void 0,T(n),Q.bind(n)}function ge(e){return E(e,!1)}function S(e){let t,s=o;return o=null,t=e(),o=s,t}function be(e,t,s){const n=Array.isArray(e);let r,u=s&&s.defer;return i=>{let c;if(n){c=Array(e.length);for(let f=0;f<e.length;f++)c[f]=e[f]()}else c=e();if(u){u=!1;return}const b=S(()=>t(c,r,i));return r=c,b}}function re(e){return a===null||(a.cleanups===null?a.cleanups=[e]:a.cleanups.push(e)),e}function we(){return o}function ve(e){const t=Symbol("context");return{id:t,Provider:ce(t),defaultValue:e}}function me(e){let t;return(t=J(a,e.id))!==void 0?t:e.defaultValue}function le(e){const t=F(e);return F(()=>P(t()))}function Q(){const e=d;if(this.sources&&(this.state||e))if(this.state===y||e)T(this);else{const t=p;p=null,E(()=>R(this),!1),p=t}if(o){const t=this.observers?this.observers.length:0;o.sources?(o.sources.push(this),o.sourceSlots.push(t)):(o.sources=[this],o.sourceSlots=[t]),this.observers?(this.observers.push(o),this.observerSlots.push(o.sources.length-1)):(this.observers=[o],this.observerSlots=[o.sources.length-1])}return this.value}function W(e,t,s){let n=e.value;return(!e.comparator||!e.comparator(n,t))&&(e.value=t,e.observers&&e.observers.length&&E(()=>{for(let r=0;r<e.observers.length;r+=1){const u=e.observers[r],i=d&&d.running;i&&d.disposed.has(u),(i&&!u.tState||!i&&!u.state)&&(u.pure?p.push(u):g.push(u),u.observers&&q(u)),i||(u.state=y)}if(p.length>1e6)throw p=[],new Error},!1)),t}function T(e){if(!e.fn)return;$(e);const t=a,s=o,n=D;o=a=e,ue(e,e.value,n),o=s,a=t}function ue(e,t,s){let n;try{n=e.fn(t)}catch(r){e.pure&&(e.state=y),z(r)}(!e.updatedAt||e.updatedAt<=s)&&(e.updatedAt&&"observers"in e?W(e,n):e.value=n,e.updatedAt=s)}function M(e,t,s,n=y,r){const u={fn:e,state:n,updatedAt:null,owned:null,sources:null,sourceSlots:null,cleanups:null,value:t,owner:a,context:null,pure:s};return a===null||a!==H&&(a.owned?a.owned.push(u):a.owned=[u]),u}function O(e){const t=d;if(e.state===0||t)return;if(e.state===N||t)return R(e);if(e.suspense&&S(e.suspense.inFallback))return e.suspense.effects.push(e);const s=[e];for(;(e=e.owner)&&(!e.updatedAt||e.updatedAt<D);)(e.state||t)&&s.push(e);for(let n=s.length-1;n>=0;n--)if(e=s[n],e.state===y||t)T(e);else if(e.state===N||t){const r=p;p=null,E(()=>R(e,s[0]),!1),p=r}}function E(e,t){if(p)return e();let s=!1;t||(p=[]),g?s=!0:g=[],D++;try{const n=e();return ie(s),n}catch(n){p||(g=null),z(n)}}function ie(e){if(p&&(X(p),p=null),e)return;const t=g;g=null,t.length&&E(()=>G(t),!1)}function X(e){for(let t=0;t<e.length;t++)O(e[t])}function Y(e){let t,s=0;for(t=0;t<e.length;t++){const n=e[t];n.user?e[s++]=n:O(n)}for(B.context&&_(),g=[],t=0;t<s;t++)O(e[t]);g.length&&Y(g)}function R(e,t){const s=d;e.state=0;for(let n=0;n<e.sources.length;n+=1){const r=e.sources[n];r.sources&&(r.state===y||s?r!==t&&O(r):(r.state===N||s)&&R(r,t))}}function q(e){const t=d;for(let s=0;s<e.observers.length;s+=1){const n=e.observers[s];(!n.state||t)&&(n.state=N,n.pure?p.push(n):g.push(n),n.observers&&q(n))}}function $(e){let t;if(e.sources)for(;e.sources.length;){const s=e.sources.pop(),n=e.sourceSlots.pop(),r=s.observers;if(r&&r.length){const u=r.pop(),i=s.observerSlots.pop();n<r.length&&(u.sourceSlots[i]=n,r[n]=u,s.observerSlots[n]=i)}}if(e.owned){for(t=0;t<e.owned.length;t++)$(e.owned[t]);e.owned=null}if(e.cleanups){for(t=0;t<e.cleanups.length;t++)e.cleanups[t]();e.cleanups=null}e.state=0,e.context=null}function oe(e){return e instanceof Error||typeof e=="string"?e:new Error("Unknown error")}function z(e){throw e=oe(e),e}function J(e,t){return e?e.context&&e.context[t]!==void 0?e.context[t]:J(e.owner,t):void 0}function P(e){if(typeof e=="function"&&!e.length)return P(e());if(Array.isArray(e)){const t=[];for(let s=0;s<e.length;s++){const n=P(e[s]);Array.isArray(n)?t.push.apply(t,n):t.push(n)}return t}return e}function ce(e){return function(s){let n;return se(()=>n=S(()=>(a.context={[e]:s.value},le(()=>s.children)))),n}}const ae=Symbol("fallback");function V(e){for(let t=0;t<e.length;t++)e[t]()}function fe(e,t,s={}){let n=[],r=[],u=[],i=0,c=t.length>1?[]:null;return re(()=>V(u)),()=>{let b=e()||[],f,l;return b[te],S(()=>{let h=b.length,A,C,k,L,U,w,v,m,x;if(h===0)i!==0&&(V(u),u=[],n=[],r=[],i=0,c&&(c=[])),s.fallback&&(n=[ae],r[0]=j(Z=>(u[0]=Z,s.fallback())),i=1);else if(i===0){for(r=new Array(h),l=0;l<h;l++)n[l]=b[l],r[l]=j(K);i=h}else{for(k=new Array(h),L=new Array(h),c&&(U=new Array(h)),w=0,v=Math.min(i,h);w<v&&n[w]===b[w];w++);for(v=i-1,m=h-1;v>=w&&m>=w&&n[v]===b[m];v--,m--)k[m]=r[v],L[m]=u[v],c&&(U[m]=c[v]);for(A=new Map,C=new Array(m+1),l=m;l>=w;l--)x=b[l],f=A.get(x),C[l]=f===void 0?-1:f,A.set(x,l);for(f=w;f<=v;f++)x=n[f],l=A.get(x),l!==void 0&&l!==-1?(k[l]=r[f],L[l]=u[f],c&&(U[l]=c[f]),l=C[l],A.set(x,l)):u[f]();for(l=w;l<h;l++)l in k?(r[l]=k[l],u[l]=L[l],c&&(c[l]=U[l],c[l](l))):r[l]=j(K);r=r.slice(0,i=h),n=b.slice(0)}return r});function K(h){if(u[l]=h,c){const[A,C]=ne(l);return c[l]=C,t(b[l],A)}return t(b[l])}}}function ye(e,t){return S(()=>e(t||{}))}function Ae(e){const t="fallback"in e&&{fallback:()=>e.fallback};return F(fe(()=>e.each,e.children,t||void 0))}export{pe as $,Ae as F,se as a,F as b,j as c,ge as d,te as e,ne as f,we as g,ye as h,ve as i,he as j,be as k,re as o,B as s,me as u};
