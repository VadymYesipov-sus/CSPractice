using Practice12;
using System.Globalization;

Console.WriteLine(CitizenInfo.numberOfCitizens);
Citizen citizen = new Citizen("egor");
citizen.ShowInfo();
citizen.ApplyToJob(200, "Killer");
Citizen citizen1 = new Citizen("vlad");
citizen1.ApplyToJob(300, "woodcutter");
citizen1.ChangeSalary(-900);
citizen1.ChangeSalary(796760);
citizen1.ChangeSalary(5000);
citizen1.CitizenInfo.CitizenProfession.ShowProfessionSalary();
citizen1.ShowInfo();
//citizen.ChangeAddress();
citizen.ShowInfo();
Console.WriteLine(CitizenInfo.numberOfCitizens);
Governor governor = new Governor("Sadoviy");
governor.ChangeSalary(900);
governor.GovernorTerm = 1;
governor.ChangeSalary(900);
//sternenko.ChangeAddress();
governor.ShowInfo();


//Console.WriteLine(citizen.ToString());
//Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);
//CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
//Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);
//cInfo.CitizensProfession.ShowSalary();
Console.ReadKey();