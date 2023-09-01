<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfWizard.aspx.cs" Inherits="WaConhecendoComponentes.wfWizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" BackColor="#FFFBD6" BorderColor="#FFDFAD" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="492px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="579px">
                <HeaderStyle BackColor="#FFCC66" BorderColor="#FFFBD6" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="#333333" HorizontalAlign="Center" />
                <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
                <SideBarButtonStyle ForeColor="White" />
                <SideBarStyle BackColor="#990000" Font-Size="0.9em" VerticalAlign="Top" />
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Dados Básicos">
                        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbNome" runat="server" Width="357px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="CPF"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbCPF" runat="server" Width="355px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="RG"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbRG" runat="server" Width="350px"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Endereço">
                        <asp:Label ID="Label4" runat="server" Text="CEP"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbCEP" runat="server" Width="233px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbEstado" runat="server" Width="226px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label6" runat="server" Text="Cidade"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbCidade" runat="server" Width="231px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Rua/Avenida"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbRua" runat="server" Width="223px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label8" runat="server" Text="Bairro"></asp:Label>
                        <br />
                        <asp:TextBox ID="txbBairro" runat="server" Width="219px"></asp:TextBox>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
