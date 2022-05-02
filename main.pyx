import numpy
cimport numpy
cdef class Closure0():
    def __init__(self): pass
    def __call__(self):
        return method0()
cdef signed long method0():
    return (<signed long>180)
cdef void method1(str v0):
    print(v0)
cdef void method2(bint v0):
    cdef bint v1
    v1 = v0 == 0
    if v1:
        raise Exception("test")
    else:
        pass
cdef void method3(numpy.ndarray[signed long,ndim=1] v0):
    print(v0)
cpdef void main():
    cdef object v0
    cdef str v1
    cdef str v2
    cdef bint v3
    cdef str v4
    cdef numpy.ndarray[signed long,ndim=1] v5
    cdef str v6
    v0 = Closure0()
    v1 = $"main.spi Loaded. Width: {v0 ()}"
    del v0
    method1(v1)
    del v1
    v2 = "/########################################\\ start"
    method1(v2)
    del v2
    v3 = 1
    method2(v3)
    v4 = str???('q', (<signed long>17))
    method1(v4)
    del v4
    v5 = numpy.empty(1,dtype=numpy.int32)
    v5[0] = (<signed long>3)
    method3(v5)
    del v5
    v6 = "\\########################################/ end"
    method1(v6)
