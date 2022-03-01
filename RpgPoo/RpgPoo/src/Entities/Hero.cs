using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgPoo.src.Entities;

internal abstract class Hero
{
    public String Name { get; protected set; }
    public int Level { get; protected set; }
    public String HeroType { get; protected set; }

    public virtual String Attack()
    {
        return this.Name + " usou um ataque básico!";
    }
}
