using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        public static void fibonacci()
        {
            var numeros = new List<int> {1,1};
            var anterior = numeros[numeros.Count - 1];
            var preAnterior = numeros[numeros.Count -2];

            numeros.Add(anterior + preAnterior);

            foreach(var item in numeros)
            {
                Console.WriteLine(item);       
            }
        }
        public static void Main(string[] args)
        {
            fibonacci();
            //Criando uma lista utilizando o laço foreach
            var nomes = new List<string> {"matheus", "pedro", "julia"};
            
            //Adicionando um item na lista
            nomes.Add("bill");
            //Removendo um item da lista
            nomes.Remove("julia");
            
            //Laço foreach
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Hello {nome.ToUpper()}!");
            }
            
            //Contando uma lista
            Console.WriteLine($"A lista tem {nomes.Count} item(s)");
            
            //Manipulando através do indice
            Console.WriteLine($"O item do índice 0 é: {nomes[0]}");
            
            //Pesquisar e classificar uma lista
            var indices = nomes.IndexOf("bill");
            //Se o indexOf retornar -1 é porque o item não consta na lista
            if(indices != -1)
            {
                Console.WriteLine($"O nome {nomes[indices]} foi encontrado na posição {indices}");
                
            }

            //Ordenando uma lista
            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Hello {nome.ToUpper()}!");
            }
        }
    }
}
