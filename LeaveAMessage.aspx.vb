Imports System.Data.SqlClient
Imports System.Data

Partial Class LeaveAMessage
    Inherits System.Web.UI.Page

    Protected Firstname As String
    Protected MiddleName As String
    Protected LastName As String
    Protected DateTime As String
    Protected IDEmail As String
    Protected LoggedInEmail As String
    Protected Email As String
    Protected MessagesID As String
    Protected IDMessages As String
    Protected RelationshipEmail As String
    Protected RelationshipID As String
    Protected URLOfPicture As String
    Protected PictureURL As String
    Protected IDExchange As String

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")
        Session("ID") = ID

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email

        'MessagesID = CType(Session.Item("MesasgesID"), String)
        'Session("MessagesID") = MessagesID

        MessagesID = Request.QueryString("MessagesID")
        Session("MessagesID") = MessagesID

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True

        End If


    End Sub
    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Dim UserNameConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim UserNameCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Session("Email") & "'", UserNameConnection)

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

    Protected Sub Send_Click(sender As Object, e As System.EventArgs) Handles Send.Click

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\postimages\"

        ' Get the name of the file to upload.
        Dim fileName As String = FileUpload.FileName

        ' Create the path and file name to check for duplicates.
        Dim pathToCheck As String = savePath + fileName

        ' Create a temporary file name to use for checking duplicates.
        'Dim tempfileName As String
        'tempfileName = ""
        ' Check to see if a file already exists with the
        ' same name as the file to upload.        
        'If (System.IO.File.Exists(pathToCheck)) Then
        'Dim counter As Integer = 1
        'While (System.IO.File.Exists(pathToCheck))
        ' If a file with this name already exists,
        ' prefix the filename with a number.
        'tempfileName = counter.ToString() + fileName
        'pathToCheck = savePath + tempfileName
        'counter = counter + 1
        'End While

        'fileName = tempfileName

        'End If

        ' Append the name of the file to upload to the path.
        savePath += fileName

        If FileUpload.FileName = "" Then

            savePath = "http://www.unknownprotocol.us:8080/postimages/Null.jpg"

        Else

            savePath = "http://www.unknownprotocol.us:8080/postimages/"


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


            RelationshipID = (Row("ID").ToString())
            Firstname = (Row("FirstName").ToString())
            MiddleName = (Row("MiddleName").ToString())
            LastName = (Row("LastName").ToString())
            URLOfPicture = (Row("URLOfPicture").ToString())
            LoggedInEmail = (Row("Email").ToString())
            MessagesID = (Row("ID").ToString())

            Connection.Close()

            Dim AddUserConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            Dim AddUserCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", AddUserConnection)
            Dim AddUserDA As SqlDataAdapter = New SqlDataAdapter()

            AddUserDA.SelectCommand = AddUserCmd
            AddUserConnection.Open()
            Dim AddUserDS As DataSet = New DataSet()
            AddUserDA.Fill(AddUserDS, "tblRegistered")
            Dim AddUserRow As DataRow

            For Each AddUserRow In AddUserDS.Tables("tblRegistered").Rows

                'URLOfPicture = (AddUserRow("URLOfPicture").ToString())
                RelationshipEmail = (AddUserRow("Email").ToString())
                IDEmail = (AddUserRow("Email").ToString())

            Next

            AddUserConnection.Close()

            If txtMessage.Text <> "" Then

                Messages.InsertParameters.Add("IDControl", MessagesID)
                Messages.InsertParameters.Add("MessagesID", ID)
                Messages.InsertParameters.Add("URLOfPicture", savePath + fileName)
                Messages.InsertParameters.Add("FirstName", Firstname)
                Messages.InsertParameters.Add("MiddleName", MiddleName)
                Messages.InsertParameters.Add("LastName", LastName)
                Messages.InsertParameters.Add("Email", RelationshipEmail)
                Messages.InsertParameters.Add("RelationshipEmail", LoggedInEmail)
                Messages.InsertParameters.Add("FollowUnFollow", "Follow")
                Messages.InsertParameters.Add("DateTime", Date.Now)


                Messages.Insert()

            End If

        Next

        Response.Redirect("http://www.unknownprotocol.us:8080/default.aspx?ID=" & ID)

        ' ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "close", "window.close();", True)

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub

End Class
