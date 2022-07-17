<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Termsofuse.aspx.vb" Inherits="termsofuse" %>

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

            <form id="Form" runat="server">
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
                        <asp:MenuItem NavigateUrl="~/registration.aspx" Text="Registration" Value="SignUp"></asp:MenuItem>
                                             <asp:MenuItem NavigateUrl="~/status.aspx" Text="Contacts" Value="Contacts"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ChangePassword.aspx" Text="Change Password" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotUsername.aspx" Text="Forgot Username" Value="Change Password"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/ForgotPassword.aspx" Text="Forgot Password" Value="Forgot Password"></asp:MenuItem>
                     
                        <asp:MenuItem NavigateUrl="~/DeleteContact.aspx" Text="Delete Contact" Value="Delete Contact"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">
<fieldset>
<legend>Terms Of Use</legend>
<body>
    <br />
    <h2>TERMS OF USE</h2>

<p>These terms and conditions outline the rules and regulations for the use of&nbsp; Unknownprotocol&#39; s Website.</p>

<p>By accessing these websites we assume you accept these terms and conditions. Do not continue to use Unknownprotocol, if you do not agree to take all of the terms and conditions stated on this page.</p>

<p>The following terminology applies to these Terms and Conditions, Privacy Statement and Disclaimer Notice and all Agreements: "Client", "You" and "Your" refers to you, the person log on this website and compliant to the Company’s terms and conditions. "The Company", "Ourselves", "We", "Our" and "Us", refers to our Company. "Party", "Parties", or "Us", refers to both the Client and ourselves. All terms refer to the offer, acceptance and consideration of payment necessary to undertake the process of our assistance to the Client in the most appropriate manner for the express purpose of meeting the Client’s needs in respect of provision of the Company’s stated services. Any use of the above terminology or other words in the singular, plural, capitalization and/or he/she or they, are taken as interchangeable and therefore as referring to same.</p>

<h3><strong>Cookies</strong></h3>

<p>We employ the use of cookies. By accessing Unknownprotocol you agreed to use cookies in agreement with the Sooner Connection&#39;s / Unknownprotocol's Privacy Policy. </p>

<p>Most interactive websites use cookies to let us retrieve the user’s details for each visit. Cookies are used by our website to enable the functionality of certain areas to make it easier for people visiting our website. Some of our affiliate/advertising partners may also use cookies.</p>

<h3><strong>License</strong></h3>

<p>Unless otherwise stated, Unknownprotocol and/or its licensors own the intellectual property rights for all material on Unknownprotocol. All intellectual property rights are reserved. You may access this from Unknownprotocol for your own personal use subjected to restrictions set in these terms and conditions.</p>

<p>You must not:</p>
<ul>
    <li>Republish material from Sonner Connection / Unknownprotocol</li>
    <li>Sell, rent or sub-license material from Sooner Connection / Unknownprotocol</li>
    <li>Reproduce, duplicate or copy material from Sooner Connection / Unknownprotocol</li>
    <li>Redistribute content from Sonner Connection / Unknownprotocol</li>
</ul>

<p>This Agreement shall begin on the date hereof. Our Terms and Conditions were created.</p>

<p>Parts of this website offer an opportunity for users to post and exchange opinions and information in certain areas of the website. Unknownprotocol does not filter, edit, publish or review Comments prior to their presence on the website. Comments do not reflect the views and opinions of Unknownprotocol,its agents and/or affiliates. Comments reflect the views and opinions of the person who post their views and opinions. To the extent permitted by applicable laws,&nbsp; Unknownprotocol shall not be liable for the Comments or for any liability, damages or expenses caused and/or suffered as a result of any use of and/or posting of and/or appearance of the Comments on this website.</p>

<p>Unknownprotocol&nbsp; reserves the right to monitor all Comments and to remove any Comments which can be considered inappropriate, offensive or causes breach of these Terms and Conditions.</p>

<p>You warrant and represent that:</p>

<ul>
    <li>You are entitled to post the Comments on our website and have all necessary licenses and consents to do so;</li>
    <li>The Comments do not invade any intellectual property right, including without limitation copyright, patent or trademark of any third party;</li>
    <li>The Comments do not contain any defamatory, libelous, offensive, indecent or otherwise unlawful material which is an invasion of privacy</li>
    <li>The Comments will not be used to solicit or promote business or custom or present commercial activities or unlawful activity.</li>
</ul>

<p>You hereby grant Unknownprotocol, Processor Click, and Sonner Connection a non-exclusive license to use, reproduce, edit and authorize others to use, reproduce and edit any of your Comments in any and all forms, formats or media.</p>

<h3><strong>Hyperlinking to our Content</strong></h3>

<p>The following organizations may link to our Website without prior written approval:</p>

<ul>
    <li>Government agencies;</li>
    <li>Search engines;</li>
    <li>News organizations;</li>
    <li>Online directory distributors may link to our Website in the same manner as they hyperlink to the Websites of other listed businesses; and</li>
    <li>System wide Accredited Businesses except soliciting non-profit organizations, charity shopping malls, and charity fundraising groups which may not hyperlink to our Web site.</li>
</ul>

<p>These organizations may link to our home page, to publications or to other Website information so long as the link: (a) is not in any way deceptive; (b) does not falsely imply sponsorship, endorsement or approval of the linking party and its products and/or services; and (c) fits within the context of the linking party’s site.</p>

<p>We may consider and approve other link requests from the following types of organizations:</p>

<ul>
    <li>commonly-known consumer and/or business information sources;</li>
    <li>dot.com community sites;</li>
    <li>associations or other groups representing charities;</li>
    <li>online directory distributors;</li>
    <li>internet portals;</li>
    <li>accounting, law and consulting firms; and</li>
    <li>educational institutions and trade associations.</li>
</ul>

<p>We will approve link requests from these organizations if we decide that: (a) the link would not make us look unfavorably to ourselves or to our accredited businesses; (b) the organization does not have any negative records with us; (c) the benefit to us from the visibility of the hyperlink compensates the absence of Unknownprotocol, Processor Click, and Sonner Connection; and (d) the link is in the context of general resource information.</p>

<p>These organizations may link to our home page so long as the link: (a) is not in any way deceptive; (b) does not falsely imply sponsorship, endorsement or approval of the linking party and its products or services; and (c) fits within the context of the linking party’s site.</p>

<p>If you are one of the organizations listed in paragraph 2 above and are interested in linking to our website, you must inform us by sending an e-mail to Unknownprotocol, Processor Click, and Sonner Connection. Please include your name, your organization name, contact information as well as the URL of your site, a list of any URLs from which you intend to link to our Website, and a list of the URLs on our site to which you would like to link.</p>

<p>Approved organizations may hyperlink to our Website as follows:</p>

<ul>
    <li>By use of our corporate name; or</li>
    <li>By use of the uniform resource locator being linked to; or</li>
    <li>By use of any other description of our Website being linked to that makes sense within the context and format of content on the linking party’s site.</li>
</ul>

<p>No use of Unknownprotocol&#39;s Connection's logo or other artwork will be allowed for linking absent a trademark license agreement.</p>

<h3><strong>iFrames</strong></h3>

<p>Without prior approval and written permission, you may not create frames around our Webpages that alter in any way the visual presentation or appearance of our Website.</p>

<h3><strong>Content Liability</strong></h3>

<p>We shall not be hold responsible for any content that appears on your Website. You agree to protect and defend us against all claims that is rising on your Website. No link(s) should appear on any Website that may be interpreted as libelous, obscene or criminal, or which infringes, otherwise violates, or advocates the infringement or other violation of, any third party rights.</p>

<h3><strong>Your Privacy</strong></h3>

<p>Please read Privacy Policy</p>

<h3><strong>Reservation of Rights</strong></h3>

<p>We reserve the right to request that you remove all links or any particular link to our Website. You approve to immediately remove all links to our Website upon request. We also reserve the right to amen these terms and conditions and it’s linking policy at any time. By continuously linking to our Website, you agree to be bound to and follow these linking terms and conditions.</p>

<h3><strong>Removal of links from our website</strong></h3>

<p>If you find any link on our Website that is offensive for any reason, you are free to contact and inform us any moment. We will consider requests to remove links but we are not obligated to or so or to respond to you directly.</p>

<p>We do not ensure that the information on this website is correct, we do not warrant its completeness or accuracy; nor do we promise to ensure that the website remains available or that the material on the website is kept up to date.</p>

<h3><strong>Disclaimer</strong></h3>

<p>To the maximum extent permitted by applicable law, we exclude all representations, warranties and conditions relating to our website and the use of this website. Nothing in this disclaimer will:</p>

<ul>
    <li>limit or exclude our or your liability for death or personal injury;</li>
    <li>limit or exclude our or your liability for fraud or fraudulent misrepresentation;</li>
    <li>limit any of our or your liabilities in any way that is not permitted under applicable law; or</li>
    <li>exclude any of our or your liabilities that may not be excluded under applicable law.</li>
</ul>

<p>The limitations and prohibitions of liability set in this Section and elsewhere in this disclaimer: (a) are subject to the preceding paragraph; and (b) govern all liabilities arising under the disclaimer, including liabilities arising in contract, in tort and for breach of statutory duty.</p>

<p>As long as the website and the information and services on the website are provided free of charge, we will not be liable for any loss or damage of any nature.</p>
    <p>administrator@unknownprotocol.net</p>

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
</body>  
</html>