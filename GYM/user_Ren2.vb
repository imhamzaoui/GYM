Public Class user_Ren2
    Public id As String
    Private Sub user_Ren2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.add_abs(id, txt_abn.SelectedIndex)
        Me.Close()
    End Sub
End Class