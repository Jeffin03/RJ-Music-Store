﻿Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Controls
Imports System.Windows.Forms
Public Class admin
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")
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

    End Sub


    Private Sub admin_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayitem()
        ItemDGV.Columns(0).Width = 50
        ItemDGV.Columns(1).Width = 90
        ItemDGV.Columns(2).Width = 75
        ItemDGV.Columns(3).Width = 75
        ItemDGV.Columns(4).Width = 75

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
    Private Sub Chart()
        CartesianChart1.Series = New SeriesCollection From {
            New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 10),
            New ObservablePoint(4, 7),
            New ObservablePoint(5, 3),
            New ObservablePoint(7, 6),
            New ObservablePoint(10, 8)
            },
            .PointGeometrySize = 25
            },
            New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 2),
            New ObservablePoint(2, 5),
            New ObservablePoint(3, 6),
            New ObservablePoint(6, 8),
            New ObservablePoint(10, 5)
        },
        .PointGeometrySize = 15
        },
          New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 4),
            New ObservablePoint(5, 5),
            New ObservablePoint(7, 7),
            New ObservablePoint(9, 10),
            New ObservablePoint(10, 9)
        },
        .PointGeometrySize = 15
     }
 }
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()
        End

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim adsls = New admin_sales
        adsls.Show()

    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Dim adstc = New admin_stocks
        adstc.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart()
        Button11.Hide()
        Button8.Hide()

    End Sub
    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Me.Hide()
        Dim adstc = New admin_stocks
        adstc.Show()
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Me.Hide()
        Dim adsls = New admin_sales
        adsls.Show()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub

    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class