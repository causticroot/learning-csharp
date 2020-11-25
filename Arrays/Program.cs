using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um objeto da classe base System.Array é instanciado quando inicializamos um array
            //Array inicializado
            int[] a = new int[5];
            int[] b = new int[5] {1, 2, 3, 4, 5};
            int[] c = new int[] {1, 2, 6, 3, 6};
            int[] d = {5, 4, 3, 2, 1};
            //Array não inicializado
            int[] y;

            //Array multidimensional (matrix)
            // Um virgula para cada dimensão
            int[,] matriz = new int[2, 1];
            int[,] matrix = new int[2, 2] 
            {
                {11, 12},
                {21, 22}
            };
            //Tridimensional
            int[,,] matrizTridimensional;

            //Arrays irregulares ou Jagged array
            char[][] caracteres = new char[3][];
            caracteres[0] = new char[2] {'a', 'b'};
            caracteres[1] = new char[1] {'c'};
            caracteres[2] = new char[3] {'d', 'e', 'f'};
        }
    }
}
