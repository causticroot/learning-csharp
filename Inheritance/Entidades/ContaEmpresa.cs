namespace Inheritance.Entidades
{
    public class ContaEmpresa : Conta
    {
        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
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