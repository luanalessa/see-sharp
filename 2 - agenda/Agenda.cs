using System;
using System.Collections.Generic;

namespace agenda
{
    public class Agenda
    {
        public static int Armazenamento { get; set; }

        public List<string> contas = new List<string>();

        public void ArmazenaPessoa(Pessoa pessoa)
        {
            string[] dadosPessoa = { $"{pessoa.Nome}", $"{pessoa.Endereco}", $"{pessoa.Email}"};

            contas.AddRange(dadosPessoa);
            Armazenamento++;
        }

        public void MostrarAgenda(){
             for(int x = 0 ; x < Armazenamento * 3 ; x++)
                {    
                    if(x % 3 == 0)
                    {
                    Console.WriteLine("");
                    }
                    Console.Write($"{contas[x]} ");
                } 
        }

        public void BuscarPessoa(string nome)
        {
            int indice = contas.IndexOf(nome);
            if (indice < 0) 
            {
                Console.WriteLine("Pessoa não cadastrada");
            } 
            else
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine(contas[indice + i]);
                }
            } 
        }

        public void RemovePessoa(string nome)
        {
            contas.Remove(nome);
        }
    }    
}