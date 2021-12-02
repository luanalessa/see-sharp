using System;
using System.Collections.Generic;

namespace models
{
    public class Agenda
    {
        public Dictionary<string, string[]> acounts = new Dictionary<string, string[]>();

        public string[] searchContact(string document)
        {
            string[] userData = new string[3];
            foreach(string key in acounts.Keys )
            {
                if(key == document) 
                   userData = acounts[key];
            }
            return userData;
        }

        public void addContact(string document, string name, string address, string email)
        {
            string[] contact = searchContact(document);

             if(contact[0] == null)
            {   
                string[] data = { name, address, email };
                acounts.Add(document, data);
                Console.WriteLine("Contact added successfully!");
                return;
            }
            
            Console.WriteLine("Contact not found!");
        }  
          
        public void showContacts(string document = null){
            
            Dictionary<string, string[]> search = new Dictionary<string, string[]>();

            if(document != null)
            {
                search.Add(document,searchContact(document));
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

        public void editContact(string document, string name, string address, string email)
        {
            string[] contact = searchContact(document);
            string[] editedContact = { name, address, email };

            if(contact != null)
            {
                acounts[document] = editedContact;
            }
        }
    }    
}