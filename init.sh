curl https://bun.sh/install | bash
export BUN_INSTALL="$HOME/.bun"
export PATH="$BUN_INSTALL/bin:$PATH"
echo "export BUN_INSTALL=\"\$HOME/.bun\"" >> ~/.bashrc
echo "export PATH=\"\$BUN_INSTALL/bin:\$PATH\"" >> ~/.bashrc

curl https://sh.rustup.rs -sSf | sh
export PATH="$HOME/.cargo/bin:$PATH"
echo "export PATH=\"\$HOME/.cargo/bin:\$PATH\"" >> ~/.bashrc
cargo install rod

dotnet tool restore
curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 3.1.100

pip install -r requirements.txt

npm install -g pnpm

cd web && bun run playwright-install
