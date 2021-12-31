using System;

namespace exemploPOO.Models
{
    public class Aluno : Pessoa 
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine ($"Olá, me chamo {Nome} e sou um aluno nota {Nota}");
        }
    }
}