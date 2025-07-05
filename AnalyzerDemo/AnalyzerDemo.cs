using System;
using System.IO;
using System.Threading.Tasks;

public class AnalyzerDemo
{
    public void CA2000_Example()
    {
        var ms = new MemoryStream(); // No using, triggers CA2000
    }
    class BadDisposable : IDisposable
    {
        private readonly MemoryStream _stream = new();
        public void Dispose() { }
    }
    class HasFinalizer : IDisposable
    {
        ~HasFinalizer() { }
        public void Dispose() { }
    }
    public async Task ASYNC0001_Example()
    {
        SomeAsync();
        await Task.CompletedTask;
    }
    public async Task ASYNC0005_Example()
    {
        var ms = new MemoryStream();
        ms.DisposeAsync();
        await Task.CompletedTask;
    }
    public Task CA2012_Example() => Task.Delay(1);
    public void CA1825_Example() { string[] arr = new string[0]; }
    public void CS0168_Example() { int unusedVar; }
    public Task SomeAsync() => Task.CompletedTask;
}
