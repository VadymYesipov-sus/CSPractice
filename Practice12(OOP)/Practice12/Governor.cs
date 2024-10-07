using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    class Governor : Citizen
    {
        private int _governorTerm;
        public int GovernorTerm {
            get 
            {
                return _governorTerm;
            } 
            set
            {
                if (_governorTerm < 0)
                {
                    Console.WriteLine("term cannot be less than 1 year");
                }
                else
                {
                    _governorTerm = value;
                }
            }
        }

        public Governor(string citizenName) : base(citizenName)
        {
            CitizenInfo.CitizenProfession = new Profession(0, "governor");
        }

        public override void ChangeSalary(int newSalary)
        {
            if (_governorTerm == 0)
            {
                Console.WriteLine("Can't change salary during probation period!!!");
            }else
            {
                base.ChangeSalary(newSalary);
            }
        }

        public override void ShowInfo()
        {
            //showing information about the governor. Added information about governor's occupation
            base.ShowInfo();
            Console.WriteLine("{0} is governor of {1}", _citizenName, CitizenInfo.CitizenAddress);
        }
    }
}
