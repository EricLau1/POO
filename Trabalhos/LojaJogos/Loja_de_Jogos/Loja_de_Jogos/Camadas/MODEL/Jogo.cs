using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.MODEL
{
   public class Jogo
    {
        public int id { get; set; }
        public int idGenero { get; set; }
        public string nome { get; set; }
        public string  desenvolvedora { get; set; }
        public string distribuidora { get; set; }
        public float valor { get; set; }
        public string descricao { get; set; }
    }
}
