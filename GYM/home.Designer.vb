<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenovellLabonnementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuprimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GYM"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenovellLabonnementToolStripMenuItem, Me.EditeToolStripMenuItem, Me.SuprimeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 70)
        '
        'RenovellLabonnementToolStripMenuItem
        '
        Me.RenovellLabonnementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RenovellLabonnementToolStripMenuItem.Name = "RenovellLabonnementToolStripMenuItem"
        Me.RenovellLabonnementToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RenovellLabonnementToolStripMenuItem.Text = "Renovell l'abonnement"
        '
        'EditeToolStripMenuItem
        '
        Me.EditeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditeToolStripMenuItem.Name = "EditeToolStripMenuItem"
        Me.EditeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EditeToolStripMenuItem.Text = "Modifier"
        '
        'SuprimeToolStripMenuItem
        '
        Me.SuprimeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SuprimeToolStripMenuItem.Name = "SuprimeToolStripMenuItem"
        Me.SuprimeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SuprimeToolStripMenuItem.Text = "Supprimé"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(4, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Ajouté"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(4, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Renovell l'abonnement"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(4, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Parametre"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(239, 172)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1184, 517)
        Me.ListView1.TabIndex = 10
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
        Me.ColumnHeader2.Text = "Prenom"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nom"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Email"
        Me.ColumnHeader4.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Telephone"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Abonnement"
        Me.ColumnHeader9.Width = 110
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Enregistrement"
        Me.ColumnHeader10.Width = 150
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Date d'expiration"
        Me.ColumnHeader11.Width = 150
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 692)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1435, 25)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 20)
        Me.Label2.Text = "Nombre total de clients : 0"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(960, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 22)
        Me.TextBox1.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1303, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 28)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Recherche"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(950, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 29)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1435, 717)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GYM"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenovellLabonnementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuprimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label2 As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
