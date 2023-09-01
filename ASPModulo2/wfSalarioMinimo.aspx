<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfSalarioMinimo.aspx.cs" Inherits="ASPModulo2.wfSalarioMinimo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Informe o Salário Bruto:"></asp:Label>
            <br />
            <asp:TextBox ID="txbSb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Percentual de Desconto:"></asp:Label>
            <br />
            <asp:RadioButtonList ID="rblPd" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="10">10 %</asp:ListItem>
                <asp:ListItem Value="20">20 %</asp:ListItem>
                <asp:ListItem Value="30">30 %</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txbPd" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" PostBackUrl="~/wfRespostaSalarioMinimo.aspx" Text="Enviar Dados" />
&nbsp;</div>
    </form>
</body>
</html>
