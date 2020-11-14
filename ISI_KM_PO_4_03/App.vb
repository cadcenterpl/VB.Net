Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj liczbę n: ") : Dim Liczba As Double = Console.ReadLine()
        Dim Lista As New List(Of Double)
        For i As Integer = 0 To Liczba - 1
            Console.Write($"Podaj {i + 1}.liczbę: ")
            Lista.Add(Console.ReadLine())
        Next
        Program.Action(Lista)
    End Sub
    Public Shared Function checkWar(lista As List(Of Double), wartosc As Integer)
        Select Case wartosc
            Case 1 : Return lista.Max
            Case 2 : Return lista.Min
        End Select
    End Function
    Public Shared Function checkPoz(lista As List(Of Double), wartosc As Integer)
        For i As Integer = 0 To lista.Count - 1
            If lista.Item(i) = wartosc Then Return i + 1
        Next
    End Function
    Public Shared Function Srednia(lista As List(Of Double))
        Return lista.Average
    End Function
    Public Shared Function Znak(lista As List(Of Double), wartosc As Integer)
        Dim ListaZnakow As New List(Of Double)
        Select Case wartosc
            Case 1 : For i As Integer = 0 To lista.Count - 1
                    If lista.Item(i) > 0 Then ListaZnakow.Add(lista.Item(i))
                Next
            Case 2 : For i As Integer = 0 To lista.Count - 1
                    If lista.Item(i) < 0 Then ListaZnakow.Add(lista.Item(i))
                Next
        End Select
        Return ListaZnakow.Count
    End Function
    Public Shared Sub Show(Lista)
        Console.WriteLine("Informacje o Tablicy:")
        Console.WriteLine($"Wartość i numer pozycji największego elementu: Wartość:{checkWar(Lista, 1)} (poz.{checkPoz(Lista, checkWar(Lista, 1))})")
        Console.WriteLine($"Wartość i numer pozycji najmniejszego elementu: Wartość:{checkWar(Lista, 2)} (poz.{checkPoz(Lista, checkWar(Lista, 2))})")
        Console.WriteLine($"Średnia wartości wszystkich elementów tablicy: {Srednia(Lista)}")
        Console.WriteLine($"Liczba dodatnich elementów tablicy: {Znak(Lista, 1)}")

    End Sub
    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
