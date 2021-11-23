
namespace agenda
{
    public class Pessoa
    {
        
        public string Nome { get; set; }

        private string _endereco;
        public string Endereco 
        { 
            get
            {
                return _endereco;
            } 
            set
            {
                _endereco = value;
            }     
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

    }
}