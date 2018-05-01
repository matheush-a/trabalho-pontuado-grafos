using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace matrizEListaDeAdjacencia
{
    class ListaAdjacencia
    {
        private ArrayList LA;
        private string verticesLA = "";
        //private string[,] LA;

        public ListaAdjacencia()
        {
            LA = new ArrayList();
        }

        public int Ordem()
        {
            return LA.Count;
        }

        public bool InserirVertice(int vertice)
        {
            if (LA.Contains(vertice))
            {
                return false;
            }
            verticesLA += vertice + ",";
            LA.Add(vertice);
            return true;
        }

        public bool RemoverVertice(int vertice)
        {
            if (VerificaExistenciaVertice(vertice))
            {
                LA.Remove(vertice);
                return true;
            }
            throw new ArgumentException();
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                if (VerificaExistenciaAresta(v1, v2) || VerificaExistenciaAresta(v2, v1))
                    return false;

                string valorV1 = LA[v1].ToString();
                valorV1 += (v2 + ",");
                LA.Insert(v1, valorV1);

                string valorV2 = LA[v2].ToString();
                valorV2 += (v1 + ",");
                LA.Insert(v2, valorV2);

                return true;
            }
            throw new ArgumentException();
        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                if (!VerificaExistenciaAresta(v1, v2) || !VerificaExistenciaAresta(v2, v1))
                    return false;

                string valorV1 = LA[v1].ToString();
                string[] valoresV1 = valorV1.Split(',');
                valorV1 = "";
                for (int i = 0; i < (valoresV1.Length - 1); i++)
                {
                    if (valoresV1[i] != (v2 + ""))
                    {
                        valorV1 += valoresV1[i] + ",";
                    }

                }
                LA.RemoveAt(v1);
                LA.Add(v1);
                LA.Insert(v1, valorV1);

                string valorV2 = LA[v2].ToString();
                string[] valoresV2 = valorV2.Split(',');
                valorV2 = "";
                for (int i = 0; i < (valoresV2.Length - 1); i++)
                {
                    if (valoresV2[i] != (v1 + ""))
                    {
                        valorV2 += valoresV2[i] + ",";
                    }

                }
                LA.RemoveAt(v2);
                LA.Add(v2);
                LA.Insert(v2, valorV2);
                return true;
            }
            throw new ArgumentException();
        }

        public int Grau(int vertice)
        {
            string itens = LA[vertice].ToString();
            string[] numItens = itens.Split(',');
            return (numItens.Length - 1);
        }

        public bool Completo()
        {
            string adjacentes = "";
            string[] adjacentesV;
            string[] vertices = this.verticesLA.Split(',');
            ArrayList adjacentesA = new ArrayList();
            for(int i = 0; i < (vertices.Length - 1); i++)
            {
                adjacentes = LA[i].ToString();
                adjacentesV = adjacentes.Split(',');
                for(int j = 0; j < adjacentesV.Length - 1; j++)
                {
                    adjacentesA.Add(adjacentesV[j]);
                }
                foreach(string s in vertices)
                {
                    if (!adjacentesA.Contains(s))
                        return false;
                }
            }
            return true;
        }

        public bool Regular()
        {
            string adjacentes = LA[0].ToString();
            string adjacentesAux;
            string[] adjacentesV = adjacentes.Split(',');
            string[] adjacentesVAux;
            int numArest = adjacentesV.Length;
            for(int i = 1; i < LA.Count; i++)
            {
                adjacentesAux = LA[i].ToString();
                adjacentesVAux = adjacentesAux.Split(',');
                if (adjacentesVAux.Length != numArest)
                    return false;
            }
            return true;
        }

        public void ShowLA()
        {
            for (int i = 0; i < LA.Count; i++)
                Console.WriteLine(i + " : " + LA[i].ToString());
        }

        public void SequenciaGraus()
        {
            int[] sequenciaGraus = new int[LA.Count];
            for (int i = 0; i < LA.Count; i++)
                sequenciaGraus[i] = Grau(i);

            Array.Sort(sequenciaGraus);
            foreach (int i in sequenciaGraus)
                Console.Write(i + ",");
        }

        public void VerticesAdjacentes(int vertice)
        {
            Console.WriteLine(LA[vertice].ToString());
        }

        public bool Isolado(int vertice)
        {
            if (Grau(vertice) == 0)
                return true;
            return false;
        }

        public bool Impar(int vertice)
        {
            if (Grau(vertice) % 2 != 0)
                return true;
            return false;
        }

        public bool Par(int vertice)
        {
            if (Grau(vertice) % 2 == 0)
                return true;
            return false;
        }

        public bool Adjacentes(int v1, int v2)
        {
            string itens = LA[v1].ToString();
            string[] itensSep = itens.Split(',');
            for (int i = 0; i < itensSep.Length - 1; i++)
                if (itensSep[i] == (v2 + ""))
                    return true;
            return false;
        }

        private bool VerificaExistenciaVertice(int vertice)
        {
            if (LA.Contains(vertice))
                return true;
            return false;
        }

        private bool VerificaExistenciaAresta(int v1, int v2)
        {
            string valorV1 = LA[v1].ToString();
            string[] valoresV1 = valorV1.Split(',');
            for (int i = 0; i < valoresV1.Length - 1; i++)
            {
                if (valoresV1[i] == (v2 + ""))
                    return true;
            }
            return false;
        }
    }
}
