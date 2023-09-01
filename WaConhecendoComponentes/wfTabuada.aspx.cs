using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaConhecendoComponentes
{
    public partial class wfTabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // isPostBack é quando voce está retornando para a página (servidor do site em questão)
            // =false significa que é a primeira vez que voce está acessando, fazendo requisição para o servidor 
            if(!IsPostBack)
            {
                for (int i = 2; i < 11; i++)
                {
                    ddlNumeros.Items.Add(i.ToString());
                }
            }
        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            //lbDados.Items.Clear();
            ListItem li = ddlNumeros.SelectedItem;
            int n = Convert.ToInt32(li.Value);
            //int t = 0;

            //calcula para preencher a tabela feita a mao 
            //for (int i = 0; i < 11; i++)
            //{
            //    t = i * n;
            //    //list box
            //    //lbDados.Items.Add(i.ToString() + " X " + n.ToString() + " = " + t.ToString());

            //    //table
            //    tblDados.Rows[i].Cells[0].Text = n.ToString();
            //    tblDados.Rows[i].Cells[4].Text = t.ToString();
            //}


            //calcula e faz a tabela na hora para preencher o placeholder
            Table tabela = new Table();
            int t = 0;
            for (int i = 0; i <= 10; i++)
            {
                TableRow linha = new TableRow();
                //1 celula
                TableCell coluna = new TableCell();
                coluna.Text = n.ToString() + " X " + i.ToString() + " = ";
                linha.Cells.Add(coluna);
                //2 celula
                coluna = new TableCell();
                t = i * n;
                coluna.Text = t.ToString();
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);
            }
            PlaceHolder.Controls.Add(tabela);
        }
    }
}