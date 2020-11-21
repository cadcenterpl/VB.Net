Public Class Dzialania
    Public Shared Function Przesun(ByRef punkt() As Double, ByVal wek() AS Double)
        punkt(0)+=wek(0) : punkt(1)+=wek(1)
    End Function
End Class