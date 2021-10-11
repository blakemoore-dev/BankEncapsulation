using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount01 = new BankAccount();
            Console.WriteLine($"Your current blance is:    {bankAccount01.GetBalance()}");
            Console.Write("\nHow much would you like to deposit?    ");
            bankAccount01.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine($"\nYour current balnce is {bankAccount01.GetBalance()}");
        }
    }
}
