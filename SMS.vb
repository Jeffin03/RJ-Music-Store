'****************DISCLAIMER**********************
'This page in not made functional for now due to it being incomplete. Thank you......!!!
Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class SMS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim apikey = "Mzk2YzY5NjIzODcyNDMzMjY1NjU2NjU1NjY2MzQ1NzU="
        Dim message = msg.Text
        Dim numbers = cnum.Text
        Dim strGet As String
        Dim sendername = "RJSTXT"
        Dim url As String = "https://api.textlocal.in/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + sendername

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MessageBox.Show(result, "informationn", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub SMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class