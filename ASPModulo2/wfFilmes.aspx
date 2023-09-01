<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfFilmes.aspx.cs" Inherits="ASPModulo2.wfFilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Filmes: Insira um novo filme digitando seu nome na caixa de texto!!"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddl_Filmes" runat="server">
            </asp:DropDownList>
&nbsp;<asp:TextBox ID="txb_Valor" runat="server" ToolTip="Digite o nome de um filme"></asp:TextBox>
&nbsp;<asp:Button ID="btn_add" runat="server" OnClick="btn_add_Click" Text="Adicionar" />
            <br />
            <br />
            <asp:Button ID="btn_Enviar" runat="server" OnClick="btn_Enviar_Click" Text="Enviar" Width="116px" PostBackUrl="~/wfRespostaFilmes.aspx" />
        </div>
    </form>
</body>
</html>
