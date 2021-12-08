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
                "Ana Lessa Sena",
                "lessa@gmail.com",
                "Rua 9");  

            SavingsAccount account1 = new SavingsAccount(cliente1, 0001, 1, 013, 100);
    

            Client cliente2 = new Client(
                "13002756008",
                "Luana Lessa Sena",
                "lessa@gmail.com",
                "Rua 9");  
            
            CheckingAccount account2 = new CheckingAccount(cliente2, 0001, 1, 001, 0, 100);

            account1.Deposit(200);
            account1.Withdraw(70);
            account1.Transfer(30, account2);

            account1.getBalance();

            

            account2.Withdraw(120);
            account2.getBalance();


 
        }

        
    }
}
