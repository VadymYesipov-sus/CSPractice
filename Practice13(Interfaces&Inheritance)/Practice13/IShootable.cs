using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    internal interface IShootable
    {
        public string AmmoType { get; set; }
        public int FireRate { get; set; }
        void Shoot();
        void ToggleSafety();
    }
}
