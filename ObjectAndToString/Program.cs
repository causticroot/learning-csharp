using System;

namespace ObjectAndToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem("Matheus", 10.0, 15.0);

            System.Console.WriteLine(p1.ToString());

            //Também funciona....
            System.Console.WriteLine(p1);
        }
    }
}
