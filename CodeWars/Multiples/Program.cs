using System;
/*
@ Mutiples_of_3_or_5
 
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
*/

public static class kata
{
    public static int Solution(int value)
    {
        int total;
        for (int i = 1; i <= value; i++)
        {
            if(i % 3 == 0 && i < value || i % 5 == 0 && i < value)
            {
                total += i;
            }
        }
        return total;
    }
}
