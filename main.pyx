import numpy
cimport numpy
cdef class Closure0():
    def __init__(self): pass
    def __call__(self):
        return method0()
cdef class Closure1():
    def __init__(self): pass
    def __call__(self, str v0):
        AnsiConsole.WriteLine v0
cdef signed long method0():
    return (<signed long>180)
cdef object method2():
    return Closure1()
cdef void method1():
    cdef object v0
    cdef Color v1
    cdef Style v2
    cdef Rule v3
    cdef Rule v4
    cdef Rule v5
    cdef str v6
    cdef numpy.ndarray[signed long,ndim=1] v7
    cdef object v8
    v0 = Color.FromInt32
    v1 = v0((<signed long>5))
    del v0
    v2 = Style v1
    del v1
    v3 = Rule "[white bold underline]Title 1[/]"
    v4 = v3.LeftAligned ()
    del v3
    v5 = v4.RuleStyle v2
    del v2; del v4
    AnsiConsole.Write v5
    del v5
    v6 = System.String ('w', (<signed long>17))
    printfn $"%A{v6}"
    del v6
    v7 = numpy.empty(1,dtype=numpy.int32)
    v7[0] = (<signed long>5)
    printfn $"%A{v7}"
    del v7
    v8 = method2()
    v8("end")
cpdef void main():
    cdef object v0
    cdef str v1
    v0 = Closure0()
    v1 = $"main.spi Loaded. Width: {v0 ()}"
    del v0
    printfn $"%A{v1}"
    del v1
    #r "nuget: Spectre.Console"
    open Spectre.Console
    method1()
