Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Zliczanie wierszy i znakow")
        Dim LancuchUzytkownika As Lancuch =  New Lancuch("W parę godzin później, gdy noc zbierała siędo odejścia," + vbCrLf + "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia." + vbCrLf + "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział," +  vbCrLf + "co ono oznacza. Był głodny. Więc poszedł do spiżarni," +  vbCrLf + "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.")
        Aplikacja.Wydrukuj(LancuchUzytkownika.Tresc) : Aplikacja.Wyswietl("")
        Aplikacja.Wyswietl($"Ilosc Wierszy: {LancuchUzytkownika.LiczWiersze()}") 
        Aplikacja.Wyswietl($"Ilosc Znakw w wierszach: {LancuchUzytkownika.LiczZnakiWWierszach()}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
