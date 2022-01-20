<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_enter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_abn = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(214, 27)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(183, 23)
        Me.txt_nom.TabIndex = 1
        Me.txt_nom.Tag = ""
        Me.txt_nom.Text = "hamzaoui"
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(25, 27)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(183, 23)
        Me.txt_prenom.TabIndex = 0
        Me.txt_prenom.Text = "mohamed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prenom"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(214, 71)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(183, 23)
        Me.txt_email.TabIndex = 3
        Me.txt_email.Text = "gg@gmail.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(25, 71)
        Me.txt_phone.MaxLength = 8
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(183, 23)
        Me.txt_phone.TabIndex = 2
        Me.txt_phone.Text = "9698989"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone"
        '
        'txt_enter
        '
        Me.txt_enter.Enabled = False
        Me.txt_enter.Location = New System.Drawing.Point(25, 120)
        Me.txt_enter.Name = "txt_enter"
        Me.txt_enter.Size = New System.Drawing.Size(183, 23)
        Me.txt_enter.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Entre"
        '
        'txt_abn
        '
        Me.txt_abn.FormattingEnabled = True
        Me.txt_abn.Items.AddRange(New Object() {"1 mois", "3 mois", "6 mois", "1 ans"})
        Me.txt_abn.Location = New System.Drawing.Point(214, 120)
        Me.txt_abn.Name = "txt_abn"
        Me.txt_abn.Size = New System.Drawing.Size(183, 23)
        Me.txt_abn.TabIndex = 5
        Me.txt_abn.Tag = ""
        Me.txt_abn.Text = "1 mois"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Abonnement"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'newC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 268)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_abn)
        Me.Controls.Add(Me.txt_enter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newC"
        Me.Text = "newC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_enter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_abn As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
