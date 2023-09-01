<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBasicoJavaScript.aspx.cs" Inherits="WaConhecendoComponentes.wfBasicoJavaScript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript"/>
        function ExibeMensagem() {
            alert('Alô Mundo!!');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagens/daki.jpg" Width="800px" OnMouseOver="ExibeMensagem()"/>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Clique no Botão" Width="798px" OnClientClick="ExibeMensagem()" />
        </div>
    </form>
</body>
</html>
