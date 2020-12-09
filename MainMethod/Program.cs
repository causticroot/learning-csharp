using System;

namespace MainMethod
{
    //Classe que define o método main
    class Program 
    {
        /*
        Todo programa C# deve ter uma classe que defina o método Main( ), que deve
        ser declarado como estático usando o modificador static, que diz ao runtime
        que o método pode ser chamado sem que a classe seja instanciada
        */

        // Main recebe parâmetros na linha de comando via o array
        // args
        static void Main(string[] args)
        {
            System.Console.WriteLine("Main da class Program");
        }
    }
        /*
        A forma do método Main( ) a ser usada vai depender dos seguintes fatores:
        
        * O programa vai receber parâmetros na linha de comando? Então esses parâmetros serão 
        armazenados no array args.
        
        * Quando o programa é finalizado, é necessário retornar algum valor ao sistema? Então
        o valor de retorno será do tipo int.
        */
    class ProgramAux
    {
        static int Main()
        {
            System.Console.WriteLine("Main da class ProgramAux");
            return 0;
        }
    }

        /*
        Um programa escrito em C# pode ter mais de uma classe que implementa o
        método Main( ). Nesse caso, deverá ser especificado em tempo de compilação
        em qual classe se encontra o método Main( ), que deverá ser chamado pelo runtime quando
        a aplicação for executada
        */
}   
