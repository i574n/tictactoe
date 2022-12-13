defmodule LibEx.Repo do
  use Ecto.Repo,
    otp_app: :lib_ex,
    adapter: Ecto.Adapters.Postgres
end
