Public Class Wartosc
    Private Wart As Integer
    Public Sub New(ByVal Przekazana As Integer)
        Wart = Przekazana
    End Sub
Public Function KonwersjaFC()
    Return Math.Round(((Wart-32)/(1.8)),1)
End Function
End Class