using Practice15;
using System.Collections;



Animal<int> animal = new Animal<int>();
Console.WriteLine(animal.getToString(200));

List<int> numList = new List<int>{1,2,3,2,2,2,3,3};
var lList = numList
    .GroupBy(c => c)
    .Where(x => x.Count() > 1)
    .Select(g => new { Character = g.Key, Count = g.Count() })
    .ToList();
foreach (var item in lList) Console.WriteLine($"Character '{item.Character}' occurs {item.Count} times"); ;

Random random = new Random();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(random.Next(1, 3)); //it appear range from 1 to 3 is actually (1-2) O_O
}

Apples apples = new Apples();
apples[0] = new Apple("Red apple");
apples[1] = new Apple("Green apple");
apples[2] = new Apple("Blue apple");
apples[3] = new Apple("Yellow apple");
foreach (Apple apple in apples)
{
    Console.WriteLine(apple.Name);
}
int a = apples.Count;
Console.WriteLine(a);

AppleBox box = new AppleBox(1, 1, 1, apples[1]);
AppleBox box2 = new AppleBox(1, 1 , 1, apples[2]);
AppleBox box3 = box + box2;
Console.WriteLine(box3.Apple.Name);
Console.WriteLine(box3.ToString());
Console.WriteLine(box3);
Console.WriteLine((int)box3);

var appleShop = new { Name = "shop", Wares = "apples" };
Console.WriteLine(appleShop.Name + appleShop.Wares);

var appleShopsArray = new[]
{
    new
    {
        Name = "apple in array",
        Wares = "apples"
    },
    new
    {
        Name = "apple two in array",
        Wares = "apples two"
    }
};
foreach (var item in appleShopsArray)
{
    Console.WriteLine("{0} is shops name, {1} is their wares",
        item.Name, item.Wares);
}

List<Apple> appleList = new List<Apple>();
appleList.Add(new Apple("apple"));
appleList.Add(new Apple("zapple2"));
appleList.Add(new Apple("gapple3"));
Apples applesTwo = new Apples(appleList);

var applesSorted = from apple in applesTwo
                   orderby apple.Name
                   select apple;

foreach (var item in applesSorted)
{
    Console.WriteLine("{0}", item.Name);
}



public struct Animal<T>
{
    public T Value { get; set; }

    public string getToString<T>(T gragas)
    {
        string d = Convert.ToString(gragas);
        if (d != null)
        {
            return d;
        }
        else
        {
            return "meh";
        }
    }
} 