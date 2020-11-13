Public Class App
    Public Shared Sub start()
        Console.Write("Podaj pierwszą liczbę: ")
        Dim A As Integer = Console.ReadLine()
        Console.Write("Podaj drugą liczbę: ")
        Dim B As Integer = Console.ReadLine()
        Program.action(A, B)
    End Sub
    Shared Function check(A, B)
        If A Mod B = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub show(A, B)
        Console.WriteLine($"Czy druga liczba jest dzielnikiem pierwszej?: " + check(A, B).ToString)
    End Sub

    Public Shared Sub enterkey()
        Console.ReadKey()
    End Sub
End Class
