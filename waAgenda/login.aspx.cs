using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            //capturar string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];

            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", txbEmail.Text);
            cmd.Parameters.AddWithValue("senha", txbSenha.Text);
            con.Open();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                //cookie
                HttpCookie login = new HttpCookie("login", txbEmail.Text);
                Response.Cookies.Add(login);

                //direcionar para a pagina principal
                Response.Redirect("/index.aspx");
            }
            else
            {
                Response.Write("<script> alert('Email ou Senha incorretos!!!!') </script>");
                //lblMsg.Text = "email ou senha incorretos!!!!";
            }
        }
    }
}