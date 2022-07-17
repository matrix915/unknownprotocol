Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Configuration

Partial Class PrivateChat
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

    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")
        Session("ID") = ID

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email

        'MessagesID = CType(Session.Item("MesasgesID"), String)
        'Session("MessagesID") = MessagesID

        'MessagesID = Request.QueryString("MessagesID")
        Session("MessagesID") = MessagesID

        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { document.getElementById('UpdatePanel1').scrollTo(0,10000); }, 1);", True)
        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
        Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
        Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
        ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
    End Sub

    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            MessagesID = (Row("ID").ToString())
        Next
        Connection.Close()

        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Contacts"
                Response.Redirect("~/status.aspx?ID=" & Session("ID"))
                Exit Select
        End Select
    End Sub

    'Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    '    Dim SqlDataSource2 As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)

    '    Dim OldChatDelete As String = "DELETE tblPrivateChat WHERE DATEDIFF(second, DateTime, getdate()) > 180"
    '    Dim OldChatDeleteCmd As New SqlCommand(OldChatDelete)
    '    OldChatDeleteCmd.Connection = SqlDataSource2
    '    SqlDataSource2.Open()
    '    OldChatDeleteCmd.ExecuteNonQuery()

    '    Dim StreamCmd As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM tblPrivateChat WHERE (IDControl='" & ID & "' AND MessagesID='" & MessagesID & "') OR (IDControl='" & MessagesID & "' AND MessagesID='" & ID & "') ORDER BY CommunicationID", SqlDataSource2)
    '    Dim Streamds As New DataSet()
    '    StreamCmd.Fill(Streamds)

    '    ListView1.DataSource = Streamds
    '    ListView1.DataBind()

    '    SqlDataSource2.Close()
    '    'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { document.getElementById('UpdatePanel1').scrollTo(0, document.getElementById('UpdatePanel1').offsetHeight); }, 1);", True)
    '    'WHERE ID = '" & ID & "' And RelationshipEmail = '" & Email & "'
    '    'WHERE country = '" & "Unitedstates" & "'
    'End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function GetMessage(ByVal rowID As String, ByVal ID As String, ByVal MessagesID As String) As String
        Dim response As String = ""
        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource2").ConnectionString)

        Dim OldChatDelete As String = "DELETE tblPrivateChat WHERE DATEDIFF(second, DateTime, getdate()) > 180"
        Dim OldChatDeleteCmd As New SqlCommand(OldChatDelete)
        OldChatDeleteCmd.Connection = Connection
        Connection.Open()
        OldChatDeleteCmd.ExecuteNonQuery()

        Dim Cmd As SqlCommand = New SqlCommand(
            "SELECT * FROM tblPrivateChat WHERE ((IDControl='" & ID & "' AND MessagesID='" & MessagesID & "') OR (IDControl='" & MessagesID & "' AND MessagesID='" & ID & "'))" &
            " AND CommunicationID > '" & rowID & "' ORDER BY CommunicationID",
            Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()
        DA.SelectCommand = Cmd
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblPrivateChat")

        Dim Row As DataRow
        For Each Row In DS.Tables("tblPrivateChat").Rows
            rowID = (Row("CommunicationID").ToString())

            response &= "<b><a href='/default.aspx?ID=" & (Row("IDControl")) & "'><span>" & (Row("FirstName").ToString()) & " </span>" &
                "<span>" & (Row("MiddleName").ToString()) & " </span>" &
                "<span>" & (Row("LastName").ToString()) & "</span></a></b>" &
                "<br/>"

            Dim URLOfPicture = (Row("URLOfPicture").ToString())
            If URLOfPicture <> "" Then
                Dim exts As String() = URLOfPicture.Split(New Char() {"."c})
                Dim ext As String
                For Each word As String In exts
                    ext = word
                Next
                ext = ext.ToLower()
                If ext = "jpg" Or ext = "jpeg" Or ext = "png" Or ext = "gif" Then
                    response &= "<img src='" & URLOfPicture & "' style='height:50px;width:50px;' />"
                ElseIf ext = "flv" Or ext = "avi" Or ext = "mov" Or ext = "mpg" Or ext = "wmv" Or ext = "m4v" Or ext = "mp3" Or ext = "wma" Or ext = "3gp" Then
                    response &= "<video width='320' height='240' muted><source src='" & URLOfPicture & "' type='video/mp4'></video>"
                End If
            End If

            response &= "<br/><div class='a'><span style='font-size:16px;'>" & (Row("Messages").ToString()) & "</span></div><br/><hr/><br/>"
        Next
        Connection.Close()
        Return rowID & "##" & response
    End Function

    Sub SaveFile(ByVal file As HttpPostedFile, ByVal fileName As String)

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\privateimages\"

        ' Append the name of the file to upload to the path.
        savePath += fileName

        ' Call the SaveAs method to save the uploaded
        ' file to the specified directory.
        FileUpload.SaveAs(savePath)
    End Sub

    Protected Sub Send_Click(sender As Object, e As System.EventArgs) Handles Send.Click

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
            'URLOfPicture = (Row("URLOfPicture").ToString())
            LoggedInEmail = (Row("Email").ToString())
            MessagesID = (Row("ID").ToString())
        Next
        Connection.Close()

        ' Specify the path to save the uploaded file to.
        Dim savePath As String = "C:\Inetpub\wwwroot\privateimages\"

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
            fileName = "http://www.unknownprotocol.us:8080/privateimages/" + fileName
        Else
            fileName = ""

        End If

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

        SqlDataSource1.InsertParameters.Add("IDControl", MessagesID)
        SqlDataSource1.InsertParameters.Add("MessagesID", ID)
        SqlDataSource1.InsertParameters.Add("Messages", Posted.Text)
        SqlDataSource1.InsertParameters.Add("URLOfPicture", fileName)
        SqlDataSource1.InsertParameters.Add("FirstName", Firstname)
        SqlDataSource1.InsertParameters.Add("MiddleName", MiddleName)
        SqlDataSource1.InsertParameters.Add("LastName", LastName)
        SqlDataSource1.InsertParameters.Add("Email", RelationshipEmail)
        SqlDataSource1.InsertParameters.Add("RelationshipEmail", LoggedInEmail)
        SqlDataSource1.InsertParameters.Add("FollowUnFollow", "Follow")
        SqlDataSource1.InsertParameters.Add("DateTime", Date.Now)


        SqlDataSource1.Insert()

        'Response.Redirect("http://www.unknownprotocol.us:8080/status.aspx?ID=" & ID)

        ' ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "close", "window.close();", True)

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)
    End Sub
End Class
