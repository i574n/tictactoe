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
    v6_1 : str = pyteal.Bytes("ActionTimeout")
    v7_1 : str = pyteal.Bytes("GameState")
    return (v6_1, pyteal.Bytes("BetAmount"), v5_1, v7_1, v3_1, v1_1, v4_1, v2_1, v0_1)


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
    v6_1 : int = (pyteal.Int(56)) or 0
    v9 : bool = (pyteal.BitwiseAnd(v0_1, v6_1)) == (pyteal.Int(56))
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
    v8_1 : str = pattern_input[7]
    v7_1 : str = pattern_input[6]
    v5_1 : str = pattern_input[4]
    v4_1 : str = pattern_input[3]
    v3_1 : str = pattern_input[2]
    v2_1 : str = pattern_input[1]
    v1_1 : str = pattern_input[0]
    v12 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(1))
    v15 : bool = (pyteal.App.globalGet(v4_1)) == (pyteal.Int(0))
    v18 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v1_1))
    v21 : bool = (pyteal.App.globalGet(v7_1)) == (pyteal.App.globalGet(v5_1))
    v22 : bool = pyteal.And(v15, v18, v21)
    v23 : bool = pyteal.Or(v12, v22)
    v24 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v27 : bool = (v24.receiver()) == (pyteal.App.globalGet(v8_1))
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
    v51 : bool = (pyteal.App.globalGet(v7_1)) == (pyteal.App.globalGet(v8_1))
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
    v76 : bool = (v73.receiver()) == (pyteal.App.globalGet(v8_1))
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
    v8_1 : str = pattern_input[7]
    v7_1 : str = pattern_input[6]
    v6_1 : str = pattern_input[5]
    v5_1 : str = pattern_input[4]
    v4_1 : str = pattern_input[3]
    v10 : int = (pyteal.Int(0)) or 0
    v11 : int = (pyteal.Int(0)) or 0
    v12 : int = (pyteal.Int(0)) or 0
    v13 : int = (pyteal.Int(1000000)) or 0
    v14 : int = (pyteal.Int(3600)) or 0
    v15 : str = pyteal.Txn.application_args[1]
    v16 : int = (pyteal.Btoi(v15)) or 0
    v17 : int = (pyteal.App.globalGet(v9)) or 0
    v18 : int = (pyteal.App.globalGet(v6_1)) or 0
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
    v66 : List[bool] = [v22, v63, pyteal.App.globalPut(v7_1, v64)]
    v67 : bool = pyteal.Seq(v66)
    v68 : int = (pyteal.BitwiseOr(v18, v20)) or 0
    v69 : bool = pyteal.App.globalPut(v6_1, v68)
    v70 : int = (pyteal.App.globalGet(v6_1)) or 0
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
    v111 : int = (pyteal.App.globalGet(v8_1)) or 0
    v113 : List[bool] = [v69, v110, pyteal.App.globalPut(v7_1, v111)]
    v114 : bool = pyteal.Seq(v113)
    v116 : bool = v16 >= (pyteal.Int(0))
    v117 : bool = pyteal.Assert(v116)
    v119 : bool = v16 <= (pyteal.Int(8))
    v120 : bool = pyteal.Assert(v119)
    v123 : bool = (pyteal.Global.latest_timestamp()) <= (pyteal.App.globalGet(pattern_input[0]))
    v124 : bool = pyteal.Assert(v123)
    v126 : bool = (pyteal.App.globalGet(v4_1)) == v12
    v127 : bool = pyteal.Assert(v126)
    v130 : bool = (pyteal.Txn.sender()) == (pyteal.App.globalGet(v7_1))
    v131 : bool = pyteal.Assert(v130)
    v134 : bool = (pyteal.BitwiseAnd(v17, v20)) == (pyteal.Int(0))
    v137 : bool = (pyteal.BitwiseAnd(v18, v20)) == (pyteal.Int(0))
    v138 : bool = pyteal.And(v134, v137)
    v139 : bool = pyteal.Assert(v138)
    v143 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v8_1)), v67]
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


def closure5(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["initialize_players_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v8_1 : str = pattern_input[7]
    v5_1 : str = pattern_input[4]
    v2_1 : str = pattern_input[1]
    v10 : int = (pyteal.Int(0)) or 0
    v11 : int = (pyteal.Int(0)) or 0
    v12 : int = (pyteal.Int(0)) or 0
    v13 : int = (pyteal.Int(1000000)) or 0
    v14 : int = (pyteal.Int(3600)) or 0
    v15 : int = (pyteal.Int(0)) or 0
    v16 : int = (pyteal.App.globalGetEx(v15, v8_1)) or 0
    v17 : int = (pyteal.Int(0)) or 0
    v18 : int = (pyteal.App.globalGetEx(v17, v5_1)) or 0
    v19 : int = (pyteal.Int(0)) or 0
    v21 : List[bool] = [pyteal.Return(v19)]
    v22 : bool = pyteal.Seq(v21)
    v23 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v26 : bool = (v23.type_enum()) == pyteal.TxnType.Payment
    v27 : bool = pyteal.Assert(v26)
    v28 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v31 : bool = (v28.type_enum()) == pyteal.TxnType.Payment
    v32 : bool = pyteal.Assert(v31)
    v33 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v34 : int = (v33.receiver()) or 0
    v35 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v37 : bool = v34 == (v35.receiver())
    v38 : bool = pyteal.Assert(v37)
    v39 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v42 : bool = (v39.amount()) == (pyteal.App.globalGet(v2_1))
    v43 : bool = pyteal.Assert(v42)
    v44 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v47 : bool = (v44.amount()) == (pyteal.App.globalGet(v2_1))
    v48 : bool = pyteal.Assert(v47)
    v49 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v50 : int = (v49.sender()) or 0
    v51 : bool = pyteal.App.globalPut(v8_1, v50)
    v52 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v53 : int = (v52.sender()) or 0
    v54 : bool = pyteal.App.globalPut(v5_1, v53)
    v55 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v56 : int = (v55.sender()) or 0
    v57 : bool = pyteal.App.globalPut(pattern_input[6], v56)
    v58 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v59 : int = (v58.receiver()) or 0
    v60 : bool = pyteal.App.globalPut(pattern_input[2], v59)
    v62 : int = ((pyteal.Global.latest_timestamp()) + v14) or 0
    v63 : bool = pyteal.App.globalPut(pattern_input[0], v62)
    v64 : int = (pyteal.Int(1)) or 0
    v66 : List[bool] = [v27, v32, v38, v43, v48, v51, v54, v57, v60, v63, pyteal.Return(v64)]
    v67 : bool = pyteal.Seq(v66)
    v68 : bool = v16.hasValue()
    v69 : bool = v18.hasValue()
    v70 : bool = pyteal.Or(v68, v69)
    v71 : bool = pyteal.If(v70, v22, v67)
    return pyteal.Seq([v16, v18, v71])


def closure6(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["application_start"]))
    v1_1 : str = pyteal.Bytes("SetupPlayers")
    v2_1 : str = pyteal.Bytes("ActionMove")
    v3_1 : str = pyteal.Bytes("MoneyRefund")
    v6_1 : bool = (pyteal.Txn.application_id()) == (pyteal.Int(0))
    v8_1 : bool = pyteal.Txn.application_args[0] == v1_1
    to_console(interpolate("%A%P()", ["initialize_players_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v17 : str = pattern_input[7]
    v14 : str = pattern_input[4]
    v11 : str = pattern_input[1]
    v19 : int = (pyteal.Int(0)) or 0
    v20 : int = (pyteal.Int(0)) or 0
    v21 : int = (pyteal.Int(0)) or 0
    v22 : int = (pyteal.Int(1000000)) or 0
    v23 : int = (pyteal.Int(3600)) or 0
    v24 : int = (pyteal.Int(0)) or 0
    v25 : int = (pyteal.App.globalGetEx(v24, v17)) or 0
    v26 : int = (pyteal.Int(0)) or 0
    v27 : int = (pyteal.App.globalGetEx(v26, v14)) or 0
    v28 : int = (pyteal.Int(0)) or 0
    v30 : List[bool] = [pyteal.Return(v28)]
    v31 : bool = pyteal.Seq(v30)
    v32 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v35 : bool = (v32.type_enum()) == pyteal.TxnType.Payment
    v36 : bool = pyteal.Assert(v35)
    v37 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v40 : bool = (v37.type_enum()) == pyteal.TxnType.Payment
    v41 : bool = pyteal.Assert(v40)
    v42 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v43 : int = (v42.receiver()) or 0
    v44 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v46 : bool = v43 == (v44.receiver())
    v47 : bool = pyteal.Assert(v46)
    v48 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v51 : bool = (v48.amount()) == (pyteal.App.globalGet(v11))
    v52 : bool = pyteal.Assert(v51)
    v53 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v56 : bool = (v53.amount()) == (pyteal.App.globalGet(v11))
    v57 : bool = pyteal.Assert(v56)
    v58 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v59 : int = (v58.sender()) or 0
    v60 : bool = pyteal.App.globalPut(v17, v59)
    v61 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v62 : int = (v61.sender()) or 0
    v63 : bool = pyteal.App.globalPut(v14, v62)
    v64 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v65 : int = (v64.sender()) or 0
    v66 : bool = pyteal.App.globalPut(pattern_input[6], v65)
    v67 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v68 : int = (v67.receiver()) or 0
    v69 : bool = pyteal.App.globalPut(pattern_input[2], v68)
    v71 : int = ((pyteal.Global.latest_timestamp()) + v23) or 0
    v72 : bool = pyteal.App.globalPut(pattern_input[0], v71)
    v73 : int = (pyteal.Int(1)) or 0
    v75 : List[bool] = [v36, v41, v47, v52, v57, v60, v63, v66, v69, v72, pyteal.Return(v73)]
    v76 : bool = pyteal.Seq(v75)
    v77 : bool = v25.hasValue()
    v78 : bool = v27.hasValue()
    v79 : bool = pyteal.Or(v77, v78)
    v80 : bool = pyteal.If(v79, v31, v76)
    v82 : List[bool] = [v8_1, pyteal.Seq([v25, v27, v80])]
    v84 : bool = pyteal.Txn.application_args[0] == v2_1
    v87 : bool = (pyteal.Global.group_size()) == (pyteal.Int(1))
    v88 : bool = pyteal.And(v84, v87)
    to_console(interpolate("%A%P()", ["play_action_logic"]))
    pattern_input_1 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v98 : str = pattern_input_1[8]
    v97 : str = pattern_input_1[7]
    v96 : str = pattern_input_1[6]
    v95 : str = pattern_input_1[5]
    v94 : str = pattern_input_1[4]
    v93 : str = pattern_input_1[3]
    v99 : int = (pyteal.Int(0)) or 0
    v100 : int = (pyteal.Int(0)) or 0
    v101 : int = (pyteal.Int(0)) or 0
    v102 : int = (pyteal.Int(1000000)) or 0
    v103 : int = (pyteal.Int(3600)) or 0
    v104 : str = pyteal.Txn.application_args[1]
    v105 : int = (pyteal.Btoi(v104)) or 0
    v106 : int = (pyteal.App.globalGet(v98)) or 0
    v107 : int = (pyteal.App.globalGet(v95)) or 0
    v108 : int = (pyteal.Int(1)) or 0
    v109 : int = (pyteal.ShiftLeft(v108, v105)) or 0
    v110 : int = (pyteal.BitwiseOr(v106, v109)) or 0
    v111 : bool = pyteal.App.globalPut(v98, v110)
    v112 : int = (pyteal.App.globalGet(v98)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v114 : int = (pyteal.Int(448)) or 0
    v117 : bool = (pyteal.BitwiseAnd(v112, v114)) == (pyteal.Int(448))
    v118 : int = (pyteal.Int(56)) or 0
    v121 : bool = (pyteal.BitwiseAnd(v112, v118)) == (pyteal.Int(56))
    v122 : int = (pyteal.Int(7)) or 0
    v125 : bool = (pyteal.BitwiseAnd(v112, v122)) == (pyteal.Int(7))
    v126 : int = (pyteal.Int(292)) or 0
    v129 : bool = (pyteal.BitwiseAnd(v112, v126)) == (pyteal.Int(292))
    v130 : int = (pyteal.Int(146)) or 0
    v133 : bool = (pyteal.BitwiseAnd(v112, v130)) == (pyteal.Int(146))
    v134 : int = (pyteal.Int(73)) or 0
    v137 : bool = (pyteal.BitwiseAnd(v112, v134)) == (pyteal.Int(73))
    v138 : int = (pyteal.Int(273)) or 0
    v141 : bool = (pyteal.BitwiseAnd(v112, v138)) == (pyteal.Int(273))
    v142 : int = (pyteal.Int(84)) or 0
    v145 : bool = (pyteal.BitwiseAnd(v112, v142)) == (pyteal.Int(84))
    v146 : bool = pyteal.Or(v117, v121, v125, v129, v133, v137, v141, v145)
    v147 : int = (pyteal.Int(1)) or 0
    v148 : int = (pyteal.Int(0)) or 0
    v149 : bool = pyteal.If(v146, v147, v148)
    v150 : int = (pyteal.Int(1)) or 0
    v151 : bool = pyteal.App.globalPut(v93, v150)
    v152 : bool = pyteal.If(v149, v151)
    v153 : int = (pyteal.App.globalGet(v94)) or 0
    v155 : List[bool] = [v111, v152, pyteal.App.globalPut(v96, v153)]
    v156 : bool = pyteal.Seq(v155)
    v157 : int = (pyteal.BitwiseOr(v107, v109)) or 0
    v158 : bool = pyteal.App.globalPut(v95, v157)
    v159 : int = (pyteal.App.globalGet(v95)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v161 : int = (pyteal.Int(448)) or 0
    v164 : bool = (pyteal.BitwiseAnd(v159, v161)) == (pyteal.Int(448))
    v165 : int = (pyteal.Int(56)) or 0
    v168 : bool = (pyteal.BitwiseAnd(v159, v165)) == (pyteal.Int(56))
    v169 : int = (pyteal.Int(7)) or 0
    v172 : bool = (pyteal.BitwiseAnd(v159, v169)) == (pyteal.Int(7))
    v173 : int = (pyteal.Int(292)) or 0
    v176 : bool = (pyteal.BitwiseAnd(v159, v173)) == (pyteal.Int(292))
    v177 : int = (pyteal.Int(146)) or 0
    v180 : bool = (pyteal.BitwiseAnd(v159, v177)) == (pyteal.Int(146))
    v181 : int = (pyteal.Int(73)) or 0
    v184 : bool = (pyteal.BitwiseAnd(v159, v181)) == (pyteal.Int(73))
    v185 : int = (pyteal.Int(273)) or 0
    v188 : bool = (pyteal.BitwiseAnd(v159, v185)) == (pyteal.Int(273))
    v189 : int = (pyteal.Int(84)) or 0
    v192 : bool = (pyteal.BitwiseAnd(v159, v189)) == (pyteal.Int(84))
    v193 : bool = pyteal.Or(v164, v168, v172, v176, v180, v184, v188, v192)
    v194 : int = (pyteal.Int(1)) or 0
    v195 : int = (pyteal.Int(0)) or 0
    v196 : bool = pyteal.If(v193, v194, v195)
    v197 : int = (pyteal.Int(2)) or 0
    v198 : bool = pyteal.App.globalPut(v93, v197)
    v199 : bool = pyteal.If(v196, v198)
    v200 : int = (pyteal.App.globalGet(v97)) or 0
    v202 : List[bool] = [v158, v199, pyteal.App.globalPut(v96, v200)]
    v203 : bool = pyteal.Seq(v202)
    v205 : bool = v105 >= (pyteal.Int(0))
    v206 : bool = pyteal.Assert(v205)
    v208 : bool = v105 <= (pyteal.Int(8))
    v209 : bool = pyteal.Assert(v208)
    v212 : bool = (pyteal.Global.latest_timestamp()) <= (pyteal.App.globalGet(pattern_input_1[0]))
    v213 : bool = pyteal.Assert(v212)
    v215 : bool = (pyteal.App.globalGet(v93)) == v101
    v216 : bool = pyteal.Assert(v215)
    v219 : bool = (pyteal.Txn.sender()) == (pyteal.App.globalGet(v96))
    v220 : bool = pyteal.Assert(v219)
    v223 : bool = (pyteal.BitwiseAnd(v106, v109)) == (pyteal.Int(0))
    v226 : bool = (pyteal.BitwiseAnd(v107, v109)) == (pyteal.Int(0))
    v227 : bool = pyteal.And(v223, v226)
    v228 : bool = pyteal.Assert(v227)
    v232 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v97)), v156]
    v236 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v94)), v203]
    v237 : bool = pyteal.Cond(v232, v236)
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input_2 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v248 : int = (pyteal.App.globalGet(pattern_input_2[8])) or 0
    v249 : int = (pyteal.App.globalGet(pattern_input_2[5])) or 0
    v252 : bool = (pyteal.Int(511)) == (pyteal.BitwiseOr(v248, v249))
    v253 : int = (pyteal.Int(3)) or 0
    v254 : bool = pyteal.App.globalPut(v93, v253)
    v255 : bool = pyteal.If(v252, v254)
    v256 : int = (pyteal.Int(1)) or 0
    v258 : List[bool] = [v206, v209, v213, v216, v220, v228, v237, v255, pyteal.Return(v256)]
    v260 : List[bool] = [v88, pyteal.Seq(v258)]
    v262 : bool = pyteal.Txn.application_args[0] == v3_1
    to_console(interpolate("%A%P()", ["money_refund_logic"]))
    pattern_input_3 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v271 : str = pattern_input_3[7]
    v270 : str = pattern_input_3[6]
    v268 : str = pattern_input_3[4]
    v267 : str = pattern_input_3[3]
    v266 : str = pattern_input_3[2]
    v265 : str = pattern_input_3[1]
    v264 : str = pattern_input_3[0]
    v275 : bool = (pyteal.App.globalGet(v267)) == (pyteal.Int(1))
    v278 : bool = (pyteal.App.globalGet(v267)) == (pyteal.Int(0))
    v281 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v264))
    v284 : bool = (pyteal.App.globalGet(v270)) == (pyteal.App.globalGet(v268))
    v285 : bool = pyteal.And(v278, v281, v284)
    v286 : bool = pyteal.Or(v275, v285)
    v287 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v290 : bool = (v287.receiver()) == (pyteal.App.globalGet(v271))
    v291 : bool = pyteal.Assert(v290)
    v292 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v297 : bool = (v292.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v265)))
    v298 : bool = pyteal.Assert(v297)
    v299 : int = (pyteal.Int(1)) or 0
    v301 : List[bool] = [v291, v298, pyteal.App.globalPut(v267, v299)]
    v302 : bool = pyteal.Seq(v301)
    v305 : bool = (pyteal.App.globalGet(v267)) == (pyteal.Int(2))
    v308 : bool = (pyteal.App.globalGet(v267)) == (pyteal.Int(0))
    v311 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v264))
    v314 : bool = (pyteal.App.globalGet(v270)) == (pyteal.App.globalGet(v271))
    v315 : bool = pyteal.And(v308, v311, v314)
    v316 : bool = pyteal.Or(v305, v315)
    v317 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v320 : bool = (v317.receiver()) == (pyteal.App.globalGet(v268))
    v321 : bool = pyteal.Assert(v320)
    v322 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v327 : bool = (v322.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v265)))
    v328 : bool = pyteal.Assert(v327)
    v329 : int = (pyteal.Int(2)) or 0
    v331 : List[bool] = [v321, v328, pyteal.App.globalPut(v267, v329)]
    v332 : bool = pyteal.Seq(v331)
    v335 : bool = (pyteal.App.globalGet(v267)) == (pyteal.Int(3))
    v336 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v339 : bool = (v336.receiver()) == (pyteal.App.globalGet(v271))
    v340 : bool = pyteal.Assert(v339)
    v341 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v344 : bool = (v341.amount()) == (pyteal.App.globalGet(v265))
    v345 : bool = pyteal.Assert(v344)
    v346 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v349 : bool = (v346.type_enum()) == pyteal.TxnType.Payment
    v350 : bool = pyteal.Assert(v349)
    v351 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v354 : bool = (v351.sender()) == (pyteal.App.globalGet(v266))
    v355 : bool = pyteal.Assert(v354)
    v356 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v359 : bool = (v356.receiver()) == (pyteal.App.globalGet(v268))
    v360 : bool = pyteal.Assert(v359)
    v361 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v364 : bool = (v361.amount()) == (pyteal.App.globalGet(v265))
    v366 : List[bool] = [v340, v345, v350, v355, v360, pyteal.Assert(v364)]
    v367 : bool = pyteal.Seq(v366)
    v368 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v371 : bool = (v368.type_enum()) == pyteal.TxnType.Payment
    v372 : bool = pyteal.Assert(v371)
    v373 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v376 : bool = (v373.sender()) == (pyteal.App.globalGet(v266))
    v377 : bool = pyteal.Assert(v376)
    v378 : List[bool] = [v286, v302]
    v379 : List[bool] = [v316, v332]
    v380 : List[bool] = [v335, v367]
    v381 : bool = pyteal.Cond(v378, v379, v380)
    v382 : int = (pyteal.Int(1)) or 0
    v384 : List[bool] = [v372, v377, v381, pyteal.Return(v382)]
    v386 : List[bool] = [v262, pyteal.Seq(v384)]
    v387 : bool = pyteal.Cond(v82, v260, v386)
    to_console(interpolate("%A%P()", ["app_initialization_logic"]))
    v389 : int = (pyteal.Int(0)) or 0
    v390 : int = (pyteal.Int(0)) or 0
    v391 : int = (pyteal.Int(0)) or 0
    v392 : int = (pyteal.Int(1000000)) or 0
    v393 : int = (pyteal.Int(3600)) or 0
    pattern_input_4 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v403 : bool = pyteal.App.globalPut(pattern_input_4[8], v389)
    v404 : bool = pyteal.App.globalPut(pattern_input_4[5], v390)
    v405 : bool = pyteal.App.globalPut(pattern_input_4[3], v391)
    v406 : bool = pyteal.App.globalPut(pattern_input_4[1], v392)
    v407 : int = (pyteal.Int(1)) or 0
    v409 : List[bool] = [v403, v404, v405, v406, pyteal.Return(v407)]
    v410 : bool = pyteal.Seq(v409)
    return pyteal.If(v6_1, v410, v387)


def closure7(unit_var0: None, v0_1: int) -> bool:
    to_console(interpolate("%A%P()", ["game_funds_escrow"]))
    v2_1 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 0)
    v5_1 : bool = (v2_1.application_id()) == (pyteal.Int(v0_1))
    v6_1 : bool = pyteal.Assert(v5_1)
    v7_1 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v10 : bool = (v7_1.fee()) <= (pyteal.Int(1000))
    v11 : bool = pyteal.Assert(v10)
    v12 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v15 : bool = (v12.asset_close_to()) == (pyteal.Global.zero_address())
    v16 : bool = pyteal.Assert(v15)
    v17 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v20 : bool = (v17.rekey_to()) == (pyteal.Global.zero_address())
    v22 : List[bool] = [v6_1, v11, v16, pyteal.Assert(v20)]
    v23 : bool = pyteal.Seq(v22)
    v24 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 0)
    v27 : bool = (v24.application_id()) == (pyteal.Int(v0_1))
    v28 : bool = pyteal.Assert(v27)
    v29 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v32 : bool = (v29.fee()) <= (pyteal.Int(1000))
    v33 : bool = pyteal.Assert(v32)
    v34 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v37 : bool = (v34.asset_close_to()) == (pyteal.Global.zero_address())
    v38 : bool = pyteal.Assert(v37)
    v39 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v42 : bool = (v39.rekey_to()) == (pyteal.Global.zero_address())
    v43 : bool = pyteal.Assert(v42)
    v44 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v47 : bool = (v44.fee()) <= (pyteal.Int(1000))
    v48 : bool = pyteal.Assert(v47)
    v49 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v52 : bool = (v49.asset_close_to()) == (pyteal.Global.zero_address())
    v53 : bool = pyteal.Assert(v52)
    v54 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v57 : bool = (v54.rekey_to()) == (pyteal.Global.zero_address())
    v59 : List[bool] = [v28, v33, v38, v43, v48, v53, pyteal.Assert(v57)]
    v60 : bool = pyteal.Seq(v59)
    v64 : List[bool] = [(pyteal.Global.group_size()) == (pyteal.Int(2)), v23]
    v68 : List[bool] = [(pyteal.Global.group_size()) == (pyteal.Int(3)), v60]
    v69 : bool = pyteal.Cond(v64, v68)
    v70 : int = (pyteal.Int(1)) or 0
    v72 : List[bool] = [v69, pyteal.Return(v70)]
    return pyteal.Seq(v72)


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

def arrow_5(__unit: Any=None) -> bool:
    return closure5(None, None)


v6 : Callable[[], bool] = arrow_5

def arrow_6(__unit: Any=None) -> bool:
    return closure6(None, None)


v7 : Callable[[], bool] = arrow_6

def arrow_7(v0_1: int) -> bool:
    return closure7(None, v0_1)


v8 : Callable[[int], bool] = arrow_7

