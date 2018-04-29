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
            LA.Add(vertice);
            return true;
        }
    }
}
