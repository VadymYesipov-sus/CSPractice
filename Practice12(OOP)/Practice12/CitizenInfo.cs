using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class CitizenInfo
    {
        public static int numberOfCitizens;
        public Profession CitizenProfession { get; set; } = new Profession();
        public int CitizenID { get; set; } 
        public string CitizenAddress { get; set; } = "No address";
        Random rand = new Random();
        
        public CitizenInfo()
        {
            //to give everyone different IDs we are using random
            //(with very slight possibility of getting same ID multiple times)
            CitizenID = rand.Next(1, 234925389);
        }

    }
}
