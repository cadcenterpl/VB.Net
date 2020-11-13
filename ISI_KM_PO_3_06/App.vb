Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj wagę ciała [kg]: ") : Dim waga As Double = Console.ReadLine()
        Console.Write("Podaj wzrost [m]: ") : Dim wzrost As Double = Console.ReadLine()
        Program.Action(waga, wzrost)
    End Sub

    Public Shared Function Check(waga, wzrost)
        Dim BMI As Double = (waga / (wzrost ^ 2))
        Select Case BMI
            Case < 18, 5 : MsgBox("Niedowaga. Musisz trochę przytyć.") : Return "Niedowaga"
            Case 18, 5 To 24, 99 : MsgBox("Twoja waga jest idealna") : Return "Wartość Prawidłowa"
            Case >= 25 : MsgBox("Nadwaga! Odchudź się by zejść do prawidłowego poziomu") : Return "Nadwaga"
        End Select
    End Function

    Public Shared Sub Show(waga, wzrost)
        Console.WriteLine($"Status: {Check(waga, wzrost)}")
    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
