Imports System.IO
Imports System.IO.Compression
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ZipFile.ExtractToDirectory("./calc.zip", "./bin")
        Dim startInfo As New ProcessStartInfo()
        Dim myprocess As New Process()
        startInfo.FileName = "./bin/Wabbitemu.exe"
        ''startInfo.Verb = "runas"
        ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
        myprocess.StartInfo = startInfo
        myprocess.Start()
    End Sub
End Class
