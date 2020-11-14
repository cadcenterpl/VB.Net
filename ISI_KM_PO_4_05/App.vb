Public Class App
    Public Shared Sub Start(Tab1 As List(Of Double), Tab2 As List(Of Double))
        Console.Write("Podaj liczbę n: ") : Dim Liczba As Double = Console.ReadLine()
        For i As Integer = 0 To Liczba - 1
            Console.Write($"Podaj {i + 1}.liczbę Tab1: ")
            Tab1.Add(Console.ReadLine())
        Next
        Program.Action(Tab1, Tab2)
    End Sub
    Public Shared Function ZmienPoz(Tab1 As List(Of Double), Tab2 As List(Of Double))
        Tab2.Add(Tab1.Item(Tab1.Count - 1))
        For i As Integer = 0 To Tab1.Count - 2
            Tab2.Add(Tab1.Item(i))
        Next
        Return Tab2
    End Function
    Public Shared Sub Show(Tab1 As List(Of Double), Tab2 As List(Of Double))
        Console.WriteLine("Tablica Tab2 (Zamienione pozycje o +1):")
        For i As Integer = 0 To ZmienPoz(Tab1, Tab2).Count - 1
            Console.Write($"{ZmienPoz(Tab1, Tab2).item(i).ToString} ")
        Next
    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class