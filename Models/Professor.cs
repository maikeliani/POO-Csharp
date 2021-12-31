using System;
namespace exemploPOO.Models
{
    public class Professor : Pessoa 
    {
        public double Salario { get; set; }

        public  override void Apresentar()
        {
        Console.WriteLine($"Ola, meu nome é {Nome}, sou um professor e meu salario é {Salario}");
        }
    }
} // para acessar uma classe qualquer é só clicar em cima dela e apertar F12