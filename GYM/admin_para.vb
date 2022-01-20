Imports System.Data.OleDb

Public Class admin_para
    Public conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Little Boy\Desktop\gym\database.accdb")
    Public dr As OleDbDataReader




    Public Function getTarifbyName(ByRef k As String)
        Dim p() As String
        p = getuser().Split("-")
        If k <> "" Then
            Select Case k
                Case "1 mois"
                    Return p(0)
                Case "3 mois"
                    Return p(1)
                Case "6 mois"
                    Return p(2)
                Case "1 ans"
                    Return p(3)
            End Select
        Else
            Return "err/cannot get tarif data"
        End If
    End Function


    Public Sub add_tarif(ByRef dat, id, tarif) 'add_tarif("01/19/2022", "#IDHM", "50")
        Dim somDT As String = getTarifbyName(tarif)
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("insert into bank ([date],[user_id],[tarif],[type]) values ('" & dat & "','" & id & "','" & somDT & "','" & tarif & "')", conn)
        cmd.Parameters.Add(New OleDbParameter("date", CType(dat, String)))
        cmd.Parameters.Add(New OleDbParameter("user_id", CType(id, String)))
        cmd.Parameters.Add(New OleDbParameter("tarif", CType(somDT, String)))
        cmd.Parameters.Add(New OleDbParameter("type", CType(tarif, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            'MsgBox("Done")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function getuser() As String
        Dim alldata As String
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from tarif", conn)
            dr = cmd.ExecuteReader
            While dr.Read

                'alldata = dr.Item("id").ToString & "-" & dr.Item("surname").ToString & "-" & dr.Item("name").ToString & "-" & dr.Item("email").ToString & "-" & dr.Item("phone").ToString & "-" & dr.Item("subs").ToString & "-" & dr.Item("start").ToString & "-" & dr.Item("end").ToString
                alldata = dr.Item("1 mois").ToString & "-" & dr.Item("3 mois").ToString & "-" & dr.Item("6 mois").ToString & "-" & dr.Item("1 ans").ToString

            End While
            conn.Close()
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return alldata
    End Function

    Private Sub admin_para_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim p() As String = getuser().Split("-")
        TextBox1.Text = p(0)
        TextBox2.Text = p(1)
        TextBox3.Text = p(2)
        TextBox4.Text = p(3)

    End Sub
    Sub update_CV(ByRef a, b, c, d)
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("update tarif set [1 mois]='" & a & "',[3 mois]='" & b & "',[6 mois]='" & c & "',[1 ans]='" & d & "'", conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MsgBox("Done edit")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update_CV(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub


End Class