using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    public class Gun : IShootable
    {
        protected Safety safety = new Safety();
        private string? _ammoType;
        private int _fireRate;
        public string GunBrand { get; set; }
        public string AmmoType {
            get { 
                if (_ammoType == null)
                {
                    Console.WriteLine("ammo type is null");
                    return null;
                }
                else
                {
                    return _ammoType;
                }
            }
            set { _ammoType = value; } 
        }
        public int FireRate { 
            get { return _fireRate; }
            set { _fireRate = FireRate; }
        }

        public Gun(string gunBrand = "no brand", string ammoType = "no ammo type", int fireRate = 0)
        {
            GunBrand = gunBrand;
            AmmoType = ammoType;
            FireRate = fireRate;
        }

        public void Shoot()
        {
            if(safety.isSafetyOn == true)
            {
                Console.WriteLine("Can't shoot. Safety is on.");
            }
            else
            {
                Console.WriteLine("{0} shoots with {1} bullets at {2} Round per Minute", GunBrand, AmmoType, FireRate);
            }
        }

        public void ToggleSafety()
        {
            if( safety.isSafetyOn == true)
            {
                safety.Off();
            }
            else
            {
                safety.On();
            }
        }
    }
}
