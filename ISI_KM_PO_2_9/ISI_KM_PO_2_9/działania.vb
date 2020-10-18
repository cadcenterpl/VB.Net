Imports System
Public Class działania
    Public Shared Sub A(w, x, y, z)
        w = (Math.Min(System.Threading.Interlocked.Increment(x), x - 1) > 1 AndAlso
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) = 4 AndAlso
            Math.Max(System.Threading.Interlocked.Decrement(z), z + 1) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
    Public Shared Sub B(w, x, y, z)
        w = (Math.Min(System.Threading.Interlocked.Increment(x), x - 1) > 1 And
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) = 4 AndAlso
            Math.Max(System.Threading.Interlocked.Decrement(z), z + 1) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
    Public Shared Sub C(w, x, y, z)
        w = (Math.Min(System.Threading.Interlocked.Increment(x), x - 1) > 1 And
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) = 4 And
            Math.Max(System.Threading.Interlocked.Decrement(z), z + 1) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
    Public Shared Sub D(w, x, y, z)
        w = (x = 1 OrElse
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) > 2 OrElse
            System.Threading.Interlocked.Increment(z) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
    Public Shared Sub E(w, x, y, z)
        w = (x = 1 Or
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) > 2 OrElse
            System.Threading.Interlocked.Increment(z) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
    Public Shared Sub F(w, x, y, z)
        w = (x = 1 Or
            Math.Min(System.Threading.Interlocked.Increment(y), y - 1) > 2 Or
            System.Threading.Interlocked.Increment(z) > 0)
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", w, x, y, z)
    End Sub
End Class



