using System;

public class Elevador
    {
        public int QuantidadeAtual { get; set; }
        public int AndarAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public int AndarTotal { get; set;}

        public Elevador(int capacidade, int andar)
        {
            QuantidadeAtual = 0;
            AndarAtual = 1;
         
            CapacidadeTotal = capacidade;
            AndarTotal = andar;
        }

        public bool Entra(int pessoas){

            if( ( QuantidadeAtual + pessoas ) <= CapacidadeTotal)
            {
                QuantidadeAtual += pessoas;
                return true;
            }            
            return false;
        }

        public bool Sai(int pessoas){

            if( QuantidadeAtual > 0 )
            {
                QuantidadeAtual -= pessoas;
                return true;
            }            
            return false;
        }

        public bool Sobe(int andar){

            if( (AndarAtual + andar ) <= AndarTotal )
            {
                AndarAtual += andar;
                return true;
            }            
            return false;
        }

        public bool Desce(int andar){

            if( AndarAtual > 0 )
            {
                AndarAtual -= andar;
                return true;
            }            
            return false;
        }
    
}