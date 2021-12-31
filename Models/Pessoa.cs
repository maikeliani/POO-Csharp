using System;
namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string Nome{get;set;}
        public int Idade{get; set;}

        public  virtual void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos");
        }
    }
}