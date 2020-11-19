Imports System.Text.RegularExpressions

Public Class Koder
    Private Tekst() As Char = {} 
    Private Kod() As Char = {"G","A","D","E","R","Y","P","O","L","U","K","I"}
    Public Sub New (Fraza As String)
        Tekst = Fraza.ToUpper
    End Sub
    Public Function Kodowanie() As String
    Dim Wynik As String = ""
    For i As Integer = 0 To Tekst.Count - 1
        If Kod.Contains(Tekst(i)) Then
        For j As Integer = 0 To Kod.Count -1
            If (Tekst(i)=Kod(j)) AndAlso (j mod 2 = 0) Then 
                Wynik += Kod(j+1)
            ElseIf (Tekst(i)=Kod(j)) AndAlso (j mod 2 <> 0) Then 
                Wynik += Kod(j-1)
            End If
        Next
        Else
            Wynik+=Tekst(i)
        End If
    Next
    Return Wynik
    End Function 
End Class