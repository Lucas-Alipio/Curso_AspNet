<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucMenu.ascx.cs" Inherits="WaConhecendoComponentes.wucMenu" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/wfCursos.aspx" Text="Cursos" Value="Cursos"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/wfTabuada.aspx" Text="Tabuada" Value="Tabuada"></asp:MenuItem>
    </Items>
</asp:Menu>

