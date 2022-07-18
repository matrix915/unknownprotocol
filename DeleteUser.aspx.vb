Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail

Partial Class DeleteUser
    Inherits System.Web.UI.Page

    Protected Email As String
    Protected ConfirmEmail As String
    Protected Password As String
    Protected ConfirmPassword As String
    Protected dbID As String
    Protected dbEmail As String
    Protected dbConfirmEmail As String
    Protected URLOfPicture As String
    Protected FindFile As String
    Protected DeleteID As String
    Protected EmailDelete As String
    Dim URL As String

    Dim WithEvents Menu1 As New Menu

    Public CONN_STRING As String = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = False
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = False
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True


        End If

        ID = Session("ID")

        Email = CType(Session.Item("Email"), String)

    End Sub

    Protected Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click

        txtEmail.Text = ""

    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As System.EventArgs) Handles btnDelete.Click

        Email = txtEmail.Text

        Dim conn As SqlConnection = New SqlConnection(CONN_STRING)
        Dim cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", conn)
        Dim da As SqlDataAdapter = New SqlDataAdapter()

        da.SelectCommand = cmd
        conn.Open()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "tblRegistered")

        If ds.Tables("tblRegistered") IsNot Nothing AndAlso ds.Tables("tblRegistered").Rows.Count > 0 Then
            DeleteID = ds.Tables("tblRegistered").Rows(0)("ID").ToString()
            EmailDelete = ds.Tables("tblRegistered").Rows(0)("Email").ToString()
            URLOfPicture = ds.Tables("tblRegistered").Rows(0)("UrlOfPicture")
        End If

        If URLOfPicture IsNot Nothing Then
            URL = Server.MapPath("~/" + URLOfPicture.Substring(URLOfPicture.IndexOf("/postimages") + 1))
        End If

        If ID = DeleteID And Email = EmailDelete And URL <> "" Then
            Dim RegistrationDeleteConnectionString = CONN_STRING
            Dim RegistrationDeleteConnection As New SqlConnection(RegistrationDeleteConnectionString)
            Dim RegistrationDelete As String = "Delete tblRegistered WHERE Email = '" & Email & "' "
            Dim RegistrationDeleteCommand As New SqlCommand(RegistrationDelete)
            RegistrationDeleteCommand.Connection = RegistrationDeleteConnection
            RegistrationDeleteConnection.Open()
            RegistrationDeleteCommand.ExecuteNonQuery()
            RegistrationDeleteCommand.Connection.Close()

            If System.IO.File.Exists(URL) Then
                System.IO.File.Delete(URL)
            End If

            Dim RegOfUsersConnectionString = CONN_STRING
            Dim RegOfUsersConnection As New SqlConnection(RegOfUsersConnectionString)
            Dim RegOfUsersDelete As String = "Delete tblRegisteredUsers WHERE LoggedInEmail = '" & Email & "' "
            Dim RegOfUsersCmd As New SqlCommand(RegOfUsersDelete)
            RegOfUsersCmd.Connection = RegOfUsersConnection
            RegOfUsersConnection.Open()
            RegOfUsersCmd.ExecuteNonQuery()
            RegOfUsersCmd.Connection.Close()

            Dim UserRegConnectionString = CONN_STRING
            Dim UserRegConnection As New SqlConnection(UserRegConnectionString)
            Dim UserRegDelete As String = "Delete tblUsersRegistered WHERE LoggedInEmail = '" & Email & "' "
            Dim UserRegCommand As New SqlCommand(UserRegDelete)
            UserRegCommand.Connection = UserRegConnection
            UserRegConnection.Open()
            UserRegCommand.ExecuteNonQuery()
            UserRegCommand.Connection.Close()

            Dim RelationshipConnectionString = CONN_STRING
            Dim RelationshipConnection As New SqlConnection(RelationshipConnectionString)
            Dim RelationshipDelete As String = "Delete tblUpdateRegistered WHERE Email = '" & Email & "' "
            Dim RelationshipCommand As New SqlCommand(RelationshipDelete)
            RelationshipCommand.Connection = RelationshipConnection
            RelationshipConnection.Open()
            RelationshipCommand.ExecuteNonQuery()
            RelationshipCommand.Connection.Close()

            'Dim UpdateConnectionString = CONN_STRING
            'Dim UpdateConnection As New SqlConnection(UpdateConnectionString)
            'Dim UpdateDelete As String = "Delete tblMessages WHERE Email = '" & Email & "' "
            'Dim UpdateCommand As New SqlCommand(UpdateDelete)
            'UpdateCommand.Connection = UpdateConnection
            'UpdateConnection.Open()
            'UpdateCommand.ExecuteNonQuery()
            'UpdateCommand.Connection.Close()

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            MailMessage.To.Add(New MailAddress(Email))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = "http://www.unknownprotocol.us:8080/registration.aspx" & " " & "to register again."
            Dim SmtpClient = New SmtpClient("www.briandalesinger.me")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000
            SmtpClient.Send(MailMessage)

            '' Specify the path to save the uploaded file to.
            'Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

            '' Get the name of the file to upload.
            'Dim fileName As String = String.Empty 'FileUpload.FileName

            '' Create the path and file name to check for duplicates.
            'Dim pathToCheck As String = savePath + fileName

            '' Create a temporary file name to use for checking duplicates.
            'Dim tempfileName As String
            'tempfileName = ""
            '' Check to see if a file already exists with the
            '' same name as the file to upload.        
            'If (System.IO.File.Exists(pathToCheck)) Then
            '    Dim counter As Integer = 1
            '    While (System.IO.File.Exists(pathToCheck))
            '        ' If a file with this name already exists,
            '        ' prefix the filename with a number.
            '        tempfileName = counter.ToString() + fileName
            '        pathToCheck = savePath + tempfileName
            '        counter = counter + 1
            '    End While

            '    fileName = tempfileName


            'End If

            Response.Redirect("~/logon.aspx")


        End If

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("~/logon.aspx", True)

    End Sub


    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Select Case e.Item.Value
            Case "Update User"
                Response.Redirect("~/updatecontact.aspx?ID=" & ID)
                Exit Select
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & ID)
                Exit Select
            Case "Contacts"
                Response.Redirect("~/status.aspx?ID=" & ID)
                Exit Select
        End Select
    End Sub
End Class


