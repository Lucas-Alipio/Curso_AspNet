using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFrases.DAL;
using WebFrases.MODELO;

namespace WebFrases
{
    public partial class Autor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            DALAutor dalA = new DALAutor();
            gv_Dados.DataSource = dalA.Localizar();
            gv_Dados.DataBind();
        }

        private void LimparCampos()
        {
            txb_Id.Text = "";
            txb_Nome.Text = "";
            btn_Salvar.Text = "Inserir";
        }

        protected void btn_Salvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            string caminho = Server.MapPath(@"IMAGENS/AUTORES/");
            DALAutor dalA = new DALAutor();
            ModeloAutor obj = new ModeloAutor();

            obj.Nome = txb_Nome.Text;
            if (fuFoto.PostedFile.FileName != "")
            {
                obj.Foto = DateTime.Now.Millisecond.ToString() + fuFoto.PostedFile.FileName;
                string img = caminho + obj.Foto;
                fuFoto.PostedFile.SaveAs(img);
            }


            try
            {
                if (btn_Salvar.Text == "Inserir")
                {
                    dalA.Inserir(obj);
                    msg = "<script> ShowMsg('Sucesso!!', 'O código gerado foi: " + obj.Id.ToString() + "');</script>";
                }
                else
                {
                    //alterar

                    obj.Id = Convert.ToInt32(txb_Id.Text);

                    //verificar se existe foto, se existe primeiro deleta e faz a alteração
                    ModeloAutor uold = dalA.GetRegistro(obj.Id);
                    if (uold.Foto != "")
                    {
                        File.Delete(caminho + uold.Foto);
                    }

                    dalA.Alterar(obj);
                    msg = "<script> ShowMsg('Sucesso!!', 'Registro alterado corretamente!!!');</script>";
                }

                //Response.Write(msg);
                PlaceHolder1.Controls.Add(new LiteralControl(msg));
                this.LimparCampos();
                AtualizaGrid();
            }
            catch (Exception erro)
            {

                msg = "<script> ShowMsg('Erro Inesperado!!', 'Erro: " + erro.Message.ToString() + "');</script>";
                PlaceHolder1.Controls.Add(new LiteralControl(msg));
            }
        }
        protected void btn_Cancelar_Click1(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        protected void gv_Dados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string caminho = Server.MapPath(@"IMAGENS/AUTORES/");
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);
            DALAutor dalA = new DALAutor();
            //verificar se existe foto para deletar
            ModeloAutor uold = dalA.GetRegistro(cod);
            if (uold.Foto != "")
            {
                File.Delete(caminho + uold.Foto);
            }
            //delete from database
            dalA.Excluir(cod);

            this.LimparCampos();
            AtualizaGrid();
        }

        protected void gv_Dados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gv_Dados.SelectedIndex;
            int cod = Convert.ToInt32(gv_Dados.Rows[index].Cells[0].Text);

            DALAutor dalA = new DALAutor();
            ModeloAutor aut = dalA.GetRegistro(cod);

            try
            {
                txb_Id.Text = aut.Id.ToString();
                txb_Nome.Text = aut.Nome;

                btn_Salvar.Text = "Alterar";
            }
            catch
            {

            }
        }
    }
}