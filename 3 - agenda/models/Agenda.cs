using System;
using System.Collections.Generic;

namespace models
{
    public class Agenda
    {
        public Dictionary<string, string[]> acounts = new Dictionary<string, string[]>();

        public bool searchContact(string number)
        {
            string[] userData = new string[3];
 
            if(acounts.ContainsKey(number))
            {
                return true;
            }
            return false;
        }

        public bool createContact(string number, string name, string address, string email)
        {

             if(!searchContact(number))
            {   
                string[] data = { name, address, email };
                acounts.Add(number, data);
                Console.WriteLine("Contact added successfully!");
                return true;
            }
            
            Console.WriteLine("This contact is already in your agenda.");
            return false;
        }  
          
        public Dictionary<string, string[]> readContact(string number = null)
        {    
            Dictionary<string, string[]> search = new Dictionary<string, string[]>();

            if(number != null)
            {
                search.Add(number,acounts[number]);
            }
            else
            {
                search = acounts;
            }

            // foreach (string id in search.Keys)
            // {
            //     Console.WriteLine("-------------------------------------------------");
            //     Console.WriteLine("Nome: " + search[id][0]);
            //     Console.WriteLine("Number: " + id);
            //     Console.WriteLine("Endereço: " + search[id][1]);
            //     Console.WriteLine("Email: " + search[id][2]);
            //     Console.WriteLine("-------------------------------------------------");
            // }

            return search;
        }

        public bool updateContact(string number, string name, string address, string email)
        {
            string[] newData = { name, address, email };

            if(searchContact(number))
            {
                acounts[number] = newData;
                return true;
            }
            return false;
        }

        public bool deleteContact(string number)
        {
            if(searchContact(number))
                {   
                     acounts.Remove(number);
                     return true;
                }
            return false;
        }

    }    
}