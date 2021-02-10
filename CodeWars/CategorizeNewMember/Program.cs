using System.Collections.Generic;
using System;

namespace CategorizeNewMember
{
    public class Kata
    {   
        public static List<string> OpenOrSenior(int[][] data)
        {
            List<string> categoria = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    int idade = data[i][j] ;
                    int handicap = data[i][(j + 1)];
                    if(idade >= 55 && handicap > 7)
                    {
                        categoria.Add("Senior");
                    }else
                    {
                        categoria.Add("Open");
                    }
                }
            }
            return categoria;
        }

        static void Main(string[] args)
        {
            foreach (var item in OpenOrSenior(new int[][] {new int[] {18, 20}, new int[] {45, 2}, new int[] {61, 12}, new int[] {37, 6}, new int[] {21, 21}, new int[] {78, 9}}))
            {
                System.Console.WriteLine(item);
            }
        }
    }

}
