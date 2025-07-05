using System;

class Program
{
    static void Main()
    {
        var bad = new KafkaProducerService_Bad();
        bad.Produce("leak test");
        var good = new KafkaProducerService_Good();
        good.Produce("safe test");
        good.Dispose();
        Console.WriteLine("KafkaLeakDemo executed.");
    }
}
