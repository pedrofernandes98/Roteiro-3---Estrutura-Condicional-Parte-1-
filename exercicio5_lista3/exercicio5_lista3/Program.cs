using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo, olhos, cabelos;
            double media_idade, altura, peso, media_peso, media_altura, soma_altura=0, soma_peso=0;
            int i = 0, continua, masc = 0, fem = 0, verdes_louros=0, idade, soma_idade=0;

            do
            {
                Console.WriteLine("\nDigite a opção desejada: \n1- Inserir os dados da pesquisa\n0- Fechar o programa ");
                continua = int.Parse(Console.ReadLine());

                if (continua != 0)
                {
                    if (continua == 1)
                    {
                        Console.WriteLine("\nDigite o sexo do entrevistado: M- Masculino ou F- Feminino");
                        sexo = char.Parse(Console.ReadLine().ToUpper());

                        if (sexo == 'M')
                        {
                            ++masc;
                        }
                        else
                        {
                            ++fem;
                        }

                        Console.WriteLine("\nDigite a cor dos olhos do entrevistado: \nA- Azuis\nV- Verdes\nC - Castanhos");
                        olhos = char.Parse(Console.ReadLine().ToUpper());

                        Console.WriteLine("\nDigite a cor dos cabelos do entrevistado: \nL- Louros\nC- Castanhos\nP- Pretos");
                        cabelos = char.Parse(Console.ReadLine().ToUpper());

                        if (olhos == 'V' && cabelos == 'L')
                        {
                            ++verdes_louros;
                        }

                        Console.WriteLine("Digite a idade do entrevistado:");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a altura do entrevistado(em metros):");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o peso do entrevistado(em kg):");
                        peso = double.Parse(Console.ReadLine());

                        soma_idade += idade;
                        soma_altura += altura;
                        soma_peso += peso;

                        ++i;

                    }
                    else
                    {
                        Console.WriteLine("Opção inválidade! Digite uma opção válida para continuar");
                    }
                }
            } while (continua != 0);


            if( i != 0)
            {
                Console.WriteLine("\nA porcentagem de pessoas do sexo feminino entrevistadas foi de " + (((double)fem / i) * 100.0) + "%");
                Console.WriteLine("\nA porcentagem de pessoas do sexo masculino entrevistadas foi de " + (((double)masc / i) * 100.0) + "%");

                Console.WriteLine("\nO número de pessoas de olhos verdes e cabelos loiros é de " + verdes_louros + " pessoas");
                media_idade = (double)soma_idade / (double)i;
                media_altura = soma_altura / i;
                media_peso = soma_peso / i;

                Console.WriteLine("\nA média de idade dos entrevistados é de " + media_idade + " anos");
                Console.WriteLine("\nA média de altura dos entrevistados é de " + media_altura + " metros");
                Console.WriteLine("\nA média de peso dos entrevistados é de " + media_peso + " kg");
            }


            Console.ReadKey();



        }
    }
}
