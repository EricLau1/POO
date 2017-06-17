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
                while (reader.Read())
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

        public void Insert(MODEL.Jogo jogo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Jogo values ";
            sql += "(@idGenero, @nome, @desenvolvedora, @distribuidora, @valor, @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idGenero", jogo.idGenero);
            cmd.Parameters.AddWithValue("@nome", jogo.nome);
            cmd.Parameters.AddWithValue("@desenvolvedora", jogo.desenvolvedora);
            cmd.Parameters.AddWithValue("@distribuidora", jogo.distribuidora);
            cmd.Parameters.AddWithValue("@valor", jogo.valor);
            cmd.Parameters.AddWithValue("@descricao", jogo.descricao);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro nessa bagaça!!!");
            }
            finally
            {
                conexao.Close();
            }
        }//FIM do metodo INSERT

        public void Delete(MODEL.Jogo jogo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Jogo where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", jogo.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro nessa bagaça!!!");
            }
            finally
            {
                conexao.Close();
            }
        }//FIM do metodo delete

        public void Update(MODEL.Jogo jogo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "update Jogo set idGenero=@idGenero, ";
            sql += "nome=@nome, desenvolvedora=@desenvolvedora, distribuidora=@distribuidora, valor=@valor, descricao=@descricao ";
            sql += " where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idGenero", jogo.idGenero);
            cmd.Parameters.AddWithValue("@nome", jogo.nome);
            cmd.Parameters.AddWithValue("@desenvolvedora", jogo.desenvolvedora);
            cmd.Parameters.AddWithValue("@distribuidora", jogo.distribuidora);
            cmd.Parameters.AddWithValue("@valor", jogo.valor);
            cmd.Parameters.AddWithValue("@descricao", jogo.descricao);
            cmd.Parameters.AddWithValue("@id", jogo.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro nessa bagaça!!!");
            }
            finally
            {
                conexao.Close();
            }
        }//FIM do metodo update

    }
}
