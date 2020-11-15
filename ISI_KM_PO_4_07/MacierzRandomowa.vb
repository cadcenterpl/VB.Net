Public Class MacierzRandomowa

    Private Pozycja(,) As Integer
    Private Row, Col As Integer
    Shared Rand As Random = New Random()
    Public Sub New(ByVal Rows As Integer, Columns As Integer, zakresA As Integer, zakresB As Integer)
        Row = Rows - 1 : Col = Columns - 1
        ReDim Pozycja(Row, Col)
        For i As Integer = 0 To Row
            For j As Integer = 0 To Col
                Pozycja(i, j) = Rand.Next(zakresA, zakresB)
            Next
        Next
    End Sub
    Public Function Widok()
        For i As Integer = 0 To Row
            For j As Integer = 0 To Col
                Console.Write($"{Me.Pozycja(i, j)} ")
            Next
            Console.Write(Environment.NewLine)
        Next
    End Function
    Public Function Tr()
        Dim Suma As Double
        For i As Integer = 0 To Row
            Suma += Me.Pozycja(i, i)
        Next
        Return Suma
    End Function
    Public Function Suma(MacierzTemp As MacierzRandomowa)
        For i As Integer = 0 To Row
            For j As Integer = 0 To Col
                Me.Pozycja(i, j) += MacierzTemp.Pozycja(i, j)
            Next
        Next
        Return Me
    End Function

End Class
