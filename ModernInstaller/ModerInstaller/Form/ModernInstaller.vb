Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ReaLTaiizor.Controls

Public Class ModernInstaller

    Private Sub HopeSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles HopeSwitch1.CheckedChanged
        If HopeSwitch1.Checked = True Then
            Panel1.BackColor = Color.FromArgb(40, 52, 64)
            ParrotForm1.MacOSLeftBackColor = Color.FromArgb(40, 52, 64)
            ParrotForm1.MacOSRightBackColor = Color.FromArgb(40, 52, 64)
            ParrotForm1.MacOSSeparatorColor = Color.FromArgb(40, 52, 64)
            ParrotForm1.MacOSForeColor = Color.FromArgb(35, 168, 109)
            rd.BaseColor = Color.FromArgb(60, 70, 73)
            gdt.BackColor = Color.FromArgb(60, 70, 73)
            gdt.ForeColor = Color.FromArgb(35, 168, 109)
            rd.TextColor = Color.FromArgb(35, 168, 109)
            MoonLabel1.Text = "DarkMode"
            MoonLabel1.ForeColor = Color.White
            MoonLabel2.ForeColor = Color.White
            MetroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark
            MaterialButton1.UseAccentColor = True
            MaterialButton2.UseAccentColor = True
            MaterialLabel1.UseAccent = True
            MaterialLabel2.UseAccent = True
            MetroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark
            ds.BackColor = Color.FromArgb(30, 30, 30)
            ds.ForeColor = Color.White
            sfb.UseAccentColor = True
            'SmallTextBox1.CustomBGColor = Color.White
            'SmallTextBox1.ForeColor = Color.Black

        Else
            Panel1.BackColor = Color.FromArgb(167, 179, 190)
            ParrotForm1.MacOSLeftBackColor = Color.FromArgb(167, 179, 190)
            ParrotForm1.MacOSRightBackColor = Color.FromArgb(167, 179, 190)
            ParrotForm1.MacOSSeparatorColor = Color.FromArgb(167, 179, 190)
            ParrotForm1.MacOSForeColor = Color.Black
            rd.BaseColor = Color.FromArgb(111, 131, 137)
            rd.TextColor = Color.Black
            gdt.BackColor = Color.FromArgb(111, 131, 137)
            gdt.ForeColor = Color.Black
            MoonLabel1.Text = "LightMode"
            MoonLabel1.ForeColor = Color.Black
            MaterialLabel1.UseAccent = False
            MaterialButton1.UseAccentColor = False
            MaterialButton2.UseAccentColor = False
            MaterialLabel2.UseAccent = False
            MoonLabel2.ForeColor = Color.Black
            MetroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light
            MetroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light
            ds.BackColor = Color.White
            ds.ForeColor = Color.Black
            sfb.UseAccentColor = False
            'SmallTextBox1.CustomBGColor = Color.Black
            'SmallTextBox1.ForeColor = Color.White

        End If
    End Sub

    Private Sub HopeSwitch2_CheckedChanged(sender As Object, e As EventArgs) Handles HopeSwitch2.CheckedChanged
        If HopeSwitch2.Checked = True Then
            PlayLoopingBackgroundSoundFile()
        Else
            StopBackgroundSound()
        End If
    End Sub

    Sub PlayLoopingBackgroundSoundFile()
        Try
            If System.IO.File.Exists(Application.StartupPath & "\Settings\song.wav") Then
                My.Computer.Audio.Play(Application.StartupPath & "\Settings\song.wav", AudioPlayMode.BackgroundLoop)
            Else
                HopeSwitch2.Visible = False
                MoonLabel2.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If MaterialButton1.Text = "Install" Then
            If ip.Text = "" Then
                MsgBox("Please select a installation path first !", MsgBoxStyle.Critical)
            Else
                Panel4.Visible = True
                MaterialButton1.Text = "Previous"
                MaterialButton1.Visible = False
                My.Settings.InstallationPath = ip.Text
            End If
        Else
            Panel3.Visible = True
            MaterialButton2.Visible = True
            MaterialButton1.Text = "Install"
        End If

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        If Panel4.Visible = True Then
            Panel4.Visible = False
            MaterialButton1.Visible = True
        End If
        If MaterialButton2.Visible = True Then
            MaterialButton2.Visible = False
            Panel3.Visible = False
            MaterialButton1.Text = "Next"
        End If

    End Sub

    Private Sub ParrotForm1_Paint(sender As Object, e As PaintEventArgs) Handles ParrotForm1.Paint

    End Sub

    Private Sub ModernInstaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(Application.StartupPath & "\Settings\Icon.ico") Then
            Dim Ico As New System.Drawing.Icon(Application.StartupPath & "\Settings\Icon.ico")
            Me.Icon = Ico
        Else
            MsgBox("Icon not found :(", MsgBoxStyle.Critical)
            Me.Close()
        End If
        If System.IO.File.Exists(Application.StartupPath & "\Settings\Background.jpg") Then
            bg1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Settings\Background.jpg")
            bg2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Settings\Background.jpg")

        Else
            MsgBox("Background image not found :(", MsgBoxStyle.Critical)
            Me.Close()
        End If
        If System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
            Dim d64 As String = DecodeBase64(File.ReadAllText(Application.StartupPath & "\config.ini"))
            Dim i, j, i2, j2 As Integer
            i = d64.IndexOf("Game name : ") + "Game name : ".Length
            j = d64.IndexOf(Environment.NewLine) - i
            gdt.Text = d64
            Dim IT As String = d64.Substring(i, j)
            'MsgBox(IT)
            Me.Text = Me.Text & IT
            ParrotForm1.TitleText = ParrotForm1.TitleText & IT
            My.Settings.GameName = IT
            i2 = d64.IndexOf("Compression method : ") + "Compression method : ".Length
            j2 = d64.IndexOf(Environment.NewLine) - i
            Dim IT2 As String = d64.Substring(i2, j2)
            'MsgBox(IT2)
            If IT2.Contains("ZTSD") Then
                My.Settings.Compression = "ZTSD"
            ElseIf IT2.Contains("XZ") Then
                My.Settings.Compression = "XZ"
            ElseIf IT2.Contains("Zlib") Then
                My.Settings.Compression = "Zlib"
            ElseIf IT2.Contains("GZip") Then
                My.Settings.Compression = "GZip"
            ElseIf IT2.Contains("Deflame") Then
                My.Settings.Compression = "Deflame"
            ElseIf IT2.Contains("Brotli") Then
                My.Settings.Compression = "Brotli"
            ElseIf IT2.Contains("LZMA") Then
                My.Settings.Compression = "LZMA"
            End If
        End If
            Me.Opacity = 0
        'Timer1.Start()
        Timer2.Start()
    End Sub

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim opacityFade As Single
        For opacityFade = 0 To 0.95 Step 0.05
            Me.Opacity = opacityFade
            Me.Refresh()
            'System.Threading.Thread.Sleep(10)
        Next opacityFade
        Me.Opacity = 0.95
        Timer2.Enabled = False
    End Sub

    Private Sub ModernInstaller_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub

    Private Sub sfb_Click(sender As Object, e As EventArgs) Handles sfb.Click
        Dim sf As New FolderBrowserDialog
        sf.Description = "Choose the installation path"
        sf.ShowNewFolderButton = True
        If sf.ShowDialog = DialogResult.OK Then
            ip.Text = sf.SelectedPath & "\" & My.Settings.GameName
            'My.Settings.Compression = "Zlib"
            My.Settings.InstallationPath = ip.Text
        End If
    End Sub

    Private Sub tac_TextChanged(sender As Object, e As EventArgs) Handles tac.TextChanged

    End Sub

    Private Sub tac_Click(sender As Object, e As EventArgs) Handles tac.Click
        ia.Visible = True
    End Sub

    Private Sub ia_CheckedChanged(sender As Object, e As EventArgs) Handles ia.CheckedChanged
        If ia.Checked = True Then
            ib.Visible = True
        End If
    End Sub

    Private Sub ib_Click(sender As Object, e As EventArgs) Handles ib.Click
        Directory.CreateDirectory(My.Settings.InstallationPath & "\Temp")
        status.Visible = True
        status.Text = "Extracting files pleas wait..."

        Dim t As New Thread(Sub()
                                DecompressFile(My.Settings.InstallationPath & "\Temp")
                            End Sub)
        t.IsBackground = True
        t.Start()

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
                    'MsgBox(My.Settings.InstallationPath & "\" & folder.Substring(folder.IndexOf(GS) + 5))
                    Directory.CreateDirectory(My.Settings.InstallationPath & "\" & folder.Substring(folder.IndexOf(GS) + 5))
                Else

                End If
            Next
        Catch ex As Exception
            'Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
        End Try
    End Sub

    Sub systemcmd(ByVal cmd As String)
        Shell("cmd /c """ & cmd & """", AppWinStyle.MinimizedFocus, True)
    End Sub

    Sub MergeBin()
        Dim bin As String
        For Each bin In Directory.GetDirectories("Repack\", "*", SearchOption.AllDirectories)
            If bin.Contains("Setup-") Then
                systemcmd("copy /b " & bin & "\*.bin" & " " & "Repack\" & Path.GetFileName(bin) & ".hakkr")
                Directory.Delete(bin, True)
            End If
        Next

    End Sub

    Sub DecompressFile(files As String)
        If Me.InvokeRequired Then

            Try
                Me.Invoke(Sub() UseWaitCursor = True)
                'MergeBin()
                Extract.Extract(ip.Text)
                If File.Exists(My.Settings.InstallationPath & "\Temp\[Content_Types].xml") Then
                    File.Delete(My.Settings.InstallationPath & "\Temp\[Content_Types].xml")
                End If
                Me.Invoke(Sub() status.Text = "Extraction done.")
                Dim fd As String
                For Each fd In Directory.GetFileSystemEntries(My.Settings.InstallationPath & "\Temp", "*", SearchOption.AllDirectories)
                    ListBox1.Items.Add(fd)

                Next
                CircleProgressBar1.Maximum = ListBox1.Items.Count
                Me.Invoke(Sub() status.Text = "Creating game folders...")
                AddFolder(Path.GetFileName(My.Settings.InstallationPath & "\Temp"))
                Me.Invoke(Sub() status.Text = "Game folders created.")
                Me.Invoke(Sub() MaterialButton2.Enabled = False)
                Me.Invoke(Sub() ib.Enabled = False)
                Me.Invoke(Sub() ia.Enabled = False)

                'disablectrl()
                'MsgBox(GF.Remove(0, GF.IndexOf(GF) + Path.GetDirectoryName(GF).Length + 1))
                Me.Invoke(Sub() status.Text = "Decompressing files...")
                Me.Invoke(Sub() CircleProgressBar1.Visible = True)
                Dim GS As String = files
                For i = 0 To ListBox1.Items.Count - 1
                    Me.Invoke(Sub() ListBox1.SelectedIndex = i)
                    'MsgBox("Compress\" & GF & "\" & Path.GetFileName(ListBox1.SelectedItem.ToString))
                    Me.Invoke(Sub() files = ListBox1.SelectedItem.ToString)
                    'MsgBox(GF.Substring(GF.IndexOf(Path.GetFileName(Path.GetDirectoryName(GF)))))
                    If WhatIsThisThing(files) = FileSystemObject.File Then
                        'GS = GF.Remove(0, GF.IndexOf(GF) + Path.GetFullPath(gs).Length)
                        'MsgBox(files.Substring(files.IndexOf("\Temp\") + 6))
                        If My.Settings.Compression = "ZSTD" Then
                            Decompress.DecompressFileZstdNet(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "Deflame" Then
                            Decompress.DecompressFileDeflate(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "Brotli" Then
                            Decompress.DecompressFileBrotli(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "Zlib" Then
                            Decompress.DecompressFileZlib(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "GZip" Then
                            Decompress.DecompressFileGzip(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "XZ" Then
                            Decompress.DecompressFileXZ(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        ElseIf My.Settings.Compression = "LZMA" Then
                            Decompress.DecompressFileLZip(files, My.Settings.InstallationPath & "\" & files.Substring(files.IndexOf("\Temp\") + 6))
                        End If
                        'Directory.CreateDirectory("Compress\" & files.Substring(files.IndexOf(GS)))
                        Me.Invoke(Sub() CircleProgressBar1.Value = ListBox1.SelectedIndex + 1)
                        'Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & files & " | " & CheckFileSize.GetFileSize(files) & " -> " & CheckFileSize.GetFileSize(My.Settings.RF & "\" & files.Substring(files.IndexOf(GS))) & vbCrLf)
                        'Me.Invoke(Sub() RichTextBox1.SelectionStart = RichTextBox1.Text.Length)
                        'Me.Invoke(Sub() RichTextBox1.ScrollToCaret())

                    End If
                Next
                Me.Invoke(Sub() UseWaitCursor = False)
                Directory.Delete(My.Settings.InstallationPath & "\Temp", True)
                Me.Invoke(Sub() status.Text = "Installation done.")
            Catch ex As Exception
                'Me.Invoke(Sub() RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Error : " & ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Hakkuraifu-Repacker")
                Me.Invoke(Sub() UseWaitCursor = False)
            End Try
        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
