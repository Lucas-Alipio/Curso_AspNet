using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPModulo2
{
    public partial class wfRespostaSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //response.write("<h1> objeto request </h1>");
            //response.write("<h3> txbsb: " + request.form["txbsb"] + "</h3>");
            //response.write("<h3> txbpd: " + request.form["txbpd"] + "</h3>");

            if (Request["txbSb"] == null)
            {
                Response.Redirect("wfSalarioMinimo.aspx");
            }

            double sb = Convert.ToDouble(Request.Form["txbSb"]);
            double pd = 0;
            RadioButtonList rbl = (RadioButtonList)Page.PreviousPage.FindControl("rblPd");
            if (rbl.SelectedIndex != 3)
            {
                pd = Convert.ToDouble(rbl.SelectedItem.Value);
            }
            else
            {
                pd = Convert.ToDouble(Request.Form["txbPd"]);
            }
          
            double d = sb * pd / 100;
            double sl = sb - d;

            //Tabela com informações -> 3 Linhas x 2 Colunas (2 cells para cada linha)
            Table tabela = new Table();
            TableRow linha = new TableRow();
            TableCell celula1 = new TableCell();
            TableCell celula2 = new TableCell();

            //--------------------------- Linha 1: Salário Bruto --------------------------------
            //célula 1: texto explicativo
            celula1.Text = "Salário Bruto: ";
            linha.Cells.Add(celula1);
            //célula 2: valor
            celula2.Text = sb.ToString();
            linha.Cells.Add(celula2);
            //Adiciona a linha na tabela criada para reaproveitar as váriaveis.
            tabela.Rows.Add(linha);

            //--------------------------- Linha 2: Percentual de Desconto --------------------------------
            //Importante instanciar as váriaveis novamente
            linha = new TableRow();
            celula1 = new TableCell();
            celula2 = new TableCell();
            //célula 1: texto explicativo
            celula1.Text = "Percentual de Desconto: ";
            linha.Cells.Add(celula1);
            //célula 2: valor
            celula2.Text = pd.ToString() + " %";
            linha.Cells.Add(celula2);
            //Adiciona a linha na tabela criada para reaproveitar as váriaveis.
            tabela.Rows.Add(linha);

            //--------------------------- Linha 3: Salário Liquído --------------------------------
            //Importante instanciar as váriaveis novamente
            linha = new TableRow();
            celula1 = new TableCell();
            celula2 = new TableCell();
            //célula 1: texto explicativo
            celula1.Text = "Salário Líquido: ";
            linha.Cells.Add(celula1);
            //célula 2: valor
            celula2.Text = sl.ToString();
            linha.Cells.Add(celula2);
            //Adiciona a linha na tabela criada para reaproveitar as váriaveis.
            tabela.Rows.Add(linha);
            //****************************************************** FIM DA TABELA **********************



            //adicionar a tabela no placeholder
            PlaceHolder1.Controls.Add(tabela);
        }
    }
}