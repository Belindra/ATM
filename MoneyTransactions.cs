using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class MoneyTransactions
    {
        public static void WithdrawMoney(out double amount, out bool arvo)
        {
            string stringAmount = Console.ReadLine();
            if (stringAmount.Contains("."))
                stringAmount = stringAmount.Replace('.', ',');
            amount = Convert.ToDouble(stringAmount);
            amount = Math.Round(amount, 2);
            arvo = amount < 0 ? true : false;
        }
        public static void AmountToWithdraw(List<double> balance2, double amount, int listposition)
        {
            Console.Clear();
            Console.WriteLine($"You withdrew {amount} €, and your balance is {balance2[listposition]} €\n");
            Console.WriteLine("Please remove your card!");
        }
        public static void NotEnoughBalance()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your account doesn't have sufficient balance");
            Console.WriteLine("Please remove your card!");
        }
        public static void DepositMoney(List<double> balance2, int listposition)
        {
            Console.WriteLine("Please enter amount you want to deposit using only digits and/or comma: ");

            double deposit;
            string stringDeposit;
            stringDeposit = Console.ReadLine();
            if (stringDeposit.Contains("."))
                stringDeposit = stringDeposit.Replace('.', ',');
            deposit = Convert.ToDouble(stringDeposit);
            deposit = Math.Round(deposit, 2);
            balance2[listposition] = Math.Round((balance2[listposition] + deposit), 2);
            Console.Clear();
            Console.WriteLine($"You deposited {deposit} € and the current balance is {balance2[listposition]} €\n");
        }
        public static void EnterOnlyPositiveNumbers()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please only enter positive digits");
        }
        public static int Receipt(List<double> balance2, double amount, int listposition)
        {
            int receipt;
            Console.Clear();
            Console.WriteLine("Would you like a receipt, please use only digits?");
            Console.WriteLine("1. Yes   2. No");
            receipt = Convert.ToInt32(Console.ReadLine());
            balance2[listposition] = Math.Round((balance2[listposition] - amount), 2);
            return receipt;
        }
    }
}
