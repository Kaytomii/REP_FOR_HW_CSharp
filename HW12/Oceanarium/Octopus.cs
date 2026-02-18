using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Oceanarium
{
    public class Octopus : SeaCreature
    {
        public Octopus(string name) : base(name, "Octopus") { }

        public override string Info()
        {
            return $"{Name} — octopus";
        }
    }

}
