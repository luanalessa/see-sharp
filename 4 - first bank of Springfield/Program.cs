using System;
using models;


namespace _4___first_bank_of_Springfield
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente1 = new Client(
                "12345678909",
                "Luana Lessa Sena",
                "lessa@gmail.com",
                "Rua 9");  

            SavingsAccount account1 = new SavingsAccount(cliente1, 0001, 1, "Savings Account", 100);


            account1.Deposit(200);
            account1.Withdraw(70);

            account1.getBalance();
 
        }

        
    }
}
