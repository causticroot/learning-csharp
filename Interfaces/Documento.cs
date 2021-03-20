using System;

namespace Interfaces
{
    //Herança de interface, herança mutiplas
    public class Documento : IAcesso, IComprimir
    {
        // IComprimir
        public void Comprimir()
        {
            Console.WriteLine("Executando a função comprimir");
        }

        public void Descomprimir()
        {
            Console.WriteLine("Executando a função descomprimir");
        }

        //IAcesso
        public void Escrever()
        {
            Console.WriteLine("Executando a função escrever");
        }

        public void Ler()
        {
            Console.WriteLine("Executando a função ler");
        }
    }
}