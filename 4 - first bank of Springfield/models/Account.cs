using System;
namespace models
{
    public class Account
    {
        private Client _owner;
        private string _initialDate;
        private int _number;
        private int _agency;
        public int op;
        protected double _balance;


        public Account(Client owner, int number, int agency, int type, double value)
        {

            if(type != 013 && type != 001)
            { 
                throw new ArgumentException(message: "Invalid argument");
            }

            op = type;
            
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

        public virtual bool Withdraw(double value)
        {
            //Qual o correto?
            if(Balance < value) return false;
            
            Balance -= value;

            return true;      
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public bool Transfer(double value, Account account)
        {
            bool checkBalance = Withdraw(value);

            if(!checkBalance) return false;

            account.Deposit(value);
            return true; 
        }
     
        public void getBalance()
        {
            Console.WriteLine(Balance);
        }


    }
}