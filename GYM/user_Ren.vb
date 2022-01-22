
Public Class user_Ren
    Dim start, ends As String
    'Public dr As OleDbDataReader
    Sub find()
        Try
            'DataGridView1.Rows.Clear()
            ListView1.Items.Clear()
            Form1.conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select id,surname from users where id like '" & TextBox1.Text & "%' or name like '" & TextBox1.Text & "%'", Form1.conn)

            Form1.dr = cmd.ExecuteReader
            While Form1.dr.Read
                If Form1.dr.Item("id") <> "" Then
                    Dim newItem As New ListViewItem(Form1.dr.Item("id").ToString)
                    newItem.SubItems.Add(Form1.dr.Item("surname"))
                    ListView1.Items.Add(newItem)

                    'DataGridView1.Rows.Add(Form1.dr.Item("id"), Form1.dr.Item("surname"))

                End If

            End While
            Form1.conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.ListView1.Items.Count <> 0 Then
            find()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Clear()
        End If
        If Form1.ListView1.Items.Count <> 0 Then
            find()
        End If

    End Sub
    Dim id As String = ""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.add_abs(id, txt_abn.SelectedIndex)
    End Sub

    Private Sub user_Ren_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Try

            'id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            id = ListView1.SelectedItems.Item(0).SubItems(0).Text



            Label2.Text = "ID : " & ListView1.SelectedItems.Item(0).SubItems(0).Text
            Label3.Text = "Nom : " & ListView1.SelectedItems.Item(0).SubItems(1).Text.ToUpper



        Catch ex As Exception

        End Try
    End Sub
End Class