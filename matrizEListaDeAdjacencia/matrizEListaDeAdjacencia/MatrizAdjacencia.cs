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

        private bool VerificaExistenciaVertice(int v1)
        {
            if (MA.GetLength(0) > v1) // Se o tamanho da matriz for maior ao número do vertice então ele existe
                return true;
            return false; // Só retorna false se não entrar no return true
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

        public void ShowLA()
        {
            for (int i = 0; i < MA.GetLength(0); i++) // Percorre Linhas
            {
                Console.Write(i + ": ");
                for(int j =0; j < MA.GetLength(1); j++) // Percorre colunas
                {
                    if (VerificaExistenciaAresta(i, j)) // Se houver aresta entre [i,j] então escrever j
                        Console.Write(" " + j + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
