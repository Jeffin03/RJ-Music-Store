﻿Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class admin_stocks
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        Try
            con.Open()
            Dim query = "insert into producttb values ('" & pname.Text & "','" & pcat.SelectedItem.ToString() & "','" & quan.Text & "','" & price.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox(" Product details saved")
            con.Close()
            displayitem()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        pname.Text = ""
        pcat.Text = ""
        price.Text = ""
        quan.Text = ""


    End Sub

    Private Sub displayitem()
        con.open()
        Dim query = "select * from producttb"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        con.close()

    End Sub

    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)

        pname.Text = row.Cells(2).Value.ToString
        'pcat.SelectedIndex = row.Cells(3).Value.ToString
        'price.Text = row.Cells(4).Value.ToString
        quan.Text = row.Cells(4).Value.ToString


    End Sub

    Private Sub FilterByCat()
        con.open()
        Dim query = "select * from producttb where pcat = '" & pcat.SelectedItem.ToString() & " '"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        con.close()

    End Sub

    Private Sub pcat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles pcat.SelectionChangeCommitted
        FilterByCat()

    End Sub
    Private Sub admin_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayitem()
        ItemDGV.Columns(0).Width = 50
        ItemDGV.Columns(1).Width = 184.8
        ItemDGV.Columns(2).Width = 170
        ItemDGV.Columns(3).Width = 150
        ItemDGV.Columns(4).Width = 150



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dim adm = New admin
        adm.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim admsls = New admin_sales
        admsls.Show()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ufd = New User_FB
        ufd.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim log = New Start
        log.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        End
    End Sub
End Class