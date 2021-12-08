using System;
using System.Globalization;

namespace models
{
    public class SavingsAccount : Account
    {
        private double _rate = 0.3;

        public SavingsAccount(Client owner, int number, int agency, string type, double value) : base(owner, number, agency, type, value)
        {
        
        }
        

    }
}