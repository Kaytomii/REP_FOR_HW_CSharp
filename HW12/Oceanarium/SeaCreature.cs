using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Oceanarium;

public abstract class SeaCreature
{
    public string Name { get; set; }
    public string Species { get; set; }

    public SeaCreature(string name, string species)
    {
        Name = name;
        Species = species;
    }

    public abstract string Info();
}
