using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPModulo2
{
    public partial class wfPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                lbl_Login.Text = "";
                if (Request.Cookies["login"] != null)
                {
                    lbl_Login.Text = Request.Cookies["login"].Value;
                }
            }

            //Session é armazenada no server, tendo seu id vinculado ao unico usuario enquanto que o 
            //Cookie é armazenado no web browser
            if (Session["login"] == null)
            {
                Response.Redirect("~/wfLogin.aspx");
            }
            else
            {
                lbl_Login.Text = Session["login"].ToString();
                if (Session["contador"] == null)
                {
                    Session["contador"] = 0;
                }

                txb_Id.Text = Session.SessionID.ToString();
                txb_SContador.Text = Session["contador"].ToString();
            }

            //Apliccation é armazenado no server e é acessivel para todos os usuarios da aplicação
            if (Application["contador"] == null)
            {
                Application["contador"] = 0;
            }
            else
            {
                txb_CApp.Text = Application["contador"].ToString();
            }
        }

        protected void btn_Executar_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                Response.Cookies.Remove("login");
                //Request.Cookies.Clear();

                int n = Request.Cookies.Count;
            }
        }

        protected void btn_Listar_Click(object sender, EventArgs e)
        {
            var keys = Request.Cookies.AllKeys;
            String texto = "<p>";
            String pos = "";

            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                pos = keys[i];
                texto += pos + ":" + Request.Cookies[pos].Value + " ";
            }

            texto += "</p>";
            Response.Write(texto);
        }

        protected void btn_IncContS_Click(object sender, EventArgs e)
        {
            Session["contador"] = Convert.ToInt32(Session["contador"]) + 1;
        }

        protected void btn_RemoveS_Click(object sender, EventArgs e)
        {
            Session.Remove("contador");
        }

        protected void btn_AddApp_Click(object sender, EventArgs e)
        {
            Application["contador"] = Convert.ToInt32(Application["contador"]) + 1;
        }

        protected void btn_RemoveApp_Click(object sender, EventArgs e)
        {
            Application.Remove("contador");
        }
    }
}