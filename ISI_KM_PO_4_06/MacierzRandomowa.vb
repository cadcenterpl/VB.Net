Public Class MacierzRandomowa
    Private Macierz(,) As Integer
    Private Row, Col As Integer
    Public Sub New(ByVal Rows As Integer, Columns As Integer, zakresA As Integer, zakresB As Integer)
        Row = Rows - 1 : Col = Columns - 1
        ReDim Macierz(Row, Col)
        Dim Rand As Random = New Random()
        For i As Integer = 0 To Row
            For j As Integer = 0 To Col
                Macierz(i, j) = Rand.Next(zakresA, zakresB)
            Next
        Next
    End Sub
    Public Function Pokaz()
        For i As Integer = 0 To Row
            For j As Integer = 0 To Col
                Console.Write($"{Me.Macierz(i, j)} ")
            Next
            Console.Write(Environment.NewLine)
        Next
    End Function
    Public Function Tr()
        Dim Suma As Double
        For i As Integer = 0 To Row
            Suma += Me.Macierz(i, i)
        Next
        Return Suma
    End Function
End Class
