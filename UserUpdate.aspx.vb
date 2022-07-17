Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration

Partial Class UserUpdate

    Inherits System.Web.UI.Page

    Protected Friend URLOfPicture As String
    Protected Friend UNCPath As String
    Protected Friend PathSaved As String
    Protected Friend Email As String
    Protected Friend DateTime As DateTime
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")

        'ID = CType(Session.Item("ID"), String)

        'Session("ID") = ID

        Email = CType(Session.Item("Email"), String)

        'Session("Email") = Email

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True

        End If

    End Sub

    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Select Case e.Item.Text
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & ID)
                Exit Select
        End Select
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\images\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        Dim tempfileName As String

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

    Protected Sub Connect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Connect.Click

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\images\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        Dim tempfileName As String

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

            savePath = "http://www.unknownprotocol.us:8080/images/Null.jpg"

        Else

            savePath = "http://www.unknownprotocol.us:8080/images/"


        End If

        ' Before attempting to save the file, verify
        ' that the FileUpload control contains a file.
        If (FileUpload.HasFile) Then
            ' Call a helper method routine to save the file.
            SaveFile(FileUpload.PostedFile)

        End If

        Dim Connection As SqlConnection = New SqlConnection("Data Source=D7BBFM83\DIGITALBDS;Initial Catalog=Registration;Integrated Security=True;uid=sa;password=1AbrianA1;")
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblUpdateRegistered", Connection)

        Dim DA As SqlDataAdapter = New SqlDataAdapter
        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblUpdateRegistered")
        Dim Row As DataRow

        For Each Row In DS.Tables("tblUpdateRegistered").Rows

        Next

        Connection.Close()

        If savePath + FileUpload.FileName = URLOfPicture Then
            lblAccess.Text = "File name is already in use."
            Response.Redirect("UserUpdate.aspx")
        End If

        RegUpdate.UpdateParameters.Add("PictureURL", savePath + fileName)
        RegUpdate.UpdateParameters.Add("URLOfPicture", savePath + fileName)
        RegUpdate.UpdateParameters.Add("DateTime", Now())
        RegUpdate.Update()

        RegisteredUpdate1.UpdateParameters.Add("URLOfPicture", savePath + fileName)
        RegisteredUpdate1.Update()

        RegisteredUpdate2.UpdateParameters.Add("URLOfPicture", savePath + fileName)
        RegisteredUpdate2.Update()

        RegisteredUpdate3.UpdateParameters.Add("URLOfPicture", savePath + fileName)
        RegisteredUpdate3.Update()

        RegisteredUpdate4.UpdateParameters.Add("URLOfPicture", savePath + fileName)
        RegisteredUpdate4.Update()

        Response.Redirect("http://www.unknownprotocol.us:8080/status.aspx?ID=" & ID)

    End Sub

    Protected Sub btnGoBack_Click(sender As Object, e As System.EventArgs) Handles btnGoBack.Click

        Response.Redirect("http://www.unknownprotocol.us:8080/status.aspx?ID=" & ID)

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub

End Class