using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine("{0}",
            //        i % 15 == 0 ? "Fizz Buzz"
            //        : (i % 3 == 0 ? "Fizz"
            //        : (i % 5 == 0 ? "Buzz"
            //        : i.ToString())));
            //}

            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine(i % 15 == 0 ? "Fizz Buzz" : i % 5 == 0 ? "Buzz" : i % 3 == 0 ? "Fizz" : i.ToString());
            //}


            
            for (int i = 1; i < 100; i++)
            {
                string result = string.Empty;
                if (i % 3 == 0)
                {
                    result = "Fizz ";
                }

                if (i % 5 == 0)
                {
                    result = result + "Buzz";
                }

                if (result.Length == 0)
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
