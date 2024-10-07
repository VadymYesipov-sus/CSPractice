using System.ComponentModel.Design;

class Program
{
    public static int Divide(int a, int b)
    {
        int div;
        try
        {
            div = a / b;
            Console.WriteLine(div);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
        return div;

    }

    public static int ReadNumber(int start, int end)
    {
        Console.WriteLine($"enter integer in range from {start} to {end}");
        int num;

        num = Convert.ToInt32(Console.ReadLine());


        if (num < start || num > end) 
            throw new ArgumentOutOfRangeException(num.ToString(), $"the range must be from {start} to {end}");
        if (num.GetType() != typeof(int))
            throw new FormatException(nameof(num));


        return num;
    }


    public static void Main(String[] args)
    {
        /* Console.WriteLine("enter 2 ints");
        int a;
        int b;
        try
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a.GetTypeCode() == TypeCode.Double || b.GetTypeCode() == TypeCode.Double)
            {
                throw new Exception("cant be double");
            }
            Divide(a, b);
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: {e.Message}");
        }
        Console.ReadLine(); */
        try
        {
            int[] ints = new int[5];

            for (int i = 0; i < 5; i++)
            {
                ints[i] = ReadNumber(10, 2000);

            }
            Console.WriteLine("Your array: " + string.Join(",", ints));
        }
        catch (ArgumentOutOfRangeException e) 
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }


}



    

}