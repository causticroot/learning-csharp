using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Nome = "Feijão";
            produto.Preco = 4.99;
            produto.Quantidade = 1;

            System.Console.WriteLine("Nome: {0} | Preço: {1} | Quantidade: {2} ", produto.Nome, produto.Preco, produto.Quantidade);
        }
    }
}
