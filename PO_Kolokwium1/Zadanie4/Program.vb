Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Sprawdzanie dodatnich, ujemnych i zer:")
        Dim Lista as New List(of Integer)
        Dim n As Integer : Do : n = Aplikacja.Odp("Podaj wyraz n : ", "*") : Loop Until n >0
        For i As Integer = 0 To n - 1
            Lista.Add(Aplikacja.Odp($"Podaj liczbę {i+1} : ", "*"))
        Next
        Aplikacja.Wyswietl($"Dodatnich: {Dzialania.ObliczPlus(Lista)}, Ujemnych: {Dzialania.ObliczMinus(Lista)}, Zero: {Dzialania.ObliczZero(Lista)}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module

Public Class Dzialania
    Public Shared Function ObliczPlus(Lista) As Integer
        Dim wartosc As Integer = 0 
        For i As Integer = 0 To Lista.Count - 1
            If Lista(i) > 0 Then wartosc += 1
        Next
        Return wartosc
    End Function  
        Public Shared Function ObliczMinus(Lista) As Integer
        Dim wartosc As Integer = 0 
        For i As Integer = 0 To Lista.Count - 1
            If Lista(i) < 0 Then wartosc += 1
        Next
        Return wartosc
    End Function 
        Public Shared Function ObliczZero(Lista) As Integer
        Dim wartosc As Integer = 0 
        For i As Integer = 0 To Lista.Count - 1
            If Lista(i) = 0 Then wartosc += 1
        Next
        Return wartosc
    End Function 
End Class

Public Class App
    Private Name As String
    Private Konstrukcja As String
    Public Sub New(ByVal Nazwa As String)
        Name = Nazwa : Console.WriteLine(Nazwa)
    End Sub
    Public Sub Zatrzymaj()
        Console.WriteLine(vbCrLf + "Aby zakończyć wciśnij dowolny klawisz.")
        Console.ReadKey()
    End Sub
    Public Sub Wyswietl(ByVal Obiekt As Object)
        Console.WriteLine(Obiekt)
    End Sub

    Public Sub Wydrukuj(ByVal Obiekt As Object)
        Console.Write(Obiekt)
    End Sub

    Public Function Odp(ByVal Polecenie As String, Format As String)
        Dim Odpowiedź As String
        Do
            Console.Write(Polecenie)
            Odpowiedź = Console.ReadLine()
        Loop Until Odpowiedź Like Format
        Return Odpowiedź
    End Function
End Class
