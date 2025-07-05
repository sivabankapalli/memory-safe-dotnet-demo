using System;

class Program
{
    static void Main()
    {
        BadDbContextUsage.StaticContext.Data.Add("static leak");
        new BadDbContextUsage().Leak();
        new GoodDbContextUsage().Use();
        Console.WriteLine("DbContextLeakDemo executed.");
    }
}
