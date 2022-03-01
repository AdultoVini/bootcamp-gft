using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgPoo.src.Entities;

internal class Knigth : Hero
{
    public Knigth(String name, int level)
    {
        this.Name = name;
        this.Level = level;
        this.HeroType = "Knigth";
        Console.WriteLine("================\nNome: " + this.Name + "\nLevel: " + this.Level + "\nClasse: " + this.HeroType);
    }

    public override string Attack()
    {
        return this.Name + " usou sua espada!";
    }
}
