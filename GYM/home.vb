Imports System.Data.OleDb
Imports System.IO

Public Class Form1


    Public conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Little Boy\Desktop\gym\database.accdb")
    Public dr As OleDbDataReader

#Region "functions"
    Function calcDate(ByRef d1 As String, ByRef d2 As String) As String
        Dim ss() As String = d1.Split("/")
        Dim ss2() As String = d2.Split("/")
        Dim firstDate, seconDate As Date
        'firstDate = Convert.ToDateTime(ss(1) + "/" + ss(0) + "/" + ss(2))
        firstDate = Now
        seconDate = Convert.ToDateTime(ss2(1) + "/" + ss2(0) + "/" + ss2(2))
        Dim op = (DateDiff(DateInterval.Day, firstDate, seconDate))
        If op > 0 Then
            Return op.ToString + " day left"
        Else
            Return " Terminer ! (" + op.ToString + ")"
        End If
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
#End Region



#Region "Form events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadall()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newC.Show()
    End Sub

#End Region





    Sub _load()
        Try
            ' DataGridView1.Rows.Clear()
            ListView1.Items.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from users", conn)

            dr = cmd.ExecuteReader




            While dr.Read
                If dr.Item("id") <> "" Then

                    'DataGridView1.Rows.Add(dr.Item("id"), dr.Item("surname"), dr.Item("name"), dr.Item("email"), calcDate(dr.Item("start"), dr.Item("end")), dr.Item("phone"), dr.Item("subs"), dr.Item("start"), dr.Item("end"))

                    Dim newItem As New ListViewItem(dr.Item("id").ToString)
                    newItem.SubItems.Add(dr.Item("surname"))
                    newItem.SubItems.Add(dr.Item("name"))
                    newItem.SubItems.Add(dr.Item("email"))
                    newItem.SubItems.Add(calcDate(dr.Item("start"), dr.Item("end")))
                    newItem.SubItems.Add(dr.Item("phone"))
                    newItem.SubItems.Add(dr.Item("subs"))
                    newItem.SubItems.Add(dr.Item("start"))
                    newItem.SubItems.Add(dr.Item("end"))
                    ListView1.Items.Add(newItem)


                End If

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Sub loadall()
        Try
            conn.Open()
            'Label2.Text = "Server Statut : connect"
        Catch ex As Exception
            '  Label2.Text = "Server Statut : Not Connect ! "

        End Try
        conn.Close()
        _load()
    End Sub




    Sub delete_user(ByRef id As String)
        conn.Open()

        Dim op As New OleDb.OleDbCommand("delete from users where[id]='" & id & "'", conn)
        Try
            op.ExecuteNonQuery()
            op.Dispose()

            MsgBox("delite done")
            loadall()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
    End Sub

    '1 mois
    '3 mois
    '6 mois
    '1 ans
    Sub add_abs(ByRef id, typeme)

        Dim xsub As String = ""
        Select Case typeme
            Case 0
                xsub = "1 mois"
            Case 1
                xsub = "3 mois"
            Case 2
                xsub = "6 mois"
            Case 3
                xsub = "1 ans"
        End Select


        Dim mdate As Date

        mdate = Now

        Dim kk As Date

        Select Case typeme
            Case 0
                kk = mdate.AddMonths(1)
            Case 1
                kk = mdate.AddMonths(3)
            Case 2
                kk = mdate.AddMonths(6)
            Case 3
                kk = mdate.AddYears(1)
        End Select

        ' MsgBox("'" & id & "'")
        'MsgBox("update users set subs='" & xsub & "',start='" & mdate.ToString("dd/MM/yyyy") & "',end='" & kk.ToString("dd/MM/yyyy") & "' where id='" & id & "'")

        conn.Open()
        'Dim op As New OleDb.OleDbCommand("update users set subs='" & xsub & "',start='" & mdate.ToString("dd/MM/yyyy") & "',end='" & kk.ToString("dd/MM/yyyy") & "' WHERE id='" & id & "'", conn)

        Dim a, b As String
        a = mdate.ToString("dd/MM/yyyy")
        b = kk.ToString("dd/MM/yyyy")

        Dim op As New OleDb.OleDbCommand("update[users]set[subs]='" & xsub & "',[start]='" & a & "',[end]='" & b & "' where[id]='" & id & "'", conn)
        Try
            op.ExecuteNonQuery()
            op.Dispose()

            MsgBox("Done edit")
            loadall()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()



    End Sub


    Function getuser(ByRef iddd As String) As String
        Dim alldata As String
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from users where id='" + iddd + "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read

                alldata = dr.Item("id").ToString & "-" & dr.Item("surname").ToString & "-" & dr.Item("name").ToString & "-" & dr.Item("email").ToString & "-" & dr.Item("phone").ToString & "-" & dr.Item("subs").ToString & "-" & dr.Item("start").ToString & "-" & dr.Item("end").ToString


            End While
            conn.Close()
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return alldata

    End Function



    Sub update_CV(ByRef _id, _name, id, name, surname, email, phone)
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("update users set name='" & surname & "',surname='" & name & "',email='" & email & "',phone='" & phone & "' where id='" & _id & "' and name='" & _name & "'", conn)


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MsgBox("Done edit")
            loadall()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub add_CV(ByRef name, surname, cin, phone, subs, start, ends)
        conn.Open()
        Dim genID As String = "#" + UCase(name(0)) + UCase(surname(0)) + UCase(name(Len(name) - 1)) + UCase(surname(Len(surname) - 1)) + GetRandom(10, 99).ToString()  ' Where not exists(select * from tablename where code='1448523')
        Dim cmd As New OleDb.OleDbCommand("insert into users ([id],[name],[surname],[email],[phone],[subs],[start],[end]) values ('" & genID & "','" & name & "','" & surname & "','" & cin & "','" & phone & "','" & subs & "','" & start & "','" & ends & "'" & ")", conn)
        cmd.Parameters.Add(New OleDbParameter("id", CType(genID, String)))
        cmd.Parameters.Add(New OleDbParameter("name", CType(name, String)))
        cmd.Parameters.Add(New OleDbParameter("surname", CType(surname, String)))
        cmd.Parameters.Add(New OleDbParameter("email", CType(cin, String)))
        cmd.Parameters.Add(New OleDbParameter("phone", CType(phone, String)))
        cmd.Parameters.Add(New OleDbParameter("subs", CType(subs, String)))
        cmd.Parameters.Add(New OleDbParameter("start", CType(start, String)))
        cmd.Parameters.Add(New OleDbParameter("end", CType(ends, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Dim dk As Date = Now
            admin_para.add_tarif(dk, genID, subs)
            MsgBox("Done")
            loadall()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub








    Function getop(ByRef d1, ByRef d2) As String
        Dim ss() As String
        ss = d1.Split("/")

        Dim ss2() As String
        ss2 = d2.Split("/")

        Dim firstDate As Date
        Dim seconDate As Date

        firstDate = Convert.ToDateTime(ss(1) + "/" + ss(0) + "/" + ss(2))
        seconDate = Convert.ToDateTime(ss2(1) + "/" + ss2(0) + "/" + ss2(2))


        Return (DateDiff(DateInterval.Day, firstDate, seconDate))
    End Function



    'Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)

    '    Dim f As New userView
    '    f.txt_id.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '    f.txt_nom.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
    '    f.txt_prenom.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
    '    f.txt_email.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
    '    f.txt_phone.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
    '    'f.txt_abn.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
    '    f.id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '    f.nom = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()

    '    f.Show()

    'End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        user_Ren.Show()
    End Sub

    'Private Sub RenovellLabonnementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenovellLabonnementToolStripMenuItem.Click
    '    Try
    '        Dim f As New user_Ren2
    '        f.id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '        f.Label2.Text = "ID : " & DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '        f.Label3.Text = "Nom : " & DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
    '        f.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '        f.Show()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub EditeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditeToolStripMenuItem.Click

    '    Dim f As New userView
    '    f.txt_id.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '    f.txt_nom.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
    '    f.txt_prenom.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
    '    f.txt_email.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
    '    f.txt_phone.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
    '    'f.txt_abn.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
    '    f.id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    '    f.nom = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()

    '    f.Show()
    'End Sub

    'Private Sub SuprimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuprimeToolStripMenuItem.Click
    '    Dim result As DialogResult = MessageBox.Show("Supprime " & DataGridView1.SelectedRows(0).Cells(1).Value.ToString() & "??",
    '                          "Confirme",
    '                          MessageBoxButtons.YesNo)


    '    If (result = DialogResult.Yes) Then
    '        delete_user(DataGridView1.SelectedRows(0).Cells(0).Value.ToString())

    '    End If


    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin_para.Show()
    End Sub


    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim f As New userView
        f.txt_id.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
        f.txt_nom.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
        f.txt_prenom.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        f.txt_email.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
        f.txt_phone.Text = ListView1.SelectedItems.Item(0).SubItems(4).Text

        f.id = ListView1.SelectedItems.Item(0).SubItems(5).Text
        f.nom = ListView1.SelectedItems.Item(0).SubItems(6).Text

        f.Show()
    End Sub

    Private Sub RenovellLabonnementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenovellLabonnementToolStripMenuItem.Click
        Try
            Dim f As New user_Ren2
            f.id = ListView1.SelectedItems.Item(0).SubItems(0).Text
            f.Label2.Text = "ID : " & ListView1.SelectedItems.Item(0).SubItems(0).Text
            f.Label3.Text = "Nom : " & ListView1.SelectedItems.Item(0).SubItems(1).Text
            f.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text + " - " + ListView1.SelectedItems.Item(0).SubItems(1).Text + " " + ListView1.SelectedItems.Item(0).SubItems(2).Text
            f.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EditeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditeToolStripMenuItem.Click
        Dim f As New userView
        f.txt_id.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
        f.txt_nom.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
        f.txt_prenom.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        f.txt_email.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
        f.txt_phone.Text = ListView1.SelectedItems.Item(0).SubItems(5).Text
        f.id = ListView1.SelectedItems.Item(0).SubItems(0).Text
        f.nom = ListView1.SelectedItems.Item(0).SubItems(2).Text

        f.Show()
    End Sub
End Class
