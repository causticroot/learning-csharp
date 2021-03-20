using System;

namespace Interfaces
{    
    class Program
    {
        static void Main(string[] args)
        {
            IAcesso objAcesso = new Documento();
            objAcesso.Ler();
            objAcesso.Escrever();

            Console.ReadKey();
            
            IComprimir objComprimir = new Documento();
            objComprimir.Comprimir();
            objComprimir.Descomprimir();            
        }
    }
}
