Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail

Partial Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Email As String
    Protected Password As String
    Protected ForgotEmail As String
    Protected IDSession As String

    Dim WithEvents btnSubmit As New Button
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


        ID = Request.QueryString("ID")
        'Session("ID") = ID

        Email = txtEmail.Text

    End Sub

    Protected Sub btnGetPassword_Click(sender As Object, e As System.EventArgs) Handles btnGetPassword.Click

        Dim PwdConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim PwdCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", PwdConnection)

        Dim PwdDA As SqlDataAdapter = New SqlDataAdapter
        PwdDA.SelectCommand = PwdCmd
        PwdConnection.Open()
        Dim PwdDS As DataSet = New DataSet()
        PwdDA.Fill(PwdDS, "tblRegistered")
        Dim PwdRow As DataRow

        For Each PwdRow In PwdDS.Tables("tblRegistered").Rows

            'ForgotEmail = (PwdRow("Email").ToString())
            Password = (PwdRow("Password").ToString())

        Next

        Dim MailMessage = New MailMessage()
        MailMessage.IsBodyHtml = False
        MailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        MailMessage.To.Add(New MailAddress(Email))
        MailMessage.Subject = "Change Password"
        MailMessage.Body = "http://www.unknownprotocol.us:8080/ChangePassword.aspx"
        Dim SmtpClient = New SmtpClient("www.briandalesinger.me")
        SmtpClient.ServicePoint.MaxIdleTime = 60000
        SmtpClient.Timeout = 60000
        SmtpClient.Send(MailMessage)

        PwdConnection.Close()

        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub

    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtEmail.Text = ""

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080", True)

    End Sub

    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Contacts"
                Response.Redirect("~/contact.aspx?ID=" & Session("ID"))
                Exit Select
        End Select
    End Sub

End Class