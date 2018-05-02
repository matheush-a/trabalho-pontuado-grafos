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
        //private ArrayList LA;
        private string verticesLA = "";
        private string[,] LA;
        int contPos = 0;

        public ListaAdjacencia()
        {
            LA = new string[20, 2];
            for (int i = 0; i < LA.GetLength(0); i++)
            {
                LA[i, 0] = "";
                LA[i, 1] = "";
            }
        }

        public int Ordem()
        {
            for (int i = 0; i < LA.Length; i++)
                if (LA[0, i] == "")
                    return i;
            return 0;
        }

        public bool InserirVertice(int vertice)
        {
            if (VerificaExistenciaVertice(vertice))
            {
                LA[contPos, 0] = vertice+"";
                contPos--;
                return true;
            }
            return false;
        }

        public bool RemoverVertice(int vertice)
        {
            if (VerificaExistenciaVertice(vertice))
            {
                string arestVert = "";
                string[] adjaVert;
                int pos = getPosVertice(vertice);
                for(int i = pos; i < contPos; i++)
                {
                    LA[pos, 0] = LA[(pos + 1), 0];
                    LA[pos, 1] = LA[(pos + 1), 1];
                }
                for(int i = 0; i < LA.GetLength(0); i++)
                {
                    arestVert = LA[i, 1];
                    adjaVert = arestVert.Split(',');
                    arestVert = "";
                    for (int j = 0; j < adjaVert.Length - 1; j++)
                    {
                        if(adjaVert[j] == vertice + "")
                        {
                            for (int k = 0; k < adjaVert.Length - 1; k++)
                                if (k != j)
                                    arestVert += adjaVert[k];
                        }
                    }
                    LA[i, 1] = arestVert;
                }
                return true;
            }
            throw new ArgumentException();
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                if (!VerificaExistenciaAresta(v1, v2) || !VerificaExistenciaAresta(v2, v1))
                    return false;
                int pos = getPosVertice(v1);
                string valorV1 = LA[pos,1];
                valorV1 += (v2 + ",");
                LA[pos,1] = valorV1;
                pos = getPosVertice(v2);
                string valorV2 = LA[pos,1];
                valorV2 += (v1 + ",");
                LA[pos,1] = valorV2;

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
                int pos = getPosVertice(v1);
                string valorV1 = LA[pos,1];
                string[] valoresV1 = valorV1.Split(',');
                valorV1 = "";
                for (int i = 0; i < (valoresV1.Length - 1); i++)
                    if (valoresV1[i] != (v2 + ""))
                        valorV1 += valoresV1[i] + ",";
                LA[pos, 1] = valorV1;
                pos = getPosVertice(v2);
                string valorV2 = LA[pos,1];
                string[] valoresV2 = valorV2.Split(',');
                valorV2 = "";
                for (int i = 0; i < (valoresV2.Length - 1); i++)
                    if (valoresV2[i] != (v1 + ""))
                        valorV2 += valoresV2[i] + ",";
                LA[pos, 1] = valorV2;
                return true;
            }
            throw new ArgumentException();
        }

        public int Grau(int vertice)
        {
            int pos = getPosVertice(vertice);
            string itens = LA[pos,1];
            string[] numItens = itens.Split(',');
            return (numItens.Length - 1);
        }

        public bool Completo()
        {
            string adjacentes = "";
            string[] adjacentesV;
            string[] vertices = this.verticesLA.Split(',');
            ArrayList adjacentesA = new ArrayList();
            for (int i = 0; i < (vertices.Length - 1); i++)
            {
                adjacentes = LA[i,1];
                adjacentesV = adjacentes.Split(',');
                for (int j = 0; j < adjacentesV.Length - 1; j++)
                    adjacentesA.Add(adjacentesV[j]);
                foreach (string s in vertices)
                    if (!adjacentesA.Contains(s))
                        return false;
            }
            return true;
        }

        public bool Regular()
        {
            string adjacentes = LA[0,1];
            string adjacentesAux;
            string[] adjacentesV = adjacentes.Split(',');
            string[] adjacentesVAux;
            int numArest = adjacentesV.Length;
            for (int i = 1; i < LA.GetLength(0); i++)
            {
                adjacentesAux = LA[i,1];
                adjacentesVAux = adjacentesAux.Split(',');
                if (adjacentesVAux.Length != numArest)
                    return false;
            }
            return true;
        }

        public void ShowLA()
        {
            for (int i = 0; i < LA.GetLength(0); i++)
                Console.WriteLine(i + " : " + LA[i,0]);
        }

        public void SequenciaGraus()
        {
            int[] sequenciaGraus = new int[LA.GetLength(0)];
            for (int i = 0; i < LA.GetLength(0); i++)
                sequenciaGraus[i] = Grau(i);

            Array.Sort(sequenciaGraus);
            foreach (int i in sequenciaGraus)
                Console.Write(i + ",");
        }

        public void VerticesAdjacentes(int vertice)
        {
            int pos = getPosVertice(vertice);
            Console.WriteLine(LA[pos,1]);
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
            int pos = getPosVertice(v1);
            string itens = LA[pos,1];
            string[] itensSep = itens.Split(',');
            for (int i = 0; i < itensSep.Length - 1; i++)
                if (itensSep[i] == (v2 + ""))
                    return true;
            return false;
        }

        private bool VerificaExistenciaVertice(int vertice)
        {
            for (int i = 0; i < LA.GetLength(0); i++)
                if (LA[i, 0] == (vertice + ""))
                    return true;
            return false;
        }

        private int getPosVertice(int vertice)
        {
            for (int i = 0; i < LA.GetLength(0); i++)
            {
                if (LA[i, 0] == (vertice + ""))
                {
                    return i;
                }
            }
            throw new ArgumentException();
        }

        private bool VerificaExistenciaAresta(int v1, int v2)
        {
            int posv1 = getPosVertice(v1);
            string valorV1 = LA[posv1,1];
            string[] valoresV1 = valorV1.Split(',');
            for (int i = 0; i < valoresV1.Length - 1; i++)
                if (valoresV1[i] == (v2 + ""))
                    return true;
            return false;
        }
    }
}
