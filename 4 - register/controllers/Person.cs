using System;
using System.Collections.Generic;

namespace controllers
{
    public class Person : Agenda
    {
        public string _name;
        private string _address;
        private string _email;
        private string _document;
        private Agenda _agenda = new Agenda();
        public Person(string document, string name, string address, string email )
        {
            Document doc = new Document();

            if(doc.isValid(document))
            {
                _document = document;
                _name = name;
                _address = address;
                _email = email;
            }
        }

    }
}
