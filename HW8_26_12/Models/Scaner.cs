using HW8_26_12.Abstract_Class;
using HW8_26_12.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW8_26_12.Models;

public class Scanner : OfficeDevice, IScannable
{
    public Scanner(string name) : base(name) { }

    public void Scan()
    {
        if (IsOn)
            Console.WriteLine($"{Name} scanning...");
        else
            Console.WriteLine($"{Name} is off");
    }
}

