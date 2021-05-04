using System;
using Polymorphism.Entidades;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage kaelThas = new Mage(190, 200);
            Mage hadggar = new ArcaneMage(3, 190, 200);

            kaelThas.Healing(35);
            hadggar.Healing(35);

            Console.WriteLine($"kaelthas - |life {kaelThas.Life}|mana {kaelThas.Mana}");
            Console.WriteLine($"hadggar - |life {hadggar.Life}|mana {hadggar.Mana}");
        }
    }
}
