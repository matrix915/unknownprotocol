Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail

Partial Class approveddisapproved
    Inherits System.Web.UI.Page

    Protected Email As String
    Protected strExpression As String
    Protected Firstname As String
    Protected Middlename As String
    Protected LastName As String
    Protected FirstName1 As String
    Protected MiddleName1 As String
    Protected LastName1 As String
    Protected Relationships As String
    Protected dbPicture As String
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
    Protected FName As String
    Protected MName As String
    Protected LName As String
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
    Protected LryEmail As String
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
    'Dim WithEvents btnAccept As New Button

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Page.User.Identity.IsAuthenticated = False Then

        'NavigationMenu.Items.Item(0).Enabled = False
        'NagationMenu.Items.Item(1).Enabled = True
        'NavigationMenu.Items.Item(2).Enabled = False
        'NavigationMenu.Items.Item(3).Enabled = True
        'NavigationMenu.Items.Item(4).Enabled = True
        'NavigationMenu.Items.Item(5).Enabled = True
        'NavigationMenu.Items.Item(6).Enabled = False
        'End If

        ID = Request.QueryString("ID")
        RelationshipID = Request.QueryString("RelationshipID")
        Approve = Request.QueryString("Approve")
        Email = Session("Email")
        Session("Email") = Email

        Dim ApproveValue As String = "0"
        If Approve = "True" Then
            ApproveValue = "1"
        ElseIf Approve = "False" Then
            ApproveValue = "2"
        End If


        Dim UpdateDAConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UpdateCmd As SqlCommand = New SqlCommand("UPDATE tblregisteredUsers SET Approved='" & ApproveValue & "' WHERE ID='" & ID & "' AND RelationshipID='" & RelationshipID & "'", UpdateDAConnection)
        UpdateDAConnection.Open()
        UpdateCmd.ExecuteNonQuery()
        UpdateDAConnection.Close()
        Response.Redirect("~/default.aspx?ID=" & ID)

        UpdateDAConnection.Close()

    End Sub

    Protected Sub btnAcceptClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccept.Click

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
            Firstname = (Row("FirstName").ToString())
            Middlename = (Row("MiddleName").ToString())
            LastName = (Row("LastName").ToString())
            URLOfPicture = (Row("URLOfPicture").ToString())
            LoggedInEmail = (Row("Email").ToString())
        Next

        Connection.Close()

        Dim StatusConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim StatusCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Session("Email") & "'", StatusConnection)
        Dim StatusDA As SqlDataAdapter = New SqlDataAdapter()

        StatusDA.SelectCommand = StatusCmd
        StatusConnection.Open()
        Dim StatusDS As DataSet = New DataSet()
        StatusDA.Fill(StatusDS, "tblRegistered")
        Dim StatusRow As DataRow
        For Each StatusRow In StatusDS.Tables("tblRegistered").Rows

            RelationshipID = (StatusRow("ID").ToString())
            'Firstname = (StatusRow("FirstName").ToString())
            'Middlename = (StatusRow("MiddleName").ToString())
            'LastName = (StatusRow("LastName").ToString())
            RelationshipEmail = (StatusRow("Email").ToString())
            'URLOfPicture = (StatusRow("URLOfPicture").ToString())

        Next

        StatusConnection.Close()

        Dim AddDAConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim AddCmd As SqlCommand = New SqlCommand("Select * from tblregisteredUsers", AddDAConnection)

        Dim AddDA As SqlDataAdapter = New SqlDataAdapter
        AddDA.SelectCommand = AddCmd
        AddDAConnection.Open()
        Dim AddDS As DataSet = New DataSet()
        AddDA.Fill(AddDS, "tblregisteredUsers")
        Dim AddRow As DataRow

        For Each AddRow In AddDS.Tables("tblRegisteredUsers").Rows

            ApproveDisapprove = (AddRow("FollowUnfollow").ToString())

        Next

        AddDAConnection.Close()

        DateTime = Date.Now

        SqlDataSource1.InsertParameters.Add("ID", RelationshipID)
        SqlDataSource1.InsertParameters.Add("RelationshipID", ID)
        SqlDataSource1.InsertParameters.Add("URLOfPicture", URLOfPicture)
        SqlDataSource1.InsertParameters.Add("FirstName", Firstname)
        SqlDataSource1.InsertParameters.Add("MiddleName", Middlename)
        SqlDataSource1.InsertParameters.Add("LastName", LastName)
        SqlDataSource1.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
        SqlDataSource1.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
        SqlDataSource1.InsertParameters.Add("Relationships", "Aquintences")
        SqlDataSource1.InsertParameters.Add("FollowUnFollow", "Follow")
        SqlDataSource1.InsertParameters.Add("DateTime", DateTime)

        SqlDataSource1.Insert()

        'Dim ChangeStatusConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        'Dim ChangeStatusCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE ID = '" & ID & "' ", ChangeStatusConnection)
        'Dim ChangeStatusDA As SqlDataAdapter = New SqlDataAdapter()

        'ChangeStatusDA.SelectCommand = ChangeStatusCmd
        'ChangeStatusConnection.Open()
        'Dim ChangeStatusDS As DataSet = New DataSet()
        'ChangeStatusDA.Fill(ChangeStatusDS, "tblRegisteredUsers")
        'Dim ChangeStatusRow As DataRow

        'For Each ChangeStatusRow In ChangeStatusDS.Tables("tblRegisteredUsers").Rows

        'RelationshipID = (ChangeStatusRow("RelationshipID").ToString())
        'Firstname = (ChangeStatusRow("FirstName1").ToString())
        'Middlename = (ChangeStatusRow("MiddleName1").ToString())
        'LastName = (ChangeStatusRow("LastName1").ToString())
        'lNotification = (ChangeStatusRow("LoggedInEmail").ToString())
        'Approved = (ChangeStatusRow("Approved").ToString())

        'Next

        'ChangeStatusConnection.Close()

        'SqlDataSource2.InsertParameters.Add("ID", ID)
        'SqlDataSource2.InsertParameters.Add("RelationshipID", RelationshipID)
        'SqlDataSource2.InsertParameters.Add("URLOfPicture", URLOfPicture)
        'SqlDataSource2.InsertParameters.Add("FirstName", Firstname)
        'SqlDataSource2.InsertParameters.Add("MiddleName", Middlename)
        'SqlDataSource2.InsertParameters.Add("LastName", LastName)
        'SqlDataSource2.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
        'SqlDataSource2.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
        'SqlDataSource2.InsertParameters.Add("Relationships", "Aquintences")
        'SqlDataSource2.InsertParameters.Add("FollowUnFollow", "Follow")
        'SqlDataSource2.InsertParameters.Add("DateTime", DateTime)

        'SqlDataSource2.Insert()

        Dim InitialMailMessage = New MailMessage()
        InitialMailMessage.IsBodyHtml = False
        InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        InitialMailMessage.To.Add(New MailAddress("briandalesinger@yahoo.com"))
        InitialMailMessage.Subject = "Unknownprotocol Request"
        InitialMailMessage.Body = ("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID) & "  a request has been sent to you for you to be an aquintences."
        Dim IntialSmtpClient = New SmtpClient("www.briandalesinger.me")
        IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
        IntialSmtpClient.Timeout = 60000

        IntialSmtpClient.Send(InitialMailMessage)

        'Response.Redirect("http://www.unknownprotocol.me:8080/default.aspx?ID=" & RelationshipID)

    End Sub
End Class
