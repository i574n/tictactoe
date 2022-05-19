import pyteal
from pyteal import (TxnGroup, Gtxn)
from typing import (Tuple, List, Any, Callable)
from fable_modules.fable_library.string import (to_console, interpolate)

def method0() -> Tuple[str, str, str, str, str, str, str, str, str]:
    v0_1 : str = pyteal.Bytes("PlayerXState")
    v1_1 : str = pyteal.Bytes("PlayerOState")
    v2_1 : str = pyteal.Bytes("PlayerXAddress")
    v3_1 : str = pyteal.Bytes("PlayerOAddress")
    v4_1 : str = pyteal.Bytes("PlayerTurnAddress")
    v5 : str = pyteal.Bytes("FundsEscrowAddress")
    v6 : str = pyteal.Bytes("ActionTimeout")
    v7 : str = pyteal.Bytes("GameState")
    return (v6, pyteal.Bytes("BetAmount"), v5, v7, v3_1, v1_1, v4_1, v2_1, v0_1)


def closure0(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["app_initialization_logic"]))
    v1_1 : int = (pyteal.Int(0)) or 0
    v2_1 : int = (pyteal.Int(0)) or 0
    v3_1 : int = (pyteal.Int(0)) or 0
    v4_1 : int = (pyteal.Int(1000000)) or 0
    v5 : int = (pyteal.Int(3600)) or 0
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v15 : bool = pyteal.App.globalPut(pattern_input[8], v1_1)
    v16 : bool = pyteal.App.globalPut(pattern_input[5], v2_1)
    v17 : bool = pyteal.App.globalPut(pattern_input[3], v3_1)
    v18 : bool = pyteal.App.globalPut(pattern_input[1], v4_1)
    v19 : int = (pyteal.Int(1)) or 0
    v21 : List[bool] = [v15, v16, v17, v18, pyteal.Return(v19)]
    return pyteal.Seq(v21)


def closure1(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v10 : int = (pyteal.App.globalGet(pattern_input[8])) or 0
    v11 : int = (pyteal.App.globalGet(pattern_input[5])) or 0
    return (pyteal.Int(511)) == (pyteal.BitwiseOr(v10, v11))


def closure2(unit_var0: None, v0_1: int) -> bool:
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
    v34 : bool = pyteal.Or(v5, v9, v13, v17, v21, v25, v29, v33)
    v35 : int = (pyteal.Int(1)) or 0
    v36 : int = (pyteal.Int(0)) or 0
    return pyteal.If(v34, v35, v36)


def closure3(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["money_refund_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v8 : str = pattern_input[7]
    v7 : str = pattern_input[6]
    v5 : str = pattern_input[4]
    v4_1 : str = pattern_input[3]
    v3_1 : str = pattern_input[2]
    v2_1 : str = pattern_input[1]
    v1_1 : str = pattern_input[0]
    v12 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(1))
    v15 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(0))
    v18 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v1_1))
    v21 : bool = (pyteal.App.globalGet(v7)) == (pyteal.App.globalGet(v5))
    v22 : bool = pyteal.And(v15, v18, v21)
    v23 : bool = pyteal.Or(v12, v22)
    v26 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(2))
    v29 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(0))
    v32 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v1_1))
    v35 : bool = (pyteal.App.globalGet(v7)) == (pyteal.App.globalGet(v8))
    v36 : bool = pyteal.And(v29, v32, v35)
    v37 : bool = pyteal.Or(v26, v36)
    v38 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v41 : bool = (v38.receiver()) == (pyteal.App.globalGet(v8))
    v42 : bool = pyteal.Assert(v41)
    v43 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v48 : bool = (v43.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v2_1)))
    v49 : bool = pyteal.Assert(v48)
    v50 : int = (pyteal.Int(1)) or 0
    v52 : List[bool] = [v42, v49, pyteal.App.globalPut(v4_1, v50)]
    v53 : bool = pyteal.Seq(v52)
    v54 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v57 : bool = (v54.receiver()) == (pyteal.App.globalGet(v5))
    v58 : bool = pyteal.Assert(v57)
    v59 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v64 : bool = (v59.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v2_1)))
    v65 : bool = pyteal.Assert(v64)
    v66 : int = (pyteal.Int(2)) or 0
    v68 : List[bool] = [v58, v65, pyteal.App.globalPut(v4_1, v66)]
    v69 : bool = pyteal.Seq(v68)
    v72 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(3))
    v73 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v76 : bool = (v73.receiver()) == (pyteal.App.globalGet(v8))
    v77 : bool = pyteal.Assert(v76)
    v78 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v81 : bool = (v78.amount()) == (pyteal.App.globalGet(v2_1))
    v82 : bool = pyteal.Assert(v81)
    v83 : Any = TxnGroup.__getitem__(Gtxn, 2)
    v86 : bool = (v83.type_enum()) == pyteal.TxnType.Payment
    v87 : bool = pyteal.Assert(v86)
    v88 : Any = TxnGroup.__getitem__(Gtxn, 2)
    v91 : bool = (v88.sender()) == (pyteal.App.globalGet(v3_1))
    v92 : bool = pyteal.Assert(v91)
    v93 : Any = TxnGroup.__getitem__(Gtxn, 2)
    v96 : bool = (v93.receiver()) == (pyteal.App.globalGet(v5))
    v97 : bool = pyteal.Assert(v96)
    v98 : Any = TxnGroup.__getitem__(Gtxn, 2)
    v101 : bool = (v98.amount()) == (pyteal.App.globalGet(v2_1))
    v103 : List[bool] = [v77, v82, v87, v92, v97, pyteal.Assert(v101)]
    v104 : bool = pyteal.Seq(v103)
    v105 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v108 : bool = (v105.type_enum()) == pyteal.TxnType.Payment
    v109 : bool = pyteal.Assert(v108)
    v110 : Any = TxnGroup.__getitem__(Gtxn, 1)
    v113 : bool = (v110.sender()) == (pyteal.App.globalGet(v3_1))
    v114 : bool = pyteal.Assert(v113)
    v115 : List[bool] = [v23, v53]
    v116 : List[bool] = [v37, v69]
    v117 : List[bool] = [v72, v104]
    v118 : bool = pyteal.Cond(v115, v116, v117)
    v119 : int = (pyteal.Int(1)) or 0
    v121 : List[bool] = [v109, v114, v118, pyteal.Return(v119)]
    return pyteal.Seq(v121)


v0 : str = "main.spi Loaded"

to_console(interpolate("%A%P()", [v0]))

def arrow_0(__unit: Any=None) -> bool:
    return closure0(None, None)


v1 : Callable[[], bool] = arrow_0

def arrow_1(__unit: Any=None) -> bool:
    return closure1(None, None)


v2 : Callable[[], bool] = arrow_1

def arrow_2(v0_1: int) -> bool:
    return closure2(None, v0_1)


v3 : Callable[[int], bool] = arrow_2

def arrow_3(__unit: Any=None) -> bool:
    return closure3(None, None)


v4 : Callable[[], bool] = arrow_3

