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
   public class Jogo
    {
        private string strCon = Conexao.getConexao();

        //método para mostrar os dados na tela
        public List<MODEL.Jogo> Select()
        {
            List<MODEL.Jogo> lstJogos = new List<MODEL.Jogo>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Jogo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    MODEL.Jogo jogo = new MODEL.Jogo();
                    jogo.id = int.Parse(reader["id"].ToString());
                    jogo.idGenero = Convert.ToInt32(reader["idGenero"]);
                    jogo.nome = reader["nome"].ToString();
                    jogo.desenvolvedora = reader["desenvolvedora"].ToString();
                    jogo.distribuidora = reader["distribuidora"].ToString();
                    jogo.valor = Convert.ToSingle(reader["valor"].ToString());
                    jogo.descricao = reader["descricao"].ToString();
                    lstJogos.Add(jogo);
   
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
            return lstJogos;
        }//FIM METODO SELECT
   

    }
}
