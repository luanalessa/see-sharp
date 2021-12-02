using System;
using System.Collections.Generic;

namespace controllers
{
    public class Agenda
    {
        public Dictionary<string, string[]> acounts = new Dictionary<string, string[]>();

        public string[] searchUser(string document)
        {
            string[] userData = new string[3];
            foreach(string key in acounts.Keys )
            {
                if(key == document) 
                   userData[0] = acounts[key][0];
                   userData[1] = acounts[key][1];
                   userData[2] = acounts[key][2];
            }
            return userData;
        }

        public void addContact(string document, string name, string address, string email)
        {
            string[] userExist = searchUser(document);

             if(userExist[0] == null)
            {
                string[] data = { name, address, email };
                acounts.Add(document, data);
            }
        }  
          
        public void showContacts(string document = null){
            
            Dictionary<string, string[]> search = new Dictionary<string, string[]>();

            if(document != null)
            {
                search.Add(document,searchUser(document));
            }
            else
            {
                search = acounts;
            }

            foreach (string id in search.Keys)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nome: " + search[id][0]);
                Console.WriteLine("Cpf: " + id);
                Console.WriteLine("Endereço: " + search[id][1]);
                Console.WriteLine("Email: " + search[id][2]);
                Console.WriteLine("-------------------------------------------------");
            }
        }

        public void removeContact(string document)
        {
            acounts.Remove(document);
        }

        // public void editContact(string document, string document)
        // {
        //     foreach(string key in acounts.Keys )
        //     {
        //         if(key == document) 
        //             return false;
        //     }        
        // }

    }    
}