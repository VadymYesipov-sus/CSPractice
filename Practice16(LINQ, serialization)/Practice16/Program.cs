using Practice16;
using System.Runtime.Serialization.Formatters.Binary;

Thread t = new Thread(Print1);
t.Start();
for (int i = 0; i < 100; i++)
{
    Console.Write(0);
}

static void Print1()
{
    for(int i = 0; i < 100; i++)
    {
        Console.Write(1);
    }
}



static int[] QueryIntArray()
{
    int[] nums = { 5, 10, 15, 20, 25, 30, 100 };

    var gt20 = from num in nums
               where num > 20
               orderby num
               select num;

    foreach ( var num in gt20)
    {
        Console.WriteLine(num);
    }
    Console.WriteLine($"Get Type: {gt20.GetType()}");

    var listGT20 = gt20.ToList<int>();
    var arrayGT20 = gt20.ToArray();

    nums[0] = 40;
    foreach (var num in gt20)
    {
        Console.WriteLine(num);
    }

    return arrayGT20;
}

int[] intArray = QueryIntArray();
foreach (int num in intArray)
{
    Console.WriteLine(num);
}


Animal lion  = new Animal("tiger", 40, 200, 1);
Stream stream = File.Open("AnimalData.dat", FileMode.Create);
#pragma warning disable SYSLIB0011
BinaryFormatter bf = new BinaryFormatter();
bf.Serialize(stream, lion);
stream.Close();

lion = null; // deleting data

stream = File.Open("AnimalData.dat", FileMode.Open);
bf = new BinaryFormatter();


lion = (Animal)bf.Deserialize(stream);
#pragma warning restore SYSLIB0011
stream.Close();

Console.WriteLine(lion.ToString());


//string[] dogs = { "K 9", "Snuffy", "Brian Griffin" };

//var dogSpaces = from dog in dogs
//                where dog.Contains(" ")
//                orderby dog descending
//                select dog;

//foreach (var dog in dogSpaces)
//{
//    Console.WriteLine(dog);
//}
