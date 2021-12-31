using exemploPOO.interfaces;

namespace exemploPOO.Models
{
    public class Calculadora : ICalculadora 
    {
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2 ;
        // }

        // não precisou implementar Dividir() pq só é obrigado a implementar um método quando
        // ele não tem uma implementação padrão!!!

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2 ;
        }

        public int Somar (int num1, int num2)
        {
            return num1+num2;
        }


        public int Somar (int num1, int num2, int num3)
        {
            return num1+num2+num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    } // pra fazer o import no VSCode segura CONTROL+ "." e seleciona o q quer importar
    // segurar CONTROL + "." E CLICA EM IMPLEMENTAR INTERFACE
}