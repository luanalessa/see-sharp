using System;
using models;

namespace _4___register
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();
            string nameUser, enderecoUser, emailUser;
            int documentUser;

            Console.WriteLine("Informe o seu nome: ");
            nameUser = Console.ReadLine();

            Console.WriteLine("Informe o seu endereço: ");
            enderecoUser = Console.ReadLine(); ;

            Console.WriteLine("Informe o seu e-mail: ");
            emailUser = Console.ReadLine();

            Console.WriteLine("Informe o seu documento: ");
            documentUser = int.Parse(Console.ReadLine());


            Console.WriteLine("===============================");

            Console.WriteLine(person.Name = nameUser);
            Console.WriteLine(person.Address = enderecoUser);
            Console.WriteLine(person.Email = emailUser);
            Console.WriteLine(person.Document = documentUser);



        }
    }
}
