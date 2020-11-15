Imports System.Text.RegularExpressions
Public Class Łańcuch
    Private Wartość As String
    Public Sub New(Obiekt As String)
        Wartość = Obiekt
    End Sub
    Public Function LiczWyrazy() As Integer
        Dim Kolekcja As MatchCollection = Regex.Matches(Wartość, "\S ")
        Return Kolekcja.Count + 1
    End Function
End Class
