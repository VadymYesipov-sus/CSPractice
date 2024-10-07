using System.Linq;
using System.Runtime.CompilerServices;
using static Program;

class Program
{
    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        virtual public string Name { get { return name; } }

        virtual public string Subject { get { return name; } }

        virtual public void Print()
        {
         
        }
    }

    public class Staff : Person
    {

        public Staff(string name) : base(name)
        {

        }

        override public string Name { get { return base.Name;  }}

        

        override public void Print()
        {
            Console.WriteLine("{0} ", Name + "\n");

        }

    }

    public class Teacher : Staff
    {
        private string subject;

        override public string Subject {  get { return subject; } }

        public Teacher(string name, string subject) : base(name) { this.subject = subject; }


        override public string Name { get { return base.Name; } }
        override public void Print()
        {
            Console.WriteLine("{0} leads the subject {1}", Name, this.subject + "\n");

        }

    }

    public class Developer : Staff
    {
        private int level;

        public Developer(string name, int level) : base(name)
        { this.level = level; }

        override public string Name { get { return base.Name; } }
        override public void Print()
        {
            Console.WriteLine("{0} who has level {1}", Name, this.level + "\n");

        }

    }
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person("Vadym"));
        people.Add(new Teacher("Vlad", "biology"));
        people.Add(new Developer("Nazar", 2));
        people.Add(new Staff("Michael"));
        people.OrderBy(person => person.Name).ToList();

        List<Teacher> teachers = new List<Teacher>(); 

        foreach (var person in people)
        {
            var selected = people.Where(person => person.Subject.Equals("biology")).ToList();
            teachers.AddRange(selected);




        }

    }

}
