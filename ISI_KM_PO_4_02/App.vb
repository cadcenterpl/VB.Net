Public Class App
    Public Shared Sub Start()
        Dim Tab1 As New List(Of Integer)
        For i As Integer = 0 To 9
            Console.WriteLine($"Podaj {i + 1}.liczbę: ")
            Tab1.Add(Console.ReadLine())
        Next
        Program.Action(Tab1)
    End Sub
    Public Shared Function Licz(Tab1)
        Dim Tab2 As New List(Of Integer)
        For i As Integer = 0 To Tab1.Count - 1
            If Tab1.Item(i) > 0 Then
                Tab2.Add(Tab1.Item(i))
            End If
        Next
        For i As Integer = 0 To Tab2.Count - 1
            Console.Write($"{Tab2.Item(i)} ")
        Next
        Console.WriteLine()
        Return 0
    End Function

    Public Shared Sub Show(Tab1)
        Console.WriteLine($"Liczby dodatnie (Tab2) to:" + vbCrLf) : Licz(Tab1)
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
