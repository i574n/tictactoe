from __future__ import annotations
import pyteal
from pyteal import Gtxn
from typing import (Any, List, Tuple, Callable)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, union_type)
from fable_modules.fable_library.string import (to_console, interpolate)
from fable_modules.fable_library.types import Union

def expr_0() -> TypeInfo:
    return union_type("Main.US0", [], US0, lambda: [[], [("f1_0", int32_type)]])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag : int = tag or 0
        self.fields : List[Any] = list(fields)
    
    @staticmethod
    def cases() -> List[str]:
        return ["US0_0", "US0_1"]
    

US0_reflection = expr_0

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


def closure0(unit_var0: None, v0_1: US0) -> bool:
    to_console(interpolate("%A%P()", ["application_start"]))
    v2_1 : str = pyteal.Bytes("SetupPlayers")
    v3_1 : str = pyteal.Bytes("ActionMove")
    v4_1 : str = pyteal.Bytes("MoneyRefund")
    v7_1 : bool = (pyteal.Txn.application_id()) == (pyteal.Int(0))
    v9_1 : bool = pyteal.Txn.application_args[0] == v2_1
    to_console(interpolate("%A%P()", ["initialize_players_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v18 : str = pattern_input[7]
    v15 : str = pattern_input[4]
    v12 : str = pattern_input[1]
    v20 : int = (pyteal.Int(0)) or 0
    v21 : int = (pyteal.Int(0)) or 0
    v22 : int = (pyteal.Int(0)) or 0
    v23 : int = (pyteal.Int(1000000)) or 0
    v24 : int = (pyteal.Int(3600)) or 0
    v25 : int = (pyteal.Int(0)) or 0
    v26 : int = (pyteal.App.globalGetEx(v25, v18)) or 0
    v27 : int = (pyteal.Int(0)) or 0
    v28 : int = (pyteal.App.globalGetEx(v27, v15)) or 0
    v29 : int = (pyteal.Int(0)) or 0
    v31 : List[bool] = [pyteal.Return(v29)]
    v32 : bool = pyteal.Seq(v31)
    v35 : int = ((pyteal.Int(v0_1.fields[0])) if (v0_1.tag == 1) else v24) or 0
    v36 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v39 : bool = (v36.type_enum()) == pyteal.TxnType.Payment
    v40 : bool = pyteal.Assert(v39)
    v41 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v44 : bool = (v41.type_enum()) == pyteal.TxnType.Payment
    v45 : bool = pyteal.Assert(v44)
    v46 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v47 : int = (v46.receiver()) or 0
    v48 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v50 : bool = v47 == (v48.receiver())
    v51 : bool = pyteal.Assert(v50)
    v52 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v55 : bool = (v52.amount()) == (pyteal.App.globalGet(v12))
    v56 : bool = pyteal.Assert(v55)
    v57 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v60 : bool = (v57.amount()) == (pyteal.App.globalGet(v12))
    v61 : bool = pyteal.Assert(v60)
    v62 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v63 : int = (v62.sender()) or 0
    v64 : bool = pyteal.App.globalPut(v18, v63)
    v65 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v66 : int = (v65.sender()) or 0
    v67 : bool = pyteal.App.globalPut(v15, v66)
    v68 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v69 : int = (v68.sender()) or 0
    v70 : bool = pyteal.App.globalPut(pattern_input[6], v69)
    v71 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v72 : int = (v71.receiver()) or 0
    v73 : bool = pyteal.App.globalPut(pattern_input[2], v72)
    v75 : int = ((pyteal.Global.latest_timestamp()) + v35) or 0
    v76 : bool = pyteal.App.globalPut(pattern_input[0], v75)
    v77 : int = (pyteal.Int(1)) or 0
    v79 : List[bool] = [v40, v45, v51, v56, v61, v64, v67, v70, v73, v76, pyteal.Return(v77)]
    v80 : bool = pyteal.Seq(v79)
    v81 : bool = v26.hasValue()
    v82 : bool = v28.hasValue()
    v83 : bool = pyteal.Or(v81, v82)
    v84 : bool = pyteal.If(v83, v32, v80)
    v86 : List[bool] = [v9_1, pyteal.Seq([v26, v28, v84])]
    v88 : bool = pyteal.Txn.application_args[0] == v3_1
    v91 : bool = (pyteal.Global.group_size()) == (pyteal.Int(1))
    v92 : bool = pyteal.And(v88, v91)
    to_console(interpolate("%A%P()", ["play_action_logic"]))
    pattern_input_1 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v99 : str = pattern_input_1[5]
    v98 : str = pattern_input_1[4]
    v97 : str = pattern_input_1[3]
    v102 : str = pattern_input_1[8]
    v101 : str = pattern_input_1[7]
    v100 : str = pattern_input_1[6]
    v103 : int = (pyteal.Int(0)) or 0
    v104 : int = (pyteal.Int(0)) or 0
    v105 : int = (pyteal.Int(0)) or 0
    v106 : int = (pyteal.Int(1000000)) or 0
    v107 : int = (pyteal.Int(3600)) or 0
    v108 : str = pyteal.Txn.application_args[1]
    v109 : int = (pyteal.Btoi(v108)) or 0
    v110 : int = (pyteal.App.globalGet(v102)) or 0
    v111 : int = (pyteal.App.globalGet(v99)) or 0
    v112 : int = (pyteal.Int(1)) or 0
    v113 : int = (pyteal.ShiftLeft(v112, v109)) or 0
    v114 : int = (pyteal.BitwiseOr(v110, v113)) or 0
    v115 : bool = pyteal.App.globalPut(v102, v114)
    v116 : int = (pyteal.App.globalGet(v102)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v118 : int = (pyteal.Int(448)) or 0
    v121 : bool = (pyteal.BitwiseAnd(v116, v118)) == (pyteal.Int(448))
    v122 : int = (pyteal.Int(56)) or 0
    v125 : bool = (pyteal.BitwiseAnd(v116, v122)) == (pyteal.Int(56))
    v126 : int = (pyteal.Int(7)) or 0
    v129 : bool = (pyteal.BitwiseAnd(v116, v126)) == (pyteal.Int(7))
    v130 : int = (pyteal.Int(292)) or 0
    v133 : bool = (pyteal.BitwiseAnd(v116, v130)) == (pyteal.Int(292))
    v134 : int = (pyteal.Int(146)) or 0
    v137 : bool = (pyteal.BitwiseAnd(v116, v134)) == (pyteal.Int(146))
    v138 : int = (pyteal.Int(73)) or 0
    v141 : bool = (pyteal.BitwiseAnd(v116, v138)) == (pyteal.Int(73))
    v142 : int = (pyteal.Int(273)) or 0
    v145 : bool = (pyteal.BitwiseAnd(v116, v142)) == (pyteal.Int(273))
    v146 : int = (pyteal.Int(84)) or 0
    v149 : bool = (pyteal.BitwiseAnd(v116, v146)) == (pyteal.Int(84))
    v150 : bool = pyteal.Or(v121, v125, v129, v133, v137, v141, v145, v149)
    v151 : int = (pyteal.Int(1)) or 0
    v152 : int = (pyteal.Int(0)) or 0
    v153 : bool = pyteal.If(v150, v151, v152)
    v154 : int = (pyteal.Int(1)) or 0
    v155 : bool = pyteal.App.globalPut(v97, v154)
    v156 : bool = pyteal.If(v153, v155)
    v157 : int = (pyteal.App.globalGet(v98)) or 0
    v159 : List[bool] = [v115, v156, pyteal.App.globalPut(v100, v157)]
    v160 : bool = pyteal.Seq(v159)
    v161 : int = (pyteal.BitwiseOr(v111, v113)) or 0
    v162 : bool = pyteal.App.globalPut(v99, v161)
    v163 : int = (pyteal.App.globalGet(v99)) or 0
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v165 : int = (pyteal.Int(448)) or 0
    v168 : bool = (pyteal.BitwiseAnd(v163, v165)) == (pyteal.Int(448))
    v169 : int = (pyteal.Int(56)) or 0
    v172 : bool = (pyteal.BitwiseAnd(v163, v169)) == (pyteal.Int(56))
    v173 : int = (pyteal.Int(7)) or 0
    v176 : bool = (pyteal.BitwiseAnd(v163, v173)) == (pyteal.Int(7))
    v177 : int = (pyteal.Int(292)) or 0
    v180 : bool = (pyteal.BitwiseAnd(v163, v177)) == (pyteal.Int(292))
    v181 : int = (pyteal.Int(146)) or 0
    v184 : bool = (pyteal.BitwiseAnd(v163, v181)) == (pyteal.Int(146))
    v185 : int = (pyteal.Int(73)) or 0
    v188 : bool = (pyteal.BitwiseAnd(v163, v185)) == (pyteal.Int(73))
    v189 : int = (pyteal.Int(273)) or 0
    v192 : bool = (pyteal.BitwiseAnd(v163, v189)) == (pyteal.Int(273))
    v193 : int = (pyteal.Int(84)) or 0
    v196 : bool = (pyteal.BitwiseAnd(v163, v193)) == (pyteal.Int(84))
    v197 : bool = pyteal.Or(v168, v172, v176, v180, v184, v188, v192, v196)
    v198 : int = (pyteal.Int(1)) or 0
    v199 : int = (pyteal.Int(0)) or 0
    v200 : bool = pyteal.If(v197, v198, v199)
    v201 : int = (pyteal.Int(2)) or 0
    v202 : bool = pyteal.App.globalPut(v97, v201)
    v203 : bool = pyteal.If(v200, v202)
    v204 : int = (pyteal.App.globalGet(v101)) or 0
    v206 : List[bool] = [v162, v203, pyteal.App.globalPut(v100, v204)]
    v207 : bool = pyteal.Seq(v206)
    v209 : bool = v109 >= (pyteal.Int(0))
    v210 : bool = pyteal.Assert(v209)
    v212 : bool = v109 <= (pyteal.Int(8))
    v213 : bool = pyteal.Assert(v212)
    v216 : bool = (pyteal.Global.latest_timestamp()) <= (pyteal.App.globalGet(pattern_input_1[0]))
    v217 : bool = pyteal.Assert(v216)
    v219 : bool = (pyteal.App.globalGet(v97)) == v105
    v220 : bool = pyteal.Assert(v219)
    v223 : bool = (pyteal.Txn.sender()) == (pyteal.App.globalGet(v100))
    v224 : bool = pyteal.Assert(v223)
    v227 : bool = (pyteal.BitwiseAnd(v110, v113)) == (pyteal.Int(0))
    v230 : bool = (pyteal.BitwiseAnd(v111, v113)) == (pyteal.Int(0))
    v231 : bool = pyteal.And(v227, v230)
    v232 : bool = pyteal.Assert(v231)
    v236 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v101)), v160]
    v240 : List[bool] = [(pyteal.Txn.sender()) == (pyteal.App.globalGet(v98)), v207]
    v241 : bool = pyteal.Cond(v236, v240)
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input_2 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v252 : int = (pyteal.App.globalGet(pattern_input_2[8])) or 0
    v253 : int = (pyteal.App.globalGet(pattern_input_2[5])) or 0
    v256 : bool = (pyteal.Int(511)) == (pyteal.BitwiseOr(v252, v253))
    v257 : int = (pyteal.Int(3)) or 0
    v258 : bool = pyteal.App.globalPut(v97, v257)
    v259 : bool = pyteal.If(v256, v258)
    v260 : int = (pyteal.Int(1)) or 0
    v262 : List[bool] = [v210, v213, v217, v220, v224, v232, v241, v259, pyteal.Return(v260)]
    v264 : List[bool] = [v92, pyteal.Seq(v262)]
    v266 : bool = pyteal.Txn.application_args[0] == v4_1
    to_console(interpolate("%A%P()", ["money_refund_logic"]))
    pattern_input_3 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v275 : str = pattern_input_3[7]
    v274 : str = pattern_input_3[6]
    v272 : str = pattern_input_3[4]
    v271 : str = pattern_input_3[3]
    v270 : str = pattern_input_3[2]
    v269 : str = pattern_input_3[1]
    v268 : str = pattern_input_3[0]
    v279 : bool = (pyteal.App.globalGet(v271)) == (pyteal.Int(1))
    v282 : bool = (pyteal.App.globalGet(v271)) == (pyteal.Int(0))
    v285 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v268))
    v288 : bool = (pyteal.App.globalGet(v274)) == (pyteal.App.globalGet(v272))
    v289 : bool = pyteal.And(v282, v285, v288)
    v290 : bool = pyteal.Or(v279, v289)
    v291 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v294 : bool = (v291.receiver()) == (pyteal.App.globalGet(v275))
    v295 : bool = pyteal.Assert(v294)
    v296 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v301 : bool = (v296.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v269)))
    v302 : bool = pyteal.Assert(v301)
    v303 : int = (pyteal.Int(1)) or 0
    v305 : List[bool] = [v295, v302, pyteal.App.globalPut(v271, v303)]
    v306 : bool = pyteal.Seq(v305)
    v309 : bool = (pyteal.App.globalGet(v271)) == (pyteal.Int(2))
    v312 : bool = (pyteal.App.globalGet(v271)) == (pyteal.Int(0))
    v315 : bool = (pyteal.Global.latest_timestamp()) > (pyteal.App.globalGet(v268))
    v318 : bool = (pyteal.App.globalGet(v274)) == (pyteal.App.globalGet(v275))
    v319 : bool = pyteal.And(v312, v315, v318)
    v320 : bool = pyteal.Or(v309, v319)
    v321 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v324 : bool = (v321.receiver()) == (pyteal.App.globalGet(v272))
    v325 : bool = pyteal.Assert(v324)
    v326 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v331 : bool = (v326.amount()) == ((pyteal.Int(2)) * (pyteal.App.globalGet(v269)))
    v332 : bool = pyteal.Assert(v331)
    v333 : int = (pyteal.Int(2)) or 0
    v335 : List[bool] = [v325, v332, pyteal.App.globalPut(v271, v333)]
    v336 : bool = pyteal.Seq(v335)
    v339 : bool = (pyteal.App.globalGet(v271)) == (pyteal.Int(3))
    v340 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v343 : bool = (v340.receiver()) == (pyteal.App.globalGet(v275))
    v344 : bool = pyteal.Assert(v343)
    v345 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v348 : bool = (v345.amount()) == (pyteal.App.globalGet(v269))
    v349 : bool = pyteal.Assert(v348)
    v350 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v353 : bool = (v350.type_enum()) == pyteal.TxnType.Payment
    v354 : bool = pyteal.Assert(v353)
    v355 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v358 : bool = (v355.sender()) == (pyteal.App.globalGet(v270))
    v359 : bool = pyteal.Assert(v358)
    v360 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v363 : bool = (v360.receiver()) == (pyteal.App.globalGet(v272))
    v364 : bool = pyteal.Assert(v363)
    v365 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v368 : bool = (v365.amount()) == (pyteal.App.globalGet(v269))
    v370 : List[bool] = [v344, v349, v354, v359, v364, pyteal.Assert(v368)]
    v371 : bool = pyteal.Seq(v370)
    v372 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v375 : bool = (v372.type_enum()) == pyteal.TxnType.Payment
    v376 : bool = pyteal.Assert(v375)
    v377 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v380 : bool = (v377.sender()) == (pyteal.App.globalGet(v270))
    v381 : bool = pyteal.Assert(v380)
    v382 : List[bool] = [v290, v306]
    v383 : List[bool] = [v320, v336]
    v384 : List[bool] = [v339, v371]
    v385 : bool = pyteal.Cond(v382, v383, v384)
    v386 : int = (pyteal.Int(1)) or 0
    v388 : List[bool] = [v376, v381, v385, pyteal.Return(v386)]
    v390 : List[bool] = [v266, pyteal.Seq(v388)]
    v391 : bool = pyteal.Cond(v86, v264, v390)
    to_console(interpolate("%A%P()", ["app_initialization_logic"]))
    v393 : int = (pyteal.Int(0)) or 0
    v394 : int = (pyteal.Int(0)) or 0
    v395 : int = (pyteal.Int(0)) or 0
    v396 : int = (pyteal.Int(1000000)) or 0
    v397 : int = (pyteal.Int(3600)) or 0
    pattern_input_4 : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v407 : bool = pyteal.App.globalPut(pattern_input_4[8], v393)
    v408 : bool = pyteal.App.globalPut(pattern_input_4[5], v394)
    v409 : bool = pyteal.App.globalPut(pattern_input_4[3], v395)
    v410 : bool = pyteal.App.globalPut(pattern_input_4[1], v396)
    v411 : int = (pyteal.Int(1)) or 0
    v413 : List[bool] = [v407, v408, v409, v410, pyteal.Return(v411)]
    v414 : bool = pyteal.Seq(v413)
    return pyteal.If(v7_1, v414, v391)


def closure1(unit_var0: None, unit_var1: None) -> bool:
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


def closure2(unit_var0: None, v0_1: US0) -> bool:
    to_console(interpolate("%A%P()", ["initialize_players_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v9_1 : str = pattern_input[7]
    v6_1 : str = pattern_input[4]
    v3_1 : str = pattern_input[1]
    v11 : int = (pyteal.Int(0)) or 0
    v12 : int = (pyteal.Int(0)) or 0
    v13 : int = (pyteal.Int(0)) or 0
    v14 : int = (pyteal.Int(1000000)) or 0
    v15 : int = (pyteal.Int(3600)) or 0
    v16 : int = (pyteal.Int(0)) or 0
    v17 : int = (pyteal.App.globalGetEx(v16, v9_1)) or 0
    v18 : int = (pyteal.Int(0)) or 0
    v19 : int = (pyteal.App.globalGetEx(v18, v6_1)) or 0
    v20 : int = (pyteal.Int(0)) or 0
    v22 : List[bool] = [pyteal.Return(v20)]
    v23 : bool = pyteal.Seq(v22)
    v26 : int = ((pyteal.Int(v0_1.fields[0])) if (v0_1.tag == 1) else v15) or 0
    v27 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v30 : bool = (v27.type_enum()) == pyteal.TxnType.Payment
    v31 : bool = pyteal.Assert(v30)
    v32 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v35 : bool = (v32.type_enum()) == pyteal.TxnType.Payment
    v36 : bool = pyteal.Assert(v35)
    v37 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v38 : int = (v37.receiver()) or 0
    v39 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v41 : bool = v38 == (v39.receiver())
    v42 : bool = pyteal.Assert(v41)
    v43 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v46 : bool = (v43.amount()) == (pyteal.App.globalGet(v3_1))
    v47 : bool = pyteal.Assert(v46)
    v48 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v51 : bool = (v48.amount()) == (pyteal.App.globalGet(v3_1))
    v52 : bool = pyteal.Assert(v51)
    v53 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v54 : int = (v53.sender()) or 0
    v55 : bool = pyteal.App.globalPut(v9_1, v54)
    v56 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 2)
    v57 : int = (v56.sender()) or 0
    v58 : bool = pyteal.App.globalPut(v6_1, v57)
    v59 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v60 : int = (v59.sender()) or 0
    v61 : bool = pyteal.App.globalPut(pattern_input[6], v60)
    v62 : Any = pyteal.TxnGroup.__getitem__(Gtxn, 1)
    v63 : int = (v62.receiver()) or 0
    v64 : bool = pyteal.App.globalPut(pattern_input[2], v63)
    v66 : int = ((pyteal.Global.latest_timestamp()) + v26) or 0
    v67 : bool = pyteal.App.globalPut(pattern_input[0], v66)
    v68 : int = (pyteal.Int(1)) or 0
    v70 : List[bool] = [v31, v36, v42, v47, v52, v55, v58, v61, v64, v67, pyteal.Return(v68)]
    v71 : bool = pyteal.Seq(v70)
    v72 : bool = v17.hasValue()
    v73 : bool = v19.hasValue()
    v74 : bool = pyteal.Or(v72, v73)
    v75 : bool = pyteal.If(v74, v23, v71)
    return pyteal.Seq([v17, v19, v75])


def closure3(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["play_action_logic"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v9_1 : str = pattern_input[8]
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
    v17 : int = (pyteal.App.globalGet(v9_1)) or 0
    v18 : int = (pyteal.App.globalGet(v6_1)) or 0
    v19 : int = (pyteal.Int(1)) or 0
    v20 : int = (pyteal.ShiftLeft(v19, v16)) or 0
    v21 : int = (pyteal.BitwiseOr(v17, v20)) or 0
    v22 : bool = pyteal.App.globalPut(v9_1, v21)
    v23 : int = (pyteal.App.globalGet(v9_1)) or 0
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


def closure4(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["is_tie"]))
    pattern_input : Tuple[str, str, str, str, str, str, str, str, str] = method0()
    v10 : int = (pyteal.App.globalGet(pattern_input[8])) or 0
    v11 : int = (pyteal.App.globalGet(pattern_input[5])) or 0
    return (pyteal.Int(511)) == (pyteal.BitwiseOr(v10, v11))


def closure5(unit_var0: None, v0_1: int) -> bool:
    to_console(interpolate("%A%P()", ["has_player_won"]))
    v2_1 : int = (pyteal.Int(448)) or 0
    v5_1 : bool = (pyteal.BitwiseAnd(v0_1, v2_1)) == (pyteal.Int(448))
    v6_1 : int = (pyteal.Int(56)) or 0
    v9_1 : bool = (pyteal.BitwiseAnd(v0_1, v6_1)) == (pyteal.Int(56))
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
    v34 : bool = pyteal.Or(v5_1, v9_1, v13, v17, v21, v25, v29, v33)
    v35 : int = (pyteal.Int(1)) or 0
    v36 : int = (pyteal.Int(0)) or 0
    return pyteal.If(v34, v35, v36)


def closure6(unit_var0: None, v0_1: int) -> bool:
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


def closure7(unit_var0: None, unit_var1: None) -> bool:
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


def closure8(unit_var0: None, unit_var1: None) -> bool:
    to_console(interpolate("%A%P()", ["clear_program"]))
    v1_1 : int = (pyteal.Int(1)) or 0
    return pyteal.Return(v1_1)


v0 : str = "main.spi Loaded"

to_console(interpolate("%A%P()", [v0]))

def arrow_1(v0_1: US0) -> bool:
    return closure0(None, v0_1)


v1 : Callable[[US0], bool] = arrow_1

def arrow_2(__unit: Any=None) -> bool:
    return closure1(None, None)


v2 : Callable[[], bool] = arrow_2

def arrow_3(v0_1: US0) -> bool:
    return closure2(None, v0_1)


v3 : Callable[[US0], bool] = arrow_3

def arrow_4(__unit: Any=None) -> bool:
    return closure3(None, None)


v4 : Callable[[], bool] = arrow_4

def arrow_5(__unit: Any=None) -> bool:
    return closure4(None, None)


v5 : Callable[[], bool] = arrow_5

def arrow_6(v0_1: int) -> bool:
    return closure5(None, v0_1)


v6 : Callable[[int], bool] = arrow_6

def arrow_7(v0_1: int) -> bool:
    return closure6(None, v0_1)


v7 : Callable[[int], bool] = arrow_7

def arrow_8(__unit: Any=None) -> bool:
    return closure7(None, None)


v8 : Callable[[], bool] = arrow_8

def arrow_9(__unit: Any=None) -> bool:
    return closure8(None, None)


v9 : Callable[[], bool] = arrow_9

