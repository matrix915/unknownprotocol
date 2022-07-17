Imports System.Data
Imports System.Data.SqlClient

Partial Class MixAndMingle

    Inherits System.Web.UI.Page

    Protected FirstName As String
    Protected FN As String
    Protected Lastname As String
    Protected LN As String
    Protected FNLN As String
    Protected LNFN As String
    Protected FName As String
    Protected LName As String
    Protected Email As String
    Protected IDS As String
    Protected Post As String
    Protected ChatID As String
    Protected DateTime As String
    Protected test As String
    Protected ChatEmail As String
    Protected CUPID As String
    Protected SearchID As String
    Protected SearchCondition As String = ""
    Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = Request.QueryString("ID")

        IDS = Request.QueryString("IDS")

        Email = CType(Session.Item("Email"), String)

        'Session("Email") = Email

        CUPID = txtCUPID.Text

        Session("CUPID") = CUPID

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True
        End If

        ' Load sample data only once, when the page is first loaded.
        If Not IsPostBack Then
            ItemsGrid.DataSource = CreateDataSource()
            ItemsGrid.DataBind()
        End If

    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & Session("ID"))
                Exit Select
            Case "Contacts"
                Response.Redirect("~/contact.aspx?ID=" & Session("ID"))
                Exit Select
        End Select
    End Sub

    Function CreateDataSource() As ICollection

        ID = Session("ID")
        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblMixMingleUsers WHERE (UserID = '" & ID & "' OR PutUserID = '" & ID & "') " & SearchCondition, Connection)
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


    'Sub Check_Change(ByVal sender As Object, ByVal e As EventArgs)
    ' Allow or prevent paging depending on the user's selection.
    'ItemsGrid.AllowPaging = AllowPagingCheckBox.Checked()

    'If AllowPagingCheckBox.Checked Then
    'ItemsGrid.PagerStyle.Mode = PagerMode.NumericPages
    'Else
    'ItemsGrid.PagerStyle.Mode = PagerMode.NextPrev
    'End If

    ' Rebind the data to refresh the DataGrid control. 
    'ItemsGrid.DataSource = CreateDataSource()
    'ItemsGrid.DataBind()
    'End Sub

    'Sub Grid_Change(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs)
    ' For the DataGrid control to navigate to the correct page when
    ' paging is allowed, the CurrentPageIndex property must be updated
    ' programmatically. This process is usually accomplished in the
    ' event-handling method for the PageIndexChanged event.

    ' Set CurrentPageIndex to the page the user clicked.
    ' ItemsGrid.CurrentPageIndex = e.NewPageIndex

    ' Rebind the data to refresh the DataGrid control. 
    ' ItemsGrid.DataSource = DataSource()
    ' ItemsGrid.DataBind()
    ' End Sub

    Protected Sub btnLNSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNSearch.Click

        LN = txtLastName.Text

        SearchCondition = "AND LName = '" & LN & "'"


        ItemsGrid.CurrentPageIndex = 0

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()


    End Sub

    Protected Sub btnLNReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNReset.Click
        SearchCondition = ""
        txtLastName.Text = ""

        ItemsGrid.CurrentPageIndex = 0
        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnIDReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIDReset.Click
        SearchCondition = ""
        txtCUPID.Text = ""

        ItemsGrid.CurrentPageIndex = 0
        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    ' Protected Sub btnIDSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIDSearch.Click

    'Dim RegistrationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
    'Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblregisteredUsers WHERE ID = '" & CUPID & "'", RegistrationConnection)

    'Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
    ' RegistrationDA.SelectCommand = RegistrationCmd
    ' RegistrationConnection.Open()
    'Dim RegistrationDS As DataSet = New DataSet()
    'RegistrationDA.Fill(RegistrationDS, "tblregisteredUsers")
    'Dim Row As DataRow

    'For Each Row In RegistrationDS.Tables("tblregisteredUsers").Rows

    'CUPID = (Row("ID").ToString())


    'Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
    'Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblregisteredUsers WHERE ID = '" & CUPID & "'", Connection)
    'Dim nDt As DataTable = New DataTable()
    'Cmd.Fill(nDt)

    ' Populate the table with sample values.
    'ItemsGrid.DataSource = nDt
    'ItemsGrid.DataBind()

    'Next

    'End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.us:8080/logon.aspx", True)

    End Sub


    Protected Sub btnIDSearch_Click(sender As Object, e As EventArgs) Handles btnIDSearch.Click
        SearchCondition = "AND PutUserID = '" & txtCUPID.Text & "'"

        ItemsGrid.CurrentPageIndex = 0

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()


    End Sub
End Class