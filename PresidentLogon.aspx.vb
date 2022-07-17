Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Security
Imports System.IO
Imports System.Configuration
Imports System.Net.Mail

Partial Class Presidentlogon
    Inherits System.Web.UI.Page
    Dim Email As String
    'Dim WithEvents btnReset As New Button
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.User.Identity.IsAuthenticated = False Then

            NavigationMenu.Items.Item(0).Enabled = False
            NavigationMenu.Items.Item(1).Enabled = True
            NavigationMenu.Items.Item(2).Enabled = True
            NavigationMenu.Items.Item(3).Enabled = True
            NavigationMenu.Items.Item(4).Enabled = True
            NavigationMenu.Items.Item(5).Enabled = True
        End If

    End Sub

    Private Function ValidateUser(ByVal userName As String, ByVal passWord As String) As Boolean
        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim lookupPassword As String

        lookupPassword = Nothing

        ' Check for an invalid userName.
        ' userName  must not be set to nothing and must be between one and 15 characters.
        If ((userName Is Nothing)) Then
            System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of userName failed.")
            Return False
        End If
        If ((userName.Length = 0) Or (userName.Length > 50)) Then
            System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of userName failed.")
            Return False
        End If

        ' Check for invalid passWord.
        ' passWord must not be set to nothing and must be between one and 25 characters.
        If (passWord Is Nothing) Then
            System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of passWord failed.")
            Return False
        End If
        If ((passWord.Length = 0) Or (passWord.Length > 25)) Then
            System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of passWord failed.")
            Return False
        End If

        Try
            ' Consult with your SQL Server administrator for an appropriate connection
            ' string to use to connect to your local SQL Server.
            conn = New SqlConnection("server=D7BBFM83\DIGITALBDS;Integrated Security=SSPI;database=registration")
            conn.Open()

            ' Create SqlCommand to select pwd field from the users table given a supplied userName.
            cmd = New SqlCommand("Select password from tblRegistered where Email=@Email", conn)
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50)
            cmd.Parameters("@Email").Value = userName


            ' Execute command and fetch pwd field into lookupPassword string.
            lookupPassword = cmd.ExecuteScalar()

            ' Cleanup command and connection objects.
            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            ' Add error handling here for debugging.
            ' This error message should not be sent back to the caller.
            System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " & ex.Message)
        End Try

        ' If no password found, return false.
        If (lookupPassword Is Nothing) Then
            ' You could write failed login attempts here to the event log for additional security.
            Return False
        End If

        ' Compare lookupPassword and input passWord by using a case-sensitive comparison.
        Return (String.Compare(lookupPassword, passWord, False) = 0)

    End Function
    Private Sub cmdLogin_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLogin.ServerClick

        Session("Email") = txtUserName.Value

        If ValidateUser(txtUserName.Value, txtUserPass.Value) Then
            FormsAuthentication.RedirectFromLoginPage(txtUserName.Value, chkPersistCookie.Checked)
        Else
            Response.Redirect("logon.aspx", True)
        End If
    End Sub

    ' ScriptManager.RegisterStartupScript(Page, Page.GetType(), "scrollDown", "setTimeout(function () { window.scrollTo(0,document.body.scrollHeight); }, 25);", true);

End Class