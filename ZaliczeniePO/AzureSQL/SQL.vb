Public Class SQL
    Public Shared Sub SQL_Logowanie(Email, Hasło)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "SELECT * FROM [acam].[dbo].[PO_Logowanie] WHERE EMAIL LIKE '" + Email + "' AND HASŁO LIKE'" + Hasło + "'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            Dim da = New SqlClient.SqlDataAdapter(cmd)
            Dim ds = New DataSet
            da.Fill(ds, "Table")
            Console.WriteLine(Raport.Status9("OK"))
            If ds.Tables(0).Rows.Count > 0 Then
                Console.WriteLine(Raport.Status10("OK"))
                Dim Status As String = ds.Tables(0).Rows(0)(2).ToString
                If Status = "aktywny" Then
                    Console.WriteLine(Raport.Status11("OK"))
                    Call Sesja_Start("OK")
                Else
                    Console.WriteLine(Raport.Status11("Błąd"))
                    MsgBox("Użytkownik zablokowany!")
                End If
            Else
                Console.WriteLine(Raport.Status10("Błąd"))
                MsgBox("Błędne dane logowania!")
            End If
            conn.Close()
        Catch ex As Exception
            Console.WriteLine(Raport.Status9("Błąd"))
            MsgBox("Brak połączenia z internetem!")
        End Try
    End Sub
End Class

Public Class SQL_Creator

    Public Shared Sub Creation(nazwa)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "CREATE TABLE UWM_" + nazwa + " ([Nazwisko, Imię] [nvarchar](50) NOT NULL UNIQUE,[Nr Albumu] [nvarchar](6) NOT NULL)"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie utworzono Tabeli")
        End Try
    End Sub

    Public Shared Sub Delete(nazwa)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "DROP TABLE " + nazwa
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skasowano Tabeli " + nazwa)
        End Try
    End Sub
    Public Shared Sub CopyItems(pozycja, destlib, sLib)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "Insert Into " + destlib + " Select *" + " From " + sLib + " WHERE [Nazwisko, Imię] Like '" + pozycja + "'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skopiowano pozycji " + pozycja)
        End Try
    End Sub
    Public Shared Sub DeleteItems(pozycja, sLib)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "Delete FROM " + sLib + " WHERE [Nazwisko, Imię] Like '" + pozycja + "'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skasowano z " + sLib + " pozycji " + pozycja)
        End Try
    End Sub
    Public Shared Sub MakeItems(Nazwa, Numer, destlib)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = $"Insert Into {destlib} ([Nazwisko, Imię], [Nr Albumu]) VALUES ('{Nazwa}', '{Numer}')"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox($"Nie utworzono: {Nazwa}")
        End Try
    End Sub
End Class
