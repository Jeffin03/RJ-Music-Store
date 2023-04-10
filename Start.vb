Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "rjmusic" And TextBox2.Text = "456987" Then
            Me.Hide()
            Dim hm = New Home
            hm.Show()

        Else
            MsgBox("wrong username and password")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim adlog = New adminlog
        adlog.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        End

    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class