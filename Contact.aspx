<%@ Page Title="Contact" Language="VB" AutoEventWireup="false" EnableEventValidation="False"
    CodeFile="Contact.aspx.vb" Inherits="Contact" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
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

        body {
            font-size: 12px;
        }

        a:link, a:visited {
            color: #034af3;
            font-size: 12px;
        }

        a:hover {
            color: #1d60ff;
            text-decoration: none;
            font-size: 12px;
        }

        a:active {
            color: #034af3;
            font-size: 12px;
        }

        p {
            margin-bottom: 10px;
            line-height: 1.6em;
        }

        .link img {
            height: 100px;
            width: 100px;
            border: 0px;
        }
        /* HEADINGS   
----------------------------------------------------------*/

        h1, h2, h3, h4, h5, h6 {
            font-size: 12px;
            color: #666666;
            font-variant: small-caps;
            text-transform: none;
            font-weight: 200;
            margin-bottom: 0px;
        }

        h1 {
            font-size: 12px;
            padding-bottom: 0px;
            margin-bottom: 0px;
        }

        h2 {
            font-size: 12px;
            font-weight: 600;
        }

        h3 {
            font-size: 12px;
        }

        h4 {
            font-size: 12px;
        }

        h5, h6 {
            font-size: 12px;
        }

        /* this rule styles <h1> and <h2> tags that are the 
first child of the left and right table columns */
        .rightColumn > h1, .rightColumn > h2, .leftColumn > h1, .leftColumn > h2 {
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

        .header {
            position: relative;
            margin: 0px;
            padding: 0px;
            background: #4b6c9e;
            width: 100%;
        }

            .header h1 {
                font-weight: 700;
                margin: 0px;
                padding: 0px 0px 0px 20px;
                color: #f9f9f9;
                border: none;
                line-height: 2em;
                font-size: 2em;
            }

        .main {
            padding: 0px 12px;
            margin: 12px 8px 8px 8px;
            min-height: 420px;
        }

        .leftCol {
            padding: 6px 0px;
            margin: 12px 8px 8px 8px;
            width: 200px;
            min-height: 200px;
        }

        .footer {
            color: #4e5766;
            padding: 8px 0px 0px 0px;
            margin: 0px auto;
            text-align: center;
            line-height: normal;
        }


        /* TAB MENU   
----------------------------------------------------------*/

        div.hideSkiplink {
            background-color: #3a4f63;
            width: 100%;
            color: #FFFFFF;
        }

        div.menu {
            padding: 4px 0px 4px 8px;
        }

            div.menu ul {
                list-style: none;
                margin: 0px;
                padding: 0px;
                width: auto;
                display: flex;
                justify-content: center;
            }

                div.menu ul li a, div.menu ul li a:visited {
                    background-color: #465c71;
                    border: 1px #4e667d solid;
                    color: #dde4ec;
                    display: block;
                    line-height: 1.35em;
                    padding: 4px 20px;
                    text-decoration: none;
                    white-space: nowrap;
                }

                    div.menu ul li a:hover {
                        background-color: #bfcbd6;
                        color: #465c71;
                        text-decoration: none;
                    }

                    div.menu ul li a:active {
                        background-color: #465c71;
                        color: #cfdbe6;
                        text-decoration: none;
                    }

        /* FORM ELEMENTS   
----------------------------------------------------------*/

        fieldset {
            margin: 1em 0px;
            padding: 1em;
            border: 1px solid #ccc;
        }

            fieldset p {
                margin: 2px 12px 10px 10px;
            }

            fieldset.login label, fieldset.register label, fieldset.changePassword label {
                display: block;
            }

            fieldset label.inline {
                display: inline;
            }

        legend {
            font-size: 1.1em;
            font-weight: 600;
            padding: 2px 4px 8px 4px;
        }

        input.textEntry {
            width: 320px;
            border: 1px solid #ccc;
        }

        input.passwordEntry {
            width: 320px;
            border: 1px solid #ccc;
        }

        div.accountInfo {
            width: 42%;
        }

        /* MISC  
----------------------------------------------------------*/

        .clear {
            clear: both;
        }

        .title {
            display: block;
            float: left;
            text-align: left;
            width: auto;
        }

        .loginDisplay {
            font-size: 1.1em;
            display: block;
            text-align: right;
            padding: 10px;
            color: White;
        }

            .loginDisplay a:link {
                color: white;
            }

            .loginDisplay a:visited {
                color: white;
            }

            .loginDisplay a:hover {
                color: white;
            }

        .failureNotification {
            font-size: 1.2em;
            color: Red;
        }

        .bold {
            font-weight: bold;
        }

        .button {
            font-size: 6px;
        }

        .submitButton {
            text-align: right;
            padding-right: 10px;
        }

        .style3 {
            width: 960px;
        }

        .style5 {
            text-align: center;
        }

        .auto-style1 {
            width: 100%;
        }
    </style>

    <script type="text/javascript">
        function SessionExpire(timeout) {
            console.log('session start');
            setTimeout(function () {
                document.getElementById("btnLogout").click();
            }, timeout + 2000);
        }
    </script>

</head>
<body attr='<%= Email %>'>

    <div class="page">
        <div class="header">
            <div class="title">
                <h1>unknownprotocol
                </h1>
            </div>

            <form id="Form" runat="server">

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
                            <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignSC"></asp:MenuItem>
                            <asp:MenuItem Text="Contacts" Value="Contacts"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/forgotUsername.aspx" Text="Forgot Username" Value="Forgot Username"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Forgot Password"></asp:MenuItem>

                            <asp:MenuItem NavigateUrl="~/DeleteContact.aspx" Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </div>
        </div>

        <div class="auto-style1">

            <asp:DataGrid ID="ItemsGrid" runat="server"
                CellPadding="4"
                UseAccessibleHeader="True"
                AutoGenerateColumns="False"
                PageSize="10"
                AllowPaging="True"
                ForeColor="#333333"
                OnPageIndexChanged="ItemsGrid_PageIndexChanged"
                OnItemCommand="ItemsGrid_ItemCommand"
                GridLines="None" Font-Bold="False" Font-Italic="False"
                Font-Names="Times New Roman" Font-Overline="False" Font-Size="12pt"
                Font-Strikeout="False" Font-Underline="False" Width="100%">

                <EditItemStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

                <HeaderStyle Font-Size="12pt" Font-Bold="True" HorizontalAlign="Left"
                    ForeColor="White" BackColor="#5D7B9D" Font-Italic="False"
                    Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>

                <AlternatingItemStyle BackColor="White" ForeColor="#284775"></AlternatingItemStyle>

                <Columns>

                    <asp:TemplateColumn HeaderText="Photo">

                        <ItemTemplate>
                            <asp:Image ID="Image2" ImageUrl='<%# Eval("URLOfPicture")%>' Visible='<%#Convert.ToString(Eval("URLOfPicture")) <> ""%>' runat="server" Height="100px" Width="100px" />

                        </ItemTemplate>

                    </asp:TemplateColumn>

                    <asp:HyperLinkColumn HeaderText="First Name" DataTextField="FirstName"
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="~/default.aspx?ID={0}"></asp:HyperLinkColumn>

                    <asp:HyperLinkColumn HeaderText="Middle Name" DataTextField="MiddleName"
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="~/default.aspx?ID={0}"></asp:HyperLinkColumn>

                    <asp:HyperLinkColumn HeaderText="Last Name" DataTextField="LastName"
                        DataNavigateUrlField="ID" DataNavigateUrlFormatString="~/default.aspx?ID={0}"></asp:HyperLinkColumn>
                     
                    <asp:TemplateColumn HeaderText="RelationshipGroup">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlRelationship" runat="server">
                                <asp:ListItem Value="">Select</asp:ListItem>
                                <asp:ListItem Value="Invisable">Invisable</asp:ListItem>
                                <asp:ListItem Value="Association">Association</asp:ListItem>
                                <asp:ListItem Value="Aquintences">Aquintences</asp:ListItem>
                                <asp:ListItem Value="TheList">The List</asp:ListItem>
                                <asp:ListItem Value="InTheKnow">In The Know</asp:ListItem>
                                <asp:ListItem Value="KnowsOf">Knows Of</asp:ListItem>
                                <asp:ListItem Value="Knows">Knows</asp:ListItem>
                                <asp:ListItem Value="Friends">Friends</asp:ListItem>
                                <asp:ListItem Value="WantToDate">Want To Date</asp:ListItem>
                                <asp:ListItem Value="Dateing">Dateing</asp:ListItem>
                                <asp:ListItem Value="Fiances">Fiances</asp:ListItem>
                                <asp:ListItem Value="Fiancees">Fiancees</asp:ListItem>
                                <asp:ListItem Value="Married">Married</asp:ListItem>
                                <asp:ListItem Value="Divorce">Divorce</asp:ListItem>
                                <asp:ListItem Value="Divorcee">Divorcee</asp:ListItem>
                                <asp:ListItem Value="NonBiologicalFamily">Non-Biological Family</asp:ListItem>
                                <asp:ListItem Value="Family">Family</asp:ListItem>
                                <asp:ListItem Value="Secret">Secret</asp:ListItem>
                                <asp:ListItem Value="FamilySecret">Family Secret</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:ButtonColumn ButtonType="PushButton" CommandName="Select" HeaderText="-" Text="Add contact"></asp:ButtonColumn>
                    <asp:BoundColumn DataField="ID" HeaderText="rowID" Visible="False"></asp:BoundColumn>

                </Columns>


                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <PagerStyle BackColor="#284775" ForeColor="White"
                    HorizontalAlign="Center" PrevPageText="Previous" NextPageText="Next" />
                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
        </div>



        </form>
   
    <br />

        <center>

            <font size="5">
                <asp:HyperLink ID="hyperlink2"
                    ImageUrl=""
                    NavigateUrl="~/privacy.aspx"
                    Text="Privacy"
                    Target="_self"
                    runat="server" />
                </asp:HyperLink>
                  
                      |
                  <asp:HyperLink ID="hyperlink3"
                      ImageUrl=""
                      NavigateUrl="~/termsofuse.aspx"
                      Text="Terms Of Use"
                      Target="_self"
                      runat="server" />
                 </asp:HyperLink> 

        </center>
</body>
</html>
