using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> {"Matheus", "pedro", "julia"};
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Hello {nome.ToUpper()}!");
            }
        }
    }
}
