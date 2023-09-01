<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfMenu.aspx.cs" Inherits="WaConhecendoComponentes.wfMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#F7F6F3" />
                <DynamicSelectedStyle BackColor="#5D7B9D" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/wfCursos.aspx" Text="Cadastros" Value="Cadastros">
                        <asp:MenuItem Text="Clientes" Value="Clientes"></asp:MenuItem>
                        <asp:MenuItem Text="Fornecedores" Value="Fornecedores"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Consultas" Value="Consultas"></asp:MenuItem>
                    <asp:MenuItem Text="Relatórios" Value="Relatórios"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#5D7B9D" />
            </asp:Menu>
        </div>
    </form>
</body>
</html>
