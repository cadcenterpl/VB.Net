Imports System
Public Class Nodek
    Public Property wart As String : Public Property nast As Nodek
    Public Sub New(ByVal wartosc As String)
        wart = wartosc
    End Sub
End Class

Public Class LinkedLista
    Public Property head As Nodek : Public Property tail As Nodek

    Public Sub Push(ByVal str As String)
        Dim node As Nodek = New Nodek(str) : node.nast = head : head = node
    End Sub

    Public Sub Append(ByVal str As String)
        Dim sh = head : Dim node As Nodek = New Nodek(str) : While sh.nast isNot Nothing : sh = sh.nast : End While : sh.nast = node
    End Sub

    Public Function Pop() As Nodek
        Dim pierwszy = head : head = head.nast : return pierwszy
    End Function

    Public Function Widok() As String
        Dim sh = head : Dim val As String = ""
        While sh.nast isNot Nothing : val += (sh.wart + " -> ") : sh = sh.nast : End While : val += sh.wart : return val
    End Function
End Class

Module Program
    Public Sub print(ByVal str As String)
        Console.WriteLine(str)
    End Sub

    Sub Main(args As String())
        Dim Lista1 As LinkedLista = New LinkedLista()
        For i As Integer = 0 to 3 : Lista1.Push(i) : Next
        print($"Efekt Push   : {Lista1.Widok}")
        For i As Integer = 1 to 4 : Lista1.Append(i) : Next
        print($"Efekt Append : {Lista1.Widok}")
        print($"Pierwszy el. : {Lista1.Pop().wart}")
        print($"Efekt Pop    : {Lista1.Widok}")
    End Sub
End Module
