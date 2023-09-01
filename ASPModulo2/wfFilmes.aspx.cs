using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPModulo2
{
    public partial class wfFilmes : System.Web.UI.Page
    {
        public List<String> Filmes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            ddl_Filmes.Items.Add(new ListItem(txb_Valor.Text, txb_Valor.Text));
        }

        protected void btn_Enviar_Click(object sender, EventArgs e)
        {
            Filmes = new List<string>();

            foreach (ListItem item in ddl_Filmes.Items)
            {
                Filmes.Add(item.Text);
                //Response.Redirect("~/wfRespostaFilmes.aspx");
            }
        }
    }
}