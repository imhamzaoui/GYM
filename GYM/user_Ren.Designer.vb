<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user_Ren
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_abn = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(219, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(22, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 25)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID ou Prenom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(22, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Abonnement"
        '
        'txt_abn
        '
        Me.txt_abn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_abn.FormattingEnabled = True
        Me.txt_abn.Items.AddRange(New Object() {"1 mois", "3 mois", "6 mois", "1 ans"})
        Me.txt_abn.Location = New System.Drawing.Point(22, 224)
        Me.txt_abn.Name = "txt_abn"
        Me.txt_abn.Size = New System.Drawing.Size(137, 25)
        Me.txt_abn.TabIndex = 16
        Me.txt_abn.Tag = ""
        Me.txt_abn.Text = "1 mois"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(165, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Ajouté"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(22, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(140, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nom : "
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(22, 71)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(278, 109)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 180
        '
        'user_Ren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(331, 283)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_abn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "user_Ren"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user_Ren"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_abn As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
