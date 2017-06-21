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

        public List<MODEL.Compra> Select()
        {
            List<MODEL.Compra> lstCompra = new List<MODEL.Compra>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compra;";
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
                    //compra.dataCompra = Convert.ToDateTime(reader["dataCompra"].ToString());
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

        public List<MODEL.Compra> SelectByUJ()
        {
            List<MODEL.Compra> lstCompra = new List<MODEL.Compra>();
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
                    lstCompra.Add(compra);
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

            return lstCompra;
        }// fim do metodo SelectByUJ

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
