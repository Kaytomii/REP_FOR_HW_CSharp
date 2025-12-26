using HW8_26_12.Abstract_Class;
using HW8_26_12.Interface;

namespace HW8_26_12.Models;

public class Printer : OfficeDevice, IPrintable
{
    public Printer(string name) : base(name) { }

    public void Print()
    {
        if (IsOn)
            Console.WriteLine($"{Name} is print...");
        else
            Console.WriteLine($"{Name} is off");
    }
}
