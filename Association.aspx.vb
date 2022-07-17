Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Configuration
Imports System.Net.Security
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Drawing

Public Class Association
    Inherits System.Web.UI.Page

    <System.Web.Services.WebMethod()>
    Public Shared Function GetCurrentTime(ByVal name As String) As String

        Return name

    End Function
End Class
