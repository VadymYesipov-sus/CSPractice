using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14
{
    class Warrior : IFightable
    {
        public string FighterName { get; set; } = "Unnamed fighter";
        public int Health { get; set; }
        public int MaxDamage { get; set; }
        public int MaxBlock { get; set; }
        Random rnd = new Random();

        public Warrior(string name, int health, int maxDamage, int maxBlock)
        {
            FighterName = name;
            Health = health;
            MaxDamage = maxDamage;
            MaxBlock = maxBlock;
        }
        public void Attack(IFightable attackingFighter, IFightable defendingFighter)
        {
            int remainingHP;
            int damage = rnd.Next(1, MaxDamage);
            int block = rnd.Next(1, MaxBlock);
            int unmitigatedDamage = damage - block;
            if (unmitigatedDamage > 20) Console.WriteLine("\n CRITICAL HIT!");
            if (unmitigatedDamage <= 0)
            {
                Console.WriteLine("{0} MISSES...", attackingFighter.FighterName);
            }
            else
            {
                remainingHP = defendingFighter.Health - (damage - block);
                defendingFighter.Health = remainingHP;
                Console.WriteLine("{0} attacks {1} with a staff, dealing {2} damage. {3} health remaining",
                attackingFighter.FighterName, defendingFighter.FighterName, unmitigatedDamage, remainingHP);
            }
        }
    }
}
