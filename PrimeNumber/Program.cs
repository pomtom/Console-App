using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number to print the prime number!");
            int maxnumber = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= maxnumber; i++)
            {
                for (int j = 2; j <= maxnumber; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }

                isPrime = true;
            }

            Console.ReadLine();
        }


        
    }

    public class PrimeNumberClass
    {
        public static int PrintPrimeNumber(int number)
        {
            if (number % 2 != 0)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }
    }
}
