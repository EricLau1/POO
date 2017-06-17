using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pacotes adicionados
using System.Data;
using System.Data.SqlClient;

namespace Loja_de_Jogos.Camadas.DAL
{
   public class Usuario
    {
        private string strCon = Conexao.getConexao();

        //Metodo para vizualizar os dados dos Usuarios
        public List<MODEL.Usuario> Select()
        {
            List<MODEL.Usuario> lstUsers = new List<MODEL.Usuario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Usuario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Usuario usuario = new MODEL.Usuario();
                    usuario.id = Convert.ToInt32(reader["id"].ToString());
                    usuario.nome = reader["nome"].ToString();
                    usuario.username = reader["username"].ToString();
                    usuario.email = reader["email"].ToString();
                    usuario.senha = reader["senha"].ToString();
                    lstUsers.Add(usuario);  
                }
                
            }
            catch
            {
                Console.WriteLine("Select from ERROR!");
            }
            finally
            {
                conexao.Close();
            }

            return lstUsers;
        }// fim do Metodo Select

        //Metodo para Inserir Dados
        public void Insert(MODEL.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Usuario values ";
            sql += "(@nome, @username, @email, @senha);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", usuario.nome);
            cmd.Parameters.AddWithValue("@username", usuario.username);
            cmd.Parameters.AddWithValue("@email", usuario.email);
            cmd.Parameters.AddWithValue("@senha", usuario.senha);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Insert ERROR!");
            }
            finally
            {
                conexao.Close();
            }
        }// fim metodo Insert

        // Metodo para deletar um registro de Usuario
        public void Delete(MODEL.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Usuario where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", usuario.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Delete ERROR!");
            }
            finally
            {
                conexao.Close();
            }
        }// fim metodo Delete

        public void Update(MODEL.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Usuario set nome=@nome, username=@username, email=@email, senha=@senha ";
            sql += "where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", usuario.nome);
            cmd.Parameters.AddWithValue("@username", usuario.username);
            cmd.Parameters.AddWithValue("@email", usuario.email);
            cmd.Parameters.AddWithValue("@senha", usuario.senha);
            cmd.Parameters.AddWithValue("@id", usuario.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Update ERROR!");
            }
            finally
            {
                conexao.Close();
            }
        }// fim do Metodo Update

    }//fim da Classe DAL Usuarios
}
