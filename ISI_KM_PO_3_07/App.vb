Public Class App
    Public Shared Sub Start()
        Console.Write("Wpisz numer dnia tygodnia: ") : Dim Dzień As String = Console.ReadLine() : Program.Action(Dzień)
    End Sub

    Public Shared Function Check(Dzień)
        Select Case Dzień
            Case 1 : Return "Poniedziałek"
            Case 2 : Return "Wtorek"
            Case 3 : Return "Środa"
            Case 4 : Return "Czwartek"
            Case 5 : Return "Piątek"
            Case 6 : Return "Sobota"
            Case 7 : Return "Niedziela"
            Case Else : Return "Błędny numer dnia tygodnia - (1-7)" : Program.Main()
        End Select
    End Function

    Public Shared Sub Show(Dzień)
        Console.WriteLine($"{Dzień}. dzień tygodnia to: {Check(Dzień)}")
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub

End Class
