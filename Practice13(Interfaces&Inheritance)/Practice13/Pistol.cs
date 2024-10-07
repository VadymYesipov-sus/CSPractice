using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    public class Pistol : Gun
    {
        public bool canEquipSilencer { get; set; }

        public Pistol() : base()
        {
            
        }

        public void ShootWithSilencer()
        {
            if (safety.isSafetyOn == true)
            {
                Console.WriteLine("Can't shoot. Safety is on.");
            }
            else
            {
                if (canEquipSilencer == true)
                {
                    Console.WriteLine("{0} shoots silently", GunBrand);
                }
                else
                {
                    Console.WriteLine("{0} cannot be equipped with silencer", GunBrand);
                }
            }
        }
    }
}
