<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userView
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
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(46, 166)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(183, 23)
        Me.txt_phone.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Phone"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(46, 211)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(183, 23)
        Me.txt_email.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email"
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(46, 122)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(183, 23)
        Me.txt_prenom.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Prenom"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(46, 78)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(183, 23)
        Me.txt_nom.TabIndex = 17
        Me.txt_nom.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nom"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(46, 34)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(183, 23)
        Me.txt_id.TabIndex = 27
        Me.txt_id.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 48)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'userView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "userView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
