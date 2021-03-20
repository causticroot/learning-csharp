using System;

namespace StructType
{
    class Program
    {
        static void Main(string[] args)
        {
            RetanguloStruct retangulo = new RetanguloStruct(3.0, 4.2);//Armazenado na memória stack
            Console.WriteLine($"Área: {retangulo.AreaDoRetangulo().ToString("F2")}");
        }
    }
}
