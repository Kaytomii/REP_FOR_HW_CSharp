using HW8_26_12.Abstract_Class;
using HW8_26_12.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW8_26_12.Models
{
    public class Copier : OfficeDevice, ICopyable
    {
        public Copier(string name) : base(name) { }

        public void Copy()
        {
            if (IsOn)
                Console.WriteLine($"{Name} coping...");
            else
                Console.WriteLine($"{Name} is off");
        }
    }

}
