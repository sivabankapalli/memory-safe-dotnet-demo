using System.Collections.Generic;

public static class StaticMemoryBloat
{
    // ❌ Grows forever
    public static List<byte[]> Bloat = new();
    public static void AddBloat()
    {
        Bloat.Add(new byte[1024 * 1024]); // 1MB per call
    }
}
