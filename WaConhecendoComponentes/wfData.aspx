<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfData.aspx.cs" Inherits="WaConhecendoComponentes.wfData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
            <br />
            <asp:TextBox ID="txbNome" runat="server" Width="230px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmail" runat="server" Width="230px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Lista de Contatos"></asp:Label>
            <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="306px">
                <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <ItemTemplate>
                    Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Nome:
                    <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' />
                    <br />
                    Email:
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    <br />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#E2DED6" ForeColor="#333333" Font-Bold="True" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Nome], [Email] FROM [Contato]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
