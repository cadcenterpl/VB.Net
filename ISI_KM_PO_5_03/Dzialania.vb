Public Class Dzialania
    Public Shared Sub Przesun(ByRef punkt() As Double, ByVal wek() AS Double)
        punkt(0)+=wek(0) : punkt(1)+=wek(1)
    End Sub
End Class