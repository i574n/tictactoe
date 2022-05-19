import pyteal
from typing import (Tuple, Any, List, Callable)
from fable_modules.fable_library.string import (to_console, interpolate)

def method0() -> Tuple[str, str, str, str, str, str, str, str, str]:
    v0_1 : str = pyteal.Bytes("PlayerXState")
    v1_1 : str = pyteal.Bytes("PlayerOState")
    v2_1 : str = pyteal.Bytes("PlayerXAddress")
    v3_1 : str = pyteal.Bytes("PlayerOAddress")
    v4 : str = pyteal.Bytes("PlayerTurnAddress")
    v5 : str = pyteal.Bytes("FundsEscrowAddress")
    v6 : str = pyteal.Bytes("ActionTimeout")
    v7 : str = pyteal.Bytes("GameState")
    return (v6, pyteal.Bytes("BetAmount"), v5, v7, v3_1, v1_1, v4, v2_1, v0_1)


def closure0(unit_var0: None, unit_var1: None) -> Any:
    to_console(interpolate("%A%P()", ["app_initialization_logic"]))
    v1_1 : int = (pyteal.Int(0)) or 0
    v2_1 : int = (pyteal.Int(0)) or 0
    v3_1 : int = (pyteal.Int(0)) or 0
    v4 : int = (pyteal.Int(1000000)) or 0
    v5 : int = (pyteal.Int(3600)) or 0
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v15 : Any = pyteal.App.globalPut(pattern_input[8], v1_1)
    v16 : Any = pyteal.App.globalPut(pattern_input[5], v2_1)
    v17 : Any = pyteal.App.globalPut(pattern_input[3], v3_1)
    v18 : Any = pyteal.App.globalPut(pattern_input[1], v4)
    v19 : int = (pyteal.Int(1)) or 0
    v21 : List[Any] = [v15, v16, v17, v18, pyteal.Return(v19)]
    return pyteal.Seq(v21)


def closure1(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v10 : int = (pyteal.App.globalGet(pattern_input[8])) or 0
    v11 : int = (pyteal.App.globalGet(pattern_input[5])) or 0
    return (pyteal.Int(511)) == (pyteal.BitwiseOr(v10, v11))


def closure2(unit_var0: None, v0_1: int) -> Any:
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v2_1 : int = (pyteal.Int(448)) or 0
    v5 : bool = (pyteal.BitwiseAnd(v0_1, v2_1)) == (pyteal.Int(448))
    v6 : int = (pyteal.Int(56)) or 0
    v9 : bool = (pyteal.BitwiseAnd(v0_1, v6)) == (pyteal.Int(56))
    v10 : int = (pyteal.Int(7)) or 0
    v13 : bool = (pyteal.BitwiseAnd(v0_1, v10)) == (pyteal.Int(7))
    v14 : int = (pyteal.Int(292)) or 0
    v17 : bool = (pyteal.BitwiseAnd(v0_1, v14)) == (pyteal.Int(292))
    v18 : int = (pyteal.Int(146)) or 0
    v21 : bool = (pyteal.BitwiseAnd(v0_1, v18)) == (pyteal.Int(146))
    v22 : int = (pyteal.Int(73)) or 0
    v25 : bool = (pyteal.BitwiseAnd(v0_1, v22)) == (pyteal.Int(73))
    v26 : int = (pyteal.Int(273)) or 0
    v29 : bool = (pyteal.BitwiseAnd(v0_1, v26)) == (pyteal.Int(273))
    v30 : int = (pyteal.Int(84)) or 0
    v33 : bool = (pyteal.BitwiseAnd(v0_1, v30)) == (pyteal.Int(84))
    v34 : Any = pyteal.Or(v5, v9, v13, v17, v21, v25, v29, v33)
    v35 : int = (pyteal.Int(1)) or 0
    v36 : int = (pyteal.Int(0)) or 0
    return pyteal.If(v34, v35, v36)


v0 : str = "main.spi Loaded"

to_console(interpolate("%A%P()", [v0]))

def arrow_0(__unit: Any=None) -> Any:
    return closure0(None, None)


v1 : Callable[[], Any] = arrow_0

def arrow_1(__unit: Any=None) -> bool:
    return closure1(None, None)


v2 : Callable[[], bool] = arrow_1

def arrow_2(v0_1: int) -> Any:
    return closure2(None, v0_1)


v3 : Callable[[int], Any] = arrow_2

