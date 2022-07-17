Imports System.Data.SqlClient
Imports System.Data

Partial Class ViewBroadcastMessages
    Inherits System.Web.UI.Page

    Protected MessagesID As String
    Protected Email As String
    Protected LoggedInEmail As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")
        Session("ID") = ID

        MessagesID = Request.QueryString("MessagesID")
        Session("MessagesID") = MessagesID

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email



        Dim Connection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Registration;uid=sa;password=1AbrianA1;")
        Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & ID & "'", Connection)
        Dim DA As SqlDataAdapter = New SqlDataAdapter()

        DA.SelectCommand = Cmd
        Connection.Open()
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS, "tblRegistered")
        Dim Row As DataRow
        For Each Row In DS.Tables("tblRegistered").Rows

            LoggedInEmail = (Row("Email").ToString())

        Next

        Connection.Close()


        If Email = LoggedInEmail And ID = ID Then


            Dim MessageMailConnection As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Messages;uid=sa;password=1AbrianA1;")
            Dim MessageMailCmd As SqlDataAdapter = New SqlDataAdapter("Select * FROM tblMessages WHERE IDControl = '" & ID & "' And MessagesID ='" & ID & "'  ORDER BY ID", MessageMailConnection)
            Dim MessageMailds As New DataSet()
            MessageMailCmd.Fill(MessageMailds)
            ListView.DataSource = MessageMailds
            ListView.DataBind()
            MessageMailConnection.Close()

            Dim DeleteMessageConnectionstring = "Server=D7BBFM83\DIGITALBDS;database=Messages;uid=sa;password=1AbrianA1;"
            Dim DeleteMessageConnection As New SqlConnection(DeleteMessageConnectionstring)
            Dim DeleteMessageConnectionDelete As String = "Delete tblMessages " & _
            "WHERE DATEDIFF(day, DateTime, getdate()) > 30 And Email = '" & Email & "' "
            Dim DeleteMessageConnectionCmd As New SqlCommand(DeleteMessageConnectionDelete)
            DeleteMessageConnectionCmd.Connection = DeleteMessageConnection
            DeleteMessageConnection.Open()
            DeleteMessageConnectionCmd.ExecuteNonQuery()
            DeleteMessageConnection.Close()
        End If
    End Sub

    Protected Sub btnClose_Click(sender As Object, e As System.EventArgs) Handles btnClose.Click

        ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "close", "window.close();", True)

    End Sub
End Class
