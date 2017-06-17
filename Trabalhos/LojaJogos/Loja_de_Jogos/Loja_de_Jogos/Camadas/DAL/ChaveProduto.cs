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
        }

    }// fim class DAL ChaveProduto
}
