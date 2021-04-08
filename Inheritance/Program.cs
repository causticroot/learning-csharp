using System;
using Inheritance.Entidades;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(101, "Maria Green", 0.0);
            ContaEmpresa contaEmpresa = new ContaEmpresa(1210, "Carlinhos Brown", 0.0, 1000.00);

            //Upcasting
            Conta conta1 = contaEmpresa;
            Conta conta2 = new ContaEmpresa(1202, "Jhon Lenon", 1000.0, 10.000);
            Conta conta3 = new ContaPoupanca(1021, "Josefina", 0.0, 0.87);

            //Downcasting
            ContaEmpresa conta4 = (ContaEmpresa)conta2;
            conta4.Emprestimo(100.0);

            // ContaEmpresa conta5 = (ContaEmpresa)conta3;  - Exception em runtime
            if ( conta3 is ContaEmpresa)
            {
                ContaEmpresa conta5 = (ContaEmpresa)conta3;
            }

            if (conta3 is ContaPoupanca)
            {
                ContaPoupanca conta5 = conta3 as ContaPoupanca;
            }
        }
    }
}
