Imports System.Data.SqlClient
Imports System.Data

Partial Class test1
    Inherits System.Web.UI.Page

    Protected DateTime As String
    Protected UNCPath As String
    Protected Relationship As String
    Protected Email As String
    Protected StatusID As String
    Protected RelationshipID As String
    Protected RelationshipEmail As String
    Protected FirstName As String
    Protected MiddleName As String
    Protected LastName As String
    Protected ZipCode As String
    Protected WriteEmail As String
    Protected URLOFPicture As String
    Protected UpdateID As String


    Dim WithEvents Insert As New Button
    Dim WithEvents LinkButton As New LinkButton
    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

      
        ID = Request.QueryString("ID")
        'Session("ID") = ID

        Email = CType(Session.Item("Email"), String)
        'Session("Email") = Email

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
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In DS.Tables("tblRegistered").Rows

            URLOFPicture = (Row("URLofPicture").ToString())

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

        ' Before attempting to save the file, verify
        ' that the FileUpload control contains a file.
        If (FileUpload.HasFile) Then
            ' Call a helper method routine to save the file.
            SaveFile(FileUpload.PostedFile)

        End If

        Dim UpdateConnection As SqlConnection = New SqlConnection("Data Source=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;Initial Catalog=Registration;Integrated Security=True;uid=sa;password=1A@brian@A1;")
        Dim UpdateCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", UpdateConnection)

        Dim UpdateDA As SqlDataAdapter = New SqlDataAdapter
        UpdateDA.SelectCommand = UpdateCmd
        UpdateConnection.Open()
        Dim UpdateDS As DataSet = New DataSet()
        UpdateDA.Fill(UpdateDS, "tblregistered")
        Dim UpdateRow As DataRow

        For Each UpdateRow In UpdateDS.Tables("tblregistered").Rows

            UpdateID = (UpdateRow("ID").ToString())
            FirstName = (UpdateRow("FirstName").ToString())
            MiddleName = (UpdateRow("MiddleName").ToString())
            LastName = (UpdateRow("LastName").ToString())
            StatusID = (UpdateRow("ID").ToString())
            WriteEmail = (UpdateRow("Email").ToString())

            Connection.Close()

            Dim RelationshipConnection As SqlConnection = New SqlConnection("Data Source=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;Initial Catalog=Registration;Integrated Security=True;uid=sa;password=1A@brian@A1;")
            Dim RelationshipCmd As SqlCommand = New SqlCommand("Select * from tblUpdateRegistered  WHERE RelationshipID = '" & ID & "'", RelationshipConnection)

            Dim RelationshipDA As SqlDataAdapter = New SqlDataAdapter
            RelationshipDA.SelectCommand = RelationshipCmd
            RelationshipConnection.Open()
            Dim RelationshipDS As DataSet = New DataSet()
            RelationshipDA.Fill(RelationshipDS, "tblUpdateRegistered")
            Dim RelationshipRow As DataRow

            For Each RelationshipRow In RelationshipDS.Tables("tblUpdateRegistered").Rows

                RelationshipID = (RelationshipRow("RelationshipID").ToString())
                RelationshipEmail = (RelationshipRow("Email").ToString())

            Next

            RelationshipConnection.Close()

            If ID = RelationshipID Then

                lblExists.Text = "Record Already Exists"

            ElseIf ID = UpdateID Then

                RegisteredInsert.InsertParameters.Add("URLOfPicture", savePath + fileName)

                RegisteredInsert.InsertParameters.Add("RelationshipID", ID)

                RegisteredInsert.InsertParameters.Add("FirstName", FirstName)

                RegisteredInsert.InsertParameters.Add("MiddleName", MiddleName)

                RegisteredInsert.InsertParameters.Add("LastName", LastName)

                RegisteredInsert.InsertParameters.Add("Associations", Relationship)
                'RegisteredInsert.InsertParameters.Add("Emotions", ddlEmotions.Text)
                RegisteredInsert.InsertParameters.Add("Email", Session("Email"))
                RegisteredInsert.InsertParameters.Add("DateTime", Date.Now)
                RegisteredInsert.Insert()

                'RegisteredUpdate1.UpdateParameters.Add("FirstName", txtFirstName.Text)
                'RegisteredUpdate1.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
                'RegisteredUpdate1.UpdateParameters.Add("LastName", txtLastName.Text)
                RegisteredUpdate1.UpdateParameters.Add("URLOfPicture", savePath + fileName)
                RegisteredUpdate1.Update()

                'RegisteredUpdate2.UpdateParameters.Add("FirstName", txtFirstName.Text)
                'RegisteredUpdate2.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
                'RegisteredUpdate2.UpdateParameters.Add("LastName", txtLastName.Text)
                RegisteredUpdate2.UpdateParameters.Add("URLOfPicture", savePath + fileName)
                RegisteredUpdate2.Update()

                'RegisteredUpdate3.UpdateParameters.Add("FirstName", txtFirstName.Text)
                'RegisteredUpdate3.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
                'RegisteredUpdate3.UpdateParameters.Add("LastName", txtLastName.Text)
                RegisteredUpdate3.UpdateParameters.Add("URLOfPicture", savePath + fileName)
                'RegisteredUpdate3.UpdateParameters.Add("Emotions", ddlEmotions.Text)
                RegisteredUpdate3.Update()

                'RegisteredUpdate4.UpdateParameters.Add("FirstName", txtFirstName.Text)
                'RegisteredUpdate4.UpdateParameters.Add("MiddleName", txtMiddleName.Text)
                'RegisteredUpdate4.UpdateParameters.Add("LastName", txtLastName.Text)
                RegisteredUpdate4.UpdateParameters.Add("URLOfPicture", savePath + fileName)
                RegisteredUpdate4.Update()

            End If

            Response.Redirect("http://www.unknownprotocol.us:8080/default.aspx?ID=" & ID)

        Next
    End Sub

    Protected Sub btnGoBack_Click(sender As Object, e As System.EventArgs) Handles btnGoBack.Click

        Response.Redirect("http://www.unknownprotocol.us:8080/default.aspx?ID=" & ID)

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub

End Class
