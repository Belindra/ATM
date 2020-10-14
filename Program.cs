using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // saadaan € -merkki tulostettua
            BankATM atm = new BankATM(); 
            atm.OurATM(); 

            Console.ReadKey();
        }
    }
}
