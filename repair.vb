Imports System.Data.SqlClient
Imports System.Web.UI
Imports System.Windows.Controls
Imports System.Windows.Forms
Imports System.Windows.Input

Public Class repair
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")

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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dim adm = New adminlog
        adm.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If ordnme.Text = "" Or cnum.Text = "" Or itemno.Text = "" Or itemdes.Text = "" Or itmcat.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim query = "insert into repairtb values ('" & ordnme.Text & "','" & cnum.Text & "','" & itemno.Text & "','" & itemdes.Text & "','" & itmcat.SelectedItem.ToString & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" Repair request details added successfully")
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim i = 0
    Private Sub addbtn_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles addbtn.MouseClick
        If ordnme.Text = "" Or cnum.Text = "" Or itemno.Text = "" Or itemdes.Text = "" Or itmcat.Text = "" Then
            MsgBox("Missing Information")

        Else
            Dim rnum As Integer = ItemDGV.Rows.Add()
            i += 1

            ItemDGV.Rows.Item(rnum).Cells("column1").Value = i
            ItemDGV.Rows.Item(rnum).Cells("column2").Value = itemno.Text
            ItemDGV.Rows.Item(rnum).Cells("column3").Value = itemdes.Text
            ItemDGV.Rows.Item(rnum).Cells("column4").Value = itmcat.SelectedItem


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Your Request has been accepted, we will update you on when the repairs are completed by SMS.
Thank you and please visit again")
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub Logoutbt_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim lod = New Start
        lod.Show()
    End Sub

    Private Sub checkava_Click(sender As Object, e As EventArgs) Handles checkava.Click
        Me.Hide()
        Dim cava = New Checkav
        cava.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Order Has been Canceled")
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub clrbtn_Click(sender As Object, e As EventArgs) Handles clrbtn.Click
        itemdes.Text = ""
        itemno.Text = ""
        itmcat.Text = ""
        ordnme.Text = ""
        cnum.Text = ""
    End Sub

    Private Sub repair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemDGV.Columns(0).Width = 100
        ItemDGV.Columns(1).Width = 240
        ItemDGV.Columns(2).Width = 243.5
        ItemDGV.Columns(3).Width = 210
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles userfdbtn.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        Dim lod = New Start
        lod.Show()
    End Sub
End Class