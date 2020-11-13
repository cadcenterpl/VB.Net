Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj wartość średniej: ") : Dim Srednia As Double = Console.ReadLine() : Program.Action(Srednia)
    End Sub
    Public Shared Function Check(Srednia)
        Select Case Srednia
            Case 2 To 3.99 : Return "0.00"
            Case 4 To 4.79 : Return "350.00"
            Case 4.8 To 5 : Return "550.00"
            Case Else : MsgBox("Błędna wartość średniej") : Program.Main()
        End Select
    End Function

    Public Shared Sub Show(Srednia)
        Console.WriteLine($"Wartość Stypendium przy średniej {Srednia} wynosi: {App.Check(Srednia)}zł")
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
