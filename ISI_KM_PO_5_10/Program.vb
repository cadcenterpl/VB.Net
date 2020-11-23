Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Badanie Rekurencji:")
        Dim n As Integer : Do : n = Aplikacja.Odp("Podaj wyraz n : ", "*") : Loop Until n >0
        Aplikacja.Wyswietl($"Efekt Rekurencji = {Dzialania.Oblicz(n)}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
