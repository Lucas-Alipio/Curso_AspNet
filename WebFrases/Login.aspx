<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFrases.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Login de Usuário" CssClass="login">
                <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
                <br />
                <asp:TextBox ID="txb_Login" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
                <br />
                <asp:TextBox ID="txb_Senha" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />

                <asp:Button ID="btn_Logar" runat="server" Text="Logar" OnClick="btn_Logar_Click" Width="118px"/>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
