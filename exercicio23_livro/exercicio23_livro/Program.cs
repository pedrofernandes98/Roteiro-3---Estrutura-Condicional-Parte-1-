using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio23_livro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, meses;
            double salario_atual, novo_salario, ferias, decimo_terceiro;

            do
            {
                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("1 - Novo Salário\n2 - Férias\n3 - Décimo Terceiro\n4 - Sair");
                Console.WriteLine("\nDigite a opção desejada");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != 4)
                {
                    switch (opcao)
                    {
                        case 1:

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            if (salario_atual <= 210)
                            {
                                novo_salario = salario_atual * 1.15;
                            }
                            else if (salario_atual <= 600)
                            {
                                novo_salario = salario_atual * 1.1;
                            }
                            else
                            {
                                novo_salario = salario_atual * 1.05;
                            }

                            Console.WriteLine("O novo salário do funcionário é de R$" + novo_salario);

                            break;

                        case 2:

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            ferias = salario_atual + (salario_atual / 3);

                            Console.WriteLine("O valor das férias dos funcionários é de R$" + ferias);

                            break;

                        case 3:

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o número de meses de trabalho na empresa (máximo 12):");
                            meses = int.Parse(Console.ReadLine());

                            decimo_terceiro = (salario_atual * meses) / 12.0;

                            Console.WriteLine("O valor do décimo terceiro do funcionário é de R$" + decimo_terceiro);

                            break;

                        default:

                            Console.WriteLine("Opção Inválida! Digite uma opção válida.");

                            break;


                    }
                }

            } while (opcao != 4);

            Console.ReadKey();
        }
    }
}
