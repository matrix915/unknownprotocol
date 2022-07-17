Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Partial Class unknownprotocol
    Inherits System.Web.UI.Page

    Protected Friend Firstname As String
    Protected Friend Middlename As String
    Protected Friend Lastname As String
    Protected Friend Firstname1 As String
    Protected Friend Middlename1 As String
    Protected Friend Lastname1 As String
    Protected Friend Continent As String
    Protected Friend Country As String
    Protected Friend State As String
    Protected Friend City As String
    Protected Friend Town As String
    Protected Friend Village As String
    Protected Friend Island As String
    Protected Friend Address As String
    Protected Friend Zipcode As String
    Protected Friend FileName As String
    Protected Friend URLOfPicture As String
    Protected Friend LoggedInEmail As String
    Protected Friend RelationshipEmail As String
    Protected Friend RelationshipID As String
    Protected Friend Emotions As String
    Protected Friend Email As String
    Protected Friend DateTime As String

    'Dim WithEvents Connect As New Button
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")

        'Session("ID") = ID

        'Email = CType(Session.Item("Email"), String)

        'Email = Session("Email")


    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim SqlDataSource2 As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)
        Dim StreamCmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblPublicChat ORDER BY CommunicationID", SqlDataSource2)
        Dim Streamds As New DataSet()
        StreamCmd.Fill(Streamds)

        ListView1.DataSource = Streamds
        ListView1.DataBind()

        SqlDataSource2.Close()

        'WHERE ID = '" & ID & "' And RelationshipEmail = '" & Email & "'
        'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", true);
        'WHERE country = '" & "Unitedstates" & "'
    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Contacts"
                Response.Redirect("~/status.aspx?ID=" & Session("ID"))
                Exit Select
        End Select
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload1.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        Dim tempfileName As String
        tempfileName = ""
        ' Check to see if a file already exists with the
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
        savePath += fileName

        ' Call the SaveAs method to save the uploaded
        ' file to the specified directory.
        FileUpload1.SaveAs(savePath)

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
            'Middlename = (Row("MiddleName").ToString())
            'Lastname = (Row("LastName").ToString())
            'URLOfPicture = (Row("URLOfPicture").ToString())
            RelationshipEmail = (Row("Email").ToString())

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
            Firstname = (IDRow("FirstName").ToString())
            Middlename = (IDRow("MiddleName").ToString())
            Lastname = (IDRow("LastName").ToString())

            URLOfPicture = (IDRow("URLOfPicture").ToString())
            LoggedInEmail = (IDRow("Email").ToString())

        Next


        IDConnection.Close()

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload1.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        ' Dim tempfileName As String
        ' tempfileName = ""
        ' Check to see if a file already exists with the
        ' same name as the file to upload.        
        ' If (System.IO.File.Exists(pathToCheck)) Then
        '     Dim counter As Integer = 1
        '     While (System.IO.File.Exists(pathToCheck))
        '         ' If a file with this name already exists,
        '         ' prefix the filename with a number.
        '         tempfileName = counter.ToString() + fileName
        '         pathToCheck = savePath + tempfileName
        '         counter = counter + 1
        '     End While

        '     fileName = tempfileName

        ' End If

        ' Append the name of the file to upload to the path.
        savePath += fileName

        If (FileUpload1.HasFile) Then
            'Call a helper method routine to save the file.
            SaveFile(FileUpload1.PostedFile)

        End If


        'Dim Emotions As String = String.Empty

        Continent = Request.QueryString("Continent")
        Session("Continent") = Continent
        Country = Request.QueryString("Country")
        Session("Country") = Country
        State = Request.QueryString("State")
        Session("State") = State
        ' City = Request.QueryString("City")
        ' Session("City") = City
        ' Town = Request.QueryString("Town")
        ' Session("Town") = Town
        ' Village = Request.QueryString("Village")
        ' Session("Village") = Village
        ' Island = Request.QueryString("Island")
        ' Session("Island") = Island
        Address = Request.QueryString("Address")
        Session("Address") = Address
        Zipcode = Request.QueryString("Zipcode")
        Session("Zipcode") = Zipcode


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
        ElseIf rbUpBeat.Checked Then
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
            SqlDataSource1.InsertParameters.Add("URLOfPicture", URLOfPicture)
            SqlDataSource1.InsertParameters.Add("FirstName", Firstname)
            SqlDataSource1.InsertParameters.Add("MiddleName", Middlename)
            SqlDataSource1.InsertParameters.Add("LastName", Lastname)
            SqlDataSource1.InsertParameters.Add("Posted", Posted.Text)
            SqlDataSource1.InsertParameters.Add("Continents", Session("Continent"))
            SqlDataSource1.InsertParameters.Add("Countries", Session("Country"))
            SqlDataSource1.InsertParameters.Add("States", Session("State"))
            ' SqlDataSource1.InsertParameters.Add("Cities", Session("City"))
            ' SqlDataSource1.InsertParameters.Add("Towns", Session("Town"))
            ' SqlDataSource1.InsertParameters.Add("Villages", Session("Village"))
            ' SqlDataSource1.InsertParameters.Add("Islands", Session("Island"))
            SqlDataSource1.InsertParameters.Add("Addresses", Session("Address"))
            SqlDataSource1.InsertParameters.Add("Zipcodes", Session("Zipcode"))
            SqlDataSource1.InsertParameters.Add("LoggedInEmail", LoggedInEmail)
            SqlDataSource1.InsertParameters.Add("RelationshipEmail", RelationshipEmail)
            SqlDataSource1.InsertParameters.Add("Relationships", "Association")
            SqlDataSource1.InsertParameters.Add("Emotions", Emotions)
            SqlDataSource1.InsertParameters.Add("DateTime", Date.Now)
            SqlDataSource1.Insert()
        End If

        'Session("Emotions") = Emotions

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://localhost:8080/logon.aspx", True)

    End Sub

End Class
