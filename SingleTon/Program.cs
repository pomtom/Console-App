using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton one = Singleton.Getinstance;
            Singleton two = Singleton.Getinstance;
            Console.ReadKey();
        }
    }

    public class Singleton
    {
        private static readonly object mutex = new object();
        private static Singleton _instance = null;
        private Singleton() { }

        public static Singleton Getinstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (mutex)
                    {
                        if (_instance == null)
                        {
                            Console.WriteLine("Method called");
                            _instance = new Singleton();
                            return _instance;
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
