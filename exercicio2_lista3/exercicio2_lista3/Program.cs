using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, maior = 0, menor = 0;
            int n, i = 0;

            Console.WriteLine("Digite a quantidade de números deseja digitar:");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {

                Console.WriteLine("Digite um número:");
                num = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                }

                i++;


            }
            Console.WriteLine("O maior número digitado é " + maior);
            Console.WriteLine("O menor número digitado é " + menor);
            Console.ReadKey();
        }
    }
}
