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
    public partial class Categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            DALCategoria dalC = new DALCategoria();
            gv_Dados.DataSource = dalC.Localizar();
            gv_Dados.DataBind();
        }

        private void LimparCampos()
        {
            txb_Id.Text = "";
            txb_NomeCategoria.Text = "";
            btn_Salvar.Text = "Inserir";
        }

        protected void btn_Salvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALCategoria dalC = new DALCategoria();
            ModeloCategoria obj = new ModeloCategoria();
            obj.Nome = txb_NomeCategoria.Text;

            try
            {
                if (btn_Salvar.Text == "Inserir")
                {
                    dalC.Inserir(obj);
                    msg = "<script> alert('O código gerado foi: " + obj.Id.ToString() + "');</script>";
                }
                else
                {
                    obj.Id = Convert.ToInt32(txb_Id.Text);
                    dalC.Alterar(obj);
                    msg = "<script> alert('Registro alterado corretamente!!!!!');</script>";
                }
                Response.Write(msg);
                this.LimparCampos();
                AtualizaGrid();
            }
            catch (Exception erro)
            {

               Response.Write("<script> alert('Erro: " + erro.Message + "');</script>");
            }
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        protected void gv_Dados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALCategoria dalC = new DALCategoria();
            dalC.Excluir(cod);

            AtualizaGrid();
        }

        protected void gv_Dados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gv_Dados.SelectedIndex;
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALCategoria dalC = new DALCategoria();
            ModeloCategoria cat = dalC.GetRegistro(cod);

            try
            {
                txb_Id.Text = cat.Id.ToString();
                txb_NomeCategoria.Text = cat.Nome;

                btn_Salvar.Text = "Alterar";
            }catch
            {

            }
        }
    }
}