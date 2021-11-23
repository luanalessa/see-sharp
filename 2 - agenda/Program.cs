using System;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando pessoa
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = "Luana";
            novaPessoa.Endereco = "Rua da Matriz, 101";
            novaPessoa.Email = "lessa@gmail.com";

            Pessoa novaPessoa1 = new Pessoa();
            novaPessoa1.Nome = "Lessa";
            novaPessoa1.Endereco = "Rua da Matriz, 101";
            novaPessoa1.Email = "lessa@gmail.com";
            
            // Console.WriteLine($" Nome: {novaPessoa.Nome} \n Endereco: {novaPessoa.Endereco}");
        
            // Adicionando na agenda
            Agenda novaAgenda = new Agenda();
            // novaAgenda.CriarAgenda(novaPessoa);
            novaAgenda.ArmazenaPessoa(novaPessoa);
            novaAgenda.ArmazenaPessoa(novaPessoa1);

            novaAgenda.BuscarPessoa("Luana");
            novaAgenda.RemovePessoa("Luana");
            novaAgenda.BuscarPessoa("Luana");


            // novaAgenda.MostrarAgenda();
        }
    }
}
