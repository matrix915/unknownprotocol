<%@ Page Language="VB" AutoEventWireup="false" EnableEventValidation="false" CodeFile="unknownprotocol.asp.vb"
    Inherits="unknownprotocol" %>

<!DOCTYPE html
        PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta http-equiv="Content-Language" content="en-us" />
    <meta http-equiv="Content-Type" content="text/html; charset=windows-1252" />
    <title>Untitled</title>

    <style type="text/css">
        /* DEFAULTS
----------------------------------------------------------*/

        body {
            font-size: 12px;
        }

        a:link,
        a:visited {
            color: #034af3;
        }

        a:hover {
            color: #1d60ff;
            text-decoration: none;
        }

        a:active {
            color: #034af3;
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

        h1,
        h2,
        h3,
        h4,
        h5,
        h6 {
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

        h5,
        h6 {
            font-size: 12px;
        }

        /* this rule styles <h1> and <h2> tags that are the 
first child of the left and right table columns */
        .rightColumn > h1,
        .rightColumn > h2,
        .leftColumn > h1,
        .leftColumn > h2 {
            margin-top: 0px;
        }


        /* PRIMARY LAYOUT ELEMENTS   
----------------------------------------------------------*/

        .page {
            width: 500px;
            background-color: #fff;
            margin: auto auto 0px 250px;
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
            }

                div.menu ul li a,
                div.menu ul li a:visited {
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

            fieldset.login label,
            fieldset.register label,
            fieldset.changePassword label {
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

        .auto-style4 {
            width: 85px;
        }

        .auto-style6 {
            width: 88px;
        }

        .auto-style10 {
            width: 91px;
        }

        .hide {
            display: none;
        }

        /* Update Panel Styling */
        #UpdatePanel1 {
            height: 350px;
            border: 1px solid #eee;
            overflow-y: auto;
        }

        .input-text {
            border: 1px solid #000;
            display: flex;
            border-radius: 10px;
        }

            .input-text span {
                font-size: xx-large;
                line-height: 1;
            }

            .input-text input {
                border: none;
                outline: none;
                border-top-right-radius: 10px;
                border-bottom-right-radius: 10px;
            }

        /*  File, Address */
        .address-block {
            margin-top: 10px;
            display: flex;
        }

        .address-block label {
            font-size: 14px;
            line-height: 1.5em;
        }
        .auto-style11 {
            width: 123px;
        }
        .auto-style12 {
            width: 97px;
        }
        .auto-style13 {
            width: 95px;
        }
    </style>
    <script src="./emoji/fgEmojiPicker.js"></script>
    <script type="text/javascript">
        function SessionExpire(timeout) {
            setTimeout(function () {
                document.getElementById("btnLogout").click();
            }, timeout + 2000);
        }
    </script>
</head>

<body>
    <center>
        <form id="form1" runat="server">
            <div class="page">
                <div class="header">
                    <div class="title">
                        <h1>PROTOTYPE
                        </h1>
                    </div>

                    <div class="loginDisplay">

                        <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">

                            <LoggedInTemplate>
                            </LoggedInTemplate>
                        </asp:LoginView>

                        <asp:Button ID="btnLogout" CausesValidation="False" runat="server" Text="Log Out" UseSubmitBehavior="False" />

                    </div>
                    <div class="clear hideSkiplink">
                        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false"
                            IncludeStyleBlock="false" Orientation="Horizontal" OnMenuItemClick="NavigationMenu_MenuItemClick">
                            <Items>
                                <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="Registration"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/status.aspx" Text="Contacts" Value="Contacts"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password"
                                    Value="Change Password"></asp:MenuItem>
                               <asp:MenuItem NavigateUrl="~/forgotUsername.aspx" Text="Forgot Username"
                                    Value="Change Password"></asp:MenuItem>
                                 <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password"
                                    Value="Retrieve Password"></asp:MenuItem>
                                <asp:MenuItem Text="Update User" Value="Update User"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="DeleteUser.aspx" Text="Delete User" Value="Delete User"></asp:MenuItem>
                            </Items>
                        </asp:Menu>
                    </div>
                </div>
                <div class="main">
                    <asp:Label ID="labelcountries" runat="server" Text=""></asp:Label>
                    <asp:Label ID="labelstates" runat="server" Text=""></asp:Label>
                    <asp:Label ID="labelcities" runat="server" Text=""></asp:Label>
                    <asp:Label ID="labeltowns" runat="server" Text=""></asp:Label>
                    <br />
                    <div ID="UpdatePanel1">
                        <div class="WordWrap" >
                            <div id="Listview_container" class="0" style="text-align:left; padding-left:10px">

                            </div>
                        </div>
                        
                    </div>

                    <div class="address-block">
                        <asp:FileUpload ID="FileUpload" runat="server" onchange="fileValidation()" />
                        
                        <label for="address">Address:</label>
                        <asp:TextBox ID="address" runat="server" Width="295px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="input-text">
                        <span id="emoji_trigger">&#9786;</span>
                        <asp:TextBox ID="Posted" MaxLength="250" runat="server" Width="431px"></asp:TextBox>
                    </div>
                    <br />
                    <asp:TextBox ID="zipcode" runat="server" ReadOnly="true" CssClass="hide" />
                    <asp:TextBox ID="continent" runat="server" ReadOnly="true" CssClass="hide" />
                    <asp:TextBox ID="country" runat="server" ReadOnly="true" CssClass="hide" />
                    <asp:TextBox ID="state" runat="server" ReadOnly="true" CssClass="hide" />

                    <asp:Button ID="Connect" runat="server" Text="Connect" />
                    

                    <table border="1" cellpadding="0" cellspacing="0" height="178" width="450">
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbAngry" GroupName="Emotions" Text="Angry" runat="server"  />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbAnxious" GroupName="Emotions" Text="Anxious"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbBlewUp" GroupName="Emotions" Text="Blew Up" runat="server" />
                                </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbBold" GroupName="Emotions" Text="Bold" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbBored" GroupName="Emotions" Text="Bored" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbCalm" GroupName="Emotions" Text="Calm" runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbCautious" GroupName="Emotions" Text="Cautious"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbCool" GroupName="Emotions" Text="Cool" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbConfident" GroupName="Emotions" Text="Confident"
                                    runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbConfused" GroupName="Emotions" Text="Confused"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbContent" GroupName="Emotions" Text="Content"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbCrying" GroupName="Emotions" Text="Crying" runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbDepressed" GroupName="Emotions" Text="Depressed"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbDuress" GroupName="Emotions" Text="Duress" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbDiscriminated" GroupName="Emotions" Text="Discriminated"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbDisgusted" GroupName="Emotions" Text="Disgusted"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbDown" GroupName="Emotions" Text="Down"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbEcstatic" GroupName="Emotions" Text="Ecstatic"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbEmbarrassed" GroupName="Emotions" Text="Embarrassed"
                                    runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbEnraged" GroupName="Emotions" Text="Enraged"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbExhausted" GroupName="Emotions" Text="Exhausted"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbFrightend" GroupName="Emotions" Text="Frightened"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbFrustrated" GroupName="Emotions" Text="Frustrated"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbGuilty" GroupName="Emotions" Text="Guilty" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbHappy" GroupName="Emotions" Text="Happy" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbHonorable" GroupName="Emotions" Text="Honorable"
                                    runat="server" />

                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbHopeful" GroupName="Emotions" Text="Hopeful"
                                    runat="server" />

                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbHysterical" GroupName="Emotions" Text="Hysterical"
                                    runat="server" />

                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbInlove" GroupName="Emotions" Text="InLove" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbJealous" GroupName="Emotions" Text="Jealous"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbLightenedUp" GroupName="Emotions" Text="Lightened Up"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbLonley" GroupName="Emotions" Text="Lonley" runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbLoveStruck" GroupName="Emotions" Text="Love Struck"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbMad" GroupName="Emotions" Text="Mad" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbMedicated" GroupName="Emotions" Text="Medicated"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbOutOfThisWorld" GroupName="Emotions" Text="Out of this world"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbOverwhelmed" GroupName="Emotions" Text="Overwhelmed"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbPain" GroupName="Emotions" Text="Pain" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbPowerful" GroupName="Emotions" Text="Powerful"
                                    runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbProvoked" GroupName="Emotions" Text="Provoked"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbMischievous" GroupName="Emotions" Text="Mischievous"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbRelaxed" GroupName="Emotions" Text="Relaxed"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbSad" GroupName="Emotions" Text="Sad" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbSexy" GroupName="Emotions" Text="Sexy" runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbShocked" GroupName="Emotions" Text="Shocked"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbQuite" GroupName="Emotions" Text="Quite" runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbShy" GroupName="Emotions" Text="Shy" runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbSmug" GroupName="Emotions" Text="Smug" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbStressed" GroupName="Emotions" Text="Stressed"
                                    runat="server" />
                            </td>
                            <td class="auto-style6">
                                <asp:RadioButton ID="rbStupid" GroupName="Emotions" Text="Stupid" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbSuprised" GroupName="Emotions" Text="Suprised"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbSuspicious" GroupName="Emotions" Text="Suspicious"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbTired" GroupName="Emotions" Text="Tired" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbUpbeat" GroupName="Emotions" Text="Upbeat" runat="server" />
                            </td>
                             <td class="auto-style10">
                                <asp:RadioButton ID="rbUpset" GroupName="Emotions" Text="Upset" runat="server" />
                            </td>
                        </tr>
                         <tr>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbUptight" GroupName="Emotions" Text="Uptight"
                                    runat="server" />
                             </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbVengeful" GroupName="Emotions" Text="Vengeful"
                                    runat="server" />
                            </td>
                            <td class="auto-style4">
                                <asp:RadioButton ID="rbWondering" GroupName="Emotions" Text="Wondering"
                                    runat="server" />
                             </td>
                            <td class="auto-style13">
                                &nbsp;</td>
                             <td class="auto-style10">
                                 &nbsp;</td>
                        </tr>
                    </table>


                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                        ConnectionString="<%$ ConnectionStrings:SqlDataSource2%>"
                        InsertCommand="INSERT INTO tblPublicChat (ID,IDSS,URLOfPicture,FirstName,MiddleName,LastName,Posted,addresses,zipcodes,LoggedInEmail,Relationships,Emotions,DateTime)
VALUES (@ID,@IDSS,@URLOfPicture,@FirstName,@MiddleName,@LastName,@Posted,@AddressText,@ZipcodeText,@LoggedInEmail,@Relationships,@Emotions,@DateTime)">
                        <InsertParameters>
                            <asp:FormParameter Name="AddressText" Type="String" FormField="address" />
                            <asp:FormParameter Name="ContinentText" Type="String" FormField="continent" />
                            <asp:FormParameter Name="CountryText" Type="String" FormField="country" />
                            <asp:FormParameter Name="StateText" Type="String" FormField="state" />
                            <asp:FormParameter Name="ZipcodeText" Type="String" FormField="zipcode" />
                        </InsertParameters>
                    </asp:SqlDataSource>

                    <a href="../privacy.aspx">Privacy</a> | <a href="../termsofuse.aspx">Terms of us</a>
                </div>
            </div>
        </form>
    </center>
    <script>
        //document.querySelectorAll("input[type='radio']").forEach(function (obj) {
        //obj.addEventListener("click", function(){document.getElementById("Connect").click()})
        //});


        function triggerEvent(el, type) {
            // IE9+ and other modern browsers
            if ('createEvent' in document) {
                var e = document.createEvent('HTMLEvents');
                e.initEvent(type, false, true);
                el.dispatchEvent(e);
            } else {
                // IE8
                var e = document.createEventObject();
                e.eventType = type;
                el.fireEvent('on' + e.eventType, e);
            }
        }

        function addLoadEvent(func) {
            var oldonload = window.onload;
            if (typeof window.onload != 'function') {
                window.onload = func;
            } else {
                window.onload = function () {
                    if (oldonload) {
                        oldonload();
                    }
                    func();
                }
            }
        }

        addLoadEvent(function () {
            document.getElementById('Posted').value = '';
            document.getElementById('Posted').focus();
            document.getElementById('Posted').select();
        });

        var autocomplete;

        var continents = { "AD": "Europe", "AE": "Asia", "AF": "Asia", "AG": "North America", "AI": "North America", "AL": "Europe", "AM": "Asia", "AN": "North America", "AO": "Africa", "AQ": "Antarctica", "AR": "South America", "AS": "Australia", "AT": "Europe", "AU": "Australia", "AW": "North America", "AZ": "Asia", "BA": "Europe", "BB": "North America", "BD": "Asia", "BE": "Europe", "BF": "Africa", "BG": "Europe", "BH": "Asia", "BI": "Africa", "BJ": "Africa", "BM": "North America", "BN": "Asia", "BO": "South America", "BR": "South America", "BS": "North America", "BT": "Asia", "BW": "Africa", "BY": "Europe", "BZ": "North America", "CA": "North America", "CC": "Asia", "CD": "Africa", "CF": "Africa", "CG": "Africa", "CH": "Europe", "CI": "Africa", "CK": "Australia", "CL": "South America", "CM": "Africa", "CN": "Asia", "CO": "South America", "CR": "North America", "CU": "North America", "CV": "Africa", "CX": "Asia", "CY": "Asia", "CZ": "Europe", "DE": "Europe", "DJ": "Africa", "DK": "Europe", "DM": "North America", "DO": "North America", "DZ": "Africa", "EC": "South America", "EE": "Europe", "EG": "Africa", "EH": "Africa", "ER": "Africa", "ES": "Europe", "ET": "Africa", "FI": "Europe", "FJ": "Australia", "FK": "South America", "FM": "Australia", "FO": "Europe", "FR": "Europe", "GA": "Africa", "GB": "Europe", "GD": "North America", "GE": "Asia", "GF": "South America", "GG": "Europe", "GH": "Africa", "GI": "Europe", "GL": "North America", "GM": "Africa", "GN": "Africa", "GP": "North America", "GQ": "Africa", "GR": "Europe", "GS": "Antarctica", "GT": "North America", "GU": "Australia", "GW": "Africa", "GY": "South America", "HK": "Asia", "HN": "North America", "HR": "Europe", "HT": "North America", "HU": "Europe", "ID": "Asia", "IE": "Europe", "IL": "Asia", "IM": "Europe", "IN": "Asia", "IO": "Asia", "IQ": "Asia", "IR": "Asia", "IS": "Europe", "IT": "Europe", "JE": "Europe", "JM": "North America", "JO": "Asia", "JP": "Asia", "KE": "Africa", "KG": "Asia", "KH": "Asia", "KI": "Australia", "KM": "Africa", "KN": "North America", "KP": "Asia", "KR": "Asia", "KW": "Asia", "KY": "North America", "KZ": "Asia", "LA": "Asia", "LB": "Asia", "LC": "North America", "LI": "Europe", "LK": "Asia", "LR": "Africa", "LS": "Africa", "LT": "Europe", "LU": "Europe", "LV": "Europe", "LY": "Africa", "MA": "Africa", "MC": "Europe", "MD": "Europe", "ME": "Europe", "MG": "Africa", "MH": "Australia", "MK": "Europe", "ML": "Africa", "MM": "Asia", "MN": "Asia", "MO": "Asia", "MP": "Australia", "MQ": "North America", "MR": "Africa", "MS": "North America", "MT": "Europe", "MU": "Africa", "MV": "Asia", "MW": "Africa", "MX": "North America", "MY": "Asia", "MZ": "Africa", "NA": "Africa", "NC": "Australia", "NE": "Africa", "NF": "Australia", "NG": "Africa", "NI": "North America", "NL": "Europe", "NO": "Europe", "NP": "Asia", "NR": "Australia", "NU": "Australia", "NZ": "Australia", "OM": "Asia", "PA": "North America", "PE": "South America", "PF": "Australia", "PG": "Australia", "PH": "Asia", "PK": "Asia", "PL": "Europe", "PM": "North America", "PN": "Australia", "PR": "North America", "PS": "Asia", "PT": "Europe", "PW": "Australia", "PY": "South America", "QA": "Asia", "RE": "Africa", "RO": "Europe", "RS": "Europe", "RU": "Europe", "RW": "Africa", "SA": "Asia", "SB": "Australia", "SC": "Africa", "SD": "Africa", "SE": "Europe", "SG": "Asia", "SH": "Africa", "SI": "Europe", "SJ": "Europe", "SK": "Europe", "SL": "Africa", "SM": "Europe", "SN": "Africa", "SO": "Africa", "SR": "South America", "ST": "Africa", "SV": "North America", "SY": "Asia", "SZ": "Africa", "TC": "North America", "TD": "Africa", "TF": "Antarctica", "TG": "Africa", "TH": "Asia", "TJ": "Asia", "TK": "Australia", "TM": "Asia", "TN": "Africa", "TO": "Australia", "TR": "Asia", "TT": "North America", "TV": "Australia", "TW": "Asia", "TZ": "Africa", "UA": "Europe", "UG": "Africa", "US": "North America", "UY": "South America", "UZ": "Asia", "VC": "North America", "VE": "South America", "VG": "North America", "VI": "North America", "VN": "Asia", "VU": "Australia", "WF": "Australia", "WS": "Australia", "YE": "Asia", "YT": "Africa", "ZA": "Africa", "ZM": "Africa", "ZW": "Africa" };

        function initMaps() {
            initAutocomplete();
            // initializeMap();
        }

        function initAutocomplete() {
            autocomplete = new google.maps.places.Autocomplete(
                document.getElementById('address'),
                {
                    types: ['geocode', 'establishment']
                }
            );
            autocomplete.setFields(['geometry', 'formatted_address', 'address_components']);
            autocomplete.addListener('place_changed', fillInAddress);
        }

        function fillInAddress() {
            var place = autocomplete.getPlace();

            document.getElementById('continent').value = '';
            document.getElementById('country').value = '';
            document.getElementById('state').value = '';
            document.getElementById('zipcode').value = '';

            for (var i = 0; i < place.address_components.length; i++) {
                for (var j = 0; j < place.address_components[i].types.length; j++) {
                    if (place.address_components[i].types[j] == "postal_code") {
                        document.getElementById('zipcode').value = place.address_components[i].long_name;
                    }
                    if (place.address_components[i].types[j] == "country") {
                        wzip = document.getElementById('address').value;
                        document.getElementById('address').value = wzip + ', ' + continents[place.address_components[i].short_name];

                        document.getElementById('continent').value = continents[place.address_components[i].short_name];
                        document.getElementById('country').value = place.address_components[i].long_name;
                    }
                    if (place.address_components[i].types[j] == "administrative_area_level_1") {
                        document.getElementById('state').value = place.address_components[i].long_name;
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

        function fileValidation() {
            var fileInput = document.getElementById('FileUpload');
            var filePath = fileInput.value;

            // Allowing file type
            var allowedExtensions = /(\.jpg|\.jpeg|\.png|\.gif)$/i;

            if (!allowedExtensions.exec(filePath)) {
                alert('Invalid file type');
                fileInput.value = '';
                return false;
            }

            if (fileInput.files.length > 0) {
                for (const i = 0; i <= fileInput.files.length - 1; i++) {
                    const fsize = fileInput.files.item(i).size;
                    const file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 4096) {
                        alert("File too Big, please select a file less than 4mb");
                        fileInput.value = '';
                        return false;
                    }
                }
            }
        }

        const emojiPicker = new FgEmojiPicker({
            trigger: ['#emoji_trigger'],
            position: ['bottom', 'right'],
            preFetch: true,
            insertInto: document.querySelector('#Posted'),
            dir: './emoji/'

        });

        var rowID = 0;
        function getMessage() {
            var params = {
                rowID: rowID,
                Address: '<%= Session("Address") %>',
                Emotions: '<%= Session("Emotions") %>'
            }
            fetch(
                "/unknownprotocol.aspx/GetMessage",
                {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json; charset=utf-8"
                    },
                    body: JSON.stringify(params)
                }
            )
                .then(response => response.json())
                .then((data) => {
                    var responseBody = data.d.split("##");
                    document.getElementById("Listview_container").insertAdjacentHTML('beforeend', responseBody[1]);
                    if (rowID == 0)
                        document.getElementById('UpdatePanel1').scrollTo(0, 10000);
                    rowID = responseBody[0];

                    setTimeout(getMessage, 800);
                });
        }

        getMessage();

    </script>

    <script defer async src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBSjbe9_hIWU4o7N2RevIQu1zdH48BJL70&libraries=places&callback=initMaps&language=en"></script>

   
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.9.1.js"></script>
    <script>
        $(function () {
            $('input[name="Emotions"]').click(function () {
                var $radio = $(this);

                // if this was previously checked
                if ($radio.data('waschecked') == true) {
                    $radio.prop('checked', false);
                    $radio.data('waschecked', false);
                } else
                    $radio.data('waschecked', true);

                // remove was checked from other radios
                $radio.siblings('input[name="Emotions"]').data('waschecked', false);
            });
        });
    </script>
</body>

</html>
