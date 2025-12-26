using HW8_26_12.Abstract_Class;
using HW8_26_12.Interface;

namespace HW8_26_12.Models;

public class Mfu : OfficeDevice, IPrintable, IScannable, ICopyable
{
    public Mfu(string name) : base(name) { }

    public void Print()
    {
        if (IsOn)
            Console.WriteLine($"{Name} is print...");
        else
            Console.WriteLine($"{Name} is off");
    }

    public void Scan()
    {
        if (IsOn)
            Console.WriteLine($"{Name} scanning...");
        else
            Console.WriteLine($"{Name} is off");
    }

    public void Copy()
    {
        if (IsOn)
            Console.WriteLine($"{Name} coping...");
        else
            Console.WriteLine($"{Name} is off");
    }
}
