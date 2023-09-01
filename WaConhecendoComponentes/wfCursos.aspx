<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfCursos.aspx.cs" Inherits="WaConhecendoComponentes.wfCursos" %>

<%@ Register src="wucMenu.ascx" tagname="wucMenu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:wucMenu ID="wucMenu1" runat="server" />
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="propagandas.xml" Target="_blank"/>
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server" Text="&lt;h1&gt;Alô Mundo!!!!!&lt;/h1&gt;"></asp:Literal>
            <br />
        </div>
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Naruto" DescriptionUrl="Naruto" ImageUrl="~/imagens/naruto.jpg" OnClick="ImageButton1_Click" ToolTip="Clique aqui para saber mais" Width="500px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="Daki" DescriptionUrl="Daki" ImageUrl="~/imagens/daki.jpg" OnClick="ImageButton2_Click" ToolTip="Clique aqui para saber mais" Width="500px" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Naruto"></asp:Label>
                    <br />
                    <p>Personagem principal do anime Naruto</p>
                    <p>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com/search?sca_esv=558787020&amp;rlz=1C1RXQR_pt-PTBR1070BR1070&amp;q=naruto&amp;tbm=isch&amp;source=lnms&amp;sa=X&amp;ved=2ahUKEwj0poDPju6AAxWECbkGHTW_DNIQ0pQJegQIDxAB&amp;biw=1536&amp;bih=715&amp;dpr=1.25" Target="_blank">Veja mais fotos no google</asp:HyperLink>
                    </p>
                    <p>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://www.google.com/" Target="_blank">Procure você mesmo pelo google</asp:HyperLink>
                    </p>
                    <p>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
                    </p>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Daki"></asp:Label>
                    <br />
                    <p>Sexto oni dos doze kizuki de Kimetsu no Yaiba</p>
                    <p>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="https://www.google.com/search?sca_esv=558787020&amp;q=daki+demon+slayer&amp;tbm=isch&amp;source=lnms&amp;sa=X&amp;ved=2ahUKEwi5yZevj-6AAxXGpZUCHWYxBoQQ0pQJegQIDBAB&amp;biw=1536&amp;bih=715&amp;dpr=1.25" Target="_blank">Veja mais fotos no google</asp:HyperLink>
                    </p>
                    <p>
                        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="https://www.google.com/" Target="_blank">Procure você mesmo pelo google</asp:HyperLink>
                    </p>
                    <p>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
                    </p>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
