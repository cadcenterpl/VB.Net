Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Słownik dni tygodnia")
        For i As Integer = 0 To 6
            Dim DzieńNowy As Dzień = New Dzień(i)
            Aplikacja.DrukujTabele(DzieńNowy.PL)
            Aplikacja.DrukujTabele(DzieńNowy.EN)
            Aplikacja.DrukujTabele(DzieńNowy.DE)
            Aplikacja.Wyświetl(Nothing)
        Next
        Aplikacja.Zatrzymaj()

    End Sub
End Module
