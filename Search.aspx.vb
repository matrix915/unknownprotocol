Imports System.Data
Imports System.Data.SqlClient

Partial Class Search

    Inherits System.Web.UI.Page

    Protected FirstName As String
    Protected FN As String
    Protected Lastname As String
    Protected LN As String
    Protected CupidID As String
    Protected Email As String

    'Dim WithEvents Menu1 As New Menu

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = True
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
            NavigationMenu.Items.Item(6).Enabled = True

        End If

        Lastname = Request.QueryString("LastName")

        ID = Request.QueryString("ID")

        'Session("ID") = ID

        Email = CType(Session.Item("Email"), String)

        'Session("Email") = Email

        ' Load sample data only once, when the page is first loaded.
        If Not IsPostBack Then
            ItemsGrid.DataSource = CreateDataSource()
            ItemsGrid.DataBind()
        End If

        'Variable for chat image
        ' ID = CType(Session.Item("ID"), String)

        'Load sample data only once, when the page is first loaded.
        'If Not IsPostBack Then
        'ItemsGrid.DataSource = FirstnameDataSource()
        'ItemsGrid.DataBind()
        ' End If

    End Sub


    Protected Sub NavigationMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Select Case e.Item.Value
            Case "Home"
                Response.Redirect("~/default.aspx?ID=" & ID)
                Exit Select
            Case "Contacts"
                Response.Redirect("~/contact.aspx?ID=" & ID)
                Exit Select
            Case "Delete User"
                Response.Redirect("~/deleteuser.aspx?ID=" & ID)
                Exit Select
        End Select
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

    Sub Grid_Change(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs)
        ' For the DataGrid control to navigate to the correct page when
        ' paging is allowed, the CurrentPageIndex property must be updated
        ' programmatically. This process is usually accomplished in the
        ' event-handling method for the PageIndexChanged event.

        ' Set CurrentPageIndex to the page the user clicked.
        ItemsGrid.CurrentPageIndex = e.NewPageIndex

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    Function CreateDataSource() As ICollection

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE LastName = '" & Lastname & "'", Connection)
        Dim Dt As DataTable = New DataTable()
        Cmd.Fill(Dt)

        ' Populate the table with sample values.
        ItemsGrid.DataSource = Dt
        ItemsGrid.DataBind()

        Dim dv As DataView = New DataView(Dt)
        Return dv

    End Function

    Protected Sub ItemsGrid_SelectedIndexChanged(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs) Handles ItemsGrid.SelectedIndexChanged

        ' For the DataGrid control to navigate to the correct page when
        ' paging is allowed, the CurrentPageIndex property must be updated
        ' programmatically. This process is usually accomplished in the
        ' event-handling method for the PageIndexChanged event.

        ' Set CurrentPageIndex to the page the user clicked.
        ItemsGrid.CurrentPageIndex = e.NewPageIndex

        ' Rebind the data to refresh the DataGrid control. 
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnSoonerSearch_Click(sender As Object, e As EventArgs) Handles btnSoonerSearch.Click

        CupidID = txtcupid.Text

        Dim RegistrationConnection As SqlConnection = New SqlConnection("Server=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;uid=sa;password=1A@brian@A1;database=Registration;")
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE ID = '" & CupidID & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblRegistered").Rows

            CupidID = (Row("ID").ToString())

            If CupidID = CupidID Then
                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
                Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE ID = '" & CupidID & "'", Connection)
                Dim nDt As DataTable = New DataTable()
                Cmd.Fill(nDt)

                ' Populate the table with sample values.
                ItemsGrid.DataSource = nDt
                ItemsGrid.DataBind()
            End If
        Next

        RegistrationConnection.Close

    End Sub
    Protected Sub btnLNSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNSearch.Click

        LN = txtLastName.Text

        Dim RegistrationConnection As SqlConnection = New SqlConnection("Server=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;uid=sa;password=1A@brian@A1;database=Registration;")
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE LastName = '" & LN & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblRegistered").Rows

            Lastname = (Row("Lastname").ToString())

            If LN = Lastname Then
                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
                Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE LastName = '" & LN & "'", Connection)
                Dim nDt As DataTable = New DataTable()
                Cmd.Fill(nDt)

                ' Populate the table with sample values.
                ItemsGrid.DataSource = nDt
                ItemsGrid.DataBind()
            End If
        Next

        RegistrationConnection.Close

    End Sub

    Protected Sub btnFNSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFNSearch.Click

        FN = txtFirstName.Text

        Dim RegistrationConnection As SqlConnection = New SqlConnection("Server=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;uid=sa;password=1A@brian@A1;database=Registration;")
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE FirstName = '" & FN & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblRegistered").Rows

            FirstName = (Row("Firstname").ToString())

            If FN = FirstName Then
                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
                Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE FirstName = '" & FN & "'", Connection)
                Dim nDt As DataTable = New DataTable()
                Cmd.Fill(nDt)

                ' Populate the table with sample values.
                ItemsGrid.DataSource = nDt
                ItemsGrid.DataBind()
            End If
        Next

    End Sub

    Protected Sub btnFNLNSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFNLNSearch.Click

        FN = txtFNLN.Text
        LN = txtLNFN.Text

        Dim RegistrationConnection As SqlConnection = New SqlConnection("Server=WIN-CKMGSD9EMJT\UNKNOWNPROTOCOL;uid=sa;password=1A@brian@A1;database=Registration;")
        Dim RegistrationCmd As SqlCommand = New SqlCommand("Select * from tblRegistered WHERE FirstName = '" & FN & "'", RegistrationConnection)

        Dim RegistrationDA As SqlDataAdapter = New SqlDataAdapter
        RegistrationDA.SelectCommand = RegistrationCmd
        RegistrationConnection.Open()
        Dim RegistrationDS As DataSet = New DataSet()
        RegistrationDA.Fill(RegistrationDS, "tblRegistered")
        Dim Row As DataRow

        For Each Row In RegistrationDS.Tables("tblRegistered").Rows

            FirstName = (Row("Firstname").ToString())
            Lastname = (Row("Lastname").ToString())

            If FN = FirstName And LN = Lastname Then
                Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
                Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered WHERE FirstName = '" & FN & "'", Connection)
                Dim nDt As DataTable = New DataTable()
                Cmd.Fill(nDt)

                ' Populate the table with sample values.
                ItemsGrid.DataSource = nDt
                ItemsGrid.DataBind()
            End If
        Next

        RegistrationConnection.Close

    End Sub
    Protected Sub btnResetSC_Click(sender As Object, e As EventArgs) Handles btnResetSC.Click

        txtcupid.Text = ""

        ' Rebind the data to refresh the DataGrid control.
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnLNReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLNReset.Click


        txtLastName.Text = ""

        ' Populate the table with sample values.
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub
    Protected Sub btnFNLNReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFNLNReset.Click

        txtFNLN.Text = ""
        txtLNFN.Text = ""

        ' Rebind the data to refresh the DataGrid control.
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub
    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtFirstName.Text = ""

        ' Rebind the data to refresh the DataGrid control.
        ItemsGrid.DataSource = CreateDataSource()
        ItemsGrid.DataBind()

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        FormsAuthentication.SignOut()
        Response.Redirect("http://www.unknownprotocol.me:8080/logon.aspx", True)

    End Sub
End Class