<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TheList.aspx.vb" Inherits="TheList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 41px;
        }
        .auto-style8 {
            height: 41px;
            width: 137px;
        }
        .auto-style9 {
            width: 137px;
        }
        .auto-style10 {
            height: 41px;
            width: 80px;
        }
        .auto-style11 {
            width: 205px;
        }
        .auto-style12 {
            height: 41px;
            width: 205px;
        }
        .auto-style13 {
            width: 167px;
        }
        .auto-style14 {
            height: 41px;
            width: 167px;
        }
    </style>
    </head>
<body>

     <form id="form1" runat="server">

     <table border="1" cellpadding="0" cellspacing="0" height="178" width="450">
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbAngry" GroupName="Emotions" Text="Angry" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbAnxious" GroupName="Emotions" Text="Anxious"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbBlewUp" GroupName="Emotions" Text="Blew Up" runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbBored" GroupName="Emotions" Text="Bored" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbCalm" GroupName="Emotions" Text="Calm" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbCautious" GroupName="Emotions" Text="Cautious"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbCool" GroupName="Emotions" Text="Cool" runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbCollected" GroupName="Emotions" Text="Collected"
                                    runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbContent" GroupName="Emotions" Text="Content"
                                    runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbConfused" GroupName="Emotions" Text="Confused"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbConfident" GroupName="Emotions" Text="Confident"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbCrying" GroupName="Emotions" Text="Crying" runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbDepressed" GroupName="Emotions" Text="Depressed"
                                    runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbDown" GroupName="Emotions" Text="Down" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbDuress" GroupName="Emotions" Text="Duress" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbDiscriminated" GroupName="Emotions" Text="Discriminated"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbDisgusted" GroupName="Emotions" Text="Disgusted"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbEcstatic" GroupName="Emotions" Text="Ecstatic"
                                    runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbEmbarrassed" GroupName="Emotions" Text="embarrassed"
                                    runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbEnraged" GroupName="Emotions" Text="Enraged"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbExhausted" GroupName="Emotions" Text="Exhausted"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbFrightend" GroupName="Emotions" Text="Frightened"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbFrustrated" GroupName="Emotions" Text="Frustrated"
                                    runat="server" />

                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbGuilty" GroupName="Emotions" Text="Guilty" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbHappy" GroupName="Emotions" Text="Happy" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbHonorable" GroupName="Emotions" Text="Honorable"
                                    runat="server" />

                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbHopeful" GroupName="Emotions" Text="Hopeful"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbHysterical" GroupName="Emotions" Text="Hysterical"
                                    runat="server" />

                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbInlove" GroupName="Emotions" Text="InLove" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbJealous" GroupName="Emotions" Text="Jealous"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:RadioButton ID="rbLightenedUp" GroupName="Emotions" Text="Lightened Up"
                                    runat="server" />

                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbLonley" GroupName="Emotions" Text="Lonley" runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbLoveStruck" GroupName="Emotions" Text="Love Struck"
                                    runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbMad" GroupName="Emotions" Text="Mad" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbMedicated" GroupName="Emotions" Text="Medicated"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:RadioButton ID="rbMischievous" GroupName="Emotions" Text="Mischievous"
                                    runat="server" />
                            </td>
                            <td class="auto-style14">
                                <asp:RadioButton ID="rbOverwhelmed" GroupName="Emotions" Text="Overwhelmed"
                                    runat="server" />
                            </td>
                            <td class="auto-style12">
                                <asp:RadioButton ID="rbPain" GroupName="Emotions" Text="Pain" runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbPowerful" GroupName="Emotions" Text="Powerful"
                                    runat="server" />
                            </td>
                            <td class="auto-style1">
                                <asp:RadioButton ID="rbProvoked" GroupName="Emotions" Text="Provoked"
                                    runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:RadioButton ID="rbQuite" GroupName="Emotions" Text="Quite" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbRelaxed" GroupName="Emotions" Text="Relaxed"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbSad" GroupName="Emotions" Text="Sad" runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbSceptical" GroupName="Emotions" Text="Sceptical" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbSexy" GroupName="Emotions" Text="Sexy" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:RadioButton ID="rbShocked" GroupName="Emotions" Text="Shocked"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbShy" GroupName="Emotions" Text="Shy" runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbSmug" GroupName="Emotions" Text="Smaug" runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbStressed" GroupName="Emotions" Text="Stressed"
                                    runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbStupid" GroupName="Emotions" Text="Stupid" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:RadioButton ID="rbSuprised" GroupName="Emotions" Text="Suprised"
                                    runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbSuspicious" GroupName="Emotions" Text="Suspicious"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbTired" GroupName="Emotions" Text="Tired" runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbUnhappy" GroupName="Emotions" Text="Unhappy" runat="server" />
                            </td>
                            <td>
                                <asp:RadioButton ID="rbUpbeat" GroupName="Emotions" Text="Upbeat" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:RadioButton ID="rbUpset" GroupName="Emotions" Text="Upset" runat="server" />
                            </td>
                            <td class="auto-style13">
                                <asp:RadioButton ID="rbUptight" GroupName="Emotions" Text="Uptight"
                                    runat="server" />
                            </td>
                            <td class="auto-style11">
                                <asp:RadioButton ID="rbVengeful" GroupName="Emotions" Text="Vengeful"
                                    runat="server" />
                            </td>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rbWondering" GroupName="Emotions" Text="Wondering"
                                    runat="server" />
                            </td>
                        </tr>
                    </table>

     </form>

</body>
</html>
