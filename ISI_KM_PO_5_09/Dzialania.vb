Public Class Dzialania
    Public Shared Function WyrazCiagu_Rekurencja(ByVal n As String)
    If (n<3) Then Return 1 
    Return WyrazCiagu_Rekurencja(n-1)+WyrazCiagu_Rekurencja(n-2)
    End Function
    Public Shared Function WyrazCiagu_Iteracja(ByVal n As String)
    If (n<3) Then Return 1 
    Dim x As Integer = 0 : Dim y As Integer = 1
    For i As Integer = 0 To n - 1 
        Dim Temp As Integer = x + y
        x = y
        y = Temp
    Next
    Return x
    End Function
End Class
