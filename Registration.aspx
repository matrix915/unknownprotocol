<%@ Page Title="Registration" Language="VB" AutoEventWireup="false" CodeFile="Registration.aspx.vb"
    Inherits="Registration" %>


    <!DOCTYPE html
        PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
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
    </style>    </head>

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
                        <div class="loginDisplay">

                            <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">

                                <LoggedInTemplate>

                                </LoggedInTemplate>
                            </asp:LoginView>

                            <asp:Button ID="btnLogout" CausesValidation="False" runat="server" Text="Login" />

                        </div>
                        <div class="clear hideSkiplink">
                            <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false"
                                IncludeStyleBlock="false" Orientation="Horizontal">
                                <Items>
                                    <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignUp">
                                    </asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/contact.aspx" Text="Contacts" Value="Contacts">
                                    </asp:MenuItem>
                                     <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password"
                                        Value="Change Password"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/ForgotUsername.aspx" Text="Forgot Username"
                                        Value="Forgot Username"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password"
                                        Value="Forgot Password"></asp:MenuItem>
                                   <asp:MenuItem NavigateUrl="~/DeleteContact.aspx" Text="Delete Contact"
                                        Value="Delete Contact"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                        </div>
                </div>
                <div class="main">
                    <fieldset>
                        <legend>Registration</legend>
                        <center>


                            <table>
                                <tr>
                                    <td colspan="2" style="text-align: left">
                                        <hr />
                                    </td>
                                </tr>


                                <tr>
                                    <td class="style6">
                                        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtFirstName" runat="server" MaxLength="20"
                                            CssClass="textEntry"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                                            Text="Required!" ControlToValidate="txtFirstName">
                                        </asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                            ErrorMessage="Enter alphabetic characters and or apothrophes only."
                                            ControlToValidate="txtFirstName"
                                            ValidationExpression="^[a-zA-Z0-9'.\s]{1,40}$" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                        <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtMiddleName" runat="server" MaxLength="20"
                                            CssClass="textEntry"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="RequiredFieldValidator27" runat="server"
                                            Text="Required!" ControlToValidate="txtMiddleName">
                                        </asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator27" runat="server"
                                            ErrorMessage="Enter alphabetic characters and or apothrophes only."
                                            ControlToValidate="txtFirstName"
                                            ValidationExpression="^[a-zA-Z0-9'.\s]{1,40}$" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style10">
                                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtLastName" runat="server" MaxLength="20"
                                            CssClass="textEntry"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="RequiredFieldValidator28" runat="server"
                                            Text="Required!" ControlToValidate="txtFirstName">
                                        </asp:RequiredFieldValidator>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                        <asp:Label ID="lblPictureUpload" runat="server" Text="Upload Picture">
                                        </asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:FileUpload ID="FileUpload" CssClass="textEntry" runat="server" />
                                        <br />

                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">Address</td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtAddress" runat="server" Width="266px">
                                        </asp:TextBox>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">City</td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtCity" runat="server" MaxLength="20" Width="266px">
                                        </asp:TextBox>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                        State</td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtState" runat="server" MaxLength="20" Width="266px">
                                        </asp:TextBox>

                                        <br />

                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">ZipCode</td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtZipCode" runat="server" MaxLength="20" Width="266px">
                                        </asp:TextBox>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">Country</td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtCountry" runat="server" MaxLength="20" Width="266px">
                                        </asp:TextBox>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtEmail" runat="server" MaxLength="40" CssClass="textEntry">
                                        </asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server"
                                            Text="Required!" ControlToValidate="txtEmail">
                                        </asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server"
                                            display="dynamic" ControlToValidate="txtEmail"
                                            ErrorMessage="Enter a valid email."
                                            ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                        <br />
                                        <asp:Label ID="lblIDCheck" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" MaxLength="10"
                                            CssClass="textEntry"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="RequiredFieldValidator25" runat="server"
                                            Text="Required!" ControlToValidate="txtPassword">
                                        </asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator25" runat="server"
                                            display="dynamic" ControlToValidate="txtPassword"
                                            ErrorMessage="Password must be 10 characters, contain at least one digit, one alphabetic character and one special character."
                                            ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{10,}$" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                    </td>
                                    <td class="style8"><br />


                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">&nbsp;</td>
                                    <td class="style8"><br />
                                        <center>
                                        <asp:Button ID="Connect" runat="server" style="text-align: center" Text="Send"
                                            BackColor="#4b6c9e" ForeColor="white" />
                                        <asp:Button ID="Reset" runat="server" style="text-align: center" Text="Reset"
                                            BackColor="#4b6c9e" ForeColor="white" />
                                            
                                        <br />
                                        <br />
                                    </td>
                                    <td class="style8">&nbsp;</td>
                                </tr>
                                <tr>

                                    <td class="style9">&nbsp;</td>
                                    <td class="style7">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">

                                        &nbsp;</td>
                                </tr>

                            </table>

                            <asp:HyperLink id="hyperlink2" ImageUrl="" NavigateUrl="~/privacy.aspx" Text="Privacy"
                                Target="_self" runat="server" />
                            &nbsp;|
                            </asp:HyperLink>

                            <asp:HyperLink id="hyperlink3" ImageUrl="" NavigateUrl="~/termsofuse.aspx"
                                Text="Terms Of Use" Target="_self" runat="server" />
                            </asp:HyperLink>
                        </center>
                        </form>

                        <asp:sqldatasource id="RegisterInsert" runat="server"
                            connectionstring="<%$ ConnectionStrings:SqlDataSource1%>"
                            insertcommand="INSERT INTO tblRegistered (URLOfPicture,FirstName,MiddleName,LastName,countries,states,cities,zipcode,address,FollowUnfollow,Email,Password,DateTime)
        VALUES (@URLOfPicture,@FirstName,@MiddleName,@LastName,@countries,@states,@cities,@zipcode,@address,@FollowUnfollow,@Email,@Password,@DateTime)">
                            <insertparameters>
                                <asp:FormParameter Name="PictureURL" formfield="FileUpload" />
                                <asp:FormParameter name="FirstName" formfield="txtFirstName" />
                                <asp:FormParameter name="Middlename" formfield="txtMiddleName" />
                                <asp:FormParameter name="LastName" formfield="txtLastName" />
                                <asp:FormParameter Name="countries" formfield="txtCountry" />
                                <asp:FormParameter Name="states" formfield="txtState" />
                                <asp:FormParameter Name="cities" formfield="txtCity" />
                                <asp:FormParameter Name="zipcode" formfield="txtZipCode" />
                                <asp:FormParameter Name="address" formfield="txtAddress" />
                                <asp:FormParameter Name="Email" formfield="txtEmail" />
                                <asp:FormParameter Name="Password" formfield="txtPassword" />
                            </insertparameters>
                        </asp:sqldatasource>


                        <script>
                            function initMaps() {
                                initAutocomplete();
                                // initializeMap();
                            }

                            function initAutocomplete() {
                                autocomplete = new google.maps.places.Autocomplete(
                                    document.getElementById('txtAddress'),
                                    {
                                        types: ['geocode', 'establishment']
                                    }
                                );
                                autocomplete.setFields(['geometry', 'formatted_address', 'address_components']);
                                autocomplete.addListener('place_changed', fillInAddress);
                            }

                            function fillInAddress() {
                                var place = autocomplete.getPlace();
                                document.getElementById('txtAddress').value = place.formatted_address.split(',')[0];
                                for (var i = 0; i < place.address_components.length; i++) {
                                    for (var j = 0; j < place.address_components[i].types.length; j++) {
                                        if (place.address_components[i].types[j] == "postal_code") {
                                            document.getElementById('txtZipCode').value = place.address_components[i].long_name;
                                        }
                                        if (place.address_components[i].types[j] == "locality") {
                                            document.getElementById('txtCity').value = place.address_components[i].long_name;
                                        }
                                        if (place.address_components[i].types[j] == "country") {
                                            document.getElementById('txtCountry').value = place.address_components[i].long_name;
                                        }
                                        if (place.address_components[i].types[j] == "administrative_area_level_1") {
                                            document.getElementById('txtState').value = place.address_components[i].long_name;
                                        }
                                    }
                                }

                                //document.getElementById("Connect").click();
                            }

                            function geolocate() {
                                if (navigator.geolocation) {
                                    navigator.geolocation.getCurrentPosition(function (position) {
                                        var geolocation = { lat: position.coords.latitude, lng: position.coords.longitude };
                                        var circle = new google.maps.Circle({ center: geolocation, radius: position.coords.accuracy });
                                        autocomplete.setBounds(circle.getBounds());
                                    });
                                }
                            }
                        </script>
                        <script defer async
                            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBSjbe9_hIWU4o7N2RevIQu1zdH48BJL70&libraries=places&callback=initMaps&language=en"></script>

    </body>

    </html>