Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Configuration
Imports System.Web.Configuration

Partial Class Contact
    Inherits System.Web.UI.Page

    Protected Friend UserID As String
    Protected Friend RedirectID As String
    Protected Friend Email As String
    Protected Friend FirstName1 As String
    Protected Friend MiddleName1 As String
    Protected Friend LastName1 As String
    Protected Friend FirstName2 As String
    Protected Friend MiddleName2 As String
    Protected Friend LastName2 As String
    Protected Friend IDStatus As String
    Protected Friend IDExchange As String

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

        'Email = "briandalesinger@gmail.com"

        Email = CType(Session.Item("Email"), String)


        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        If Not Me.IsPostBack Then
            Session("Reset") = True
            Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
            Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
            Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
            ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
        End If

        ItemsGrid.Attributes.Add("style", "word-break:break-all; word-wrap:break-word")

        'Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        'Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "' ", Connection)
        'Dim DA As SqlDataAdapter = New SqlDataAdapter()

        'DA.SelectCommand = Cmd
        'Connection.Open()
        'Dim DS As DataSet = New DataSet()
        'DA.Fill(DS, "tblRegistered")
        'Dim Row As DataRow
        'For Each Row In DS.Tables("tblRegistered").Rows

        'RedirectID = (Row("ID").ToString())

        'Next

        'Connection.Close()

        ' Load sample data only once, when the page is first loaded.
        If Not IsPostBack Then
            ItemsGrid.DataSource = CreateDataSource()
            ItemsGrid.DataBind()
        End If

    End Sub

    Function CreateDataSource() As ICollection

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE Email <> '" & Email & "' ORDER BY ID", Connection)
        Dim Dt As DataTable = New DataTable()
        Cmd.Fill(Dt)

        Connection.Open()

        ' Populate the table with sample values.
        ItemsGrid.DataSource = Dt
        ItemsGrid.DataBind()

        Dim dv As DataView = New DataView(Dt)
        'Return dv

        Cmd.Dispose()
        Connection.Close()
        Connection.Dispose()
        SqlConnection.ClearAllPools()
        Return dv
    End Function

    Protected Sub ItemsGrid_PageIndexChanged(source As Object, e As DataGridPageChangedEventArgs) Handles ItemsGrid.PageIndexChanged
        ' Set CurrentPageIndex to the page the user clicked.
        ItemsGrid.CurrentPageIndex = e.NewPageIndex

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()
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
            Case "Delete User"
                Response.Redirect("~/deleteuser.aspx?ID=" & IDExchange)
                Exit Select
        End Select
    End Sub

    Protected Sub ItemsGrid_ItemCommand(ByVal source As Object, ByVal e As DataGridCommandEventArgs) Handles ItemsGrid.ItemCommand
        If e.CommandName = "Select" Then

            Dim RelationshipID As Integer = Convert.ToInt32(e.Item.Cells(6).Text)
            Dim RelationshipEmail As String = String.Empty
            Dim FirstName As String = String.Empty
            Dim MiddleName As String = String.Empty
            Dim LastName As String = String.Empty
            Dim URLOfPicture As String = String.Empty
            Dim LoggedInEmail As String = String.Empty
            Dim DateTime As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

            Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & RelationshipID & "'", Connection)
            Dim DA As SqlDataAdapter = New SqlDataAdapter()

            DA.SelectCommand = Cmd
            Connection.Open()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS, "tblRegistered")
            Dim Row As DataRow
            For Each Row In DS.Tables("tblRegistered").Rows

                FirstName2 = (Row("FirstName").ToString())
                MiddleName2 = (Row("MiddleName").ToString())
                LastName2 = (Row("LastName").ToString())
                URLOfPicture = (Row("URLOfPicture").ToString())
                LoggedInEmail = (Row("Email").ToString())
            Next

            Connection.Close()

            Dim StatusConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            Dim StatusCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", StatusConnection)
            Dim StatusDA As SqlDataAdapter = New SqlDataAdapter()

            StatusDA.SelectCommand = StatusCmd
            StatusConnection.Open()
            Dim StatusDS As DataSet = New DataSet()
            StatusDA.Fill(StatusDS, "tblRegistered")

            Dim StatusRow As DataRow
            For Each StatusRow In StatusDS.Tables("tblRegistered").Rows

                UserID = (StatusRow("ID").ToString())
                FirstName1 = (StatusRow("FirstName").ToString())
                MiddleName1 = (StatusRow("MiddleName").ToString())
                LastName1 = (StatusRow("LastName").ToString())
                RelationshipEmail = (StatusRow("Email").ToString())

            Next

            If UserID = RelationshipID Then
                Return
            End If

            Dim drp As DropDownList = CType(e.Item.FindControl("ddlRelationship"), DropDownList)

            Dim relationship As String = "Association"
            If drp.SelectedValue <> "" Then
                relationship = drp.SelectedValue
            End If

            Dim InsertCmd As SqlCommand = New SqlCommand("DELETE FROM tblRegisteredUsers WHERE ID='" & UserID & "' AND RelationshipID='" & RelationshipID & "'; INSERT INTO tblRegisteredUsers (ID,RelationshipID,URLOfPicture,FirstName1,MiddleName1,LastName1,LoggedInEmail,RelationshipEmail,Firstname2,MiddleName2,LastName2, FollowUnfollow,Relationships,Approved,DateTime) " &
        "VALUES ('" & UserID & "', '" & RelationshipID & "','" & URLOfPicture & "','" & FirstName1 & "','" & MiddleName1 & "','" & LastName1 & "','" & LoggedInEmail & "','" & RelationshipEmail & "','" & FirstName2 & "','" & MiddleName2 & "','" & LastName2 & "','Follow','" & relationship & "', '0','" & DateTime & "');", StatusConnection)
            'InsertCmd.Connection = StatusConnection
            InsertCmd.ExecuteNonQuery()

                StatusConnection.Close()

                Dim uri As Uri = Context.Request.Url
                Dim UrlPath As String = uri.Scheme & Uri.SchemeDelimiter & uri.Host & ":" & uri.Port

                Dim InitialMailMessage = New MailMessage()
                InitialMailMessage.IsBodyHtml = True
                InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
                InitialMailMessage.To.Add(New MailAddress(LoggedInEmail))
                InitialMailMessage.Subject = "Unknownprotocol Request"
                InitialMailMessage.Body = "<p>A request has been sent to you for you to be an aquintences.</p>" &
                "<a href='" & UrlPath & "/approveddisapproved.aspx?ID=" & UserID & "&RelationshipID=" & RelationshipID & "&Approve=True'>Approve</a>" &
                "  <a href='" & UrlPath & "/approveddisapproved.aspx?ID=" & UserID & "&RelationshipID=" & RelationshipID & "&Approve=False'>Decline</a>" &
                "  <a href='" & UrlPath & "/default.aspx?ID=" & UserID & "'>View Profile</a>"
                Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
                IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
                IntialSmtpClient.Timeout = 60000

                IntialSmtpClient.Send(InitialMailMessage)

            End If

        'Response.Redirect("~/")

    End Sub
    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("~/logon.aspx", True)

    End Sub


End Class