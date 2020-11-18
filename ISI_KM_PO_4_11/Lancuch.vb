Imports System.Text.RegularExpressions

Public Class Lancuch
    Private Wartosc As String
    Public Sub New(Obiekt As String)
        Wartosc = Obiekt
    End Sub
    Public Function LiczWyrazy() As Integer
        Dim Kolekcja As MatchCollection = Regex.Matches(Wartosc, "\S ")
        Return Kolekcja.Count + 1
    End Function
    Public Function Pobierz(ByVal Start As Integer, Ile As Integer) As String
        Dim Pobrane As String = Wartosc.Substring(Start, Ile)
        Return Pobrane
    End Function
    Public Function LiczLitery() As String
        Dim IloscZnakow As Integer = Wartosc.Count()
        Dim Litery As New List(of String)
        For i As Integer = 0 To IloscZnakow - 1
            Dim Litera As String = Pobierz(i,1).ToUpper
            If Litera.ToString <> " " Then
                If Litery.Contains(Litera) = False then Litery.Add(Litera)
            End If
        Next 
        Dim Powtorzenia As New List(of String)
        Dim LiczbaLiter As Integer = Litery.Count
        For i As Integer = 0 to LiczbaLiter- 1
            Dim Kolekcja As MatchCollection = Regex.Matches(Wartosc.ToUpper, Litery(i))
            Powtorzenia.Add(Kolekcja.Count)
        Next
        Dim Wynik As String = ""
        For i As Integer = 0 To LiczbaLiter -1
            Wynik += Litery(i).ToString + "=" + Powtorzenia(i).ToString + " "
        Next
        Return Wynik
    End Function
End Class