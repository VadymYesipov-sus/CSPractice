using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class Profession
    {
        private string? _professionName;
        private int _salary;
        public int Salary { get; set; }
        public bool isLegal { get; set; } = true;
        public string ProfessionName
        {
            //checking for possible null or empty values
            get
            {
                if (_professionName == null)
                {
                    _professionName = "unemployed";
                    return _professionName;
                }
                else
                {
                    return _professionName;
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _professionName = value;
                }
                else
                {
                    _professionName = "no job info";
                }
            }

        }

        public Profession(int salary, string professionName)
        {
            _salary = salary;
            _professionName = professionName;
        }

        public Profession()
        {

        }


        public void ShowProfessionSalary()
        {
            //showing salary in format according to user's CurrentCulture
            Console.WriteLine("{0}'s salary is {1:c}", _professionName, Salary);
        }
    }
}
