using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// pacote adicionado
using System.IO;

namespace Loja_de_Jogos.Relatorio
{
    public class funRel
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\Relatorios";
            if (!Directory.Exists(folder))
            {
                // cria o diretorio caso nao exista
                Directory.CreateDirectory(folder);
            }
            return folder;
        }
    }
}
