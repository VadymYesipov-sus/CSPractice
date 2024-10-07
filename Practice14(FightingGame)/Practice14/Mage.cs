using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14
{
    class Mage : IFightable
    {
        public string FighterName { get; set; } = "Unnamed fighter";
        public int Health { get; set; } 
        public int MaxDamage { get; set; }
        public int MaxBlock { get; set; }
        public double Mana { get; set; }
        Random rnd = new Random();
        public Mage(string name, int health, int maxDamage, int maxBlock, double mana)
        {
            FighterName = name;
            Health = health;
            MaxDamage = maxDamage;
            MaxBlock = maxBlock;
            Mana = mana;
        }

        public void Attack(IFightable attackingFighter, IFightable defendingFighter)
        {
            int remainingHP;
            int damage = rnd.Next(1, MaxDamage);
            int block = rnd.Next(1, MaxBlock);
            int unmitigatedDamage = damage - block;
            if (unmitigatedDamage > 20) Console.WriteLine(" CRITICAL HIT!");
            if(unmitigatedDamage <= 0)
            {
                Console.WriteLine("{0} MISSES and loses 5 mana...", attackingFighter.FighterName);
                Mana -= 5.0;
            }
            else
            {
                remainingHP = defendingFighter.Health - (damage - block);
                defendingFighter.Health = remainingHP;
                Console.WriteLine("{0} attacks {1} with a staff, dealing {2} damage. {3} health remaining",
                attackingFighter.FighterName, defendingFighter.FighterName, unmitigatedDamage, remainingHP);
                Mana += 10.0;
            }
            if (Mana >= 50.0)
            {
                Fireball(defendingFighter);
            }
        }

        public void Fireball(IFightable target)
        {
                int fireballDamage = 20;
                target.Health -= fireballDamage;
                Mana -= 50.0;
                Console.WriteLine("\n {0} casts Fireball! {1} has {2} health remaining \n",
                    FighterName, target.FighterName, target.Health);
        }
    }
}
