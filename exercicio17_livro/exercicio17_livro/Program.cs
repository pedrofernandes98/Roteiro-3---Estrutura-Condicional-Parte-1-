using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio17_livro
{
    class Program
    {
        static void Main(string[] args)
        {
            int canal, n_pessoas, total, soma4 = 0, soma5 = 0, soma7 = 0, soma12 = 0, cont=0;
            do
            {
                Console.WriteLine("\n\nDigite o número do canal assistido na casa pesquisada:\n4 - Canal 4\n5 - Canal 5\n7 - Canal 7\n12 - Canal 12\n1 - A TV estava desligada\n0 - Sair, ver os resultados da pesquisa e encerrar o programa");
                canal = int.Parse(Console.ReadLine());

                if (canal != 0)
                {
                    switch (canal)
                    {
                        case 4:

                            Console.WriteLine("Digite o número de pessoas que estavam assistindo ao canal:");
                            n_pessoas = int.Parse(Console.ReadLine());

                            soma4 += n_pessoas;
                            cont += n_pessoas;
                            break;

                        case 5:

                            Console.WriteLine("Digite o número de pessoas que estavam assistindo ao canal:");
                            n_pessoas = int.Parse(Console.ReadLine());

                            soma5 += n_pessoas;
                            cont += n_pessoas;
                            break;

                        case 7:

                            Console.WriteLine("Digite o número de pessoas que estavam assistindo ao canal:");
                            n_pessoas = int.Parse(Console.ReadLine());

                            soma7 += n_pessoas;
                            cont += n_pessoas;
                            break;

                        case 12:

                            Console.WriteLine("Digite o número de pessoas que estavam assistindo ao canal:");
                            n_pessoas = int.Parse(Console.ReadLine());

                            soma12 += n_pessoas;
                            cont += n_pessoas;
                            break;

                        case 1:

                            Console.WriteLine("A TV estava desligada logo essa casa não será computada na pesquisa");

                            break;

                        default:

                            Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar");

                            break;
                    }
                }

            } while (canal != 0);

            if(cont > 0)
            {
                Console.WriteLine("\nResultados da Pesquisa:");
                Console.WriteLine("Canal 4: " + (((double)soma4 / (double)cont) * 100.0) + "%");
                Console.WriteLine("Canal 5: " + (((double)soma5 / (double)cont) * 100.0) + "%");
                Console.WriteLine("Canal 7: " + (((double)soma7 / (double)cont) * 100.0) + "%");
                Console.WriteLine("Canal 12: " + (((double)soma12 / (double)cont) * 100.0) + "%");
            }

            Console.ReadKey();
            



        }
    }
}
