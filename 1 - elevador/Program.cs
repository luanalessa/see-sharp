using System;

namespace elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador1 = new Elevador(8,10);

            elevador1.Entra(3);
            Console.WriteLine(elevador1.QuantidadeAtual);

            elevador1.Sai(2);
            elevador1.Entra(8);
            Console.WriteLine(elevador1.QuantidadeAtual);

            elevador1.Sobe(9);

            elevador1.Sobe(1);
            Console.WriteLine(elevador1.AndarAtual);

            elevador1.Desce(1);



        }
    }
}
