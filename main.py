from pyteal import (Int, Bytes, App, Return, Seq)
from typing import (Callable, Any, List)
from fable_modules.fable_library.string import (to_console, interpolate)

def method0(v0_1: int) -> int:
    v1_1 : Callable[[int], int] = Int
    return v1_1(v0_1)


def method1(v0_1: str) -> str:
    v1_1 : Callable[[str], str] = Bytes
    return v1_1(v0_1)


def method2(v0_1: str, v1_1: int) -> Any:
    return App.globalPut(v0_1, v1_1)


def method3(v0_1: int) -> Any:
    v1_1 : Callable[[int], Any] = Return
    return v1_1(v0_1)


def method4(v0_1: List[Any]) -> Any:
    v1_1 : Callable[[List[Any]], Any] = Seq
    return v1_1(v0_1)


def closure0(unit_var0: None, unit_var1: None) -> Any:
    v1_1 : int = method0(0) or 0
    v3 : int = method0(0) or 0
    v5 : int = method0(0) or 0
    v7 : int = method0(1000000) or 0
    v9 : int = method0(3600) or 0
    v11 : str = method1("PlayerXState")
    v13 : str = method1("PlayerOState")
    v15 : str = method1("PlayerXAddress")
    v17 : str = method1("PlayerOAddress")
    v19 : str = method1("PlayerTurnAddress")
    v21 : str = method1("FundsEscrowAddress")
    v23 : str = method1("ActionTimeout")
    v25 : str = method1("GameState")
    v27 : str = method1("BetAmount")
    return method4([method2(v11, v1_1), method2(v13, v3), method2(v25, v5), method2(v27, v7), method3(method0(1))])


v0 : str = "main.spi Loaded"

to_console(interpolate("%A%P()", [v0]))

def arrow_0(__unit: Any=None) -> Any:
    return closure0(None, None)


v1 : Callable[[], Any] = arrow_0

