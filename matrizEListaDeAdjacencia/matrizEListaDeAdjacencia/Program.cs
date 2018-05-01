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
            /*
            int v1, v2;
            v1 = 32;
            v2 = 20;
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Insert(1, v1 + "," + v2);
            string val = a[1].ToString();
            string[] valresult = val.Split(',');
            a.Insert(1, valresult[0]);
            //a.Insert(1, v2);
            //string val = a[1].
            //Console.Write(a[1].ToString());
           // a.RemoveAt(1);
            Console.Write(a[1].ToString());
            Console.ReadKey(true);
            */

            // MATRIZ DE ADJACÊNCIA
            int opcaoMA;
            int quantidadeVertices;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Matriz de Adjacência \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Primeiramente, informe a quantidade de vértices do grafo: ");
            quantidadeVertices = int.Parse(Console.ReadLine());

            Console.WriteLine("\n                             - Escolha uma opção -\n");
            Console.Write("1- Visualizar a ordem do grafo\n");
            Console.Write("2- Inserir aresta entre vértices do grafo\n");
            Console.Write("3- Remover aresta entre vértices do grafo\n");
            Console.Write("4- Visualizar o grau de um vértice do grafo\n");
            Console.Write("5- Verificar se o grafo é completo\n");
            Console.Write("6- Verificar se o grafo é regular\n");
            Console.Write("7- Mostrar a Matriz de Adjacência do grafo\n");
            Console.Write("8- Mostrar a Lista de Adjacência do grafo\n");
            Console.Write("9- Visualizar a sequência de graus do grafo\n");
            Console.Write("10- Visualizar os vértices adjacentes a um vértice específico\n");
            Console.Write("11- Verificar se um vértice é isolado\n");
            Console.Write("12- Verificar se um vértice é ímpar\n");
            Console.Write("13- Verificar se um vértice é par\n");
            Console.Write("14- Verificar se dois vértices são adjacentes\n");
            Console.Write("\nDigite o número da opção escolhida: ");
            opcaoMA = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();
            //switch(opcao)
            //{
            // case 1:
            //      break;
            //}

            // LISTA DE ADJACÊNCIA

        }
    }
}
