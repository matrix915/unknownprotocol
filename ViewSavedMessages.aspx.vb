Imports System.Data.SqlClient
Imports System.Data

Public Class ViewSavedMessages
    Inherits System.Web.UI.Page

    Protected Email As String
    Protected MessageID As String
    Protected MessagesID As String
    Protected Status As String
    Protected RelationshipID As String
    Protected IDSS As Integer
    Protected VerifyEmail As String
    Protected PictureImage As String
    Protected Firstname As String
    Protected MiddleName As String
    Protected LastName As String
    Protected Relationship As String
    Protected RelationshipEmail As String
    Protected LoggedInEmail As String
    Protected SavedID As String
    Protected Messages As String
    Protected IDButton As String
    Protected IDControl As String

    Dim WithEvents btnSave As New Button
    Dim WithEvents btnDelete As New Button

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Email = CType(Session.Item("Email"), String)
        Session("Email") = Email

        ID = Request.QueryString("ID")
        Session("ID") = ID

        MessageID = Request.QueryString("MessageID")
        Session("MessageID") = MessageID

        Status = Request.QueryString("Status")
        Session("Status") = Status

        Dim MessageMailConnection As SqlConnection = New SqlConnection("Server=digitalbds\DIGITALBDS;database=Messages;uid=sa;password=1AbrianA1;")
        Dim MessageMailCmd As SqlDataAdapter = New SqlDataAdapter("Select ID, RelationshipID, URLOfPicture, FirstName, MiddleName, LastName, Messages from tblSavedMessages WHERE RelationshipID= '" & ID & "' And IDControl = '" & MessageID & "' And Email = '" & Email & "' Order By ID ", MessageMailConnection)
        Dim MessageMailds As New DataSet()
        MessageMailCmd.Fill(MessageMailds)
        ListView.DataSource = MessageMailds
        ListView.DataBind()
        MessageMailConnection.Close()

    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As CommandEventArgs) Handles btnDelete.Click

        Dim ButtonID As String = e.CommandArgument.ToString

        Dim DeleteMessageConnectionstring = "Server=digitalbds\DIGITALBDS;database=Messages;uid=sa;password=1AbrianA1;"
        Dim DeleteMessageConnection As New SqlConnection(DeleteMessageConnectionstring)
        Dim DeleteMessageConnectionDelete As String = "Delete tblSavedMessages " & _
        "WHERE ID = '" & ButtonID & "' "
        Dim DeleteMessageConnectionCmd As New SqlCommand(DeleteMessageConnectionDelete)
        DeleteMessageConnectionCmd.Connection = DeleteMessageConnection
        DeleteMessageConnection.Open()
        DeleteMessageConnectionCmd.ExecuteNonQuery()
        DeleteMessageConnection.Close()

    End Sub

End Class
