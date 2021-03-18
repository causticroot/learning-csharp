using System;

namespace InterestingStringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "A stonned DUDE A";
            
            //Formatar
            string fraseLower = frase.ToLower();
            string fraseUpper = frase.ToUpper();
            string fraseTrim = frase.Trim();

            //Buscar
            int fraseAtIndex = frase.IndexOf("DUDE");
            int fraseAtLastIndex = frase.IndexOf("A");

            //Recortar
            string subFrase = frase.Substring(2);
            string subFraseUntil = frase.Substring(2, 7);
            
            //Substituir
            string fraseReplace = frase.Replace("A", "HUE");
            string fraseReplaceChar = frase.Replace('A', 'X');

            //Null, empty, whiteSpace
            bool fraseIsNull = String.IsNullOrEmpty(frase);
            bool fraseIsNullOrWitheSpace = String.IsNullOrWhiteSpace(frase);
        }
    }
}
