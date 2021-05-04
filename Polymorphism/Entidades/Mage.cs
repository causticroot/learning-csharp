namespace Polymorphism.Entidades
{
    public class Mage
    {
        public Mage(int life, int mana)
        {
            Life = life;
            Mana = mana;
        }

        public int Life { get; set; }
        public int Mana { get; set; }

        public virtual void Healing(int amount)
        {
            Life += amount;
        }
    }
}

