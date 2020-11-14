Public Class App
    Public Shared Sub Start(Tablica)
        Dim Rand As Random = New Random()
        For i As Integer = 0 To 99
            Tablica.Add(Rand.Next(1, 1000))
        Next
        Action(Tablica)
    End Sub
    Public Shared Function Pierwsze(Tablica As List(Of Double))
        Dim TabPierwsze As New List(Of Double)
        For i As Integer = 0 To Tablica.Count - 1
            Dim TabDzielniki As New List(Of Double)
            For j As Integer = 1 To Tablica.Item(i)
                If Tablica.Item(i) Mod j = 0 Then
                    TabDzielniki.Add(Tablica.Item(i))
                End If
            Next
            If TabDzielniki.Count < 3 And TabDzielniki.Count > 1 Then
                TabPierwsze.Add(Tablica.Item(i))
            End If
        Next
        Return TabPierwsze
    End Function
    Public Shared Sub Show(Tablica)
        Console.WriteLine("Liczby pierwsze Tablicy Randomowej 100 elementowej (1-999)")
        For i As Integer = 0 To Pierwsze(Tablica).Count - 1
            Console.Write($"{Pierwsze(Tablica).Item(i),6}")
        Next
    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
