Public Class userView
    Public id, nom As String

    Private Sub userView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '(ByRef id, name, surname, email, phone, subs, start, ends)




        Form1.update_CV(id, nom, txt_id.Text, txt_nom.Text, txt_prenom.Text, txt_email.Text, txt_phone.Text)

        Me.Close()
    End Sub
End Class