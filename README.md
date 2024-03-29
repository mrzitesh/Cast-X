# Cast By Nitesh
<br>Cast-X Windows Application helps you to connect any android device to windows machine to share screen and much more.
<br>!!! Need to do 
<br>First you need to turn on Developer Option in Your Android Device.
<br>Your can check this website how to turn on developer option in android. https://developer.android.com/studio/debug/dev-options
<br>After that turn on USB Debugging Option in Your Android Device.
<br>Connect Your Android Device to Windows Machine.
<br>After that Allow Debugging to your android devices.
<br>now you can connect your android device display to your windows pc usingn Usb Button in the application
and also your can use Wifi but before using wifi you need to turn on your mobile hotspot or connect 
windows machine to the same wifi network and fill the ip address in textbox in 127.0.0.0 format 
<br>first time need to connect android device through cable and press connect button and after plug out 
and press wifi button it will connect your android device to windows machine
<br>*
<br>*
<br>*
<br>*
<br>This is the source code of this windows application.
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
