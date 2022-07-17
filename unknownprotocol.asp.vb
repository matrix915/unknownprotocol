Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Configuration
Partial Class unknownprotocol
    Inherits System.Web.UI.Page

    Protected Friend Firstname As String
    Protected Friend Middlename As String
    Protected Friend Lastname As String
    Protected Friend Firstname1 As String
    Protected Friend Middlename1 As String
    Protected Friend Lastname1 As String
    Protected Friend ContinentText As String
    Protected Friend CountryText As String
    Protected Friend StateText As String
    Protected Friend City As String
    Protected Friend Town As String
    Protected Friend Village As String
    Protected Friend Island As String
    Protected Friend AddressText As String
    Protected Friend ZipcodeText As String
    Protected Friend FileName As String
    Protected Friend URLOfPicture As String
    Protected Friend LoggedInEmail As String
    Protected Friend RelationshipEmail As String
    Protected Friend RelationshipID As String
    Protected Friend Emotions As String
    Protected Friend Email As String
    Protected Friend DateTime As String
    Public Shared IDSS As Integer


    'Dim WithEvents Connect As New Button
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")

        Session("ID") = ID


        If Not Request.QueryString("IDSS") Is Nothing Then
            IDSS = CInt(Request.QueryString("IDSS"))
        End If

        Email = CType(Session.Item("Email"), String)

        Email = Session("Email")

        If Session("Email") Is Nothing Then
            FormsAuthentication.SignOut()
            Response.Redirect("http://www.unknownprotocol.me:8080/logout.aspx", True)
        End If

        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
        Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
        Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
        ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)

        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { document.getElementById('UpdatePanel1').scrollTo(0,10000); }, 1);", True)

    End Sub

    'Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    '    Dim SqlDataSource2 As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)

    '    Dim OldChatDelete As String = "DELETE tblPublicChat WHERE DATEDIFF(second, DateTime, getdate()) > 180"
    '    Dim OldChatDeleteCmd As New SqlCommand(OldChatDelete)
    '    OldChatDeleteCmd.Connection = SqlDataSource2
    '    SqlDataSource2.Open()
    '    OldChatDeleteCmd.ExecuteNonQuery()

    '    Dim StreamCmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblPublicChat WHERE addresses = '" & Session("Address") & "' AND emotions = '" &
    '                                                         Session("Emotions") & "' ORDER BY CommunicationID", SqlDataSource2)
    '    Dim Streamds As New DataSet()
    '    StreamCmd.Fill(Streamds)

    '    ListView1.DataSource = Streamds
    '    ListView1.DataBind()

    '    SqlDataSource2.Close()

    '    'WHERE ID = '" & ID & "' And RelationshipEmail = '" & Email & "'
    '    'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", true);
    '    'WHERE country = '" & "Unitedstates" & "'
    'End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function GetMessage(ByVal rowID As String, ByVal Address As String, ByVal Emotions As String) As String
        Dim response As String = ""
        If Address = "" AndAlso Emotions = "" Then
            Return rowID & "##" & response
        End If

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)

        Dim OldChatDelete As String = "DELETE tblPublicChat WHERE DATEDIFF(second, DateTime, getdate()) > 180"
        Dim OldChatDeleteCmd As New SqlCommand(OldChatDelete)
        OldChatDeleteCmd.Connection = Connection
        Connection.Open()
        OldChatDeleteCmd.ExecuteNonQuery()

        Dim query As String = String.Empty
        Dim subQuery As String = String.Empty

        If IDSS > 0 Then
            subQuery = " AND IDSS = " & IDSS
        Else
            subQuery = " AND IDSS is null "
        End If

        If Not String.IsNullOrEmpty(Emotions) Then
            query = "Select * from tblPublicChat WHERE addresses = '" & Address & "' " & subQuery & " AND emotions = '" & Emotions & "' AND CommunicationID > '" & rowID & "' ORDER BY CommunicationID"
        Else
            query = "Select * from tblPublicChat WHERE addresses = '" & Address & "' " & subQuery & " AND CommunicationID > '" & rowID & "' ORDER BY CommunicationID"
        End If

        Dim Cmd As SqlCommand = New SqlCommand(query, Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()
        DA.SelectCommand = Cmd
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblPublicChat")

        Dim Row As DataRow
        For Each Row In DS.Tables("tblPublicChat").Rows
            rowID = (Row("CommunicationID").ToString())

            response &= "<b><span>" & (Row("FirstName").ToString()) & "</span>" &
                "<span>" & (Row("MiddleName").ToString()) & "</span>" &
                "<span>" & (Row("LastName").ToString()) & "</span></b>" &
                "<br/>"

            Dim URLOfPicture = (Row("URLOfPicture").ToString())
            If URLOfPicture <> "" Then
                response &= "<img src='" & URLOfPicture & "' style='height:50px;width:50px;' />"
            End If

            response &= "<br/><div class='a'><span style='font-size:16px;'>" & (Row("Posted").ToString()) & "</span></div><br/>"
            response &= "<br/><div class='a'><span style='font-size:14px;font-weight:bold'>" & (Row("emotions").ToString()) & "</span></div><br/><hr/><br/>"
        Next
        Connection.Close()
        Return rowID & "##" & response
    End Function
    Sub SaveFile(ByVal file As HttpPostedFile, ByVal fileName As String)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        'Dim fileName As String = FileUpload.FileName

        '' Create the path and file name to check for duplicates.
        'Dim pathToCheck As String = savePath + fileName

        '' Create a temporary file name to use for checking duplicates.
        'Dim tempfileName As String
        'tempfileName = ""
        '' Check to see if a file already exists with the
        '' same name as the file to upload.        
        'If (System.IO.File.Exists(pathToCheck)) Then
        '    Dim counter As Integer = 1
        '    While (System.IO.File.Exists(pathToCheck))
        '        ' If a file with this name already exists,
        '        ' prefix the filename with a number.
        '        tempfileName = counter.ToString() + fileName
        '        pathToCheck = savePath + tempfileName
        '        counter = counter + 1
        '    End While

        '    fileName = tempfileName

        'End If

        ' Append the name of the file to upload to the path.
        savePath += fileName

        ' Call the SaveAs method to save the uploaded
        ' file to the specified directory.
        FileUpload.SaveAs(savePath)
    End Sub

    Protected Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click


        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "' ", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            RelationshipID = (Row("ID").ToString())
            'Email = (Row("Email").ToString())
            Firstname = (Row("FirstName").ToString())
            Middlename = (Row("MiddleName").ToString())
            Lastname = (Row("LastName").ToString())
            URLOfPicture = (Row("URLOfPicture").ToString())
            RelationshipEmail = (Row("Email").ToString())
            LoggedInEmail = (Row("Email").ToString())

        Next

        Connection.Close()

        Dim IDConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim IDCmd As SqlCommand = New SqlCommand("Select * from tblRegistered  WHERE Email = '" & Email & "'", IDConnection)
        Dim IDDA As SqlDataAdapter = New SqlDataAdapter()

        IDDA.SelectCommand = IDCmd
        IDConnection.Open()
        Dim IDDS As DataSet = New DataSet()
        IDDA.Fill(IDDS, "tblRegistered")
        Dim IDRow As DataRow

        For Each IDRow In IDDS.Tables("tblregistered").Rows

            ID = (IDRow("ID").ToString())
            'RelationshipID = (IDRow("ID").ToString())
            'Firstname = (IDRow("FirstName").ToString())
            ' Middlename = (IDRow("MiddleName").ToString())
            'Lastname = (IDRow("LastName").ToString())
            URLOfPicture = (IDRow("URLOfPicture").ToString())

        Next


        IDConnection.Close()

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        Dim tempfileName As String
        tempfileName = ""
        'Check to see if a file already exists with the
        ' same name as the file to upload.        
        If (System.IO.File.Exists(pathToCheck)) Then
            Dim counter As Integer = 1
            While (System.IO.File.Exists(pathToCheck))
                ' If a file with this name already exists,
                ' prefix the filename with a number.
                tempfileName = counter.ToString() + fileName
                pathToCheck = savePath + tempfileName
                counter = counter + 1
            End While

            fileName = tempfileName

        End If

        ' Append the name of the file to upload to the path.


        If (FileUpload.HasFile) Then
            'Call a helper method routine to save the file.
            SaveFile(FileUpload.PostedFile, fileName)
            fileName = "http://www.unknownprotocol.me:8080/postimages/" + fileName
        Else
            fileName = ""

        End If


        'Dim Emotions As String = String.Empty

        ContinentText = continent.Text
        CountryText = country.Text
        StateText = state.Text
        ' City = Request.QueryString("City")
        ' Session("City") = City
        ' Town = Request.QueryString("Town")
        ' Session("Town") = Town
        ' Village = Request.QueryString("Village")
        ' Session("Village") = Village
        ' Island = Request.QueryString("Island")
        ' Session("Island") = Island
        AddressText = address.Text
        ZipcodeText = zipcode.Text

        'Emotions = Request.QueryString("Emotions")
        'Session("Emotions") = Emotions

        If rbAngry.Checked Then
            Emotions = "Angry"
        ElseIf rbAnxious.Checked Then
            Emotions = "Anxious"
        ElseIf rbBlewUp.Checked Then
            Emotions = "Blew Up"
        ElseIf rbBold.Checked Then
            Emotions = "Bold"
        ElseIf rbBored.Checked Then
            Emotions = "Bored"
        ElseIf rbCalm.Checked Then
            Emotions = "Calm"
        ElseIf rbCautious.Checked Then
            Emotions = "Cautious"
        ElseIf rbCool.Checked Then
            Emotions = "Cool"
        ElseIf rbConfident.Checked Then
            Emotions = "Confident"
        ElseIf rbConfused.Checked Then
            Emotions = "Confused"
        ElseIf rbContent.Checked Then
            Emotions = "Content"
        ElseIf rbCrying.Checked Then
            Emotions = "Crying"
        ElseIf rbDepressed.Checked Then
            Emotions = "Depressed"
        ElseIf rbDown.Checked Then
            Emotions = "Down"
        ElseIf rbDuress.Checked Then
            Emotions = "Duress"
        ElseIf rbDiscriminated.Checked Then
            Emotions = "Discriminated"
        ElseIf rbDisgusted.Checked Then
            Emotions = "Disgusted"
        ElseIf rbEcstatic.Checked Then
            Emotions = "Ecstatic"
        ElseIf rbEmbarrassed.Checked Then
            Emotions = "Embarrassed"
        ElseIf rbEnraged.Checked Then
            Emotions = "Enraged"
        ElseIf rbExhausted.Checked Then
            Emotions = "Exhausted"
        ElseIf rbFrightend.Checked Then
            Emotions = "Frightend"
        ElseIf rbFrustrated.Checked Then
            Emotions = "Frustrated"
        ElseIf rbGuilty.Checked Then
            Emotions = "Guilty"
        ElseIf rbHappy.Checked Then
            Emotions = "Happy"
        ElseIf rbHonorable.Checked Then
            Emotions = "Honorable"
        ElseIf rbHopeful.Checked Then
            Emotions = "Hopeful"
        ElseIf rbHysterical.Checked Then
            Emotions = "Hysterical"
        ElseIf rbInlove.Checked Then
            Emotions = "Inlove"
        ElseIf rbJealous.Checked Then
            Emotions = "Jealous"
        ElseIf rbLightenedUp.Checked Then
            Emotions = "Lightened Up"
        ElseIf rbLonley.Checked Then
            Emotions = "Lonley"
        ElseIf rbLoveStruck.Checked Then
            Emotions = "Love Struck"
        ElseIf rbMad.Checked Then
            Emotions = "Mad"
        ElseIf rbMedicated.Checked Then
            Emotions = "Medicated"
        ElseIf rbMischievous.Checked Then
            Emotions = "Mischievous"
        ElseIf rbOutOfThisWorld.Checked Then
            Emotions = "OutOfThisWorld"
        ElseIf rbOverwhelmed.Checked Then
            Emotions = "Overwhelmed"
        ElseIf rbPain.Checked Then
            Emotions = "Pain"
        ElseIf rbPowerful.Checked Then
            Emotions = "Powerful"
        ElseIf rbProvoked.Checked Then
            Emotions = "Provoked"
        ElseIf rbQuite.Checked Then
            Emotions = "Quite"
        ElseIf rbRelaxed.Checked Then
            Emotions = "Relaxed"
        ElseIf rbSad.Checked Then
            Emotions = "Sad"
        ElseIf rbSexy.Checked Then
            Emotions = "Sexy"
        ElseIf rbShocked.Checked Then
            Emotions = "Shocked"
        ElseIf rbShy.Checked Then
            Emotions = "Shy"
        ElseIf rbSmug.Checked Then
            Emotions = "Smug"
        ElseIf rbStressed.Checked Then
            Emotions = "Stressed"
        ElseIf rbStupid.Checked Then
            Emotions = "Stupid"
        ElseIf rbSuprised.Checked Then
            Emotions = "Suprised"
        ElseIf rbSuspicious.Checked Then
            Emotions = "Suspicious"
        ElseIf rbTired.Checked Then
            Emotions = "Tired"
        ElseIf rbUpbeat.Checked Then
            Emotions = "UpBeat"
        ElseIf rbUpset.Checked Then
            Emotions = "Upset"
        ElseIf rbUptight.Checked Then
            Emotions = "Uptight"
        ElseIf rbVengeful.Checked Then
            Emotions = "Vengeful"
        ElseIf rbWondering.Checked Then
            Emotions = "Wondering"
        End If

        If Posted.Text <> "" Then
            SqlDataSource1.InsertParameters.Add("ID", ID)
            If IDSS > 0 Then
                SqlDataSource1.InsertParameters.Add("IDSS", IDSS)
            Else
                SqlDataSource1.InsertParameters.Add("IDSS", Nothing)
            End If

            SqlDataSource1.InsertParameters.Add("RelationshipID", ID)
            SqlDataSource1.InsertParameters.Add("URLOfPicture", fileName)
            SqlDataSource1.InsertParameters.Add("FirstName", Firstname)
            SqlDataSource1.InsertParameters.Add("MiddleName", Middlename)
            SqlDataSource1.InsertParameters.Add("LastName", Lastname)
            SqlDataSource1.InsertParameters.Add("Posted", Posted.Text)
            'SqlDataSource1.InsertParameters.Add("Continents", ContinentText)
            'SqlDataSource1.InsertParameters.Add("Countries", CountryText)
            'SqlDataSource1.InsertParameters.Add("States", StateText)
            'SqlDataSource1.InsertParameters.Add("Cities", Session("City"))
            'SqlDataSource1.InsertParameters.Add("Towns", Session("Town"))
            'SqlDataSource1.InsertParameters.Add("Villages", Session("Village"))
            'SqlDataSource1.InsertParameters.Add("Islands", Session("Island"))
            SqlDataSource1.InsertParameters.Add("Addresses", AddressText)
            SqlDataSource1.InsertParameters.Add("Zipcodes", ZipcodeText)
            SqlDataSource1.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource1.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource1.InsertParameters.Add("Relationships", "Association")
            SqlDataSource1.InsertParameters.Add("Emotions", Emotions)
            SqlDataSource1.InsertParameters.Add("DateTime", Date.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            SqlDataSource1.Insert()
        End If

        Session("Emotions") = Emotions
        Session("Address") = AddressText

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.me:8080/logon.aspx", True)

    End Sub


    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Select Case e.Item.Text
            Case "User Update"
                Response.Redirect("~/test2.aspx?ID=" & ID)
                Exit Select
        End Select

    End Sub
End Class
