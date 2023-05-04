
Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(0.09)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Dim str = New Start
            str.Show()
        Else
            ProgressBar1.PerformStep()
            lblpercent.Text = ProgressBar1.Value & ("%")

        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class