Public Class Dzialania
    Public Shared Sub Wymno(ByRef tab() As Integer, mno As Integer)
        For i As Integer = 0 To tab.Count - 1
            tab(i) *= mno
        Next
    End Sub

    Public Shared Sub Wymno(ByRef tab() As String, mno As Integer)
        Dim Temp(tab.Count) As String
            For j As Integer = 0 To tab.Count - 1
                For i As Integer = 0 To mno -1 : Temp(j) += tab(j) :Next
            Next : tab = Temp
        End Sub
End Class