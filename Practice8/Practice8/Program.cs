class Program
{
    public static void Main(string[] args)
    {

        double time = IManageable.GetTime(100, 10);
        Console.WriteLine(time);
        Person person = new Person("vasyl");
        Car car = new Car();
        ((IManageable)person).Run();
        car.Run();
        Data<Person> storedata = new Data<Person>();
        storedata.id = person;
        ((IManageable)storedata.id).Run();
        Console.WriteLine(storedata.id.Name);

        int frfr = 4;
        int npnp = 5;
        Swap<int>(ref frfr, ref npnp);
        Console.WriteLine("{0} {1}", frfr, npnp);

    }




    static void Swap<T>(ref T input1, ref T input2)
    {
        T temp = default(T);

        temp = input2;
        input2 = input1;
        input1 = temp;

    }
}



public class Data<T> where T : Person
{
    public T id;
}
public class Person : IManageable
{
    private string name;
    public Person(string name) { this.name = name; }

    public string Name {  get { return name; } }
}

class Car : IManageable
{
    public void Run()
    {
        Console.WriteLine("im a car");
    }
}

interface IManageable
{
    const int speed = 20;

    static double GetTime(double distance, double speed) { return distance / speed; }

    string Name { get { return "name"; } }

    void Run()
    {
        Console.WriteLine("i run");
    }

}
