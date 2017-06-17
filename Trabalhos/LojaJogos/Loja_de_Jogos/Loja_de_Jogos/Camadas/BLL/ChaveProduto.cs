using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.BLL
{
    public class ChaveProduto
    {
        public List<MODEL.ChaveProduto> Select()
        {
            DAL.ChaveProduto cp = new DAL.ChaveProduto();
            return cp.Select();
        }

        public void Insert(MODEL.ChaveProduto cp)
        {
            DAL.ChaveProduto dalCp = new DAL.ChaveProduto();
            dalCp.Insert(cp);
        }
    }
}
