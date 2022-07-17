Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Web.Configuration


Partial Class _Default

    Inherits System.Web.UI.Page

    Protected strExpression As String
    Protected Firstname As String
    Protected Middlename As String
    Protected LastName As String
    Protected FirstName1 As String
    Protected MiddleName1 As String
    Protected LastName1 As String
    Protected FirstName2 As String
    Protected MiddleName2 As String
    Protected LastName2 As String
    Protected FirstNameA As String
    Protected MiddleNameA As String
    Protected LastNameA As String
    Protected FirstNameB As String
    Protected MiddleNameB As String
    Protected LastNameB As String
    Protected FirstNameC As String
    Protected MiddleNameC As String
    Protected LastNameC As String
    Protected FirstNameD As String
    Protected MiddleNameD As String
    Protected LastNameD As String
    Protected FName As String
    Protected MName As String
    Protected LName As String
    Protected GlobalChangeID As String
    Protected Relationships As String
    Protected dbPicture As String
    Protected EmailID As String
    Protected Email As String
    Protected Picture As String
    Protected DateTime As String
    Protected Password As String
    Protected fEmail As String
    Protected dbEmail As String
    Protected LoggedIn As String
    Protected Family As String
    Protected Friends As String
    Protected IDSS As String
    Protected RedirectID As String
    Protected LoggedInID As String
    Protected LoggedInName As String
    Protected RelationshipEmail As String
    Protected RelationshipIDS As String
    Protected RelationshipID As String
    Protected tblregisteredEmail As String
    Protected RIDS As String
    Protected dbIDS As String
    Protected IDSLoggedIn As String
    Protected Null As String
    Protected Approved As String
    Protected Pending As String
    Protected IDSRelationship As String
    Protected RelationshipLoggedIn As String
    Protected RelationshipLoggedInEmail As String
    Protected LoggedInEmail As String
    Protected Approve As String
    Protected Aquintence As String
    Protected IDSNumber As String
    Protected PostingID As String
    Protected Delete As String
    Protected Disapprove As String
    Protected AddFriend As String
    Protected AddFamily As String
    Protected FriendsID As String
    Protected IDLoggedInEmail As String
    Protected IDRelationship As String
    Protected IDisapproved As String
    Protected OneTimeAdded As String
    Protected AlreadyAddedEmail As String
    Protected Post As String
    Protected ChatID As String
    Protected ChatEmail As String
    Protected EmailNotification As String
    Protected RequestID As String
    Protected PicturePath As String
    Protected AddNonBiologicalFamily As String
    Protected NonBiologicalFamily As String
    Protected Know As String
    Protected AddAquintence As String
    Protected AddKnowOf As String
    'Protected URLOfPicture As String
    Protected InTheKnow As String
    Protected URLOfPicture As String
    Protected IDPictureMove As String
    Protected AddID As Integer
    Protected PicMoveEmail As String
    Protected IDDeleted As String
    Protected IDDeletedEmail As String
    Protected YouDisapproved As String
    Protected YouDeleted As String
    Protected SaveNoFilePath As String
    Protected URL As String
    Protected URLOP As String
    Protected ImagePath As String
    Protected AbsolutePathtoPicture As String
    Protected savepath As String
    Protected pathtocheck As String
    Protected d As String
    Protected MoveIDSS As String
    Protected IDeleteEmail As String
    Protected YouDeleteEmail As String
    Protected IDSSRequestNumber As String
    Protected Association As String
    Protected AddIDSS As String
    Protected IDHome As String
    Protected REmail As String
    Protected ApprovedEmail As String
    Protected Gender As String
    Protected LoggedInMove As Integer
    Protected DateingVerificationEmail As String
    Protected FN As String
    Protected MN As String
    Protected LN As String
    Protected IDNumber As Integer
    Protected NameID As Integer
    Protected Status As String
    Protected PostID As String
    Protected IDeletedEmail As String
    Protected IDSSID As String
    Protected IDelete As String
    Protected YouDelete As String
    Protected EmailCheck As String
    Protected ApproveDisapprove As String
    Protected ADD As String
    Protected IDStatus As String

    ' Dim WithEvents btnChat As New Button

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ADD = String.Empty

        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        If Not Me.IsPostBack Then
            Session("Reset") = True
            Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
            Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
            Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
            ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
        End If

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True

        End If

        Email = CType(Session.Item("Email"), String)
        'Session("Email") = Email

        ID = Request.QueryString("ID")

        'Session("ID") = ID

        'ID = CType(Session.Item("ID"), String)
        'Session("ID") = ID

        IDSS = Request.QueryString("IDSS")
        'Session("IDSS") = IDSS

        IDisapproved = Request.QueryString("IDisapproved")

        Session("IDisapproved") = IDisapproved

        YouDisapproved = Request.QueryString("YouDisapproved")

        Session("YouDisapproved") = YouDisapproved

        DateTime = Date.Now

        Prototype.Attributes.Add("style", "word-break:break-all; word-wrap:break-word")

        'Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        'Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", Connection)
        'Dim DA As SqlDataAdapter = New SqlDataAdapter()

        'DA.SelectCommand = Cmd
        'Connection.Open()
        'Dim DS As DataSet = New DataSet()
        'DA.Fill(DS, "tblRegistered")
        'Dim Row As DataRow
        'For Each Row In DS.Tables("tblRegistered").Rows

        'ID = (Row("ID").ToString())
        'EmailCheck = (Row("Email").ToString())

        'Next

        labelID.Text = ID

        'Cmd.Dispose()
        'Connection.Close()
        'Connection.Dispose()
        'SqlConnection.ClearAllPools()

        Dim StatusConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim StatusCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", StatusConnection)
        Dim StatusDA As SqlDataAdapter = New SqlDataAdapter()

        StatusDA.SelectCommand = StatusCmd
        StatusConnection.Open()
        Dim StatusDS As DataSet = New DataSet()
        StatusDA.Fill(StatusDS, "tblRegistered")
        Dim StatusRow As DataRow
        For Each StatusRow In StatusDS.Tables("tblRegistered").Rows

            RelationshipID = (StatusRow("ID").ToString())
            FirstName1 = (StatusRow("FirstName").ToString())
            MiddleName1 = (StatusRow("MiddleName").ToString())
            LastName1 = (StatusRow("LastName").ToString())
            RelationshipEmail = (StatusRow("Email").ToString())

        Next

        StatusConnection.Close()


        Dim FMLConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim FMLCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & Session("ID") & "'", FMLConnection)
        Dim FMLDA As SqlDataAdapter = New SqlDataAdapter()

        FMLDA.SelectCommand = FMLCmd
        FMLConnection.Open()
        Dim FMLDS As DataSet = New DataSet()
        FMLDA.Fill(FMLDS, "tblRegistered")
        Dim FMLRow As DataRow
        For Each FMLRow In FMLDS.Tables("tblRegistered").Rows

            RelationshipID = (FMLRow("ID").ToString())
            FirstName1 = (FMLRow("FirstName").ToString())
            MiddleName1 = (FMLRow("MiddleName").ToString())
            LastName1 = (FMLRow("LastName").ToString())
            RelationshipEmail = (FMLRow("Email").ToString())

        Next

        StatusConnection.Close()


        Dim IDeleteConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim IDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE IDSS = '" & IDSS & "'", IDeleteConnection)
        Dim IDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        IDeleteDA.SelectCommand = IDeleteCmd
        IDeleteConnection.Open()
        Dim IDeleteDS As DataSet = New DataSet()
        IDeleteDA.Fill(IDeleteDS, "tblRegisteredUsers")
        Dim IDeleteRow As DataRow

        For Each IDeleteRow In IDeleteDS.Tables("tblRegisteredUsers").Rows

            IDelete = (IDeleteRow("ID").ToString())
            RelationshipEmail = (IDeleteRow("RelationshipEmail").ToString())
            FirstName2 = (IDeleteRow("FirstName2").ToString())
            MiddleName2 = (IDeleteRow("MiddleName2").ToString())
            LastName2 = (IDeleteRow("LastName2").ToString())
            LoggedInEmail = (IDeleteRow("LoggedInEmail").ToString())
            Relationships = (IDeleteRow("Relationships").ToString())
            URLOfPicture = (IDeleteRow("URLOfPicture").ToString())

        Next

        If IDisapproved = "Deleted" Then

            SqlDataSource6.InsertParameters.Add("ID", ID)
            SqlDataSource6.InsertParameters.Add("RelationshipID", RelationshipID)
            SqlDataSource6.InsertParameters.Add("URLOfPicture", URLOfPicture)
            SqlDataSource6.InsertParameters.Add("FirstName1", FirstName1)
            SqlDataSource6.InsertParameters.Add("MiddleName1", MiddleName1)
            SqlDataSource6.InsertParameters.Add("LastName1", LastName1)
            SqlDataSource6.InsertParameters.Add("FirstName2", FirstName2)
            SqlDataSource6.InsertParameters.Add("MiddleName2", MiddleName2)
            SqlDataSource6.InsertParameters.Add("LastName2", LastName2)
            SqlDataSource6.InsertParameters.Add("LoggedInEmail", Email)
            SqlDataSource6.InsertParameters.Add("RelationshipEmail", LoggedInEmail)
            SqlDataSource6.InsertParameters.Add("Ideleted", "IDeleted")
            SqlDataSource6.InsertParameters.Add("Relationships", Relationships)
            SqlDataSource6.InsertParameters.Add("FollowUnFollow", "Follow")
            SqlDataSource6.InsertParameters.Add("DateTime", DateTime)
            SqlDataSource6.Insert()

            Dim CommandDeleteConnections = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim CommandDeleteConnection As New SqlConnection(CommandDeleteConnections)
            Dim CommandDeleteDelete As String = "Delete tblRegisteredUsers " &
                        "WHERE IDSS= '" & IDSS & "' And RelationshipEmail = '" & Email & "'"
            Dim CommandDeleteCmd As New SqlCommand(CommandDeleteDelete)
            CommandDeleteCmd.Connection = CommandDeleteConnection

            CommandDeleteConnection.Open()
            CommandDeleteCmd.ExecuteNonQuery()
            CommandDeleteConnection.Close()

            CommandDeleteConnection.Close()

            IDeleteConnection.Close()

        End If

        IDeleteConnection.Close()
        IDeleteConnection.Dispose()
        IDeleteCmd.Dispose()
        SqlConnection.ClearAllPools()


        Dim YouDeleteConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim YouDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE IDSS = '" & IDSS & "'", YouDeleteConnection)
        Dim YouDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        YouDeleteDA.SelectCommand = YouDeleteCmd
        YouDeleteConnection.Open()
        Dim YouDeleteDS As DataSet = New DataSet()
        YouDeleteDA.Fill(YouDeleteDS, "tblRegisteredUsers")
        Dim YouDeleteRow As DataRow

        For Each YouDeleteRow In YouDeleteDS.Tables("tblRegisteredUsers").Rows

            FirstName1 = (YouDeleteRow("FirstName1").ToString())
            MiddleName1 = (YouDeleteRow("MiddleName1").ToString())
            LastName1 = (YouDeleteRow("LastName1").ToString())
            Relationships = (YouDeleteRow("Relationships").ToString())
            LoggedInEmail = (YouDeleteRow("LoggedInEmail").ToString())
            RelationshipEmail = (YouDeleteRow("RelationshipEmail").ToString())
            URLOfPicture = (YouDeleteRow("URLOfPicture").ToString())

        Next

        YouDeleteConnection.Close()

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & Session("ID") & "'", Connection)
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

        Next

        Connection.Close()

        If YouDisapproved = "Deleted" Then

            SqlDataSource8.InsertParameters.Add("ID", ID)
            SqlDataSource8.InsertParameters.Add("RelationshipID", RelationshipID)
            SqlDataSource8.InsertParameters.Add("URLOfPicture", URLOfPicture)
            SqlDataSource8.InsertParameters.Add("FirstName1", FirstName2)
            SqlDataSource8.InsertParameters.Add("MiddleName1", MiddleName2)
            SqlDataSource8.InsertParameters.Add("LastName1", LastName2)
            SqlDataSource8.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource8.InsertParameters.Add("FirstName2", FirstName1)
            SqlDataSource8.InsertParameters.Add("MiddleName2", MiddleName1)
            SqlDataSource8.InsertParameters.Add("LastName2", LastName1)
            SqlDataSource8.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource8.InsertParameters.Add("Youdeleted", "YouDeleted")
            SqlDataSource8.InsertParameters.Add("Relationships", "Association")
            SqlDataSource8.InsertParameters.Add("FollowUnFollow", "Follow")
            SqlDataSource8.InsertParameters.Add("DateTime", DateTime)
            SqlDataSource8.Insert()

            Dim YouCommandDeleteConnections = ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString
            Dim YouCommandDeleteConnection As New SqlConnection(YouCommandDeleteConnections)
            Dim YouCommandDeleteDelete As String = "Delete tblRegisteredUsers " &
                        "WHERE IDSS= '" & IDSS & "' And LoggedInEmail = '" & Email & "'"
            Dim YouCommandDeleteCmd As New SqlCommand(YouCommandDeleteDelete)
            YouCommandDeleteCmd.Connection = YouCommandDeleteConnection
            YouCommandDeleteConnection.Open()
            YouCommandDeleteCmd.ExecuteNonQuery()
            YouCommandDeleteConnection.Close()

        End If

        YouDeleteConnection.Close()

        AssociationListView.DataBind()
        TheListRelationshipListView.DataBind()
        KnowsRelationshipListView.DataBind()
        KnowsOfRelationshipListView.DataBind()
        AquintenceRelationshipListView.DataBind()
        FriendsRelationshipListView.DataBind()
        WantToDateRelationshipListView.DataBind()
        DateingRelationshipListView.DataBind()
        FiancesRelationshipListView.DataBind()
        FianceesRelationshipListView.DataBind()
        MarriedRelationshipListView.DataBind()
        NonBiologicaFamilyRelationshipListView.DataBind()
        FamilyRelationshipListView.DataBind()
        FamilySecretRelationshipListView.DataBind()

        'Dim NameDeleteConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        'Dim NameDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE ID = '" & ID & "'", NameDeleteConnection)
        'Dim NameDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        'NameDeleteDA.SelectCommand = NameDeleteCmd
        'NameDeleteConnection.Open()
        'Dim NameDeleteDS As DataSet = New DataSet()
        'NameDeleteDA.Fill(NameDeleteDS, "tblRegisteredUsers")
        'Dim NameDeleteRow As DataRow

        'For Each NameDeleteRow In NameDeleteDS.Tables("tblRegisteredUsers").Rows

        'FirstName1 = NameDeleteRow("FirstName").ToString()
        'MiddleName1 = NameDeleteRow("MiddleName").ToString()
        'LastName1 = NameDeleteRow("LastName1").ToString()

        'SqlDataSource6.InsertParameters.Add("FirstName1", FirstName1)
        'SqlDataSource6.InsertParameters.Add("MiddleName1", MiddleName1)
        'SqlDataSource6.InsertParameters.Add("LastName1", LastName1)
        'SqlDataSource6.Insert()
        'Next
        'End If

        'Dim StatusCheck As SqlConnection = New SqlConnection("Server=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;Database=Registration;uid=sa;password=1A@brian@A1;")
        'Dim StatusCheckCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers Where ID = '" & ID & "'", StatusCheck)
        'Dim StatusCheckDA As SqlDataAdapter = New SqlDataAdapter()

        'StatusCheckDA.SelectCommand = StatusCheckCmd
        'StatusCheck.Open()
        'Dim StatusCheckDS As DataSet = New DataSet()
        'StatusCheckDA.Fill(StatusCheckDS, "tblRegisteredUsers")
        'Dim StatusCheckRow As DataRow

        'StatusCheck.Close()

        'For Each StatusCheckRow In StatusCheckDS.Tables("tblRegisteredUsers").Rows

        'FirstName1 = (StatusCheckRow("FirstName").ToString())
        'MiddleName1 = (StatusCheckRow("MiddleName").ToString())
        'LastName1 = (StatusCheckRow("LastName1").ToString())

        'End If
        'Next
        'End If

        'Response.Redirect("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID)

        'If Status = "" Then
        'Response.Redirect("Association.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Select" Then
        'Response.Redirect("Association.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Association" Then
        'Response.Redirect("Association.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "TheList" Then
        'Response.Redirect("TheList.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "InTheKnow" Then
        'Response.Redirect("InTheKnow.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Knows" Then
        'Response.Redirect("Knows.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "KnowsOf" Then
        'Response.Redirect("KnowsOf.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Aquintences" Then
        'Response.Redirect("Aquintences.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Friends" Then
        'Response.Redirect("Friends.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "WantToDate" Then
        'Response.Redirect("WantToDate.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Dateing" Then
        'Response.Redirect("Dateing.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Fiances" Then
        'Response.Redirect("Fiances.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Fiancees" Then
        'Response.Redirect("Fiancees.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Married" Then
        'Response.Redirect("Married.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Divorce" Then
        'Response.Redirect("Divorce.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Divorcee" Then
        'Response.Redirect("Divorcee.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "NonBiologicalFamily" Then
        'Response.Redirect("NonBiologicalFamily.aspx?ID=" & RelationshipID)
        'End If

        'If Status = "Family" Then
        'Response.Redirect("Family.aspx?ID=" & RelationshipID)
        'End If

    End Sub

    Protected Sub Connect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Connect.Click

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows
            ID = (Row("ID").ToString())
            FirstNameB = (Row("FirstName").ToString())
            MiddleNameB = (Row("MiddleName").ToString())
            LastNameB = (Row("LastName").ToString())
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


            RelationshipID = (StatusRow("ID").ToString())
            FirstNameA = (StatusRow("FirstName").ToString())
            MiddleNameA = (StatusRow("MiddleName").ToString())
            LastNameA = (StatusRow("LastName").ToString())
            RelationshipEmail = (StatusRow("Email").ToString())

        Next

        StatusConnection.Close()

        Dim AddDAConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim AddCmd As SqlCommand = New SqlCommand("Select * from tblregisteredUsers WHERE ID='" & RelationshipID & "' AND RelationshipID='" & ID & "'", AddDAConnection)

        Dim AddDA As SqlDataAdapter = New SqlDataAdapter
        AddDA.SelectCommand = AddCmd
        AddDAConnection.Open()
        Dim AddDS As DataSet = New DataSet()
        AddDA.Fill(AddDS, "tblregisteredUsers")
        Dim AddRow As DataRow

        For Each AddRow In AddDS.Tables("tblRegisteredUsers").Rows

            ADD = (AddRow("RelationshipID").ToString())

        Next

        AddDAConnection.Close()

        If ADD = String.Empty Then
            SqlDataSource1.InsertParameters.Add("ID", RelationshipID)
            SqlDataSource1.InsertParameters.Add("RelationshipID", ID)
            SqlDataSource1.InsertParameters.Add("URLOfPicture", URLOfPicture)
            SqlDataSource1.InsertParameters.Add("FirstName1", FirstNameA)
            SqlDataSource1.InsertParameters.Add("MiddleName1", MiddleNameA)
            SqlDataSource1.InsertParameters.Add("LastName1", LastNameA)
            SqlDataSource1.InsertParameters.Add("FirstName2", FirstNameB)
            SqlDataSource1.InsertParameters.Add("MiddleName2", MiddleNameB)
            SqlDataSource1.InsertParameters.Add("LastName2", LastNameB)
            SqlDataSource1.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource1.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource1.InsertParameters.Add("Relationships", "Association")
            SqlDataSource1.InsertParameters.Add("FollowUnFollow", "Follow")
            SqlDataSource1.InsertParameters.Add("Approved", 0)
            SqlDataSource1.InsertParameters.Add("DateTime", Date.Now)

            SqlDataSource1.Insert()
        End If

        Dim InitialMailMessage = New MailMessage()
        InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        InitialMailMessage.To.Add(New MailAddress(LoggedInEmail))
        InitialMailMessage.Subject = "Unknownprotocol Request"
        InitialMailMessage.Body = "<p>A request has been sent to you for you to be an aquintences.</p>" &
            "<a href='http://www.unknownprotocol.me:8080/approveddisapproved.aspx?ID=" & RelationshipID & "&RelationshipID=" & ID & "&Approve=True'>Approve</a>" &
            "  <a href='http://www.unknownprotocol.me:8080/approveddisapproved.aspx?ID=" & RelationshipID & "&RelationshipID=" & ID & "&Approve=False'>Decline</a>" &
            "  <a href='http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID & "'>View Profile</a>"
        InitialMailMessage.IsBodyHtml = True
        Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
        IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
        IntialSmtpClient.Timeout = 60000

        IntialSmtpClient.Send(InitialMailMessage)

        'If Gender = "Male" Then
        'Dim MailMessage = New MailMessage()
        'MailMessage.IsBodyHtml = False
        'MailMessage.From = New MailAddress("briandalesinger@yahoo.com")
        'MailMessage.To.Add(New MailAddress(LoggedInEmail))
        'MailMessage.Subject = "Unknownprotocol Request"
        'MailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " Please visit  " & FName & " " & MName & " " & LName & "'s UP page, a request has been sent to you for you to associate with him."
        'Dim SmtpClient = New SmtpClient("www.briandalesinger.me")
        'SmtpClient.ServicePoint.MaxIdleTime = 60000
        'SmtpClient.Timeout = 60000

        'SmtpClient.Send(MailMessage)
        'End If

        'If Gender = "Female" Then
        'Dim MailMessage = New MailMessage()
        'MailMessage.IsBodyHtml = False
        'MailMessage.From = New MailAddress("briandalesinger@yahoo.com")
        'MailMessage.To.Add(New MailAddress(LoggedInEmail))
        'MailMessage.Subject = "Unknownprotocol Request"
        'MailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " Please visit  " & FName & " " & MName & " " & LName & "'s UP page, a request has been sent to you for you to associate with her."
        'Dim SmtpClient = New SmtpClient("www.briandalesinger.me")
        'SmtpClient.ServicePoint.MaxIdleTime = 60000
        'SmtpClient.Timeout = 60000

        'SmtpClient.Send(MailMessage)
        'End If
        '!!! UPDATE THIS VALUE TO YOUR EMAIL ADDRESS
        'Dim ToAddress As String = EmailNotification

        ''(1) Create the MailMessage instance
        'Dim mm As New MailMessage(LoggedInEmail, ToAddress)

        '(2) Assign the MailMessage's properties
        'mm.Subject = "Unknownprotocol Request"
        'mm.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " Please visit User ID number " & RelationshipID & " UP page. "
        'mm.IsBodyHtml = False

        '(3) Create the SmtpClient object
        'Dim smtp As New SmtpClient

        '(4) Send the MailMessage (will use the Web.config settings)
        'smtp.Send(mm)

        'Response.Redirect("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        IDSS = DropDownList2.SelectedItem.Value

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            EmailNotification = (Row("Email").ToString())
        Next

        Connection.Close()

        Dim NotificationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim NotificationCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE RelationshipEmail = '" & Email & "'", NotificationConnection)
        Dim NotificationDA As SqlDataAdapter = New SqlDataAdapter()

        NotificationDA.SelectCommand = NotificationCmd
        NotificationConnection.Open()
        Dim NotificationDS As DataSet = New DataSet()
        NotificationDA.Fill(NotificationDS, "tblRegistered")
        Dim NotificationRow As DataRow

        For Each NotificationRow In NotificationDS.Tables("tblRegistered").Rows

            RelationshipID = (NotificationRow("ID").ToString())
            RelationshipEmail = (NotificationRow("RelationshipEmail").ToString())
            'EmailNotification = (NotificationRow("RelationshipEmail").ToString())


        Next

        NotificationConnection.Close()

        Dim EmailNotificationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim EmailNotificationCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE IDSS = '" & IDSS & "'", EmailNotificationConnection)
        Dim EmailNotificationDA As SqlDataAdapter = New SqlDataAdapter()

        EmailNotificationDA.SelectCommand = EmailNotificationCmd
        EmailNotificationConnection.Open()
        Dim EmailNotificationDS As DataSet = New DataSet()
        EmailNotificationDA.Fill(EmailNotificationDS, "tblRegisteredUsers")
        Dim EmailNotificationRow As DataRow

        For Each EmailNotificationRow In EmailNotificationDS.Tables("tblRegisteredUsers").Rows

            IDRelationship = (EmailNotificationRow("RelationshipID").ToString())
            'IDSS = (EmailNotificationRow("IDSS").ToString())
            'EmailNotification = (EmailNotificationRow("LoggedInEmail").ToString())
        Next

        EmailNotificationConnection.Close()

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Invisable" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Invisable Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be Invisable."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Association" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Association Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be an Association."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Aquintences" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Aquintences Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be an or know an Aquintences."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "TheList" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "The List Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be on or know the The List."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "InTheKnow" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "In The Know Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be In The Know."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Knows" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to Know."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "KnowsOf" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to Knows Of."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Friends" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be Friends."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "WantToDate" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who Want To Date."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)
        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Dateing" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is Dateing."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000

            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Fiances" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to who is a Fiances."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Fiancees" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to who is a Fiancees."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Married" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is Married."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Divorce" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is a Divorce."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Divorcee" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is a Divorcee."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "NonBiologicalFamily" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is a Non Biological Family member."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Family" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to know who is Family."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Secret" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be or know who has a Family Secret."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "FamilySecret" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be or know who has a Family Secret."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

        If ID = RelationshipID And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "MixAndMingle" Then

            SqlDataSource7.UpdateParameters.Add("Relationships", DropDownList3.SelectedItem.Value)

            SqlDataSource7.Update()

            AssociationListView.DataBind()
            TheListRelationshipListView.DataBind()
            InTheKnowRelationshipListView.DataBind()
            KnowsRelationshipListView.DataBind()
            KnowsOfRelationshipListView.DataBind()
            AquintenceRelationshipListView.DataBind()
            FriendsRelationshipListView.DataBind()
            WantToDateRelationshipListView.DataBind()
            DateingRelationshipListView.DataBind()
            MarriedRelationshipListView.DataBind()
            FiancesRelationshipListView.DataBind()
            FianceesRelationshipListView.DataBind()
            DivorceRelationshipListView.DataBind()
            DivorceeRelationshipListView.DataBind()
            NonBiologicaFamilyRelationshipListView.DataBind()
            FamilyRelationshipListView.DataBind()
            SecretRelationshipListView.DataBind()
            FamilySecretRelationshipListView.DataBind()

            'Dim InitialMailMessage = New MailMessage()
            'InitialMailMessage.IsBodyHtml = False
            'InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
            'InitialMailMessage.To.Add(New MailAddress(EmailNotification))
            'InitialMailMessage.Subject = "Unknownprotocol Request"
            'InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to mix and mingle."
            'Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
            'IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
            'IntialSmtpClient.Timeout = 60000
            'IntialSmtpClient.Send(InitialMailMessage)

        End If

    End Sub

    'Dim EmailApprovalConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
    'Dim EmailApprovalCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", EmailApprovalConnection)

    'Dim EmailApprovalDA As SqlDataAdapter = New SqlDataAdapter
    'EmailApprovalDA.SelectCommand = EmailApprovalCmd
    'EmailApprovalConnection.Open()
    'Dim EmailApprovalDS As DataSet = New DataSet()
    'EmailApprovalDA.Fill(EmailApprovalDS, "tblRegistered")
    'Dim EmailApprovalRow As DataRow

    ' For Each EmailApprovalRow In EmailApprovalDS.Tables("tblRegistered").Rows

    'Firstname = (EmailApprovalRow("FirstName").ToString())
    'Middlename = (EmailApprovalRow("MiddleName").ToString())
    'tName = (EmailApprovalRow("LastName1").ToString())
    'LoggedInEmail = (EmailApprovalRow("Email").ToString())

    't

    'EmailApprovalConnection.Close()
    'Protected Sub ddlSelectADestination_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSelectADestination.SelectedIndexChanged

    'If ddlSelectADestination.SelectedItem.Value = "MixAndMingle" Then
    'Response.Redirect("mixandmingle.aspx")
    'End If

    'End Sub

    Protected Sub btnChangeYourStatus_Click(sender As Object, e As System.EventArgs) Handles btnChangeYourStatus.Click


        Dim EmailNotificationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim EmailNotificationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", EmailNotificationConnection)
        Dim EmailNotificationDA As SqlDataAdapter = New SqlDataAdapter()

        EmailNotificationDA.SelectCommand = EmailNotificationCmd
        EmailNotificationConnection.Open()
        Dim EmailNotificationDS As DataSet = New DataSet()
        EmailNotificationDA.Fill(EmailNotificationDS, "tblRegistered")
        Dim EmailNotificationRow As DataRow

        For Each EmailNotificationRow In EmailNotificationDS.Tables("tblRegistered").Rows

            RelationshipID = (EmailNotificationRow("ID").ToString())
            EmailNotification = (EmailNotificationRow("Email").ToString())
        Next

        EmailNotificationConnection.Close()

        Dim NotificationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim NotificationCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE LoggedInEmail = '" & Email & "'", NotificationConnection)
        Dim NotificationDA As SqlDataAdapter = New SqlDataAdapter()

        NotificationDA.SelectCommand = NotificationCmd
        NotificationConnection.Open()
        Dim NotificationDS As DataSet = New DataSet()
        NotificationDA.Fill(NotificationDS, "RegisteredUsers")
        Dim NotificationRow As DataRow

        For Each NotificationRow In NotificationDS.Tables("RegisteredUsers").Rows

            'RelationshipID = (NotificationRow("ID").ToString())
            RelationshipEmail = (NotificationRow("RelationshipEmail").ToString())
            EmailNotification = (NotificationRow("RelationshipEmail").ToString())


        Next

        NotificationConnection.Close()

        Dim ChangeStatusConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim ChangeStatusCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE ID = '" & ID & "' ", ChangeStatusConnection)
        Dim ChangeStatusDA As SqlDataAdapter = New SqlDataAdapter()

        ChangeStatusDA.SelectCommand = ChangeStatusCmd
        ChangeStatusConnection.Open()
        Dim ChangeStatusDS As DataSet = New DataSet()
        ChangeStatusDA.Fill(ChangeStatusDS, "tblRegisteredUsers")
        Dim ChangeStatusRow As DataRow

        For Each ChangeStatusRow In ChangeStatusDS.Tables("tblRegisteredUsers").Rows

            GlobalChangeID = (ChangeStatusRow("RelationshipID").ToString())
            Firstname = (ChangeStatusRow("FirstName1").ToString())
            Middlename = (ChangeStatusRow("MiddleName1").ToString())
            LastName = (ChangeStatusRow("LastName1").ToString())
            IDSS = (ChangeStatusRow("IDSS").ToString())
            EmailNotification = (ChangeStatusRow("LoggedInEmail").ToString())

        Next

        ChangeStatusConnection.Close()

        SqlDataSource4.UpdateParameters.Add("Relationships", DropDownList1.SelectedItem.Value)

        SqlDataSource4.Update()

        AssociationListView.DataBind()
        TheListRelationshipListView.DataBind()
        InTheKnowRelationshipListView.DataBind()
        KnowsRelationshipListView.DataBind()
        KnowsOfRelationshipListView.DataBind()
        AquintenceRelationshipListView.DataBind()
        FriendsRelationshipListView.DataBind()
        WantToDateRelationshipListView.DataBind()
        DateingRelationshipListView.DataBind()
        MarriedRelationshipListView.DataBind()
        FiancesRelationshipListView.DataBind()
        FianceesRelationshipListView.DataBind()
        DivorceRelationshipListView.DataBind()
        DivorceeRelationshipListView.DataBind()
        NonBiologicaFamilyRelationshipListView.DataBind()
        FamilyRelationshipListView.DataBind()
        SecretRelationshipListView.DataBind()
        FamilySecretRelationshipListView.DataBind()

        Dim InitialMailMessage = New MailMessage()
        InitialMailMessage.IsBodyHtml = False
        InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        InitialMailMessage.To.Add(New MailAddress(EmailNotification))
        InitialMailMessage.Subject = "Unknownprotocol Request"
        InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & " a request has been sent to you for you to be an aquintences."
        Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
        IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
        IntialSmtpClient.Timeout = 60000
        IntialSmtpClient.Send(InitialMailMessage)

    End Sub

    Protected Sub btnMakeConnection_Click(sender As Object, e As EventArgs) Handles btnMakeConnection.Click
        Response.Redirect("http://www.unknownprotocol.me:8080/status.aspx?ID=" & ID)
        ' & "&IDSS=" & IDSS
    End Sub
    Protected Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Response.Redirect("http://www.unknownprotocol.me:8080/CreateContact.aspx?ID=" & ID)
    End Sub

    Protected Sub btnViewStatus_Click(sender As Object, e As EventArgs) Handles btnViewStatus.Click
        Response.Redirect("http://www.unknownprotocol.me:8080/contactinformation.aspx?ID=" & ID)
    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.me:8080/logon.aspx", True)

    End Sub

    Protected Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "' ", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            ID = (Row("ID").ToString())
            RelationshipEmail = (Row("Email").ToString())

        Next

        Connection.Close()

        If DropDownList2.SelectedItem.Value = "" Then

            Response.Redirect("http://www.unknownprotocol.me:8080/unknownprotocol.aspx?ID=" & ID & "&IDSS=" & "0")

            'Response.Redirect("http://www.unknownprotocol.me:8080/unknownprotocol.aspx?ID=" & Session("ID") & "&IDSS=" & "0")

            'ElseIf DropDownList2.SelectedItem.Value = "" Then

            'Response.Redirect("http://www.unknownprotocol.me:8080/unknownprotocol.aspx?ID=" & ID & "&IDSS=" & DropDownList2.SelectedItem.Value)

        End If

    End Sub

    Protected Function IsVisible(UserID As String) As Boolean
        Dim ID = Session("ID")
        Dim SelectConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim SelectCmd As SqlCommand = New SqlCommand("SELECT * FROM tblRegisteredUsers WHERE ((ID = '" & ID & "' AND RelationshipID = '" & UserID & "') OR (ID = '" & UserID & "' AND RelationshipID = '" & ID & "')) And Approved = '1'", SelectConnection)

        SelectConnection.Open()
        Dim count = SelectCmd.ExecuteScalar()
        SelectConnection.Close()

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Select Case e.Item.Value

            Case "Home"

                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "' ", Connection)
                Dim DA As SqlDataAdapter = New SqlDataAdapter()

                DA.SelectCommand = Cmd
                Connection.Open()
                Dim DS As DataSet = New DataSet()
                DA.Fill(DS, "tblRegistered")
                Dim Row As DataRow
                For Each Row In DS.Tables("tblRegistered").Rows

                    IDHome = (Row("ID").ToString())

                Next

                Connection.Close()

            If IDHome = ID Then
                Response.Redirect("~/default.aspx?ID=" & ID)
            End If
            Exit Select

            Case "Contacts"

                Response.Redirect("~/contact.aspx?ID=" & ID)
                Exit Select

            Case "Delete Contact"

                Response.Redirect("~/deletecontact.aspx?ID=" & ID)
                Exit Select
            Case "Delete Contact"
                Response.Redirect("~/deletecontact.aspx?ID=" & ID)
                Exit Select

        End Select

    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Response.Redirect("http://www.unknownprotocol.me:8080/search.aspx?ID=" & ID)

    End Sub
End Class
