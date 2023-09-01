<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WaConhecendoComponentes.index" %>

<%@ Register src="wucMenu.ascx" tagname="wucMenu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        <uc1:wucMenu ID="wucMenu1" runat="server" />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/wfTabuada.aspx">Tabuada</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/wfParOuImparFatorial.aspx">Par Ou Impar</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/wfDiasDeVida.aspx">Calcula os dias de vida</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagens/daki.jpg" PostBackUrl="~/wfCursos.aspx" Width="200px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagens/naruto.jpg" PostBackUrl="~/wfCursos.aspx" Width="200px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/imagens/coca.jpg" PostBackUrl="~/wfAlteraTamanhoFonte.aspx" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
