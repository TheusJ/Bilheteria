using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    internal class Bilheteria
    {
        
        // ATRIBUTOS
        public int disponiveis, quantidade, setores;
        protected double geral = 25, sociais = 150, frontal = 45, placar = 30;

        // METODOS


        public double obter()
        {
            double obterValor = quantidade;
            return obter();
        }
        public void Pagou()
        {
            double valor = quantidade * geral;

            Console.WriteLine($"O valor é: R$ {valor}");
            
        }



        // CONSTRUTOR
        
    }
}
