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
            if(VerificaExistenciaVertice(v1) && VerificaExistenciaVertice(v2))
            {
                if (VerificaExistenciaAresta(v1, v2) || VerificaExistenciaAresta(v2,v1))
                    return false;

                string valorV1 = LA[v1].ToString();
                valorV1 += (v2+",");
                LA.Insert(v1, valorV1);

                string valorV2 = LA[v2].ToString();
                valorV2 += (v1+",");
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
                for(int i = 0; i < (valoresV1.Length - 1); i++)
                {
                    if(valoresV1[i] != (v2 + ""))
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
            for(int i = 0; i < valoresV1.Length; i++)
            {
                if (valoresV1[i] == (v2 + ""))
                    return true;
            }
            return false;
        }
    }
}
