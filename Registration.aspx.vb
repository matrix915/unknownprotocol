Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Web.Security
Imports System.Net.Mail

Partial Class Registration
    Inherits System.Web.UI.Page

    Protected DateTime As String
    Protected savePath As String
    Protected Email As String
    Protected AbsolutePathtoPicture As String
    Protected UNCPath As String
    Protected FileName As String
    Protected Relationship As String
    Protected PSW As String
    Protected Emotions As String
    Protected IDEmail As String
    Protected Firstname As String
    Protected MiddleName As String
    Protected Lastname As String
    Protected EmailID As String
    Protected EmailCheck As String
    Protected IDCheck As String
    Protected EmailReg As String

    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = False
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True

        End If

        ID = Session("ID")

    End Sub
    Sub SaveFile(ByVal file As HttpPostedFile)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        Dim tempfileName As String
        tempfileName = ""
        ' Check to see if a file already exists with the
        ' same name as the file to upload.        
        If (System.IO.File.Exists(pathToCheck)) Then
            Dim counter As Integer = 1
            While (System.IO.File.Exists(pathToCheck))
                ' If a file with this name already exists,
                ' prefix the filename with a number.
                tempfileName = counter.ToString() + fileName
                pathToCheck = savePath + tempfileName
                counter = counter + 1
            End While

            fileName = tempfileName

        End If

        ' Append the name of the file to upload to the path.
        savePath += fileName

        ' Call the SaveAs method to save the uploaded
        ' file to the specified directory.
        FileUpload.SaveAs(savePath)

    End Sub

    Protected Sub Connect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Connect.Click

        'Session("country") = txtCountry
        'Session("state") = txtState
        'Session("city") = txtCity
        'Session("town") = txtTown
        'Session("Email") = txtEmail.Text

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        'Dim tempfileName As String
        'tempfileName = ""
        ' Check to see if a file already exists with the
        ' same name as the file to upload.        
        'If (System.IO.File.Exists(pathToCheck)) Then
        'Dim counter As Integer = 1
        'While (System.IO.File.Exists(pathToCheck))
        ' If a file with this name already exists,
        ' prefix the filename with a number.
        'tempfileName = counter.ToString() + fileName
        'pathToCheck = savePath + tempfileName
        'counter = counter + 1
        'End While

        'fileName = tempfileName

        'End If

        ' Append the name of the file to upload to the path.
        savePath += fileName

        Dim uri As Uri = Context.Request.Url
        Dim uriPath = uri.Scheme & Uri.SchemeDelimiter & uri.Host & ":" & uri.Port & "/postimages/"

        If FileUpload.FileName = "" Then

            savePath = uriPath & "Null.jpg"

        End If


        DateTime = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

        RegisterInsert.InsertParameters.Add("FollowUnFollow", "Unfollow")
        RegisterInsert.InsertParameters.Add("DateTime", DateTime)
        RegisterInsert.InsertParameters.Add("URLOfPicture", savePath + fileName)
        'DataSource.InsertParameters.Add("AbsolutePathToPicture", UNCPath + fileName)

        ' Before attempting to save the file, verify
        ' that the FileUpload control contains a file.
        If (FileUpload.HasFile) Then
            ' Call a helper method routine to save the file.
            SaveFile(FileUpload.PostedFile)

        End If

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select Email from tblRegistered WHERE Email = '" & txtEmail.Text & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            EmailCheck = (Row("Email").ToString())

        Next

        If txtEmail.Text <> EmailCheck Then

            RegisterInsert.Insert()

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            MailMessage.To.Add(New MailAddress(txtEmail.Text))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = "Logon, an account has been created at Unknownprotocol. http://unknownprotocol.me:8080/logon.aspx"
            Dim SmtpClient = New SmtpClient("www.unknownprotocol.us")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000
            SmtpClient.Send(MailMessage)

            Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx")

        ElseIf txtEmail.Text = EmailCheck Then

            lblIDCheck.Text = "Email already in use."

        End If

        Connection.Close()

    End Sub

    Protected Sub Reset_Click(sender As Object, e As System.EventArgs) Handles Reset.Click

        txtPassword.Text = ""

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Response.Redirect("~/logon.aspx")
    End Sub

    Private Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/logon.aspx?ID=" & ID)
                Exit Select
            Case "Contacts"
                Response.Redirect("~/contact.aspx?ID=" & ID)
                Exit Select
        End Select
    End Sub
End Class