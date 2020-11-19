Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System

Public Class Lancuch
    Private Wartosc As String
    Public Sub New(Obiekt As String)
        Wartosc = Obiekt
    End Sub
        Public Function Tresc ()
        Return Wartosc
    End Function
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
    Public Function LiczWiersze()
        Dim Kolekcja As MatchCollection = Regex.Matches(Wartosc, vbCrLF)
        Return Kolekcja.Count + 1
    End Function
    Public Function LiczZnakiWWierszach() As String
        Dim IloscZnakow As Integer = Wartosc.Count - 2 * Regex.Matches(Wartosc, vbCrLF).Count
        Dim IloscZnakowWWierszu As New List (of Integer)
        Dim Poprzedni As Integer = 0
        Dim Aktualny As Integer = 0
        Dim Wynik As String = ""
        For i As Integer = 0 To IloscZnakow-1
            If Wartosc(i).ToString.Equals(Chr(13)) Then
             Aktualny = i - Poprzedni
             IloscZnakowWWierszu.Add(Aktualny)
             Poprzedni += Aktualny
             Poprzedni += 2
            End If
        Next
        Dim IloscZnakowWOst As Integer = IloscZnakow
        For i As integer = 0 To IloscZnakowWWierszu.Count-1
            IloscZnakowWOst -= IloscZnakowWWierszu(i)
        Next
        For i As integer = 0 To IloscZnakowWWierszu.Count-1
            Wynik += $"Wiersz nr {i+1} = {IloscZnakowWWierszu(i).ToString}; "
            If i = IloscZnakowWWierszu.Count-1 Then Wynik += $"Wiersz nr {i+2} = {IloscZnakowWOst.ToString}"
        Next
        return Wynik
    End Function
    Public Function LiczPowieloneSlowa () As String
        Dim IloscSlow As Integer = Regex.Matches(Wartosc, "\S ").Count + 1
        Dim Poprzedni As Integer = 0 : Dim Aktualny As Integer = 0
        Dim ListaSlow As New List (of String)
        Dim Wartosc1 As String= Wartosc.ToUpper + " ."
        For i As Integer = 0 to Wartosc1.Count -1 
            If Wartosc1(i) = " " Then
                ListaSlow.Add(Pobierz(Poprzedni, i - Poprzedni).ToUpper)
                Poprzedni+=(i-Poprzedni+1)
            End If
        Next
        Dim ListaWyrazow As New List (of String)
        For i As Integer = 0 To ListaSlow.Count -1
            If ListaWyrazow.Contains(ListaSlow(i).ToUpper) = False Then ListaWyrazow.Add(ListaSlow(i).ToUpper)
        Next
        Dim LiczbaWyst As New List (of Integer)
        Dim Pogrupowane = ListaSlow.GroupBy(Function(value) value)
        For Each Wyrazy In Pogrupowane
            LiczbaWyst.Add(Wyrazy.Count)
        Next
        For i As Integer = 0 To ListaWyrazow.Count -1
            LiczbaWyst.Add(ListaSlow.Equals(ListaWyrazow(i)))
        Next
        Dim Wynik As String = ""
        For i As Integer = 0 To ListaWyrazow.Count -1
            If LiczbaWyst(i) > 1 Then Wynik += $"{ListaWyrazow(i)}={LiczbaWyst(i)}; "
        Next
        Return Wynik
    End Function
End Class