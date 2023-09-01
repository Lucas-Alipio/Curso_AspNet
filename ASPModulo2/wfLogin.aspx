<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="ASPModulo2.wfLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
                <br />
                <asp:TextBox ID="txb_Login" runat="server" Width="280px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
                <br />
                <asp:TextBox ID="txb_Senha" runat="server" TextMode="Password" Width="280px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btn_Entrar" runat="server" OnClick="btn_Entrar_Click" Text="Entrar" Width="140px" />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
