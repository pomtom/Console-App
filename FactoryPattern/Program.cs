using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vr = FactoryInvoice.GetInvoiceInstance("yearly");
            vr.GenerateInvoice();
            Console.ReadLine();
        }
    }


    public class FactoryInvoice
    {
        public static IInvoice GetInvoiceInstance(string invoicetype)
        {
            if (invoicetype == "monthly")
            {
                return new MonthlyInvoice();
            }
            else if (invoicetype == "quarterly")
            {
                return new QuaterlyInvoice();
            }
            else if (invoicetype == "yearly")
            {
                return new YearlyInvoice();
            }
            else
                return null;
        }
    }


    public interface IInvoice
    {
        string GenerateInvoice();
    }

    public class MonthlyInvoice : IInvoice
    {
        public string  GenerateInvoice()
        {
            Console.WriteLine("Montly Invoice Printed");
            return "monthly";
        }
    }

    public class QuaterlyInvoice : IInvoice
    {
        public string GenerateInvoice()
        {
            Console.WriteLine("Quaterly Invoice Printed");
            return "quarterly";
        }
    }

    public class YearlyInvoice : IInvoice
    {
        public string GenerateInvoice()
        {
            Console.WriteLine("Yearly Invoice Printed");
            return "yearly";
        }
    }

}
