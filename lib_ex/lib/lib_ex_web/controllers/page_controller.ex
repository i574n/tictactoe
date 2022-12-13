defmodule LibExWeb.PageController do
  use LibExWeb, :controller

  def index(conn, _params) do
    render(conn, "index.html")
  end
end
