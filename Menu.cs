using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Menu
    {
        public static int MenuOptions()
        {
            int choice;
            Console.WriteLine("Please enter your choice using numbers: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. To check balance");
            Console.WriteLine("2. To withdraw money");
            Console.WriteLine("3. To deposit money");
            Console.WriteLine("4. Change pin code");
            Console.WriteLine("5. To quit");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return choice;
        }
    }
}