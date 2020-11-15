Public Class Miesiąc
    Private Wartość As String
    Public Sub New(ByVal Numer As String)
        Wartość = Numer
    End Sub

    Public Function Nazwa()
        Dim Wynik As String
        Select Case Wartość
            Case "01" : Wynik = "Styczeń"
            Case "02" : Wynik = "Luty"
            Case "03" : Wynik = "Marzec"
            Case "04" : Wynik = "Kwiecień"
            Case "05" : Wynik = "Maj"
            Case "06" : Wynik = "Czerwiec"
            Case "07" : Wynik = "Lipiec"
            Case "08" : Wynik = "Sierpień"
            Case "09" : Wynik = "Wrzesień"
            Case "10" : Wynik = "Październik"
            Case "11" : Wynik = "Listopad"
            Case "12" : Wynik = "Grudzień"
            Case Else : Wynik = "(Błędna Data!)"
        End Select
        Return Wynik
    End Function
End Class
