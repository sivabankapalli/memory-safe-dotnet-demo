using System;

public interface IFakeProducer : IDisposable
{
    void Send(string msg);
}

public class FakeKafkaProducer : IFakeProducer
{
    public void Send(string msg)
    {
        // Simulate sending (no-op)
    }
    public void Dispose()
    {
        // Should clean up connections (simulated)
    }
}

// ❌ Missing Dispose
public class KafkaProducerService_Bad
{
    private readonly IFakeProducer _producer = new FakeKafkaProducer();
    public void Produce(string msg) => _producer.Send(msg);
}

// ✅ Implements IDisposable correctly
public class KafkaProducerService_Good : IDisposable
{
    private readonly IFakeProducer _producer = new FakeKafkaProducer();
    public void Produce(string msg) => _producer.Send(msg);
    public void Dispose() => _producer.Dispose();
}
