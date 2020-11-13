Public Class App
    Public Shared Function Licz(Liczba, Granica)
        Dim Suma As Integer = 0 : Dim Wsk As Integer = 0
        Do
            Suma += Wsk + 1
            Wsk += 1
        Loop Until Suma > Granica
        Return Wsk
    End Function

    Public Shared Sub Show(Liczba, Granica)
        Console.WriteLine($"Ilosc liczb, których suma przekracza 100 to {Licz(Liczba, Granica)}")
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class