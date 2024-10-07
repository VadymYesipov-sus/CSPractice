class Program
{
    class Student
    {
        public delegate void MyDel(int mark);
        public event MyDel? MarkChange;

        private List<int>? marks;
        private string? name;

        public Student(string name, List<int> marks)
        {
            this.name = name;
            this.marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            if(MarkChange != null && mark >= 1 && mark <= 5)
            {    
                MarkChange(mark);
                marks?.Add(mark);
                Console.WriteLine("Amount of marks overall: " + marks?.Count);
            }
            else Console.WriteLine("invalid mark");
        }

    }

    class Parent
    {
        public Parent() { }

        public void OnMarkChange(int mark)
        {
            Console.WriteLine("Students mark is: " + mark);
        }
    }

    class Accountancy
    {

        public Accountancy() { }
        public void PayingFellowship(int mark) 
        {
            if (mark > 3 && mark <= 5) Console.WriteLine("Congrats! You will have fellowship based on mark: " + mark);
            else if (mark >= 1 && mark <= 3) Console.WriteLine("Too bad! No fellowship based on mark: " + mark);
            else Console.WriteLine("invalid mark");
        }

    }

    public static void Main(string[] args)
    {
        List<int> marks = new List<int>();
        Parent parent = new Parent();
        Student student = new Student("Petro", marks);
        student.MarkChange += parent.OnMarkChange;
        student.AddMark(2);
        student.AddMark(3);
        student.AddMark(4);
        Accountancy account = new Accountancy();
        student.MarkChange += account.PayingFellowship;
        student.AddMark(5);
        student.AddMark(2);
        student.AddMark(0);
        student.AddMark(7);

    }
   
}
