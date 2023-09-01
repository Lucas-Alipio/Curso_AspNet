using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaConhecendoComponentes
{
    public partial class wfComponentes1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            //ddlSites.Items.Add(txtSite.Text);

            /*ListItem item = new ListItem(txtSite.Text, ddlSites.Items.Count.ToString());
            ddlSites.Items.Add(item);
            txtSite.Text = "";

            item = new ListItem(txtEndereco.Text, lbEndereco.Items.Count.ToString());
            lbEndereco.Items.Add(item);
            txtEndereco.Text = "";*/

            ListItem item = new ListItem(txtSite.Text, txtEndereco.Text);
            lbEndereco.Items.Add(item);
            txtEndereco.Text = "";
            txtSite.Text = "";
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            /*ListItem item = ddlSites.SelectedItem;
            txtSite.Text = item.Text;

            item = lbEndereco.SelectedItem;
            txtEndereco.Text = item.Text;*/

            ddlSites.Items.Clear();
            ListItem li;

            for (int i = 0; i < lbEndereco.Items.Count; i++)
            {
                li = lbEndereco.Items[i];
                if (li.Selected)
                {
                    //nao consegue add com o site selecionado no listBox, por isso necessario colocar em false para tirar marcação de selecionado
                    li.Selected = false;
                    ddlSites.Items.Add(li);
                }
            }

            /*no lugar do for, pode-se usar também foreach
             * foreach (ListItem item in lbEndereco.Items)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                    ddlSites.Items.Add(item);
                }
            }*/
        }
    }
}