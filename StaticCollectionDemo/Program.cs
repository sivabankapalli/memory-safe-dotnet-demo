using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
            StaticMemoryBloat.AddBloat();
        Console.WriteLine("StaticCollectionDemo executed.");
    }
}
