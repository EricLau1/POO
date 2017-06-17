using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loja_de_Jogos.Camadas.MODEL
{
   public class ChaveProduto
    {
        public int codigo { get; set; }
        public int idJogo { get; set; }
        public string chave { get; set; }
        public char status { get; set; }
    }
}
