using System;

namespace Polymorphism.Entidades
{
    public class ArcaneMage : Mage
    {
        public ArcaneMage(int arcaneBonus, int life, int mana) : base(life, mana)
        {
            ArcaneBonus = arcaneBonus;
        }

        public int ArcaneBonus { get; set; }
        
        public override void Healing(int amount)
        {
            base.Healing(amount);
            Mana += amount + ArcaneBonus;
        }
    }
}