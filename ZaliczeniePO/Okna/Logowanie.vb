Imports System
Public Class Logowanie
    Friend Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Panel Logowania v1.0"
            Me.Tytuł.Text = "Baza studentów UWM WMII NS"
            Me.Label1.Text = "Adres Email:"
            Me.Label2.Text = "Hasło"
            Me.Button1.Text = "Wyjdź"
            Me.Button2.Text = "Zaloguj"
            Console.WriteLine(Raport.Status2("OK"))
            Try
                Me.Button2.Enabled = False
                Console.WriteLine(Raport.Status3("OK"))
            Catch ex As Exception
                Console.WriteLine(Raport.Status3("Błąd"))
            End Try
        Catch ex As Exception
            Console.WriteLine(Raport.Status2("Błąd"))
        End Try
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If TextBox1.Text Like "*@*.*" Then
            Label3.Visible = True : Label3.Text = "v" : Label3.ForeColor = Drawing.Color.Green
            Console.WriteLine(Raport.Status4("OK")) : Label4.Visible = False
        Else
            Label3.Visible = True : Label3.Text = "x" : Label3.ForeColor = Drawing.Color.Red
            Label4.ForeColor = Drawing.Color.Red : Label4.Text = "Podano błędny format Email!" : Label4.Visible = True
            Console.WriteLine(Raport.Status4("Błąd"))
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Count > 6 Then
            Label5.Visible = False
            Console.WriteLine(Raport.Status5("OK"))
            If TextBox1.Text Like "*@*.*" Then
                Button2.Enabled = True
                Console.WriteLine(Raport.Status6("OK"))
            End If
        Else
            Label5.ForeColor = Drawing.Color.Red : Label5.Text = "Hasło powinno mieć min. 6 znaków" : Label5.Visible = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Login As String = TextBox1.Text
        Dim Hasło As String = TextBox2.Text

    End Sub
End Class