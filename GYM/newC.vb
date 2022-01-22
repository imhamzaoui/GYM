Public Class newC
    Dim dt As String = DateTime.Now.ToString("dd/MM/yyyy")


    Dim total_tarif() As String



    Private Sub newC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' add tarif to label



        Me.txt_enter.Text = dt
        label_prix.Text = total_tarif(0).ToString + " DT"

    End Sub
    Dim _bol As Boolean = False


    Private Sub newC_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If txt_enter.Enabled = False Then
            txt_enter.Enabled = True
            _bol = True
        Else
            _bol = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mdate As Date
        If _bol = False Then
            mdate = Now
        Else ' 22/22/2001
            mdate = Convert.ToDateTime(txt_enter.Text.Substring(3, 2) + "/" + txt_enter.Text.Substring(0, 2) + "/" + txt_enter.Text.Substring(6, 4))
        End If
        Dim kk As Date
        Select Case txt_abn.SelectedIndex
            Case 0
                kk = mdate.AddMonths(1)
            Case 1
                kk = mdate.AddMonths(3)
            Case 2
                kk = mdate.AddMonths(6)
            Case 3
                kk = mdate.AddYears(1)
        End Select
        'add_CV(ByRef name, surname, cin, phone, subs, start, ends)
        Form1.add_CV(txt_nom.Text, txt_prenom.Text, txt_email.Text, txt_phone.Text, txt_abn.Text, txt_enter.Text, kk.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_abn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_abn.SelectedIndexChanged
        total_tarif = admin_para.getuser().Split("-")
        Select Case txt_abn.SelectedIndex
            Case 0
                label_prix.Text = total_tarif(0).ToString + " DT"
            Case 1
                label_prix.Text = total_tarif(1).ToString + " DT"
            Case 2
                label_prix.Text = total_tarif(2).ToString + " DT"
            Case 3
                label_prix.Text = total_tarif(3).ToString + " DT"
        End Select
    End Sub
End Class