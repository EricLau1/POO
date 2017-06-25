using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Classes adicionadas
using System.Data;
using System.Data.SqlClient;

namespace Loja_de_Jogos.Camadas.DAL
{
    public class ChaveProduto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.ChaveProduto> Select()
        {
            List<MODEL.ChaveProduto> lstCP = new List<MODEL.ChaveProduto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Chave_Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.ChaveProduto cp = new MODEL.ChaveProduto();
                    cp.codigo = Convert.ToInt32(reader["codigo"]);
                    cp.idJogo = Convert.ToInt32(reader["idJogo"]);
                    cp.chave = reader["chave"].ToString();
                    cp.status = Convert.ToChar(reader["status"]);
                    lstCP.Add(cp);

                }
            }
            catch
            {
                Console.WriteLine("Select ERROR!");
            }
            finally
            {
                conexao.Close();
            }
            return lstCP;
        } // fim metodo Select

        // procurando Jogo pelo id
        public bool DetectedGame(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Chave_Produto order by idJogo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    int x = Convert.ToInt32(reader["idJogo"]);
                    if (x == id)
                    {
                        return false;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Select ERROR!");
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }// fim do Metodos DetectedGame

        public void Insert(MODEL.ChaveProduto cp)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Chave_Produto values ";
            sql += "(@idJogo, @chave, @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idJogo", cp.idJogo);
            cmd.Parameters.AddWithValue("@chave", cp.chave);
            cmd.Parameters.AddWithValue("@status", cp.status);
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
        } // fim metodo Insert

        public void Update(MODEL.ChaveProduto cp)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Chave_Produto set ";
            sql += "idJogo=@idJogo, chave=@chave, status=@status ";
            sql += "where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idJogo", cp.idJogo);
            cmd.Parameters.AddWithValue("@chave", cp.chave);
            cmd.Parameters.AddWithValue("@status", cp.status);
            cmd.Parameters.AddWithValue("@codigo", cp.codigo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Insert ERROR");
            }
            finally
            {
                conexao.Close();
            }

        }// fim metodo Update

        public void Delete(MODEL.ChaveProduto cp)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from Chave_Produto ";
            sql += "where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", cp.codigo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Insert ERROR");
            }
            finally
            {
                conexao.Close();
            }

        }// fim metodo Update

    }// fim class DAL ChaveProduto
}
