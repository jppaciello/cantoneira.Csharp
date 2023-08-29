using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantoneira
{
    public class Contar
    {
        public void ImprimirSequencia(int valor)
        {
            Console.WriteLine("cantoneira:");
            int c = 0;
            while(c <= valor)
            {
                Console.WriteLine(c);
                c++;
            }
        }
    }
}
