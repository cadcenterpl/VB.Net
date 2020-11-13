Public Class App
    Public Shared Sub Start()
        Console.Write("Podaj liczbę n: ") : Dim Liczba As Integer = Console.ReadLine() : Module1.Action(Liczba)
    End Sub

    Public Shared Function Licz(Liczba)
        Dim Suma As Integer = 1 : Dim Wsk As Integer = 1
        Do
            If Wsk < Liczba Then : Suma -= Wsk + 1 : Wsk += 1 : End If
            If Wsk < Liczba Then : Suma += Wsk + 1 : Wsk += 1 : End If
        Loop Until Wsk >= Liczba
        Return Suma
    End Function

    Public Shared Sub Show(Liczba)
        Console.WriteLine($"Suma szeregu 1-2+3-4...+/-n przxy n={Liczba} wynosi : {Licz(Liczba)}" + vbCrLf) : Module1.Main()
    End Sub

    Public Shared Sub enterKey()
        Console.ReadKey()
    End Sub
End Class