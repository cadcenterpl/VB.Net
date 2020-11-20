'Copyright Kamil Martenczuk 2020
Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Witaj Świecie! Operacje na stringach. Liczenie liter:")
        Dim LancuchUzytkownika As Lancuch = New Lancuch(Aplikacja.OdpUzytkownika("Wpisz frazę: ", "*"))
        Aplikacja.Wyswietl($"We frazie jest {LancuchUzytkownika.LiczLitery} ")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
