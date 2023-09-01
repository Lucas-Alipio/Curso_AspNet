<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpLoad.aspx.cs" Inherits="UpLoad.UpLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="UPLOAD de Arquivos"></asp:Label>
            <br />
            <br />
            <asp:FileUpload ID="fuArquivo" runat="server" AllowMultiple="True" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome do Arquivo: "></asp:Label>
            <asp:TextBox ID="txbNome" runat="server" Width="754px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Tamanho do Arquivo: "></asp:Label>
            <asp:TextBox ID="txbTamanho" runat="server" Width="729px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar Arquivo" Width="346px" />
            <asp:Button ID="btnEnviar2" runat="server" OnClick="btnEnviar2_Click" Text="Enviar multiplos arquivos" />
        </div>
    </form>
</body>
</html>
