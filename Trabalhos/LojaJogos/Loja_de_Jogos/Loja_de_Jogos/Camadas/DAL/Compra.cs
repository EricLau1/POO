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
        }
    }// fim Class DAL Compra
}
