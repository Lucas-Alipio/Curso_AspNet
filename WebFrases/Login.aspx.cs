﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFrases.DAL;
using WebFrases.MODELO;

namespace WebFrases
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void btn_Logar_Click(object sender, EventArgs e)
        {
            string email = txb_Login.Text;
            string senha = txb_Senha.Text;

            DALUsuario du = new DALUsuario();
            ModeloUsuario u = du.GetRegistro(email);

            if (email == u.Email && senha == u.Senha)
            {
                Session["id"] = u.Id;
                Session["nome"] = u.Nome;
                Session["email"] = u.Email;
                Session["senha"] = u.Senha;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                String msg = "<script> alert('Login ou senha Inválidos!!!!!');</script>";
                Response.Write(msg);
            }
        }
    }
}