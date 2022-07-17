<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewSavedMessages.aspx.vb" Inherits="ViewSavedMessages" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
  <head id="Head1" runat="server">
    <title>ListView Example</title>
  </head>
  
  <style type="text/css">
  .WordWrap 
{
    width:100%;
    word-break: break-all;
}
    }     
  </style>

  <body>
    <form id="form1" runat="server">
        
      <asp:ListView ID="ListView"
       DataKeyNames="RelationshipID"
        runat="server">
        <LayoutTemplate>
        <div class = "WordWrap">
          <table cellpadding="2" width="100%" border="1" ID="tbl1" runat="server">
            <tr id="Tr1" runat="server" style="background-color: #4b6c9e">
             <th id="Th5" runat="server" style="color: #ffffff">Delete</th>
              <th id="Th6" runat="server" style="color: #ffffff">Picture</th>
              <th id="Th1" runat="server" style="color: #ffffff">First Name</th>
              <th id="Th2" runat="server" style="color: #ffffff">Middle Name</th>
              <th id="Th3" runat="server" style="color: #ffffff">Last Name</th>
              <th id="Th4" runat="server" style="color: #ffffff">Messages</th>
             </tr>
            <tr runat="server" id="itemPlaceholder" />
          </table>
          </div>
          <asp:DataPager runat="server" ID="DataPager"
                   PageSize="50">
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
           <asp:Button id="Delete"
           Text="Delete"
           BackColor="#4b6c9e"
           ForeColor="white"
           CommandName="Delete"
           CommandArgument='<%#Eval("ID")%>'
           OnCommand="btnDelete_Click"
           runat="server"/>
           </td>
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
              <asp:Label ID="Messages" runat="server" Text='<%# Eval("Messages") %>' />
            </td>
          </tr>
        </ItemTemplate>
      </asp:ListView>
      </form>
  </body>
</html>
