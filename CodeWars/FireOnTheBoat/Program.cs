/* 
Enjoying your holiday, you head out on a scuba diving trip!

Disaster!! The boat has caught fire!!

You will be provided a string that lists many boat related 
items. If any of these items are "Fire" you must spring into 
action. Change any instance of "Fire" into "~~". Then return the string.
*/

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
            Console.WriteLine(FireFight("Boat Rudder Mast Boat Hull Water fire Boat Deck Hull fire Propeller Deck fire"));
        }
    }
}
