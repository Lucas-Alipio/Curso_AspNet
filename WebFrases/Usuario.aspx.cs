using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFrases.DAL;
using WebFrases.MODELO;

namespace WebFrases
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            DALUsuario dal = new DALUsuario();
            gv_Dados.DataSource = dal.Localizar();
            gv_Dados.DataBind();
        }

        private void LimparCampos()
        {
            txb_Id.Text = "";
            txb_Nome.Text = "";
            txb_Email.Text = "";
            txb_Senha.Text = "";
            btn_Salvar.Text = "Inserir";
        }

        protected void btn_Salvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALUsuario dal = new DALUsuario();
            ModeloUsuario obj = new ModeloUsuario();

            obj.Nome = txb_Nome.Text;
            obj.Email = txb_Email.Text;
            obj.Senha = txb_Senha.Text;

            ModeloUsuario validaEmail = dal.GetRegistro(txb_Email.Text);
            try
            {
                if (btn_Salvar.Text == "Inserir")
                {
                    //Validação do Email....
                    if (validaEmail.Id == 0)
                    {
                        dal.Inserir(obj);
                        msg = "<script> alert('O código gerado foi: " + obj.Id.ToString() + "');</script>";
                        this.LimparCampos();
                    }
                    else
                    {
                        msg = "<script> alert('Não é possível cadastrar o usuário. Já existe um usuário " +
                            "cadastrado com esse Email!!!!!');</script>";
                    }
                }
                else
                {
                    obj.Id = Convert.ToInt32(txb_Id.Text);
                    //Validação do Email....
                    if (validaEmail.Id != 0 && validaEmail.Id != obj.Id)
                    {
                        msg = "<script> alert('Não é possível alterar o usuário. Já existe um usuário " +
                            "cadastrado com esse Email!!!!!');</script>";
                    }
                    else
                    { 
                        dal.Alterar(obj);
                        msg = "<script> alert('Registro alterado corretamente!!!!!');</script>";
                        this.LimparCampos();
                    } 
                }

                Response.Write(msg);
                
            }
            catch (Exception erro)
            {

                Response.Write("<script> alert('Erro: " + erro.Message + "');</script>");
            }

            AtualizaGrid();
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        protected void gv_Dados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALUsuario dal = new DALUsuario();
            dal.Excluir(cod);

            AtualizaGrid();
        }

        protected void gv_Dados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gv_Dados.SelectedIndex;
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALUsuario dal = new DALUsuario();
            ModeloUsuario usu = dal.GetRegistro(cod);

            try
            {
                txb_Id.Text = usu.Id.ToString();
                txb_Nome.Text = usu.Nome;
                txb_Email.Text = usu.Email;
                txb_Senha.Text = usu.Senha;
                

                btn_Salvar.Text = "Alterar";
            }
            catch
            {

            }
        }
    }
}