using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[10];
            double[] poeni = new double[2] { 43.332, 32.91 };

            for(int i = 0; i < 10; i++)
            {
                niz[i] = i * 10;
                Console.WriteLine("Vrijednost elementa niz[{0}]={1}", i, niz[i]);
            }
            Console.ReadKey();
        }
    }
    }

