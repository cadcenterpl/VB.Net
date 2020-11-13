Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj liczbę n: ") : Dim Liczba As Integer = Console.ReadLine() : Program.Action(Liczba)
    End Sub

    Public Shared Function Licz(Liczba)
        Dim Wsk As Integer = 0 : Dim Dzielnik As Integer = 0 : Dim Suma As Integer = 0
        Do
            Wsk += 1
            If (Wsk <= Liczba) And (Wsk Mod 2 = 0) Then
                Suma = 0
                For i As Integer = 1 To Wsk - 1
                    If (Wsk Mod i = 0) Then
                        Dzielnik = i
                        Suma += Dzielnik
                    End If
                Next
                If Wsk = Suma Then
                    Console.Write($"{Wsk},")
                End If
            End If
        Loop Until Wsk > Liczba
        Console.WriteLine()
        Return 0
    End Function

    Public Shared Sub Show(Liczba)
        Console.WriteLine($"Liczby doskonałe w przedziale <1,{Liczba}> to : ") : Licz(Liczba) : Program.Main()
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class
