Imports System.IO
Imports System.Configuration
Imports System.IO.Compression
Imports System.Security.Cryptography
Imports Microsoft.SqlServer
Imports System.Runtime
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Threading
Imports System.ComponentModel
Imports System.Xml
Imports System.Convert
Imports System.Text
Imports System.Net.WebRequestMethods
Imports File = System.IO.File

Public Class Repacker
    Dim GF As String
    Dim icone
    Dim bg
    Dim song
    Dim orisize
    Dim compsize
    Dim DoubleBytes As Double
    Private Sub Repacker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Directory.CreateDirectory("Compress")
        'Directory.CreateDirectory("Decompress")
        Directory.CreateDirectory("LOG")
        Directory.CreateDirectory("Crack")
        If My.Settings.DarkMode = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Me.GroupBox1.BackColor = Color.Black
            Me.GroupBox1.ForeColor = Color.White
            Me.GroupBox2.BackColor = Color.Black
            Me.GroupBox2.ForeColor = Color.White
            Me.GroupBox3.BackColor = Color.Black
            Me.GroupBox3.ForeColor = Color.White
            Me.GroupBox4.BackColor = Color.Black
            Me.GroupBox4.ForeColor = Color.White
            Me.ComboBox1.BackColor = Color.Black
            Me.ComboBox1.ForeColor = Color.White
            Dim c As Control
            For Each c In Me.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next

            For Each c In Me.GroupBox1.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ListBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next

            For Each c In Me.GroupBox2.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ListBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next


            For Each c In Me.GroupBox3.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ListBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next


            For Each c In Me.GroupBox4.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ListBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                ElseIf TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
        Else
            Me.Refresh()

        End If
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Try
            ListBox1.Items.Clear()
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim files1 As String
            For Each pathd In files
                'MsgBox(path)
                For Each files1 In Directory.GetFileSystemEntries(pathd, "*", SearchOption.AllDirectories)
                    ListBox1.Items.Add(files1)
                Next
                'MsgBox(Path.GetFileName(pathd))
                Label1.Text = "Game folder : " & Path.GetFileName(pathd)
                ProgressBar1.Maximum = ListBox1.Items.Count
                GF = Path.GetFileName(pathd)
                TextBox1.Text = GF
            Next
        Catch ex As Exception
            MsgBox("Please drag and drop the game folder NOT the files !", MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        End Try

    End Sub

    Public Enum FileSystemObject
        InvalidPath
        Directory
        File
    End Enum

    Public Function WhatIsThisThing(path As String) As FileSystemObject
        If Directory.Exists(path) Then
            Return FileSystemObject.Directory
        ElseIf File.Exists(path) Then
            Return FileSystemObject.File
        Else
            Return FileSystemObject.InvalidPath
        End If
    End Function

    <Obsolete>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or Label2.Text = "N/A" Or Label3.Text = "N/A" Then
            MsgBox("Please complete everything !", MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        ElseIf ListBox1.Items.Count = Nothing Then
            MsgBox("Please drag and drop a folder !", MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
            'ElseIf Label2.Text = "N/A" Or Label3.Text = "N/A" Then
            'MsgBox("Please choose a icon and a background image !", MsgBoxStyle.Critical)
        ElseIf My.Settings.RF = "" Then
            MsgBox("Please add a output folder in the setting !", MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        Else
            AddFolder(GF)
            'CompressFile(GF)
            Dim t As New Thread(Sub()
                                    CompressFile(GF)
                                End Sub)
            t.IsBackground = True
            t.Start()
        End If


    End Sub

    Sub AddFolder(folder As String)
        Dim GS As String = folder
        Try
            'MsgBox(GF.Remove(0, GF.IndexOf(GF) + Path.GetDirectoryName(GF).Length + 1))
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedIndex = i
                'MsgBox("Compress\" & GF & "\" & Path.GetFileName(ListBox1.SelectedItem.ToString))
                folder = ListBox1.SelectedItem.ToString
                'MsgBox(GF.Substring(GF.IndexOf(Path.GetFileName(Path.GetDirectoryName(GF)))))
                If WhatIsThisThing(folder) = FileSystemObject.Directory Then
                    'GS = GF.Remove(0, GF.IndexOf(GF) + Path.GetFullPath(gs).Length)
                    'MsgBox(GS)
                    Directory.CreateDirectory(My.Settings.RF & "\" & folder.Substring(folder.IndexOf(GS)))

                End If
            Next
        Catch ex As Exception
            Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        End Try
    End Sub

    Sub disablectrl()
        Me.Invoke(Sub() Me.UseWaitCursor = True)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Button Then
                Me.Invoke(Sub() ctrl.Enabled = False)
            ElseIf TypeOf ctrl Is GroupBox Then
                Me.Invoke(Sub() ctrl.Enabled = False)
            ElseIf TypeOf ctrl Is TextBox Then
                Me.Invoke(Sub() ctrl.Enabled = False)
            End If
        Next
    End Sub

    Sub enbalectrl()
        Me.Invoke(Sub() Me.UseWaitCursor = False)
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Button Then
                Me.Invoke(Sub() ctrl.Enabled = True)
            ElseIf TypeOf ctrl Is GroupBox Then
                Me.Invoke(Sub() ctrl.Enabled = True)
            ElseIf TypeOf ctrl Is TextBox Then
                Me.Invoke(Sub() ctrl.Enabled = True)
            End If
        Next
    End Sub

    <Obsolete>
    Sub CompressFile(files As String)
        If Me.InvokeRequired Then

            Try
                disablectrl()
                'MsgBox(GF.Remove(0, GF.IndexOf(GF) + Path.GetDirectoryName(GF).Length + 1))
                Dim GS As String = files
                For i = 0 To ListBox1.Items.Count - 1
                    Me.Invoke(Sub() ListBox1.SelectedIndex = i)
                    'MsgBox("Compress\" & GF & "\" & Path.GetFileName(ListBox1.SelectedItem.ToString))
                    Me.Invoke(Sub() files = ListBox1.SelectedItem.ToString)
                    'MsgBox(GF.Substring(GF.IndexOf(Path.GetFileName(Path.GetDirectoryName(GF)))))
                    If WhatIsThisThing(files) = FileSystemObject.File Then
                        'GS = GF.Remove(0, GF.IndexOf(GF) + Path.GetFullPath(gs).Length)
                        'MsgBox(GS)
                        If My.Settings.Compreesion = "ZSTD (Recommended)" Then
                            Compress.CompressFileZtsd(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "Deflame" Then
                            Compress.CompressFileDefalte(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "Brotli" Then
                            Compress.CompressFileBrotli(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "Zlib" Then
                            Compress.CompressFileZLib(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "GZip" Then
                            Compress.CompressFileGzip(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "LZMA" Then
                            Compress.CompressFileLZip(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        ElseIf My.Settings.Compreesion = "XZ" Then
                            Compress.CompressFileXZ(files, My.Settings.RF & "\" & files.Substring(files.IndexOf(GS)))
                        End If
                        'Directory.CreateDirectory("Compress\" & files.Substring(files.IndexOf(GS)))
                        Me.Invoke(Sub() ProgressBar1.Value = ListBox1.SelectedIndex + 1)
                        Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & files & " | " & CheckFileSize.GetFileSize(files) & " -> " & CheckFileSize.GetFileSize(My.Settings.RF & "\" & files.Substring(files.IndexOf(GS))) & vbCrLf)
                        Me.Invoke(Sub() RichTextBox1.SelectionStart = RichTextBox1.Text.Length)
                        Me.Invoke(Sub() RichTextBox1.ScrollToCaret())

                    End If
                Next
                Try
                    MsgBox("Compression done start to Repack :D." & vbCrLf & "PLEASE WAIT !!!!!", MsgBoxStyle.Information, "Hakkuraifu-Repacker")

                    Archive.ArchiveFile(My.Settings.RF & "\" & GF)
                    Archive.ArchiveDir(My.Settings.RF & "\" & GF)
                    deletealldir(My.Settings.RF & "\" & GF)
                    deleteallfile(My.Settings.RF & "\" & GF)
                    Dim fsize As Long
                    For Each file As String In My.Computer.FileSystem.GetFiles(My.Settings.RF & "\" & GF)
                        Dim finnfo As New System.IO.FileInfo(file)
                        fsize += finnfo.Length
                    Next
                    compsize = FormatBytes(fsize)
                    createconfig()
                    'SplitRepack()
                    MI()
                    MsgBox("Repack is done :D" & vbCrLf & vbCrLf & "Repack size : " & compsize, MsgBoxStyle.Information, "Hakkuraifu-Repacker")
                    enbalectrl()
                Catch ex As Exception
                    Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
                    enbalectrl()
                End Try
            Catch ex As Exception
                Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
            End Try
        End If



    End Sub

    Sub MI()
        Dim fs As System.IO.FileStream = New System.IO.FileStream(My.Settings.RF & "\" & GF & "\MI.zip", IO.FileMode.Create)

        fs.Write(My.Resources.MI, 0, My.Resources.MI.Length)

        fs.Close()

        ZipFile.ExtractToDirectory(My.Settings.RF & "\" & GF & "\MI.zip", My.Settings.RF & "\" & GF)

        File.Delete(My.Settings.RF & "\" & GF & "\MI.zip")

    End Sub

    <Obsolete>
    Sub SplitRepack()
        Dim setupf As String
        Dim setupc = 0

        For Each setupf In Directory.GetFiles(My.Settings.RF & "\" & GF)
            If setupf.Contains("Setup-") Then
                Directory.CreateDirectory(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc)
                File.Move(setupf, My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf))
                Dim myFile As New FileInfo(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf))
                If myFile.Length >= 1099511627776 Then
                    SplitFile.Program.SplitToBin(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf), My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf).Replace(".hakkr", ""), myFile.Length / 50)
                ElseIf myFile.Length >= 1073741824 Then
                    SplitFile.Program.SplitToBin(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf), My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf).Replace(".hakkr", ""), myFile.Length / 20)
                ElseIf myFile.Length >= 1048576 Then
                    SplitFile.Program.SplitToBin(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf), My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf).Replace(".hakkr", ""), myFile.Length / 10)
                ElseIf myFile.Length >= 1024 Then
                    SplitFile.Program.SplitToBin(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf), My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf).Replace(".hakkr", ""), myFile.Length / 5)
                Else
                    SplitFile.Program.SplitToBin(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf), My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf).Replace(".hakkr", ""), myFile.Length / 2)
                End If
                File.Delete(My.Settings.RF & "\" & GF & "\Repack\Setup-" & setupc & "\" & Path.GetFileName(setupf))
                setupc += 1
                End If

        Next
    End Sub

    Public Function FormatBytes(ByVal BytesCaller As ULong) As String

        Try
            Select Case BytesCaller
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = BytesCaller ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try

    End Function
    Sub createconfig()
        Dim configne As String = "Game name : " & TextBox1.Text & vbCrLf & "----------------------------" & vbCrLf & "Game version : " & TextBox2.Text & vbCrLf & "----------------------------" & vbCrLf & "Game creator : " & TextBox3.Text & vbCrLf & "----------------------------" & vbCrLf & "Store : " & TextBox4.Text & vbCrLf & "----------------------------" & vbCrLf & "Repack author : " & TextBox5.Text & vbCrLf & "----------------------------" & vbCrLf & "Author link : " & TextBox6.Text & vbCrLf & "----------------------------" & vbCrLf & "Crack used : " & TextBox8.Text & vbCrLf & "----------------------------" & vbCrLf & "Compression method : " & My.Settings.Compreesion.Replace(" (Recommended)", "") & vbCrLf & "----------------------------" & vbCrLf & "Repack size : " & compsize & vbCrLf & "----------------------------"
        Dim data As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(configne)
        Dim confige As String = Convert.ToBase64String(data)
        File.WriteAllText(My.Settings.RF & "\" & GF & "\config.ini", confige)
        Directory.CreateDirectory(My.Settings.RF & "\" & GF & "\Settings")
        File.Copy(bg, My.Settings.RF & "\" & GF & "\Settings\Background.jpg")
        File.Copy(icone, My.Settings.RF & "\" & GF & "\Settings\Icon.ico")
        If song = "" Then
        Else
            File.Copy(song, My.Settings.RF & "\" & GF & "\Settings\song.wav")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Settings.Show()
    End Sub
    Sub deletealldir(path As String)
        Try
            Dim dir As String
            For Each dir In Directory.GetDirectories(path)
                Directory.Delete(dir, True)
            Next
        Catch ex As Exception
            Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        End Try

    End Sub
    Sub deleteallfile(path As String)
        Try
            Dim files As String

            For Each files In Directory.GetFiles(path)
                If files.Contains("hakkr") Then
                Else
                    File.Delete(files)
                End If
            Next
        Catch ex As Exception
            Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("In the next update ;)", MsgBoxStyle.Exclamation, "Hakkuraifu-Repacker")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iconefile As New OpenFileDialog
        iconefile.Filter = "Icon files (*.ico)|*.ico"
        iconefile.Title = "Choose a icon for the installer"
        If iconefile.ShowDialog = DialogResult.OK Then
            icone = iconefile.FileName
            Label2.Visible = True
            Label2.Text = Path.GetFileName(iconefile.SafeFileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bgfile As New OpenFileDialog
        bgfile.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg"
        bgfile.Title = "Choose a background for the installer"
        If bgfile.ShowDialog = DialogResult.OK Then
            bg = bgfile.FileName
            Label3.Visible = True
            Label3.Text = Path.GetFileName(bgfile.SafeFileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim songfile As New OpenFileDialog
        songfile.Filter = "WAV files (*.wav)|*.wav"
        songfile.Title = "Choose a background song for the installer"
        If songfile.ShowDialog = DialogResult.OK Then
            song = songfile.FileName
            Label4.Visible = True
            Label4.Text = Path.GetFileName(songfile.SafeFileName)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        MsgBox("In the next update ;)", MsgBoxStyle.Exclamation, "Hakkuraifu-Repacker")

    End Sub

    <Obsolete>
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim tf As New OpenFileDialog
        If tf.ShowDialog = DialogResult.OK Then
            Dim tsf As New FolderBrowserDialog
            If tsf.ShowDialog = DialogResult.OK Then
                Dim myFile As New FileInfo(tf.FileName)
                MsgBox(Path.GetFileNameWithoutExtension(tf.FileName) & vbCrLf & myFile.Length.ToString)
                SplitFile.Program.SplitToBin(tf.FileName, tsf.SelectedPath & "\" & Path.GetFileNameWithoutExtension(tf.FileName).Replace(" ", "_"), myFile.Length / 2)
                MsgBox(tsf.SelectedPath & "\" & Path.GetFileNameWithoutExtension(tf.FileName.Replace(" ", "_").Replace("MP4", "*.bin").Replace(".mp4", "")))
                MsgBox(tsf.SelectedPath & "\" & Path.GetFileName(tf.SafeFileName.Replace(" ", "_")))
                systemcmd("copy /b " & tsf.SelectedPath & "\" & Path.GetFileNameWithoutExtension(tf.FileName.Replace(" ", "_").Replace("MP4", "*.bin").Replace(".mp4", "")) & " " & tsf.SelectedPath & "\" & Path.GetFileName(tf.SafeFileName.Replace(" ", "_")))
            End If
        End If
    End Sub



    Sub systemcmd(ByVal cmd As String)
        Shell("cmd /c """ & cmd & """", AppWinStyle.MinimizedFocus, True)
    End Sub


    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        MsgBox("In the next update ;)", MsgBoxStyle.Exclamation, "Hakkuraifu-Repacker")
    End Sub
End Class
