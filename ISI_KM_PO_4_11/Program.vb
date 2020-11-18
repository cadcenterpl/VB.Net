Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Zliczanie liter")
        Dim LancuchUzytkownika As Lancuch = New Lancuch(Aplikacja.OdpUżytkownika("Wpisz zdanie lub wyraz: ", "*"))
        Aplikacja.Wydrukuj($"Liczba liter: {LancuchUzytkownika.LiczLitery}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
