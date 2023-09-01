using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPModulo2
{
    public partial class wfLogin : System.Web.UI.Page
    {
        List<String> Usuarios;
        String senhaPadrao = "2000";
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios = new List<string>();
            Usuarios.Add("Lucas");
            Usuarios.Add("Adm1");
            Usuarios.Add("Adm2");

            if (Request.Cookies["login"] != null)
            {
                txb_Login.Text = Request.Cookies["login"].Value;
                txb_Senha.Text = Request.Cookies["senha"].Value;

                btn_Entrar_Click(sender, e);
            }
        }

        protected void btn_Entrar_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            foreach (var item in Usuarios)
            {
                if (item == txb_Login.Text && txb_Senha.Text == senhaPadrao)
                {
                    //criando cookies na maquina do usuario
                    Response.Cookies.Add(new HttpCookie("login", txb_Login.Text));
                    Response.Cookies.Add(new HttpCookie("senha", txb_Senha.Text));

                    //Session do usuario 
                    Session["login"] = txb_Login.Text;

                    Response.Redirect("~/wfPrincipal.aspx");
                }
            }
        }
    }
}