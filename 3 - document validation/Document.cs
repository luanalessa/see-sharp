using System;
using System.Text.RegularExpressions;

namespace _3___document_validation
{
    public class Document
    {
        private string _cpf;
        private string _cnpj;
        

        public Document(string doc)
        {
            string docNumber = Regex.Replace(doc, "[^0-9]+", "");
            bool docValidation = isValid(docNumber);

            if(docValidation && docNumber.Length == 11)
            {
               _cpf = docNumber;

            }
            else if(docValidation && docNumber.Length == 14)
            {
                _cnpj = docNumber;
            }
        }
        public bool isValid(string doc){

            if(doc.Length != 14 && doc.Length != 11 || !InvalidNumbers(doc))
            {
                Console.WriteLine ("Invalid argument length or document number.");
                return false;
            }
            
            bool isChecked = CheckDocument(doc);

            if(isChecked)
            {
                Console.WriteLine ("Valid document number.");
                return true;
            }
            
            Console.WriteLine ("Invalid document number.");
            return false;               
        }

        public bool CheckDocument(string doc)
        {
            int[] arr = new int[doc.Length];
            int indice = 0;
            int firstDigit = 0;
            int secondDigit = 0;

            foreach(char number in doc)
            {
                arr[indice] = (int)Char.GetNumericValue(number);
                indice++;
            }

            if(doc.Length == 11)
                return CpfValidation(doc, firstDigit, secondDigit, arr);
            
            return CnpjValidation(doc, firstDigit, secondDigit, arr);
        }

        public bool CpfValidation(string doc, int firstDigit, int secondDigit, int[] arr)
        {
            
            for(int i = 10; i > 1; i--)
            {
                firstDigit += arr[10 - i] * i;
            }

            firstDigit = (firstDigit * 10 % 11) >= 10 ? 0 : (firstDigit * 10 % 11);

            if(firstDigit == arr[9])
            {
                for(int i = arr.Length; i > 1; i--)
                {
                    secondDigit += arr[11 - i] * i;
                }

                    secondDigit = (secondDigit * 10 % 11) >= 10 ? 0 : (secondDigit * 10 % 11);

                    return secondDigit == arr[10];
                    
            }    
            return false;
        }

        public bool CnpjValidation(string doc, int firstDigit, int secondDigit, int[] arr)
        {
            int weight = 5;

            for(int i = 0; i < arr.Length - 2; i++)
            {
                firstDigit += arr[i] * weight;

                weight = (weight == 2) ? 9 : weight - 1;
            }


            firstDigit = (firstDigit % 11) < 2 ? 0 : (11 - firstDigit % 11 );

            if(firstDigit == arr[12])
            {

                weight = 6;

                for(int i = 0; i < 13; i++)
                {
                    secondDigit += arr[i] * weight;
                    weight = (weight == 2) ? 9 : weight - 1;
                }

                    secondDigit = (secondDigit % 11) < 2 ? 0 : (11 - secondDigit % 11);

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
