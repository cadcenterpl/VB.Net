Public Class App
    Public Shared Sub start()
        Console.Write("Podaj rok: ")
        Dim rok As Int32 = Console.ReadLine()
        Call Program.action(rok)
    End Sub

    Shared Function check(rok)
        If ((rok Mod 4 = 0) And (rok Mod 100 <> 0)) Or ((rok Mod 4 = 0) And (rok Mod 100 = 0) And (rok Mod 400 = 0)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub show(rok)
        Console.WriteLine("Czy rok jest przystępny: " + App.check(rok).ToString)
    End Sub

    Public Shared Sub enterkey()
        Console.ReadKey()
    End Sub

End Class
