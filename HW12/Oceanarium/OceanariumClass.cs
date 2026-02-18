using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Oceanarium;

public class OceanariumClass : IEnumerable<SeaCreature>
{
    private List<SeaCreature> creatures = new List<SeaCreature>();

    public void Add(SeaCreature creature)
    {
        creatures.Add(creature);
    }

    public IEnumerator<SeaCreature> GetEnumerator()
    {
        return creatures.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
