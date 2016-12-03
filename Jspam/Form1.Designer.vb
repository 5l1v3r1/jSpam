<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.usernamebox = New System.Windows.Forms.TextBox()
        Me.subjectbox = New System.Windows.Forms.TextBox()
        Me.Tobox = New System.Windows.Forms.TextBox()
        Me.messagebox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sent = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(297, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "end"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(12, 67)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(155, 20)
        Me.passwordbox.TabIndex = 3
        '
        'usernamebox
        '
        Me.usernamebox.Location = New System.Drawing.Point(12, 26)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(155, 20)
        Me.usernamebox.TabIndex = 4
        '
        'subjectbox
        '
        Me.subjectbox.Location = New System.Drawing.Point(12, 105)
        Me.subjectbox.Name = "subjectbox"
        Me.subjectbox.Size = New System.Drawing.Size(155, 20)
        Me.subjectbox.TabIndex = 5
        '
        'Tobox
        '
        Me.Tobox.Location = New System.Drawing.Point(12, 144)
        Me.Tobox.Name = "Tobox"
        Me.Tobox.Size = New System.Drawing.Size(155, 20)
        Me.Tobox.TabIndex = 6
        '
        'messagebox
        '
        Me.messagebox.Location = New System.Drawing.Point(12, 218)
        Me.messagebox.Multiline = True
        Me.messagebox.Name = "messagebox"
        Me.messagebox.Size = New System.Drawing.Size(365, 117)
        Me.messagebox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Message"
        '
        'sent
        '
        Me.sent.AutoSize = True
        Me.sent.Location = New System.Drawing.Point(219, 202)
        Me.sent.Name = "sent"
        Me.sent.Size = New System.Drawing.Size(13, 13)
        Me.sent.TabIndex = 13
        Me.sent.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sent:"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 347)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.messagebox)
        Me.Controls.Add(Me.Tobox)
        Me.Controls.Add(Me.subjectbox)
        Me.Controls.Add(Me.usernamebox)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents usernamebox As System.Windows.Forms.TextBox
    Friend WithEvents subjectbox As System.Windows.Forms.TextBox
    Friend WithEvents Tobox As System.Windows.Forms.TextBox
    Friend WithEvents messagebox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sent As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
