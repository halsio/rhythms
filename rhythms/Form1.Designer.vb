<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.lblCMDOutput = New System.Windows.Forms.Label()
        Me.txtProjDir = New System.Windows.Forms.TextBox()
        Me.txtProjName = New System.Windows.Forms.TextBox()
        Me.txtProjPort = New System.Windows.Forms.TextBox()
        Me.pnlInstaller = New System.Windows.Forms.Panel()
        Me.picLoader = New System.Windows.Forms.PictureBox()
        Me.lblInstaller = New System.Windows.Forms.Label()
        Me.pnlRepos = New System.Windows.Forms.Panel()
        Me.repoList = New System.Windows.Forms.ListBox()
        Me.lblRepo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.stepSub = New System.Windows.Forms.Label()
        Me.stepMain = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtUpdateDir = New System.Windows.Forms.TextBox()
        Me.lblBG3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblBG2 = New System.Windows.Forms.Label()
        Me.lblHostStatus = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblHTTPD = New System.Windows.Forms.Label()
        Me.lblHTTPDStatus = New System.Windows.Forms.Label()
        Me.lblApacheStatus = New System.Windows.Forms.Label()
        Me.lblInternetStatus = New System.Windows.Forms.Label()
        Me.lblInternet = New System.Windows.Forms.Label()
        Me.lblApache = New System.Windows.Forms.Label()
        Me.lblBG = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bgaddWorker = New System.ComponentModel.BackgroundWorker()
        Me.bgsetupWorker = New System.ComponentModel.BackgroundWorker()
        Me.bgupdateWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.pnlInstaller.SuspendLayout()
        CType(Me.picLoader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRepos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 539)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.pnlHome)
        Me.Panel6.Controls.Add(Me.pnlInstaller)
        Me.Panel6.Controls.Add(Me.pnlRepos)
        Me.Panel6.Controls.Add(Me.btnExit)
        Me.Panel6.Controls.Add(Me.stepSub)
        Me.Panel6.Controls.Add(Me.stepMain)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.imgLogo)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(312, 539)
        Me.Panel6.TabIndex = 0
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHome.Controls.Add(Me.lblCMDOutput)
        Me.pnlHome.Controls.Add(Me.txtProjDir)
        Me.pnlHome.Controls.Add(Me.txtProjName)
        Me.pnlHome.Controls.Add(Me.txtProjPort)
        Me.pnlHome.Location = New System.Drawing.Point(22, 196)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(267, 216)
        Me.pnlHome.TabIndex = 9
        '
        'lblCMDOutput
        '
        Me.lblCMDOutput.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.lblCMDOutput.ForeColor = System.Drawing.Color.White
        Me.lblCMDOutput.Location = New System.Drawing.Point(1, 7)
        Me.lblCMDOutput.Name = "lblCMDOutput"
        Me.lblCMDOutput.Size = New System.Drawing.Size(271, 125)
        Me.lblCMDOutput.TabIndex = 5
        Me.lblCMDOutput.Text = "What shall we call your new project? You can also assign a port for your virtual " & _
    "host."
        Me.lblCMDOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProjDir
        '
        Me.txtProjDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtProjDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjDir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtProjDir.ForeColor = System.Drawing.Color.White
        Me.txtProjDir.Location = New System.Drawing.Point(61, 166)
        Me.txtProjDir.Name = "txtProjDir"
        Me.txtProjDir.Size = New System.Drawing.Size(148, 20)
        Me.txtProjDir.TabIndex = 8
        Me.txtProjDir.Text = "Select Path"
        Me.txtProjDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProjName
        '
        Me.txtProjName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtProjName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtProjName.ForeColor = System.Drawing.Color.White
        Me.txtProjName.Location = New System.Drawing.Point(28, 140)
        Me.txtProjName.Name = "txtProjName"
        Me.txtProjName.Size = New System.Drawing.Size(148, 20)
        Me.txtProjName.TabIndex = 6
        Me.txtProjName.Text = "Enter Project Name"
        Me.txtProjName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProjPort
        '
        Me.txtProjPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtProjPort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjPort.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtProjPort.ForeColor = System.Drawing.Color.White
        Me.txtProjPort.Location = New System.Drawing.Point(182, 140)
        Me.txtProjPort.Name = "txtProjPort"
        Me.txtProjPort.Size = New System.Drawing.Size(70, 20)
        Me.txtProjPort.TabIndex = 7
        Me.txtProjPort.Text = "Port"
        Me.txtProjPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlInstaller
        '
        Me.pnlInstaller.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlInstaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInstaller.Controls.Add(Me.picLoader)
        Me.pnlInstaller.Controls.Add(Me.lblInstaller)
        Me.pnlInstaller.Location = New System.Drawing.Point(22, 196)
        Me.pnlInstaller.Name = "pnlInstaller"
        Me.pnlInstaller.Size = New System.Drawing.Size(267, 216)
        Me.pnlInstaller.TabIndex = 18
        Me.pnlInstaller.Visible = False
        '
        'picLoader
        '
        Me.picLoader.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picLoader.Image = Global.rhythms.My.Resources.Resources.loder
        Me.picLoader.Location = New System.Drawing.Point(10, 0)
        Me.picLoader.Name = "picLoader"
        Me.picLoader.Size = New System.Drawing.Size(241, 28)
        Me.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoader.TabIndex = 10
        Me.picLoader.TabStop = False
        '
        'lblInstaller
        '
        Me.lblInstaller.Font = New System.Drawing.Font("Calibri Light", 12.0!)
        Me.lblInstaller.ForeColor = System.Drawing.Color.White
        Me.lblInstaller.Location = New System.Drawing.Point(13, 31)
        Me.lblInstaller.Name = "lblInstaller"
        Me.lblInstaller.Size = New System.Drawing.Size(238, 177)
        Me.lblInstaller.TabIndex = 9
        Me.lblInstaller.Text = "Loading Laravel Console..."
        Me.lblInstaller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRepos
        '
        Me.pnlRepos.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlRepos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRepos.Controls.Add(Me.repoList)
        Me.pnlRepos.Controls.Add(Me.lblRepo)
        Me.pnlRepos.Location = New System.Drawing.Point(22, 196)
        Me.pnlRepos.Name = "pnlRepos"
        Me.pnlRepos.Size = New System.Drawing.Size(267, 216)
        Me.pnlRepos.TabIndex = 19
        Me.pnlRepos.Visible = False
        '
        'repoList
        '
        Me.repoList.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.repoList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.repoList.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.repoList.ForeColor = System.Drawing.Color.White
        Me.repoList.FormattingEnabled = True
        Me.repoList.ItemHeight = 18
        Me.repoList.Location = New System.Drawing.Point(9, 67)
        Me.repoList.Name = "repoList"
        Me.repoList.Size = New System.Drawing.Size(247, 126)
        Me.repoList.TabIndex = 11
        '
        'lblRepo
        '
        Me.lblRepo.Font = New System.Drawing.Font("Calibri Light", 12.0!)
        Me.lblRepo.ForeColor = System.Drawing.Color.White
        Me.lblRepo.Location = New System.Drawing.Point(10, 7)
        Me.lblRepo.Name = "lblRepo"
        Me.lblRepo.Size = New System.Drawing.Size(246, 46)
        Me.lblRepo.TabIndex = 10
        Me.lblRepo.Text = "Select the JSON code to add them to the below list."
        Me.lblRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(284, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "x"
        '
        'stepSub
        '
        Me.stepSub.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepSub.ForeColor = System.Drawing.Color.Silver
        Me.stepSub.Location = New System.Drawing.Point(18, 130)
        Me.stepSub.Name = "stepSub"
        Me.stepSub.Size = New System.Drawing.Size(271, 30)
        Me.stepSub.TabIndex = 3
        Me.stepSub.Text = "give your project a name"
        '
        'stepMain
        '
        Me.stepMain.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepMain.ForeColor = System.Drawing.Color.White
        Me.stepMain.Location = New System.Drawing.Point(18, 100)
        Me.stepMain.Name = "stepMain"
        Me.stepMain.Size = New System.Drawing.Size(110, 45)
        Me.stepMain.TabIndex = 3
        Me.stepMain.Text = "Step 1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.rhythms.My.Resources.Resources.xzxzcxx
        Me.PictureBox3.Location = New System.Drawing.Point(-13, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnMain)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 465)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(310, 72)
        Me.Panel8.TabIndex = 0
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.Color.White
        Me.btnMain.Location = New System.Drawing.Point(210, 23)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(79, 30)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Compose"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.rhythms.My.Resources.Resources.sdfdsfds
        Me.imgLogo.Location = New System.Drawing.Point(-1, 6)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(171, 83)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Lime
        Me.Panel5.Location = New System.Drawing.Point(311, -12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(19, 50)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lime
        Me.Panel4.Location = New System.Drawing.Point(311, 504)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(19, 79)
        Me.Panel4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Location = New System.Drawing.Point(314, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 466)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel7.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.webBrowser)
        Me.Panel7.Controls.Add(Me.btnUpdate)
        Me.Panel7.Controls.Add(Me.txtUpdateDir)
        Me.Panel7.Controls.Add(Me.lblBG3)
        Me.Panel7.Controls.Add(Me.lblError)
        Me.Panel7.Controls.Add(Me.lblBG2)
        Me.Panel7.Controls.Add(Me.lblHostStatus)
        Me.Panel7.Controls.Add(Me.lblHost)
        Me.Panel7.Controls.Add(Me.lblHTTPD)
        Me.Panel7.Controls.Add(Me.lblHTTPDStatus)
        Me.Panel7.Controls.Add(Me.lblApacheStatus)
        Me.Panel7.Controls.Add(Me.lblInternetStatus)
        Me.Panel7.Controls.Add(Me.lblInternet)
        Me.Panel7.Controls.Add(Me.lblApache)
        Me.Panel7.Controls.Add(Me.lblBG)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(372, 466)
        Me.Panel7.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel10.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.Panel10.Location = New System.Drawing.Point(-4, 452)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(378, 21)
        Me.Panel10.TabIndex = 1
        Me.Panel10.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel9.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.Panel9.Location = New System.Drawing.Point(-6, -10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(378, 21)
        Me.Panel9.TabIndex = 0
        Me.Panel9.Visible = False
        '
        'webBrowser
        '
        Me.webBrowser.IsWebBrowserContextMenuEnabled = False
        Me.webBrowser.Location = New System.Drawing.Point(-13, -25)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.ScriptErrorsSuppressed = True
        Me.webBrowser.Size = New System.Drawing.Size(409, 490)
        Me.webBrowser.TabIndex = 17
        Me.webBrowser.Url = New System.Uri("http://packagist.org/", System.UriKind.Absolute)
        Me.webBrowser.Visible = False
        Me.webBrowser.WebBrowserShortcutsEnabled = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnUpdate.BackgroundImage = Global.rhythms.My.Resources.Resources.gplaypattern
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(254, 245)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 30)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtUpdateDir
        '
        Me.txtUpdateDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtUpdateDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUpdateDir.Font = New System.Drawing.Font("Calibri Light", 14.0!)
        Me.txtUpdateDir.ForeColor = System.Drawing.Color.White
        Me.txtUpdateDir.Location = New System.Drawing.Point(28, 247)
        Me.txtUpdateDir.Name = "txtUpdateDir"
        Me.txtUpdateDir.Size = New System.Drawing.Size(207, 23)
        Me.txtUpdateDir.TabIndex = 21
        Me.txtUpdateDir.Text = "Select Project Path"
        Me.txtUpdateDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBG3
        '
        Me.lblBG3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblBG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBG3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBG3.ForeColor = System.Drawing.Color.White
        Me.lblBG3.Location = New System.Drawing.Point(-16, 228)
        Me.lblBG3.Name = "lblBG3"
        Me.lblBG3.Size = New System.Drawing.Size(391, 62)
        Me.lblBG3.TabIndex = 23
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblError.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblError.ForeColor = System.Drawing.Color.White
        Me.lblError.Location = New System.Drawing.Point(7, 43)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(352, 150)
        Me.lblError.TabIndex = 20
        Me.lblError.Text = "Any errors encountered during runtime will show up here. Click the Titlebar to cl" & _
    "ose this sidebar."
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBG2
        '
        Me.lblBG2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblBG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBG2.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblBG2.ForeColor = System.Drawing.Color.White
        Me.lblBG2.Location = New System.Drawing.Point(-3, 39)
        Me.lblBG2.Name = "lblBG2"
        Me.lblBG2.Size = New System.Drawing.Size(378, 159)
        Me.lblBG2.TabIndex = 19
        Me.lblBG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHostStatus
        '
        Me.lblHostStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblHostStatus.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.lblHostStatus.ForeColor = System.Drawing.Color.White
        Me.lblHostStatus.Location = New System.Drawing.Point(84, 374)
        Me.lblHostStatus.Name = "lblHostStatus"
        Me.lblHostStatus.Size = New System.Drawing.Size(266, 19)
        Me.lblHostStatus.TabIndex = 16
        Me.lblHostStatus.Text = "None"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblHost.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblHost.ForeColor = System.Drawing.Color.White
        Me.lblHost.Location = New System.Drawing.Point(17, 374)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(36, 18)
        Me.lblHost.TabIndex = 15
        Me.lblHost.Text = "Host"
        '
        'lblHTTPD
        '
        Me.lblHTTPD.AutoSize = True
        Me.lblHTTPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblHTTPD.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblHTTPD.ForeColor = System.Drawing.Color.White
        Me.lblHTTPD.Location = New System.Drawing.Point(17, 394)
        Me.lblHTTPD.Name = "lblHTTPD"
        Me.lblHTTPD.Size = New System.Drawing.Size(48, 18)
        Me.lblHTTPD.TabIndex = 18
        Me.lblHTTPD.Text = "HTTPD"
        '
        'lblHTTPDStatus
        '
        Me.lblHTTPDStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblHTTPDStatus.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.lblHTTPDStatus.ForeColor = System.Drawing.Color.White
        Me.lblHTTPDStatus.Location = New System.Drawing.Point(84, 394)
        Me.lblHTTPDStatus.Name = "lblHTTPDStatus"
        Me.lblHTTPDStatus.Size = New System.Drawing.Size(266, 18)
        Me.lblHTTPDStatus.TabIndex = 17
        Me.lblHTTPDStatus.Text = "None"
        '
        'lblApacheStatus
        '
        Me.lblApacheStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblApacheStatus.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.lblApacheStatus.ForeColor = System.Drawing.Color.White
        Me.lblApacheStatus.Location = New System.Drawing.Point(84, 354)
        Me.lblApacheStatus.Name = "lblApacheStatus"
        Me.lblApacheStatus.Size = New System.Drawing.Size(266, 18)
        Me.lblApacheStatus.TabIndex = 14
        Me.lblApacheStatus.Text = "None"
        '
        'lblInternetStatus
        '
        Me.lblInternetStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblInternetStatus.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.lblInternetStatus.ForeColor = System.Drawing.Color.White
        Me.lblInternetStatus.Location = New System.Drawing.Point(84, 334)
        Me.lblInternetStatus.Name = "lblInternetStatus"
        Me.lblInternetStatus.Size = New System.Drawing.Size(266, 18)
        Me.lblInternetStatus.TabIndex = 11
        Me.lblInternetStatus.Text = "None"
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblInternet.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblInternet.ForeColor = System.Drawing.Color.White
        Me.lblInternet.Location = New System.Drawing.Point(17, 334)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(59, 18)
        Me.lblInternet.TabIndex = 10
        Me.lblInternet.Text = "Internet"
        '
        'lblApache
        '
        Me.lblApache.AutoSize = True
        Me.lblApache.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblApache.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblApache.ForeColor = System.Drawing.Color.White
        Me.lblApache.Location = New System.Drawing.Point(17, 354)
        Me.lblApache.Name = "lblApache"
        Me.lblApache.Size = New System.Drawing.Size(54, 18)
        Me.lblApache.TabIndex = 13
        Me.lblApache.Text = "Apache"
        '
        'lblBG
        '
        Me.lblBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBG.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBG.ForeColor = System.Drawing.Color.White
        Me.lblBG.Location = New System.Drawing.Point(-16, 319)
        Me.lblBG.Name = "lblBG"
        Me.lblBG.Size = New System.Drawing.Size(393, 111)
        Me.lblBG.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lime
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(689, 544)
        Me.Panel3.TabIndex = 2
        '
        'bgaddWorker
        '
        '
        'bgsetupWorker
        '
        '
        'bgupdateWorker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(689, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rhythms"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlInstaller.ResumeLayout(False)
        CType(Me.picLoader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRepos.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents stepSub As System.Windows.Forms.Label
    Friend WithEvents stepMain As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents txtProjDir As System.Windows.Forms.TextBox
    Friend WithEvents txtProjPort As System.Windows.Forms.TextBox
    Friend WithEvents txtProjName As System.Windows.Forms.TextBox
    Friend WithEvents lblCMDOutput As System.Windows.Forms.Label
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblBG2 As System.Windows.Forms.Label
    Friend WithEvents lblHostStatus As System.Windows.Forms.Label
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents lblHTTPD As System.Windows.Forms.Label
    Friend WithEvents lblHTTPDStatus As System.Windows.Forms.Label
    Friend WithEvents lblApacheStatus As System.Windows.Forms.Label
    Friend WithEvents lblInternetStatus As System.Windows.Forms.Label
    Friend WithEvents lblInternet As System.Windows.Forms.Label
    Friend WithEvents lblApache As System.Windows.Forms.Label
    Friend WithEvents lblBG As System.Windows.Forms.Label
    Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents bgaddWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgsetupWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgupdateWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtUpdateDir As System.Windows.Forms.TextBox
    Friend WithEvents lblBG3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents pnlInstaller As System.Windows.Forms.Panel
    Friend WithEvents picLoader As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstaller As System.Windows.Forms.Label
    Friend WithEvents pnlRepos As System.Windows.Forms.Panel
    Friend WithEvents repoList As System.Windows.Forms.ListBox
    Friend WithEvents lblRepo As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel

End Class
