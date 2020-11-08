Imports System.Windows.Forms
Public Class Sesja

    Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
    Dim cmd As SqlClient.SqlCommand
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(200) As String
    Dim aView As String
    Dim dlName As String

    Public Sub Sesja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Label1.Text = "Baza Studentów UWM WMII NS. Kamil Martenczuk Programowanie Obiektowe"
        Me.Button1.Text = "Utwórz Kategorię" : Me.Button2.Text = "Skasuj Kategorię"
        Me.Button3.Text = "Dodaj" : Me.Button4.Text = "Kopiuj" : Me.Button5.Text = "Skasuj" : Me.Button6.Text = "Wyjdź"

        Me.ListView1.Clear()
        Me.ListView2.ShowGroups = True
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.ListView2.Clear()
        conn.Open()
        Try
            Dim strQ As String = String.Empty
            strQ = "SELECT Table_Name FROM acam.INFORMATION_SCHEMA.Tables WHERE Table_Name LIKE 'UWM%'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            da = New SqlClient.SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Table")
            Dim usermax As Integer = ds.Tables(0).Rows.Count - 1
            If usermax > -1 Then
                For i = 0 To usermax
                    Me.ListView2.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next
            End If
            Console.WriteLine(Raport.Status13("OK"))
            conn.Close()
            Me.ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            Console.WriteLine(Raport.Status13("Błąd"))
            conn.Close()
        End Try
    End Sub
    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        Dim lvwitem As ListViewItem
        lvwitem = ListView2.SelectedItems.Item(0)
        aView = lvwitem.Text
        If aView <> "" Then
            Me.Button5.Enabled = False
            Me.Button2.Enabled = True
            Call SQLConnect_online()
            If Me.Button4.Text = "Wklej" Then
                Me.Button4.Enabled = True
            ElseIf Me.Button4.Text = "Kopiuj" Then
                Me.Button4.Enabled = False
            End If
            If Me.Button5.Text = "Odrzuć" Then
                Me.Button5.Enabled = True
            ElseIf Me.Button5.Text = "Delete" Then
                Me.Button5.Enabled = False
            End If
            If Me.Button4.Text = "Wklej" Then
                Me.Button4.Enabled = True
            Else Me.Button4.Enabled = False
            End If
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Dim lvwitem1 As ListViewItem
        lvwitem1 = ListView1.SelectedItems.Item(0)
        Dim aView1 As String = lvwitem1.Text
        Button4.Enabled = True
        Button5.Enabled = True
        Label5.Visible = True
        Label5.Text = aView1
        If Me.Button5.Text = "Cancel" Then
            Me.Button5.Enabled = True
        End If
        If Me.Button4.Text = "Paste" Then
            Me.Button4.Enabled = False
        End If

    End Sub

    Friend Sub SQLConnect_online()
        Dim lvwitem As ListViewItem
        lvwitem = ListView2.SelectedItems.Item(0)
        aView = lvwitem.Text
        If aView <> "" Then
            Me.ListView1.Clear()
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "SELECT * FROM [acam].[dbo].[" + aView + "] ORDER BY [Nazwisko, Imię] "
            cmd = New SqlClient.SqlCommand(strQ, conn)
            da = New SqlClient.SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Table")
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To ds.Tables(0).Columns.Count - 1
                Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
            Next
            Try
                For i = 0 To ds.Tables(0).Rows.Count - 1

                    For j = 0 To ds.Tables(0).Columns.Count - 1

                        itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                    Next
                    Dim lvi As New ListViewItem(itemcoll)
                    Me.ListView1.Items.Add(lvi)
                Next
                Console.WriteLine(Raport.Status14("OK"))
                conn.Close()
                Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                MsgBox("...")
            End Try
        End If
        Console.WriteLine(Raport.Status14("Błąd"))
    End Sub

    Public Sub MyLibrary()
        ListView1.Clear()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = True : TextBox1.Visible = True : Button7.Visible = True : Button8.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label2.Visible = False : TextBox1.Visible = False : Button7.Visible = False : Button8.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
        Console.WriteLine(Raport.Status15("OK"))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim nazwa = TextBox1.Text
        Call SQL_Creator.Creation(nazwa)
        Me.Sesja_Load(e, e)
        Me.Button8.Visible = False
        Me.Button7.Visible = False
        Me.TextBox1.Visible = False
        Me.Label2.Visible = False
        Me.TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call SQL_Creator.Delete(aView)
        Call Sesja_Load(e, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Odrzuć" Then
            Button3.Text = "Dodaj"
            Button4.Text = "Kopiuj"
        Else
            Me.Button9.Visible = True : Me.Button10.Visible = True
            Me.TextBox2.Visible = True : Me.TextBox3.Visible = True
            Me.Label3.Visible = True : Me.Label4.Visible = True
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Button9.Visible = False : Me.Button10.Visible = False
        Me.TextBox2.Visible = False : Me.TextBox3.Visible = False
        Me.Label3.Visible = False : Me.Label4.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Nazwa As String = TextBox2.Text
        Dim Numer As String = TextBox3.Text
        Call SQL_Creator.MakeItems(Nazwa, Numer, aView)
        Me.Button9.Visible = False : Me.Button10.Visible = False
        Me.TextBox2.Visible = False : Me.TextBox3.Visible = False
        Me.Label3.Visible = False : Me.Label4.Visible = False
        TextBox2.Text = "" : TextBox3.Text = ""
        Call SQLConnect_online()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.Button4.Text = "Kopiuj" Then
            Me.Button4.Text = "Wklej"
            Me.Button3.Text = "Odrzuć"
            Me.Button3.Enabled = True
            Me.Label6.Text = aView
        Else
            Me.Button4.Text = "Kopiuj"
            Dim sLib As String = Me.Label6.Text
            Dim destLib As String = aView
            Label7.Text = destLib
            Dim pozycja As String = Me.Label5.Text
            Call SQL_Creator.CopyItems(pozycja, destLib, sLib)
            Button3.Text = "Dodaj"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pozycja As String = Me.Label5.Text
        Button5.Enabled = False
        Button4.Enabled = False
        Call SQL_Creator.DeleteItems(pozycja, aView)
        Call SQLConnect_online()
    End Sub
End Class