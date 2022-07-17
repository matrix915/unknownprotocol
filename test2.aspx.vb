Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Web.Security
Imports System.Net.Mail

Partial Class test2
    Inherits System.Web.UI.Page

    Protected DateTime As String
    Protected UNCPath As String
    Protected Relationship As String
    Protected StatusID As String
    Protected Email As String
    Protected RelationshipID As String
    Protected FirstName As String
    Protected MiddleName As String
    Protected LastName As String
    Protected URLOfPicture As String
    Protected Country As String
    Protected State As String
    Protected Town As String
    Protected Address As String
    Protected City As String
    Protected ZipCode As String
    Protected CurrentAge As String
    Protected Gender As String
    Protected HeightFeet As String
    Protected HeightInches As String
    Protected WeightPounds As String
    Protected WeightOunces As String
    Protected HairColor As String
    Protected EyeColor As String
    Protected Drinks As String
    Protected Smokes As String
    Protected UsesDrugs As String
    Protected Emotions As String
    Protected MaritalStatus As String
    Protected PathToPicture As String
    Protected UpDateEmail As String
    Protected RelationshipEmail As String
    Protected IDStatus As String
    Protected IDRelationship As String
    Protected EmailStatus As String
    Protected RelatonshipID As String

    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")
        Session("ID") = ID

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email


        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
        End If

    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & ID)
                Exit Select
            Case "Contacts"
                Response.Redirect("~/status.aspx?ID=" & ID)
                Exit Select
        End Select
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

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
        FileUpload.SaveAs(savePath)

    End Sub

    Protected Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblUpdateRegistered WHERE RelationshipID = '" & ID & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblUpdateRegistered")
        Dim Row As DataRow

        For Each Row In DS.Tables("tblUpdateRegistered").Rows


            IDRelationship = (Row("RelationshipID").ToString())
            EmailStatus = (Row("Email").ToString())
            URLOfPicture = (Row("URLofPicture").ToString())
            FirstName = (Row("FirstName").ToString())
            MiddleName = (Row("MiddleName").ToString())
            LastName = (Row("LastName").ToString())
            Country = (Row("Country").ToString())
            State = (Row("State").ToString())
            Address = (Row("Address").ToString())
            City = (Row("City").ToString())
            ZipCode = (Row("ZipCode").ToString())
            CurrentAge = (Row("CurrentAge").ToString())
            Gender = (Row("Gender").ToString())
            HeightFeet = (Row("HeightFeet").ToString())
            HeightInches = (Row("HeightInches").ToString())
            WeightPounds = (Row("WeightPounds").ToString())
            WeightOunces = (Row("WeightOunces").ToString())
            HairColor = (Row("HairColor").ToString())
            EyeColor = (Row("EyeColor").ToString())
            Drinks = (Row("Drinks").ToString())
            Smokes = (Row("Smokes").ToString())
            UsesDrugs = (Row("UsesDrugs").ToString())
            Emotions = (Row("Emotions").ToString())
            MaritalStatus = (Row("MaritalStatus").ToString())

        Next

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

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

        If FileUpload.FileName = "" Then
            savePath = URLOfPicture
        Else
            savePath = "http://www.unknownprotocol.us:8080/postimages/"
        End If

        'UNCPath = "C:\Inetpub\wwwroot\images\"

        'DataSource.UpdateParameters.Add("AbsolutePathToPicture", UNCPath + fileName)

        ' Before attempting to save the file, verify
        ' that the FileUpload control contains a file.
        If (FileUpload.HasFile) Then
            ' Call a helper method routine to save the file.
            SaveFile(FileUpload.PostedFile)

        End If


        If IDRelationship = ID And Session("Email") = EmailStatus Then

            If txtFirstName.Text = "" Then
                txtFirstName.Text = FirstName
            ElseIf txtFirstName.Text = "" Then
                txtFirstName.Text = FirstName
            End If

            If txtMiddleName.Text = "" Then
                txtMiddleName.Text = MiddleName
            ElseIf txtMiddleName.Text = "" Then
                txtMiddleName.Text = MiddleName
            End If

            If txtLastName.Text = "" Then
                txtLastName.Text = LastName
            ElseIf txtLastName.Text = "" Then
                txtLastName.Text = LastName
            End If

            If txtCountry.Text = "" Then
                txtCountry.Text = Country
            ElseIf txtCountry.Text = "" Then
                txtCountry.Text = Country
            End If

            If txtState.Text = "" Then
                txtState.Text = State
            ElseIf txtState.Text = "" Then
                txtState.Text = State
            End If

            If txtAddress.Text = "" Then
                txtAddress.Text = Address
            ElseIf txtAddress.Text = "" Then
                txtAddress.Text = Address
            End If

            If txtCity.Text = "" Then
                txtCity.Text = City
            ElseIf txtCity.Text = "" Then
                txtCity.Text = City
            End If

            If txtZipCode.Text = "" Then
                txtZipCode.Text = ZipCode
            ElseIf txtZipCode.Text = "" Then
                txtZipCode.Text = ZipCode
            End If

            If ddlCurrentAge.Text = "Select" Then
                ddlCurrentAge.Text = CurrentAge
            ElseIf ddlCurrentAge.Text = "Select" Then
                ddlCurrentAge.Text = CurrentAge
            End If

            If ddlGender.Text = "Select" Then
                ddlGender.Text = Gender
            ElseIf ddlGender.Text = "Select" Then
                ddlGender.Text = Gender
            End If

            If ddlHeightFeet.Text = "Select" Then
                ddlHeightFeet.Text = HeightFeet
            ElseIf ddlHeightFeet.Text = "Select" Then
                ddlHeightFeet.Text = HeightFeet
            End If

            If ddlHeightInches.Text = "Select" Then
                ddlHeightInches.Text = HeightInches
            ElseIf ddlHeightInches.Text = "Select" Then
                ddlHeightInches.Text = HeightInches
            End If

            If ddlWeightPounds.Text = "Select" Then
                ddlWeightPounds.Text = WeightPounds
            ElseIf ddlWeightPounds.Text = "Select" Then
                ddlWeightPounds.Text = WeightPounds
            End If

            If ddlWeightOunces.Text = "Select" Then
                ddlWeightOunces.Text = WeightOunces
            ElseIf ddlWeightOunces.Text = "Select" Then
                ddlWeightOunces.Text = WeightOunces
            End If

            If ddlHairColor.Text = "Select" Then
                ddlHairColor.Text = HairColor
            ElseIf ddlHairColor.Text = "Select" Then
                ddlHairColor.Text = HairColor
            End If

            If ddlEyeColor.Text = "Select" Then
                ddlEyeColor.Text = EyeColor
            ElseIf ddlEyeColor.Text = "Select" Then
                ddlEyeColor.Text = EyeColor
            End If

            If ddlDrinks.Text = "Select" Then
                ddlDrinks.Text = Drinks
            ElseIf ddlDrinks.Text = "Select" Then
                ddlDrinks.Text = Drinks
            End If

            If ddlSmokes.Text = "Select" Then
                ddlSmokes.Text = Smokes
            ElseIf ddlSmokes.Text = "select" Then
                ddlSmokes.Text = Smokes
            End If

            'If ddlUsesDrugs.Text = "Select" Then
            'ddlUsesDrugs.Text = UsesDrugs
            'ElseIf ddlUsesDrugs.Text = "select" Then
            'ddlUsesDrugs.Text = UsesDrugs
            'End If

            'If ddlEmotions.Text = "Select" Then
            'ddlEmotions.Text = Emotions
            'ElseIf ddlEmotions.Text = "Select" Then
            'ddlEmotions.Text = Emotions
            'End If

            If ddlMaritalStatus.Text = "Select" Then
                ddlMaritalStatus.Text = MaritalStatus
            ElseIf ddlMaritalStatus.Text = "Select" Then
                ddlMaritalStatus.Text = MaritalStatus
            End If

            RegisteredUpdate.UpdateParameters.Add("URLOfPicture", savePath + fileName)
            RegisteredUpdate.UpdateParameters.Add("RelationshipID", ID)
            RegisteredUpdate.UpdateParameters.Add("FirstName", txtFirstName.Text)
            RegisteredUpdate.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
            RegisteredUpdate.UpdateParameters.Add("LastName", txtLastName.Text)
            RegisteredUpdate.UpdateParameters.Add("Country", txtCountry.Text)
            RegisteredUpdate.UpdateParameters.Add("State", txtState.Text)
            RegisteredUpdate.UpdateParameters.Add("Address", txtAddress.Text)
            RegisteredUpdate.UpdateParameters.Add("City", txtCity.Text)
            RegisteredUpdate.UpdateParameters.Add("ZipCode", txtZipCode.Text)
            RegisteredUpdate.UpdateParameters.Add("CurrentAge", ddlCurrentAge.Text)
            RegisteredUpdate.UpdateParameters.Add("Gender", ddlGender.Text)
            RegisteredUpdate.UpdateParameters.Add("HeightFeet", ddlHeightFeet.Text)
            RegisteredUpdate.UpdateParameters.Add("HeightInches", ddlHeightInches.Text)
            RegisteredUpdate.UpdateParameters.Add("WeightPounds", ddlWeightPounds.Text)
            RegisteredUpdate.UpdateParameters.Add("WeightOunces", ddlWeightOunces.Text)
            RegisteredUpdate.UpdateParameters.Add("HairColor", ddlHairColor.Text)
            RegisteredUpdate.UpdateParameters.Add("EyeColor", ddlEyeColor.Text)
            RegisteredUpdate.UpdateParameters.Add("Drinks", ddlDrinks.Text)
            RegisteredUpdate.UpdateParameters.Add("Smokes", ddlSmokes.Text)
            'RegisteredUpdate.UpdateParameters.Add("UsesDrugs", ddlUsesDrugs.Text)
            RegisteredUpdate.UpdateParameters.Add("MaritalStatus", ddlMaritalStatus.Text)
            RegisteredUpdate.UpdateParameters.Add("Email", Email)
            RegisteredUpdate.UpdateParameters.Add("DateTime", Date.Now)
            RegisteredUpdate.Update()

            RegisteredUpdate1.UpdateParameters.Add("FirstName", txtFirstName.Text)
            RegisteredUpdate1.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
            RegisteredUpdate1.UpdateParameters.Add("LastName", txtLastName.Text)
            RegisteredUpdate1.UpdateParameters.Add("URLOfPicture", savePath + fileName)
            RegisteredUpdate1.Update()

            RegisteredUpdate2.UpdateParameters.Add("FirstName1", txtFirstName.Text)
            RegisteredUpdate2.UpdateParameters.Add("MiddleName1", txtMiddleName.Text)
            RegisteredUpdate2.UpdateParameters.Add("LastName1", txtLastName.Text)
            RegisteredUpdate2.UpdateParameters.Add("URLOfPicture", savePath + fileName)
            RegisteredUpdate2.Update()

            RegisteredUpdate3.UpdateParameters.Add("FirstName", txtFirstName.Text)
            RegisteredUpdate3.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
            RegisteredUpdate3.UpdateParameters.Add("LastName", txtLastName.Text)
            RegisteredUpdate3.UpdateParameters.Add("URLOfPicture", savePath + fileName)
            RegisteredUpdate3.Update()

            RegisteredUpdate4.UpdateParameters.Add("FirstName", txtFirstName.Text)
            RegisteredUpdate4.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
            RegisteredUpdate4.UpdateParameters.Add("LastName", txtLastName.Text)
            RegisteredUpdate4.UpdateParameters.Add("URLOfPicture", savePath + fileName)
            RegisteredUpdate4.Update()

        End If

        Response.Redirect("http://www.unknownprotocol.us:8080/userinformation.aspx?ID=" & ID)

    End Sub

    'Protected Sub btnGoBack_Click(sender As Object, e As System.EventArgs) Handles btnGoBack.Click

    'Response.Redirect("http://www.unknownprotocol.us:8080/test2.aspx?ID=" & ID)

    ' End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub
End Class
