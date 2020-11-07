<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logowanie
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tytuł = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tytuł
        '
        Me.Tytuł.AutoSize = True
        Me.Tytuł.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Tytuł.Location = New System.Drawing.Point(13, 21)
        Me.Tytuł.Name = "Tytuł"
        Me.Tytuł.Size = New System.Drawing.Size(45, 20)
        Me.Tytuł.TabIndex = 0
        Me.Tytuł.Text = "XXX"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 81)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 125)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(285, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(285, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(12, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "v"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Logowanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(320, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Tytuł)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Logowanie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tytuł As Windows.Forms.Label
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
End Class
