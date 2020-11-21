Public Class Przedzial
    Private A As Integer
    Private B As Integer
    Public Sub New(ByVal Start As Integer, Koniec As Integer)
        A = Start : B = Koniec
    End Sub
Public Function Sprawdz(ByVal X As Integer)
    if (X>A AndAlso X<B) Then : Return " "
    Else : Return " nie "
    End if
End Function
End Class