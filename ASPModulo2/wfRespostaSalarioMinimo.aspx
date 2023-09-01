<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfRespostaSalarioMinimo.aspx.cs" Inherits="ASPModulo2.wfRespostaSalarioMinimo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1> Cálculo do Salário Mínimo</h1>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <asp:Button ID="btnVoltar" runat="server" PostBackUrl="~/wfSalarioMinimo.aspx" Text="Voltar" />
        </div>
    </form>
</body>
</html>
