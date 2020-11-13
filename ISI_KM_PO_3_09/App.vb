Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj wariant (a,b,c,d): ") : Dim Wariant As String = Console.ReadLine()
        Console.Write("Podaj ilość wierszy: ") : Dim Ilosc As String = Console.ReadLine()
        Program.Action(Wariant, Ilosc)
    End Sub

    Public Shared Function Rysuj(Wariant, Ilosc)
        Select Case Wariant
            Case "a" : For i As Integer = 0 To Ilosc - 1
                    For j As Integer = 0 To i : Console.Write("*") : Next : Console.WriteLine() : Next
            Case "b" : For i As Integer = 0 To Ilosc - 1
                    For j As Integer = Ilosc - 1 - i To 0 Step -1 : Console.Write("*") : Next : Console.WriteLine() : Next
            Case "c" : For i As Integer = 0 To Ilosc - 1 Step +1
                    For j As Integer = Ilosc - 1 - i To 0 Step -1 : Console.Write(" ") : Next
                    For k As Integer = 0 To i : Console.Write("*") : Next : Console.WriteLine() : Next
            Case "d" : For i As Integer = 0 To Ilosc - 1
                    If i = 0 Or i = Ilosc - 1 Then : Console.WriteLine("****") : Else Console.WriteLine("*  *") : End If : Next
        End Select
    End Function

    Public Shared Sub Show(Wariant, Ilosc)
        Console.WriteLine(vbCrLf + $"Wariant {Wariant.ToString.ToUpper}") : Rysuj(Wariant, Ilosc) : Program.Main()
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub

End Class
