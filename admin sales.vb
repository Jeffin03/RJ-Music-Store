Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting
Public Class admin_sales

    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")

    Private Sub Sales_chart()
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
            Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
            Chart1.ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
            Chart1.ChartAreas(0).AxisY.Title = "Sales (amount) in Rupees--->"
            Chart1.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Near
            Chart1.ChartAreas(0).AxisY.TextOrientation = TextOrientation.Rotated270


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.close

        End Try
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()
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

    Private Sub admin_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sales_chart()


    End Sub
    Private Sub userfdbt_Click(sender As Object, e As EventArgs) Handles userfdbt.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub

    Private Sub logoutbt_Click_1(sender As Object, e As EventArgs) Handles logoutbt.Click
        Me.Hide()
        Dim log = New Start
        log.Show()
    End Sub

    Private Sub closebt_Click(sender As Object, e As EventArgs) Handles closebt.Click
        Me.Close()
        End
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dim adm = New admin
        adm.Show()

    End Sub
End Class