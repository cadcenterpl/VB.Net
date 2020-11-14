Public Class App
    Public Shared Sub Hold()
        Console.WriteLine(vbCrLf + "Aby zakończyć wciśnij dowolny klawisz.")
        Console.ReadKey()
    End Sub
    Public Shared Sub Wyświetl(ByVal Obiekt)
        Console.Write(Obiekt)
    End Sub
End Class
