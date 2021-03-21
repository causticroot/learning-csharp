using System;
using Enums;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // O método enum.getnames requer que seja passado
            // o tipo enum como parâmetro, fazemos isso com o typeof 
            foreach (var item in Enum.GetNames(typeof(DiasUteis)))
            {
                Console.WriteLine($"{item}");
                
            }
        }
    }
}
