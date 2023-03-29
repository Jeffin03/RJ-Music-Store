

Public Class admin_sales

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()
        End

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

    End Sub

    Private Sub Logoutbt_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim log = New Start
        log.Show()


    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
        End

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Dim ufb = New User_FB
        ufb.Show()
    End Sub
End Class