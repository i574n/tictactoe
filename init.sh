curl https://bun.sh/install | bash
export BUN_INSTALL="$HOME/.bun"
export PATH="$BUN_INSTALL/bin:$PATH"
echo "export BUN_INSTALL=\"\$HOME/.bun\"" >> ~/.bashrc
echo "export PATH=\"\$BUN_INSTALL/bin:\$PATH\"" >> ~/.bashrc
npm install -g pnpm
sudo apt-get update
sudo apt-get install powershell
cd web && bun run playwright-install
cargo install rod

dotnet tool restore

pip install -r requirements.txt
