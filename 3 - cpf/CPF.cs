using System;
using System.Text.RegularExpressions;

namespace _3___cpf
{
    public class CPF
    {
        public void IsValid(string number){

            string cpf = Regex.Replace(number, "[^0-9]+", "");

            if(cpf.Length != 11 || InvalidNumbers(cpf))
            {
                Console.WriteLine ("Invalid argument length or CPF number.");
            }
            else{
                bool isChecked = Check(cpf);

                if(isChecked == true)
                {
                    Console.WriteLine ("Valid CPF number.");
                }
                else
                {
                    Console.WriteLine ("Invalid CPF number.");
                }   
            }   
        }

        public static bool Check(string cpf){
            int[] arr = new int[11];
            int counter = 0;
            int firstDigit = 0;
            int secondDigit = 0;

            foreach(char x in cpf)
            {
                arr[counter] = (int)Char.GetNumericValue(x);
                counter++;
            }

            for(int i = 10; i > 1; i--)
            {
                firstDigit += arr[10 - i] * i;
            }

            firstDigit = (firstDigit * 10 % 11) >= 10 ? 0 : (firstDigit * 10 % 11);

            if(firstDigit == arr[9])
            {
                for(int i = 11; i > 1; i--)
                {
                    secondDigit += arr[11 - i] * i;
                }

                    secondDigit = (secondDigit * 10 % 11) >= 10 ? 0 : (secondDigit * 10 % 11);
                    if(secondDigit == arr[10]){
                        return true;
                    }
            }    
            return false;

        }

        public static string Mask(string number){
            string cpf = "";

            for(int i = 0; i < 11; i++)
            {   
                if( i == 3 || i == 6) cpf += ".";

                if( i == 9) cpf += "-";         

                cpf += number[i];
            }
            
           return cpf;
        }

        public static bool InvalidNumbers(string cpf){
            
            string[] repeatedDigits = 
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };

            int index = Array.IndexOf(repeatedDigits, cpf);

            if(index == -1) return false;
            
            return true;
        }
    }

}
