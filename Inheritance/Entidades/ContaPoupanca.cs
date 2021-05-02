namespace Inheritance.Entidades
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base (numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public double TaxaJuros { get; set; }

        public override void Remover(double quantidade)
        {
            base.Remover(quantidade);
            Saldo -= 0.43;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        
    }
}