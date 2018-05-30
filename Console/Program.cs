using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static List<TransactionsPool> pools = new List<TransactionsPool>();
        static Program()
        {
            pools.Add(new TransactionsPool { Id = 1, SizeByte = 57247, Fees = 0.0887M });
            pools.Add(new TransactionsPool { Id = 2, SizeByte = 98732, Fees = 0.1856M });
            pools.Add(new TransactionsPool { Id = 3, SizeByte = 134928, Fees = 0.2307M });
            pools.Add(new TransactionsPool { Id = 4, SizeByte = 77275, Fees = 0.1522M });
            pools.Add(new TransactionsPool { Id = 5, SizeByte = 29240, Fees = 0.0532M });
            pools.Add(new TransactionsPool { Id = 6, SizeByte = 15440, Fees = 0.0250M });
            pools.Add(new TransactionsPool { Id = 7, SizeByte = 70820, Fees = 0.1409M });
            pools.Add(new TransactionsPool { Id = 8, SizeByte = 139603, Fees = 0.2541M });
            pools.Add(new TransactionsPool { Id = 9, SizeByte = 63718, Fees = 0.1147M });
            pools.Add(new TransactionsPool { Id = 10, SizeByte = 143807, Fees = 0.2660M });
            pools.Add(new TransactionsPool { Id = 11, SizeByte = 190457, Fees = 0.2933M });
            pools.Add(new TransactionsPool { Id = 12, SizeByte = 40572, Fees = 0.0686M });
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < pools.Count; i++)
            {
                pools[i].FeesPerByte = pools[i].Fees / pools[i].SizeByte;
                pools[i].Reward = pools[i].FeesPerByte * pools[i].SizeByte;
            }



            //foreach (var item in pools)
            //{
            //    Console.WriteLine(item.Id + "-" + item.FeesPerByte);
            //}

            pools.Sort((a, b) => a.Compare(a, b)); // ascending sort


            //Console.WriteLine("--- After sort --- ");
            //foreach (var item in pools)
            //{
            //    Console.WriteLine(item.Id + "-" + item.FeesPerByte);
            //}

            pools.Sort((a, b) => -1 * a.Compare(a, b)); // descending sort

            //Console.WriteLine("--- After Reverse --- ");
            //foreach (var item in pools)
            //{
            //    Console.WriteLine(item.Id + "-" + item.FeesPerByte);
            //}

            decimal fees = 0, size = 0;
            for (int i = 0; i < pools.Count; i++)
            {
                if ((size) < 500000)
                {
                    fees += pools[i].SizeByte * pools[i].FeesPerByte;
                    size += pools[i].SizeByte;
                }
                else
                    break;
            }
            Console.WriteLine("Fees = " + fees);
            Console.WriteLine("Size = " + size);
            Console.WriteLine("Maximum Reward = " + (fees + 12.5M));
            Console.ReadKey();
        }
    }

    class TransactionsPool : IComparer<TransactionsPool>
    {
        public int Id { get; set; }
        public int SizeByte { get; set; }
        public decimal Fees { get; set; }
        public decimal FeesPerByte { get; set; }
        public decimal Reward { get; set; }

        public int Compare(TransactionsPool x, TransactionsPool y)
        {
            int comparevalue = x.FeesPerByte.CompareTo(y.FeesPerByte);
            if (comparevalue == 0)
            {
                return x.FeesPerByte.CompareTo(y.FeesPerByte);
            }
            return comparevalue;
        }
    }
}
