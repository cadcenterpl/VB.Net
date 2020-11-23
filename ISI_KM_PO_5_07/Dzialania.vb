Public Class Dzialania
    Public Shared Function LiczenieW(ByVal x As Integer, n As Integer)
        Dim W As Integer = 0
        For i As Integer = 1 To n
            W += (x+i)
        Next
        Return (W)
    End Function
End Class

