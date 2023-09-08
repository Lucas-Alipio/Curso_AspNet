<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="WebFrases.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="Panel1" GroupingText="Cadastro/Alteração de categorias">
        <asp:Label  ID="Label1" runat="server" Text="ID:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txb_Id" Enabled="False"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Nome da Categoria:"></asp:Label>
        <br />
        <asp:TextBox ID="txb_NomeCategoria" runat="server" Width="400px"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="btn_Salvar" runat="server" Text="Inserir" Width="100px" OnClick="btn_Salvar_Click" />
        &nbsp;<asp:Button ID="btn_Cancelar" runat="server" CausesValidation="False" Text="Cancelar" Width="100px" OnClick="btn_Cancelar_Click" />
        <br />
        <br />

        <asp:Panel ID="Panel2" runat="server" GroupingText="Registro das categorias">
            <asp:GridView ID="gv_Dados" runat="server" AutoGenerateColumns="False" Width="655px" OnRowDeleting="gv_Dados_RowDeleting" OnSelectedIndexChanged="gv_Dados_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="categoria" HeaderText="categoria" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:CommandField ShowSelectButton="True" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    <asp:CommandField ShowDeleteButton="True" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </asp:Panel>
    
    </asp:Panel>
</asp:Content>
