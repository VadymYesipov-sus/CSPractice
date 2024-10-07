using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
namespace Program
{
    class Program
    {
        
        public static void HowMany(int a, int b)
        {
            int sum = 0;    
            int[] nums = new int[5] {0, 3, 9, 15, 0};
            nums[0] = a;
            nums[4] = b;
            foreach (int x in nums) {
                if (x % 3 == 0) { 
                Console.WriteLine(x);
                    sum++;
                }
                else
                {
                    Console.WriteLine("bruh");
                }
                
            }
            Console.WriteLine("Number of divided integers: " + sum);
        }

        public static void Stringer()
        {
            string s = "";
            Console.WriteLine("write something");
            try
            {
                s = Console.ReadLine();
                char[] chars = s.ToCharArray();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0 && i != 0) { 
                    Console.Write(chars[i]);
                
                }
            }
            Console.WriteLine(s);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.ToString(), "Vi vveli nichogo");
            }

        }

        public enum Drinks
        {
            CocaCola = 1,
            Pepsi = 2,
            Fanta = 3,
            Sprite = 4
        }

        public static void Napoi(Drinks d) {
            Console.WriteLine("Vvedit napoi");
            switch (d) {
                case Drinks.CocaCola: Console.WriteLine($"{Drinks.CocaCola} kowtue 1.50");
                    break;
                case Drinks.Pepsi: Console.WriteLine($"{2} kowtue 2.50");
                    break;
                case Drinks.Fanta: Console.WriteLine($"{3} kowtue 350.50");
                    break;
                case Drinks.Sprite: Console.WriteLine($"{4} kowtuedas0d");
                    break;
                default: Console.WriteLine("problem?");
                    break;
            }
        }

        public static void Seredne()
        {
            Console.WriteLine("int 1");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int 2");
            int two = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> numbers = new[] { first, two };   
            int sternenko = Convert.ToInt32(numbers.Average());
            Console.WriteLine("seredne znachennya: " + sternenko);
        }

        public static void Summochka()
        {
            Console.WriteLine("vvedit)");
            int poro = Convert.ToInt32(Console.ReadLine());
            int[] porosad = poro.ToString().Select(o=>Convert.ToInt32(o) - 48).ToArray();
            int gorila = porosad.Sum();
            Console.WriteLine(gorila);
        }

        public static int[] Parni(int n)
        {
            if (n == 0) return new int[1] { 0 };

            Console.WriteLine("emm)");
            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);
            var arr = digits.ToArray();
            bool Parnii = arr.All(x => x % 2 == 0);

            if(Parnii == true)
            {
                Console.WriteLine("vsi parni!");
            }
            else
            {
                Console.WriteLine("ne vsi parni!");
            }


            return arr;
            

        }
        

        public static bool Bruhers(string s)
        {
            if(new[] { "a", "o", "i", "e" }.Any(c => s.Contains(c)))
            {
                Console.WriteLine("String contains these symbols");
                return true;
            }
            else
            {
                Console.WriteLine("String doesnt contain these symbols");
                return false;
            }
        }

        public static int BruhersTwo()
        {
            string haystack = "fasfsafasf";
            Console.WriteLine(haystack.Length);
            int n = haystack.Length - haystack.Replace("a", "").Length;
            Console.WriteLine(n);
            return n;
        }
        public static int BruhersThree()
        {
            string haystack = "aaooeeffbb";
            int count = haystack.Count(f => f == 'a');
            int incr = 0 + count;
            count = haystack.Count(f => f == 'e');
            incr += count;
            count = haystack.Count(f => f == 'o');
            incr += count;  
            Console.WriteLine(incr);
            return incr;
        }

        static void Main(string[] args)
        {

            //HowMany(2,6);
            //Stringer();
            //Napoi(Drinks.CocaCola);
            //Seredne();  
            //Summochka();
            //Parni(22422);
            //Bruhers("aaaoieueavasfksamfksafaa");
            BruhersThree();
        }

    }
}











