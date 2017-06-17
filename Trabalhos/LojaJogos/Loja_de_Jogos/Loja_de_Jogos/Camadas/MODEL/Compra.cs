using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.MODEL
{
    public class Compra
    {
        public DateTime horaCompra { get; set; }
        public int idUser { get; set; }
        public int idJogo { get; set; }
    }
}
