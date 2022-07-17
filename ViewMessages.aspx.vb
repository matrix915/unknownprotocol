Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Web.Configuration

Partial Class ViewMessages
    Inherits System.Web.UI.Page

    Protected MessagesID As String
    Protected Email As String
    Protected LoggedInEmail As String
    Protected RelationshipEmail As String
    Protected IDMessages As String
    Protected AdvID As String
    Protected AdvMessages As String
    Protected IDExchange As String

    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        If Not Me.IsPostBack Then
            Session("Reset") = True
            Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
            Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
            Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
            ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
        End If

        ID = Request.QueryString("ID")
        'Session("ID") = ID

        MessagesID = Request.QueryString("MessagesID")
        Session("MessagesID") = MessagesID

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email

        'If CType(Session.Item("Email"), String) = "" Then
        'Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx")
        'End If


        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True


        End If

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            AdvID = (Row("ID").ToString())
            LoggedInEmail = (Row("Email").ToString())

        Next

        Connection.Close()

        Dim AdvConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)
        Dim AdvCmd As SqlCommand = New SqlCommand("Select * from tblMessages WHERE Email = '" & Email & "'", AdvConnection)
        Dim AdvDA As SqlDataAdapter = New SqlDataAdapter()

        AdvDA.SelectCommand = AdvCmd
        AdvConnection.Open()
        Dim AdvDS As DataSet = New DataSet()
        AdvDA.Fill(AdvDS, "tblMessages")
        Dim AdvRow As DataRow
        For Each AdvRow In AdvDS.Tables("tblMessages").Rows

            AdvMessages = (AdvRow("Messages").ToString())

        Next

        Connection.Close()

        If AdvMessages = "" Then
            Response.Redirect("http://www.unknownprotocol.us/investors.aspx")
        Else

            Dim MessageMailConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)
            Dim MessageMailCmd As SqlDataAdapter = New SqlDataAdapter("Select * FROM tblMessages  WHERE  Email = '" & LoggedInEmail & "' And FollowUnFollow = '" & "Follow" & "' ORDER BY ID", MessageMailConnection)
            ' WHERE  MessagesID = '" & ID & "' And FollowUnFollow = '" & "Follow" & "' ORDER BY ID"
            Dim MessageMailds As New DataSet()
            MessageMailCmd.Fill(MessageMailds)
            ListView.DataSource = MessageMailds
            ListView.DataBind()
            MessageMailConnection.Close()

        End If

        Dim DeleteMessageConnectionstring = ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString
        Dim DeleteMessageConnection As New SqlConnection(DeleteMessageConnectionstring)
        Dim DeleteMessageConnectionDelete As String = "Delete tblMessages " &
           "WHERE DATEDIFF(day, DateTime, getdate()) > 30 And Email = '" & Email & "' "
        '"WHERE DATEDIFF(day, DateTime, getdate()) > 1 And Email = '" & Email & "' "
        Dim DeleteMessageConnectionCmd As New SqlCommand(DeleteMessageConnectionDelete)
        DeleteMessageConnectionCmd.Connection = DeleteMessageConnection
        DeleteMessageConnection.Open()
        DeleteMessageConnectionCmd.ExecuteNonQuery()
        DeleteMessageConnection.Close()

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
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.briandalesinger.me:8080/logon.aspx", True)

    End Sub

    'ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "close", "window.close();", True)

End Class
