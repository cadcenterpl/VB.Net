Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Obliczanie sumy cyfr liczby naturalnej x")
        Dim x As String : x = Aplikacja.Odp("Podaj wielkość x: ", "*")
        Aplikacja.Wyswietl(Dzialania.LiczenieSumyCyfr(x))
        Aplikacja.Zatrzymaj()
    End Sub
End Module
