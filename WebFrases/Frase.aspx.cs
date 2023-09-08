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
    public partial class Frase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            if (!IsPostBack)
            { 
                AtualizaAutor();
                AtualizaCategoria();
            }
        }

        public void AtualizaGrid()
        {
            DALFrase dal = new DALFrase();
            gv_Dados.DataSource = dal.Localizar();
            gv_Dados.DataBind();
        }

        public void AtualizaAutor()
        {
            DALAutor dal = new DALAutor();
            ddl_Autor.DataSource = dal.Localizar();
            ddl_Autor.DataTextField = "nome";
            ddl_Autor.DataValueField = "id";
            ddl_Autor.DataBind();
        }

        public void AtualizaCategoria()
        {
            DALCategoria dal = new DALCategoria();
            ddl_Categoria.DataSource = dal.Localizar();
            ddl_Categoria.DataTextField = "categoria";
            ddl_Categoria.DataValueField = "id";
            ddl_Categoria.DataBind();
        }

        private void LimparCampos()
        {
            txb_Id.Text = "";
            txb_Frase.Text = "";
            btn_Salvar.Text = "Inserir";
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        protected void btn_Salvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALFrase dal = new DALFrase();
            ModeloFrase obj = new ModeloFrase();

            obj.Texto = txb_Frase.Text;
            obj.Autor = Convert.ToInt32(ddl_Autor.SelectedValue);
            obj.Categoria = Convert.ToInt32(ddl_Categoria.SelectedValue);


            try
            {
                if (btn_Salvar.Text == "Inserir")
                {
                    dal.Inserir(obj);
                    msg = "<script> alert('O código gerado foi: " + obj.Id.ToString() + "');</script>";
                }
                else
                {
                    obj.Id = Convert.ToInt32(txb_Id.Text);
                    dal.Alterar(obj);
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

        protected void gv_Dados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gv_Dados.SelectedIndex;
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALFrase dal = new DALFrase();
            ModeloFrase fra = dal.GetRegistro(cod);

            try
            {
                txb_Id.Text = fra.Id.ToString();
                txb_Frase.Text = fra.Texto;
                ddl_Autor.SelectedValue = fra.Autor.ToString();
                ddl_Categoria.SelectedValue = fra.Categoria.ToString();

                btn_Salvar.Text = "Alterar";
            }
            catch
            {

            }
        }

        protected void gv_Dados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALFrase dal = new DALFrase();
            dal.Excluir(cod);

            AtualizaGrid();
        }
    }
}