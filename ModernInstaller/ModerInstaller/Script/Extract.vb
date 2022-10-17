Imports System.IO
Imports System.IO.Compression

Public Class Extract
    Shared Sub Extract(Path As String)
        Dim count = 1
        Dim zip As String
        For Each zip In Directory.GetFiles(Application.StartupPath, "*", SearchOption.AllDirectories)
            If zip.Contains("Setup-0") Then
                ZipFile.ExtractToDirectory("Setup-0.hakkr", Path & "\Temp")
            ElseIf zip.Contains("Setup-") Then
                ZipFile.ExtractToDirectory("Setup-" & count & ".hakkr", Path & "\Temp")
                count += 1
            End If
        Next
    End Sub
End Class
