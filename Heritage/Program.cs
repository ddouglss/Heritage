using Heritage.Entities;
using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1011, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1022,"Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
