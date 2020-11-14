Public Class App
    Public Shared Function Licz(Monety, Indeks, Kwota, Wartość)

        Static Wsk As Integer = 0
        Dim Ilość As Integer = Kwota / Monety(Indeks)
        If Indeks > 0 Then
            For i As Integer = 0 To Ilość
                If (i > 0) Then
                    Console.Write(Wartość)
                End If
                Dim Obecne As String = ""
                For j As Integer = 0 To i - 1
                    Obecne += Convert.ToString(Monety(Indeks)) + " "
                Next
                Console.Write(Obecne)
                Licz(Monety, Indeks - 1, Kwota - Monety(Indeks) * i, Wartość + Obecne)
            Next
        Else
            For i As Integer = 0 To Ilość - 1
                Console.Write(Monety(Indeks))
            Next
            Console.WriteLine()
            Wsk += 1
        End If
        Return Wsk
    End Function


    Public Shared Sub Show(Monety, Kwota)
        Console.WriteLine($"Mozliwe kombinacje to: " + vbCrLf) : Licz(Monety, Monety.Count - 1, Kwota, "")
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
