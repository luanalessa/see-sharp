using System;
using System.Globalization;

namespace models
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(Client owner, int number, int agency, string type, double value) : base(owner, number, agency, type, value)
        {

        }



    }
}