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

        }
    }
}
