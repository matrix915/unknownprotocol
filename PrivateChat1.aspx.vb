Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Net.Security
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Drawing

Partial Class PrivateChat1
    Inherits System.Web.UI.Page


    Dim country As String
    Dim state As String
    Dim city As String
    Dim town As String
    Dim Emotions As String
    Dim Email As String

    'Dim WithEvents Timer1 As New Button
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Email = Session("Email")

        'country = Session("Country")
        'state = Session("State")
        'city = Session("City")
        'town = Session("Town")
        'Emotions = Session("Emotions")

        ID = Request.QueryString("ID")
        Session("ID") = ID
        'Email = Request.QueryString("Email")
        'Session("Email") = Email
        'country = Request.QueryString("country")
        'Session("country") = country
        'state = Request.QueryString("state")
        'Session("state") = state
        'city = Request.QueryString("city")
        'Session("city") = city
        'town = Request.QueryString("town")
        'Session("town") = town
        'Emotions = Request.QueryString("Emotions")
        'Session("Emotions") = Emotions

        'country = CType(Session.Item("country"), String)
        'Session("country") = Session("country")
        'state = CType(Session.Item("state"), String)
        'Session("state") = Session("state")
        'city = CType(Session.Item("city"), String)
        'Session("city") = Session("city")
        'town = CType(Session.Item("town"), String)
        'Session("town") = Session("town")
        'Emotions = CType(Session.Item("Emotions"), String)
        'Session("Emotions") = Session("Emotions")

        'If CType(Session.Item("ID"), String) = "" Then
        'Ronse.Redirect("http://localhost/logon.aspx")
        'End If

        Dim UserRegConnectionString = "Server=D7BBFM83\DIGITALBDS;database=Communication;uid=sa;password=1AbrianA1;"
        Dim UserRegConnection As New SqlConnection(UserRegConnectionString)
        Dim UserRegDelete As String = "Delete tblPrivateChat " &
        "WHERE DATEDIFF(second, DateTime, getdate()) > 120"
        Dim UserRegCommand As New SqlCommand(UserRegDelete)
        UserRegCommand.Connection = UserRegConnection
        UserRegConnection.Open()
        UserRegCommand.ExecuteNonQuery()
        UserRegCommand.Connection.Close()

        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", True)
        'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", True)

    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim SqlDataSource1 As SqlConnection = New SqlConnection("Server=D7BBFM83\DIGITALBDS;database=Communication;uid=sa;password=1AbrianA1;")
        Dim StreamCmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblPrivateChat  WHERE Email = '" & Email & "' ORDER BY CommunicationID", SqlDataSource1)
        Dim Streamds As New DataSet()
        StreamCmd.Fill(Streamds)

        ListView1.DataSource = Streamds
        ListView1.DataBind()

        SqlDataSource1.Close()

        ' WHERE countries = '" & country & "' And  states ='" & state & "' And cities ='" & city & "' And towns ='" & town & "' And Emotions ='" & Session("Emotions") & "' 
        'WHERE ID = '" & ID & "' And RelationshipEmail = '" & Email & "'
        'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", true);

    End Sub
End Class
