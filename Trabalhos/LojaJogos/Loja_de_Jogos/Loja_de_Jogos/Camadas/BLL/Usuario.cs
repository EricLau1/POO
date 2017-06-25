using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.BLL
{
   public class Usuario
    {
        private DAL.Usuario getUser()
        {
            DAL.Usuario DalUser = new DAL.Usuario();
            return DalUser;
        }

        public int getUsuarios()
        {
            DAL.Usuario DalUser = new DAL.Usuario();
            return DalUser.getUsuarios();
        }

        public List<MODEL.Usuario> Select()
        {
            return getUser().Select();   
        }

        public string BuscaNome(int id)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            return dalUser.BuscaNome(id);
        }

        public void Insert(MODEL.Usuario user)
        {
            getUser().Insert(user);
        }
        
        public void Delete(MODEL.Usuario user)
        {
            getUser().Delete(user);
        }

        public void Update(MODEL.Usuario user)
        {
            getUser().Update(user);
        }
    }
}
