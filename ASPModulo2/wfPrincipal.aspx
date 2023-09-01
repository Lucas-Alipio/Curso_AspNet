<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfPrincipal.aspx.cs" Inherits="ASPModulo2.wfPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_Login" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_Executar" runat="server" OnClick="btn_Executar_Click" Text="Apagar Cookies" />
&nbsp;<asp:Button ID="btn_Listar" runat="server" OnClick="btn_Listar_Click" Text="Listar Cookies" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Session ID: "></asp:Label>
            <asp:TextBox ID="txb_Id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contador da Session : "></asp:Label>
            <asp:TextBox ID="txb_SContador" runat="server"></asp:TextBox>
            <asp:Button ID="btn_IncContS" runat="server" OnClick="btn_IncContS_Click" Text="Adicionar" Width="103px" />
&nbsp;<asp:Button ID="btn_RemoveS" runat="server" OnClick="btn_RemoveS_Click" Text="Remover" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Contador da aplicação: "></asp:Label>
            <asp:TextBox ID="txb_CApp" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btn_AddApp" runat="server" OnClick="btn_AddApp_Click" Text="Adicionar" />
&nbsp;<asp:Button ID="btn_RemoveApp" runat="server" OnClick="btn_RemoveApp_Click" Text="Remover" />
        </div>
    </form>
</body>
</html>
