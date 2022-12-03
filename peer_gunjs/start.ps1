[System.IO.Directory]::CreateDirectory('ssl')
bun mkcert create-ca --cert=./ssl/ca.pem --key=./ssl/ca-key.pem
bun mkcert create-cert --ca-cert=./ssl/ca.pem --ca-key=./ssl/ca-key.pem --cert=./ssl/$env:PEER_DOMAIN.pem --key=./ssl/$env:PEER_DOMAIN-key.pem --domains $env:PEER_DOMAIN

$env:NODE_NO_WARNINGS=1
node --loader ts-node/esm server.ts
