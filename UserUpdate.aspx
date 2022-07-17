<%@ Page Title="User Update" Language="VB" AutoEventWireup="false" CodeFile="UserUpdate.aspx.vb" Inherits="UserUpdate" %>

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
            .auto-style1 {
                height: 34px;
            }
            .auto-style2 {
                width: 149px;
            }
            .auto-style3 {
                height: 34px;
                width: 149px;
            }
            .auto-style4 {
                width: 74px;
            }
            .auto-style5 {
                height: 34px;
                width: 74px;
            }
    </style>  
</head>
<body>
<center>
<div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    unknownprotocol</h1>
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
                        <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignUp"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotUsername.aspx" Text="Forogot Username" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Retrieve Password"></asp:MenuItem>
<asp:MenuItem NavigateUrl="~/UserUpdate.aspx" Text="User Update" Value="User Update"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/DeleteUser.aspx" Text="Delete User" Value="Delete User"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">


<fieldset>
       <legend>User Update</legend>
    <br />
    <br />
    
    <center>
    <table class="style1">
        
        <tr>
            <td class="style7">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtFirstName" MaxLength="20" CssClass="textEntry" runat="server" Width="130px"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"     
                                    ErrorMessage="Enter alphabetic characters and or apothrophes only." 
                                    ControlToValidate="txtFirstName"     
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$" />
            </td>
            <td>
                <asp:Label ID="lblMiddleName"  runat="server" Text="Middle Name"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMiddleName" MaxLength="20" CssClass="textEntry" runat="server" AutoPostBack="False" Width="130px"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"     
                                    ErrorMessage="Enter alphabetic characters and or apothrophes only." 
                                    ControlToValidate="txtMiddleName"     
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblLastName" runat="server" Text="Last name"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtLastName" MaxLength="20" CssClass="textEntry" runat="server" AutoPostBack="False" Width="131px"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"     
                                    ErrorMessage="Enter alphabetic characters and or apothrophes only." 
                                    ControlToValidate="txtLastName"     
                                    ValidationExpression="^[a-zA-Z0-9'-.\s]{1,40}$" />
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCountry" MaxLength="20" CssClass="textEntry" runat="server" Width="130px"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" display="dynamic" ControlToValidate="txtCountry"
ErrorMessage="Enter alphabetic numeric characters, periods and or apothrophes only."  ValidationExpression="^[a-zA-Z.'.\s]{1,40}$" />
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtState" MaxLength="20" CssClass="textEntry" runat="server" Width="130px"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" display="dynamic" ControlToValidate="txtState"
ErrorMessage="Enter alphabetic numeric characters, periods and or apothrophes only."  ValidationExpression="^[a-zA-Z.'.\s]{1,40}$" />
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblTown" runat="server" Text="Town"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtTown" MaxLength="20" CssClass="textEntry" runat="server" Width="130px"></asp:TextBox><br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" display="dynamic" ControlToValidate="txtTown"
ErrorMessage="Enter alphabetic numeric characters, periods and or apothrophes only."  ValidationExpression="^[a-zA-Z.'.\s]{1,40}$" />
                
                <br />
            </td>
            <td>
                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
            </td>
            <td class="auto-style4">
                  <asp:TextBox ID="txtCity" MaxLength="20" CssClass="textEntry" runat="server" Width="130px"></asp:TextBox><br />
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" display="dynamic" ControlToValidate="txtCity"
ErrorMessage="Enter alphabetic numeric characters, periods and or apothrophes only."  ValidationExpression="^[a-zA-Z.'.\s]{1,40}$" />
                
                <br />
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblZipCode" runat="server" Text="Zip Code"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtZipCode" MaxLength="5" CssClass="textEntry" runat="server" AutoPostBack="False" Width="130px"></asp:TextBox>
                <br />
<asp:RegularExpressionValidator id="RegularExpressionValidator16" ControlToValidate="txtZipCode" ValidationExpression="\d{5}" Display="Static"
ErrorMessage="Zip code must be 5 numeric digits"  runat="server"/>
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblPictureUpload" runat="server" Text="Picture Upload"></asp:Label>
            </td>
            <td colspan="3">
                <asp:FileUpload ID="FileUpload" CssClass="textEntry" runat="server" Width="322px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;<asp:Label 
                    ID="lblCurrentAge" runat="server" Text="Current age"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlCurrentAge" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="18">18</asp:ListItem>
                <asp:ListItem value="19">19</asp:ListItem>
                <asp:ListItem value="20">20</asp:ListItem>
                <asp:ListItem value="21">21</asp:ListItem>
                <asp:ListItem value="22">22</asp:ListItem>
                <asp:ListItem value="23">23</asp:ListItem>
                <asp:ListItem value="24">24</asp:ListItem>
                <asp:ListItem value="25">25</asp:ListItem>
                <asp:ListItem value="26">26</asp:ListItem>
                <asp:ListItem value="27">27</asp:ListItem>
                <asp:ListItem value="28">28</asp:ListItem>
                <asp:ListItem value="29">29</asp:ListItem>
                <asp:ListItem value="30">30</asp:ListItem>
                <asp:ListItem value="31">31</asp:ListItem>
                <asp:ListItem value="32">32</asp:ListItem>
                <asp:ListItem value="33">33</asp:ListItem>
                <asp:ListItem value="34">34</asp:ListItem>
                <asp:ListItem value="35">35</asp:ListItem>
                <asp:ListItem value="36">36</asp:ListItem>
                <asp:ListItem value="37">37</asp:ListItem>
                <asp:ListItem value="38">38</asp:ListItem>
                <asp:ListItem value="39">39</asp:ListItem>
                <asp:ListItem value="40">40</asp:ListItem>
                <asp:ListItem value="41">41</asp:ListItem>
                <asp:ListItem value="42">42</asp:ListItem>
                <asp:ListItem value="43">43</asp:ListItem>
                <asp:ListItem value="44">44</asp:ListItem>
                <asp:ListItem value="45">45</asp:ListItem>
                <asp:ListItem value="46">46</asp:ListItem>
                <asp:ListItem value="47">47</asp:ListItem>
                <asp:ListItem value="48">48</asp:ListItem>
                <asp:ListItem value="49">49</asp:ListItem>
                <asp:ListItem value="50">50</asp:ListItem>
                <asp:ListItem value="51">51</asp:ListItem>
                <asp:ListItem value="52">52</asp:ListItem>
                <asp:ListItem value="53">53</asp:ListItem>
                <asp:ListItem value="54">54</asp:ListItem>
                <asp:ListItem value="55">55</asp:ListItem>
                <asp:ListItem value="56">56</asp:ListItem>
                <asp:ListItem value="57">57</asp:ListItem>
                <asp:ListItem value="58">58</asp:ListItem>
                <asp:ListItem value="59">59</asp:ListItem>
                <asp:ListItem value="60">60</asp:ListItem>
                <asp:ListItem value="61">61</asp:ListItem>
                <asp:ListItem value="62">62</asp:ListItem>
                <asp:ListItem value="63">63</asp:ListItem>
                <asp:ListItem value="64">64</asp:ListItem>
                <asp:ListItem value="65">65</asp:ListItem>
                <asp:ListItem value="66">66</asp:ListItem>
                <asp:ListItem value="67">67</asp:ListItem>
                <asp:ListItem value="68">68</asp:ListItem>
                <asp:ListItem value="69">69</asp:ListItem>
                <asp:ListItem value="70">70</asp:ListItem>
                <asp:ListItem value="71">71</asp:ListItem>
                <asp:ListItem value="72">72</asp:ListItem>
                <asp:ListItem value="73">73</asp:ListItem>
                <asp:ListItem value="74">74</asp:ListItem>
                <asp:ListItem value="75">75</asp:ListItem>
                <asp:ListItem value="76">76</asp:ListItem>
                <asp:ListItem value="77">77</asp:ListItem>
                <asp:ListItem value="78">78</asp:ListItem>
                <asp:ListItem value="79">79</asp:ListItem>
                <asp:ListItem value="80">80</asp:ListItem>
                <asp:ListItem value="81">81</asp:ListItem>
                <asp:ListItem value="82">82</asp:ListItem>
                <asp:ListItem value="83">83</asp:ListItem>
                <asp:ListItem value="84">84</asp:ListItem>
                <asp:ListItem value="85">85</asp:ListItem>
                <asp:ListItem value="86">86</asp:ListItem>
                <asp:ListItem value="87">87</asp:ListItem>
                <asp:ListItem value="88">88</asp:ListItem>
                <asp:ListItem value="89">89</asp:ListItem>
                <asp:ListItem value="90">90</asp:ListItem>
                <asp:ListItem value="91">91</asp:ListItem>
                <asp:ListItem value="92">92</asp:ListItem>
                <asp:ListItem value="93">93</asp:ListItem>
                <asp:ListItem value="94">94</asp:ListItem>
                <asp:ListItem value="95">95</asp:ListItem>
                <asp:ListItem value="96">96</asp:ListItem>
                <asp:ListItem value="97">97</asp:ListItem>
                <asp:ListItem value="98">98</asp:ListItem>
                <asp:ListItem value="99">99</asp:ListItem>
                <asp:ListItem value="100">100</asp:ListItem>
                <asp:ListItem value="101">101</asp:ListItem>
                <asp:ListItem value="102">102</asp:ListItem>
                <asp:ListItem value="103">103</asp:ListItem>
                <asp:ListItem value="104">104</asp:ListItem>
                <asp:ListItem value="105">105</asp:ListItem>
                <asp:ListItem value="106">106</asp:ListItem>
                <asp:ListItem value="107">107</asp:ListItem>
                <asp:ListItem value="108">108</asp:ListItem>
                <asp:ListItem value="109">109</asp:ListItem>
                <asp:ListItem value="110">110</asp:ListItem>
                <asp:ListItem value="111">111</asp:ListItem>
                <asp:ListItem value="112">112</asp:ListItem>
                <asp:ListItem value="113">113</asp:ListItem>
                <asp:ListItem value="114">114</asp:ListItem>
                <asp:ListItem value="115">115</asp:ListItem>
                <asp:ListItem value="116">116</asp:ListItem>
                <asp:ListItem value="117">117</asp:ListItem>
                <asp:ListItem value="118">118</asp:ListItem>
                <asp:ListItem value="119">119</asp:ListItem>
                <asp:ListItem value="120">120</asp:ListItem>
                <asp:ListItem value="121">121</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style1">
                <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="Female">Female</asp:ListItem>
                <asp:ListItem value="Male">Male</asp:ListItem>
               
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblHeightFeet" runat="server" Text="Height feet"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlHeightFeet" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="0">0</asp:ListItem>
                <asp:ListItem value="1">1</asp:ListItem>
                <asp:ListItem value="2">2</asp:ListItem>
                <asp:ListItem value="3">3</asp:ListItem>
                <asp:ListItem value="4">4</asp:ListItem>
                <asp:ListItem value="5">5</asp:ListItem>
                <asp:ListItem value="6">6</asp:ListItem>
                <asp:ListItem value="7">7</asp:ListItem>
                <asp:ListItem value="8">8</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lblHeightInches" runat="server" Text="Height inches"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlHeightInches" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="0">0</asp:ListItem>
                <asp:ListItem value="1">1</asp:ListItem>
                <asp:ListItem value="2">2</asp:ListItem>
                <asp:ListItem value="3">3</asp:ListItem>
                <asp:ListItem value="4">4</asp:ListItem>
                <asp:ListItem value="5">5</asp:ListItem>
                <asp:ListItem value="6">6</asp:ListItem>
                <asp:ListItem value="7">7</asp:ListItem>
                <asp:ListItem value="8">8</asp:ListItem>
                <asp:ListItem value="9">9</asp:ListItem>
                <asp:ListItem value="10">10</asp:ListItem>
                <asp:ListItem value="11">11</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblWeightPounds" runat="server" Text="Weight pounds"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlWeightPounds" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="0">0</asp:ListItem>
                <asp:ListItem value="1">1</asp:ListItem>
                <asp:ListItem value="2">2</asp:ListItem>
                <asp:ListItem value="3">3</asp:ListItem>
                <asp:ListItem value="4">4</asp:ListItem>
                <asp:ListItem value="5">5</asp:ListItem>
                <asp:ListItem value="6">6</asp:ListItem>
                <asp:ListItem value="7">7</asp:ListItem>
                <asp:ListItem value="8">8</asp:ListItem>
                <asp:ListItem value="9">9</asp:ListItem>
                <asp:ListItem value="10">10</asp:ListItem>
                <asp:ListItem value="11">11</asp:ListItem>
                <asp:ListItem value="12">12</asp:ListItem>
                <asp:ListItem value="13">13</asp:ListItem>
                <asp:ListItem value="14">14</asp:ListItem>
                <asp:ListItem value="15">15</asp:ListItem>
                <asp:ListItem value="16">16</asp:ListItem>
                <asp:ListItem value="17">17</asp:ListItem>
                <asp:ListItem value="18">18</asp:ListItem>
                <asp:ListItem value="19">19</asp:ListItem>
                <asp:ListItem value="20">20</asp:ListItem>
                <asp:ListItem value="21">21</asp:ListItem>
                <asp:ListItem value="22">22</asp:ListItem>
                <asp:ListItem value="23">23</asp:ListItem>
                <asp:ListItem value="24">24</asp:ListItem>
                <asp:ListItem value="25">25</asp:ListItem>
                <asp:ListItem value="26">26</asp:ListItem>
                <asp:ListItem value="27">27</asp:ListItem>
                <asp:ListItem value="28">28</asp:ListItem>
                <asp:ListItem value="29">29</asp:ListItem>
                <asp:ListItem value="30">30</asp:ListItem>
                <asp:ListItem value="31">31</asp:ListItem>
                <asp:ListItem value="32">32</asp:ListItem>
                <asp:ListItem value="33">33</asp:ListItem>
                <asp:ListItem value="34">34</asp:ListItem>
                <asp:ListItem value="35">35</asp:ListItem>
                <asp:ListItem value="36">36</asp:ListItem>
                <asp:ListItem value="37">37</asp:ListItem>
                <asp:ListItem value="38">38</asp:ListItem>
                <asp:ListItem value="39">39</asp:ListItem>
                <asp:ListItem value="40">40</asp:ListItem>
                <asp:ListItem value="41">41</asp:ListItem>
                <asp:ListItem value="42">42</asp:ListItem>
                <asp:ListItem value="43">43</asp:ListItem>
                <asp:ListItem value="44">44</asp:ListItem>
                <asp:ListItem value="45">45</asp:ListItem>
                <asp:ListItem value="46">46</asp:ListItem>
                <asp:ListItem value="47">47</asp:ListItem>
                <asp:ListItem value="48">48</asp:ListItem>
                <asp:ListItem value="49">49</asp:ListItem>
                <asp:ListItem value="50">50</asp:ListItem>
                <asp:ListItem value="51">51</asp:ListItem>
                <asp:ListItem value="52">52</asp:ListItem>
                <asp:ListItem value="53">53</asp:ListItem>
                <asp:ListItem value="54">54</asp:ListItem>
                <asp:ListItem value="55">55</asp:ListItem>
                <asp:ListItem value="56">56</asp:ListItem>
                <asp:ListItem value="57">57</asp:ListItem>
                <asp:ListItem value="58">58</asp:ListItem>
                <asp:ListItem value="59">59</asp:ListItem>
                <asp:ListItem value="60">60</asp:ListItem>
                <asp:ListItem value="61">61</asp:ListItem>
                <asp:ListItem value="62">62</asp:ListItem>
                <asp:ListItem value="63">63</asp:ListItem>
                <asp:ListItem value="64">64</asp:ListItem>
                <asp:ListItem value="65">65</asp:ListItem>
                <asp:ListItem value="66">66</asp:ListItem>
                <asp:ListItem value="67">67</asp:ListItem>
                <asp:ListItem value="68">68</asp:ListItem>
                <asp:ListItem value="69">69</asp:ListItem>
                <asp:ListItem value="70">70</asp:ListItem>
                <asp:ListItem value="71">71</asp:ListItem>
                <asp:ListItem value="72">72</asp:ListItem>
                <asp:ListItem value="73">73</asp:ListItem>
                <asp:ListItem value="74">74</asp:ListItem>
                <asp:ListItem value="75">75</asp:ListItem>
                <asp:ListItem value="76">76</asp:ListItem>
                <asp:ListItem value="77">77</asp:ListItem>
                <asp:ListItem value="78">78</asp:ListItem>
                <asp:ListItem value="79">79</asp:ListItem>
                <asp:ListItem value="80">80</asp:ListItem>
                <asp:ListItem value="81">81</asp:ListItem>
                <asp:ListItem value="82">82</asp:ListItem>
                <asp:ListItem value="83">83</asp:ListItem>
                <asp:ListItem value="84">84</asp:ListItem>
                <asp:ListItem value="85">85</asp:ListItem>
                <asp:ListItem value="86">86</asp:ListItem>
                <asp:ListItem value="87">87</asp:ListItem>
                <asp:ListItem value="88">88</asp:ListItem>
                <asp:ListItem value="89">89</asp:ListItem>
                <asp:ListItem value="90">90</asp:ListItem>
                <asp:ListItem value="91">91</asp:ListItem>
                <asp:ListItem value="92">92</asp:ListItem>
                <asp:ListItem value="93">93</asp:ListItem>
                <asp:ListItem value="94">94</asp:ListItem>
                <asp:ListItem value="95">95</asp:ListItem>
                <asp:ListItem value="96">96</asp:ListItem>
                <asp:ListItem value="97">97</asp:ListItem>
                <asp:ListItem value="98">98</asp:ListItem>
                <asp:ListItem value="99">99</asp:ListItem>
                <asp:ListItem value="100">100</asp:ListItem>
                <asp:ListItem value="101">101</asp:ListItem>
                <asp:ListItem value="102">102</asp:ListItem>
                <asp:ListItem value="103">103</asp:ListItem>
                <asp:ListItem value="104">104</asp:ListItem>
                <asp:ListItem value="105">105</asp:ListItem>
                <asp:ListItem value="106">106</asp:ListItem>
                <asp:ListItem value="107">107</asp:ListItem>
                <asp:ListItem value="108">108</asp:ListItem>
                <asp:ListItem value="109">109</asp:ListItem>
                <asp:ListItem value="110">110</asp:ListItem>
                <asp:ListItem value="111">111</asp:ListItem>
                <asp:ListItem value="112">112</asp:ListItem>
                <asp:ListItem value="113">113</asp:ListItem>
                <asp:ListItem value="114">114</asp:ListItem>
                <asp:ListItem value="115">115</asp:ListItem>
                <asp:ListItem value="116">116</asp:ListItem>
                <asp:ListItem value="117">117</asp:ListItem>
                <asp:ListItem value="118">118</asp:ListItem>
                <asp:ListItem value="119">119</asp:ListItem>
                <asp:ListItem value="120">120</asp:ListItem>
                <asp:ListItem value="121">121</asp:ListItem>
                <asp:ListItem value="122">122</asp:ListItem>
                <asp:ListItem value="123">123</asp:ListItem>
                <asp:ListItem value="124">124</asp:ListItem>
                <asp:ListItem value="125">125</asp:ListItem>
                <asp:ListItem value="126">126</asp:ListItem>
                <asp:ListItem value="127">127</asp:ListItem>
                <asp:ListItem value="128">128</asp:ListItem>
                <asp:ListItem value="129">129</asp:ListItem>
                <asp:ListItem value="130">130</asp:ListItem>
                <asp:ListItem value="131">131</asp:ListItem>
                <asp:ListItem value="132">132</asp:ListItem>
                <asp:ListItem value="133">133</asp:ListItem>
                <asp:ListItem value="134">134</asp:ListItem>
                <asp:ListItem value="135">135</asp:ListItem>
                <asp:ListItem value="136">136</asp:ListItem>
                <asp:ListItem value="137">137</asp:ListItem>
                <asp:ListItem value="138">138</asp:ListItem>
                <asp:ListItem value="139">139</asp:ListItem>
                <asp:ListItem value="140">140</asp:ListItem>
                <asp:ListItem value="141">141</asp:ListItem>
                <asp:ListItem value="142">142</asp:ListItem>
                <asp:ListItem value="143">143</asp:ListItem>
                <asp:ListItem value="144">144</asp:ListItem>
                <asp:ListItem value="145">145</asp:ListItem>
                <asp:ListItem value="146">146</asp:ListItem>
                <asp:ListItem value="147">147</asp:ListItem>
                <asp:ListItem value="148">148</asp:ListItem>
                <asp:ListItem value="149">149</asp:ListItem>
                <asp:ListItem value="150">150</asp:ListItem>
                <asp:ListItem value="151">151</asp:ListItem>
                <asp:ListItem value="152">152</asp:ListItem>
                <asp:ListItem value="153">153</asp:ListItem>
                <asp:ListItem value="154">154</asp:ListItem>
                <asp:ListItem value="155">155</asp:ListItem>
                <asp:ListItem value="156">156</asp:ListItem>
                <asp:ListItem value="157">157</asp:ListItem>
                <asp:ListItem value="158">158</asp:ListItem>
                <asp:ListItem value="159">159</asp:ListItem>
                <asp:ListItem value="160">160</asp:ListItem>
                <asp:ListItem value="161">161</asp:ListItem>
                <asp:ListItem value="162">162</asp:ListItem>
                <asp:ListItem value="163">163</asp:ListItem>
                <asp:ListItem value="164">164</asp:ListItem>
                <asp:ListItem value="165">165</asp:ListItem>
                <asp:ListItem value="166">166</asp:ListItem>
                <asp:ListItem value="167">167</asp:ListItem>
                <asp:ListItem value="168">168</asp:ListItem>
                <asp:ListItem value="169">169</asp:ListItem>
                <asp:ListItem value="170">170</asp:ListItem>
                <asp:ListItem value="171">171</asp:ListItem>
                <asp:ListItem value="172">172</asp:ListItem>
                <asp:ListItem value="173">173</asp:ListItem>
                <asp:ListItem value="174">174</asp:ListItem>
                <asp:ListItem value="175">175</asp:ListItem>
                <asp:ListItem value="176">176</asp:ListItem>
                <asp:ListItem value="177">177</asp:ListItem>
                <asp:ListItem value="178">178</asp:ListItem>
                <asp:ListItem value="179">179</asp:ListItem>
                <asp:ListItem value="180">180</asp:ListItem>
                <asp:ListItem value="181">181</asp:ListItem>
                <asp:ListItem value="182">182</asp:ListItem>
                <asp:ListItem value="183">183</asp:ListItem>
                <asp:ListItem value="184">184</asp:ListItem>
                <asp:ListItem value="185">185</asp:ListItem>
                <asp:ListItem value="186">186</asp:ListItem>
                <asp:ListItem value="187">187</asp:ListItem>
                <asp:ListItem value="188">188</asp:ListItem>
                <asp:ListItem value="189">189</asp:ListItem>
                <asp:ListItem value="190">190</asp:ListItem>
                <asp:ListItem value="191">191</asp:ListItem>
                <asp:ListItem value="192">192</asp:ListItem>
                <asp:ListItem value="193">193</asp:ListItem>
                <asp:ListItem value="194">194</asp:ListItem>
                <asp:ListItem value="195">195</asp:ListItem>
                <asp:ListItem value="196">196</asp:ListItem>
                <asp:ListItem value="197">197</asp:ListItem>
                <asp:ListItem value="198">198</asp:ListItem>
                <asp:ListItem value="199">199</asp:ListItem>
                <asp:ListItem value="200">200</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lblWeightOunces" runat="server" Text="Weight ounces"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlWeightOunces" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="0">0</asp:ListItem>
                <asp:ListItem value="1">1</asp:ListItem>
                <asp:ListItem value="2">2</asp:ListItem>
                <asp:ListItem value="3">3</asp:ListItem>
                <asp:ListItem value="4">4</asp:ListItem>
                <asp:ListItem value="5">5</asp:ListItem>
                <asp:ListItem value="6">6</asp:ListItem>
                <asp:ListItem value="7">7</asp:ListItem>
                <asp:ListItem value="8">8</asp:ListItem>
                <asp:ListItem value="9">9</asp:ListItem>
                <asp:ListItem value="9">10</asp:ListItem>
                <asp:ListItem value="9">11</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblHairColor" runat="server" Text="Hair color"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlHairColor" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="Bald">Bald</asp:ListItem>
                <asp:ListItem value="Bald">Black</asp:ListItem>
                <asp:ListItem value="Blonde">Blonde</asp:ListItem>
                <asp:ListItem value="Blue">Blue</asp:ListItem>
                <asp:ListItem value="Brown">Brown</asp:ListItem>
                 <asp:ListItem value="Light Brown">Light Brown</asp:ListItem>
                <asp:ListItem value="Brunette">Brunette</asp:ListItem>
                <asp:ListItem value="Red">Red</asp:ListItem>
                <asp:ListItem value="Purple">Purple</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lblEyeColor" runat="server" Text="Eye color"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlEyeColor" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="Blue">Blue</asp:ListItem>
                <asp:ListItem value="Brown">Brown</asp:ListItem>
                <asp:ListItem value="Green">Green</asp:ListItem>
                <asp:ListItem value="Green">Hazel</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
<td class="style15">
    <asp:Label ID="lblDrinks" runat="server" Text="Drinks"></asp:Label>
            </td>
<td class="auto-style2">
    <asp:DropDownList ID="ddlDrinks" runat="server" AutoPostBack="False">
    <asp:ListItem Value="Select">None</asp:ListItem>
    <asp:ListItem Value="No">No</asp:ListItem>
    <asp:ListItem Value="Sometimes">Sometimes</asp:ListItem>
    <asp:ListItem Value="Yes">Yes</asp:ListItem>
    </asp:DropDownList>
</td>
<td>
                <asp:Label ID="lblSmokes" runat="server" Text="Smokes"></asp:Label>
            </td>
<td class="auto-style4">
                
                <asp:DropDownList ID="ddlSmokes" runat="server" AutoPostBack="False">
    <asp:ListItem Value="Select">None</asp:ListItem>
    <asp:ListItem Value="No">No</asp:ListItem>
    <asp:ListItem Value="Sometimes">Sometimes</asp:ListItem>
    <asp:ListItem Value="Yes">Yes</asp:ListItem>
     </asp:DropDownList>
</td>
        </tr>
        <tr>
<td class="style15">
    <asp:Label ID="lblUseDrugs" runat="server" Text="Use drugs"></asp:Label>
            </td>
<td class="auto-style2">
    <asp:DropDownList ID="ddlUsesDrugs" runat="server" AutoPostBack="False">
    <asp:ListItem Value="Select">None</asp:ListItem>
    <asp:ListItem Value="No">No</asp:ListItem>
    <asp:ListItem Value="Sometimes">Sometimes</asp:ListItem>
    <asp:ListItem Value="Yes">Yes</asp:ListItem>

    </asp:DropDownList>
</td>
<td>
                <asp:Label ID="lblMaritalStatus" runat="server" Text="Marital status"></asp:Label>
            </td>
<td class="auto-style4">
                <asp:DropDownList ID="ddlMaritalStatus" runat="server" AutoPostBack="False">
<asp:ListItem value="Select">None</asp:ListItem>
<asp:ListItem value="Single">Single</asp:ListItem>
<asp:ListItem value="Just Dating">Just Dating</asp:ListItem>
<asp:ListItem value="Long term relationship">Long term relationship</asp:ListItem>
<asp:ListItem value="Live in boyfriend">Live in Boyfriend</asp:ListItem>
<asp:ListItem value="Live in girlfriend">Live in Girlfriend</asp:ListItem>
<asp:ListItem value="Fiance">Fiance</asp:ListItem>
<asp:ListItem value="Fiancee">Fiancee</asp:ListItem>
<asp:ListItem value="Married">Married</asp:ListItem>
<asp:ListItem value="Married with no child">Married no children</asp:ListItem>
<asp:ListItem value="Married with child">Married with Child</asp:ListItem>
<asp:ListItem value="Married with children">Married with Children</asp:ListItem>
<asp:ListItem value="Seperated">Seperated</asp:ListItem>
<asp:ListItem value="Divorced">Divorced</asp:ListItem>
<asp:ListItem value="Divorced no children">Divorced no Children</asp:ListItem>
<asp:ListItem value="Divorced with child">Divorced with Child</asp:ListItem>
<asp:ListItem value="Divorced with children">Divorced with children</asp:ListItem>
<asp:ListItem value="Widow">Widow</asp:ListItem>
<asp:ListItem value="Widower">Widower</asp:ListItem>
</asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label ID="lblEmotion" runat="server" Text="Emotion"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlEmotions" runat="server">
                <asp:ListItem value="Select">None</asp:ListItem>
                <asp:ListItem value="Angry">Angry</asp:ListItem>
                <asp:ListItem value="Ashamed">Ashamed</asp:ListItem>
                <asp:ListItem value="Anxious">Anxious</asp:ListItem>
                <asp:ListItem value="Blew Up">BlewUp</asp:ListItem>
                <asp:ListItem value="Bored">Bored</asp:ListItem>
                <asp:ListItem value="Calm">Calm</asp:ListItem>
                <asp:ListItem value="Cautious">Cautious</asp:ListItem>
                <asp:ListItem value="Confident">Confident</asp:ListItem>
                <asp:ListItem value="Confused">Confused</asp:ListItem>
                <asp:ListItem value="Content">Content</asp:ListItem>
                <asp:ListItem value="Crying">Crying</asp:ListItem>
                <asp:ListItem value="Depressed">Depressed</asp:ListItem>
                <asp:ListItem value="Diligent">Diligent</asp:ListItem>
                <asp:ListItem value="Disrupted">Disrupted</asp:ListItem>
                <asp:ListItem value="Duress">Duress</asp:ListItem>
                <asp:ListItem value="Discrminiated">Discrminiated</asp:ListItem>
                <asp:ListItem value="Disgusted">Disgusted</asp:ListItem>
                <asp:ListItem value="Ecstatic">Ecstatic</asp:ListItem>
                <asp:ListItem value="Embarrassed">Embarrassed</asp:ListItem>
                <asp:ListItem value="Enraged">Enraged</asp:ListItem>
                <asp:ListItem value="Excited">Excited</asp:ListItem>
                <asp:ListItem value="Exhausted">Exhausted</asp:ListItem>
                <asp:ListItem value="Frightened">Frightened</asp:ListItem>
                <asp:ListItem value="Frustrated">Frustrated</asp:ListItem>
                <asp:ListItem value="Gloom">Gloom</asp:ListItem>
                <asp:ListItem value="Gloomy">Gloomy</asp:ListItem>
                <asp:ListItem value="Good">Good</asp:ListItem>
                <asp:ListItem value="Guility">Guility</asp:ListItem>
                <asp:ListItem value="Happy">Happy</asp:ListItem>
                <asp:ListItem value="Honorable">Honorable</asp:ListItem>
                <asp:ListItem value="Hopeful">Hopeful</asp:ListItem>
                <asp:ListItem value="Hungry">Hungry</asp:ListItem>
                <asp:ListItem value="Hung Over">Hung-Over</asp:ListItem>
                <asp:ListItem value="Hysterical">Hysterical</asp:ListItem>
                <asp:ListItem value="In Love">In-Love</asp:ListItem>
                <asp:ListItem value="Jealous">Jealous</asp:ListItem>
                <asp:ListItem value="Kick ass">Kick-ass</asp:ListItem>
                <asp:ListItem value="Lighten Up">Lighten Up</asp:ListItem>
                <asp:ListItem value="Lonley">Lonley</asp:ListItem>
                <asp:ListItem value="Love Struck">Love Struck</asp:ListItem>
                <asp:ListItem value="Loved">Loved</asp:ListItem>
                <asp:ListItem value="Mad">Mad</asp:ListItem>
                <asp:ListItem value="Medicated">Medicated</asp:ListItem>
                <asp:ListItem value="Mischievous">Mischievous</asp:ListItem>
                <asp:ListItem value="Overwhelmed">Overwhelmed</asp:ListItem>
                <asp:ListItem value="Pain">Pain</asp:ListItem>
                <asp:ListItem value="Pissed-Off">Pissed-Off</asp:ListItem>
                <asp:ListItem value="Powerful">Powerful</asp:ListItem>
                <asp:ListItem value="Pricked">Pricked</asp:ListItem>
                <asp:ListItem value="Provoked">Provoked</asp:ListItem>
                <asp:ListItem value="Quite">Quite</asp:ListItem>
                <asp:ListItem value="Enraged">Enraged</asp:ListItem>
                <asp:ListItem value="Relaxed">Relaxed</asp:ListItem>
                <asp:ListItem value="Sad">Sad</asp:ListItem>
                <asp:ListItem value="Shocked">Shocked</asp:ListItem>
                <asp:ListItem value="Shy">Shy</asp:ListItem>
                <asp:ListItem value="Smug">Smug</asp:ListItem>
                <asp:ListItem value="Stressed">Stressed</asp:ListItem>
                <asp:ListItem value="Stupid">Stupid</asp:ListItem>
                <asp:ListItem value="Supercilious">Supercilious</asp:ListItem>
                <asp:ListItem value="Suprised">Suprised</asp:ListItem>
                <asp:ListItem value="Suspicious">Suspicious</asp:ListItem>
                <asp:ListItem value="Tired">Tired</asp:ListItem>
                <asp:ListItem value="Under Pressure">Under Pressure</asp:ListItem>
                <asp:ListItem value="Upset">Upset</asp:ListItem>
                <asp:ListItem value="Uptight">Uptight</asp:ListItem>
                <asp:ListItem value="Vengeful">Vengeful</asp:ListItem>
                <asp:ListItem value="Wondering">Wondering</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="lblAccess" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="Connect" runat="server" style="text-align: center" Text="Connect"  BackColor="#4b6c9e" ForeColor="white"/>
            </td>
            <td>
                <asp:Button ID="Reset" runat="server" style="text-align: center" Text="Reset"  BackColor="#4b6c9e" ForeColor="white"/>
            </td>
            <td>
                 <asp:Button ID="btnGoBack" runat="server" Text="Go Back" ForeColor="white" BackColor="#4b6c9e" />

            </td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
    </table>

    </center>
    </fieldset>
    </center>
    

    <asp:SqlDataSource
          id="RegUpdate"
          runat="server"
          ConnectionString="<%$ ConnectionStrings:SqlDataSource1%>"
          UpdateCommand="UPDATE tblUpdateRegistered SET URLOfPicture=@URLOfPicture,FirstName=@FirstName,MiddleName=@Middlename,LastName=@LastName,
          Country=@Country,State=@State,Town=@Town,City=@City,ZipCode=@ZipCode,CurrentAge=@CurrentAge,Gender=@Gender,HeightFeet=@HeightFeet,
          HeightInches=@HeightInches,WeightPounds=@WeightPounds,WeightOunces=@WeightOunces,HairColor=@HairColor,EyeColor=@EyeColor,Drinks=@Drinks,
          Smokes=@Smokes,UsesDrugs=@UsesDrugs,Emotions=@Emotions,MaritalStatus=@MaritalStatus,Email=@Email,DateTime=@DateTime">
          <UpdateParameters>
          <asp:FormParameter name="FirstName" formfield="txtFirstName" />
          <asp:FormParameter Name="MiddleName" formfield="txtMiddleName"/>
          <asp:FormParameter Name="LastName" formfield="txtLastName"/>
          <asp:FormParameter Name="Country" formfield="txtCountry"/>
          <asp:FormParameter Name="State" formfield="txtState" />
          <asp:FormParameter Name="City" formfield="txtCity" />
          <asp:FormParameter Name="Town" formfield="txtTown" />
          <asp:FormParameter Name="ZipCode" formfield="txtZipCode" />
          <asp:FormParameter name="FileUpload" formfield="FileUpload" />
          <asp:ControlParameter Name="CurrentAge" ControlId="ddlCurrentAge" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="Gender" ControlId="ddlGender" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="HeightFeet" ControlId="ddlHeightFeet" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="HeightInches" ControlId="ddlHeightInches" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="WeightPounds" ControlId="ddlWeightPounds" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="WeightOunces" ControlId="ddlWeightOunces" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="HairColor" ControlId="ddlHairColor" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="EyeColor" ControlId="ddlEyeColor" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="Drinks" ControlId="ddlDrinks" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="Smokes" ControlId="ddlSmokes" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="UsesDrugs" ControlId="ddlUsesDrugs" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="Emotions" ControlId="ddlEmotions" PropertyName="SelectedValue"/>
          <asp:ControlParameter Name="MaritalStatus" ControlId="ddlMaritalStatus" PropertyName="SelectedValue"/>
          <asp:FormParameter Name="Email" formfield="txtEmail"/>
                    </UpdateParameters>
      </asp:SqlDataSource>

       <asp:SqlDataSource
          id="SqlDataSource2"
          runat="server"
          ConnectionString="<%$ ConnectionStrings:SqlDataSource2%>"
          UpdateCommand="UPDATE tblRegisteredUsers SET FirstName=@FirstName, MiddleName=@Middlename, LastName=@LastName,PictureURL=@PictureURL WHERE RelationshipID=@ID">
          <UpdateParameters>
          <asp:ControlParameter Name="FirstName" ControlId="txtFirstName" PropertyName="Text"/>
          <asp:ControlParameter Name="MiddleName" ControlId="txtMiddleName" PropertyName="Text"/>
          <asp:ControlParameter Name="LastName" ControlId="txtLastName" PropertyName="Text"/>
          </UpdateParameters>
      </asp:SqlDataSource>

      <asp:SqlDataSource id="RegisteredUpdate1"
                runat="server"
                 ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                 UpdateCommand="UPDATE tblRegistered SET URLOfPicture=@UrlOfPicture WHERE ([ID] = @ID)">
                 
                 <UpdateParameters>
                  <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                 </UpdateParameters>

          </asp:SqlDataSource>

          <asp:SqlDataSource id="RegisteredUpdate2"
                runat="server"
                 ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                 UpdateCommand="UPDATE tblRegisteredUsers SET URLOfPicture=@URLOfPicture, FirstName=@FirstName,  MiddleName=@MiddleName, LastName=@Lastname WHERE ([RelationshipID] = @ID)">
                 
                 <UpdateParameters>
                  <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                     <asp:Parameter Name="FirstName" type="String" />
                     <asp:Parameter Name="MiddleName" type="String" />
                     <asp:Parameter Name="LastName" type="String" />
               </UpdateParameters>

          </asp:SqlDataSource>

          <asp:SqlDataSource id="RegisteredUpdate3"
                runat="server"
                 ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                 UpdateCommand="UPDATE tblUsersRegistered SET URLOfPicture=@URLOfPicture, FirstName=@FirstName,  MiddleName=@MiddleName, LastName=@Lastname, Emotions=@Emotions WHERE ([RelationshipID] = @ID)">
                 
                 <UpdateParameters>
                  <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                     <asp:Parameter Name="FirstName" type="String" />
                     <asp:Parameter Name="MiddleName" type="String" />
                     <asp:Parameter Name="LastName" type="String" />
                       <asp:Parameter Name="Emotions" type="String" />
               </UpdateParameters>

          </asp:SqlDataSource>

           <asp:SqlDataSource id="RegisteredUpdate4"
                runat="server"
                 ConnectionString="<%$ ConnectionStrings:SqlDataSource1 %>"
                 UpdateCommand="UPDATE tblUpdateRegistered SET URLOfPicture=@URLOfPicture, FirstName=@FirstName,  MiddleName=@MiddleName, LastName=@Lastname WHERE ([RelationshipID] = @ID)">
                 
                 <UpdateParameters>
                  <asp:QueryStringParameter Name="ID" type="String" QueryStringField="ID" />
                      <asp:Parameter Name="FirstName" type="String" />
                     <asp:Parameter Name="MiddleName" type="String" />
                     <asp:Parameter Name="LastName" type="String" />
               </UpdateParameters>

          </asp:SqlDataSource>

      </form>
</body>
</html>
