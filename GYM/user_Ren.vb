Public Class user_Ren
    Dim start, ends As String
    Sub find()
        Try
            DataGridView1.Rows.Clear()
            Form1.conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select id,surname from users where id like '" & TextBox1.Text & "%' or name like '" & TextBox1.Text & "%'", Form1.conn)

            Form1.dr = cmd.ExecuteReader
            While Form1.dr.Read
                If Form1.dr.Item("id") <> "" Then

                    DataGridView1.Rows.Add(Form1.dr.Item("id"), Form1.dr.Item("surname"))

                End If

            End While
            Form1.conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        find()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Clear()
        End If
        find()
    End Sub
    Dim id As String = ""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.add_abs(id, txt_abn.SelectedIndex)
    End Sub



    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        Try

            id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()




            Label2.Text = "ID : " & DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Label3.Text = "Nom : " & DataGridView1.SelectedRows(0).Cells(1).Value.ToString()



        Catch ex As Exception

        End Try





    End Sub
End Class