using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpLoad
{
    public partial class UpLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = fuArquivo.FileName;

                //encontra o caminho da pasta mencionado no argumento
                //necessario ter a \ no final para sinalizar que é uma pasta
                String caminho = Server.MapPath(@"upload\");

                txbNome.Text = nome;

                txbTamanho.Text = fuArquivo.PostedFile.ContentLength.ToString();

                fuArquivo.PostedFile.SaveAs(caminho + nome);
            }
            catch { }
        }

        protected void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = "";
                //encontra o caminho da pasta mencionado no argumento
                //necessario ter a \ no final para sinalizar que é uma pasta
                String caminho = Server.MapPath(@"upload\");

                for (int i = 0; i < fuArquivo.PostedFiles.Count; i++)
                {
                    nome = nome + fuArquivo.PostedFiles[i].FileName + " - ";
                    fuArquivo.PostedFiles[i].SaveAs(caminho + fuArquivo.PostedFiles[i].FileName);
                }
                txbNome.Text = nome;
            }
            catch { }
        }
    }
}