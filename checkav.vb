﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Web.UI
Imports System.Windows.Controls
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Checkav
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")
    Private Sub Displayitem()
        con.open()
        Dim query = "select * from producttb "
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
    Private Sub Search()
        con.open()
        Dim query = "select * from producttb with (nolock) where pname ='" & pronme.Text.ToString & "'"

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

    Private Sub Logoutbt_Click(sender As Object, e As EventArgs) Handles Logoutbt.Click
        Me.Hide()
        Dim log = New Start
        log.Show()

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Close()
        End

    End Sub

    Private Sub Checkav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displayitem()


    End Sub

    Private Sub pcat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles pcat.SelectionChangeCommitted
        FilterByCat()

    End Sub

    Private Sub pronme_TextChanged(sender As Object, e As EventArgs) Handles pronme.TextChanged
        If pronme.Text = "" Then
            Displayitem()
        Else
            Search()

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim reg = New register
        reg.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim rep = New repair
        rep.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dim adm = New adminlog
        adm.Show()

    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub
End Class