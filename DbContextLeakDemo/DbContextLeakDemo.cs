using System;
using System.Collections.Generic;

public class FakeDbContext : IDisposable
{
    public List<string> Data = new();
    public void Dispose() { }
}

public class BadDbContextUsage
{
    // ❌ Static DbContext (memory leak)
    public static FakeDbContext StaticContext = new();
    // ❌ Not disposed
    public void Leak()
    {
        var db = new FakeDbContext();
        db.Data.Add("test");
    }
}

public class GoodDbContextUsage
{
    public void Use()
    {
        using var db = new FakeDbContext();
        db.Data.Add("test");
    }
}
