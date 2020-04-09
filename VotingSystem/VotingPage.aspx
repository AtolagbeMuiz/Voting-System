<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotingPage.aspx.cs" Inherits="VotingSystem.VotingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>VOTING PROCESS PAGE</h1>
        <asp:Label ID="lblVoterID" runat="server" Text="VoterID"></asp:Label>
        <asp:TextBox ID="txtVoterID" runat="server"></asp:TextBox>
        <h3>President</h3>
        <asp:RadioButtonList ID="rbtnPresidentOption" RepeatDirection="Vertical" runat="server">
            <asp:ListItem>APC</asp:ListItem>
            <asp:ListItem>PDP</asp:ListItem>
            <asp:ListItem>AAC</asp:ListItem>
        </asp:RadioButtonList>

         <h3>Vice President</h3>
        <asp:RadioButtonList ID="rbtnVicePresidentOption" RepeatDirection="Vertical" runat="server">
            <asp:ListItem>APC</asp:ListItem>
            <asp:ListItem>PDP</asp:ListItem>
            <asp:ListItem>AAC</asp:ListItem>
        </asp:RadioButtonList>

         <h3>General Secretary</h3>
        <asp:RadioButtonList ID="rbtnGeneralSecretaryOption" RepeatDirection="Vertical" runat="server">
            <asp:ListItem>APC</asp:ListItem>
            <asp:ListItem>PDP</asp:ListItem>
            <asp:ListItem>AAC</asp:ListItem>
        </asp:RadioButtonList>
    </div>
        <asp:Button style="margin-left:100px;" runat="server" Text="VOTE" ForeColor="Blue" OnClick="Vote_Click"></asp:Button>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMesaage" runat="server" Text="lblMessage"></asp:Label>
    </form>
</body>
</html>
