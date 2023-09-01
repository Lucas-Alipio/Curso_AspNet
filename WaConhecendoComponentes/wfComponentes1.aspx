<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfComponentes1.aspx.cs" Inherits="WaConhecendoComponentes.wfComponentes1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conhecendo os componentes - parte 1</title>
    <style type="text/css">
        .auto-style2 {
            width: 334px;
        }
        .auto-style3 {
            margin-right: 0px;
        }
        .auto-style4 {
            width: 388px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">Site</td>
                    <td class="auto-style2">Endereço</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtSite" runat="server" CssClass="auto-style3" Width="330px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEndereco" runat="server" CssClass="auto-style3" Width="330px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ListBox ID="lbEndereco" runat="server" Width="330px" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td class="auto-style2">
                        Opções<br />
                        <asp:Button ID="btnInserir" runat="server" CssClass="auto-style3" OnClick="btnInserir_Click" Text="Inserir Site" Width="150px" />
                        <asp:Button ID="btnSelecionar" runat="server" OnClick="btnSelecionar_Click" Text="Selecionar Site" Width="150px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlSites" runat="server" Width="327px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
