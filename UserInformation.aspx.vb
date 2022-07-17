Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Web.Configuration


Partial Class UserInformation
    Inherits System.Web.UI.Page

    Protected Friend IDExchange As String
    Protected Friend Email As String
    Protected DeleteID As String
    Protected EmailDelete As String
    Protected IDEmail As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Email = CType(Session.Item("Email"), String)

        'Session("Email") = Email

        ID = Request.QueryString("ID")

        'Session("ID") = ID

        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        If Not Me.IsPostBack Then
            Session("Reset") = True
            Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
            Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
            Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
            ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
        End If

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * FROM tblUpdateRegistered WHERE RelationshipID= '" & ID & "' Order By ID ", Connection)
        Dim ds As New DataSet()
        Cmd.Fill(ds)
        ListView.DataSource = ds
        ListView.DataBind()
        Connection.Close()

        Dim EmailConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim EmailCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", EmailConnection)
        Dim EmailDA As SqlDataAdapter = New SqlDataAdapter()

        EmailDA.SelectCommand = EmailCmd
        Connection.Open()
        Dim EmailDS As DataSet = New DataSet()
        EmailDA.Fill(ds, "tblRegistered")
        Dim EmailRow As DataRow

        For Each EmailRow In ds.Tables("tblRegistered").Rows


            IDEmail = (EmailRow("Email").ToString())

        Next

        SqlDataSource1.UpdateParameters.Add("Email", IDEmail)
        SqlDataSource1.Update()

        Connection.Close()

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

    End Sub
    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
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

    Protected Sub btnDUI_Click(sender As Object, e As System.EventArgs) Handles btnDUI.Click


        Dim RelationshipConnectionString = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
        Dim RelationshipConnection As New SqlConnection(RelationshipConnectionString)
        Dim RelationshipDelete As String = "Delete tblUpdateRegistered " &
       "WHERE RelationshipID = '" & ID & "' And Email = '" & Email & "'"
        Dim RelationshipCommand As New SqlCommand(RelationshipDelete)
        RelationshipCommand.Connection = RelationshipConnection
        RelationshipConnection.Open()
        RelationshipCommand.ExecuteNonQuery()
        RelationshipCommand.Connection.Close()

        Response.Redirect("http://www.unknownprotocol.us:8080/default.aspx?ID=" & ID)

    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As System.EventArgs) Handles btnUpdate.Click
        Response.Redirect("http://www.unknownprotocol.us:8080/UpdateContact.aspx?ID=" & ID)
    End Sub

    Protected Sub btnGoBack_Click(sender As Object, e As System.EventArgs) Handles btnGoBack.Click
        Response.Redirect("http://www.unknownprotocol.us:8080/default.aspx?ID=" & ID)
    End Sub
    Protected Sub btnCreateInfo_Click(sender As Object, e As EventArgs) Handles btnCreateInfo.Click
        Response.Redirect("http://www.unknownprotocol.us:8080/CreateContact.aspx?ID=" & ID)
    End Sub
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx?ID=" & ID, True)
    End Sub
End Class

