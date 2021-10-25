using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
             Bank citi = new Bank();

            citi.CreateAccounts();
            citi.DoTransaction();
            citi.DoTransaction();
            Console.ReadKey();
        }
    }
}
