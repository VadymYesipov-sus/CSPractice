using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class Citizen
    {
        protected readonly string _citizenName;
        public CitizenInfo CitizenInfo { get; set; } = new CitizenInfo();

        public Citizen(string citizenName)
        {
            _citizenName = citizenName;
            CitizenInfo.numberOfCitizens++;
        }

        public void ChangeAddress()
        {
            bool isAddressValid = false;
            
            // check if address was entered correctly.
            // if not, sending message and letting user write down address again until format is correct.
            while (!isAddressValid)
            {
                Console.WriteLine("Please enter your address");
                string? address = Convert.ToString(Console.ReadLine());

                if (string.IsNullOrWhiteSpace(address))
                {
                    Console.WriteLine("address cannot be null or empty");
                }
                else if (address.Length < 3)
                {
                    Console.WriteLine("address must contain at least 3 characters");
                }
                else
                {
                    isAddressValid = true;
                    CitizenInfo.CitizenAddress = address;
                }
            }
        }

        public void ApplyToJob(int salary, string jobName)
        {
            Profession newJob = new Profession(salary, jobName);
            // check if job is legal by comparing its name to the names of most popular criminal activities
            bool isCriminalWork = new[] { "killer", "robber", "smuggler" }
            .Any(s => jobName.ToLower().Contains(s));
            if (isCriminalWork)
            {
                newJob.isLegal = false;
            }
            CitizenInfo.CitizenProfession = newJob;
        }

        public virtual void ChangeSalary(int newSalary)
        {
            // setting up restrictions for possible changes to salaries
            if (newSalary <= 0)
            {
                Console.WriteLine("Can't have negative or no salary");
            }else if (newSalary > 10000)
            {
                Console.WriteLine("be reasonable!!!");
            }
            else
            {
                CitizenInfo.CitizenProfession.Salary = newSalary;
            }
        }

        public virtual void ShowInfo()
        {
            //showing information about the citizen.
            Console.WriteLine("Name: {0} \n ID: {1} \n Profession: {2} \n Address: {3}",
                _citizenName, CitizenInfo.CitizenID, 
                CitizenInfo.CitizenProfession.ProfessionName, CitizenInfo.CitizenAddress);
        }

    }
}
