using System;

namespace NullableValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null;
            /*
            CS0037: Não é possível converter o valor nulo em 'double'
            porque ele não é um tipo de valor não anulável
            */

            Nullable<double> x = null;
            double? y = null;
            double? z = 5.32;
            
            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());
            System.Console.WriteLine(z.GetValueOrDefault());

            System.Console.WriteLine("Tem um valor: {0}", y.HasValue);
            System.Console.WriteLine("Tem um valor: {0}", z.HasValue);
        }
    }
}
