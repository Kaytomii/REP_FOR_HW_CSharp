using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Oceanarium
{
    public class Dolphin : SeaCreature
    {
        public Dolphin(string name) : base(name, "Dolphin") { }

        public override string Info()
        {
            return $"{Name} — dolphin";
        }
    }

}
