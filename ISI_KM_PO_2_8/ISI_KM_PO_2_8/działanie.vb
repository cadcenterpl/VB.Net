Public Class działanie
    Public Shared Function wynik(x, y, z)
        z += 1
        x = (y = 1 Or z = 1)
        Console.WriteLine("y=" + Str(y) + ", z=" + Str(z))
        Return x
    End Function
End Class
