Imports System.Data.SqlClient
Imports System.Data

Partial Class Z
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ID = CType(Session.Item("ID"), String)
        Session("ID") = ID

        ' Load sample data only once, when the page is first loaded.
        If Not IsPostBack Then
            ItemsGrid.DataSource = CreateDataSource()
            ItemsGrid.DataBind()
        End If

    End Sub
    Function CreateDataSource() As ICollection

        Dim Connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("SqlDataSource1").ConnectionString)
        Dim Cmd As SqlDataAdapter = New SqlDataAdapter("Select * from tblRegistered ORDER BY ID", Connection)
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
    Private Sub cmdSignOut_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignOut.ServerClick
        FormsAuthentication.SignOut()
        Response.Redirect("http://www.briandalesinger.me", True)
    End Sub

End Class