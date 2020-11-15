Public Class Dzień
    Private Wartość As String = ""
    Private Wybór As Integer = 0

    Public Sub New(ByVal Numer As Integer)
        Wybór = Numer
    End Sub
    Public Function PL()
        Dim Numer As Integer = Wybór
        Select Case Numer
            Case 1 : Wartość = "Poniedziałek"
            Case 2 : Wartość = "Wtorek"
            Case 3 : Wartość = "Środa"
            Case 4 : Wartość = "Czwartek"
            Case 5 : Wartość = "Piątek"
            Case 6 : Wartość = "Sobota"
            Case 7 : Wartość = "Niedziela"
        End Select
        Return Wartość
    End Function
    Public Function EN()
        Dim Numer As Integer = Wybór
        Select Case Numer
            Case 1 : Wartość = "Monday"
            Case 2 : Wartość = "Tuesday"
            Case 3 : Wartość = "Wednesday"
            Case 4 : Wartość = "Thursday"
            Case 5 : Wartość = "Friday"
            Case 6 : Wartość = "Saturday"
            Case 7 : Wartość = "Sunday"
        End Select
        Return Wartość
    End Function
    Public Function DE()
        Dim Numer As Integer = Wybór
        Select Case Numer
            Case 1 : Wartość = "Montag"
            Case 2 : Wartość = "Dienstag"
            Case 3 : Wartość = "Mittwoch"
            Case 4 : Wartość = "Donnerstag"
            Case 5 : Wartość = "Freitag"
            Case 6 : Wartość = "Samstag"
            Case 7 : Wartość = "Sonntag"
        End Select
        Return Wartość
    End Function
End Class
