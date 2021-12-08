using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace models
{
    public class Client
    {
        public string Name { get; set; }
        private string _address;
        private string _email;
        private string _document;
        
        public Client(string document, string name, string address, string email )
        {
            Document doc = new Document();

            if(doc.isValid(document))
            {
                Name = name;
                _document = document;
                _address = address;
                _email = email;
            }


        }
    }
}