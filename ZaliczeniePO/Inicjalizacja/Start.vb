Module Start
    Dim Autor As String = "K.Martenczuk"
    Dim Przedmiot As String = "Programowanie Obiektowe"
    Dim Prowadzący As String = "M.Kolev"

    Dim Klawisz As ConsoleKeyInfo
    Dim Logowanie As Logowanie = New Logowanie()

    Sub Main()
        Console.WriteLine(Raport.Tytul(Autor, Przedmiot, Prowadzący))
        Console.WriteLine("Aby rozpocząć wciśnij Enter | ESC - Wyjście")
        Do
            Klawisz = Console.ReadKey(True)
        Loop While (Klawisz.Key <> ConsoleKey.Enter And Klawisz.Key <> ConsoleKey.Escape)
        If Klawisz.Key = ConsoleKey.Enter Then Call Start_Logowanie()
    End Sub

    Public Sub Start_Logowanie()
        Console.WriteLine(vbCrLf + "Schemat:")
        Try
            Dim Logowanie1 As Logowanie = New Logowanie()
            Console.WriteLine(Raport.Status1("OK")) : Logowanie1.ShowDialog()
        Catch ex As Exception
            Console.WriteLine(Raport.Status1("Błąd"))
        End Try
    End Sub
    Public Sub Sprawdzenie_Danych_Logowania(Login, Hasło)
        Try
            Console.WriteLine(Raport.Status8("OK"))
            Call SQL.SQL_Logowanie(Login, Hasło)

        Catch ex As Exception
            Console.WriteLine(Raport.Status8("Błąd"))
        End Try
    End Sub
    Public Sub Sesja_Start(dostęp)
        If dostęp = "OK" Then
            Try
                Console.WriteLine(Raport.Status12("OK"))
                Dim Sesja1 As Sesja = New Sesja() : Sesja1.ShowDialog()
            Catch ex As Exception
                Console.WriteLine(Raport.Status12("Błąd"))
            End Try
        End If
    End Sub
End Module
