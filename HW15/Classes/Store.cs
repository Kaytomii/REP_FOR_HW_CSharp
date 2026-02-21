using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Classes;

public enum StoreType
{
    Food,
    Household,
    Clothes,
    Shoes
}

public class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public StoreType Type { get; set; }

    private bool disposed = false;

    public Store(string name, string address, StoreType type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} — {Address} — {Type}");
    }

    public void Dispose()
    {
        if (!disposed)
        {
            disposed = true;
            Console.WriteLine($"Dispose called for store: {Name}");
            GC.SuppressFinalize(this);
        }
    }

    ~Store()
    {
        Console.WriteLine($"Destructor called for store: {Name}");
    }
}

