<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfSitesParceiros.aspx.cs" Inherits="WaConhecendoComponentes.wfSitesParceiros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/imagens/Google-Facebook-Instagram.png">
                <asp:RectangleHotSpot AlternateText="Google" Bottom="170" NavigateUrl="https://www.google.com" Right="140" Target="_blank" />
                <asp:RectangleHotSpot AlternateText="Facebook" Bottom="170" Left="155" NavigateUrl="https://www.facebook.com" Right="280" Target="_blank" />
                <asp:RectangleHotSpot AlternateText="Instagram" Bottom="170" Left="295" NavigateUrl="https://www.instagram.com/" Right="455" Target="_blank" />
            </asp:ImageMap>
        </div>
    </form>
</body>
</html>
