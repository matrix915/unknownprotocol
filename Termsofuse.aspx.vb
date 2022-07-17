Imports System.Web.Configuration
Imports System.Data.SqlClient
Imports System.Data

Partial Class termsofuse
    Inherits System.Web.UI.Page

    Protected IDExchange As String
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

        ID = Request.QueryString("ID")

        'ID = Session("ID")

        If Not Me.IsPostBack Then
            Session("Reset") = True
            Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
            Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
            Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
            ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
        End If

    End Sub

    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Session("Email") & "'", UserNameConnection)

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
            Case "Delete User"
                Response.Redirect("~/deleteuser.aspx?ID=" & IDExchange)
                Exit Select
        End Select
    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub

End Class
