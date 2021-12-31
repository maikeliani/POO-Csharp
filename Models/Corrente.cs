namespace exemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo=valor; // mesmo q this.saldo mas o base diz que o atributo saldo pertence a classe pai
        }
    }
}