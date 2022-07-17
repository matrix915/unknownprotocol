Imports System.Data
Imports System.Data.SqlClient
Partial Class WomenDateing

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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        IDS = Request.QueryString("IDS")

        Email = CType(Session.Item("Email"), String)

        Session("Email") = Email

        CUPID = txtCUPID.Text

        Session("CUPID") = CUPID

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = False
            NavigationMenu.Items.Item(3).Enabled = False
            NavigationMenu.Items.Item(4).Enabled = False
            NavigationMenu.Items.Item(5).Enabled = False
            NavigationMenu.Items.Item(6).Enabled = False
        End If

        ' Load sample data only once, when the page is first loaded.
        If Not IsPostBack Then
            ItemsGrid.DataSource = DataSource()
            ItemsGrid.DataBind()
        End If

    End Sub

    Function DataSource() As ICollection
        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegisteredUsers  WHERE Relationships = '" & "WomenDateing" & "'", Connection)
        Dim nDt As DataTable = New DataTable()
        Cmd.Fill(nDt)

        ' Populate the table with sample values.
        ItemsGrid.DataSource = nDt
        ItemsGrid.DataBind()

        Dim dv As DataView = New DataView(nDt)
        Return dv

        Connection.Close()

    End Function

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

    Sub Grid_Change(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs)
        ' For the DataGrid control to navigate to the correct page when
        ' paging is allowed, the CurrentPageIndex property must be updated
        ' programmatically. This process is usually accomplished in the
        ' event-handling method for the PageIndexChanged event.

        ' Set CurrentPageIndex to the page the user clicked.
        ItemsGrid.CurrentPageIndex = e.NewPageIndex

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = DataSource()
        ItemsGrid.DataBind()
    End Sub

    Protected Sub btnLNSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNSearch.Click

        LN = txtLastName.Text

        Dim RegistrationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblregistered WHERE LastName = '" & LN & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblregistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblregistered").Rows

            Lastname = (Row("Lastname").ToString())

            If LN = Lastname Then
                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
                Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblregistered WHERE LastName = '" & LN & "'", Connection)
                Dim nDt As DataTable = New DataTable()
                Cmd.Fill(nDt)

                ' Populate the table with sample values.
                ItemsGrid.DataSource = nDt
                ItemsGrid.DataBind()
            End If
        Next


    End Sub

    Protected Sub btnLNReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNReset.Click

        txtLastName.Text = ""

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = DataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnIDReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIDReset.Click

        txtCUPID.Text = ""

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = DataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnIDSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIDSearch.Click

        Dim RegistrationConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblregistered WHERE ID = '" & CUPID & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblregistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblregistered").Rows

            CUPID = (Row("ID").ToString())


            Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
            Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblregistered WHERE ID = '" & CUPID & "'", Connection)
            Dim nDt As DataTable = New DataTable()
            Cmd.Fill(nDt)

            ' Populate the table with sample values.
            ItemsGrid.DataSource = nDt
            ItemsGrid.DataBind()

        Next

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.briandalesinger.me:8080/logon.aspx", True)

    End Sub

End Class