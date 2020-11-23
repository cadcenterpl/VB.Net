Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Obliczanie sumy wyrażenia W = (x+1) + (x+2) + (x+3) +.......+ (x+n)")
        Dim x As Integer : x = Aplikacja.Odp("Podaj wielkość x: ", "*")
        Dim n As Integer : Do : n = Aplikacja.Odp("Podaj wielkość n (>0): ", "*") : Loop Until n > 0
        Aplikacja.Wyswietl(Dzialania.LiczenieW(x,n))
        Aplikacja.Zatrzymaj()
    End Sub
End Module
