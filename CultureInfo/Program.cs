using System;
using System.Globalization; //Responsável

namespace Culture
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorErrado = double.Parse(Console.ReadLine());
            System.Console.WriteLine(valorErrado);
            
            double valorCerto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine(valorCerto);
            
        }
    }
}
