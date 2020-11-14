Module Program
    Sub Main()
        Dim Matrix As MacierzRandomowa = New MacierzRandomowa(5, 5, 1, 10)
        App.Wyświetl(Matrix.Pokaz)
        App.Wyświetl(Matrix.Tr)
        App.Hold()
    End Sub
End Module
