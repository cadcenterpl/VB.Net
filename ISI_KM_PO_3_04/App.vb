Public Class App
    Public Shared Sub Start()
        Try
            Console.Write("Wybierz działanie '+' '-' '*' '/': ")
            Dim znak As Object = Console.ReadLine()
            Console.Write("Wpisz pierwszą liczbę działania: ")
            Dim A As Double = Console.ReadLine()
            Console.Write("Wpisz drugą liczbę działania: ")
            Dim B As Double = Console.ReadLine()
            Program.Action(znak, A, B)
        Catch ex As Exception
            MsgBox("Wprowadzono błędne dane") : Program.Main()
        End Try
    End Sub
    Shared Function dzialanie(znak As String, A As Double, B As String)
        If (znak = "+" Or znak = "-" Or znak = "*" Or znak = "/") Then
            Select Case znak
                Case "+" : Return A + B : Case "-" : Return A - B : Case "*" : Return A * B : Case "/" : Return A / B
            End Select
        Else : MsgBox("Wprowadzono błędny znak działania") : Program.Main()
        End If
    End Function

    Public Shared Sub show(znak As Object, A As Double, B As Double)
        Console.WriteLine($"Wynik {A}{znak.ToString}{B} to {dzialanie(znak, A, B)}")
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
