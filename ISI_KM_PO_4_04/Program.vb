Module Program
    Dim Tablica As New List(Of Double)
    Sub Main()
        App.Start(Tablica)
    End Sub
    Public Sub Action(Tablica As List(Of Double))
        App.Show(Tablica) :: App.enterKey()
    End Sub
End Module
