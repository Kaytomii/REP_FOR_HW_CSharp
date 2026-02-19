using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Classes;

public class MemoryAllocator : IDisposable
{
    private object[] data;
    private bool disposed = false;

    public MemoryAllocator(int size)
    {
        data = new object[size];

        for (int i = 0; i < data.Length; i++)
            data[i] = new byte[100];
    }

    public long SimulateMemoryLoad()
    {
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < data.Length; i++)
        {
            if (i % 2 == 0)
                data[i] = new byte[200];
            else
                data[i] = null;
        }

        sw.Stop();
        return sw.ElapsedMilliseconds;
    }

    public int GetObjectGeneration(int index)
    {
        return GC.GetGeneration(data[index]);
    }

    public long ForceGC()
    {
        Stopwatch sw = Stopwatch.StartNew();

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        sw.Stop();
        return sw.ElapsedMilliseconds;
    }

    public void Dispose()
    {
        if (!disposed)
        {
            data = null;
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }



    ~MemoryAllocator()
    {
        data = null;
    }

    public static void RunTests()
    {
        MemoryAllocator allocator = new MemoryAllocator(1_000_000);

        long loadTime = allocator.SimulateMemoryLoad();
        System.Console.WriteLine("Load time: " + loadTime + " ms");

        System.Console.WriteLine("Generation before GC: " + allocator.GetObjectGeneration(0));

        long gcTime = allocator.ForceGC();
        System.Console.WriteLine("GC time: " + gcTime + " ms");

        System.Console.WriteLine("Generation after GC: " + allocator.GetObjectGeneration(0));

        allocator.Dispose();
    }

}
