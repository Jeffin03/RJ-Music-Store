
Imports System.Windows.Forms

Public Class MOP


    Private Sub MOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub upitxt_TextChanged(sender As Object, e As EventArgs) Handles upitxt.TextChanged
        If upitxt.Text = "@" Then
            AutoCompleteSource.CustomSource.ToString()
        End If
    End Sub
End Class