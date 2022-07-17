Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Net.Security
Imports System.Net.Mail

Partial Class Status

    Inherits System.Web.UI.Page

    Protected strExpression As String
    Protected Firstname As String
    Protected Middlename As String
    Protected LastName As String
    Protected FirstName1 As String
    Protected MiddleName1 As String
    Protected LastName1 As String
    Protected Relationships As String
    Protected dbPicture As String
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
    Protected IDEmail As String
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
    Protected EmailNotification As String
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

        Email = CType(Session.Item("Email"), String)

        Session("Email") = Email

        ID = Request.QueryString("ID")

        Session("ID") = ID

        'ID = CType(Session.Item("ID"), String)
        'Session("ID") = ID

        IDSS = Request.QueryString("IDSS")

        Session("IDSS") = IDSS

        IDisapproved = Request.QueryString("IDisapproved")

        Session("IDisapproved") = IDisapproved

        YouDisapproved = Request.QueryString("YouDisapproved")

        Session("YouDisapproved") = YouDisapproved

        DateTime = Date.Now

        Dim Connection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            ID = (Row("ID").ToString())

        Next

        labelID.Text = ID

        Connection.Close()


        Dim IDeleteConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim IDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE ID = '" & ID & "'", IDeleteConnection)
        Dim IDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        IDeleteDA.SelectCommand = IDeleteCmd
        IDeleteConnection.Open()
        Dim IDeleteDS As DataSet = New DataSet()
        IDeleteDA.Fill(IDeleteDS, "tblRegisteredUsers")
        Dim IDeleteRow As DataRow

        For Each IDeleteRow In IDeleteDS.Tables("tblRegisteredUsers").Rows

            'ID = (DeleteRow("ID").ToString())
            RelationshipID = (IDeleteRow("RelationshipID").ToString())
            Firstname = (IDeleteRow("FirstName").ToString())
            Middlename = (IDeleteRow("MiddleName").ToString())
            LastName = (IDeleteRow("LastName").ToString())
            Relationships = (IDeleteRow("Relationships").ToString())
            LoggedInEmail = (IDeleteRow("LoggedInEmail").ToString())
            RelationshipEmail = (IDeleteRow("RelationshipEmail").ToString())

        Next

        If IDisapproved = "Deleted" And Email = RelationshipEmail Then

            'SqlDataSource6.InsertParameters.Add("ID", ID)
            SqlDataSource6.InsertParameters.Add("RelationshipID", RelationshipID)
            SqlDataSource6.InsertParameters.Add("FirstName", Firstname)
            SqlDataSource6.InsertParameters.Add("MiddleName", Middlename)
            SqlDataSource6.InsertParameters.Add("LastName", LastName)
            SqlDataSource6.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource6.InsertParameters.Add("LoggedInID", ID)
            SqlDataSource6.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource6.InsertParameters.Add("IDeleted", "IDeleted")
            SqlDataSource6.InsertParameters.Add("Relationships", Relationships)
            SqlDataSource6.InsertParameters.Add("DateTime", Date.Now)
            SqlDataSource6.Insert()

            Dim CommandDeleteConnections = "Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;"
            Dim CommandDeleteConnection As New SqlConnection(CommandDeleteConnections)
            Dim CommandDeleteDelete As String = "Delete tblRegisteredUsers " &
                        "WHERE IDSS= '" & IDSS & "' And RelationshipEmail = '" & Email & "'"
            Dim CommandDeleteCmd As New SqlCommand(CommandDeleteDelete)
            CommandDeleteCmd.Connection = CommandDeleteConnection
            CommandDeleteConnection.Open()
            CommandDeleteCmd.ExecuteNonQuery()
            CommandDeleteConnection.Close()

            CommandDeleteConnection.Close()

        End If

        IDeleteConnection.Close()


        Dim YouDeleteConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim YouDeleteCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE LoggedInEmail = '" & Email & "'", YouDeleteConnection)
        Dim YouDeleteDA As SqlDataAdapter = New SqlDataAdapter()

        YouDeleteDA.SelectCommand = YouDeleteCmd
        YouDeleteConnection.Open()
        Dim YouDeleteDS As DataSet = New DataSet()
        YouDeleteDA.Fill(YouDeleteDS, "tblRegisteredUsers")
        Dim YouDeleteRow As DataRow

        For Each YouDeleteRow In YouDeleteDS.Tables("tblRegisteredUsers").Rows

            'ID = (DeleteRow("ID").ToString())
            RelationshipID = (YouDeleteRow("RelationshipID").ToString())
            Firstname = (YouDeleteRow("FirstName").ToString())
            Middlename = (YouDeleteRow("MiddleName").ToString())
            LastName = (YouDeleteRow("LastName").ToString())
            Relationships = (YouDeleteRow("Relationships").ToString())
            LoggedInEmail = (YouDeleteRow("LoggedInEmail").ToString())
            RelationshipEmail = (YouDeleteRow("RelationshipEmail").ToString())

        Next

        If YouDisapproved = "Deleted" And Email = LoggedInEmail Then

            'SqlDataSource8.InsertParameters.Add("ID", ID)
            SqlDataSource8.InsertParameters.Add("RelationshipID", RelationshipID)
            SqlDataSource8.InsertParameters.Add("FirstName", Firstname)
            SqlDataSource8.InsertParameters.Add("MiddleName", Middlename)
            SqlDataSource8.InsertParameters.Add("LastName", LastName)
            SqlDataSource8.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource8.InsertParameters.Add("LoggedInID", ID)
            SqlDataSource8.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource8.InsertParameters.Add("YouDeleted", "YouDeleted")
            SqlDataSource8.InsertParameters.Add("Relationships", Relationships)
            SqlDataSource8.InsertParameters.Add("DateTime", Date.Now)
            SqlDataSource8.Insert()

            Dim YouCommandDeleteConnections = "Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;"
            Dim YouCommandDeleteConnection As New SqlConnection(YouCommandDeleteConnections)
            Dim YouCommandDeleteDelete As String = "Delete tblRegisteredUsers " &
                        "WHERE IDSS= '" & IDSS & "' And LoggedInEmail = '" & Email & "'"
            Dim YouCommandDeleteCmd As New SqlCommand(YouCommandDeleteDelete)
            YouCommandDeleteCmd.Connection = YouCommandDeleteConnection
            YouCommandDeleteConnection.Open()
            YouCommandDeleteCmd.ExecuteNonQuery()
            YouCommandDeleteConnection.Close()

            YouCommandDeleteConnection.Close()

        End If

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

        'Dim NameDeleteConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
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
        'LastName1 = NameDeleteRow("LastName").ToString()

        'SqlDataSource6.InsertParameters.Add("FirstName1", FirstName1)
        'SqlDataSource6.InsertParameters.Add("MiddleName1", MiddleName1)
        'SqlDataSource6.InsertParameters.Add("LastName1", LastName1)
        'SqlDataSource6.Insert()
        'Next
        'End If

        'Dim StatusCheck As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;Database=Registration;uid=sa;password=1AbrianA1;")
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
        'LastName1 = (StatusCheckRow("LastName").ToString())

        'End If
        'Next
        'End If

        'Response.Redirect("http://localhost/status.aspx?ID=" & RelationshipID)

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


        Dim Connection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
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

        Dim StatusConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim StatusCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", StatusConnection)
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
            'URLOfPicture = (Row("URLOfPicture").ToString())
        Next

        StatusConnection.Close()

        'Dim AddDAConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        'Dim AddCmd As SqlCommand = New SqlCommand("Select * from tblregisteredUsers WHERE LoggedInEmail = '" & Email & "'", AddDAConnection)

        'Dim AddDA As SqlDataAdapter = New SqlDataAdapter
        'AddDA.SelectCommand = AddCmd
        'AddConnection.Open()
        'Dim AddDS As DataSet = New DataSet()
        'AddDA.Fill(AddDS, "tblregisteredUsers")
        'Dim AddRow As DataRow

        'For Each AddRow In AddDS.Tables("tblregisteredUsers").Rows

        'AddID = (AddRow("RelationshipID").ToString())

        'Next

        'AddConnection.Close()

        RelationshipID = RelationshipID
        Firstname = Firstname
        Middlename = Middlename
        LastName = LastName
        URLOfPicture = URLOfPicture
        LoggedInEmail = LoggedInEmail

        DateTime = Date.Now

        SqlDataSource1.InsertParameters.Add("ID", RelationshipID)
        SqlDataSource1.InsertParameters.Add("RelationshipID", ID)
        SqlDataSource1.InsertParameters.Add("URLOfPicture", URLOfPicture)
        SqlDataSource1.InsertParameters.Add("FirstName", Firstname)
        SqlDataSource1.InsertParameters.Add("MiddleName", Middlename)
        SqlDataSource1.InsertParameters.Add("LastName", LastName)
        SqlDataSource1.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
        SqlDataSource1.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
        SqlDataSource1.InsertParameters.Add("Relationships", "Status")
        SqlDataSource1.InsertParameters.Add("FollowUnFollow", "UnFollow")
        SqlDataSource1.InsertParameters.Add("DateTime", DateTime)

        SqlDataSource1.Insert()


        Dim InitialMailMessage = New MailMessage()
        InitialMailMessage.IsBodyHtml = False
        InitialMailMessage.From = New MailAddress("digitalunknownprotocol@gmail.com")
        InitialMailMessage.To.Add(New MailAddress(Email))
        InitialMailMessage.Subject = "Unknownprotocol Request"
        InitialMailMessage.Body = ("http://localhost/sc.aspx?ID=" & RelationshipID) & " Please visit the " & FName & " " & MName & " " & LName & "'s UP page, a request has been sent to you for you to associate with them."
        Dim IntialSmtpClient = New SmtpClient("localhost")
        IntialSmtpClient.ServicePoint.MaxIdleTime = 60000
        IntialSmtpClient.Timeout = 60000

        IntialSmtpClient.Send(InitialMailMessage)

        'If Gender = "Male" Then
        'Dim MailMessage = New MailMessage()
        'MailMessage.IsBodyHtml = False
        'MailMessage.From = New MailAddress("unknownprotocol@att.net")
        'MailMessage.To.Add(New MailAddress(LoggedInEmail))
        'MailMessage.Subject = "Unknownprotocol Request"
        'MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit  " & FName & " " & MName & " " & LName & "'s UP page, a request has been sent to you for you to associate with him."
        'Dim SmtpClient = New SmtpClient("localhost")
        'SmtpClient.ServicePoint.MaxIdleTime = 60000
        'SmtpClient.Timeout = 60000

        'SmtpClient.Send(MailMessage)
        'End If

        'If Gender = "Female" Then
        'Dim MailMessage = New MailMessage()
        'MailMessage.IsBodyHtml = False
        'MailMessage.From = New MailAddress("unknownprotocol@att.net")
        'MailMessage.To.Add(New MailAddress(LoggedInEmail))
        'MailMessage.Subject = "Unknownprotocol Request"
        'MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit  " & FName & " " & MName & " " & LName & "'s UP page, a request has been sent to you for you to associate with her."
        'Dim SmtpClient = New SmtpClient("localhost")
        'SmtpClient.ServicePoint.MaxIdleTime = 60000
        'SmtpClient.Timeout = 60000

        'SmtpClient.Send(MailMessage)
        'End If
        '!!! UPDATE THIS VALUE TO YOUR EMAIL ADDRESS
        'Dim ToAddress As String = IDEmail

        ''(1) Create the MailMessage instance
        'Dim mm As New MailMessage(LoggedInEmail, ToAddress)

        '(2) Assign the MailMessage's properties
        'mm.Subject = "Unknownprotocol Request"
        'mm.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit User ID number " & RelationshipID & " UP page. "
        'mm.IsBodyHtml = False

        '(3) Create the SmtpClient object
        'Dim smtp As New SmtpClient

        '(4) Send the MailMessage (will use the Web.config settings)
        'smtp.Send(mm)

        'Response.Redirect("http://localhost/sc.aspx?ID=" & RelationshipID)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        IDSS = DropDownList2.SelectedItem.Value

        Dim EmailNotificationConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim EmailNotificationCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE IDSS = '" & IDSS & "'", EmailNotificationConnection)
        Dim EmailNotificationDA As SqlDataAdapter = New SqlDataAdapter()

        EmailNotificationDA.SelectCommand = EmailNotificationCmd
        EmailNotificationConnection.Open()
        Dim EmailNotificationDS As DataSet = New DataSet()
        EmailNotificationDA.Fill(EmailNotificationDS, "tblRegisteredUsers")
        Dim EmailNotificationRow As DataRow

        For Each EmailNotificationRow In EmailNotificationDS.Tables("tblRegisteredUsers").Rows

            RelationshipID = (EmailNotificationRow("ID").ToString())
            IDSSID = (EmailNotificationRow("IDSS").ToString())
            'RelationshipEmail = (EmailNotificationRow("RelationshipEmail").ToString())
            EmailNotification = (EmailNotificationRow("RelationshipEmail").ToString())

        Next

        EmailNotificationConnection.Close()

        If Email = EmailNotification And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Association" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://localhost/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page. Your status has been changed and you have been added to their Association."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If Email = EmailNotification And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "TheList" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page. Your status has been changed and you have been added to The List."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If Email = EmailNotification And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "InTheKnow" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to In The Know."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If Email = EmailNotification And DropDownList2.SelectedItem.Value = IDSS And DropDownList3.SelectedItem.Value = "Knows" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Knows."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If Email = EmailNotification And DropDownList3.SelectedItem.Value = "KnowsOf" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Knows Of."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If Email = EmailNotification And DropDownList3.SelectedItem.Value = "Aquintences" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Aquintences."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Friends" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Friends."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "WantToDate" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Want To Date."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Dateing" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Dateing."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Fiances" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Fiances."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Fiancees" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Fiancees."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Married" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Married."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Divorce" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Divorce."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Divorcee" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Divorcee."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "NonBiologicalFamily" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Non-Biological Family."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "Family" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(EmailNotification))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page, your status has been changed to Family."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "MenDateing" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(RelationshipEmail))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/mendateing.aspx?ID=" & RelationshipID) & " Please visit the men dateing page," & Firstname & " " & Middlename & " " & LastName & "status has been changed to Men Dateing."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

        If DropDownList3.SelectedItem.Value = "WomenDateing" Then

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

            Dim MailMessage = New MailMessage()
            MailMessage.IsBodyHtml = False
            MailMessage.From = New MailAddress("unknownprotocol@att.net")
            MailMessage.To.Add(New MailAddress(RelationshipEmail))
            MailMessage.Subject = "Unknownprotocol Request"
            MailMessage.Body = ("http://unknownprotocol.us/mendateing.aspx?ID=" & RelationshipID) & " Please visit the women dateing page," & Firstname & " " & Middlename & " " & LastName & " status has been changed to Women Dateing."
            Dim SmtpClient = New SmtpClient("localhost")
            SmtpClient.ServicePoint.MaxIdleTime = 60000
            SmtpClient.Timeout = 60000

            SmtpClient.Send(MailMessage)

        End If

    End Sub

    'Dim EmailApprovalConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
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
    'tName = (EmailApprovalRow("LastName").ToString())
    'LoggedInEmail = (EmailApprovalRow("Email").ToString())

    't

    'EmailApprovalConnection.Close()
    Protected Sub ddlSelectADestination_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSelectADestination.SelectedIndexChanged

        If ddlSelectADestination.SelectedItem.Value = "MenDateing" Then
            Response.Redirect("mendateing.aspx")
        ElseIf ddlSelectADestination.SelectedItem.Value = "WomenDateing" Then
            Response.Redirect("womendateing.aspx")
        End If

    End Sub

    Protected Sub btnChangeYourStatus_Click(sender As Object, e As System.EventArgs) Handles btnChangeYourStatus.Click

        Dim ChangeStatusConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim ChangeStatusCmd As SqlCommand = New SqlCommand("Select * from tblRegisteredUsers WHERE RelationshipID = '" & ID & "' ", ChangeStatusConnection)
        Dim ChangeStatusDA As SqlDataAdapter = New SqlDataAdapter()

        ChangeStatusDA.SelectCommand = ChangeStatusCmd
        ChangeStatusConnection.Open()
        Dim ChangeStatusDS As DataSet = New DataSet()
        ChangeStatusDA.Fill(ChangeStatusDS, "tblRegisteredUsers")
        Dim ChangeStatusRow As DataRow

        For Each ChangeStatusRow In ChangeStatusDS.Tables("tblRegisteredUsers").Rows

            RelationshipID = (ChangeStatusRow("RelationshipID").ToString())
            Firstname = (ChangeStatusRow("FirstName").ToString())
            Middlename = (ChangeStatusRow("MiddleName").ToString())
            LastName = (ChangeStatusRow("LastName").ToString())
            LoggedInEmail = (ChangeStatusRow("LoggedInEmail").ToString())

        Next

        ChangeStatusConnection.Close()

        If IDSS = DropDownList2.SelectedItem.Value Then

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

        End If

        'Dim MailMessage = New MailMessage()
        'MailMessage.IsBodyHtml = False
        'MailMessage.From = New MailAddress("unknownprotocol@att.net")
        'MailMessage.To.Add(New MailAddress(RelationshipEmail))
        'MailMessage.Subject = "Unknownprotocol Request"
        'MailMessage.Body = ("http://unknownprotocol.us/sc.aspx?ID=" & RelationshipID) & " Please visit " & Firstname & " " & Middlename & " " & LastName & "'s UP page. Your status has been changed to."
        'Dim SmtpClient = New SmtpClient("localhost")
        'SmtpClient.ServicePoint.MaxIdleTime = 60000
        'SmtpClient.Timeout = 60000

        'SmtpClient.Send(MailMessage)

    End Sub
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://localhost/logon.aspx", True)

    End Sub

    Protected Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Response.Redirect("http://localhost/test1.aspx?ID=" & ID)
    End Sub

    Protected Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Response.Redirect("http://localhost/userupdate.aspx?ID=" & ID)
    End Sub

    Protected Sub btnViewStatus_Click(sender As Object, e As EventArgs) Handles btnViewStatus.Click
        Response.Redirect("http://localhost/userinformation.aspx?ID=" & ID)
    End Sub
End Class
