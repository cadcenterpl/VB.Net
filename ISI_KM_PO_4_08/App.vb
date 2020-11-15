Public Class App
    Private Name As String
    Public Sub New(ByVal Nazwa As String)
        Name = Nazwa : Console.WriteLine(Nazwa)
    End Sub
    Public Shared Sub Hold()
        Console.WriteLine(vbCrLf + "Aby zakończyć wciśnij dowolny klawisz.")
        Console.ReadKey()
    End Sub
    Public Shared Sub Wyświetl(ByVal Obiekt As Object)
        Console.WriteLine(Obiekt)
    End Sub
    Public Shared Sub Wydruk(ByVal Obiekt As Object)
        Console.Write($"{Obiekt,-20} ")
    End Sub
End Class
