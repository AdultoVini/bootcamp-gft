using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgPoo.src.Entities;

internal class Wizard : Hero
{
    public Wizard(String name, int level)
    {
        this.Name = name;
        this.Level = level;
        this.HeroType = "White Wizard";
        Console.WriteLine("================\nNome: " + this.Name + "\nLevel: " + this.Level + "\nClasse: " + this.HeroType);
    }

    public override string Attack()
    {
        return this.Name + " usou sua mágia!";
    }
}
