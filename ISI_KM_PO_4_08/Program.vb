Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Słownik dni tygodnia")
        Dim x As Integer = 0
        For i As Integer = 0 To 6
            Dim DzieńNowy As Dzień = New Dzień(i)
            App.Wydruk(DzieńNowy.PL)
            App.Wydruk(DzieńNowy.EN)
            App.Wydruk(DzieńNowy.DE)
            App.Wyświetl(Nothing)
        Next
        App.Hold()

    End Sub
End Module
