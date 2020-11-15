Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Macierz randomowa. Tr A")
        Dim Matrix1 As MacierzRandomowa = New MacierzRandomowa(5, 5, 1, 10)
        With Aplikacja
            .Wyświetl(Matrix1.Widok)
            .Wyświetl(Matrix1.Tr)
            .Hold()
        End With
    End Sub
End Module
