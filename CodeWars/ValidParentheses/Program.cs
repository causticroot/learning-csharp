/*
Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. 
The function should return true if the string is valid, and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters. Furthermore,
the input string may be empty and/or not contain any parentheses at all. Do not treat other forms of brackets
as parentheses (e.g. [], {}, <>).
*/
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
            Console.WriteLine(ValidParentheses("(( aaa ))"));
        }
    }

    
}
