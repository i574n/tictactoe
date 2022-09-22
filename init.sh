dotnet tool restore
curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 3.1.100

pip install -r requirements.txt


curl https://get.volta.sh | bash
export VOLTA_HOME="$HOME/.volta"
echo "export VOLTA_HOME=\"\$HOME/.volta\"" >> ~/.bashrc
export PATH="$VOLTA_HOME/bin:$PATH"
echo "export PATH=\"\$VOLTA_HOME/bin:\$PATH\"" >> ~/.bashrc

volta install node@18
sudo rm -rf /usr/local/share/nvm

npm install -g pnpm

curl https://bun.sh/install | bash
export BUN_INSTALL="$HOME/.bun"
echo "export BUN_INSTALL=\"\$HOME/.bun\"" >> ~/.bashrc
export PATH="$BUN_INSTALL/bin:$PATH"
echo "export PATH=\"\$BUN_INSTALL/bin:\$PATH\"" >> ~/.bashrc

curl https://sh.rustup.rs -sSf | sh
export PATH="$HOME/.cargo/bin:$PATH"
echo "export PATH=\"\$HOME/.cargo/bin:\$PATH\"" >> ~/.bashrc
cargo install rod

pnpm install
cd peer && pnpm install && cd ..
cd web && pnpm install && cd ..
cd web && bun run playwright-install && cd ..
