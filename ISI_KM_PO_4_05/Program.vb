Module Program
    Dim Tab1 As New List(Of Double)
    Dim Tab2 As New List(Of Double)
    Sub Main()
        App.Start(Tab1, Tab2)
    End Sub
    Public Sub Action(Tab1 As List(Of Double), Tab2 As List(Of Double))
        App.Show(Tab1, Tab2) : App.enterKey()
    End Sub
End Module