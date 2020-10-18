Public Class Class2
    Friend Shared Function delta(a, b, c) As Double
        Dim d As Integer = b ^ 2 - 4 * a * c
        Return d
    End Function
    Friend Shared Sub wynik(a, b, c)
        Console.Write("Delta ")
        Console.ForegroundColor = ConsoleColor.Red
        Console.BackgroundColor = ConsoleColor.Yellow
        Console.Write(Str(a) + "x +" + Str(b) + "y +" + Str(c) + " = 0 ")
        Console.ResetColor()
        Console.Write(" wynosi: ")
    End Sub
End Class