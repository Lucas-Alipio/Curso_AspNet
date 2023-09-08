<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="Frase.aspx.cs" Inherits="WebFrases.Frase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="Panel1" GroupingText="Cadastro/Alteração de Frases">
        <asp:Label  ID="Label1" runat="server" Text="ID:"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txb_Id" Enabled="False"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Frase:"></asp:Label>
        <br />
        <asp:TextBox ID="txb_Frase" runat="server" Width="600px"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Autor:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_Autor" runat="server" Width="220px"></asp:DropDownList>
        <br />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Categoria:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_Categoria" runat="server" Width="220px"></asp:DropDownList>
        <br />
        <br />

        <asp:Button ID="btn_Salvar" runat="server" Text="Inserir" Width="100px" OnClick="btn_Salvar_Click"/>
        &nbsp;<asp:Button ID="btn_Cancelar" runat="server" CausesValidation="False" Text="Cancelar" Width="100px" OnClick="btn_Cancelar_Click"/>
        <br />
        <br />

        <asp:Panel ID="Panel2" runat="server" GroupingText="Registro das Frases">
            <asp:GridView ID="gv_Dados" runat="server" AutoGenerateColumns="False" Width="800px" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="gv_Dados_RowDeleting" OnSelectedIndexChanged="gv_Dados_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" >
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>

                    <asp:BoundField DataField="frase" HeaderText="Frase" >
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>

                    <asp:BoundField DataField="nomeAutor" HeaderText="Autor" >
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>

                    <asp:BoundField DataField="nomeCategoria" HeaderText="Categoria" >
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
