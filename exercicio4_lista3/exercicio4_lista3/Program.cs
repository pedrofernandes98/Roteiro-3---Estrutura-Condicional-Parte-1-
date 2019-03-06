using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            double salario_atual, salario_novo = 0;

            do
            {
                Console.WriteLine("\nPrograma de cálculo de novos salário\n");
                Console.WriteLine("Menu de Opções: \nA- Para aumento de 8%\nB- Para aumento de 11% \nC- Para aumento fixo de R$ 450,00\nD- Sair do Programa");
                opcao = char.Parse(Console.ReadLine().ToUpper());

                if (opcao != 'D')
                {
                    
                    switch (opcao)
                    {
                        case 'A':

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            salario_novo = salario_atual * 1.08;

                            break;

                        case 'B':

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            salario_novo = salario_atual * 1.11;

                            break;

                        case 'C':

                            Console.WriteLine("Digite o salário atual do funcionário:");
                            salario_atual = double.Parse(Console.ReadLine());

                            salario_novo = salario_atual + 450;

                            break;

                        default:

                            Console.WriteLine("Opção Inválida! Digite uma opção válida para o cálculo ser efetuado.");
                            salario_novo = 0; //caso o a opção seja inválida não irá cair na condição abaixo de mostrar o novo salário
                            break;

                    }

                    if(salario_novo > 0)
                    {
                        Console.WriteLine("O novo salário do funcionário é de R$" + salario_novo);
                    }
                    

                }


            } while (opcao != 'D');

            Console.ReadKey();
        }
    }
}
