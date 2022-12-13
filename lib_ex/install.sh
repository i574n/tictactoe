wget https://packages.erlang-solutions.com/erlang-solutions_2.0_all.deb
sudo dpkg -i erlang-solutions_2.0_all.deb
rm erlang-solutions_2.0_all.deb

sudo apt-get update
sudo apt-get install esl-erlang -y
sudo apt-get install elixir -y
sudo apt-get install inotify-tools -y
mix escript.install github livebook-dev/livebook
