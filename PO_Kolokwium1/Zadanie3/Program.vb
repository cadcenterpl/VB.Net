Imports System
Imports System.Text.RegularExpressions

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Wyświetlanie słownie miesiąca")
        Dim DataUżytkownika As Łańcuch = New Łańcuch(Aplikacja.OdpUżytkownika("Wpisz dowolną datę w formacie DD-MM-RRRR: ", "*-*-*"))
        Dim MiesiącUżytkownika As Miesiąc = New Miesiąc(DataUżytkownika.Pobierz(3, 2))
        Aplikacja.Wydrukuj($"Wskazany miesiąc to {MiesiącUżytkownika.Nazwa}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module

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

Public Class Łańcuch
    Private Wartość As String
    Public Sub New(Obiekt As String)
        Wartość = Obiekt
    End Sub
    Public Function LiczWyrazy() As Integer
        Dim Kolekcja As MatchCollection = Regex.Matches(Wartość, "\S ")
        Return Kolekcja.Count + 1
    End Function
    Public Function Pobierz(ByVal Start As Integer, Ile As Integer) As String
        Dim Pobrane As String = Wartość.Substring(Start, Ile)
        Return Pobrane
    End Function
End Class

Public Class App
    Private Name As String
    Private Konstrukcja As String
    Public Sub New(ByVal Nazwa As String)
        Name = Nazwa : Console.WriteLine(Nazwa)
    End Sub
    Public Sub Zatrzymaj()
        Console.WriteLine(vbCrLf + "Aby zakończyć wciśnij dowolny klawisz.")
        Console.ReadKey()
    End Sub
    Public Sub Wyświetl(ByVal Obiekt As Object)
        Console.WriteLine(Obiekt)
    End Sub

    Public Sub Wydrukuj(ByVal Obiekt As Object)
        Console.Write(Obiekt)
    End Sub

    Public Function OdpUżytkownika(ByVal Polecenie As String, Format As String)
        Dim Odpowiedź As String
        Do
            Console.Write(Polecenie)
            Odpowiedź = Console.ReadLine()
        Loop Until Odpowiedź Like Format
        Return Odpowiedź
    End Function
End Class
