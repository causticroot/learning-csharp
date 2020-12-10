namespace Console
{
    //A referência de system funciona dentro do namespace
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            string str;

            //Escreve no console sem retorno de carro
            Console.WriteLine("Digite algo e tecle <Enter>: ");
            
            //Lê uma string do console
            str = Console.ReadLine();

            //Escreve no console sem retorno de carro
            Console.WriteLine("Digite uma letra e tecle <Enter>: ");
            
            //Lê um caractere
            str = Console.ReadLine();

            //Imprime uma linha em branco
            Console.WriteLine();
        }
    }
}
