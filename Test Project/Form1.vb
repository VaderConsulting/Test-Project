Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SourceDir As String = "d:\"
        Dim astrFileNames() As String = Directory.GetFiles(sourceDir)
        Dim strmZipOutputStream As ZipOutputStream
        Dim TargetName As String = "D:\test.zip"

        strmZipOutputStream = New ZipOutputStream(File.Create(targetName))

        REM Compression Level: 0-9
        REM 0: no(Compression)
        REM 9: maximum compression
        strmZipOutputStream.SetLevel(9)

        Dim strFile As String

        For Each strFile In astrFileNames
            Dim strmFile As FileStream = File.OpenRead(strFile)
            Dim abyBuffer(strmFile.Length - 1) As Byte

            strmFile.Read(abyBuffer, 0, abyBuffer.Length)
            Dim objZipEntry As ZipEntry = New ZipEntry(strFile)

            objZipEntry.DateTime = DateTime.Now
            objZipEntry.Size = strmFile.Length
            strmFile.Close()
            strmZipOutputStream.PutNextEntry(objZipEntry)
            strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)
        Next

        strmZipOutputStream.Finish()
        strmZipOutputStream.Close()

        MessageBox.Show("Operation complete")

    End Sub

End Class
