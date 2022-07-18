Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail

Partial Class ChangePassword
    Inherits System.Web.UI.Page

    Protected RelationshipID As String
    Protected Email As String
    Protected Mail As String
    Protected Password As String
    Protected PasswordID As String
    Protected NewPassword As String
    Protected ConfirmNewPassword As String
    Protected PasswordEmail As String
    Protected IDExchange As String

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

        Email = CType(Session.Item("Email"), String)

        Email = txtEmail.Text
        NewPassword = txtNewPassword.Text
        ConfirmNewPassword = txtConfirmNewPassword.Text

    End Sub

    Protected Sub btnChangePassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click

        Dim PasswordConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered  WHERE Email = '" & Email & "' ", PasswordConnection)

        Dim PasswordDA As SqlDataAdapter = New SqlDataAdapter
        PasswordDA.SelectCommand = RegistrationCmd
        PasswordConnection.Open()
        Dim PasswordDS As DataSet = New DataSet()
        PasswordDA.Fill(PasswordDS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In PasswordDS.Tables("tblRegistered").Rows

            'PasswordEmail = (Row("Email").ToString())
            PasswordID = (Row("ID").ToString())

            'If txtEmail.Text = PasswordEmail Then

            Dim myConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim myConnection As New SqlConnection(myConnectionString)
            Dim myInsertQuery As String = "UPDATE tblRegistered " &
                        "SET Password = '" & Replace((NewPassword), "'", "''") & "' WHERE ID = '" & PasswordID & "' "
            Dim myCommand As New SqlCommand(myInsertQuery)
            myCommand.Connection = myConnection
            myConnection.Open()
            myCommand.ExecuteNonQuery()
            myCommand.Connection.Close()

            'End If
        Next

        PasswordConnection.Close()

        Dim MailMessage = New MailMessage()
        MailMessage.IsBodyHtml = False
        MailMessage.From = New MailAddress("briandalesinger@gmail.com")
        MailMessage.To.Add(New MailAddress(Email))
        MailMessage.Subject = "Unknownprotocol"
        MailMessage.Body = "Your password has changed, logon at http://www.unknownprotocol.us:8080/logon.aspx"
        Dim SmtpClient = New SmtpClient("www.briandalesinger.me")
        SmtpClient.ServicePoint.MaxIdleTime = 60000
        SmtpClient.Timeout = 60000
        SmtpClient.Send(MailMessage)

        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub
    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", UserNameConnection)

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

    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtEmail.Text = ""
        txtNewPassword.Text = ""
        txtConfirmNewPassword.Text = ""

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("~/logon.aspx", True)

    End Sub
End Class
