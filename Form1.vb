Imports System.Diagnostics
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim process As New Process()
        process.StartInfo.FileName = "Scrcpy\Usb.bat"
        process.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim process As New Process()
        process.StartInfo.FileName = "Scrcpy\Wifi.bat"
        process.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Get the ip address from the textbbox
        Dim ipAddress As String = TextBox1.Text.Trim()
        ' Execute the wifi batch script with the ip address as argument
        Dim process As New Process()
        process.StartInfo.FileName = "Scrcpy\Connect.bat"
        process.StartInfo.Arguments = ipAddress
        process.Start()
    End Sub
End Class
