using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Oceanarium
{
    public class Shark : SeaCreature
    {
        public Shark(string name) : base(name, "Shark") { }

        public override string Info()
        {
            return $"{Name} - shark";
        }
    }

}
