<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotersPortal.aspx.cs" Inherits="VotingSystem.VotersPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>VOTERS' PORTAL</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <style type="text/css">
        .auto-style1 {
            width: 199px;
        }
        .auto-style2 {
            width: 199px;
            height: 22px;
        }
        .auto-style3 {
            height: 22px;
        }
        .auto-style4 {
            width: 275px;
        }
        .auto-style5 {
            height: 22px;
            width: 275px;
        }
        .auto-style6 {
            width: 276px;
        }
        .auto-style7 {
            height: 22px;
            width: 276px;
        }
    </style>

</head>
<body class="container">
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="#">Welcome,<asp:Label ID="lblwelcomevotername" runat="server" Text="Label"></asp:Label></a>
                </div>
                <div class="navbar-collapse collapse">
                    <asp:LoginView runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <%--<li><a runat="server" href="~/#">Account</a></li>--%>

                    <div class="dropdown" style=" margin-top:15px;">
                      
                          <a class="nav-link nav-item dropdown-toggle"  data-toggle="dropdown" id="Account" aria-haspopup="true" aria-expanded="false" href="#" style="font-size:20px;">Account</a>
                          
                          <div class="dropdown-menu arialabelledby=Account">
                              <a class="dropdown-item text-capitalize" href="VotersRegistrationPage.aspx">Register</a> 
                              <a class="dropdown-item text-capitalize" href="VotersLoginPage.aspx">Login</a> 
                              <a class="dropdown-item text-capitalize" href="#">Logout</a>  
                          </div>
                      
                      </div>

                            </ul>
                        </AnonymousTemplate>
                       <%-- <LoggedInTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a runat="server" href="~/Account/Manage" title="Manage your account">Hello, <%: Context.User.Identity.GetUserName()  %> !</a></li>
                                <li>
                                    <asp:LoginStatus runat="server" />
                                </li>
                            </ul>
                        </LoggedInTemplate>--%>
                    </asp:LoginView>
                </div>

            </div>
        </div>

        <table style="width:100%;">
            <%--<tr>
                <td class="auto-style2">
                    <asp:Label ID="lblWelcome" runat="server" Text="Welcome"></asp:Label>
                    <asp:Label ID="lblWelcomeName" runat="server" Text="lblWelcomeName"></asp:Label>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>

                <td class="auto-style3">
                    &nbsp;</td>

            </tr>--%>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl" runat="server" Text="SURNAME"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblSurname" runat="server" Text="lblSurname"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbl8" runat="server" Text="OTHER NAMES"></asp:Label>
                </td>

                <td class="auto-style3">
                    <asp:Label ID="lblOthernames" runat="server" Text="lblOthernames"></asp:Label>
                </td>

            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl1" runat="server" Text="DOB"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblDOB" runat="server" Text="lblDOB"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbl9" runat="server" Text="EMAIL"></asp:Label>
                </td>

                <td class="auto-style3">
                    <asp:Label ID="lblEmail" runat="server" Text="lblEmail"></asp:Label>
                </td>

            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl2" runat="server" Text="ADDRESS"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblAddress" runat="server" Text="lblAddress"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbl10" runat="server" Text="BLOOD GROUP"></asp:Label>
                </td>

                <td class="auto-style3">
                    <asp:Label ID="lblBloodGroup" runat="server" Text="lblBloodGroup"></asp:Label>
                </td>

            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lbl3" runat="server" Text="GENOTYPE"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblGenotype" runat="server" Text="lblGenotype"></asp:Label>
                </td>
                <td class="auto-style6">
                    &nbsp;</td>

                <td>
                    &nbsp;</td>

            </tr>

            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl4" runat="server" Text="TELEPHONE NUMBER"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblTel" runat="server" Text="lblTel"></asp:Label>
                </td>
                <td class="auto-style7"></td>

                <td class="auto-style3"></td>

            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lbl5" runat="server" Text="NEXT OF KIN"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblNextOfKin" runat="server" Text="lblNextOfKin"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>

                <td>&nbsp;</td>

            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lbl6" runat="server" Text="lblAddressOfNextOfKin"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblNextOfKinNumber" runat="server" Text="lblNextOfKinNumber"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>

                <td>&nbsp;</td>

            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lbl7" runat="server" Text="ADDRESS OF NEXT OF KIN"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblAddressofNextofKin" runat="server" Text="lblAddressofNextofKin"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/VotingPage.aspx" runat="server">Click here to Vote</asp:HyperLink>
                </td>

                <td>&nbsp;</td>

            </tr>

        </table>

    </form>
</body>
</html>
