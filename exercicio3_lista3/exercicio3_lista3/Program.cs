using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double soma = 0, desconto, valor_final;

            do
            {
                Console.WriteLine("Digite a idade do cliente (ou Digite -1 para sair):");
                idade = int.Parse(Console.ReadLine());

                if (idade != -1)
                {
                    if(idade < -1 || idade == 0)
                    {
                        Console.WriteLine("Idade Inválida! Digite uma idade válida para efetuar o cálculo");

                    }
                    else
                    {
                        desconto = idade / (2.0 * 100.0); //idade /2 *(1/100) para transformar em percentual
                        valor_final = 1000 * (1 - desconto);
                        soma += valor_final;
                    }
                    
                }
                

                

            } while(idade != -1);

            if(soma != 0)
            {
                Console.WriteLine("O total faturado pela loja foi de R$" + soma);
            }

            Console.ReadKey();

        }
    }
}
