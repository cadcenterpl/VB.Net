Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Wyświetlanie wskazanego n-tego wyrazu (w kółko klepanego) ciągu 'Bonifacego' :")
        Dim n As Integer : Do : n = Aplikacja.Odp("Który wyraz ciągu? : ", "*") : Loop Until n >0
        Aplikacja.Wyswietl($"'Bonifacy' twierdzi, że {n}.wyraz jego ciągu przyjmuje wartość: {Dzialania.WyrazCiagu_Rekurencja(n)} (Rekurencja)")
        Aplikacja.Wyswietl($"'Bonifacy' twierdzi, że {n}.wyraz jego ciągu przyjmuje wartość: {Dzialania.WyrazCiagu_Iteracja(n)} (Iteracja)")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
