
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Net.Cache;
using System.Text.RegularExpressions;


class Program
{







    public static void Main(string[] args)
    {
        /*ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do
        {
            cki = Console.ReadKey();
            Console.Write(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);
        */
        /*string s = "adsk45oadaks sksksk epk2rapkrsksk ss";
        Regex regex = new Regex("[bbb]");
        MatchCollection matches = regex.Matches(s);
        int num = 0;
        if (matches.Count >0){

            foreach (Match match in matches) {
                num++;
                Console.WriteLine($"Found {num} match(es)! " + match.Value);

            }

        }
        else {
            Console.WriteLine("spivpadin nema");
        }

        string es = "heoheohke";
        char c = 'o';
        int i = es.WordCount(c);
        Console.WriteLine(i);

        var per = new { Name = "Tom", Age = 20, Occupation = "mac" };
        Console.WriteLine(per.GetType().Name); */

        int[] numbers = new int  [] { 1, 2, -3, -4, -5, 200, -999};
        Show(numbers);


    }
    public static int[] Show(int[] numbers)
    {
        int[] negative = new int [0];
        int[] positive = new int[0];
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                negative = negative
                    .Concat(new int[] {number})
                    .OrderBy(number => number)
                    .ToArray();
            }else
            {
                positive = positive
                    .Concat(new int[] { number })
                    .OrderBy(number => number)
                    .ToArray();
            }

            
        }

        var large = numbers.First(number => number > numbers.Average());
        var small = numbers.First(number => number < numbers.Average());
        int min = numbers.Min();
        int max = numbers.Max();
        int sum = numbers.Sum();
        Console.WriteLine("first element larger than Average of elements in array: " + large);
        Console.WriteLine("first element smaller than Average of elements in array: " + small);
        Console.WriteLine("Array line : " + string.Join(",", negative));
        Console.WriteLine("Array line : " + string.Join(",", positive));
        Console.WriteLine("Min, max, sum of array: " + min + ',' + max + ',' + sum);
        return negative;
    }





}

public static class StringExtension
{
    public static int WordCount(this string s, char c)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == c)
            {
                count++;
            }
        }
        return count;
    }


}
