Imports LiveCharts
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
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As Windows.Forms.DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick

    End Sub


    Private Sub admin_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayitem()

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

    Private Sub Guna2Panel1_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Guna2Panel1.MouseClick
        Me.Hide()
        Dim adstc = New admin_stocks
        adstc.Show()
    End Sub

    Private Sub Guna2Panel2_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Guna2Panel2.MouseClick
        Me.Hide()
        Dim adsls = New admin_sales
        adsls.Show()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub
End Class