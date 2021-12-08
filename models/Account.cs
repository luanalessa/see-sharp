using System;
using System.Globalization;

namespace models
{
    public class Account
    {
        private Client _owner;
        private string _initialDate;
        private int _number;
        private int _agency;
        public int op;
        private double _balance;


        public Account(Client owner, int number, int agency, string type, double value)
        {

            if(type == "Savings Account")
            { 
                op = 013;
            }
            else if(type == "Checking Account")
            {
                op = 001;
            }
            else
            {
                throw new ArgumentException(message: "Invalid argument");
            }

            _owner = owner;
            _number = number;
            _agency = agency;
            _initialDate =  DateTime.Now.ToString("hh:mm:ss tt");

            _balance = value;


        }

        public double Balance 
        { 
            get
            {
                return _balance;
            }
            set
            {
                if( value < 0 )
                {
                    return;
                }

                _balance = value;
            } 
        }

        public bool Withdraw(double value)
        {
            if(_balance < value) return false;
            
            Balance -= value;

            return true;      
        }

        public void Deposit(double value)
        {
            Balance += value;
        }
     
        public void getBalance()
        {
            Console.WriteLine(Balance);
        }

    }
}