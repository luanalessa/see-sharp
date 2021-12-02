using System;
using controllers;

namespace _4___register
{
    class Program
    {
        static void Main(string[] args)
        {
            // Document doc = new Document("111.111.111-11");    
            // Document doc1 = new Document("11111111111");    
            // Document doc2 = new Document("123.456.789-09");    
            // Document doc3 = new Document("12345678909");    
    
            // Document doc4 = new Document("11111111111111");    
            // Document doc5 = new Document("11.444.777/0001-61");    
            // Document doc6 = new Document("59360748000148");            
       
            var person = new Person(
                "12345678909",
                "Luana Lessa Sena",
                "lessa@gmail.com",
                "Rua 9");  
            
            var agenda = new Agenda();

            person.addContact(
                "11111111111",
                "Joao Pedro Saraceni",
                "joao@gmail.com",
                "Rua 7"
            );

            person.addContact(
                "123",
                "Luana Lessa Sena",
                "lessa@gmail.com",
                "Rua 8"
            );

            person.showContacts("123");

            // Agenda agenda = new Agenda();
            // agenda.searchUser("12345678909");
            // agenda.showAgenda();  

        }
    }
}
