using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.BLL
{
   public class Genero
    {
        public List<MODEL.Genero> Select()
        {
            DAL.Genero genero = new DAL.Genero();
            return genero.Select();
        }

        public void Insert(MODEL.Genero genero)
        {
            DAL.Genero dalGenero = new DAL.Genero();
            dalGenero.Insert(genero);
        }

        public void Update(MODEL.Genero genero)
        {
            DAL.Genero dalGenero = new DAL.Genero();
            dalGenero.Update(genero);
        }

        public void Delete(MODEL.Genero genero)
        {
            DAL.Genero dalGenero = new DAL.Genero();
            dalGenero.Delete(genero);
        }

    }
}
