import pyteal
from pyteal import Gtxn
from typing import (Tuple, List, Any, Callable)
from fable_modules.fable_library.string import (to_console, interpolate)

def method0() -> Tuple[str, str, str, str, str, str, str, str, str]:
    v0_1 : str = pyteal.Bytes("PlayerXState")
    v1_1 : str = pyteal.Bytes("PlayerOState")
    v2_1 : str = pyteal.Bytes("PlayerXAddress")
    v3_1 : str = pyteal.Bytes("PlayerOAddress")
    v4_1 : str = pyteal.Bytes("PlayerTurnAddress")
    v5_1 : str = pyteal.Bytes("FundsEscrowAddress")
    v6 : str = pyteal.Bytes("ActionTimeout")
    v7 : str = pyteal.Bytes("GameState")
    return (v6, pyteal.Bytes("BetAmount"), v5_1, v7, v3_1, v1_1, v4_1, v2_1, v0_1)


def closure0(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["app_initialization_logic"]))
    v1_1 : int = (pyteal.Int(0)) or 0
    v2_1 : int = (pyteal.Int(0)) or 0
    v3_1 : int = (pyteal.Int(0)) or 0
    v4_1 : int = (pyteal.Int(1000000)) or 0
    v5_1 : int = (pyteal.Int(3600)) or 0
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
    v5_1 : bool = (pyteal.BitwiseAnd(v0_1, v2_1)) == (pyteal.Int(448))
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
    v34 : bool = pyteal.Or(v5_1, v9, v13, v17, v21, v25, v29, v33)
    v35 : int = (pyteal.Int(1)) or 0
    v36 : int = (pyteal.Int(0)) or 0
    return pyteal.If(v34, v35, v36)


def closure3(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["money_refund_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v8 : str = pattern_input[7]
    v7 : str = pattern_input[6]
    v5_1 : str = pattern_input[4]
    v4_1 : str = pattern_input[3]
    v3_1 : str = pattern_input[2]
    v2_1 : str = pattern_input[1]
    v1_1 : str = pattern_input[0]
    v12 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(1))
    v15 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(0))
    v18 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v1_1))
    v21 : bool = (pyteal.App.globalGet(v7)) == (pyteal.App.globalGet(v5_1))
    v22 : bool = pyteal.And(v15, v18, v21)
    v23 : bool = pyteal.Or(v12, v22)
    v24 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v27 : bool = (v24.receiver()) == (pyteal.App.globalGet(v8))
    v28 : bool = pyteal.Assert(v27)
    v29 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v34 : bool = (v29.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v2_1)))
    v35 : bool = pyteal.Assert(v34)
    v36 : int = (pyteal.Int(1)) or 0
    v38 : List[bool] = [v28, v35, pyteal.App.globalPut(v4_1, v36)]
    v39 : bool = pyteal.Seq(v38)
    v42 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(2))
    v45 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(0))
    v48 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v1_1))
    v51 : bool = (pyteal.App.globalGet(v7)) == (pyteal.App.globalGet(v8))
    v52 : bool = pyteal.And(v45, v48, v51)
    v53 : bool = pyteal.Or(v42, v52)
    v54 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v57 : bool = (v54.receiver()) == (pyteal.App.globalGet(v5_1))
    v58 : bool = pyteal.Assert(v57)
    v59 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v64 : bool = (v59.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v2_1)))
    v65 : bool = pyteal.Assert(v64)
    v66 : int = (pyteal.Int(2)) or 0
    v68 : List[bool] = [v58, v65, pyteal.App.globalPut(v4_1, v66)]
    v69 : bool = pyteal.Seq(v68)
    v72 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(3))
    v73 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v76 : bool = (v73.receiver()) == (pyteal.App.globalGet(v8))
    v77 : bool = pyteal.Assert(v76)
    v78 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v81 : bool = (v78.amount()) == (pyteal.App.globalGet(v2_1))
    v82 : bool = pyteal.Assert(v81)
    v83 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v86 : bool = (v83.type_enum()) == pyteal.TxnType.Payment
    v87 : bool = pyteal.Assert(v86)
    v88 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v91 : bool = (v88.sender()) == (pyteal.App.globalGet(v3_1))
    v92 : bool = pyteal.Assert(v91)
    v93 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v96 : bool = (v93.receiver()) == (pyteal.App.globalGet(v5_1))
    v97 : bool = pyteal.Assert(v96)
    v98 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v101 : bool = (v98.amount()) == (pyteal.App.globalGet(v2_1))
    v103 : List[bool] = [v77, v82, v87, v92, v97, pyteal.Assert(v101)]
    v104 : bool = pyteal.Seq(v103)
    v105 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v108 : bool = (v105.type_enum()) == pyteal.TxnType.Payment
    v109 : bool = pyteal.Assert(v108)
    v110 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v113 : bool = (v110.sender()) == (pyteal.App.globalGet(v3_1))
    v114 : bool = pyteal.Assert(v113)
    v115 : List[bool] = [v23, v39]
    v116 : List[bool] = [v53, v69]
    v117 : List[bool] = [v72, v104]
    v118 : bool = pyteal.Cond(v115, v116, v117)
    v119 : int = (pyteal.Int(1)) or 0
    v121 : List[bool] = [v109, v114, v118, pyteal.Return(v119)]
    return pyteal.Seq(v121)


def closure4(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["play_action_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v9 : str = pattern_input[8]
    v8 : str = pattern_input[7]
    v7 : str = pattern_input[6]
    v6 : str = pattern_input[5]
    v5_1 : str = pattern_input[4]
    v4_1 : str = pattern_input[3]
    v10 : int = (pyteal.Int(0)) or 0
    v11 : int = (pyteal.Int(0)) or 0
    v12 : int = (pyteal.Int(0)) or 0
    v13 : int = (pyteal.Int(1000000)) or 0
    v14 : int = (pyteal.Int(3600)) or 0
    v15 : int = pyteal.Txn.application_args[1] or 0
    v16 : int = (pyteal.Btoi(v15)) or 0
    v17 : int = (pyteal.App.globalGet(v9)) or 0
    v18 : int = (pyteal.App.globalGet(v6)) or 0
    v19 : int = (pyteal.Int(1)) or 0
    v20 : int = (pyteal.ShiftLeft(v19, v16)) or 0
    v21 : int = (pyteal.BitwiseOr(v17, v20)) or 0
    v22 : bool = pyteal.App.globalPut(v9, v21)
    v23 : int = (pyteal.App.globalGet(v9)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v25 : int = (pyteal.Int(448)) or 0
    v28 : bool = (pyteal.BitwiseAnd(v23, v25)) == (pyteal.Int(448))
    v29 : int = (pyteal.Int(56)) or 0
    v32 : bool = (pyteal.BitwiseAnd(v23, v29)) == (pyteal.Int(56))
    v33 : int = (pyteal.Int(7)) or 0
    v36 : bool = (pyteal.BitwiseAnd(v23, v33)) == (pyteal.Int(7))
    v37 : int = (pyteal.Int(292)) or 0
    v40 : bool = (pyteal.BitwiseAnd(v23, v37)) == (pyteal.Int(292))
    v41 : int = (pyteal.Int(146)) or 0
    v44 : bool = (pyteal.BitwiseAnd(v23, v41)) == (pyteal.Int(146))
    v45 : int = (pyteal.Int(73)) or 0
    v48 : bool = (pyteal.BitwiseAnd(v23, v45)) == (pyteal.Int(73))
    v49 : int = (pyteal.Int(273)) or 0
    v52 : bool = (pyteal.BitwiseAnd(v23, v49)) == (pyteal.Int(273))
    v53 : int = (pyteal.Int(84)) or 0
    v56 : bool = (pyteal.BitwiseAnd(v23, v53)) == (pyteal.Int(84))
    v57 : bool = pyteal.Or(v28, v32, v36, v40, v44, v48, v52, v56)
    v58 : int = (pyteal.Int(1)) or 0
    v59 : int = (pyteal.Int(0)) or 0
    v60 : bool = pyteal.If(v57, v58, v59)
    v61 : int = (pyteal.Int(1)) or 0
    v62 : bool = pyteal.App.globalPut(v4_1, v61)
    v63 : bool = pyteal.If(v60, v62)
    v64 : int = (pyteal.App.globalGet(v5_1)) or 0
    v66 : List[bool] = [v22, v63, pyteal.App.globalPut(v7, v64)]
    v67 : bool = pyteal.Seq(v66)
    v68 : int = (pyteal.BitwiseOr(v18, v20)) or 0
    v69 : bool = pyteal.App.globalPut(v6, v68)
    v70 : int = (pyteal.App.globalGet(v6)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v72 : int = (pyteal.Int(448)) or 0
    v75 : bool = (pyteal.BitwiseAnd(v70, v72)) == (pyteal.Int(448))
    v76 : int = (pyteal.Int(56)) or 0
    v79 : bool = (pyteal.BitwiseAnd(v70, v76)) == (pyteal.Int(56))
    v80 : int = (pyteal.Int(7)) or 0
    v83 : bool = (pyteal.BitwiseAnd(v70, v80)) == (pyteal.Int(7))
    v84 : int = (pyteal.Int(292)) or 0
    v87 : bool = (pyteal.BitwiseAnd(v70, v84)) == (pyteal.Int(292))
    v88 : int = (pyteal.Int(146)) or 0
    v91 : bool = (pyteal.BitwiseAnd(v70, v88)) == (pyteal.Int(146))
    v92 : int = (pyteal.Int(73)) or 0
    v95 : bool = (pyteal.BitwiseAnd(v70, v92)) == (pyteal.Int(73))
    v96 : int = (pyteal.Int(273)) or 0
    v99 : bool = (pyteal.BitwiseAnd(v70, v96)) == (pyteal.Int(273))
    v100 : int = (pyteal.Int(84)) or 0
    v103 : bool = (pyteal.BitwiseAnd(v70, v100)) == (pyteal.Int(84))
    v104 : bool = pyteal.Or(v75, v79, v83, v87, v91, v95, v99, v103)
    v105 : int = (pyteal.Int(1)) or 0
    v106 : int = (pyteal.Int(0)) or 0
    v107 : bool = pyteal.If(v104, v105, v106)
    v108 : int = (pyteal.Int(2)) or 0
    v109 : bool = pyteal.App.globalPut(v4_1, v108)
    v110 : bool = pyteal.If(v107, v109)
    v111 : int = (pyteal.App.globalGet(v8)) or 0
    v113 : List[bool] = [v69, v110, pyteal.App.globalPut(v7, v111)]
    v114 : bool = pyteal.Seq(v113)
    v116 : bool = v16 >= (pyteal.Int(0))
    v117 : bool = pyteal.Assert(v116)
    v119 : bool = v16 <= (pyteal.Int(8))
    v120 : bool = pyteal.Assert(v119)
    v123 : bool = (pyteal.Global.latest_timestamp()) <= (pyteal.App.globalGet(pattern_input[0]))
    v124 : bool = pyteal.Assert(v123)
    v126 : bool = (pyteal.App.globalGet(v4_1)) == v12
    v127 : bool = pyteal.Assert(v126)
    v130 : bool = (pyteal.Txn.sender()) == (pyteal.App.globalGet(v7))
    v131 : bool = pyteal.Assert(v130)
    v134 : bool = (pyteal.BitwiseAnd(v17, v20)) == (pyteal.Int(0))
    v137 : bool = (pyteal.BitwiseAnd(v18, v20)) == (pyteal.Int(0))
    v138 : bool = pyteal.And(v134, v137)
    v139 : bool = pyteal.Assert(v138)
    v143 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v8)), v67]
    v147 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v5_1)), v114]
    v148 : bool = pyteal.Cond(v143, v147)
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input_1 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v159 : int = (pyteal.App.globalGet(pattern_input_1[8])) or 0
    v160 : int = (pyteal.App.globalGet(pattern_input_1[5])) or 0
    v163 : bool = (pyteal.Int(511)) == (pyteal.BitwiseOr(v159, v160))
    v164 : int = (pyteal.Int(3)) or 0
    v165 : bool = pyteal.App.globalPut(v4_1, v164)
    v166 : bool = pyteal.If(v163, v165)
    v167 : int = (pyteal.Int(1)) or 0
    v169 : List[bool] = [v117, v120, v124, v127, v131, v139, v148, v166, pyteal.Return(v167)]
    return pyteal.Seq(v169)


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

def arrow_4(__unit: Any=None) -> bool:
    return closure4(None, None)


v5 : Callable[[], bool] = arrow_4

