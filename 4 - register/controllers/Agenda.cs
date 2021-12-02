using System;
using System.Collections.Generic;

namespace controllers
{
    public class Agenda
    {
        public static int Storage { get; set; }
        public Dictionary<string, string[]> acounts = new Dictionary<string, string[]>();

        public bool searchUser(string document)
        {
            foreach(string key in acounts.Keys ){
                Console.WriteLine(key);
                if(key == document)
                    Console.WriteLine("User already exits");
                    return false;
            }

            Console.WriteLine("User not found");
            return true;
            
        }

        public void addContact(string document, string name, string address, string email)
        {
            bool userExist = searchUser(document);
            if(userExist)
            {
                string[] data = { name, address, email };
                
                acounts.Add(document, data);
                }
        }

    
        // public void removeContact(string data)
        // {
        //     acounts.Remove(data);
        // }

        public void showAgenda(){
             
             foreach (string id in acounts.Keys)
             {
                Console.WriteLine("Nome: " + acounts[id][0]);
                Console.WriteLine("Cpf: " + id);
                Console.WriteLine("Endereço: " + acounts[id][1]);
                Console.WriteLine("Email: " + acounts[id][2]);
            }
        }


    }    
}