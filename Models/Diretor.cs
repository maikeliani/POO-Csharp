using System;
namespace exemploPOO.Models
{
    public class Diretor : Professor 
    {
        public override void Apresentar()
        {
        Console.WriteLine($"Ola, meu nome é {Nome}, diretor");
        }
    }
}