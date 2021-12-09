using System;
using System.Collections.Generic;

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

        public Dictionary<string, Dictionary<int, string[]>> transactions = new Dictionary<string, Dictionary<int, string[]>>();

        public Account(Client owner, int number, int agency, int type, double value)
        {

            if(type != 013 && type != 001)
            { 
                throw new ArgumentException(message: "Invalid argument"); // o throw para a aplicação?
                return;
            }

            Dictionary<int, string[]> inflow = new Dictionary<int, string[]>();
            Dictionary<int, string[]> outflow = new Dictionary<int, string[]>();
            transactions.Add("inflow", inflow);
            transactions.Add("outflow", outflow);

            op = type;
        
            _owner = owner;
            _number = number;
            _agency = agency;
            _initialDate =  DateTime.Now.ToString();

            if(value > 0){
                newTransaction("inflow", value);
            }
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

        public virtual bool Withdraw(double value, bool insertTransaction = true)
        {
            //Qual o correto?
            if(Balance < value) return false;
            
            Balance -= value;

            if(insertTransaction) newTransaction("outflow", value);
        
            return true;      
        }

        public void Deposit(double value)
        {
            Balance += value;
            newTransaction("inflow", value);

        }

        public bool Transfer(double value, Account account)
        {
            bool checkBalance = Withdraw(value, false);

            if(!checkBalance) return false;

            account.Deposit(value);

            newTransaction("outflow", value);
            return true; 
        }
     
        public void getBalance()
        {
            Console.WriteLine($"inflow");
            foreach(int key in transactions["inflow"].Keys)
            {
                Console.WriteLine($"Date: {transactions["inflow"][key][0]}, value: {transactions["inflow"][key][1]}");
            }


            Console.WriteLine($"outflow");
            foreach(int key in transactions["outflow"].Keys)
            {
                Console.WriteLine($"Date: {transactions["outflow"][key][0]}, value: {transactions["outflow"][key][1]}");
            }
        }

        public void newTransaction(string transaction, double value)
        {   
            int indice = 0 ;
            string[] data = {DateTime.Now.ToString(), Convert.ToString(value)};

            foreach(int key in transactions[transaction].Keys)
            {
                indice ++;
            }

            transactions[transaction].Add(indice , data);
        }


    }
}