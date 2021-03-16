using System;

namespace FireOnTheBoat
{
    public class kata
    {
        public static string FireFight(string s)
        {
            return s.Replace("Fire", "~~").Replace("fire", "~~");
        }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine(FireFight("Boat Rudder Mast Boat Hull Water fire Boat Deck Hull fire Propeller Deck fire"));
        }
    }
}
