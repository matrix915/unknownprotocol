<%@ Page Title="Change Password" Language="VB" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="ChangePassword" %>


    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head2" runat="server">
    <title></title>
             <style type="text/css">
    /* DEFAULTS
----------------------------------------------------------*/

body   
{
    font-size: 12px;
}

a:link, a:visited
{
    color: #034af3;
     font-size: 12px;
}

a:hover
{
    color: #1d60ff;
    text-decoration: none;
     font-size: 12px;
}

a:active
{
    color: #034af3;
     font-size: 12px;
}

p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}

.link img
{
    height:100px;
    width:100px;
    border:0px;	
}
/* HEADINGS   
----------------------------------------------------------*/

h1, h2, h3, h4, h5, h6
{
    font-size: 12px;
    color: #666666;
    font-variant: small-caps;
    text-transform: none;
    font-weight: 200;
    margin-bottom: 0px;
}

h1
{
    font-size: 12px;
    padding-bottom: 0px;
    margin-bottom: 0px;
}

h2
{
    font-size: 12px;
    font-weight: 600;
}

h3
{
    font-size: 12px;
}

h4
{
    font-size: 12px;
}

h5, h6
{
    font-size: 12px;
}

/* this rule styles <h1> and <h2> tags that are the 
first child of the left and right table columns */
.rightColumn > h1, .rightColumn > h2, .leftColumn > h1, .leftColumn > h2
{
    margin-top: 0px;
}


/* PRIMARY LAYOUT ELEMENTS   
----------------------------------------------------------*/

 .page {
        width: 950px;
        background-color: #fff;
        margin: auto auto 0px 0px;
        border: 1px solid #496077;
      }
   
.header
{
    position: relative;
    margin: 0px;
    padding: 0px;
    background: #4b6c9e;
    width: 100%;
}

.header h1
{
    font-weight: 700;
    margin: 0px;
    padding: 0px 0px 0px 20px;
    color: #f9f9f9;
    border: none;
    line-height: 2em;
    font-size: 2em;
}

.main
{
    padding: 0px 12px;
    margin: 12px 8px 8px 8px;
    min-height: 420px;
}

.leftCol
{
    padding: 6px 0px;
    margin: 12px 8px 8px 8px;
    width: 200px;
    min-height: 200px;
}

.footer
{
    color: #4e5766;
    padding: 8px 0px 0px 0px;
    margin: 0px auto;
    text-align: center;
    line-height: normal;
}


/* TAB MENU   
----------------------------------------------------------*/

div.hideSkiplink
{
    background-color:#3a4f63;
    width:100%;
    color: #FFFFFF;
}

div.menu
{
    padding: 4px 0px 4px 8px;
}

div.menu ul
{
    list-style: none;
    margin: 0px;
    padding: 0px;
    width: auto;
       display: flex;
               
                justify-content: center;
}

div.menu ul li a, div.menu ul li a:visited
{
    background-color: #465c71;
    border: 1px #4e667d solid;
    color: #dde4ec;
    display: block;
    line-height: 1.35em;
    padding: 4px 20px;
    text-decoration: none;
    white-space: nowrap;
}

div.menu ul li a:hover
{
    background-color: #bfcbd6;
    color: #465c71;
    text-decoration: none;
}

div.menu ul li a:active
{
    background-color: #465c71;
    color: #cfdbe6;
    text-decoration: none;
}

/* FORM ELEMENTS   
----------------------------------------------------------*/

fieldset
{
    margin: 1em 0px;
    padding: 1em;
    border: 1px solid #ccc;
}

fieldset p 
{
    margin: 2px 12px 10px 10px;
}

fieldset.login label, fieldset.register label, fieldset.changePassword label
{
    display: block;
}

fieldset label.inline 
{
    display: inline;
}

legend 
{
    font-size: 1.1em;
    font-weight: 600;
    padding: 2px 4px 8px 4px;
}

input.textEntry 
{
    width: 320px;
    border: 1px solid #ccc;
}

input.passwordEntry 
{
    width: 320px;
    border: 1px solid #ccc;
}

div.accountInfo
{
    width: 42%;
}

/* MISC  
----------------------------------------------------------*/

.clear
{
    clear: both;
}

.title
{
    display: block;
    float: left;
    text-align: left;
    width: auto;
}

.loginDisplay
{
    font-size: 1.1em;
    display: block;
    text-align: right;
    padding: 10px;
    color: White;
}

.loginDisplay a:link
{
    color: white;
}

.loginDisplay a:visited
{
    color: white;
}

.loginDisplay a:hover
{
    color: white;
}

.failureNotification
{
    font-size: 1.2em;
    color: Red;
}

.bold
{
    font-weight: bold;
}

.button {
  font-size: 6px;
}

.submitButton
{
    text-align: right;
    padding-right: 10px;
}    
            .style3
            {
                width: 960px;
            }
            .style5
            {
                text-align: center;
            }
            .auto-style1 {
                width: 100%;
            }
    </style>  
</head>
<body>
<center>
<div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    unknownprotocol&nbsp;
                </h1>
            </div>
            <form runat="server">
                       <div class="loginDisplay">

            <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                    
                    <LoggedInTemplate>
                        
                    </LoggedInTemplate>
                </asp:LoginView>

                     <asp:Button ID="btnLogout" CausesValidation="False" runat="server" Text="Login" />
            </div>
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                      <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignSC"></asp:MenuItem>
                          <asp:MenuItem  Text="Contacts" Value="Contacts"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                         <asp:MenuItem NavigateUrl="~/forgotUsername.aspx" Text="Forgot Username" Value="Forgot USername"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Forgot Password"></asp:MenuItem>
                       <asp:MenuItem NavigateUrl="~/DeleteContact.aspx" Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">
<body>
<center>
<fieldset>
<legend>Change Password</legend>
<table>
<tr>
<td>
    <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
    </td>
<td>
<asp:TextBox ID="txtEmail" runat="server" Width="320px"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ControlToValidate="txtEmail" Display="Static" ErrorMessage="Email required!" runat="server" ID="RequiredFieldValidator1" />
    <br />

</td>
</tr>
<tr>
</tr>
<tr>
<td>
    <asp:Label ID="lblNewPassword" runat="server" Text="New password"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server" CssClass="textEntry" Width="320px" AutoPostBack="False"></asp:TextBox>
    <br />
<asp:RequiredFieldValidator ControlToValidate="txtNewPassword" Display="Static" ErrorMessage="New password required!" runat="server" ID="RequiredFieldValidator3" />
    <br />
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" display="dynamic" ControlToValidate="txtNewPassword"
ErrorMessage="Password must be 8-10 characters,<br/> contain at least one digit and one alphabetic character,<br /> and must contain special characters." ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{10,}$" />
</td>
</tr>
<tr>
<td>
    <asp:Label ID="lblReTypePassword" runat="server" Text="Re-Type password"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtConfirmNewPassword" TextMode="Password" runat="server" CssClass="textEntry" Width="320px" AutoPostBack="False"></asp:TextBox>
    <br />
<asp:RequiredFieldValidator ControlToValidate="txtConfirmNewPassword" Display="Static" ErrorMessage="Confirm new password required!" runat="server" ID="RequiredFieldValidator4" />
    <br />
<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" display="dynamic" ControlToValidate="txtConfirmNewPassword"
ErrorMessage="Password must be 8-10 characters,<br/> contain at least one digit and one alphabetic character,<br /> and must contain special characters." ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{10,}$" />
<br />
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtConfirmNewPassword" ControlToCompare="txtNewPassword" ErrorMessage="Passwords do not match." />
</td>
</tr>
<tr>
<td>
    &nbsp;</td>
<td>
<asp:Label ID="lblPasswordChanged" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>
    &nbsp;</td>
<td>
    <Center>
<asp:Button ID="btnChangePassword" runat="server" Text="Change Password" BackColor="#4b6c9e" ForeColor="white" />
<asp:Button ID="btnReset" runat="server" Text="Reset" BackColor="#4b6c9e" ForeColor="white"/>
        </Center>
</td>
</tr>
</table>
<br />
                                  <asp:HyperLink id="hyperlink2" 
                  ImageUrl=""
                  NavigateUrl="~/privacy.aspx"
                  Text="Privacy"
                  Target="_self"
                  runat="server"/>
                  &nbsp;|
                  </asp:HyperLink>
                  
                  <asp:HyperLink id="hyperlink3" 
                  ImageUrl=""
                  NavigateUrl="~/termsofuse.aspx"
                  Text="Terms Of Use"
                  Target="_self"
                  runat="server"/>
                 </asp:HyperLink> 
</fieldset>
</center>
</form>



</body>
</html>



