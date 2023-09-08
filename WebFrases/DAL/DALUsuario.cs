using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFrases.MODELO;

namespace WebFrases.DAL
{
    public class DALUsuario
    {
        private System.Configuration.ConnectionStringSettings connString;

        public DALUsuario()
        {
            //capturar string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
        }

        public void Inserir(ModeloUsuario obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("email", obj.Email);
                cmd.Parameters.AddWithValue("senha", obj.Senha);

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

        public void Alterar(ModeloUsuario obj)
        {
            //cria objeto de conexão
            SqlConnection connection = new SqlConnection(connString.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                //configurando comandos para inserir dados no banco de dados
                cmd.CommandText = "UPDATE usuarios SET nome = @nome, email = @email, senha = @senha where id = @Id;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("email", obj.Email);
                cmd.Parameters.AddWithValue("senha", obj.Senha);
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
                cmd.CommandText = "DELETE from usuarios where id = @Id;";
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from usuarios", connString.ConnectionString);
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from usuarios where nome like '%" + valor + "%'", connString.ConnectionString);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public ModeloUsuario GetRegistro(int id)
        {
            ModeloUsuario obj = new ModeloUsuario();
            SqlConnection connection = new SqlConnection(connString.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "SELECT * FROM usuarios where id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Nome = Convert.ToString(registro["nome"]);
                    obj.Email = Convert.ToString(registro["email"]);
                    obj.Senha = Convert.ToString(registro["senha"]);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            connection.Close();
            return obj;
        }

        public ModeloUsuario GetRegistro(String email)
        {
            ModeloUsuario obj = new ModeloUsuario();
            SqlConnection connection = new SqlConnection(connString.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "SELECT * FROM usuarios where email = @Email";
                cmd.Parameters.AddWithValue("@Email", email);
                connection.Open();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Nome = Convert.ToString(registro["nome"]);
                    obj.Email = Convert.ToString(registro["email"]);
                    obj.Senha = Convert.ToString(registro["senha"]);
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