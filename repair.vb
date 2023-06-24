Imports System.Data.SqlClient

Public Class repair
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmusicdb;Integrated Security=True")

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

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click 'Adds data to the repair table
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
    Private Sub addbtn_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles addbtn.MouseClick 'adds data to ItemDGV
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Shows a confirmation message of the order being placed
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'To cancel an order
        MsgBox("Order Has been Canceled")
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub clrbtn_Click(sender As Object, e As EventArgs) Handles clrbtn.Click 'reset button
        itemdes.Text = ""
        itemno.Text = ""
        itmcat.Text = ""
        ordnme.Text = ""
        cnum.Text = ""
        ComboBox1.Text = ""
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

    Dim valid = 0
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Assigns the country code according to the country selected

        If ComboBox1.SelectedIndex = 0 Then
            cnum.Text = "+91-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                valid = 1
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            cnum.Text = "+1-"
            cnum.MaxLength = 13
            If cnum.TextLength < 13 Then
                valid = 1

            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            cnum.Text = "+44-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                valid = 1

            End If
        ElseIf ComboBox1.SelectedIndex = 3 Then
            cnum.Text = "+33-"
            cnum.MaxLength = 13
            If cnum.TextLength < 13 Then
                valid = 1

            End If
        Else
            cnum.Text = "+81-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                valid = 1

            End If
        End If

    End Sub
    Private Sub Ctrycdval() 'Used to validate the length of the phone number along with the country code
        If ComboBox1.SelectedIndex = 0 Then

            If cnum.TextLength < 14 Then
                MsgBox("Enter 10 digits after country code")
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then

            If cnum.TextLength < 13 Then
                MsgBox("Enter 10 digits after country code")
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then

            If cnum.TextLength < 14 Then
                MsgBox("Enter 10 digits after country code")
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Then

            If cnum.TextLength < 13 Then
                MsgBox("Enter 10 digits after country code")
            End If
        Else

            If cnum.TextLength < 14 Then
                MsgBox("Enter 10 digits after country code")
            End If
        End If
    End Sub
    Private Sub check_ctrycd() 'This is to help validate the length of the phone number along with its country code.
        If valid = 1 Then
            Ctrycdval()

        End If

    End Sub

    Private Sub itemno_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles itemno.MouseClick 'checks the length of phone numbe when customer clicks on the next textbox
        check_ctrycd()
    End Sub

    Private Sub itmcat_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles itmcat.MouseClick
        check_ctrycd()
    End Sub

    Private Sub itemdes_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles itemdes.MouseClick
        check_ctrycd()
    End Sub

    Private Sub ordnme_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles ordnme.MouseClick
        check_ctrycd()
    End Sub
End Class