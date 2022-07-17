<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewBroadcastMessages.aspx.vb" Inherits="ViewBroadcastMessages" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title></title>
    <style type="text/css">
    /* DEFAULTS
----------------------------------------------------------*/

body   
{
   
}

a:link, a:visited
{
    color: #034af3;
}

a:hover
{
    color: #1d60ff;
    text-decoration: none;
}

a:active
{
    color: #034af3;
}

p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}


/* HEADINGS   
----------------------------------------------------------*/

h1, h2, h3, h4, h5, h6
{
    font-size: 1.5em;
    color: #666666;
    font-variant: small-caps;
    text-transform: none;
    font-weight: 200;
    margin-bottom: 0px;
}

h1
{
    font-size: 1.6em;
    padding-bottom: 0px;
    margin-bottom: 0px;
}

h2
{
    font-size: 1.5em;
    font-weight: 600;
}

h3
{
    font-size: 1.2em;
}

h4
{
    font-size: 1.1em;
}

h5, h6
{
    font-size: 1em;
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
        #TextArea1
        {
            height: 120px;
            width: 656px;
        }
        </style>
  

   <script type = "text/javascript">
       function WinPos() {
           var randomno = Math.floor((Math.random() * 100) + 1);
           x = parseInt(window.screen.width) / 1 - 0;  // the number 175 is the exact half of the width of the pop-up and so should be changed according to the size of the pop-up
           y = parseInt(window.screen.height) / 1 - 0;  // the number 67 is the exact half of the height of the pop-up and so should be changed according to the size of the pop-up
           //window.open('PrivateChat.aspx', 'NewWin' + randomno, 'toolbar=no,menubar=no,location=no,resizable=no,status=no,width=350,height=475,scrollbars=no')
           // change the figures of width and height above to customize the size of the window to be opened.
           CW.moveTo(x, y);
       }
    </script>

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

            <form id="VBMForm" runat="server">
            <div class="loginDisplay">

            <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                    
                    <LoggedInTemplate>
                        
                    </LoggedInTemplate>
                </asp:LoginView>

              

               </div>
            <div class="clear hideSkiplink">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignUp"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Retrieve Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotUsername.aspx" Text="Forgot Username" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="UserUpdate.aspx" Text="User Update" Value="User Update"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="DeleteUser.aspx" Text="Delete User" Value="Delete User"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>

           <div class="main">

                  <asp:DataGrid id="Up" runat="server" AllowSorting="True" 
                AutoGenerateColumns="False" Font-Size="12pt" Font-Names="Times New Roman" 
                DataSourceID="SqlDataSource1" CellPadding="4"  ForeColor="#333333" 
                GridLines="None" AllowPaging="True" pagesize="1" Font-Bold="False" Font-Italic="False" 
                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Width="100%" >

                <EditItemStyle BackColor="#999999" />

                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

                <HeaderStyle font-size="12pt" font-bold="True" horizontalalign="Left" 
                    forecolor="White" backcolor="#5D7B9D" Font-Italic="False" 
                    Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>

                <AlternatingItemStyle backcolor="White" ForeColor="#284775"></AlternatingItemStyle>
                                                <Columns>

                <asp:TemplateColumn HeaderText = "Photo">
                <ItemTemplate>

                <asp:ImageButton id="imagebutton1" runat="server"
           AlternateText="ImageButton1"
           ImageAlign="left"
           Height = "200"
           Width = "200"
           ImageUrl='<%# Eval("UrlOfPicture")%>'
          />

                 
                </ItemTemplate>
                </asp:TemplateColumn>
                
               
                
                <asp:BoundColumn DataField="FirstName" HeaderText="First Name"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Middlename" HeaderText="Middle Name"></asp:BoundColumn>
                    <asp:BoundColumn DataField="LastName" HeaderText="Last Name"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ID" HeaderText="ID"></asp:BoundColumn>
                
                    
                </Columns>
                
                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />

                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />

                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

            </asp:DataGrid>  

       <div class = "WordWrap">
      <asp:ListView ID="ListView"
       DataKeyNames="RelationshipID"
        runat="server">
        <LayoutTemplate>
        <div class = "WordWrap">
          <table cellpadding="0" width="100%" border="0" ID="tbl1" runat="server">
            <tr id="Tr1" runat="server" style="background-color: #4b6c9e">
            <th id="Th5" runat="server" width = "8%" style="color: #ffffff">Picture</th>
              <th id="Th1" runat="server" width = "10%" style="color: #ffffff">First Name</th>
              <th id="Th2" runat="server" width = "10%" style="color: #ffffff">Middle Name</th>
              <th id="Th3" runat="server" width = "8%" style="color: #ffffff">Last Name</th>
             <th id="Th6" runat="server"  width = "18%" style="color: #ffffff">Date Time</th>
              <th id="Th4" runat="server" style="color: #ffffff">Messages</th>
             </tr>
            <tr runat="server" id="itemPlaceholder" />
          </table>
          </div>
          <asp:DataPager runat="server" ID="DataPager"
                   PageSize="20">
       <Fields>
         <asp:NumericPagerField ButtonCount="3"
              PreviousPageText="<--"
              NextPageText="-->" />
       </Fields>
    </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
          <tr id="Tr2" runat="server">
          <td>
              <asp:ImageButton id="Image" runat="server"
           AlternateText="ImageButton1"
           ImageAlign="left"
           Height = "150"
           Width = "150"
           ImageUrl='<%# Eval("URLOfPicture")%>' />
            </td>
          <td>
              <asp:Label ID="FirstName" runat="server" Text='<%# Eval("FirstName") %>' />
            </td>
            <td>
              <asp:Label ID="MiddleName" runat="server" Text='<%# Eval("MiddleName") %>' />
            </td>
            <td>
              <asp:Label ID="LastName" runat="server" Text='<%# Eval("LastName") %>' />
            </td>
                <td>
              <asp:Label ID="Label1" runat="server" Text='<%# Eval("DateTime") %>' />
            </td>
            <td>
              <asp:Label ID="Messages" runat="server" Text='<%# Eval("Messages") %>' />
            </td>
          </tr>
        </ItemTemplate>
      </asp:ListView>
      </div>
    </div>

    
     <asp:Button ID="btnClose" runat="server" Text="Close" ForeColor="white" BackColor="#4b6c9e" />

             
             </form>
      

       <asp:sqldatasource
          id="SqlDataSource1"
          runat="server"
          connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>" 
                      
                      SelectCommand="SELECT [URLOfPicture], [FirstName], [MiddleName], [LastName], [ID] FROM [tblRegistered] WHERE ([ID] = @ID)">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="" Name="ID" QueryStringField="ID" 
                            Type="Int32" />
                    </SelectParameters>

           </asp:sqldatasource>

</body>
</html>
