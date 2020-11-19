Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Szyfrowanie Gaderypoluki")
        Dim FrazaUzytkownika As Koder = New Koder(Aplikacja.OdpUzytkownika("Podaj fraze do zakodowania: ", "*"))
        Aplikacja.Wyswietl(FrazaUzytkownika.Kodowanie)
    End Sub
End Module
