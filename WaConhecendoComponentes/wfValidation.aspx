<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfValidation.aspx.cs" Inherits="WaConhecendoComponentes.wfValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#0066FF" GroupingText="Validação de campos" Height="381px" Width="818px">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
                <asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="O nome é obrigatório" ControlToValidate="txbNome"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label5" runat="server" Text="E-mail: "></asp:Label>
                <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txbEmail" ErrorMessage="Informe o e-mail corretamente" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Idade: "></asp:Label>
                <asp:TextBox ID="tbxIdade" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbxIdade" ErrorMessage="Valor fora do escopo permitido" MaximumValue="120" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha: "></asp:Label>
                <asp:TextBox ID="txbSenha1" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbSenha1" ErrorMessage="Informe uma senha"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Senha: "></asp:Label>
                <asp:TextBox ID="tbxSenha2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbSenha1" ControlToValidate="tbxSenha2" ErrorMessage="Os valores informados não são iguais."></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbxSenha2" ErrorMessage="Informe a segunda senha"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
