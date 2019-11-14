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
            ZadatakSumaListe();
            Console.ReadKey();
            
            

            
        }
        static void ZadatakSumaListe()
        {
            List<int> lista = new List<int>();
            bool stayinloop = true;
            string userentry;   
            int i;
            do
            {
                Console.WriteLine("Unesi broj sa tastature, za prekid ne unijeti nista");
                userentry = Console.ReadLine();
                if (string.IsNullOrEmpty(userentry))
                {
                    break;
                }else
                i = Convert.ToInt32(userentry);
                lista.Add(i);
                
            } while (stayinloop);
            Console.WriteLine("Sum of all numbers is {0}", SumaBrojeva(lista));
         
        }
        static int SumaBrojeva(List<int> brojevi)
        {
            int sum = 0;
            foreach(int i in brojevi)
            {
                sum = sum + i;
            }
            return sum;
        }

        
    }
    }

