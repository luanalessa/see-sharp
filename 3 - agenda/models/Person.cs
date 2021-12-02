using System;
using System.Collections.Generic;

namespace models
{
    public class Person : Agenda
    {
        public string Name;
        private string _address;
        private string _email;
        private string _document;
        
        public Person(string document, string name, string address, string email )
        {
            Document doc = new Document();

            if(doc.isValid(document))
            {
                _document = document;
                Name = name;
                _address = address;
                _email = email;
            }
        }

    }
}
