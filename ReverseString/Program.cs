using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string reverse = ReversalString.Reversal("Hello Pramod");
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }

    public class ReversalString
    {
        public static string Reversal(string sourse)
        {
            if (string.IsNullOrWhiteSpace(sourse))
            {
                return sourse;
            }
            string reversestring = string.Empty;
            for (int j = sourse.Length - 1; j >= 0; j--)
            {
                reversestring = reversestring + sourse[j];
            }
            return reversestring;
        }
    }
}
