Public Class działanie
    Public Shared Function wynik(x, y) As Double
        y -= 2 : x = y
        x = ++y - 1
        x = --y + 1
        Return x
    End Function
End Class
