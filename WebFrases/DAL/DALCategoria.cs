using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFrases.MODELO;

namespace WebFrases.DAL
{
    public class DALCategoria
    {
        private System.Configuration.ConnectionStringSettings connString;

        public DALCategoria()
        {
            //capturar string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
        }

        public void Inserir(ModeloCategoria obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "INSERT INTO categorias (categoria) VALUES (@categoria);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("categoria", obj.Nome);

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

        public void Alterar(ModeloCategoria obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "UPDATE categorias SET categoria = @categoria where id = @Id;";
                cmd.Parameters.AddWithValue("categoria", obj.Nome);
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
                cmd.CommandText = "DELETE from categorias where id = @Id;";
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from categorias", connString.ConnectionString);
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from categorias where categoria like '%" + valor + "%'", connString.ConnectionString);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ModeloCategoria GetRegistro(int id)
        {
            ModeloCategoria obj = new ModeloCategoria();
            SqlConnection connection = new SqlConnection(connString.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "SELECT * FROM categorias where id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Nome = Convert.ToString(registro["categoria"]);
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