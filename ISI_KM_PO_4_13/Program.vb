Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Zliczanie wierszy i znakow")
        Dim LancuchUzytkownika As Lancuch = New Lancuch(Aplikacja.OdpUzytkownika("Wpisz zdanie: ", "*"))
        Aplikacja.Wydrukuj(LancuchUzytkownika.Tresc) : Aplikacja.Wyswietl("")
        Aplikacja.Wydrukuj($"Lista powielonych slow: {LancuchUzytkownika.LiczPowieloneSlowa}") 
        Aplikacja.Zatrzymaj()
    End Sub
End Module
