<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfParOuImparFatorial.aspx.cs" Inherits="WaConhecendoComponentes.wfParOuImparFatorial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="blLista" runat="server" BorderStyle="None" BulletStyle="Square" Width="900px" DisplayMode="LinkButton" OnClick="blLista_Click" Visible="False">
                <asp:ListItem>Par ou Impar</asp:ListItem>
                <asp:ListItem>Calcula o Fatorial</asp:ListItem>
            </asp:BulletedList>

            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="270px">
                <asp:ListItem>Par ou Impar</asp:ListItem>
                <asp:ListItem>Fatorial</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />

            <asp:Panel ID="pnParOuImpar" runat="server" Visible="False">
                <asp:Label ID="Label1" runat="server" Text="Verifica se o número informado é par ou impar"></asp:Label>
                <br />
                <asp:TextBox ID="TxtValorpn1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Verificar" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="LResp1" runat="server"></asp:Label>

            </asp:Panel>
            <br />

            <asp:Panel ID="pnFatorial" runat="server" Visible="False">
                <asp:Label ID="Label3" runat="server" Text="Calcula o fatorial de um número"></asp:Label>
                <br />
                <asp:TextBox ID="TxtValorpn2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Calcular" OnClick="Button2_Click" />
                <br />
                <asp:Label ID="LResp2" runat="server"></asp:Label>
            </asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
