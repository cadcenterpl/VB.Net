Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Zamiana. Zadanie 1. Zestaw 3.")
        Dim tab1(2) As Integer
        tab1(0) = Aplikacja.Odp("Podaj liczbę 1. : ", "*")
        tab1(1) = Aplikacja.Odp("Podaj liczbę 2. : ", "*")
        Dzialania.Oblicz(tab1)
        Console.WriteLine($"Liczba 1. = {tab1(0)} Liczba 2. = {tab1(1)}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module

Public Class Dzialania
    Public Shared Function Oblicz(ByVal tab1() As Integer)
    If (tab1(1) < tab1(0)) Then 
        Dim c = tab1(0) : tab1(0)=tab1(1) : tab1(1)=c
    End If
    Return (tab1)
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
