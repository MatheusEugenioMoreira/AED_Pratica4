using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            MaxMin m = new MaxMin();

            int[] cre = new int[1000];
            int[] dec = new int[1000];
            int[] ale = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                cre[i] = i + 1;
                dec[i] = 1000 - i;
                ale[i] = r.Next(1, 1000);
            }

            Console.WriteLine("Maxmin1, crescente: ");
            m.maxMin1(cre);
            Console.WriteLine("\nMaxmin1, decrescente: ");
            m.maxMin1(dec);
            Console.WriteLine("\nMaxmin1, aleatorio: ");
            m.maxMin1(ale);

            Console.WriteLine("\nMaxmin2, crescente: ");
            m.maxMin2(cre);
            Console.WriteLine("\nMaxmin2, decrescente: ");
            m.maxMin2(dec);
            Console.WriteLine("\nMaxmin2, aleatorio: ");
            m.maxMin2(ale);

            Console.WriteLine("\nMaxmin3, crescente: ");
            m.maxMin3(cre);
            Console.WriteLine("\nMaxmin3, decrescente: ");
            m.maxMin3(dec);
            Console.WriteLine("\nMaxmin3, aleatorio: ");
            m.maxMin3(ale);
            //Console.WriteLine("Maxmin2, crescente: " + m.maxMin2(cre) + ";" + " Decrescente: " + m.maxMin2(dec) + ";" + " Aleatorio: " + m.maxMin2(ale));
            //Console.WriteLine("Maxmin3, crescente: " + m.maxMin3(cre) + ";" + " Decrescente: " + m.maxMin3(dec) + ";" + " Aleatorio: " + m.maxMin3(ale));

            Console.ReadKey();
        }
    }
}
