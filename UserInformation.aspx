<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UserInformation.aspx.vb" Inherits="UserInformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title></title>
       <script type="text/javascript">
        function SessionExpire(timeout) {
            console.log('session start');
            setTimeout(function () {
                document.getElementById("btnLogout").click();
            }, timeout + 2000);
        }
       </script>
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
                flex-flow: wrap;
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
            <form runat="server">
                       <div class="loginDisplay">

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
                        <asp:MenuItem NavigateUrl="~/Registration.aspx" Text="Registration" Value="SignUp"></asp:MenuItem>
                                                <asp:MenuItem Text="Contacts" Value="Contacts"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Retrieve Password"></asp:MenuItem>
                         <asp:MenuItem NavigateUrl="~/ForgotUsername.aspx" Text="Forgot Username" Value="Change Password"></asp:MenuItem>
    <asp:MenuItem NavigateUrl="~/DeleteContact.aspx" Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">
<body>
<center>
<fieldset>
<legend>Contact Information</legend>
        <div class="main">
       <div>
           <div class = "WordWrap">
      <asp:ListView ID="ListView"
        runat="server">
        <LayoutTemplate>
        <div class = "WordWrap">
          <table cellpadding="0" width="100%" border="0" ID="tbl1" runat="server">
            <tr id="Tr1" runat="server" style="background-color: #4b6c9e">
              <th id="Th1" runat="server" style="color: #ffffff">Picture</th>
              <th id="Th2" runat="server" width="10%" style="color: #ffffff">First Name</th>
              <th id="Th3" runat="server" width="12%" style="color: #ffffff">Middle Name</th>
              <th id="Th4" runat="server" style="color: #ffffff">Last Name</th>
              
              </tr>
              <tr runat="server" id="itemPlaceholder" />
            </tr>
            <tr>
            </tr>
           </table>
          </div>
          <asp:DataPager runat="server" ID="DataPager"
                   PageSize="1">
       <Fields>
         <asp:NumericPagerField ButtonCount="3"
              PreviousPageText="<--"
              NextPageText="-->" />
       </Fields>
    </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
         
          <td>
           <asp:ImageButton id="Image" runat="server"
           AlternateText=""
           ImageAlign="left"
           Height = "50"
           Width = "50"
           ImageUrl='<%# Eval("URLOfPicture")%>' />
             </td>
             <td>
              <center><asp:Label ID="FirstName" runat="server" Text='<%# Eval("FirstName") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="MiddleName" runat="server" Text='<%# Eval("MiddleName") %>' /></center>
            </td>
            <td>
             <center><asp:Label ID="LastName" runat="server" Text='<%# Eval("LastName") %>' /></center>
            </td>
            
            </tr>
            <tr id="Tr1" runat="server" style="background-color: #4b6c9e">
                <th id="Th5" runat="server" style="color: #ffffff">Country</th>
                                 <th id="Th9" runat="server" width="20%" style="color: #ffffff">Address</th>
               <th id="Th8" runat="server" width="20%" style="color: #ffffff">City</th>
                 <th id="Th6" runat="server" style="color: #ffffff">State</th>
               <th id="Th7" runat="server" width="20%" style="color: #ffffff">Zip Code</th>
              
              </tr>
             <tr>
            <td>
              <center><asp:Label ID="Label1" runat="server" Text='<%# Eval("Country") %>' /></center>
            </td>
            
           
                       <td>
              <center><asp:Label ID="Label14" runat="server" Text='<%# Eval("Address") %>' /></center>
            </td>
            
            <td>
              <center><asp:Label ID="Label4" runat="server" Text='<%# Eval("City") %>' /></center>
            </td>
                  <td>
              <center><asp:Label ID="Label2" runat="server" Text='<%# Eval("State") %>' /></center>
            </td>
             <td>
              <center><asp:Label ID="Label3" runat="server" Text='<%# Eval("ZipCode") %>' /></center>
            </td>
           </tr>
            <tr id="Tr2" runat="server" style="background-color: #4b6c9e">
                <th id="Th10" runat="server" width="10%" style="color: #ffffff">Current Age</th>
              <th id="Th11" runat="server" width="10%" style="color: #ffffff">Gender</th>
              <th id="Th12" runat="server" width="10%" style="color: #ffffff">Height Feet</th>
              <th id="Th13" runat="server" width="13%" style="color: #ffffff">Height Inches</th>
              <th id="Th14" runat="server" width="13%" style="color: #ffffff">Weight Pounds</th>
              <th id="Th15" runat="server" width="13%" style="color: #ffffff">Weight Ounces</th>
             
              </tr>
           
            <td>
                  <center><asp:Label ID="Label5" runat="server" Text='<%# Eval("CurrentAge") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label6" runat="server" Text='<%# Eval("Gender") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label7" runat="server" Text='<%# Eval("HeightFeet") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label8" runat="server" Text='<%# Eval("HeightInches") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label9" runat="server" Text='<%# Eval("WeightPounds") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label10" runat="server" Text='<%# Eval("WeightOunces") %>' /></center>
            </td>
            
           </tr>
                             <tr id="Tr3" runat="server" style="background-color: #4b6c9e">
            
              <th id="Th16" runat="server" width="10%" style="color: #ffffff">Hair Color</th>
              <th id="Th17" runat="server" width="0%" style="color: #ffffff">Eye Color</th>
              <th id="Th18" runat="server" style="color: #ffffff">Drinks</th>
              <th id="Th19" runat="server" style="color: #ffffff">Smokes</th>
              <th id="Th21" runat="server" width="16%" style="color: #ffffff">Marital Status</th>
                          <th id="Th23" runat="server" width="18%" style="color: #ffffff">Date Time</th>
               
                     </tr>
                                   <td>
              <center><asp:Label ID="Label11" runat="server" Text='<%# Eval("HairColor") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label20" runat="server" Text='<%# Eval("EyeColor") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label12" runat="server" Text='<%# Eval("Drinks") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label13" runat="server" Text='<%# Eval("Smokes") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label15" runat="server" Text='<%# Eval("MaritalStatus") %>' /></center>
            </td>
            <td>
              <center><asp:Label ID="Label16" runat="server" Text='<%# Eval("DateTime") %>' /></center>
            </td>

           
       </ItemTemplate>
      </asp:ListView>
      </div>
    </div>
           
            <br />
              
 
           
    <br />

               <asp:Button ID="btnCreateInfo" runat="server" Text="Create" ForeColor="white" 
                BackColor="#4b6c9e"/>

               <asp:Button ID="btnUpdate" runat="server" Text="Update" ForeColor="white" 
                BackColor="#4b6c9e"/>
                <br />
              
    <asp:Button ID="btnGoBack" runat="server" Text="Go Back" ForeColor="white" 
                BackColor="#4b6c9e"/>
               <br />
            <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
    <br />
              
    <asp:Button ID="btnDUI" runat="server" Text="Delete User Information" ForeColor="white" BackColor="#4b6c9e" />
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
                  NavigateUrl="~/TermsOfUse.aspx"
                  Text="Terms Of Use"
                  Target="_self"
                  runat="server"/>
                  </asp:HyperLink> 

    </form>
            
    </div>
       
     <asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1%>"
      UpdateCommand="UPDATE [tblUpdateRegistered] SET [Email] = @Email WHERE [RelationshipID] = @ID">
      <UpDateParameters>
       <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
      </UpDateParameters>
    </asp:SqlDataSource>

</body>
</html>
