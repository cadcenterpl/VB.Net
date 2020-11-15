Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Dodawanie macierzy randomowych")
        Dim Matrix1 As MacierzRandomowa = New MacierzRandomowa(2, 3, 1, 10)
        Dim Matrix2 As MacierzRandomowa = New MacierzRandomowa(2, 3, 1, 10)
        With Aplikacja
            .Wyświetl(Matrix1.Widok)
            .Wyświetl(Matrix2.Widok)
            .Wyświetl(Matrix1.Suma(Matrix2).Widok)
            .Hold()
        End With
    End Sub
End Module
