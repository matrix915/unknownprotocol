<%@ Page Title="UP" Language="VB" MaintainScrollPositionOnPostBack="true" AutoEventWireup="false"
  EnableEventValidation="False" CodeFile="Default.aspx.vb" Inherits="_Default" %>


  <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
  <html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">

  <head id="Head2" runat="server">
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

  <body attr="<%=Email%>">
    <center>
      <div class="page">
        <div class="header">
          <div class="title">
            <h1>
                unknownprotocol</h1>
          </div>

          <form id="Form" runat="server">
            <center>
              <div class="loginDisplay">

                <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">

                  <LoggedInTemplate>

                  </LoggedInTemplate>
                </asp:LoginView>

                <asp:Button ID="btnLogout" CausesValidation="False" runat="server" Text="Log Out" />

              </div>
              <div class="clear hideSkiplink">

                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false"
                  IncludeStyleBlock="false" Orientation="Horizontal">
                  <Items>
                    <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignSC"></asp:MenuItem>
                    <asp:MenuItem Text="Contacts" Value="Contacts"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/forgotUsername.aspx" Text="Forgot Username" Value="Forgot USername">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Forgot Password">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                  </Items>
                </asp:Menu>

              </div>
        </div>
        <div class="auto-style1">

          <asp:DataGrid id="Prototype" runat="server" AllowSorting="True" AutoGenerateColumns="False" Font-Size="12pt"
            Font-Names="Times New Roman" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333"
            GridLines="None" pagesize="1" Font-Bold="False" Font-Italic="False" Font-Overline="False"
            Font-Strikeout="False" Font-Underline="False" Width="100%">
            <EditItemStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle font-size="12pt" font-bold="True" horizontalalign="Left" forecolor="White" backcolor="#5D7B9D"
              Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
            <AlternatingItemStyle backcolor="White" ForeColor="#284775"></AlternatingItemStyle>
            <Columns>
              <asp:TemplateColumn HeaderText="Photo">
                <ItemTemplate>
                  <asp:HyperLink ID="Hyperlink1" runat="server" ImageURL='<%# Eval("URLOfPicture")%>' CssClass="link" />
                </ItemTemplate>
              </asp:TemplateColumn>
              <asp:BoundColumn DataField="FirstName" HeaderText="FirstName"></asp:BoundColumn>

              <asp:BoundColumn DataField="MiddleName" HeaderText="MiddleName"></asp:BoundColumn>

              <asp:BoundColumn DataField="LastName" HeaderText="LastName"></asp:BoundColumn>

            </Columns>
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" NextPageText="Next"
              PrevPageText="Previous" />
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
          </asp:DataGrid>

          <table class="auto-style1">
            <tr>
              <td style="background-color: #4b6c9e;">
                <center>
                  <asp:Label BackColor="#5D7B9D" ForeColor="White" runat="server">Search #</asp:Label>
                  <asp:Label ID="labelID" runat="server" BackColor="#5D7B9D" ForeColor="White">
                </center>
                </asp:Label>
              </td>
            </tr>
          </table>
          <p>

            <b>
              <font size="5">
                <asp:Button ID="Connect" runat="server" style="text-align: center" Text="Add Contact"
                  BackColor="#4b6c9e" ForeColor="white" />
              </font>
            </b>
            <br />



            <asp:Label ID="Label24" runat="server" Text="Change Global Section " autopostback="True"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
              <asp:listitem Value="Select">Select</asp:listitem>
              <asp:listitem Value="Invisable">Invisable</asp:listitem>
              <asp:listitem Value="Association">Association</asp:listitem>
              <asp:listitem Value="Aquintences">Aquintences</asp:listitem>
              <asp:listitem Value="TheList">The List</asp:listitem>
              <asp:listitem Value="InTheKnow">In The Know</asp:listitem>
              <asp:listitem Value="KnowsOf">Knows Of</asp:listitem>
              <asp:listitem Value="Knows">Knows</asp:listitem>
              <asp:listitem Value="Friends">Friends</asp:listitem>
              <asp:listitem Value="WantToDate">Want To Date</asp:listitem>
              <asp:listitem Value="Dateing">Dateing</asp:listitem>
              <asp:listitem Value="Fiances">Fiances</asp:listitem>
              <asp:listitem Value="Fiancees">Fiancees</asp:listitem>
              <asp:ListItem Value="Married">Married</asp:ListItem>
              <asp:listitem Value="Divorce">Divorce</asp:listitem>
              <asp:listitem Value="Divorcee">Divorcee</asp:listitem>
              <asp:listitem Value="NonBiologicalFamily">Non-Biological Family</asp:listitem>
              <asp:listitem Value="Family">Family</asp:listitem>
                <asp:listitem Value="Secret">Secret</asp:listitem>
              <asp:listitem Value="FamilySecret">Family Secret</asp:listitem>
                      </asp:DropDownList>
            <asp:Button ID="btnChangeYourStatus" runat="server" Text="Change Global Status" BackColor="#4b6c9e"
              ForeColor="white" />




            <br />
            <asp:Label ID="lblPictureID" runat="server" Text="PictureID"></asp:Label>

            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource5" DataTextField="IDSS"
              DataValueField="IDSS" autopostback="False" AppendDataBoundItems="True">
              <asp:ListItem>
              </asp:ListItem>
            </asp:DropDownList>


            <br />

            <center>


              <asp:Label ID="lblSendPicTo" runat="server" Text="Change Picture Status"></asp:Label>
              <asp:dropdownlist id="DropDownList3" runat="server" autopostback="False" AppendDataBoundItems="True">
                <asp:listitem Value="Select">Select</asp:listitem>
                <asp:listitem Value="Invisable">Invisable</asp:listitem>
                <asp:listitem Value="Association">Association</asp:listitem>
                <asp:listitem Value="Aquintences">Aquintences</asp:listitem>
               <asp:listitem Value="TheList">The List</asp:listitem>
                <asp:listitem Value="InTheKnow">In The Know</asp:listitem>
                <asp:listitem Value="KnowsOf">Knows Of</asp:listitem>
                <asp:listitem Value="Knows">Knows</asp:listitem>
                <asp:listitem Value="Friends">Friends</asp:listitem>
                <asp:listitem Value="WantToDate">Want To Date</asp:listitem>
                <asp:listitem Value="Dateing">Dateing</asp:listitem>
                <asp:listitem Value="Fiances">Fiances</asp:listitem>
                <asp:listitem Value="Fiancees">Fiancees</asp:listitem>
                <asp:ListItem Value="Married">Married</asp:ListItem>
                <asp:listitem Value="Divorce">Divorce</asp:listitem>
                <asp:listitem Value="Divorcee">Divorcee</asp:listitem>
                <asp:listitem Value="NonBiologicalFamily">Non-Biological Family</asp:listitem>
                <asp:listitem Value="Family">Family</asp:listitem>
                  <asp:listitem Value="Secret">Secret</asp:listitem>
                <asp:listitem Value="FamilySecret">Family Secret</asp:listitem>
             
              </asp:dropdownlist>
              <asp:Button ID="Button1" runat="server" style="text-align: center" Text="UpDate Picture Status"
                BackColor="#4b6c9e" ForeColor="white" Width="146px" />


              <br />

              <asp:Button ID="btnContact" runat="server" style="text-align: center" Text="Create Contact"
                BackColor="#4b6c9e" ForeColor="white" />

              <asp:Button ID="btnViewStatus" runat="server" style="text-align: center" Text="View Contact"
                BackColor="#4b6c9e" ForeColor="white" />

              <br />
              <asp:Button ID="btnMakeConnection" runat="server" Text="Make A Contact" BackColor="#4b6c9e"
                ForeColor="white" Width="140px" />

                <br />

            <asp:Button ID="btnChat" runat="server" Text="Chat" BackColor="#4b6c9e" ForeColor="white" Width="50px" />


              <asp:Button ID="btnSearch" runat="server" Text="Search" BackColor="#4b6c9e"
                ForeColor="white" Width="63px" />

              <p>
                  
                  <font size="5">
                   </font>
                    <hr />
                <asp:Label ID="Label19" runat="server" Text="Associations"></asp:Label>
                </font></b>
                <hr />
                    
                <asp:ListView ID="AssociationListView" runat="server" DataSourceID="AssociationRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="Relationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">

                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                         <asp:HyperLink ID="Hyperlink38" Text="PrivateChat" runat="server"
                    NavigateUrl='<%# "PrivateChat.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                  <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>
                    </td>
                  </ItemTemplate>
                 </asp:ListView>

                <asp:sqldatasource id="AssociationRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Association And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Association And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Association" type="String" QueryStringField="Association"
                      DefaultValue="Association" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                  <hr />
                </font></b>
                <asp:Label ID="Label25" runat="server" Text="Aquintences"></asp:Label>
                <hr />
                <asp:ListView ID="AquintenceRelationshipListView" runat="server" DataSourceID="AquintenceRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">



                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />

                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>
                    </td>
                  </ItemTemplate>

                </asp:ListView>


                <asp:SqlDataSource id="AquintenceRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Aquintences And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Aquintences And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Aquintences" type="String" QueryStringField="Aquintences"
                      DefaultValue="Aquintences" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:SqlDataSource>
                  <b>
                  <font size="5">
                    <hr />
                  </font>
                </b>
                <asp:Label ID="Label26" runat="server" Text="The List"></asp:Label>
                <hr />



                <asp:ListView ID="TheListRelationshipListView" runat="server" DataSourceID="TheListRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="Relationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>



                </asp:ListView>

                <asp:sqldatasource id="TheListRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Thelist And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Thelist And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="TheList" type="String" QueryStringField="TheList"
                      DefaultValue="TheList" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>
                <hr />
                <asp:Label ID="Label27" runat="server" Text="In The Know"></asp:Label>
                <hr />


                <asp:ListView ID="InTheKnowRelationshipListView" runat="server" DataSourceID="InTheKnowRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2  ")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>

                <asp:sqldatasource id="InTheKnowRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @InTheKnow And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @InTheKnow And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="InTheKnow" type="String" QueryStringField="InTheKnow"
                      DefaultValue="InTheKnow" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>


                <hr />
                <asp:Label ID="Label29" runat="server" Text="Knows Of"></asp:Label>
                <hr />


                <asp:ListView ID="KnowsOfRelationshipListView" runat="server" DataSourceID="KnowsOfRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>


                <asp:sqldatasource id="KnowsOfRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @KnowsOf And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @KnowsOf And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="KnowsOf" type="String" QueryStringField="KnowsOf"
                      DefaultValue="KnowsOf" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                </font></b>
                <asp:Label ID="Label28" runat="server" Text="Knows"></asp:Label>
                <hr />

                <asp:ListView ID="KnowsRelationshipListView" runat="server" DataSourceID="KnowsRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>



                </asp:ListView>




                <asp:sqldatasource id="KnowsRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Knows And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Knows And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Knows" type="String" QueryStringField="Knows"
                      DefaultValue="Knows" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>


                <hr />
                <asp:Label ID="Label30" runat="server" Text="Friends"></asp:Label>
                <hr />

                <asp:ListView runat="server" ID="FriendsRelationshipListView" DataSourceID="FriendsRelationship"
                  GroupItemCount="5" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>

                </asp:ListView>

                <asp:SqlDataSource id="FriendsRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Friends And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Friends And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Friends" type="String" QueryStringField="Friends"
                      DefaultValue="Friends" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>

                </asp:SqlDataSource>
                <hr />
                <asp:Label ID="Label31" runat="server" Text="Want To Date"></asp:Label>
                <hr />


                <asp:ListView ID="WantToDateRelationshipListView" runat="server" DataSourceID="WantToDateRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     
                      <asp:HyperLink ID="Hyperlink38" Text="PrivateChat" runat="server"
                        NavigateUrl='<%# "PrivateChat.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>

                <asp:sqldatasource id="WantToDateRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @WantToDate And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @WantToDate And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="WantToDate" type="String" QueryStringField="WantToDate"
                      DefaultValue="WantToDate" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>
                <hr />


                <asp:Label ID="Label32" runat="server" Text="Dateing"></asp:Label>
                <hr />


                <asp:ListView ID="DateingRelationshipListView" runat="server" DataSourceID="DateingRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     
                                           <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>



                </asp:ListView>

                <asp:sqldatasource id="DateingRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Dateing And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Dateing And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Dateing" type="String" QueryStringField="Dateing"
                      DefaultValue="Dateing" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                <asp:Label ID="Label33" runat="server" Text="Fiances"></asp:Label>
                <hr />
                <asp:ListView ID="FiancesRelationshipListView" runat="server" DataSourceID="FianceRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>






                </asp:ListView>

                <asp:sqldatasource id="FianceRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Fiances And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Fiances And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Fiances" type="String" QueryStringField="Fiances"
                      DefaultValue="Fiances" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                <asp:Label ID="Label34" runat="server" Text="Fiancees"></asp:Label>
                <hr />
                <asp:ListView ID="FianceesRelationshipListView" runat="server" DataSourceID="FianceesRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>


                <asp:sqldatasource id="FianceesRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Fiancees And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Fiancees And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Fiancees" type="String" QueryStringField="Fiancees"
                      DefaultValue="Fiancees" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                <asp:Label ID="Label35" runat="server" Text="Married"></asp:Label>
                <hr />
                <asp:ListView ID="MarriedRelationshipListView" runat="server" DataSourceID="MarriedRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>



                </asp:ListView>

                <asp:sqldatasource id="MarriedRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Married And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Married And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Married" type="String" QueryStringField="Married"
                      DefaultValue="Married" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                <asp:Label ID="Label36" runat="server" Text="Divorce"></asp:Label>
                <hr />
                <asp:ListView ID="DivorceRelationshipListView" runat="server" DataSourceID="DivorceRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                     
                     
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>

                <asp:sqldatasource id="DivorceRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Divorce And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Divorce And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Divorce" type="String" QueryStringField="Divorce"
                      DefaultValue="Divorce" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>

                <hr />
                <asp:Label ID="Label37" runat="server" Text="Divorcee"></asp:Label>
                <hr />
                <asp:ListView ID="DivorceeRelationshipListView" runat="server" DataSourceID="DivorceeRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblRelationship" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">


                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="Row" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                                            <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>




                </asp:ListView>
                <asp:sqldatasource id="DivorceeRelationship" runat="server"
                  connectionstring="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Divorcee And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Divorcee And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Divorcee" type="String" QueryStringField="Divorcee"
                      DefaultValue="Divorcee" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>
                </asp:sqldatasource>


                <hr />
                <asp:Label ID="Label38" runat="server" Text="Non-Biological Family"></asp:Label>
                <hr />
                <asp:ListView runat="server" ID="NonBiologicaFamilyRelationshipListView"
                  DataSourceID="NonBiologicalFamilyRelationship" GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>

                </asp:ListView>

                <asp:SqlDataSource id="NonBiologicalFamilyRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @NonBiologicalFamily And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @NonBiologicalFamily And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="NonBiologicalFamily" type="String"
                      QueryStringField="NonBiologicalFamily" DefaultValue="NonBiologicalFamily" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>

                </asp:SqlDataSource>



                <hr />
                <asp:Label ID="Label39" runat="server" Text="Family"></asp:Label>
                <hr />


                <asp:ListView runat="server" ID="FamilyRelationshipListView" DataSourceID="FamilyRelationship"
                  GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                   
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>

                </asp:ListView>

                <br />

                <asp:SqlDataSource id="FamilyRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Family And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Family And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Family" type="String" QueryStringField="Family"
                      DefaultValue="Family" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>

                </asp:SqlDataSource>

                   <hr />
                <asp:Label ID="Label2" runat="server" Text="Secret"></asp:Label>
                <hr />

                <asp:ListView runat="server" ID="SecretRelationshipListView" DataSourceID="SecretRelationship" GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                    
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>

                </asp:ListView>

                     <asp:SqlDataSource id="SecretRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @Secret And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @Secret And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="Secret" type="String" QueryStringField="Secret" DefaultValue="Secret" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>

                </asp:SqlDataSource>


                <hr />
                <asp:Label ID="Label1" runat="server" Text="Family Secret"></asp:Label>
                <hr />

                <asp:ListView runat="server" ID="FamilySecretRelationshipListView"
                  DataSourceID="FamilySecretRelationship" GroupItemCount="2" DataKeyNames="IDSS">
                  <LayoutTemplate>
                    <table cellpadding="2" runat="server" id="tblProducts" style="height:320px">
                      <tr runat="server" id="GroupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager" PageSize="4">
                      <Fields>
                        <asp:NumericPagerField ButtonCount="3" PreviousPageText="<--" NextPageText="-->" />
                      </Fields>
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow" style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td id="Td1" valign="top" align="center" style="width:100" runat="server">
                      <asp:HyperLink ID="Hyperlink4" runat="server" ImageURL='<%# Eval("URLOfPicture")%>'
                        CssClass="link" />
                      <br />
                      <asp:HyperLink ID="Hyperlink1"
                        Text='<%#Eval("firstname2") & Eval("MiddleName2") & Eval("LastName2")%>' runat="server"
                        NavigateUrl='<%# "default.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink3" Text="Leave A Message" runat="server"
                        NavigateUrl='<%# "leaveamessage.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink6" Text="Get a message" runat="server"
                        NavigateUrl='<%# "viewmessages.aspx?ID=" & Eval("RelationshipID") & "&IDSS=" & Eval("IDSS") %>' />
                      <br />
                                         
                      <asp:HyperLink ID="Hyperlink2" Text="I Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&IDisapproved=Deleted" & "&ID=" & Eval("ID")   %>' />
                      <br />
                      <asp:HyperLink ID="Hyperlink39" Text="You Delete" runat="server"
                        NavigateUrl='<%# "default.aspx?IDSS=" & Eval("IDSS") & "&YouDisapproved=Deleted" & "&ID=" & Eval("RelationshipID")   %>' />
                      <br />
                      <asp:Label ID="Label6" runat="server" Text="Picture ID"></asp:Label>
                      <br />
                      <asp:Label ID="Label5" runat="server" Text='<%# Eval("IDSS")%>'></asp:Label>

                    </td>
                  </ItemTemplate>

                </asp:ListView>

                <asp:SqlDataSource id="FamilySecretRelationship" runat="server"
                  ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                  SelectCommand="SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.RelationshipID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.RelationshipID = B.ID WHERE (A.[Relationships] = @FamilySecret And A.[ID] = @ID And A.[Approved] = '1') UNION SELECT A.IDSS AS [IDSS], B.ID AS [ID], A.ID AS [RelationshipID], B.URLOfPIcture AS [URLOfPicture], B.FirstName AS [firstname2], B.MiddleName AS [MiddleName2], B.LastName AS [LastName2] FROM [tblRegisteredUsers] AS A INNER JOIN [tblRegistered] AS B ON A.ID = B.ID WHERE (A.[Relationships] = @FamilySecret And A.[RelationshipID] = @ID And A.[Approved] = '1')">
                  <SelectParameters>
                    <asp:QueryStringParameter Name="FamilySecret" type="String" QueryStringField="FamilySecret"
                      DefaultValue="FamilySecret" />
                    <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                  </SelectParameters>

                </asp:SqlDataSource>


                    <asp:HyperLink id="hyperlink2" 
                  ImageUrl=""
                  NavigateUrl="~/privacy.aspx"
                  Text="Privacy"
                  Target="_new"
                  runat="server"/>
                  &nbsp;|
                  </asp:HyperLink>
                  
                  <asp:HyperLink id="hyperlink3" 
                  ImageUrl=""
                  NavigateUrl="~/TermsOfUse.aspx"
                  Text="Terms Of Use"
                  Target="_new"
                  runat="server"/>
                  </asp:HyperLink> 

                <br />

            </center>

    </center>


    </form>

    <asp:SqlDataSource id="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
      insertcommand="INSERT INTO tblRegisteredUsers (ID,RelationshipID,URLOfPicture,firstname1,MiddleName1,LastName1,firstname2,MiddleName2,LastName2,LoggedInEmail,RelationshipEmail,FollowUnfollow,Relationships,Approved,DateTime)
        VALUES (@ID,@RelationshipID,@URLOfPicture,@firstname1,@MiddleName1,@LastName1,@firstname2,@MiddleName2,@LastName2,@LoggedInEmail,@RelationshipEmail,@FollowUnfollow,@Relationships,@Approved,@DateTime)">
        
    </asp:SqlDataSource>

    <asp:SqlDataSource id="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
      SelectCommand="SELECT [ID], [UrlOfPicture], [firstname], [MiddleName], [lastname]  FROM [tblRegistered]  WHERE ([ID] = @ID)">
      <SelectParameters>
        <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
      </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource id="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource2 %>"
      SelectCommand="SELECT [ID], [IDSS], [UrlOfPicture], [firstname], [MiddleName], [lastname]  FROM [tblRegistered]">
    </asp:SqlDataSource>


    <asp:SqlDataSource id="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1%>"
      UpdateCommand="UPDATE [tblRegisteredUsers] SET [Relationships] = @Relationships  WHERE ([ID] = @ID)">
      <UpDateParameters>
        <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
        <asp:Parameter Name="DateTime" type="String" />
      </UpDateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource id="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
      SelectCommand="SELECT [ID], [idss], [UrlOfPicture], [firstname1], [MiddleName1], [lastname1] FROM [tblRegisteredUsers] WHERE ([ID] = @ID OR [RelationshipID] = @ID)">
      <SelectParameters>
        <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
      </SelectParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource id="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
      insertcommand="INSERT INTO tblIdeleted (ID,RelationshipEmail,RelationshipID,URLOfPicture,firstname1,MiddleName1,LastName1,firstname2,MiddleName2,LastName2,LoggedInEmail,FollowUnFollow,Relationships,IDeleted,DateTime)
        VALUES (@ID,@RelationshipEmail,@RelationshipID,@URLOfPIcture,@firstname1,@MiddleName1,@LastName1,@firstname2,@MiddleName2,@LastName2,@LoggedInEmail,@FollowUnfollow,@Relationships,@IDeleted,@DateTime)">

    </asp:SqlDataSource>

    <asp:SqlDataSource id="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1%>"
      UpdateCommand="UPDATE [tblRegisteredUsers] SET [Relationships] = @Relationships WHERE [IDSS] = @IDSS">
      <UpDateParameters>
        <asp:ControlParameter Name="IDSS" ControlId="DropDownList2" PropertyName="SelectedValue" />
      </UpDateParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource id="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
      insertcommand="INSERT INTO tblYouDeleted (ID,RelationshipEmail,RelationshipID,URLOfPicture,firstname1,MiddleName1,LastName1,FirstName2,MiddleName2,LastName2,LoggedInEmail,FollowUnFollow,Relationships,YouDeleted,DateTime)
        VALUES (@ID,@RelationshipEmail,@RelationshipID,@URLOfPIcture,@firstname1,@MiddleName1,@LastName1,@FirstName2,@MiddleName2,@LastName2,@LoggedInEmail,@FollowUnfollow,@Relationships,@YouDeleted,@DateTime)">



    </asp:SqlDataSource>

    <center>

    </center>
  </body>

  </html>