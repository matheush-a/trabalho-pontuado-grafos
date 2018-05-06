using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace matrizEListaDeAdjacencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 0;
            int opcaoMA = 0;
            int quantidadeVerticesMA;
            int v1MA, v2MA;
            MatrizAdjacencia ma;

            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Console.WriteLine("1) Matriz Adjacencia");
                Console.WriteLine("2) Lista Adjacencia\n");
                Console.Write("Sua opcao: ");
                opcaoMenu = int.Parse(Console.ReadLine());
                switch (opcaoMenu)
                {
                    case 1:
                        // --- 1 MATRIZ DE ADJACÊNCIA

                        Console.WriteLine("Matriz de Adjacência \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Primeiramente, informe a quantidade de vértices do grafo: ");
                        quantidadeVerticesMA = int.Parse(Console.ReadLine());

                        ma = new MatrizAdjacencia(quantidadeVerticesMA);

                        do
                        {
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("                             - Escolha uma opção [Matriz de Adjacência] -\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("1) Visualizar a ordem do grafo\n");
                            Console.Write("2) Inserir aresta entre vértices do grafo\n");
                            Console.Write("3) Remover aresta entre vértices do grafo\n");
                            Console.Write("4) Visualizar o grau de um vértice do grafo\n");
                            Console.Write("5) Verificar se o grafo é completo\n");
                            Console.Write("6) Verificar se o grafo é regular\n");
                            Console.Write("7) Mostrar a Matriz de Adjacência do grafo\n");
                            Console.Write("8) Mostrar a Lista de Adjacência do grafo\n");
                            Console.Write("9) Visualizar a sequência de graus do grafo\n");
                            Console.Write("10) Visualizar os vértices adjacentes a um vértice específico\n");
                            Console.Write("11) Verificar se um vértice é isolado\n");
                            Console.Write("12) Verificar se um vértice é ímpar\n");
                            Console.Write("13) Verificar se um vértice é par\n");
                            Console.Write("14) Verificar se dois vértices são adjacentes\n");
                            Console.Write("\n0) Sair do Menu\n");
                            Console.Write("\nDigite o número da opção escolhida: ");
                            opcaoMA = int.Parse(Console.ReadLine());
                            Console.Clear();

                            // Menu de opções da Matriz de Adjacência
                            switch (opcaoMA)
                            {
                                case 0: // Sair do Menu
                                    Environment.Exit(0);
                                    break;
                                case 1: // Ordem ***
                                    Console.Write("1) Ver a ordem do grafo\n");
                                    Console.Write("\nA ordem do grafo = " + ma.Ordem());
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 2: // Inserir Aresta
                                    Console.Write("2) Inserir Aresta entre vértices\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2MA = int.Parse(Console.ReadLine());

                                    ma.InserirAresta(v1MA, v2MA);
                                    break;
                                case 3: // Remover Aresta
                                    Console.Write("3) Remover Aresta entre vértices\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2MA = int.Parse(Console.ReadLine());

                                    ma.RemoverAresta(v1MA, v2MA);
                                    break;
                                case 4: // Ver o grau do vértice
                                    Console.Write("4) Ver o grau de um vértice\n");
                                    Console.Write("\nInforme o número do vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());

                                    ma.Grau(v1MA);
                                    Console.Write("\nO grau do vértice " + v1MA + " = " + ma.Grau(v1MA));

                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 5: // Ver se o grafo é completo ***
                                    Console.Write("5) Verificar se o grafo é completo\n");
                                    if (ma.Completo() == true)
                                    {
                                        Console.Write("\nO grafo É completo!");
                                    }
                                    else if (ma.Completo() == false)
                                        Console.Write("\nO grafo NÃO é completo!");

                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 6: // Ver se o grafo é regular
                                    Console.Write("6) Verificar se o grafo é regular\n");
                                    if (ma.Regular() == true)
                                    {
                                        Console.Write("\nO grafo É regular!");
                                    }
                                    else if (ma.Regular() == false)
                                        Console.Write("\nO grafo NÃO é regular!");

                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 7: // Mostrar MA
                                    Console.Write("7) Impressão da Matriz de Adjacência do grafo\n\n");
                                    ma.ShowMA();

                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 8: // Mostrar LA
                                    Console.Write("8) Impressão da Lista de Adjacência do grafo\n\n");
                                    ma.ShowLA();
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 9: // Ver sequencia de graus do grafo ***
                                    Console.Write("9) Impressão de graus dos vértices do grafo\n\n");
                                    Console.Write("Sequência de graus: "); ma.SequenciaGraus();
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 10: // Ver os vertices adjacentes a um vertice especifico
                                    Console.Write("10) Impressão dos vértices adjacentes a um vértice específico\n");
                                    Console.Write("Informe o vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());
                                    ma.VerticesAdjacentes(v1MA);
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 11: // Verificar se um vertice é isolado 
                                    Console.Write("11) Verificar se um vértice é isolado\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());

                                    if (ma.Isolado(v1MA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1MA + " É isolado!");
                                    }
                                    else if (ma.Isolado(v1MA) == false)
                                        Console.Write("\nO vértice " + v1MA + " NÃO é isolado!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 12: // Verificar se um vertice é ímpar
                                    Console.Write("12) Verificar se um vértice é ímpar\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());

                                    if (ma.Impar(v1MA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1MA + " É ímpar!");
                                    }
                                    else if (ma.Impar(v1MA) == false)
                                        Console.Write("\nO vértice " + v1MA + " NÃO é ímpar!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 13: // Verificar se um vertice é par
                                    Console.Write("13) Verificar se um vértice é par\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());

                                    if (ma.Par(v1MA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1MA + " É par!");
                                    }
                                    else if (ma.Par(v1MA) == false)
                                        Console.Write("\nO vértice " + v1MA + " NÃO é par!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 14: // Verificar se dois vertices são adjacentes
                                    Console.Write("14) Verificar se dois vértices são adjacentes\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1MA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2MA = int.Parse(Console.ReadLine());
                                    if (ma.Adjacentes(v1MA, v2MA) == true)
                                    {
                                        Console.Write("\nOs vértices " + v1MA + " e " + v2MA + " SÃO adjacentes!");
                                    }
                                    else
                                        Console.Write("\nOs vértices " + v1MA + " e " + v2MA + " NÃO são adjacentes!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                            }
                        }
                        while (opcaoMA > 0 && opcaoMA < 15);
                        System.Threading.Thread.Sleep(3000);
                        break;

                    case 2:
                        // --- 2 LISTA DE ADJACÊNCIA
                        int opcaoLA;
                        int v1LA, v2LA;

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Lista de Adjacência \n");
                        Console.ForegroundColor = ConsoleColor.White;

                        ListaAdjacencia la = new ListaAdjacencia();
                        do
                        {
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("                             - Escolha uma opção [Lista de Adjacência] -\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("1) Visualizar a ordem do grafo\n");
                            Console.Write("2) Inserir vértice no grafo\n");
                            Console.Write("3) Remover vértice do grafo\n");
                            Console.Write("4) Inserir aresta entre vértices do grafo\n");
                            Console.Write("5) Remover aresta entre vértices do grafo\n");
                            Console.Write("6) Visualizar o grau de um vértice do grafo\n");
                            Console.Write("7) Verificar se o grafo é completo\n");
                            Console.Write("8) Verificar se o grafo é regular\n");
                            Console.Write("9) Mostrar a Lista de Adjacência do grafo\n");
                            Console.Write("10) Visualizar a sequência de graus do grafo\n");
                            Console.Write("11) Visualizar os vértices adjacentes a um vértice específico\n");
                            Console.Write("12) Verificar se um vértice é isolado\n");
                            Console.Write("13) Verificar se um vértice é ímpar\n");
                            Console.Write("14) Verificar se um vértice é par\n");
                            Console.Write("15) Verificar se dois vértices são adjacentes\n");
                            Console.Write("\n0) Sair do Menu\n");
                            Console.Write("\nDigite o número da opção escolhida: ");
                            opcaoLA = int.Parse(Console.ReadLine());
                            Console.Clear();

                            // Menu de opções da Lista de Adjacência
                            switch (opcaoLA)
                            {
                                case 0: // Sair do Menu
                                    Environment.Exit(0);
                                    break;
                                case 1: // Ordem ***
                                    Console.Write("1) Ver a ordem do grafo\n");
                                    Console.Write("\nA ordem do grafo = " + la.Ordem());
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 2: // Inserir Vértice
                                    Console.Write("2) Inserir Vértice no grafo\n");
                                    Console.Write("\nInforme o número do vértice a ser inserido no grafo: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    la.InserirVertice(v1LA);
                                    break;
                                case 3: // Remover Vértice
                                    Console.Write("3) Remover Vértice do grafo\n");
                                    Console.Write("\nInforme o número do vértice a ser removido do grafo: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    la.RemoverVertice(v1LA);
                                    break;
                                case 4: // Inserir Aresta
                                    Console.Write("4) Inserir Aresta entre vértices\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2LA = int.Parse(Console.ReadLine());

                                    la.InserirAresta(v1LA, v2LA);
                                    break;
                                case 5: // Remover Aresta
                                    Console.Write("5) Remover Aresta entre vértices\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2LA = int.Parse(Console.ReadLine());

                                    la.RemoverAresta(v1LA, v2LA);
                                    break;
                                case 6: // Ver o grau do vértice
                                    Console.Write("6) Ver o grau de um vértice\n");
                                    Console.Write("\nInforme o número do vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    la.Grau(v1LA);
                                    Console.Write("\nO grau do vértice " + v1LA + " = " + la.Grau(v1LA));
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 7: // Ver se o grafo é completo ***
                                    Console.Write("7) Verificar se o grafo é completo\n");
                                    if (la.Completo() == true)
                                    {
                                        Console.Write("\nO grafo É completo!");
                                    }
                                    else if (la.Completo() == false)
                                        Console.Write("\nO grafo NÃO é completo!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 8: // Ver se o grafo é regular
                                    Console.Write("8) Verificar se o grafo é regular\n");
                                    if (la.Regular() == true)
                                    {
                                        Console.Write("\nO grafo É regular!");
                                    }
                                    else if (la.Regular() == false)
                                        Console.Write("\nO grafo NÃO é regular!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 9: // Mostrar LA
                                    Console.Write("9) Impressão da Lista de Adjacência do grafo\n\n");
                                    la.ShowLA();
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 10: // Ver sequencia de graus do grafo ***
                                    Console.Write("10) Impressão de graus dos vértices do grafo\n\n");
                                    Console.Write("Sequência de graus: "); la.SequenciaGraus();
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 11: // Ver os vertices adjacentes a um vertice especifico
                                    Console.Write("11) Impressão dos vértices adjacentes a um vértice específico\n");
                                    Console.Write("Informe o vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());
                                    la.VerticesAdjacentes(v1LA);
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 12: // Verificar se um vertice é isolado 
                                    Console.Write("12) Verificar se um vértice é isolado\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    if (la.Isolado(v1LA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1LA + " É isolado!");
                                    }
                                    else if (la.Isolado(v1LA) == false)
                                        Console.Write("\nO vértice " + v1LA + " NÃO é isolado!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 13: // Verificar se um vertice é ímpar
                                    Console.Write("13) Verificar se um vértice é ímpar\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    if (la.Impar(v1LA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1LA + " É ímpar!");
                                    }
                                    else if (la.Impar(v1LA) == false)
                                        Console.Write("\nO vértice " + v1LA + " NÃO é ímpar!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 14: // Verificar se um vertice é par
                                    Console.Write("14) Verificar se um vértice é par\n");
                                    Console.Write("Informe o número do vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());

                                    if (la.Par(v1LA) == true)
                                    {
                                        Console.Write("\nO vértice " + v1LA + " É par!");
                                    }
                                    else if (la.Par(v1LA) == false)
                                        Console.Write("\nO vértice " + v1LA + " NÃO é par!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                                case 15: // Verificar se dois vertices são adjacentes
                                    Console.Write("15) Verificar se dois vértices são adjacentes\n");
                                    Console.Write("\nInforme o número do primeiro vértice: ");
                                    v1LA = int.Parse(Console.ReadLine());
                                    Console.Write("\nInforme o número do segundo vértice: ");
                                    v2LA = int.Parse(Console.ReadLine());
                                    if (la.Adjacentes(v1LA, v2LA) == true)
                                    {
                                        Console.Write("\nOs vértices " + v1LA + " e " + v2LA + " SÃO adjacentes!");
                                    }
                                    else
                                        Console.Write("\nOs vértices " + v1LA + " e " + v2LA + " NÃO são adjacentes!");
                                    System.Threading.Thread.Sleep(3000);
                                    break;
                            }

                        }
                        while (opcaoLA > 0 && opcaoLA < 16);
                        break;
                }
            } while (opcaoMenu > 0 && opcaoMenu < 3);
        }
    }
}
