Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class admin
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")
    Private Sub displayitem() 'displays data from product table 
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

    Private Sub Sales_chart() 'This displays the sales chart as per data from sales table
        Try
            con.open
            Dim query As String
            query = "select * from salestb"
            Dim cmd = New SqlCommand(query, con)
            Dim reader = cmd.ExecuteReader
            Dim dt = New DataTable
            dt.Load(reader)

            Chart1.Series("Sales Rating").XValueMember = "bdate"
            Chart1.Series("Sales Rating").YValueMembers = "netamt"
            Chart1.DataSource = dt
            Chart1.DataBind()
            Chart1.ChartAreas(0).AxisX.Title = "Date of Purchase---------->"
            Chart1.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Near
            Chart1.ChartAreas(0).AxisX.TextOrientation = TextOrientation.Horizontal
            Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            Chart1.ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            Chart1.ChartAreas(0).AxisY.Title = "Sales (amount) in Rupees--->"
            Chart1.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Near
            Chart1.ChartAreas(0).AxisY.TextOrientation = TextOrientation.Rotated270


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.close

        End Try
    End Sub

    Private Sub admin_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayitem()


        ItemDGV.Columns(0).Width = 50
        ItemDGV.Columns(1).Width = 90
        ItemDGV.Columns(2).Width = 75
        ItemDGV.Columns(3).Width = 75
        ItemDGV.Columns(4).Width = 75

    End Sub
    Private Sub FilterByCat() 'Filter by category 
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
        Sales_chart()
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

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub
End Class