using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14
{
    interface IFightable
    {
        public string FighterName { get; set; }
        public int Health { get; set; }
        public int MaxDamage { get; set; }
        public int MaxBlock { get; set; }

        public void Attack(IFightable attackingFighter, IFightable defendingFighter);
    }
}
