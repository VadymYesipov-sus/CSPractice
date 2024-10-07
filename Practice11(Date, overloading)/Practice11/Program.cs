using System.Drawing;

class Program
{
    class Car
    {
        string name;
        string color;
        int price;
        const string CompanyName = "Toyota";

        public static bool operator == (Car first, Car second)
        {
            return first.name == second.name && first.price == second.price;
        }
        public static bool operator != (Car first, Car second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            return Print().ToString();
        }


        public Car()
        {
            name = "Unnamed Car";
            price = 0;
            color = "No Color";
        }

        public Car(string name, string color, int price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public void Input()
        {
            Console.WriteLine("enter name");
            string x = Console.ReadLine().ToString();
            Console.WriteLine("enter color");
            string y = Console.ReadLine().ToString();
            Console.WriteLine("enter price");
            int z = Convert.ToInt32(Console.ReadLine());

            Car bruh = new Car(x, y, z);
            Console.WriteLine($"new car added:{x},{y},{z} ");
        }

        public string Print()
        {
            string a = $"Name: {name}, price: {price}, color: {color}";
            Console.WriteLine(a);
            return a;
        }

        public double ChangePrice(double x)
        {
            if (x > 0)
            {
                double increase = price * (x / 100);
                double newprice = price + increase;
                price = Convert.ToInt32(newprice);
                Console.WriteLine(newprice);
                return newprice;
            }
            else if (x < 0)
            {
                double decrease = price * (-x / 100);
                double newprice = price - decrease;
                price = Convert.ToInt32(newprice);
                Console.WriteLine(newprice);
                return newprice;
            }
            else
            {
                Console.WriteLine(price);
                return price;
            }


        }

        
    }

    class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name { get { return this.name; } }
        public DateTime BirthYear { get { return this.birthYear; } }

        public Person()
        {
            name = "no name";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public void Input()
        {
            Person person = new Person();
            DateTime newBirthYear;
            
            Console.Write("Enter name: ");
            person.name = Console.ReadLine();

            Console.Write("Enter birth year (e.g., 01.01.1990): ");
            while (!DateTime.TryParse(Console.ReadLine(), out newBirthYear))
            {
                Console.Write("Invalid input. Enter a valid year (e.g., 01.01.1990): ");
            }

            person.birthYear = newBirthYear;


            Console.WriteLine($"\nPerson Information:");
            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Birth Year: {person.birthYear.Year}");
        }

        public void Age()
        {
            int age = DateTime.Now.Year - birthYear.Year;
            Console.WriteLine($"{name} is {age} years old.");
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("helo");
        //Car car = new Car();
        //car.Input();
        /* Car car1 = new Car("v","v", 200);
        car1.Print();
        car1.ChangePrice(20);
        car1.Print();
        car1.ChangePrice(-20);
        car1.Print();
        car1.Color = "red";
        car1.Print();
        car1.ToString();
        Car car2 = new Car("v", "v", 192);
        if (car1 == car2) Console.WriteLine("cars are same");
        Console.ReadLine();  */
        DateTime DT = new DateTime(2000,10,10);
        Person person = new Person("vadym", DT);
        //Console.WriteLine(person.Name + person.BirthYear);
        //person.Input();
        Console.WriteLine(person.Name + person.BirthYear);
        person.Age();
        person.ChangeName("petro");
        Console.WriteLine(person.Name + person.BirthYear);
    }
}



