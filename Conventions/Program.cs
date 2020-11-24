using System;

namespace Conventions {
    class Program {
            /*
             * Code conventions (somethings)
             */

            // 1- Adicione uma linha em branco entre as definições de método e de propriedade <<<
            string nome;
            // ***
            public void mudarNome (string nome) 
            {
                this.nome = nome;
            }

        static void Main (string[] args) 
        {
           

            // 2- Use parênteses para criar cláusulas em uma expressão aparente <<<
            //  if((2 > 1) && (3 > 2))
            //  {
            //      //TODO:
            //  }

            // 3- Colocar o comentário em uma linha separada <<<
            //Errado:
            int exemploErrado () //Essa função retorna o X
            {
                int x = 0;
                return x;
            }

            //Certo:
            //A função abaixo retorna x
            int exemploCerto () 
            {
                int x = 0;
                //Abaixo segue X
                return x;
            }

            // 4- Utilizar string interpolation para concatenar strings curtas <<<
            string nome = "Matheus";
            var date = DateTime.Now;
            //String interpolation    
            Console.WriteLine ($"Hello, {nome}! Hoje é {date.DayOfWeek}.");

            // 5- Para acrescentar Strings em loops, use o objeto **StringBuilder** <<<
            var frase = "kakakakakakakakakakakakak";
            //Caso não use "using System.Text;", segue abaixo
            var maisFrase = new System.Text.StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                maisFrase.Append(frase);
            }
            //Console.WriteLine(maisFrase);

            // 6- Só usar digitação implicita para variáveis locais quando o tipo for óbvio no valor <<<
            var var1 = "Texto";
            var var2 = 10;

            // 7- Não utilizar digitação implicita para determinar uma variável de loop em um foreach <<<
            // foreach (int i(Não pode ser 'var i') in laugh) 
            // {

            // }

            // 8- Em geral, utilize int ao invés de tipos sem assinatura <<<


        }

    }

}