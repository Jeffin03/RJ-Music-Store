
Public Class adminlog

    'Login page for Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If userid.Text = "admin" And password.Text = "password" Then
            Me.Hide()
            Dim hm = New admin
            hm.Show()

        Else
            MsgBox("wrong username and password")
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        End

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class