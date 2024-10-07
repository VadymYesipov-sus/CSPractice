using System.Runtime.CompilerServices;

class Program
{


    public static void AreInRange(float oneofthem, float twoofthem, float threeofthem)
    {
        
        if (oneofthem <= 5 && oneofthem >= -5)
        {
            Console.WriteLine(oneofthem + " is in range");
        }
        if (twoofthem <= 5 && twoofthem >= -5)
        {
            Console.WriteLine(twoofthem + " is in range");
        }
        if (threeofthem <= 5 && oneofthem >= -5)
        {
            Console.WriteLine(threeofthem + " is in range");
        }
        float sum = oneofthem+twoofthem+threeofthem;
    }

    public static void MinMax()
    {
        int min = 0;
        int max = 0;
        Console.WriteLine("1 int");
        int onemin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2 int");
        int twomin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3 int");
        int threemin = Convert.ToInt32(Console.ReadLine());
        if (onemin <= twomin & onemin <= threemin)
        {
            min = onemin;
        }
        if (twomin <= onemin & twomin <= threemin)
        {
            min = twomin;
        }
        if (threemin <= twomin & threemin <= onemin)
        {
            min = threemin;
        }
        if (onemin >= twomin & onemin >= threemin)
        {
            max = onemin;
        }
        if (twomin >= onemin & twomin >= threemin)
        {
            max = twomin;
        }
        if (threemin >= twomin & threemin >= onemin)
        {
            max = threemin;
        }

        Console.WriteLine("your min is: " + min);
        Console.WriteLine("your max is: " + max);
    }

    public enum HttpError {
        Error400 = 400,
        Error401 = 401,
        Error402 = 402,
        Error403 = 403,
        Error404 = 404,
        DoubleError = Error403 | Error403
    };

    public static void BloodTrail()
    {
        Console.WriteLine("Enter your error code");
        int Http = Convert.ToInt32(Console.ReadLine());
        switch (Http)
        {
            case 400:
                Console.WriteLine($"your error is {HttpError.Error400}");
                break;
            case 401:
                Console.WriteLine($"your error is {HttpError.Error401}");
                break;
            case 402:
                Console.WriteLine($"your error is {HttpError.Error402}");
                break;
            case 403:
                Console.WriteLine($"your error is {HttpError.Error403}");
                break;
            case 404:
                Console.WriteLine($"your error is {HttpError.Error404}");
                break;
        }
        if (Http >= 400 && Http <= 404)
        {
            Console.WriteLine("bruh");
        }else
        {
            throw new ArgumentOutOfRangeException("You typed wrong Error code.");
        }
    
    }

    struct MyDog
    {
        public int Age;
        public string Name;
        public string Mark;
        public string ToString(string gav){
            gav = $"{Mark} {Name} says gav";
            Console.WriteLine(gav); 
            return gav;
        }

    }


    public enum TestCase
    {
        Done,
        Failed,
        Blocked,
        Unexecuted
    }

    public void Testcase()
    {
        TestCase test1Status = TestCase.Done;
        Console.WriteLine($"Your test has this status:{test1Status}");


    }

    class Form1
    {
        
        public static Form1 It;

        public Form1()
        {
            It = this;
        }


    }
    static void Main(string[] args)
    {
        //AreInRange(4.999999F, -5.0001F, 4.22F);
        //Console.WriteLine();
        //BloodTrail();
        MyDog Sobaka = new();
        Sobaka.Name = "Dogggg";
        string govoriti = "";
        Sobaka.ToString(govoriti);
        Sobaka.Mark = "Rotveiler";
        Sobaka.ToString(govoriti);
        


    }









}




