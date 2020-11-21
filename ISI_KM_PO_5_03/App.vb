Public Class App
    Private Name As String
    Private Konstrukcja As String
    Public Sub New(ByVal Nazwa As String)
        Name = Nazwa : Console.WriteLine(Nazwa)
    End Sub
    Public Sub Zatrzymaj()
        Console.WriteLine(vbCrLf + "Aby zakończyć wciśnij dowolny klawisz.")
        Console.ReadKey()
    End Sub
    Public Sub Wyswietl(ByVal Obiekt As Object)
        Console.WriteLine(Obiekt)
    End Sub

    Public Sub Wydrukuj(ByVal Obiekt As Object)
        Console.Write(Obiekt)
    End Sub

    Public Shared Function OdpUzytkownika(ByVal Polecenie As String, Format As String)
        Dim Odpowiedź As String
        Do
            Console.Write(Polecenie)
            Odpowiedź = Console.ReadLine()
        Loop Until Odpowiedź Like Format
        Return Odpowiedź
    End Function
End Class
