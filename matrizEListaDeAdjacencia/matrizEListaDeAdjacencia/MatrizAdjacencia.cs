using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizEListaDeAdjacencia
{
    class MatrizAdjacencia
    {
        private int[,] MA;
        private int qtVertices;

        public MatrizAdjacencia(int qtdVertices)
        {
            MA = new int[qtdVertices, qtdVertices]; // Cria matriz quadrada, com o número passado
        }

        public int Ordem()
        {
            return (this.qtVertices);
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                MA[v1, v2] = 1;
                return (true);
            }
            else
            {
                return (false);
            }

        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2) && MA[v1, v2] == 1)
            {
                MA[v1, v2] = 0;
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public int Grau(int vertice)
        {
            int grau = 0;

            for (int i = 0; i < MA.GetLength(1); i++)
            {
                if (MA[vertice, i] == 1)
                {
                    grau++;
                }
            }
            return (grau);

        }

        public bool Completo()
        {
            for (int j = 0; j < MA.GetLength(1); j++)
            { // Percorre colunas
                for (int i = 0; i < MA.GetLength(0); i++) // Percorre linha
                {
                    if (MA[j, i] != 1 && i != j) // Se, na posicição [j,i] não tiver 1 (vertice) e i diferente de j (Diagonal principal i = j), então não é completo
                        return false;
                }
            }
            return true;
        }

        public bool Regular()
        {
            int numArest;
            numArest = Grau(0);
            for (int i = 1; i < MA.GetLength(0); i++)
            {
                if (MA[i, i] != numArest)
                    return false;
            }
            return true;
        }

        public void ShowMA()
        {
            Console.WriteLine("Exibindo Matriz de Adjacencia");
            for (int i = 0; i < MA.GetLength(0); i++) // Percorre Linhas
            {
                Console.Write(i + ": ");
                for (int j = 0; j < MA.GetLength(1); j++) // Percorre colunas
                {
                    if (VerificaExistenciaAresta(i, j)) // Se houver aresta entre [i,j] então escrever 1
                        Console.Write("1 ");
                    else // Senão escrever 0
                        Console.Write("0 ");
                }
                Console.Write("\n");
            }
        }

        public void ShowLA()
        {
            Console.WriteLine("Exibindo Lista de Adjacencia");
            for (int i = 0; i < MA.GetLength(0); i++) // Percorre Linhas
            {
                Console.Write(i + ": ");
                for (int j = 0; j < MA.GetLength(1); j++) // Percorre colunas
                {
                    if (VerificaExistenciaAresta(i, j))
                    {// Se houver aresta entre [i,j] então escrever j
                        Console.Write(" " + j);
                        if (j < (MA.GetLength(1) - 1))
                            Console.Write(", ");
                    }
                }
                Console.Write("\n");
            }
        }

        public void SequenciaGraus()
        {
            int[] graus = new int[MA.GetLength(0)];
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                graus[i] = Grau(i);
            }
            Array.Sort(graus);
            foreach (int i in graus)
            {
                Console.Write(i + ",");
            }
        }

        public void VerticesAdjacentes(int vertice)
        {
            Console.Write("Adjacentes a " + vertice + ": ");
            for (int i = 0; i < MA.GetLength(0); i++)
                if (MA[vertice, i] == 1)
                    Console.Write(i + ",");
        }

        public bool Isolado(int vertice)
        {
            if (VerificaExistenciaVertice(vertice) && Grau(vertice) == 0)
            {
                return (true);
            }
            return (false);
        }

        public bool Impar(int vertice)
        {
            if (VerificaExistenciaVertice(vertice) && Grau(vertice) % 2 != 0)
            {
                return (true);
            }
            return (false);
        }

        public bool Par(int vertice)
        {
            if (VerificaExistenciaVertice(vertice) && Grau(vertice) % 2 == 0)
            {
                return (true);
            }
            return (false);
        }

        public bool Adjacentes(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                if (MA[v1, v2] == 1 || MA[v2, v1] == 1) // Se na posição [v1,v2] ou [v2,v1] existir vertice return true
                    return true;
                return false;
            }
            throw new ArgumentException();
        }

        private bool VerificaExistenciaVertice(int v1)
        {
            if (MA.GetLength(0) > v1) // Se o tamanho da matriz for maior ao número do vertice então ele existe
                return true;
            return false; // Só retorna false se não entrar no return true
        }

        private bool VerificaExistenciaAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2)) // Primeiramente verifica se os vertices passados existem
            {
                if (MA[v1, v2] == 1) // Então verifica na posição [v1,v2] se for 1 é porque há aresta
                    return true;
                return false;
            }
            throw new ArgumentException();
        }

    }
}
