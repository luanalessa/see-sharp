namespace models
{
    public class CheckingAccount : Account
    {
        private double _limite;
        public CheckingAccount(Client owner, int number, int agency, int type, double value, double limite) : base(owner, number, agency, type, value)
        {
            _limite = limite;
        }

        public override bool Withdraw(double value)
        {

            if(_balance - value >= _limite) return false;
            
            _balance -= value;
            return true;  
        } 



    }
}