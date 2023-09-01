using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaConhecendoComponentes
{
    public partial class wfWizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Wizard1.ActiveStepIndex = 0;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //acessando pelo componente wizard
            var nome = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbNome")).Text;
            var cpf = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbCPF")).Text;
            var rg = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbRG")).Text;
            var cep = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbCEP")).Text;
            var uf = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbEstado")).Text;
            var cidade = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbCidade")).Text;
            var rua = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbRua")).Text;
            //var bairro = ((TextBox)Wizard1.WizardSteps[0].FindControl("txbBairro")).Text;

            //tem como pegar os dados diretos tbm
            var bairro = txbBairro.Text;

            Wizard1.Visible = false;
            Response.Write("<h1> Dados do formulário Wizard </h1>");
            Response.Write("<h3> Nome: " + nome + "</h3>");
            Response.Write("<h3> CPF: " + cpf + "</h3>");
            Response.Write("<h3> RG: " + rg + "</h3>");
            //.....
            Response.Write("<h3> Bairro: " + bairro + "</h3>");
        }
    }
}