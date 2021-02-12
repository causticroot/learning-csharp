using System.Text;
using System.Text.RegularExpressions;
using System;
/*
Gordon Ramsay shouts. He shouts and swears. There may be something wrong with him.

Anyway, you will be given a string of four words. Your job is to turn them in to Gordon language.

Rules:

Obviously the words should be Caps, Every word should end with '!!!!', Any letter 'a' or 'A'
should become '@', Any other vowel should become '*'.
*/
namespace HellsKitchen
{
    public class Kata
    {
        public static string Gordon(string a)
        {
            StringBuilder frase = new StringBuilder(a);
            frase.Replace("a", "@")
                .Replace("e", "*")
                .Replace("i", "*")
                .Replace("o", "*")
                .Replace("u", "*")
                .Replace(" ", "!!!! ");
            string fraseNova = string.Format("{0}!!!!", frase).ToUpper();
            return fraseNova;
            
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Gordon("i am a chef"));
        }
    }
}
