Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail

Partial Class ForgotUsername
    Inherits System.Web.UI.Page


    Protected Mail As String
    Protected Email As String
    Protected Password As String
    Protected UserName As String
    Protected IDUsername As String
    Protected EmailMessage As String
    Protected IDExchange As String
    Protected Forgot As String

    Dim WithEvents Menu1 As New Menu

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

        Email = CType(Session.Item("Email"), String)
        'Session("Email") = Email

        ID = Request.QueryString("ID")

        Forgot = txtEmail.Text

    End Sub

    Protected Sub btnGetUsername_Click(sender As Object, e As System.EventArgs) Handles btnGetUsername.Click

        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Forgot & "'", UserNameConnection)

        Dim UserNameDA As SqlDataAdapter = New SqlDataAdapter
        UserNameDA.SelectCommand = UserNameCmd
        UserNameConnection.Open()
        Dim UserNameDS As DataSet = New DataSet()
        UserNameDA.Fill(UserNameDS, "tblRegistered")
        Dim UserNameRow As DataRow

        For Each UserNameRow In UserNameDS.Tables("tblRegistered").Rows

            IDUsername = (UserNameRow("ID").ToString())
            Email = (UserNameRow("Email").ToString())
            'UserName = (UserNameRow("Email").ToString())
            Password = (UserNameRow("Password").ToString())

        Next

        Dim InitialMailMessage = New MailMessage()
        InitialMailMessage.IsBodyHtml = False
        InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        InitialMailMessage.To.Add(New MailAddress(Email))
        InitialMailMessage.Subject = "Unknownprotocol Request"
        InitialMailMessage.Body = "You username is:" & Email
        Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
        IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
        IntialSmtpClient.Timeout = 60000
        IntialSmtpClient.Send(InitialMailMessage)

        UserNameConnection.Close()

        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub
    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE EMail = '" & Email & "'", UserNameConnection)

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
    Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtEmail.Text = ""

    End Sub
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub


End Class