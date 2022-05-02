cdef class Closure0():
    def __init__(self): pass
    def __call__(self):
        return method0()
cdef signed long method0():
    return (<signed long>180)
cpdef void main():
    cdef object v0
    v0 = Closure0()
    printfn($"main.spi Loaded. Width: {v0 ()}")
