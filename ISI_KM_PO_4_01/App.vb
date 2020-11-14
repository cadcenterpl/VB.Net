Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj liczbę n: ") : Dim Liczba As Integer = Console.ReadLine() : Program.Action(Liczba)
    End Sub
    Public Shared Function Wprowadz(Liczba)
        Dim Lista As New List(Of Integer)
        For i As Integer = 0 To Liczba - 1
            Console.Write($"Podaj {i + 1}.liczbę: ")
            Lista.Add(Console.ReadLine())
        Next
        For i As Integer = 0 To Lista.Count - 1
            Console.Write($"Wprowadzone liczby: {Lista.Item(i)} ")
        Next
        Return 0
    End Function

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class