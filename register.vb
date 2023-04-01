Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing.Printing
'Imports System.Net
'Imports System.Web
'Imports System.Collections.Specialized
'Imports System.IO
'Imports System.Text
Imports System.Drawing


Public Class register
    Dim i = 0, GrdTotal = 0
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim con = New SqlConnection("Data Source=LAPTOP-E350127R;Initial Catalog=rjmstoredb;Integrated Security=True")

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 378, 500)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_printpage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f8b As New Font("Calibri", 8, FontStyle.Bold)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Regular)
        Dim f14b As New Font("Calibri", 14, FontStyle.Bold)
        Dim f9 As New Font("Calibri", 9, FontStyle.Regular)
        Dim f9b As New Font("Calibri", 9, FontStyle.Bold)
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat
        left.Alignment = StringAlignment.Far
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "-----------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("R&J Music Square ", f14b, Brushes.Black, 0, 5)
        e.Graphics.DrawString("Avalahalli,Bangalore-560049", f10, Brushes.Black, 0, 25)
        e.Graphics.DrawString("Tel +916364828608         Email:rjmusics.store@gmail.com", f8, Brushes.Black, 0, 40)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 50)
        e.Graphics.DrawString("TAX INVOICE", f8b, Brushes.Black, centermargin - 35, 58)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 64)
        e.Graphics.DrawString("Bill no: " & billtb.Text, f8, Brushes.Black, 8, 75)
        e.Graphics.DrawString("Bill date: " & DateTime.Now.ToString("dd/MM/yyyy"), f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString("Customer Name: " & cnametb.Text, f8, Brushes.Black, centermargin - 80, 75)
        e.Graphics.DrawString("Mob: " & cnum.Text, f8, Brushes.Black, centermargin - 80, 90)
        e.Graphics.DrawString("Address: " & cadr.Text, f8, Brushes.Black, rightmargin - 100, 75)
        e.Graphics.DrawString("Customer ID: " & custid.Text, f8, Brushes.Black, rightmargin - 119, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)
        e.Graphics.DrawString("SL.no", f9b, Brushes.Black, 0, 109)
        e.Graphics.DrawString("Name", f9b, Brushes.Black, 50, 109)
        e.Graphics.DrawString("Quantity", f9b, Brushes.Black, centermargin - 26, 109)
        e.Graphics.DrawString("GST %", f9b, Brushes.Black, rightmargin - 119, 109)
        e.Graphics.DrawString("Price", f9b, Brushes.Black, rightmargin - 5, 109, right)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 118)

        Dim height As Integer
        Dim i As Long
        BillDGV.AllowUserToAddRows = False
        For row As Integer = 0 To BillDGV.RowCount - 1
            height += 15
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 0, 120 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 50, 120 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, centermargin - 26, 120 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, rightmargin - 119, 120 + height)
            i = BillDGV.Rows(row).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, rightmargin, 120 + height, right)

        Next
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 450)
        e.Graphics.DrawString("TOTAL: " & totallb.Text, f9b, Brushes.Black, rightmargin - 119, 458)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 465)
        e.Graphics.DrawString("THANK YOU FOR SHOPPING WITH US ", f10b, Brushes.Black, centermargin - 120, 475)


    End Sub

    Private Sub Addbill()

        Try

            con.Open()
            Dim query = "insert into salestb values('" & billtb.Text & "' ,'" & cnametb.Text & " '," & GrdTotal & ",'" & DateTime.Now.ToLongDateString & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox(" Bill saved Successfully")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()

        End

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim rep = New repair
        rep.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim adm = New admin
        adm.Show()

    End Sub


    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dim adm = New adminlog
        adm.Show()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If cnametb.Text = "" Or cnum.Text = "" Or cadr.Text = "" Or custid.Text = "" Then

            MsgBox("Enter Customer Details")

        Else
            Bill_Gen()
        End If
    End Sub
    Private Sub Bill_Gen()
        If moprb.Checked = True Then
            Addbill()
            addcust()
            PDD.Document = PD
            PDD.ShowDialog()
            Clear_after_billing()



        Else
            MsgBox("select mode of payment")
        End If
    End Sub


    Private Sub addcust()
        Try
            con.Open()
            Dim query = "insert into custtb values ('" & custid.Text & "','" & cnametb.Text & "','" & cnum.Text & "','" & cadr.Text & "')"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Displayitem()
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

    Dim Key = 0, Stock = 0
    Dim cur_stock = 0
    Private Sub Updateitem()
        Dim newqty = Stock - Convert.ToInt32(quan.Text)
        Try
            con.open
            Dim query = " update producttb set quan =" & newqty & " where pid = " & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.close()

            Displayitem()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ifdeleted()

        Dim newqty = Stock - Convert.ToInt32(quan.Text)
        Dim curqty = newqty + Convert.ToInt32(quan.Text)
        Try
            con.open
            Dim query = " update producttb set quan =" & curqty & " where pid = " & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.close()
            Displayitem()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim cava = New Checkav
        cava.Show()

    End Sub

    Private Sub sndsms_Click(sender As Object, e As EventArgs) Handles sndsms.Click
        Dim sms = New SMS
        sms.Show()

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        cnametb.Text = ""
        cnum.Text = ""
        cadr.Text = ""
        custid.Text = ""
        billtb.Text = ""
        icat.Text = ""
        pname.Text = ""

        price.Text = ""
        quan.Text = ""


    End Sub



    Private Sub moprb_CheckedChanged(sender As Object, e As EventArgs) Handles moprb.CheckedChanged
        Dim mop As New MOP
        mop.Show()
    End Sub

    Private Sub Addtocart_Click(sender As Object, e As EventArgs) Handles Addtocart.Click
        If quan.Text = "" Then
            quan.Text = 1
        End If


        If price.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf icat.Text = "" Then
            MsgBox("select the Item")



        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = price.Text * Convert.ToInt32(quan.Text)
            BillDGV.Rows.Item(rnum).Cells("column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("column2").Value = pname.Text
            BillDGV.Rows.Item(rnum).Cells("column3").Value = quan.Text
            BillDGV.Rows.Item(rnum).Cells("column4").Value = "GST 18%"
            BillDGV.Rows.Item(rnum).Cells("column5").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(GrdTotal)
            totallb.Text = tot
            Updateitem()
            Displayitem()
            Resetpdt()


        End If
    End Sub


    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If Key = 0 Then
            MsgBox("select item to delete")
        Else
            Dim index As Integer
            index = BillDGV.CurrentCell.RowIndex
            BillDGV.Rows.RemoveAt(index)
            Ifdeleted()

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Dim log = New Start
        log.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        End
    End Sub

    Private Sub ItemDGV_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        pname.Text = row.Cells(1).Value.ToString
        icat.Text = row.Cells(2).Value.ToString
        price.Text = row.Cells(4).Value.ToString
        If pname.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(3).Value.ToString)


        End If
    End Sub

    Private Sub BillDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BillDGV.CellMouseClick
        Dim row As DataGridViewRow = BillDGV.Rows(e.RowIndex)
        pname.Text = row.Cells(1).Value.ToString
        price.Text = row.Cells(4).Value.ToString
        quan.Text = row.Cells(2).Value.ToString

    End Sub

    Private Sub Resetpdt()
        icat.Text = ""
        pname.Text = ""
        price.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            cnum.Text = "+91-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                MsgBox("Enter a valid number")
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
                cnum.Text = "+1-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                MsgBox("Enter a valid number")
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            cnum.Text = "+44-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                MsgBox("Enter a valid number")
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Then
            cnum.Text = "+33-"
            cnum.MaxLength = 13
            If cnum.TextLength < 13 Then
                MsgBox("Enter a valid number")
            End If
        Else
            cnum.Text = "+81-"
            cnum.MaxLength = 14
            If cnum.TextLength < 14 Then
                MsgBox("Enter a valid number")
            End If
        End If
    End Sub

    Private Sub Clear_after_billing()
        BillDGV.Rows.Clear()
        cnametb.Text = ""
        cnum.Text = ""
        cadr.Text = ""
        custid.Text = ""
        billtb.Text = ""
        icat.Text = ""
        pname.Text = ""
        price.Text = ""
        quan.Text = ""
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displayitem()
        sndsms.Hide()



        BillDGV.Columns(1).Width = 90
        BillDGV.Columns(2).Width = 70
        BillDGV.Columns(3).Width = 70
        BillDGV.Columns(4).Width = 70

        ItemDGV.Columns(0).Width = 60
        ItemDGV.Columns(1).Width = 95
        ItemDGV.Columns(2).Width = 85
        ItemDGV.Columns(3).Width = 60
        ItemDGV.Columns(4).Width = 85



    End Sub

End Class