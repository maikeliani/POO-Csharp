namespace exemploPOO.interfaces
{
    public interface ICalculadora
    {
         int Somar ( int num1, int num2);
         int Subtrair ( int num1, int num2);
         int Multiplicar ( int num1, int num2);
         int Dividir ( int num1, int num2)
         {
             return num1 / num2; // método com implementação padrão
             // método com implementação na Interface começou a partir do C# 8
         }


    } 
} // em uma Interface por padrão os métodos serão PÚBLICOS