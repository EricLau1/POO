using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loja_de_Jogos.Relatorio
{
   public class relCompra
    {
        public static void impRelCompra()
        {
            List<Camadas.MODEL.Compra> lstCompra = new List<Camadas.MODEL.Compra>();
            Camadas.BLL.Compra bllCompra = new Camadas.BLL.Compra();
            lstCompra = bllCompra.Select();

            string folder = funRel.diretorioPasta();
            string arquivo = folder + @"\relCompras.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta charset='utf-8'>");

                sw.WriteLine("<style>");
                sw.WriteLine("table td { padding: 20px; border: 1px solid #000;}");
                sw.WriteLine("table th { padding: 10px;}");
                sw.WriteLine("</style>");


                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                   sw.WriteLine("<h1>Relatório de Compras</h1>");
                   sw.WriteLine("<table>");
                // cabeçalho
                   sw.WriteLine("<tr>");
                   sw.WriteLine("<th> Usuário </th>");
                   sw.WriteLine("<th> Jogo </th>");
                   sw.WriteLine("<th> Valor </th>");
                   sw.WriteLine("<th> Data/hora</th>");
                sw.WriteLine("</tr>");

                int totJogos = 0;
                float soma = 0;
                Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
                Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
                foreach(Camadas.MODEL.Compra compra in lstCompra)
                {
                    
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td>" + bllUser.BuscaNome(compra.idUser) + "</td>");
                    sw.WriteLine("<td>" + bllJogo.BuscaNome(compra.idJogo) + "</td>");
                    sw.WriteLine("<td>" + bllJogo.BuscaValor(compra.idJogo) + "</td>");
                    sw.WriteLine("<td>" + compra.horaCompra + "</td>"); 
                    sw.WriteLine("</tr>");
                    totJogos++;
                    soma += float.Parse(bllJogo.BuscaValor(compra.idJogo).ToString());
                } // fim foreach

                sw.WriteLine("</table>");
                sw.WriteLine("<hr>");
                sw.WriteLine("<h5> Total de Jogos vendidos: " + totJogos + "</h5>");
                sw.WriteLine("<h5> Valor total de vendas: " + soma + "</h5>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
