<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModernInstaller
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModernInstaller))
        Me.ParrotForm1 = New ReaLTaiizor.Forms.ParrotForm()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CircleProgressBar1 = New ReaLTaiizor.Controls.CircleProgressBar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.status = New ReaLTaiizor.Controls.MoonLabel()
        Me.ib = New MaterialSkin.Controls.MaterialButton()
        Me.ia = New ReaLTaiizor.Controls.HopeCheckBox()
        Me.tac = New System.Windows.Forms.RichTextBox()
        Me.MetroPanel1 = New ReaLTaiizor.Controls.MetroPanel()
        Me.ds = New ReaLTaiizor.Controls.HopeCheckBox()
        Me.sfb = New ReaLTaiizor.Controls.MaterialButton()
        Me.MetroLabel1 = New ReaLTaiizor.Controls.MetroLabel()
        Me.ip = New ReaLTaiizor.Controls.SmallTextBox()
        Me.bg2 = New ReaLTaiizor.Controls.ParrotPictureBox()
        Me.bg1 = New ReaLTaiizor.Controls.ParrotPictureBox()
        Me.rd = New ReaLTaiizor.Controls.ForeverGroupBox()
        Me.gdt = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel2 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.HopeSwitch2 = New ReaLTaiizor.Controls.HopeSwitch()
        Me.HopeSwitch1 = New ReaLTaiizor.Controls.HopeSwitch()
        Me.MoonLabel2 = New ReaLTaiizor.Controls.MoonLabel()
        Me.MaterialLabel1 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MoonLabel1 = New ReaLTaiizor.Controls.MoonLabel()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.ParrotFormEllipse1 = New ReaLTaiizor.Controls.ParrotFormEllipse()
        Me.ParrotControlEllipse1 = New ReaLTaiizor.Controls.ParrotControlEllipse()
        Me.ParrotControlEllipse2 = New ReaLTaiizor.Controls.ParrotControlEllipse()
        Me.ParrotControlEllipse4 = New ReaLTaiizor.Controls.ParrotControlEllipse()
        Me.ParrotControlEllipse3 = New ReaLTaiizor.Controls.ParrotControlEllipse()
        Me.ParrotControlEllipse5 = New ReaLTaiizor.Controls.ParrotControlEllipse()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ParrotForm1.WorkingArea.SuspendLayout()
        Me.ParrotForm1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.rd.SuspendLayout()
        Me.SuspendLayout()
        '
        'ParrotForm1
        '
        Me.ParrotForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ParrotForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParrotForm1.ExitApplication = True
        Me.ParrotForm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParrotForm1.FormStyle = ReaLTaiizor.Forms.ParrotForm.Style.MacOS
        Me.ParrotForm1.Location = New System.Drawing.Point(0, 0)
        Me.ParrotForm1.MacOSForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ParrotForm1.MacOSLeftBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ParrotForm1.MacOSRightBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ParrotForm1.MacOSSeparatorColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ParrotForm1.MaterialBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ParrotForm1.MaterialForeColor = System.Drawing.Color.White
        Me.ParrotForm1.Name = "ParrotForm1"
        Me.ParrotForm1.ShowMaximize = False
        Me.ParrotForm1.ShowMinimize = True
        Me.ParrotForm1.Size = New System.Drawing.Size(1109, 644)
        Me.ParrotForm1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.ParrotForm1.TabIndex = 0
        Me.ParrotForm1.TitleText = "Installer | "
        Me.ParrotForm1.UbuntuForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ParrotForm1.UbuntuLeftBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ParrotForm1.UbuntuRightBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'ParrotForm1.WorkingArea
        '
        Me.ParrotForm1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ParrotForm1.WorkingArea.Controls.Add(Me.Panel1)
        Me.ParrotForm1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParrotForm1.WorkingArea.Location = New System.Drawing.Point(0, 39)
        Me.ParrotForm1.WorkingArea.Name = "WorkingArea"
        Me.ParrotForm1.WorkingArea.Size = New System.Drawing.Size(1109, 605)
        Me.ParrotForm1.WorkingArea.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MaterialLabel2)
        Me.Panel1.Controls.Add(Me.HopeSwitch2)
        Me.Panel1.Controls.Add(Me.HopeSwitch1)
        Me.Panel1.Controls.Add(Me.MoonLabel2)
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Controls.Add(Me.MaterialButton2)
        Me.Panel1.Controls.Add(Me.MoonLabel1)
        Me.Panel1.Controls.Add(Me.MaterialButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 605)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.bg1)
        Me.Panel2.Controls.Add(Me.rd)
        Me.Panel2.Location = New System.Drawing.Point(12, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 519)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.MetroPanel1)
        Me.Panel3.Controls.Add(Me.bg2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1085, 519)
        Me.Panel3.TabIndex = 5
        Me.Panel3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CircleProgressBar1)
        Me.Panel4.Controls.Add(Me.ListBox2)
        Me.Panel4.Controls.Add(Me.ListBox1)
        Me.Panel4.Controls.Add(Me.status)
        Me.Panel4.Controls.Add(Me.ib)
        Me.Panel4.Controls.Add(Me.ia)
        Me.Panel4.Controls.Add(Me.tac)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1085, 519)
        Me.Panel4.TabIndex = 2
        Me.Panel4.Visible = False
        '
        'CircleProgressBar1
        '
        Me.CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.CircleProgressBar1.ForeColor = System.Drawing.SystemColors.Window
        Me.CircleProgressBar1.Location = New System.Drawing.Point(475, 320)
        Me.CircleProgressBar1.Maximum = CType(100, Long)
        Me.CircleProgressBar1.MinimumSize = New System.Drawing.Size(100, 100)
        Me.CircleProgressBar1.Name = "CircleProgressBar1"
        Me.CircleProgressBar1.PercentColor = System.Drawing.Color.Transparent
        Me.CircleProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round
        Me.CircleProgressBar1.Size = New System.Drawing.Size(128, 128)
        Me.CircleProgressBar1.TabIndex = 10
        Me.CircleProgressBar1.Value = CType(0, Long)
        Me.CircleProgressBar1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(640, 281)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(441, 212)
        Me.ListBox2.TabIndex = 9
        Me.ListBox2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 281)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(441, 212)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.Visible = False
        '
        'status
        '
        Me.status.BackColor = System.Drawing.Color.Transparent
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.White
        Me.status.Location = New System.Drawing.Point(447, 281)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(189, 36)
        Me.status.TabIndex = 7
        Me.status.Text = "Waiting..."
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.status.Visible = False
        '
        'ib
        '
        Me.ib.AutoEllipsis = True
        Me.ib.AutoSize = False
        Me.ib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ib.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ib.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ib.Depth = 0
        Me.ib.HighEmphasis = True
        Me.ib.Icon = Nothing
        Me.ib.Location = New System.Drawing.Point(448, 457)
        Me.ib.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ib.MouseState = MaterialSkin.MouseState.HOVER
        Me.ib.Name = "ib"
        Me.ib.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ib.Size = New System.Drawing.Size(185, 36)
        Me.ib.TabIndex = 5
        Me.ib.Text = "Install the game"
        Me.ib.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.ib.UseAccentColor = True
        Me.ib.UseVisualStyleBackColor = True
        Me.ib.Visible = False
        '
        'ia
        '
        Me.ia.AutoSize = True
        Me.ia.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ia.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ia.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ia.DisabledStringColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ia.Enable = True
        Me.ia.EnabledCheckedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ia.EnabledStringColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ia.EnabledUncheckedColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ia.ForeColor = System.Drawing.Color.White
        Me.ia.Location = New System.Drawing.Point(1003, 281)
        Me.ia.Name = "ia"
        Me.ia.Size = New System.Drawing.Size(82, 20)
        Me.ia.TabIndex = 4
        Me.ia.Text = "I agree"
        Me.ia.UseVisualStyleBackColor = False
        Me.ia.Visible = False
        '
        'tac
        '
        Me.tac.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tac.Location = New System.Drawing.Point(3, -3)
        Me.tac.Name = "tac"
        Me.tac.Size = New System.Drawing.Size(1082, 278)
        Me.tac.TabIndex = 0
        Me.tac.Text = resources.GetString("tac.Text")
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MetroPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.MetroPanel1.BorderThickness = 2
        Me.MetroPanel1.Controls.Add(Me.ds)
        Me.MetroPanel1.Controls.Add(Me.sfb)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.ip)
        Me.MetroPanel1.IsDerivedStyle = True
        Me.MetroPanel1.Location = New System.Drawing.Point(127, 427)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(846, 80)
        Me.MetroPanel1.Style = ReaLTaiizor.[Enum].Metro.Style.Dark
        Me.MetroPanel1.StyleManager = Nothing
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.ThemeAuthor = "Taiizor"
        Me.MetroPanel1.ThemeName = "MetroDark"
        '
        'ds
        '
        Me.ds.AutoSize = True
        Me.ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ds.Checked = True
        Me.ds.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ds.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ds.DisabledStringColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ds.Enable = True
        Me.ds.EnabledCheckedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ds.EnabledStringColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ds.EnabledUncheckedColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ds.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ds.ForeColor = System.Drawing.Color.White
        Me.ds.Location = New System.Drawing.Point(677, 49)
        Me.ds.Name = "ds"
        Me.ds.Size = New System.Drawing.Size(153, 20)
        Me.ds.TabIndex = 3
        Me.ds.Text = "Desktop shortcut"
        Me.ds.UseVisualStyleBackColor = False
        Me.ds.Visible = False
        '
        'sfb
        '
        Me.sfb.AutoSize = False
        Me.sfb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.sfb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sfb.Depth = 0
        Me.sfb.DrawShadows = True
        Me.sfb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfb.HighEmphasis = True
        Me.sfb.Icon = Nothing
        Me.sfb.Location = New System.Drawing.Point(754, 12)
        Me.sfb.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.sfb.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.sfb.Name = "sfb"
        Me.sfb.Size = New System.Drawing.Size(76, 28)
        Me.sfb.TabIndex = 2
        Me.sfb.Text = "..."
        Me.sfb.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.sfb.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.sfb.UseAccentColor = True
        Me.sfb.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroLabel1.IsDerivedStyle = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 17)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(117, 23)
        Me.MetroLabel1.Style = ReaLTaiizor.[Enum].Metro.Style.Dark
        Me.MetroLabel1.StyleManager = Nothing
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Installation path :"
        Me.MetroLabel1.ThemeAuthor = "Taiizor"
        Me.MetroLabel1.ThemeName = "MetroDark"
        '
        'ip
        '
        Me.ip.BackColor = System.Drawing.Color.Transparent
        Me.ip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ip.CustomBGColor = System.Drawing.Color.White
        Me.ip.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ip.ForeColor = System.Drawing.Color.Black
        Me.ip.Location = New System.Drawing.Point(135, 12)
        Me.ip.MaxLength = 32767
        Me.ip.Multiline = False
        Me.ip.Name = "ip"
        Me.ip.ReadOnly = False
        Me.ip.Size = New System.Drawing.Size(612, 28)
        Me.ip.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.ip.TabIndex = 0
        Me.ip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ip.UseSystemPasswordChar = False
        '
        'bg2
        '
        Me.bg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bg2.ColorLeft = System.Drawing.Color.DodgerBlue
        Me.bg2.ColorRight = System.Drawing.Color.DodgerBlue
        Me.bg2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.bg2.FilterAlpha = 0
        Me.bg2.FilterEnabled = False
        Me.bg2.Image = Nothing
        Me.bg2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.bg2.IsElipse = True
        Me.bg2.IsParallax = False
        Me.bg2.Location = New System.Drawing.Point(127, 3)
        Me.bg2.Name = "bg2"
        Me.bg2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.bg2.Size = New System.Drawing.Size(846, 418)
        Me.bg2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.bg2.TabIndex = 0
        Me.bg2.Text = "ParrotPictureBox2"
        Me.bg2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'bg1
        '
        Me.bg1.BackgroundImage = CType(resources.GetObject("bg1.BackgroundImage"), System.Drawing.Image)
        Me.bg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bg1.ColorLeft = System.Drawing.Color.DodgerBlue
        Me.bg1.ColorRight = System.Drawing.Color.DodgerBlue
        Me.bg1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.bg1.FilterAlpha = 200
        Me.bg1.FilterEnabled = True
        Me.bg1.Image = Nothing
        Me.bg1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.bg1.IsElipse = True
        Me.bg1.IsParallax = False
        Me.bg1.Location = New System.Drawing.Point(448, 16)
        Me.bg1.Name = "bg1"
        Me.bg1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.bg1.Size = New System.Drawing.Size(624, 362)
        Me.bg1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.bg1.TabIndex = 1
        Me.bg1.Text = "ParrotPictureBox1"
        Me.bg1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'rd
        '
        Me.rd.ArrowColorF = System.Drawing.Color.Transparent
        Me.rd.ArrowColorH = System.Drawing.Color.Transparent
        Me.rd.BackColor = System.Drawing.Color.Transparent
        Me.rd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.rd.Controls.Add(Me.gdt)
        Me.rd.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd.Location = New System.Drawing.Point(3, 6)
        Me.rd.Name = "rd"
        Me.rd.ShowArrow = True
        Me.rd.ShowText = True
        Me.rd.Size = New System.Drawing.Size(439, 513)
        Me.rd.TabIndex = 6
        Me.rd.Text = "Repack Information"
        Me.rd.TextColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        '
        'gdt
        '
        Me.gdt.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.gdt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gdt.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.gdt.Location = New System.Drawing.Point(18, 81)
        Me.gdt.Name = "gdt"
        Me.gdt.Size = New System.Drawing.Size(402, 410)
        Me.gdt.TabIndex = 0
        Me.gdt.Text = ""
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Overline
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MaterialLabel2.HighEmphasis = True
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 585)
        Me.MaterialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(54, 13)
        Me.MaterialLabel2.TabIndex = 15
        Me.MaterialLabel2.Text = "v 0.1 | BETA"
        Me.MaterialLabel2.UseAccent = True
        '
        'HopeSwitch2
        '
        Me.HopeSwitch2.AutoSize = True
        Me.HopeSwitch2.BaseColor = System.Drawing.Color.White
        Me.HopeSwitch2.BaseOffColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.HopeSwitch2.BaseOnColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HopeSwitch2.Checked = True
        Me.HopeSwitch2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HopeSwitch2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HopeSwitch2.Location = New System.Drawing.Point(139, 552)
        Me.HopeSwitch2.Name = "HopeSwitch2"
        Me.HopeSwitch2.Size = New System.Drawing.Size(40, 20)
        Me.HopeSwitch2.TabIndex = 14
        Me.HopeSwitch2.Text = "HopeSwitch2"
        Me.HopeSwitch2.UseVisualStyleBackColor = True
        '
        'HopeSwitch1
        '
        Me.HopeSwitch1.AutoSize = True
        Me.HopeSwitch1.BaseColor = System.Drawing.Color.White
        Me.HopeSwitch1.BaseOffColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.HopeSwitch1.BaseOnColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HopeSwitch1.Checked = True
        Me.HopeSwitch1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HopeSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HopeSwitch1.Location = New System.Drawing.Point(12, 552)
        Me.HopeSwitch1.Name = "HopeSwitch1"
        Me.HopeSwitch1.Size = New System.Drawing.Size(40, 20)
        Me.HopeSwitch1.TabIndex = 13
        Me.HopeSwitch1.Text = "HopeSwitch1"
        Me.HopeSwitch1.UseVisualStyleBackColor = True
        '
        'MoonLabel2
        '
        Me.MoonLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MoonLabel2.ForeColor = System.Drawing.Color.White
        Me.MoonLabel2.Location = New System.Drawing.Point(185, 543)
        Me.MoonLabel2.Name = "MoonLabel2"
        Me.MoonLabel2.Size = New System.Drawing.Size(75, 36)
        Me.MoonLabel2.TabIndex = 12
        Me.MoonLabel2.Text = "Music"
        Me.MoonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Overline
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MaterialLabel1.HighEmphasis = True
        Me.MaterialLabel1.Location = New System.Drawing.Point(920, 585)
        Me.MaterialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(176, 13)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "Repacked by using Hakkuraifu-Repacker"
        Me.MaterialLabel1.UseAccent = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoEllipsis = True
        Me.MaterialButton2.AutoSize = False
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(882, 543)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(103, 36)
        Me.MaterialButton2.TabIndex = 9
        Me.MaterialButton2.Text = "Previous"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = True
        Me.MaterialButton2.UseVisualStyleBackColor = True
        Me.MaterialButton2.Visible = False
        '
        'MoonLabel1
        '
        Me.MoonLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MoonLabel1.ForeColor = System.Drawing.Color.White
        Me.MoonLabel1.Location = New System.Drawing.Point(58, 547)
        Me.MoonLabel1.Name = "MoonLabel1"
        Me.MoonLabel1.Size = New System.Drawing.Size(75, 29)
        Me.MoonLabel1.TabIndex = 8
        Me.MoonLabel1.Text = "DarkMode"
        Me.MoonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoEllipsis = True
        Me.MaterialButton1.AutoSize = False
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(993, 543)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(103, 36)
        Me.MaterialButton1.TabIndex = 0
        Me.MaterialButton1.Text = "Next"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = True
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'ParrotFormEllipse1
        '
        Me.ParrotFormEllipse1.CornerRadius = 20
        Me.ParrotFormEllipse1.EffectedForm = Me
        '
        'ParrotControlEllipse1
        '
        Me.ParrotControlEllipse1.CornerRadius = 20
        Me.ParrotControlEllipse1.EffectedControl = Me.bg1
        '
        'ParrotControlEllipse2
        '
        Me.ParrotControlEllipse2.CornerRadius = 20
        Me.ParrotControlEllipse2.EffectedControl = Nothing
        '
        'ParrotControlEllipse4
        '
        Me.ParrotControlEllipse4.CornerRadius = 20
        Me.ParrotControlEllipse4.EffectedControl = Me.bg2
        '
        'ParrotControlEllipse3
        '
        Me.ParrotControlEllipse3.CornerRadius = 20
        Me.ParrotControlEllipse3.EffectedControl = Nothing
        '
        'ParrotControlEllipse5
        '
        Me.ParrotControlEllipse5.CornerRadius = 20
        Me.ParrotControlEllipse5.EffectedControl = Me.tac
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'ModernInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 644)
        Me.Controls.Add(Me.ParrotForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1032)
        Me.MinimumSize = New System.Drawing.Size(190, 40)
        Me.Name = "ModernInstaller"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Installer | "
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ParrotForm1.WorkingArea.ResumeLayout(False)
        Me.ParrotForm1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.rd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParrotForm1 As ReaLTaiizor.Forms.ParrotForm
    Friend WithEvents ParrotFormEllipse1 As ReaLTaiizor.Controls.ParrotFormEllipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents bg1 As ReaLTaiizor.Controls.ParrotPictureBox
    Friend WithEvents ParrotControlEllipse1 As ReaLTaiizor.Controls.ParrotControlEllipse
    Friend WithEvents ParrotControlEllipse2 As ReaLTaiizor.Controls.ParrotControlEllipse
    Friend WithEvents MoonLabel1 As ReaLTaiizor.Controls.MoonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents MoonLabel2 As ReaLTaiizor.Controls.MoonLabel
    Friend WithEvents HopeSwitch1 As ReaLTaiizor.Controls.HopeSwitch
    Friend WithEvents HopeSwitch2 As ReaLTaiizor.Controls.HopeSwitch
    Friend WithEvents MaterialLabel2 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bg2 As ReaLTaiizor.Controls.ParrotPictureBox
    Friend WithEvents MetroPanel1 As ReaLTaiizor.Controls.MetroPanel
    Friend WithEvents ds As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents sfb As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents MetroLabel1 As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents ip As ReaLTaiizor.Controls.SmallTextBox
    Friend WithEvents ParrotControlEllipse4 As ReaLTaiizor.Controls.ParrotControlEllipse
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tac As RichTextBox
    Friend WithEvents ParrotControlEllipse3 As ReaLTaiizor.Controls.ParrotControlEllipse
    Friend WithEvents ParrotControlEllipse5 As ReaLTaiizor.Controls.ParrotControlEllipse
    Friend WithEvents status As ReaLTaiizor.Controls.MoonLabel
    Friend WithEvents ib As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ia As ReaLTaiizor.Controls.HopeCheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents CircleProgressBar1 As ReaLTaiizor.Controls.CircleProgressBar
    Friend WithEvents rd As ReaLTaiizor.Controls.ForeverGroupBox
    Friend WithEvents gdt As RichTextBox
End Class
