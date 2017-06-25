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
    public class Compra
    {
        private string strCon = Conexao.getConexao();
        private int count;

        public List<MODEL.Compra> Select()
        {
            count = 0;
            List<MODEL.Compra> lstCompra = new List<MODEL.Compra>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra order by idUser;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Compra compra = new MODEL.Compra();
                    compra.horaCompra = Convert.ToDateTime(reader["horaCompra"].ToString());
                    compra.idUser = Convert.ToInt32(reader["idUser"]);
                    compra.idJogo = Convert.ToInt32(reader["idJogo"]);
                    lstCompra.Add(compra);
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
            return lstCompra;
        }// fim do metodo Select

        public int SelectVendaByUser(int id)
        {
            int x = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra where idUser=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    x++;
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
            return x;
        }

        public int getVendas()
        {
            count = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra order by idUser;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    count++;
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
            return count;
        } // fim metodo getVendas

        // procurando usuario pelo id
        public bool DetectedUser(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra order by idUser;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    int x = Convert.ToInt32(reader["idUser"]);
                    if(x == id)
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
        }// fim do Metodos DetectedUser

        // procurando Jogo pelo id
        public bool DetectedGame(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra order by idJogo;";
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

        public void TesteInnerJoin()
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select Usuario.nome, Jogo.nome, Compra.horaCompra from Compra ";
            sql += "inner join Usuario on Compra.idUser=Usuario.id ";
            sql += "inner join Jogo on Compra.idJogo=Jogo.id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Compra compra = new MODEL.Compra();
                    compra.horaCompra = Convert.ToDateTime(reader["horaCompra"].ToString());
                    compra.idUser = Convert.ToInt32(reader["idUser"]);
                    compra.idJogo = Convert.ToInt32(reader["idJogo"]);
                }
            }
            catch
            {
                Console.WriteLine("SELECT ERROR!");
            }
            finally
            {
                conexao.Close();
            }
        }// fim do metodo

        public Single getValorMax()
        {

            Single soma = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra order by idJogo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            int x;
            Jogo jogo = new Jogo();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    x = Convert.ToInt32(reader["idJogo"]);
                    soma += Convert.ToSingle(jogo.BuscaValor(x));
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
            return soma;
        }

        public void Insert(MODEL.Compra compra)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Compra values ";
            sql += "(@horaCompra, @idUser, @idJogo);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@horaCompra", DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@idUser", compra.idUser);
            cmd.Parameters.AddWithValue("@idJogo", compra.idJogo);
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

        public void Delete(MODEL.Compra compra)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Compra where idJogo=@idJogo AND idUser=@idUser;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idJogo", compra.idJogo);
            cmd.Parameters.AddWithValue("@idUser", compra.idUser);
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
        } // fim metodo Delete
    }// fim Class DAL Compra
}
