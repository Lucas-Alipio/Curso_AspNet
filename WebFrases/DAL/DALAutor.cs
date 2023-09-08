using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFrases.MODELO;

namespace WebFrases.DAL
{
    public class DALAutor
    {
        private System.Configuration.ConnectionStringSettings connString;

        public DALAutor()
        {
            //capturar string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
        }

        public void Inserir(ModeloAutor obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "INSERT INTO autores (nome, foto) VALUES (@nome, @foto);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("foto", obj.Foto);

                connection.Open();
                obj.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Alterar(ModeloAutor obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "UPDATE autores SET nome = @nome, foto = @foto where id = @Id;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("foto", obj.Foto);
                cmd.Parameters.AddWithValue("Id", obj.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Excluir(int id)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "DELETE from autores where id = @Id;";
                cmd.Parameters.AddWithValue("Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from autores", connString.ConnectionString);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public DataTable Localizar(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from autores where nome like '%" + valor + "%'", connString.ConnectionString);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ModeloAutor GetRegistro(int id)
        {
            ModeloAutor obj = new ModeloAutor();
            SqlConnection connection = new SqlConnection(connString.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "SELECT * FROM autores where id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Nome = Convert.ToString(registro["nome"]);
                    obj.Foto = Convert.ToString(registro["foto"]);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            connection.Close();
            return obj;
        }
    }
}