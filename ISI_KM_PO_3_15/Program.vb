Module Program
    Sub Main()
        Static A As Integer = 1
        Static B As Integer = 2
        Static C As Integer = 5
        Static Kwota As Integer = 10
        Dim Monety As New List(Of Integer) : Monety.Add(A) : Monety.Add(B) : Monety.Add(C)
        App.Show(Monety, Kwota) : App.enterKey()
    End Sub
End Module
