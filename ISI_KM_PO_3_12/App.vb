Public Class App
    Public Shared Sub Start()
        Dim Lista As New List(Of Integer)
        Dim Liczba As Integer : Dim Suma As Integer = 0
        Do
            Console.Write("Podaj liczbę: ")
            Liczba = Console.ReadLine()
            Suma += Liczba
        Loop Until Liczba = 0
        Program.Action(Suma)
    End Sub

    Public Shared Sub Show(Suma)
        Console.WriteLine($"Suma wybranych liczb przed wciśnięciem 0 wynosi {Suma}" + vbCrLf) : Program.Main()
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
