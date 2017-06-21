﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos.Camadas.BLL
{
    public class Compra
    {
        public List<MODEL.Compra> Select()
        {
            DAL.Compra dalCompra = new DAL.Compra();
            return dalCompra.Select();
        }

        public void Insert(MODEL.Compra compra)
        {
            DAL.Compra dalCompra = new DAL.Compra();
            dalCompra.Insert(compra);
        }

        public void Delete(MODEL.Compra compra)
        {
            DAL.Compra dalCompra = new DAL.Compra();
            dalCompra.Delete(compra);
        }
    }
}
