using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.BancoVirtual.Modelos;
using CSharp.BancoVirtual.Modelos.Funcionarios;
using Humanizer;

namespace CSharp.BancoVirtual.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------------------------------------

            // Criação de variável:
            // Declaração de variável = Atribuição de valor
            // int idade = 15

            // ----------------------------------------------------------------------------------------------

            //int idade = 15;
            //int idade_2 = 28;
            //int idade_3 = 35;
            //int idade_4 = 50

            // Não é possível calcular a média das idade com o laço de repetição como o exemplo abaixo, pois não podemos acessar uma variável tentando juntá-la como uma string até completar o que seria o nome da variável dessa forma. O compilador precisa conhecer a variável, e a forma como as posições das variáveis foram apontadas não funciona.

            // for(int indice = 1; indice <= 5; indice++)
            // {
            //     media += idade[indice];
            // }

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_ARRAY de inteiros com 5 posições_");

            // Manipulando vários dados e valores que compartilham o mesmo significado e possuem o mesmo contexto

            // Guardando valores em posições específicas que estão indexadas na variável
            //  int[] para representar os números inteiros nas posições com acesso por meio de índices
            // Não é possível usar a variável idades sem que ela receba um valor, e idades não é um número inteiro, mas um conjunto
            // new int[] para atribuição de valores
            // int[5] informando ao compilador sobre a criação da variável que irá suportar diversos valores do tipo inteiro, no caso são cinco idades, ou seja, cinco valores para colocar no pedaço de memória criado
            int[] idades = new int[5];

            // Os colchetes especificam os índices atribuindos para as idades

            // Não é possível começar direto com [1], o índice fica fora dos limites da matriz, pois toda string começa a partir do índice 0 em C#, e essa característica se repete nos arrays. Exemplo:
                                                            // texto
                                                            // 01234
            // O índice "t" é 0, índice "e" o 1, e assim por diante

            idades[0]= 15;
            idades[1]= 28;
            idades[2]= 35;
            idades[3]= 50;
            idades[4]= 55;

            Console.WriteLine("Idade informada no índice 0: " + idades[0]);
            Console.WriteLine("Idade informada no índice 1: " + idades[1]);
            Console.WriteLine("Idade informada no índice 2: " + idades[2]);
            Console.WriteLine("Idade informada no índice 3: " + idades[3]);
            Console.WriteLine("Idade informada no índice 4: " + idades[4]);

            Console.ReadLine();
        }
    }
}