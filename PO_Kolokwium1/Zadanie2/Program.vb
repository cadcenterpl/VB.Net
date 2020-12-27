Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Największa ujemna na 3 funkcjach")
        Dim m As Integer : Do : m = Aplikacja.Odp("Podaj wyraz m : ", "*") : Loop Until (m>=0) AndAlso (m <=10) 
        Dim n As Integer : Do : n = Aplikacja.Odp("Podaj wyraz n : ", "*") : Loop Until (n>=0) AndAlso (n <=10) 
        Dim Macierz1 = Dzialania.Macierz(m,n)
        Dim NU = Dzialania.Szukaj(Macierz1,m,n)
        Aplikacja.Wyswietl($"Największa ujemna wartość to: {Dzialania.Szukaj(Macierz1,m,n)}")
        For i As Integer = 0 To m -1
            For j As Integer = 0 To n -1
                If Macierz1(i,j) = NU Then
                Aplikacja.Wyswietl($"Lokalizacja: ({i},{j})")
                End If
            Next
        Next
        Aplikacja.Zatrzymaj()
    End Sub
End Module

Public Class Dzialania
    Public Shared Function Macierz(ByVal m As Integer, n As Integer)
        Dim Mac(m,n) As Integer
        For i as Integer = 0 To m -1
            For j as Integer = 0 To n -1
                Console.Write($"Podaj wartosc ({i},{j}) tablicy:")
                Mac(i,j) = Console.ReadLine()
            Next
        Next
        Return (Mac)
    End Function
    Public Shared Function Szukaj(ByVal Mac(,) As Integer, m As Integer, n As Integer)
        Dim maks As Integer = Integer.MinValue
            For i As Integer = 0 to m - 1
                For j As Integer = 0 to n -1
                    If Mac(i,j) < 0 AndAlso Mac(i,j) > maks Then maks = Mac(i,j) 
                Next
            Next
        If maks = Integer.MinValue Then Return 0
        Return maks
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
