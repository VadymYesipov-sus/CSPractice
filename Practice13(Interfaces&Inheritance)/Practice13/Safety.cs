using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    public class Safety : ICommand
    {
        public bool isSafetyOn { get; set; } = true;

        public void Off()
        {
            isSafetyOn = false;
            Console.WriteLine("Safety is off. You can shoot");
        }

        public void On()
        {
            isSafetyOn = true;
            Console.WriteLine("Safety is on. You can't shoot");
        }
    }
}
