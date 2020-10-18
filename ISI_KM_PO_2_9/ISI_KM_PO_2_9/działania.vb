Public Class działania
    Public Shared Function A(w, x, y, z)
        w = ((++x + 1) > 1 Or y = 4 Or z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
    Public Shared Function B(w, x, y, z)
        w = (x > 1 And y = 4 Or z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
    Public Shared Function C(w, x, y, z)
        w = (x > 1 And y = 4 And z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
    Public Shared Function D(w, x, y, z)
        w = (++x = 1 Or (y + 1) > 2 Or ++z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
    Public Shared Function E(w, x, y, z)
        w = (++x = 1 And (y + 1) > 2 Or ++z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
    Public Shared Function F(w, x, y, z)
        w = (++x = 1 And (y + 1) > 2 And ++z > 0)
        Console.Write("x=" + Str(x) + ", y=" + Str(y) + ", z=" + Str(z) + ", ")
        Return w
    End Function
End Class
