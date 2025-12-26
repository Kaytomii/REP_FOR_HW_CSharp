using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_26_12.Abstract_Class;

public abstract class OfficeDevice
{
    public string Name { get; private set; }
    public bool IsOn { get; private set; }

    protected OfficeDevice(string name)
    {
        Name = name;
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} is on.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} is off.");
    }
}
