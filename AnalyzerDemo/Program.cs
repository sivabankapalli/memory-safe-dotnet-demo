using System;

class Program
{
    static void Main()
    {
        var demo = new AnalyzerDemo();
        demo.CA2000_Example();
        demo.CA1825_Example();
        demo.CS0168_Example();
        demo.ASYNC0001_Example().Wait();
        demo.ASYNC0005_Example().Wait();
        demo.CA2012_Example().Wait();
        Console.WriteLine("AnalyzerDemo executed.");
    }
}
