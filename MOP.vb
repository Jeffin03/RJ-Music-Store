
Imports System.Windows.Forms

Public Class MOP


    Private Sub MOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Hide()
        Visaimg.Hide()
        Mastcrd.Hide()
        Amrexp.Hide()
        Discover.Hide()

        Hide()
        expdate.Format = DateTimePickerFormat.Custom
        expdate.CustomFormat = "MM/yy"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Card_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Card.MouseClick
        cardpanel.Show()
        crdtxt.Show()
        cvv.Show()
        cvvl.Show()
        crdn.Show()
        expdate.Show()

        expl.Show()


    End Sub

    Private Overloads Sub Hide()
        crdtxt.Hide()
        cvv.Hide()
        cvvl.Hide()
        crdn.Hide()
        expdate.Hide()
        expl.Hide()
        upil.Hide()
        upitxt.Hide()
        upipanel.Hide()
        cardpanel.Hide()


    End Sub

    Private Sub UPI_MouseClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles UPI.MouseClick
        upipanel.Show()
        upil.Show()
        upitxt.Show()
    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        Me.Close()

    End Sub

    Private Sub Cash_Click(sender As Object, e As EventArgs) Handles Cash.Click
        Me.Close()

    End Sub
    Dim Fill As New AutoCompleteStringCollection()
    Private Sub autocomp()
        Fill.AddRange({"okaxis",
                                       "okhdfcbank",
                                       "upi",
                                       "kotak",
                                       "ybl",
                                       "paytm",
                                       "icici",
                                       "sbi",
                                       "idfc",
                                       "axisbank",
                                       "barodampay",
                                       "okicici"})
        upitxt.AutoCompleteCustomSource = Fill
    End Sub

    Private Sub upitxt_TextChanged(sender As Object, e As EventArgs) Handles upitxt.TextChanged
        autocomp()

        If upitxt.Text.EndsWith("@") Then
            ComboBox1.Items.Clear()
            For Each upiSuffix As String In Fill
                ComboBox1.Items.Add(upitxt.Text + upiSuffix)
            Next
            If ComboBox1.Items.Count > 0 Then
                ComboBox1.SelectedIndex = 0
                ComboBox1.Visible = True
            End If
        Else
            ComboBox1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        upitxt.Text = ComboBox1.SelectedItem.ToString()
        upitxt.SelectionStart = upitxt.Text.Length
    End Sub

    Private Sub crdtxt_TextChanged(sender As Object, e As EventArgs) Handles crdtxt.TextChanged
        If crdtxt.Text.StartsWith("3") Or ("4") Or ("5") Or ("6") Then
            Card_image()
        End If

    End Sub

    Private Sub Card_image()
        If crdtxt.Text.StartsWith("3") Then
            Amrexp.Show()
        ElseIf crdtxt.Text.StartsWith("4") Then
            Visaimg.Show()
        ElseIf crdtxt.Text.StartsWith("5") Then
            Mastcrd.Show()
        ElseIf crdtxt.Text.StartsWith("6") Then
            Discover.Show()
        Else

            Visaimg.Hide()
            Mastcrd.Hide()
            Amrexp.Hide()
            Discover.Hide()
        End If

    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles Card.Click
        upipanel.Hide()

    End Sub

    Private Sub UPI_Click(sender As Object, e As EventArgs) Handles UPI.Click
        cardpanel.Hide()

    End Sub
End Class