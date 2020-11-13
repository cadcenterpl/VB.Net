Public Class App
    Public Shared Sub start()
        Dim lista As New List(Of Double)
        For i As Integer = 0 To 2
            Console.Write("Podaj liczbę: ")
            lista.Add(Console.ReadLine())
        Next
        Program.Action(lista)
    End Sub
    Public Shared Function check(lista As List(Of Double))
        Return lista.Max
    End Function
    Public Shared Sub Show(lista)
        Console.WriteLine("Największa wartość z podanych liczb to: " + App.check(lista).ToString)
    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
