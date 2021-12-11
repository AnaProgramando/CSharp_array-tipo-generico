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
            // int numTeste = 15

            // ----------------------------------------------------------------------------------------------

            //int numTeste = 15;
            //int numTeste_2 = 28;
            //int numTeste_3 = 35;
            //int numTeste_4 = 50

            // Não é possível calcular a média das números de teste (numTeste) com o laço de repetição como o exemplo abaixo, pois não podemos acessar uma variável tentando juntá-la como uma string até completar o que seria o nome da variável dessa forma. O compilador precisa conhecer a variável, e a forma como as posições das variáveis foram apontadas não funciona.

            // for(int indice = 1; indice <= 5; indice++)
            // {
            //     media += numTeste[indice];
            // }

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_ARRAY de inteiros com 5 posições - De 0 a 4_");

            // Diferente dos inteiros, o array não é um tipo de valor, mas sim um tipo de referência

            // Manipulando vários dados e valores que compartilham o mesmo significado e possuem o mesmo contexto

            // Criado um objeto de array na memória do computador "new int[5]", tendo uma referência para o objeto a partir da variável "numTeste"

            // Guardando valores em posições específicas que estão indexadas na variável
            //  int[] para representar os números inteiros nas posições com acesso por meio de índices
            // Não é possível usar a variável numTeste sem que ela receba um valor, e numTeste não é um número inteiro, mas um conjunto
            // new int[] para atribuição de valores
            // int[5] informando ao compilador sobre a criação da variável que irá suportar diversos valores do tipo inteiro, no caso são cinco numTeste's, ou seja, cinco valores para colocar no pedaço de memória criado
            int[] numTeste = new int[5];

            // Os colchetes especificam os índices atribuindos para numTeste

            // Não é possível começar direto com [1], o índice fica fora dos limites da matriz, pois toda string começa a partir do índice 0 em C#, e essa característica se repete nos arrays. Exemplo:
            // texto
            // 01234
            // O índice "t" é 0, índice "e" o 1, e assim por diante

            numTeste[0]= 15;
            numTeste[1]= 28;
            numTeste[2]= 35;
            numTeste[3]= 50;
            numTeste[4]= 55;
            

            Console.WriteLine("Número informado no índice 0: " + numTeste[0]);
            Console.WriteLine("Número informado no índice 1: " + numTeste[1]);
            Console.WriteLine("Número informado no índice 2: " + numTeste[2]);
            Console.WriteLine("Número informado no índice 3: " + numTeste[3]);
            Console.WriteLine("Número informado no índice 4: " + numTeste[4]);

            Console.WriteLine("");
            Console.WriteLine("Aperte o Enter para continuar >>");

            Console.ReadLine();

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_Manipulação de ARRAY de inteiros com 4 posições - De 0 a 3_");

            // Criado um objeto de array na memória do computador "new int[5]", tendo uma referência para o objeto a partir da variável "Numtestes"

            int[] NumtesteDois = new int[5];
            NumtesteDois[0] = 91;
            NumtesteDois[1] = 81;
            NumtesteDois[2] = 71;

            // O compilador não aponta erro pela linha que atribui o valor na posição 3 do array estar comentada, pois não há verificação se os índices foram respeitados, ou seja, se há valor em todas as posições
            // O programa não irá imprimir "61", mas sim o "0", pois 0 é o valor padrão do inteiro
            // Numtestes[3] = 61;

            Console.WriteLine("Número informado no índice 0 de teste: " + NumtesteDois[0]);
            Console.WriteLine("Número informado no índice 1 de teste: " + NumtesteDois[1]);

            // Acessando a posição [2], guardando em uma variável para realizar a manipulação, não apenas mostrando na tela

            // int não é um tipo de referência como o Array, mas sim um tipo de valor
            // Aqui NumtestesNoIndice2 recebe um valor do array, acessa a posição 2, pega nela o valor 22 e atribui (copia) para a variável
            // Tipo_da_variavel nome_da_variavel = recebendo_o_array[acessando_o_valor_na_posição_2]
            int NumtestesNoIndice2 = NumtesteDois[2];
            
            Console.WriteLine("Número informado no índice 2 guardado em uma variável: " + NumtestesNoIndice2);

            int NumtestesNoIndice3 = NumtesteDois[3];
            Console.WriteLine("Número informado no índice 3, mas com a linha que atribui um valor na posição 3 do array comentada: " + NumtestesNoIndice3);

            Console.WriteLine("");
            Console.WriteLine("Aperte o Enter para continuar >>");

            Console.ReadLine();

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_Referência para o objeto de array a partir da variável outroArray_");

            // Criado um objeto de array na memória do computador "new int[5]", tendo uma referência para o objeto a partir da variável "outroArray"

            // Criando um novo array para acessar a posição [1] Numtestes
            int[] outroArray = NumtesteDois;
            Console.WriteLine("Número informado no índice 1 de teste a partir de um novo array: " + outroArray[1]);

            Console.WriteLine("");
            Console.WriteLine("Aperte o Enter para continuar >>");

            Console.ReadLine();

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_Teste da variável recebendo uma referência nula_");

            // Variável NumtesteTres recebendo uma referência nula

            // Com NumtesteTres recebendo uma referência nula, não é possível saber em que lugar da memória os valores (110, 111 e 112) estarão guardados e não haverá um lugar para acessar os índices
            // Ao executar o programa aparece a mensagem: System.NullReferenceException: 'Referência de objeto não definida para uma instância de um objeto.'
            int[] NumtesteTres = null;

            // Para fazer a aplicação executar é necessário fazer com que a variável NumtesteTres receba uma referência de um novo array de inteiros
            NumtesteTres = new int[5];

            NumtesteTres[0] = 110;
            NumtesteTres[1] = 111;
            NumtesteTres[2] = 112;

            Console.WriteLine("Número informado no índice 0: " + NumtesteTres[0]);
            Console.WriteLine("Número informado no índice 1: " + NumtesteTres[1]);
            Console.WriteLine("Número informado no índice 2: " + NumtesteTres[2]);

            Console.WriteLine("");
            Console.WriteLine("Aperte o Enter para continuar >>");

            Console.ReadLine();

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_ARRAY de Boleanos_");

            // Tipo_da_variavel (bool[]) nome_da_variavel (arrayDeBoleanos) = criando_array_na_memória_do_computador (new) tipo (bool) trabalhando_com_quantidade_de_boleanos ([3])
            bool[] arrayDeBoleanos = new bool[3];

            arrayDeBoleanos[0] = true;
            arrayDeBoleanos[1] = false;
            arrayDeBoleanos[2] = false;

            Console.WriteLine("Retorno informado no índice 0: " + arrayDeBoleanos[0]);
            Console.WriteLine("Retorno informado no índice 1: " + arrayDeBoleanos[1]);
            Console.WriteLine("Retorno informado no índice 2: " + arrayDeBoleanos[2]);

            Console.WriteLine("");
            Console.WriteLine("Aperte o Enter para continuar >>");

            Console.ReadLine();

            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("_ARRAY - Testes de acessos por meio de índices");

            // Índice é uma expressão que retorna um número inteiro

            int[] NumtesteIndice = new int[4];

            NumtesteIndice[0] = 200;
            NumtesteIndice[1] = 201;
            NumtesteIndice[2] = 202;
            NumtesteIndice[3] = 203;

            Console.WriteLine("Retorno com array recebendo o índice 0: " + NumtesteIndice[0]);

            int NumtesteIndiceNoIndiceUm = NumtesteIndice[1];
            Console.WriteLine("Retorno guardado em uma variável recebendo o índice 1 no NumtesteIndice: " + NumtesteIndiceNoIndiceUm);

            int indiceTesteDois = 2;
            Console.WriteLine("Retorno guardado em outra variável recebendo 2 no indiceTesteDois: " + NumtesteIndice[indiceTesteDois]);

            int indiceTesteTres = NumtesteIndice[2 + 1];
            Console.WriteLine("Retorno guardado em outra variável recebendo a soma de 2 + 1 no indiceTesteTres: " + indiceTesteTres);

            

            Console.ReadLine();
        }
    }
}