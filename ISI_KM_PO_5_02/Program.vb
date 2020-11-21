Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Sprawdzanie przedziału")
        Dim a as Integer = Aplikacja.OdpUzytkownika("Podaj zakres początkowy przedziału (a): ", "*")
        Dim b As Integer = Aplikacja.OdpUzytkownika("Podaj zakres końcowy przedziału (b): ", "*")
        Dim PrzedzialUzytkownika As Przedzial= New Przedzial(a,b)
        Dim x As Integer = Aplikacja.OdpUzytkownika("Podaj liczbę x: ", "*")
        Aplikacja.Wyswietl($"Odp.: x={x}{PrzedzialUzytkownika.Sprawdz(x)}należy do przedziału dwustronnie otwartego ({a},{b})")
    End Sub
End Module
