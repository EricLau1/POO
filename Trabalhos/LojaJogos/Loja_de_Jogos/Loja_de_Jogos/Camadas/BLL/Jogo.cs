using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.BLL
{
    public class Jogo
    {
        public List<MODEL.Jogo> Select()
        {
            DAL.Jogo jogo = new DAL.Jogo();
            return jogo.Select();
        }

        public string BuscaNome(int id)
        {
            DAL.Jogo dalJogo = new DAL.Jogo();
            return dalJogo.BuscaNome(id);
        }

        public void Insert(MODEL.Jogo jogo)
        {
            DAL.Jogo dalJogo = new DAL.Jogo();
            dalJogo.Insert(jogo);
        }

        public void Update(MODEL.Jogo jogo)
        {
            DAL.Jogo dalJogo = new DAL.Jogo();
            dalJogo.Update(jogo);
        }

        public void Delete(MODEL.Jogo jogo)
        {
            DAL.Jogo dalJogo = new DAL.Jogo();
            dalJogo.Delete(jogo);
        }
    }
}
