﻿<%@ Page Title="Users" Language="VB" AutoEventWireup="false" EnableEventValidation="False"
    CodeFile="Search.aspx.vb" Inherits="Search" %>

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
            </style>
</head>
<body>
<center>
<div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    unknownprotocol
                </h1>
            </div>

            <form id="Form" runat="server">
            <div class="SearchDisplay">

            <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                    
                    <LoggedInTemplate>
                        
                    </LoggedInTemplate>
                </asp:LoginView>

                <asp:Button ID="btnLogout" CausesValidation="False" runat="server" Text="Log Out" />

               </div>
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignSC"></asp:MenuItem>
                        <asp:MenuItem Text="Contacts" Value="Contacts"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Retrieve Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/forgotUsername.aspx" Text="Forgot Username" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="DeleteContact.aspx" Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">
<center>
<asp:DataGrid id="ItemsGrid" runat="server"
              CellPadding="4"
              UseAccessibleHeader="True"
              AutoGenerateColumns="False"
              PageSize="1"
              AllowPaging="True"
              OnPageIndexChanged="Grid_Change" ForeColor="#333333" 
        GridLines="None" Font-Bold="False" Font-Italic="False" 
        Font-Names="Times New Roman" Font-Overline="False" Font-Size="12pt" 
        Font-Strikeout="False" Font-Underline="False" Width="16px">

    <EditItemStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<HeaderStyle font-size="12pt" font-bold="True" horizontalalign="Center" 
                    forecolor="White" backcolor="#5D7B9D" Font-Italic="False" 
                    Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>

<AlternatingItemStyle backcolor="White" ForeColor="#284775"></AlternatingItemStyle>
                <Columns>
                <asp:TemplateColumn HeaderText = "Photo">
                <ItemTemplate>
                
                <a href="default.aspx?ID=<%# Eval("ID")%>" onclick="javascript:w= window.open(this.href,'DownloadImage','left=20,top=20,width=400,height=900,toolbar=0,resizable=0');return false;" Target="_blank"><asp:Image ID="Image2" ImageURL='<%# Eval("UrlOfPicture")%>' Visible='<%#Convert.ToString(Eval("UrlOfPicture")) <> ""%>' runat="server" Height="50" Width="50"/></asp:Image></asp:Image></a>
   

                </ItemTemplate>
                </asp:TemplateColumn>
                    <asp:HyperLinkColumn HeaderText="First Name" DataTextField="FirstName" 
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="default.aspx?ID={0}"></asp:HyperLinkColumn>
                    <asp:HyperLinkColumn HeaderText="Middle Name" DataTextField="MiddleName" 
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="default.aspx?ID={0}"></asp:HyperLinkColumn>
                    <asp:HyperLinkColumn HeaderText="Last Name" DataTextField="LastName" 
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="default.aspx?ID={0}"></asp:HyperLinkColumn>
                                   </Columns>
                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <PagerStyle BackColor="#284775" ForeColor="White" 
        HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            
    <asp:Label ID="lblSearch1" runat="server" Text="Search by ID"></asp:Label>
        <br />

    <asp:TextBox ID="txtcupid" runat="server" Width="127px"></asp:TextBox>
    <br />
    <asp:Button ID="btnSoonerSearch" runat="server" CssClass="textEntry" Text="Search" BackColor="#4b6c9e" ForeColor="white" Width="55px" />
    <asp:Button ID="btnResetSC" runat="server" CssClass="textEntry" Text="Reset" BackColor="#4b6c9e" ForeColor="white" Width="55px" />
       <br />
    <asp:Label ID="lblSearch" runat="server" Text="Search by first name"></asp:Label>
    <br />
    <asp:TextBox ID="txtFirstName" runat="server" Width="127px"></asp:TextBox>
    <br />
    <asp:Button ID="btnFNSearch" runat="server" CssClass="textEntry" Text="Search" BackColor="#4b6c9e" ForeColor="white" style="margin-left: 57px" Width="55px" />
    <asp:Button ID="btnReset" runat="server" CssClass="textEntry" Text="Reset" BackColor="#4b6c9e" ForeColor="white" Width="55px" />
    <br />
    <br />
    <asp:Label ID="lblSearch0" runat="server">Search by last name</asp:Label>
    <br />
    <asp:TextBox ID="txtLastName" runat="server" Width="127px"></asp:TextBox>
    <br />
    <asp:Button ID="btnLNSearch" runat="server" CssClass="textEntry" Text="Search" BackColor="#4b6c9e" ForeColor="white" Width="55px" />
    <asp:Button ID="btnLNReset" runat="server" CssClass="textEntry" Text="Reset" BackColor="#4b6c9e" ForeColor="white" Width="55px" />
    <br />
    <asp:Label ID="lblSearchFNLN" runat="server">Search by first and last name</asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtFNLN" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtLNFN" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnFNLNSearch" runat="server" CssClass="textEntry" Text="Search" BackColor="#4b6c9e" ForeColor="white" Width="55px"/>
    <asp:Button ID="btnFNLNReset" runat="server" CssClass="textEntry" Text="Reset" BackColor="#4b6c9e" ForeColor="white" Width="55px"/>
    <br />
    </form>
            
    <asp:SqlDataSource ID="SqlDataSource1"  runat="server" connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>" 
    SelectCommand="SELECT [ID], [UrlOfPicture], [FirstName], [MiddleName], [LastName], [Countries], [Districts], [States], [Provinces], [Territories], [Towns], [Cities], [Villages], [Boroughs], [Counties] FROM [tblRegistered] WHERE ([FirstName] = @FirstName)"
    FilterExpression="FirstName='{0}'">
    </asp:SqlDataSource>

     <asp:SqlDataSource ID="SqlDataSource3"  runat="server" connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>" 
    SelectCommand="SELECT [ID], [UrlOfPicture], [FirstName], [MiddleName], [LastName], [Countries], [Districts], [States], [Provinces], [Territories], [Towns], [Cities], [Villages], [Boroughs], [Counties] FROM [tblRegistered] WHERE ([MiddleName] = @MiddleName)"
    FilterExpression="FirstName='{0}'">
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource2" runat="server" connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
    SelectCommand="SELECT [ID], [UrlOfPicture], [FirstName], [MiddleName], [LastName], [Countries], [Districts], [States], [Provinces], [Territories], [Towns], [Cities], [Villages], [Boroughs], [Counties] FROM [tblRegistered] WHERE ([LastName] = @LastName)"
    FilterExpression="LastName='{0}'">
    </asp:SqlDataSource>


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

             </center>  
    </asp:Content>


