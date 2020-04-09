<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotersRegistrationPage.aspx.cs" Inherits="VotingSystem.VotersRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VOTING SYTEM</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>VOTERS' REGISTRATION FORM</h1>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label12" runat="server" Text="Voter's ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtVoterID" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="SURNAME"></asp:Label></td>
                <td><asp:TextBox ID="txtSurname" runat="server"></asp:TextBox></td>
                <td><asp:Label runat="server" Text="OTHER NAMES" ID="Label3"></asp:Label></td>
                <td><asp:TextBox ID="txtOthernames" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2"><asp:Label runat="server" Text="DATE OF BIRTH" ID="Label1"></asp:Label></td>
                <td class="auto-style3"><asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox></td>
                <td class="auto-style2"><asp:Label runat="server" Text="EMAIL" ID="Label9"></asp:Label></td>
                <td class="auto-style3"><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="ADDRESS" ID="Label2"></asp:Label></td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
                <td class="auto-style1"><asp:Label runat="server" Text="PASSWORD" ID="Label10"></asp:Label></td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>

            </tr>

            <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="GENOTYPE" ID="Label4"></asp:Label></td>
                <td><asp:TextBox ID="txtGenotype" runat="server"></asp:TextBox></td>
                <td class="auto-style1"><asp:Label runat="server" Text="BLOOD GROUP" ID="Label11"></asp:Label></td> 
                <td><asp:TextBox ID="txtBloodGroup" runat="server"></asp:TextBox></td>
            </tr>

             <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="TELEPHONE NUMBER" ID="Label5"></asp:Label></td>
                <td><asp:TextBox ID="txtTelephone" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>

             <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="NAME OF NEXT OF KIN" ID="Label6"></asp:Label></td>
                <td><asp:TextBox ID="txtNextOfKin" runat="server"></asp:TextBox></td>
            </tr>

             <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="NEXT OF KINS' NUMBER" ID="Label7"></asp:Label></td>
                <td><asp:TextBox ID="txtNOKTelephone" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>

             <tr>
                <td class="auto-style1"><asp:Label runat="server" Text="ADDRESS OF NEXT OF KIN" ID="Label8"></asp:Label></td>
                <td><asp:TextBox ID="txtNOKAddress" runat="server"></asp:TextBox></td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="lblsuccessmessage" runat="server" Text="lblsuccessmessage"></asp:Label>
                 </td>
                <td>&nbsp;</td>
                <td><asp:Button runat="server" Text="REGISTER" BorderStyle="Inset" ForeColor="#660033" Width="89px" ID="btnReg" OnClick="RegButtonClick"></asp:Button></td> 
                <td><asp:HyperLink ID="HyperLink1" NavigateUrl="~/VotersLoginPage.aspx" runat="server">Already Registered? Login here</asp:HyperLink></td> 
            </tr>

             <tr>
                <td>
                    <asp:Label ID="lblerrormessage" runat="server" Text="lblerrormessage"></asp:Label>
                 </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td> 
                <td>&nbsp;</td> 
            </tr>

        </table>
    </div>
    </form>
</body> 
</html>
