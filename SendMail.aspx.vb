Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Configuration
Imports System.Web.Configuration

Partial Class SendMail

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Determining the Session Timout from the Web.config file
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
            If Not Me.IsPostBack Then
                Session("Reset") = True
                Dim config As Configuration = WebConfigurationManager.OpenWebConfiguration("~/Web.config")
                Dim section As SessionStateSection = DirectCast(config.GetSection("system.web/sessionState"), SessionStateSection)
                Dim timeout As Integer = CInt(section.Timeout.TotalSeconds) * 1000
                ClientScript.RegisterStartupScript(Me.GetType(), "SessionAlert", "SessionExpire(" & timeout & ");", True)
            End If

            'Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            'Dim Cmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE Email = '" & Email & "' ", Connection)
            'Dim DA As SqlDataAdapter = New SqlDataAdapter()

            'DA.SelectCommand = Cmd
            'Connection.Open()
            'Dim DS As DataSet = New DataSet()
            'DA.Fill(DS, "tblRegistered")
            'Dim Row As DataRow
            'For Each Row In DS.Tables("tblRegistered").Rows

            'RedirectID = (Row("ID").ToString())

            'Next

            'Connection.Close()

            ' Load sample data only once, when the page is first loaded.
            If Not IsPostBack Then
                ItemsGrid.DataSource = CreateDataSource()
                ItemsGrid.DataBind()
            End If

        End Sub

    Function CreateDataSource() As ICollection
        Dim CurrID = Session("ID")
        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        ' query for filtering 
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select R.FirstName AS FirstName, R.MiddleName AS MiddleName, R.LastName AS LastName, R.ID AS ID, R.URLOfPicture AS URLOfPicture from tblRegisteredUsers AS U JOIN tblRegistered AS R ON U.ID = R.ID WHERE U.RelationshipID = '" & CurrID & "' AND U.Approved='0'", Connection)
        'Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select R.FirstName AS FirstName, R.MiddleName AS MiddleName, R.LastName AS LastName, R.ID AS ID, R.URLOfPicture AS URLOfPicture from tblRegisteredUsers AS U JOIN tblRegistered AS R ON U.RelationshipID = R.ID WHERE U.ID = '" & CurrID & "'", Connection)
        Dim Dt As DataTable = New DataTable()
        Cmd.Fill(Dt)

        Connection.Open()

        ' Populate the table with sample values.
        ItemsGrid.DataSource = Dt
        ItemsGrid.DataBind()

        Dim dv As DataView = New DataView(Dt)
        Return dv

        Cmd.Dispose()
        Connection.Close()
        Connection.Dispose()
        SqlConnection.ClearAllPools()
    End Function

    Protected Sub ItemsGrid_PageIndexChanged(source As Object, e As DataGridPageChangedEventArgs) Handles ItemsGrid.PageIndexChanged
        ' Set CurrentPageIndex to the page the user clicked.
        ItemsGrid.CurrentPageIndex = e.NewPageIndex

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()
    End Sub
    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Contacts"
                Response.Redirect("~/status.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Delete Contact"
                Response.Redirect("~/deletecontact.aspx?ID=" & Session("ID"))
                Exit Select
        End Select
    End Sub

    Protected Sub ItemsGrid_ItemCommand(ByVal source As Object, ByVal e As DataGridCommandEventArgs) Handles ItemsGrid.ItemCommand
        Dim CurrID As String = Session("ID")
        Dim RelationshipID As String = e.Item.Cells(5).Text
        Dim ApproveValue As Integer = 0

        If e.CommandName = "Approved" Then
            ApproveValue = 1
        ElseIf e.CommandName = "Disapproved" Then
            ApproveValue = 2
        End If

        SqlDataSource1.UpdateParameters.Clear()
        SqlDataSource1.UpdateParameters.Add("Approved", ApproveValue)
        SqlDataSource1.UpdateParameters.Add("ID", RelationshipID)
        SqlDataSource1.UpdateParameters.Add("RelationshipID", CurrID)
        SqlDataSource1.Update()


        Response.Redirect("~/default.aspx?ID=" & CurrID)

    End Sub
    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("~/logon.aspx", True)

    End Sub

End Class