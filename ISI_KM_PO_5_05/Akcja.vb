Public Class Akcja
    Public Shared Sub Rysuj(ByVal a As Integer, b As Integer, znk As String)
        For i As Integer = 0 To b-1
            For j As Integer = 0 To a-1
                Console.Write(znk)
            Next
            Console.Writeline()
        Next
    End Sub
End Class