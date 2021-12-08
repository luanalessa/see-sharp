namespace models
{
    public class SavingsAccount : Account
    {
        private double _rate = 0.2;

        public SavingsAccount(Client owner, int number, int agency, int type, double value) : base(owner, number, agency, type, value)
        {
        
        }
        

    }
}