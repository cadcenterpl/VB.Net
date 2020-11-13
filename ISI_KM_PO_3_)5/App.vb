Public Class App
    Public Shared Sub Start()
        Console.WriteLine("Wprowadź współczynniki A,B C równania Ax^2+Bx+C=0")
        Console.Write("Podaj A: ") : Dim A As Double = Console.ReadLine()
        Console.Write("Podaj B: ") : Dim B As Double = Console.ReadLine()
        Console.Write("Podaj C: ") : Dim C As Double = Console.ReadLine()
        Program.Action(A, B, C)
    End Sub
    Public Shared Function Check(A, B, C)
        Dim Delta As Double = B * B - (4 * A * C)
        Select Case Delta
            Case > 0 : Return 2 : Case = 0 : Return 1 : Case < 0 : Return 0
        End Select

    End Function
    Public Shared Sub Show(A, B, C)
        Console.WriteLine($"Ilość pierwiastków równania {A}x^2+{B}x+{C}=0: {Check(A, B, C)}")
    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
