using System;

namespace ConditionalTernary
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            //             condição     if true       if false
            string type = (age >= 18) ? "Cara homi" : "Guri";
            Console.WriteLine($"{type}");
        }
    }
}
