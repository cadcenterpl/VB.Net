Public Class Dzialania
    Public Shared Function LiczenieSumyCyfr(ByVal x As String)
    Dim S As Integer = 0
    For i As Integer = 0 To x.Count-1
        S+=Integer.Parse(x(i))
    Next
    Return (S)
    End Function
End Class

