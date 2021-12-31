using System;
namespace exemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        private bool valido;

        public void DefinirMedidas ( double comprimento, double largura) 
        {
            if ( comprimento > 0 && largura > 0)
            {

                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;  // o valor de qualquer booleano é false
            } 
            else
            {                            
                Console.WriteLine(" Insira números positivos");
                              
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento*largura;
            }
            else 
            {
                System.Console.WriteLine("Preencha valores válidos!");
                return 0;
            }
        }
    } 
}