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
