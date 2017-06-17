using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Loja_de_Jogos.Camadas.DAL
{
    public class Genero
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Genero> Select()
        {
            List<MODEL.Genero> lstGeneros = new List<MODEL.Genero>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Genero;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Genero genero = new MODEL.Genero();
                    genero.id = Convert.ToInt32(reader["id"]);
                    genero.genero = reader["genero"].ToString();
                    lstGeneros.Add(genero);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro nessa poha!!!");
            }
            finally
            {
                conexao.Close();
            }
            return lstGeneros;
        }//FIM metodo select

        //metodo para inserir dados
        public void Insert(MODEL.Genero genero)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Genero values (@genero);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@genero", genero.genero);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Insert ERROR!!!");
            }
            finally
            {
                conexao.Close();
            }
        }//Fim metodo Insert
        
        //Metodo para remover dados da tabela generos
        public void Delete(MODEL.Genero genero)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Genero where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", genero.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro no comando!!!");
            }
            finally
            {
                conexao.Close();
            }
        }//FIM do metodo delete

        //Metodo para editar
        public void Update(MODEL.Genero genero)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Genero set genero=@genero ";
            sql += "where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@genero", genero.genero);
            cmd.Parameters.AddWithValue("@id", genero.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro no comando!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

    }//FIM da classe genero
}
