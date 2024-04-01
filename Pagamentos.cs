using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    class Pagamentos : Bilheteria
    {
        public double dinheiro = 100.30;
        public double cartaoCredito = 500.25;
        public int opPagamento;
        private double valor;
        public string simOuNao;

        public void Paga()
        {
            if(this.dinheiro >= valor)
            {
                
                valor = this.quantidade * this.geral;
                Console.WriteLine($"O valor é: {valor}");

                Console.WriteLine("Deseja confirmar o pagamento?");
                simOuNao = Console.ReadLine();
                if(simOuNao == "sim")
                {
                    if(this.dinheiro >= valor)
                    {
                        Console.WriteLine("Pagamento concluido");
                        Console.WriteLine();
                        this.dinheiro = this.quantidade - this.geral;
                        Console.WriteLine($"Saldo Atual: R$ {this.dinheiro}\n");
                    }

                    else
                    {
                        Console.WriteLine("Dinheiro insuficiente\n");
                    }
                }



            }
            
            
            
            
        }
        public void PagaCred()
        {
            if (this.cartaoCredito >= valor)
            {
                cartaoCredito = cartaoCredito - valor;
                valor = this.quantidade * this.geral;
                Console.WriteLine($"O valor é: {valor}\n");
                Console.WriteLine("Deseja confirmar o pagamento?");
                simOuNao = Console.ReadLine();
                if (simOuNao == "sim")
                {
                    if (this.cartaoCredito >= valor)
                    {
                        Console.WriteLine("Pagamento concluido");
                        Console.WriteLine();
                        this.cartaoCredito = this.quantidade - this.geral;
                        Console.WriteLine($"Saldo Atual: R$ {this.cartaoCredito}\n");
                    }
                    else
                    {
                        Console.WriteLine("Saldo Insuficiente\n");
                    }
                }

            }
            
        }
        
    }
    
}
