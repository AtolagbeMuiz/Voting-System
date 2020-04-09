<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotersLoginPage.aspx.cs" Inherits="VotingSystem.VotersLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 87px;
        }
        .auto-style3 {
            width: 87px;
        }
        .auto-style4 {
            height: 23px;
            width: 202px;
        }
        .auto-style5 {
            width: 202px;
        }
        .auto-style6 {
            width: 87px;
            height: 30px;
        }
        .auto-style7 {
            width: 202px;
            height: 30px;
            text-align: right;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="VOTER'S ID"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtLoginVoterID" runat="server" Width="166px"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtLoginPassword" runat="server" Width="169px" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblLoginErrorMessage" runat="server" Text="LabelError"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" Text="LOGIN" Font-Bold="True" Width="72px" OnClick="Login_Click" />
                </td>
                <td class="auto-style8">
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/VotersRegistrationPage.aspx" runat="server">Haven't Registered? Register Here</asp:HyperLink>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
