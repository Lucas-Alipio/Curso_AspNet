<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFrases.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
    <asp:Label ID="lbl_Nome" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
    <asp:Label ID="lbl_Email" runat="server" Text=""></asp:Label>
    <br />
</asp:Content>
