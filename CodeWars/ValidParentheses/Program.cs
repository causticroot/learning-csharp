
using System.Collections;
using System.Collections.Generic;
using System;

namespace ValidParentheses
{
    public class kata
    {
        public static bool ValidParentheses(string input)
        {
            var aux = 0;
            ArrayList arr = new ArrayList(input.ToCharArray()); 
            
            

            if ( !String.IsNullOrEmpty(arr.ToString()) )
            {
                foreach (var item in arr)
                {
                    System.Console.WriteLine(item);
                    if (item.Equals('('))
                    {
                        aux++;
                    }else if (item.Equals(')'))
                    {
                        aux--;
                    }
                }    
            }else
            {
                return true;
            }
            return (aux == 0);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(ValidParentheses("(( aaa ))"));
            
            
            //System.Console.WriteLine((aux == 0));
           

            // foreach (var item in arr)
            // {
            //     System.Console.WriteLine(item);
            // }

            // if(inputList.FindLast.Equals(')') && inputList.FindIndex(0).Equals('('))
            // {
            //     state = true;
            // }else
            // {
            //     state = false;
            // }

            // System.Console.WriteLine(state);

        }
    }

    
}
