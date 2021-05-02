namespace Inheritance.Entidades
{
    public class Conta
    {
        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public int Numero { get; protected set; }
        public string Titular { get; protected set; }
        public double  Saldo { get; protected set; }
        
        public virtual void Remover(double quantidade)
        {
            Saldo -= quantidade + 6.50; // 6.50 = taxa de saque
        }
        
        public void Depositar(double quantidade)
        {
            Saldo += quantidade;
        }

        
        
    }
}