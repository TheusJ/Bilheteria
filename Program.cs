using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    internal class Program : Bilheteria
    {
        static void Main(string[] args)
        {
            Bilheteria Bilhe = new Bilheteria();
            Pagamentos Pag = new Pagamentos();
            

            Console.WriteLine("***** SETORES *****");
            
            Console.WriteLine("[1] Arquibancada Geral\n[2] Setor Sociais\n[3] Setor Frontal\n[4] Setor Placar\n[5] Exit");
            Pag.setores = Convert.ToInt32(Console.ReadLine());

            while (Pag.setores <= 5)
            {
                if (Pag.setores == 1)
                {
                    Console.WriteLine("QUANTIDADE DE INGRESSOS: ");
                    Pag.quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("ESCOLHA A FORMA DE PAGAMENTO");
                    Console.WriteLine();
                    Console.WriteLine("[1] Dinheiro\n[2] Cartão de Crédito");
                    Pag.opPagamento = Convert.ToInt32(Console.ReadLine());
                    if (Pag.opPagamento == 1)
                    {
                        Pag.Paga();
                        Console.WriteLine("[1] Arquibancada Geral\n[2] Setor Sociais\n[3] Setor Frontal\n[4] Setor Placar\n[5] Exit");
                        Pag.setores = Convert.ToInt32(Console.ReadLine());
                    }else if(Pag.opPagamento == 2)
                    {
                        Pag.PagaCred();
                        Console.WriteLine("[1] Arquibancada Geral\n[2] Setor Sociais\n[3] Setor Frontal\n[4] Setor Placar\n[5] Exit");
                        Pag.setores = Convert.ToInt32(Console.ReadLine());
                    }

                }
            }

        }
    }
}
