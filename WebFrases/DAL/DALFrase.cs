using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFrases.MODELO;

namespace WebFrases.DAL
{
    public class DALFrase
    {
        private System.Configuration.ConnectionStringSettings connString;

        public DALFrase()
        {
            //capturar string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
        }

        public void Inserir(ModeloFrase obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "INSERT INTO frases (frase, autor, categoria) VALUES (@frase, @autor, @categoria);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("frase", obj.Texto);
                cmd.Parameters.AddWithValue("autor", obj.Autor);
                cmd.Parameters.AddWithValue("categoria", obj.Categoria);

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

        public void Alterar(ModeloFrase obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "UPDATE frases SET frase = @frase, autor = @autor, categoria=@categoria where id = @Id;";
                cmd.Parameters.AddWithValue("frase", obj.Texto);
                cmd.Parameters.AddWithValue("autor", obj.Autor);
                cmd.Parameters.AddWithValue("categoria", obj.Categoria);
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
                cmd.CommandText = "DELETE from frases where id = @Id;";
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
                String query = "SELECT f.id, f.frase, f.autor AS autorId, f.categoria AS categoriaId, " +
                    "a.nome AS nomeAutor, c.categoria AS nomeCategoria " +
                    "FROM frases f  " +
                    "INNER JOIN autores a ON f.autor = a.id " +
                    "INNER JOIN categorias c ON f.categoria = c.id";

                SqlDataAdapter da = new SqlDataAdapter(query , connString.ConnectionString);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from frases where frase like '%" + valor + "%'", connString.ConnectionString);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ModeloFrase GetRegistro(int id)
        {
            ModeloFrase obj = new ModeloFrase();
            SqlConnection connection = new SqlConnection(connString.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "SELECT * FROM frases where id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Texto = Convert.ToString(registro["frase"]);
                    obj.Autor = Convert.ToInt32(registro["autor"]);
                    obj.Categoria = Convert.ToInt32(registro["categoria"]);
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