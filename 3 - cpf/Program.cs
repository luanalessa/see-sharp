using System;

namespace _3___cpf
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF data = new CPF();

            data.IsValid("111.111.111-11");
            data.IsValid("11111111111");          

            data.IsValid("123.456.789-09"); 
            data.IsValid("12345678909");     
       
        }
    }
}
