Imports System.IO
Imports System.IO.Compression
Imports System.IO.Packaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Hakkuraifu_Repacker.Repacker

Public Class Archive
    Shared Function GetDirectoryName(dir As String)

        Dim myPos As Integer
        Dim myPath As String
        myPath = dir
        Dim myFolder As String

        myPos = InStrRev(myPath, "\", -1, vbTextCompare)

        'Test that you actually found a backslash
        If myPos > 0 Then
            myFolder = Mid(myPath, myPos + 1)
            'MsgBox(myFolder)
            Return myFolder
        End If

    End Function
    Shared Sub ArchiveDir(Path As String)
        Dim dir As String
        Dim count = 1
        For Each dir In Directory.GetDirectories(Path, "*", SearchOption.TopDirectoryOnly)
            Try
                'MsgBox(GetDirectoryName(dir))
                'File.WriteAllText(dir & "\dn", GetDirectoryName(dir))
                ZipFile.CreateFromDirectory(dir, Path & "\Setup-" & count & ".hakkr", CompressionLevel.SmallestSize, True)
                count += 1
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Shared Sub ArchiveFile(Path As String)
        Dim Files As String
        Dim zipPath As String = Path & "\Setup-0.hakkr"
        Dim zip As Package = ZipPackage.Open(zipPath,
          IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
        For Each Files In Directory.GetFiles(Path)
            If Files.Contains(".hakkr") Then
            Else
                AddToArchive(zip, Files)
            End If
            'MsgBox(Files)

        Next
        zip.Close()


    End Sub

    Shared Sub AddToArchive(zip As Package, fileToAdd As String)
        'Replace spaces with an underscore (_)
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/"
        Dim zipUri As String = String.Concat("/",
               IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String =
               Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information:
        ' Where to extract the file when it's extracted (partUri)
        ' The type of content stream (MIME type):  (contentType)
        ' The type of compression:  (CompressionOption.Normal)
        Dim pkgPart As PackagePart = zip.CreatePart(partUri,
               contentType, CompressionOption.Maximum)

        'Read all of the bytes from the file to add to the zip file
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file
        pkgPart.GetStream().Write(bites, 0, bites.Length)
    End Sub



End Class
