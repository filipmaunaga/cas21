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
            //Practise with null variable

            int? num1 = null;
            int? num2 = 50;
            int? num3 = 0;

            //simple
            num3 = num1 ?? num2;

            //regular
            if (num1 == null)
            {
                num3 = num2;
            }
            else
                num3 = num1;
            //ternary operator
            num3 = (num1 == null) ? num2 : num1;
            string entry1, entry2;
            //Advanced Calculator with empty strings as entries
            Console.WriteLine("Enter the first value:");
            entry1 = Console.ReadLine();
            Console.WriteLine("Enter the second value:");
            entry2 = Console.ReadLine();
            Console.WriteLine("Enter the operation:");
            string o = Console.ReadLine();

            double m = string.IsNullOrEmpty(entry1) ? 2 : Convert.ToDouble(entry1);
            double n = string.IsNullOrEmpty(entry2) ? 2 : Convert.ToDouble(entry2);
            double result = AdvancedCalculator(m, n, o);
            Console.WriteLine("Result is  {0} {1} {2} = {3}", m, o, n, result);
            //ZadatakSumaListe();

            Console.WriteLine("Sum of params array is {0}", SumWithParamsArray(1, 2, 3, 4, 5, 6));
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
        static double AdvancedCalculator (double m, double n, string operation)
        {
            double result;
            switch (operation)
            {
                case "+": result = m + n;
                    break;
                case "-": result = m - n;
                    break;
                case "*": result = m * n;
                    break;
                case "/": result = m / n;
                    break;
                default: result = 0;
                    break;


            }
            return result;
        }

        static int SumWithParamsArray(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
    }

