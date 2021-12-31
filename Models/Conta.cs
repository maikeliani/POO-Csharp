namespace exemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;
        public abstract void Creditar(double valor ); // todo metodo abstrado eu sou OBRIGADO a sobrescreve-lo!!!

        public void ExibirSaldo()
        {

            System.Console.WriteLine("Seu saldo é:  " +saldo);
        }
    }
}