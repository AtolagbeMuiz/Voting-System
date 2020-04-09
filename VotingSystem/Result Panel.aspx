<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result Panel.aspx.cs" Inherits="VotingSystem.Result_Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result Panel</title>
    <style type="text/css">
        .auto-style4 {
            width: 161px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 161px;
        }
        .auto-style8 {
            width: 164px;
        }
        .auto-style9 {
            width: 164px;
            height: 23px;
        }
        .auto-style10 {
            width: 161px;
            height: 13px;
        }
        .auto-style11 {
            width: 164px;
            height: 13px;
        }
        .auto-style12 {
            height: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <legend>Result Panel</legend>
            <fieldset>
               <table style="width:100%;">
                   <tr>
                       <td class="auto-style7">
                           <asp:Label ID="lblPosts" runat="server" Text="Posts"></asp:Label>
                       </td>
                       <td class="auto-style8">
                           <asp:Label ID="Label1" runat="server" Text="APC"></asp:Label>
                       </td>
                       <td class="auto-style7">
                           <asp:Label ID="Label2" runat="server" Text="PDP"></asp:Label>
                       </td>

                       <td>
                           <asp:Label ID="Label3" runat="server" Text="AAC"></asp:Label>
                       </td>

                   </tr>
                   <tr>
                           <td class="auto-style7">
                               <asp:Label ID="lblPresident" runat="server" Text="President"></asp:Label>
                           </td>
                           <td class="auto-style8">
                               <asp:TextBox ID="txtAPCPres" runat="server" ReadOnly="True"></asp:TextBox>
                           </td>
                           <td class="auto-style7">
                               <asp:TextBox ID="txtPDPPres" runat="server" ReadOnly="True"></asp:TextBox>
                           </td>

                           <td>
                               <asp:TextBox ID="txtAACPres" runat="server" ReadOnly="True"></asp:TextBox>
                           </td>

                   </tr>
                   <tr>
                       <td class="auto-style7">
                           <asp:Label ID="lblVice" runat="server" Text="Vice Pressident"></asp:Label>
                       </td>
                       <td class="auto-style8">
                           <asp:TextBox ID="txtAPCVice" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>
                       <td class="auto-style7">
                           <asp:TextBox ID="txtPDPVice" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>

                       <td>
                           <asp:TextBox ID="txtAACVice" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                           <asp:Label ID="lblGenSec" runat="server" Text="General Secretary"></asp:Label>
                       </td>
                       <td class="auto-style9">
                           <asp:TextBox ID="txtAPCGenSec" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>
                       <td class="auto-style4">
                           <asp:TextBox ID="txtPDPGenSec" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>

                       <td class="auto-style6">
                           <asp:TextBox ID="txtAACGenSec" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                           <asp:Label ID="lblMessage" runat="server" Text="lblMessage"></asp:Label>
                       </td>
                       <td class="auto-style9">
                           <asp:Button ID="btnShowAllResults" runat="server" OnClick="btnShowAllResults_Click" Text="Show All Results" />
                       </td>
                       <td class="auto-style4">
                           &nbsp;</td>

                       <td class="auto-style6">
                           &nbsp;</td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                       </td>
                       <td class="auto-style9">
                           <asp:Label ID="Label4" runat="server" Text="Winners"></asp:Label>
                       </td>
                       <td class="auto-style4">
                           </td>

                       <td class="auto-style6">
                           </td>

                   </tr>

                   <tr>
                       <td class="auto-style10">
                           <asp:Label ID="lblPresidentWinner" runat="server" Text="President"></asp:Label>
                       </td>
                       <td class="auto-style11">
                           <asp:TextBox ID="txtPresWinner" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;</td>
                       <td class="auto-style10">
                           </td>

                       <td class="auto-style12">
                           </td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                           <asp:Label ID="lblVicePresWinner" runat="server" Text="Vice President"></asp:Label>
                       </td>
                       <td class="auto-style9">
                           <asp:TextBox ID="txtVicePresWinner" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>
                       <td class="auto-style4">
                           &nbsp;</td>

                       <td class="auto-style6">
                           &nbsp;</td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                           <asp:Label ID="lblGenSenWinner" runat="server" Text="General Secretary"></asp:Label>
                       </td>
                       <td class="auto-style9">
                           <asp:TextBox ID="txtGenSecWinner" runat="server" ReadOnly="True"></asp:TextBox>
                       </td>
                       <td class="auto-style4">
                           &nbsp;</td>

                       <td class="auto-style6">
                           &nbsp;</td>

                   </tr>

                   <tr>
                       <td class="auto-style4">
                           &nbsp;</td>
                       <td class="auto-style9">
                           <asp:Button ID="Button1" runat="server" OnClick="DeclareWinner_Click" Text="Declare Winner" />
                       </td>
                       <td class="auto-style4">
                           &nbsp;</td>

                       <td class="auto-style6">
                           &nbsp;</td>

                   </tr>

               </table>
            </fieldset>
    </form>
</body>
</html>
