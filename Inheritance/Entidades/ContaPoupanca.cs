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

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        
    }
}