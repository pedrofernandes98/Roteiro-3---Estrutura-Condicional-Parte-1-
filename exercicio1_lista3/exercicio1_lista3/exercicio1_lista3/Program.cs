using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Em termos gerais, o intuito do programa consiste em calcular um somatório de todos os números digitados pelo usuário e ao final mostrar a quantidade de números digitados por esse usuário, assim como mostrar o resultado final do somatório.
             Para tal, o programa solocita ao usuário o número de vezes que ele quer digitar um número para ser somado, desta forma,
             coloca esse valor como condição para a estrutura de repetição WHILE, que repete o número de vezes que for previamente determinado em sua condição executando todos os comandos presentes nele enquanto a sua condição for verdadeira e também se utiliza uma varíavel de controle para que quando atinja um determinado valor, a condição do WHILE seja falseada e a estrutura de repetição seja encerrada. De forma que, no WHILE é feito o somatório.
             Todo esse processo, é devidademente explicado nos comentários abaixo:
             */


            int num, N, i = 0, soma = 0; //inicialmente as variáveis que serão utilizadas no programa são declaradas. Em especial, as variáveis "i" e "soma" são atribuídas o valor zero a fim de evitar possíveis erros ocasionados por lixos de memória, já que as mesmas serão utilizadas tanto como contadores no caso do "i" quanto como somatório no caso da "soma" logo, caso tenham valor já previamente armazenado o resultado final pode ser afetado resultando em um erro no programa.
            Console.WriteLine("Quantos numeros deseja digitar: ");//Comando de saída solicitando ao usuário que digite o número de vezes que ele deseja fazer a soma
            N = int.Parse(Console.ReadLine());//Comando de entrada que lê e converte o valor digitado pelo usuário para um número inteiro e armazena na variável "N"
            while (i < N)//Nesta linha se inicia o comando WHILE com a condição que irá indicar se os comandos presentes nele serão ou não executados. Neste caso específico, os comando presentes no WHILE só serão executados caso a variável "i" seja menor que a variável "N". Além disso, sempre que os comandos dentro do WHILE forem executados, o programa retornará novamente a essa linha e caso a condição ainda seja verdadeira, os comandos serão novamente executados, caso a condição seja falsa, a estrutura de repetição será interrompida e o programa irá condinuar a sua execução na linha posterior a última linha do comando WHILE.
            {
                Console.WriteLine("\n Entre um valor inteiro: ");//Comando de saída que solicita o valor um valor inteiro para ser incluído no somatório
                num = int.Parse(Console.ReadLine()); //Comando de entrada que lê o valor digitado pelo usuário e o converte para um número inteiro armazenando-o na variável "num"
                soma = soma + num;//Soma o valor que já estava na variável "soma" que é a variável de somatório do programa com o valor digitado pelo usuário que está armazenado na variável "num"
                i++; //Faz o incremento da variável de controle da estrutura de repetição. Já que caso esse incremento não seja feito, a condição sempre será verdadeira e o programa entrará em loop infinito.
            }
            Console.Write("\n Foram digitados " + i + " numeros");//Comando de saída que imprime na tela o total de números digitados.
            Console.Write("\n A soma dos numeros digitados e: " + soma);//Comando de saída que imprime na tela o total do somatório calculado pela soma dos números digitados no programa
            Console.ReadKey();//Comando que permite a vizualização dos resultados do programa na tela
        }
    }
}
