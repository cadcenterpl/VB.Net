Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj liczbę: ") : Dim Liczba As Integer = Console.ReadLine() : Program.Action(Liczba)
    End Sub

    Public Shared Function Licz(Liczba)
        Dim Iloczyn As Integer = 1
        For i As Integer = 0 To Liczba - 1
            Iloczyn *= (i + 1)
        Next
        Return Iloczyn
    End Function

    Public Shared Sub Show(Liczba)
        Console.WriteLine($"Silnia z {Liczba} wynosi: {Licz(Liczba)}" + vbCrLf) : Program.Main()
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
