using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaConhecendoComponentes
{
    public partial class wfDiasDeVida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar2.SelectedDate = DateTime.Now;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int diaN = 0, anoN = 0, mesN = 0; //N = nascimento
            int diaA = 0, anoA = 0, mesA = 0; //A = atual;

            diaN = Calendar1.SelectedDate.Day;
            mesN = Calendar1.SelectedDate.Month*30;
            anoN = Calendar1.SelectedDate.Year*365;

            diaA = Calendar2.SelectedDate.Day;
            mesA = Calendar2.SelectedDate.Month*30; //*30 -> modificando os meses de vida para dias, arredondando os meses para 30 dias
            anoA = Calendar2.SelectedDate.Year*365; //*365 -> modificando os anos para dias

            int total = (diaA + mesA + anoA) - (diaN + mesN + anoN);
            lblResultado.Text = "Dias de vida: " + total.ToString();
        }
    }
}