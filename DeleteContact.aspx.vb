Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Web.Security
Imports System.Net.Mail

Partial Class DeleteContact
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
    Protected IDExchange As String
    Protected FileName As String
    Protected SavePath As String

    Dim WithEvents Menu1 As New Menu

    'Dim WithEvents btnDelete As New Button

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
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

        Dim IDeleteConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim IDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", IDeleteConnection)
        Dim IDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        IDeleteDA.SelectCommand = IDeleteCmd
        IDeleteConnection.Open()
        Dim IDeleteDS As DataSet = New DataSet()
        IDeleteDA.Fill(IDeleteDS, "tblRegistered")
        Dim IDeleteRow As DataRow

        For Each IDeleteRow In IDeleteDS.Tables("tblRegistered").Rows

            DeleteID = (IDeleteRow("ID").ToString())
            EmailDelete = (IDeleteRow("Email").ToString())

        Next

        'If ID = DeleteID Then

        Dim RegistrationDeleteConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim RegistrationDeleteConnection As New SqlConnection(RegistrationDeleteConnectionString)
            Dim RegistrationDelete As String = "Delete tblRegistered " &
        "WHERE Email = '" & Email & "' "
            Dim RegistrationDeleteCommand As New SqlCommand(RegistrationDelete)
            RegistrationDeleteCommand.Connection = RegistrationDeleteConnection
            RegistrationDeleteConnection.Open()
            RegistrationDeleteCommand.ExecuteNonQuery()
            RegistrationDeleteCommand.Connection.Close()

            Dim RegOfUsersConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim RegOfUsersConnection As New SqlConnection(RegOfUsersConnectionString)
            Dim RegOfUsersDelete As String = "Delete tblRegisteredUsers " &
        "WHERE LoggedInEmail = '" & Email & "' "
            Dim RegOfUsersCmd As New SqlCommand(RegOfUsersDelete)
            RegOfUsersCmd.Connection = RegOfUsersConnection
            RegOfUsersConnection.Open()
            RegOfUsersCmd.ExecuteNonQuery()
            RegOfUsersCmd.Connection.Close()

            Dim RelationshipConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim RelationshipConnection As New SqlConnection(RelationshipConnectionString)
            Dim RelationshipDelete As String = "Delete tblUpdateRegistered " &
        "WHERE Email = '" & Email & "' "
            Dim RelationshipCommand As New SqlCommand(RelationshipDelete)
            RelationshipCommand.Connection = RelationshipConnection
            RelationshipConnection.Open()
            RelationshipCommand.ExecuteNonQuery()
            RelationshipCommand.Connection.Close()

            Dim UpdateConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString
            Dim UpdateConnection As New SqlConnection(UpdateConnectionString)
            Dim UpdateDelete As String = "Delete tblMessages " &
        "WHERE Email = '" & Email & "' "
            Dim UpdateCommand As New SqlCommand(UpdateDelete)
            UpdateCommand.Connection = UpdateConnection
            UpdateConnection.Open()
            UpdateCommand.ExecuteNonQuery()
        UpdateCommand.Connection.Close()

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

        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\loading.gif"

        System.IO.File.Delete(savePath)

        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx")

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("~/logon.aspx", True)

    End Sub
    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", UserNameConnection)

        Dim UserNameDA As SqlDataAdapter = New SqlDataAdapter
        UserNameDA.SelectCommand = UserNameCmd
        UserNameConnection.Open()
        Dim UserNameDS As DataSet = New DataSet()
        UserNameDA.Fill(UserNameDS, "tblRegistered")
        Dim UserNameRow As DataRow

        For Each UserNameRow In UserNameDS.Tables("tblRegistered").Rows

            IDExchange = (UserNameRow("ID").ToString())

        Next

        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & IDExchange)
                Exit Select
            Case "Contacts"
                Response.Redirect("~/contact.aspx?ID=" & IDExchange)
                Exit Select
            Case "Delete Contact"
                Response.Redirect("~/deletecontact.aspx?ID=" & IDExchange)
                Exit Select
        End Select
    End Sub
End Class


