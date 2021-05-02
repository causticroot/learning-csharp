namespace Inheritance.Entidades
{
    public class ContaEmpresa : Conta
    {

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
            // :base(numero, titular, saldo) Reaproveita o construtor da superclasse
            // Numero = numero;
            // Titular = titular;
            // Saldo = saldo;
        }

        public ContaEmpresa()
        {
            
        }

        public double LimiteEmprestimo { get; set; }

        public void Emprestimo(double quantidade)
        {
            if (Saldo >= LimiteEmprestimo)
                Saldo += quantidade;
        }
        
        

    }
}