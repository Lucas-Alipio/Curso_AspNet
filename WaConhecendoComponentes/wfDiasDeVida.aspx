<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfDiasDeVida.aspx.cs" Inherits="WaConhecendoComponentes.wfDiasDeVida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            height: 40px;
        }
        .auto-style6 {
            height: 256px;
        }
        .auto-style8 {
            height: 60px;
        }
        .auto-style9 {
            width: 430px;
            height: 40px;
        }
        .auto-style10 {
            width: 430px;
            height: 256px;
        }
        .auto-style11 {
            width: 430px;
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text="Data De Nascimento"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label2" runat="server" Text="Data Atual"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style10">
                        <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular dias de vida" />
                        <br />
                        <br />
                        <asp:Label ID="lblResultado" runat="server" Text="Dias de Vida:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
