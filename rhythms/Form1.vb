Imports System.IO 'Used for reading and writing to the windows file system.
Imports System.Text 'Used for processing strings.
Imports mshtml 'Used to inject JS into the webBrowser control.

Public Class Form1

    '///////////////////////////////////////////////////

#Region "Check Internet Connection"

    'Create placeholders for internet status.
    Dim statusHTTP As Boolean = Nothing

    'Find internet status'
    Sub invokeHTTP()
        'Set a ping URL to check connection.
        Dim url As New System.Uri("http://www.google.com/")
        'Create new web request.
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        'Retrieve response from web URL.
        Dim resp As System.Net.WebResponse
        Try
            'If URL responds without error, internet is available.
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            statusHTTP = True
            lblInternetStatus.Text = "Active"
        Catch ex As Exception
            'If an error is raised, internet is unavailable.
            req = Nothing
            statusHTTP = False
            updateText(ex.Message & vbNewLine & "Theres was a problem determining internet status. Please restart rhythms with admin rights.", lblError)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Check Host Status"

    'Create placeholder for Host path.
    Dim dirHOSTfile As String = Nothing

    'Find Host path and check if Host is protected.
    Sub invokeHOST()
        'Get system Root path and set placeholder.
        Dim rootPath = Environment.GetFolderPath(Environment.SpecialFolder.System)
        dirHOSTfile = rootPath & "\drivers\etc\hosts"
        Try
            'Read Host file contents.
            Dim fileLines As String = Nothing
            Using streamReader As New StreamReader(dirHOSTfile)
                fileLines = streamReader.ReadToEnd()
            End Using
            'Add a #newProject line to Host file. This is to check for writability and for further reference.
            If Not fileLines.Contains("#newProject") Then
                Using streamWriter As New StreamWriter(dirHOSTfile)
                    streamWriter.Write(fileLines & vbNewLine & "#newProject")
                End Using
            End If
            lblHostStatus.Text = "Modifiable"
        Catch ex As Exception
            'On error unset Host path.
            lblHostStatus.Text = "UNWRITABLE"
            updateText(ex.Message & vbNewLine & "Theres was a problem accessing your hosts file. Please restart rhythms with admin rights.", lblError)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Apache"

    'Create placeholders for Apache paths.
    Dim dirHTTPDconf As String = Nothing
    Dim dirHTTPDexe As String = Nothing

    'Find Apache process and verify files and paths.
    Sub invokeHTTPD()
        Try
            'Create Placeholder for instances.
            Dim procInstance As Integer = 0
            'Look for a running HTTPD process.
            For Each myprocess As Process In Process.GetProcessesByName("httpd")
                dirHTTPDexe = myprocess.MainModule.FileName.ToString
                procInstance += 1
            Next
            If Not dirHTTPDexe = Nothing Then
                'Set Apache confguration path.
                dirHTTPDconf = dirHTTPDexe.Replace("bin\httpd.exe", "conf\httpd.conf")
            Else
                updateText("Rhythms couldnt find the apache process. Please start apache and run Rhythms with admin rights.", lblError)
                Exit Sub
            End If
            'Read Virtual Host file contents.
            Dim fileLines As String = Nothing
            Using streamReader As New StreamReader(dirHTTPDconf)
                fileLines = streamReader.ReadToEnd()
            End Using
            'Add Local host if it doesnt exits.
            If Not fileLines.Contains("</VirtualHost>") Then
                fileLines += vbNewLine & "<VirtualHost *>" & vbNewLine & "    ServerAdmin admin@localhost.com" & vbNewLine & "    DocumentRoot C:/xampp/htdocs/" & vbNewLine & "    ServerNamelocalhost" & vbNewLine & "</VirtualHost>" & vbNewLine
            End If
            'Add a #newProject line to Virtual Host file. This is to check for writability and for further reference.
            If Not fileLines.Contains("#newProject") Then
                Using streamWriter As New StreamWriter(dirHTTPDconf)
                    streamWriter.Write(fileLines & vbNewLine & "#newProject")
                End Using
            End If
            lblApacheStatus.Text = "Running"
            lblHTTPDStatus.Text = "Modifiable"
        Catch ex As Exception
            updateText(ex.Message & vbNewLine & "Rhythms couldnt find the apache process. Please start apache and run Rhythms with admin rights.", lblError)
        End Try
    End Sub

    'Restart HTTPD
    Sub restartHTTPD()
        Try
        For Each proc As Process In Process.GetProcessesByName("httpd")
            proc.Kill()
        Next
        Dim startInfo As New ProcessStartInfo(dirHTTPDexe)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(startInfo)
        Catch ex As Exception
            updateText(ex.Message & vbNewLine & "We tried restarting Apache and failed. You might need to do it manually.", lblError)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "CMD Acquisition"

    'Setup a new delegate for the command module.
    Delegate Sub SetOutput_Delegate(ByVal [Label] As Label, ByVal [text] As String)

    'Setup the output retrieval thread.
    Private Sub setoutputThreadSafe(ByVal [Label] As Label, ByVal [text] As String)
        If [Label].InvokeRequired Then
            Dim MyDelegate As New SetOutput_Delegate(AddressOf setoutputThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[Label], [text]})
        Else

            [Label].Text = [text]
        End If
    End Sub

    'Time for some music. Acquire command module.
    Private Sub CMDAcquisition(ByVal procPath As String, ByVal procArg As String, ByVal procOutput As Boolean, ByVal outputDest As Object, Optional ByVal procArgSub1 As String = Nothing, Optional ByVal procArgSub2 As String = Nothing, Optional ByVal procArgSub3 As String = Nothing, Optional ByVal procArgSub4 As String = Nothing)
        Try
            'Start a new command process and hide it.
            Dim startInfo As New ProcessStartInfo(procPath)
            startInfo.UseShellExecute = False
            startInfo.WindowStyle = ProcessWindowStyle.Hidden 'Check for errors here.
            startInfo.CreateNoWindow = True
            startInfo.RedirectStandardOutput = True
            startInfo.RedirectStandardInput = True
            startInfo.Arguments = procArg

            'Take control of the command process and begin invoking.
            Dim acqProcess As New Process
            acqProcess.StartInfo = startInfo
            acqProcess.Start()
            acqProcess.StandardInput.WriteLine(procArg)
            If Not procArgSub1 = Nothing Then acqProcess.StandardInput.WriteLine(procArgSub1)
            If Not procArgSub2 = Nothing Then acqProcess.StandardInput.WriteLine(procArgSub2)
            If Not procArgSub3 = Nothing Then acqProcess.StandardInput.WriteLine(procArgSub3)
            If Not procArgSub4 = Nothing Then acqProcess.StandardInput.WriteLine(procArgSub4)
            acqProcess.StandardInput.WriteLine("exit")

            'Send the command responses to the desired display object.
            If procOutput = True Then
                Using standardOutput As StreamReader = acqProcess.StandardOutput
                    Do
                        Application.DoEvents()
                        System.Threading.Thread.Sleep(10)
                        Dim finalOutput = standardOutput.ReadLine
                        If Not standardOutput.ReadLine = Nothing Then

                            If finalOutput.Contains("Microsoft") Then
                                finalOutput = "Laravel Console" & vbNewLine & "Laravel Framework Version 4 2013" & vbNewLine & "Starting Thread..."
                            End If

                            If finalOutput = Nothing Then
                                finalOutput = "Processing..."
                            End If

                            setoutputThreadSafe(outputDest, finalOutput)
                        End If
                    Loop While acqProcess.HasExited = False
                End Using
            End If
        Catch ex As Exception
            setoutputThreadSafe(lblError, ex.Message)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Setup"

    'Create placeholders for project name, port and path.
    Dim projName As String = Nothing
    Dim projPort As String = Nothing
    Dim projDir As String = Nothing

    'Create new project.
    Sub setupProject()
        'Assign the entered info to the variables.
        If Not txtProjName.Text = Nothing Then projName = txtProjName.Text
        If Not txtProjPort.Text = Nothing Then projPort = txtProjPort.Text
        If Not txtProjDir.Text = Nothing Then projDir = txtProjDir.Text
        'Disable the Create button and set it to "Composing"
        btnMain.Enabled = False
        btnMain.Text = "Composing"
        Try
            'Check for duplicate project name in path.
            If File.Exists(projDir & "\" & projName) Then
                'If duplicates exist do not continue.
                updateText("Project already exists in the set directory. Please enter a different name.", lblError)
            Else
                'Begin composing into the given path, and hand over the rest of the process to composer.
                bgsetupWorker.RunWorkerAsync()
            End If
        Catch ex As Exception
            updateText(ex.Message, lblError)
        End Try
    End Sub


    'Setup background worker for the command module.
    Private Sub bgsetupWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgsetupWorker.DoWork
        'Change directory to the setup path.
        ChDir(projDir)
        'Set the worker to begin CMDAcquisition
        CMDAcquisition("cmd.exe", "composer create-project --keep-vcs laravel/laravel", True, lblInstaller)
    End Sub

    'Set events for when the worker is done.
    Private Sub bgsetupWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgsetupWorker.RunWorkerCompleted
        'Add the project to the Host file.
        Try
            'Rename the Laravel folder.
            My.Computer.FileSystem.RenameDirectory(projDir & "\laravel", projName)
            'Read Host file contents.
            Dim fileLines As String = Nothing
            Using streamReader As New StreamReader(dirHOSTfile)
                fileLines = streamReader.ReadToEnd()
                'Replace the #newProject line with the project.
                fileLines = fileLines.Replace("#newProject", "127.0.0.1 " & projName)
            End Using
            'Add the new contents to the Host file.
            Using streamWriter As New StreamWriter(dirHOSTfile)
                streamWriter.Write(fileLines)
            End Using
        Catch ex As Exception
            'On error unset Host path.
            dirHOSTfile = "UNWRITABLE"
            updateText(ex.Message, lblError)
        End Try
        Try
            'Add virtual host.
            Dim stringBuilder As New StringBuilder()
            Dim allLines As String
            Using streamReader As New StreamReader(dirHTTPDconf)
                allLines = streamReader.ReadToEnd()
            End Using
            'Build script.
            stringBuilder.AppendLine(allLines)
            Dim fileLines As String = allLines
            If projPort = Nothing Or projPort = "Port" Then
                fileLines = fileLines.Replace("#newProject", "<VirtualHost *>" & vbNewLine)
            Else
                fileLines = fileLines.Replace("#newProject", "Listen " & projPort & vbNewLine & "<VirtualHost *:" & projPort & ">" & vbNewLine)
            End If
            fileLines = fileLines & "    ServerAdmin admin@" & projName & vbNewLine & "    DocumentRoot " & projDir & "/" & projName & "/public" & vbNewLine & "    ServerName " & projName & vbNewLine & "    ErrorLog " & projDir & "/" & projName & "/error_log" & vbNewLine & "    CustomLog """ & projDir & "/" & projName & "/access_log"" common" & vbNewLine & "    <Directory " & projDir & "/" & projName & "/public>" & vbNewLine & "        AllowOverride All" & vbNewLine & "      Order Allow,Deny" & vbNewLine & "       Allow from all" & vbNewLine & "     Require all granted" & vbNewLine & "    </Directory>" & vbNewLine & "</VirtualHost>" & vbNewLine
            'Write the script to file.
            Using streamWriter As New StreamWriter(dirHTTPDconf)
                streamWriter.Write(fileLines)
            End Using
            'Display Packagist for further upgrade.
            pnlHome.Visible = False
            pnlInstaller.Visible = False
            pnlRepos.Visible = True
            webBrowser.Visible = True

            btnMain.Text = "Load Instruments"
            btnMain.Enabled = True
            Panel10.Visible = True
            Panel9.Visible = True

            stepMain.Text = "Step 2"
            stepSub.Text = "load some repositories and features (optional)"
        Catch ex As Exception
            updateText(ex.Message, lblError)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Web Browser"

    Dim marcusBefore As String
    'Setup IE doc.
    Dim WithEvents IEDoc As System.Windows.Forms.HtmlDocument
    'Setup IE doc for retrieving package data.
    Sub IEDoc_ContextMenuShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.HtmlElementEventArgs) Handles IEDoc.MouseDown
        Dim ElementInfo As String = sender.ActiveElement.tagname
        If ElementInfo = "INPUT" Then
            Dim Marcus As String = sender.ActiveElement.GetAttribute("value").ToString
            If Not Marcus = "" And Marcus.Contains(""": """) And Not Marcus = marcusBefore And Not repoList.Items.Contains(Marcus) Then
                repoList.Items.Add(Marcus)
                marcusBefore = Marcus
                'marcusBefore = Marcus
            End If

        End If
    End Sub
    'Inject script to better show packagist.
    Private Sub webBrowser_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles webBrowser.Navigated
        Dim head As HtmlElement = webBrowser.Document.GetElementsByTagName("head")(0)
        Dim scriptEl As HtmlElement = webBrowser.Document.CreateElement("script")
        Dim element As IHTMLScriptElement = DirectCast(scriptEl.DomElement, IHTMLScriptElement)
        element.text = "function redif(){document.createStyleSheet().addRule('.container div.user','display:none!important;'),document.createStyleSheet().addRule('.container header','display:none!important;'),document.createStyleSheet().addRule('footer','display:none!important;'),document.createStyleSheet().addRule('.container div.flash-message','display:none!important;'),document.createStyleSheet().addRule('.tags','display: none!important;'),document.createStyleSheet().addRule('.main','margin: 0!important;'),document.createStyleSheet().addRule('.main div:first-child','margin-top: 25px!important;'),document.createStyleSheet().addRule('.container div.box','width: auto!important; margin-right:25px !important; margin-left:25px !important;'),document.createStyleSheet().addRule('#search_query_query','width: 98%!important;'),document.createStyleSheet().addRule('.container','padding: 1px!important;background: #3c3c3f url(http://www.99lime.com/site/templates/css/img/gplaypattern.png) repeat !important;'),document.createStyleSheet().addRule('body','background: #3c3c3f url(http://www.99lime.com/site/templates/css/img/gplaypattern.png) repeat !important; overflow-y: hidden;'),document.createStyleSheet().addRule('.source-reference','display: none!important;'),document.createStyleSheet().addRule('.main','background: #3c3c3f url(http://www.99lime.com/site/templates/css/img/gplaypattern.png) repeat !important;'),document.createStyleSheet().addRule('.package .downloads','display:none!important;'),document.createStyleSheet().addRule('ul.packages h1 .metadata','font-size: 10px!important;'),document.createStyleSheet().addRule('ul.packages h1','font-size: 17px!important;')}"
        head.AppendChild(scriptEl)
        webBrowser.Document.InvokeScript("redif")
    End Sub
    'Inject script to better show packagist.
    Private Sub webBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webBrowser.DocumentCompleted
        IEDoc = webBrowser.Document
    End Sub

    'Setup background worker for the command module.
    Private Sub bgaddWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgaddWorker.DoWork
        'Change working path to project path.
        ChDir(projDir & "\" & projName)
        CMDAcquisition("cmd.exe", "composer install", True, lblInstaller)
    End Sub
    'Completion code.
    Private Sub bgaddWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgaddWorker.RunWorkerCompleted
        pnlInstaller.Visible = False
        pnlRepos.Visible = False
        pnlHome.Visible = True
        webBrowser.Visible = False
        Panel9.Visible = False
        Panel10.Visible = False
        lblCMDOutput.Text = "Your project has been set up. Would you like to setup another one?"
        btnUpdate.Enabled = True
        btnMain.Text = "Compose"
        stepMain.Text = "Step 3"
        stepSub.Text = "you can now exit rhythms and enjoy laravel"
    End Sub

    'Set placeholder for composer path.
    Dim compDir As String = Nothing
    'Send to packagist for further upgrading.
    Sub runPackagist()
        Try
            'Set composer path.
            compDir = projDir & "\" & projName & "\composer.json"
            'Check if composer.json exists, if not exit.
            If Not My.Computer.FileSystem.FileExists(compDir) Then
                updateText("Something has gone very bad. Laravel was not installed.", lblError)
                pnlInstaller.Visible = False
                pnlRepos.Visible = False
                pnlHome.Visible = True
                webBrowser.Visible = False
                Panel9.Visible = False
                Panel10.Visible = False
                btnMain.Text = "Compose"
                stepMain.Text = "Step 2"
                stepSub.Text = "we couldnt reach the next step"

            End If
            'Set base JSON string.
            Dim baseJSON As String = """require"": {"
            'Read JSON file.
            Dim JSONReader As String = My.Computer.FileSystem.ReadAllText(compDir)
            Dim newJSON As String = Nothing
            For i As Integer = 0 To repoList.Items.Count - 1
                Dim itemText As String = repoList.Items.Item(i).ToString
                newJSON = newJSON & vbNewLine & "       " & itemText & ","
            Next
            'Update JSON file.
            JSONReader = JSONReader.Replace(baseJSON, (baseJSON & newJSON))
            Using outfiler As New StreamWriter(compDir)
                outfiler.Write(JSONReader)
            End Using
            'Send to composer for further work.
            bgaddWorker.RunWorkerAsync()
        Catch ex As Exception
            updateText(ex.Message, lblError)
        End Try
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Input Handlers"
    'Input validator for Project Name field.
    Private Sub txtProjName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProjName.KeyPress
        Dim allowedChars As String = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890_-." & vbBack
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProjName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjName.Leave
        If txtProjName.Text = Nothing Then txtProjName.Text = "Enter Project Name"
    End Sub

    Private Sub txtProjName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjName.Click
        If txtProjName.Text = "Enter Project Name" Then txtProjName.Text = Nothing
    End Sub

    Private Sub txtProjPort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjPort.Click
        If txtProjPort.Text = "Port" Then txtProjPort.Text = Nothing
    End Sub

    Private Sub txtProjPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjPort.Leave
        If txtProjPort.Text = Nothing Then txtProjPort.Text = "Port"
    End Sub

    Private Sub txtProjPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProjPort.KeyPress
        On Error Resume Next
        Dim allowedChars As String = "0123456789" & vbBack
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        Else
            Dim num As Integer = Convert.ToInt32(txtProjPort.Text)
            If Not num = 0 Then
                If num < 1 OrElse num > 999 Then
                    txtProjPort.Text = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub txtProjDir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjDir.Click
        Using dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = "C:\"
            dialog.Description = "Select Project Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtProjDir.Text = dialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub txtUpdateDir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpdateDir.Click
        Using dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = "C:\"
            dialog.Description = "Select Project Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtUpdateDir.Text = dialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'Delete items from repo list.
    Private Sub repoList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles repoList.KeyDown
        If e.KeyCode = Keys.Delete Then
            repoList.Items.Remove(repoList.SelectedItem)
        End If
    End Sub

    'Send messages to the text containers.
    Sub updateText(ByVal sayMe As String, ByVal inputLabel As Object)
        inputLabel.Text = ""
        For i = 0 To sayMe.Length - 1
            inputLabel.Text += sayMe.Substring(i, 1)
            Application.DoEvents()
        Next
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Update"

    Private Sub bgupdateWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgupdateWorker.DoWork
        'Change directory to the setup path.
        ChDir(txtUpdateDir.Text)
        'Set the worker to begin CMDAcquisition
        ' CMDAcquisition("cmd.exe", "git status -s", True, lblInstaller, "git commit -a 'Changes made on " & Date.Now & "'", "git pull origin master", "composer update")
        CMDAcquisition("cmd.exe", "composer update", True, lblInstaller)
    End Sub

    Private Sub bgupdateWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgupdateWorker.RunWorkerCompleted
        pnlInstaller.Visible = False
        pnlRepos.Visible = False
        pnlHome.Visible = True
        lblBG3.Visible = True
        txtUpdateDir.Visible = True
        btnUpdate.Visible = True
        btnUpdate.Enabled = True
        btnMain.Text = "Compose"
        btnMain.Enabled = True
        lblCMDOutput.Text = "Your project has just been updated. Would you like to update another one or install a fresh copy?"
        updateText("Any errors encountered during runtime will show up here. Click the Titlebar to close this sidebar.", lblError)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Not txtUpdateDir.Text = "Select Project Path" Then
            If Not My.Computer.FileSystem.FileExists(txtUpdateDir.Text & "\composer.json") Or txtUpdateDir.Text = "Select Project Path" Then
                updateText("Rhythms has detected that the current selected rhythm has no harmoney at all. Your project will not be updated. Use a composer for the job.", lblError)
                Exit Sub
            Else
                pnlInstaller.Visible = True
                pnlRepos.Visible = False
                pnlHome.Visible = False
                lblBG3.Visible = True
                txtUpdateDir.Visible = True
                btnUpdate.Visible = True
                btnUpdate.Enabled = False
                btnMain.Text = "Updating..."
                btnMain.Enabled = False
                bgupdateWorker.RunWorkerAsync()
            End If
        Else
            updateText("Please select a project.", lblError)
        End If
        
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "App"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        invokeHOST()
        invokeHTTP()
        invokeHTTPD()
        btnMain.Enabled = True
        btnUpdate.Enabled = True
        pnlRepos.Visible = False
        lblInstaller.Enabled = True
        pnlHome.Visible = True
        webBrowser.Visible = False
        Panel9.Visible = False
        Panel10.Visible = False

        stepMain.Text = "Step 1"
        stepSub.Text = "give your project a name"
        If Not lblError.Text = "Any errors encountered during runtime will show up here. Click the Titlebar to close this sidebar." Then
            lblCMDOutput.Text = "Something is wrong! Check sidebar for further details."
            txtProjName.Enabled = False
            txtProjDir.Enabled = False
            txtProjPort.Enabled = False
            btnMain.Enabled = False
            btnUpdate.Enabled = False
            txtUpdateDir.Enabled = False
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        If btnMain.Text = "Compose" Then
            setupProject()
            pnlHome.Visible = False
            pnlInstaller.Visible = True
            btnUpdate.Enabled = False
        End If
        If btnMain.Text = "Load Instruments" Then

            webBrowser.Visible = True
            Panel9.Visible = True
            Panel10.Visible = True

            pnlHome.Visible = False
            pnlInstaller.Visible = True
            pnlRepos.Visible = False
            btnUpdate.Enabled = False
            runPackagist()
        End If
    End Sub

#End Region

    '///////////////////////////////////////////////////

#Region "Visuals"

    Sub togglePanel()
        If Panel2.Location.X < "300" Then
            Dim x1 As Integer = Panel2.Location.X
            Do While Panel2.Location.X <= "305"
                Panel2.Location = New Point(x1 + 20, Panel2.Location.Y)
                x1 += 20
                Application.DoEvents()
            Loop
            Panel2.Location = New Point(Panel2.Location.X - 5, Panel2.Location.Y)
            Exit Sub
        End If
        If Panel2.Location.X > "-40" Then
            Dim x1 As Integer = Panel2.Location.X
            Do While Panel2.Location.X >= "-45"
                Panel2.Location = New Point(x1 - 1, Panel2.Location.Y)
                x1 -= 1
                Application.DoEvents()
            Loop
            Panel2.Location = New Point(Panel2.Location.X + 5, Panel2.Location.Y)
            Exit Sub
        End If
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub title_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseDown, imgLogo.MouseDown, stepMain.MouseDown, stepSub.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub title_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseMove, imgLogo.MouseMove, stepMain.MouseMove, stepSub.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub title_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseUp, imgLogo.MouseUp, stepMain.MouseUp, stepSub.MouseUp
        drag = False
        togglePanel()
    End Sub


    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.MouseEnter, btnUpdate.MouseEnter
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.MouseLeave, btnMain.MouseLeave
        sender.ForeColor = Color.White
    End Sub

#End Region

End Class
