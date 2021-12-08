using System;
using System.Text.RegularExpressions;

namespace models
{
    public class Document
    {
        
        public bool isValid(string id){
            
            string doc = Regex.Replace(id, "[^0-9]+", "");
            
            if(doc.Length != 14 && doc.Length != 11 || !InvalidNumbers(doc))
            {
                Console.WriteLine ("Invalid argument length or document number.");
                return false;
            }
            
            if(CheckDigits(doc))
            {
                Console.WriteLine ("Valid document number.");
                return true;
            }
            
            Console.WriteLine ("Invalid document number.");
            return false;               
        }

        public bool CheckDigits(string doc)
        {
            int[] arr = new int[doc.Length];
 
            for(int index = 0; index < doc.Length; index ++)
            {
                arr[index] = (int)Char.GetNumericValue(doc[index]);
            }

            if(doc.Length == 11)
                return CpfValidation(0, 0, arr);
            
            return CnpjValidation(0, 0, arr);
        }

        public bool CpfValidation(int firstDigit, int secondDigit, int[] arr)
        {
            int restLimit = 10;
            int rest = 0;
            
            for(int index = arr.Length - 1; index > 1; index--)
            {
                firstDigit += arr[10 - index] * index;
            }

            rest = firstDigit * 10 % 11;
            firstDigit =  rest >= restLimit ? 0 : rest;

            if(firstDigit == arr[9])
            {
                for(int index = arr.Length; index > 1; index--)
                {
                    secondDigit += arr[11 - index] * index;
                }
                    rest = secondDigit * 10 % 11;
                    secondDigit =  rest >= restLimit ? 0 : rest;

                    return secondDigit == arr[10]; 
            }    
            return false;
        }

        public bool CnpjValidation(int firstDigit, int secondDigit, int[] arr)
        {
            int weight = 5;
            int restLimit = 2;
            int rest = 0;

            for(int index = 0; index < arr.Length - 2; index++)
            {
                firstDigit += arr[index] * weight;

                weight = (weight == 2) ? 9 : weight - 1;
            }

            rest = firstDigit % 11;
            firstDigit = rest < restLimit ? 0 : 11 - rest;

            if(firstDigit == arr[12])
            {
                weight = 6;

                for(int index = 0; index < 13; index++)
                {
                    secondDigit += arr[index] * weight;
                    weight = (weight == 2) ? 9 : weight - 1;
                }

                    rest = secondDigit % 11;
                    secondDigit = rest < restLimit ? 0 : 11 - rest;

                    return secondDigit == arr[13];
                
            }    
            return false;
        }
        public static bool InvalidNumbers(string doc){
            
            string[] repeatedDigits = 
            {
                "00000000000000",
                "11111111111111",
                "22222222222222",
                "33333333333333",
                "44444444444444",
                "55555555555555",
                "66666666666666",
                "77777777777777",
                "88888888888888",
                "99999999999999",
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

            return Array.IndexOf(repeatedDigits, doc) == -1;
            
        }
    }
}
