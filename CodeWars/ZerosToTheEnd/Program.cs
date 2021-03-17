using System.Collections.Generic;
using System;
using System.Linq;

namespace ZerosToTheEnd
{
    public class kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> list = arr.OfType<int>().ToList();
            int count = list.Where(x => x.Equals(0)).Count();
            list.RemoveAll(x => x.Equals(0));
            for (var i = 0; i < count; i++)
                list.Add(0);
            return list.ToArray();
            //Best practice
            // return arr.OrderBy(x => x==0).ToArray();
  
        }
    
        static void Main(string[] args)
        {
            int[] arr = MoveZeroes(new int[] {1,2,0,5,6,0,3});  
            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
                
            }
            
        }
    }
}
