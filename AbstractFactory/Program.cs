using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var vr = Factoryinvoice.FactoryInstance("monthly");
            vr.GenerateInvoice();
            Console.ReadLine();
        }
    }


    public abstract class Factoryinvoice
    {
        public static IInvoice FactoryInstance(string invoicetype)
        {
            if (invoicetype == "monthly")
            {
                return MontlyFactory.GetInvoiceInstance();
            }
            else if (invoicetype == "quaterly")
            {
                return QuartlyFactory.GetInvoiceInstance();
            }
            else if (invoicetype == "yearly")
            {
                return YearlyFactory.GetInvoiceInstance();
            }
            else
                return null;
        }
    }

    public class MontlyFactory : Factoryinvoice
    {
        public static IInvoice GetInvoiceInstance()
        {
            return new MonthlyInvoice();
        }
    }

    public class QuartlyFactory : Factoryinvoice
    {
        public static IInvoice GetInvoiceInstance()
        {
            return new QuaterlyInvoice();
        }
    }

    public class YearlyFactory : Factoryinvoice
    {
        public static IInvoice GetInvoiceInstance()
        {
            return new YearlyInvoice();
        }
    }

    public interface IInvoice
    {
        void GenerateInvoice();
    }

    public class MonthlyInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Montly Invoice Printed");
        }
    }

    public class QuaterlyInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Quaterly Invoice Printed");
        }
    }

    public class YearlyInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Yearly Invoice Printed");
        }
    }
}
