Public Class Dzialania
Public Shared Function Oblicz(ByVal n As Integer) As Integer
    If (n <= 1) Then Return 1
    Return (n + Oblicz(n - 1))
    End Function 
End Class