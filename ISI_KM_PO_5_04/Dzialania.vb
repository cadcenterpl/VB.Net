Public Class Dzialania
    Public Shared Function NowaTabWymno(ByVal tab() As Integer, mno As Integer)
        Dim tabNowa(tab.Count-1) As Integer 
        For i As Integer = 0 To tab.Count - 1
            tabNowa(i) =tab(i)*mno
        Next
        Return (tabNowa)
    End Function
    Public Shared Sub Wymno(ByRef tab() As Integer, mno As Integer)
        For i As Integer = 0 To tab.Count - 1
            tab(i) *= mno
        Next
    End Sub
End Class