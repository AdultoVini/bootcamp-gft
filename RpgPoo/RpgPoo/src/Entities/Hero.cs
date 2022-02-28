using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgPoo.src.Entities;

internal class Hero
{
    public String Name { get; private set; }
    public int Level { get; private set; }
    public String HeroType { get; private set; }

    public Hero(String name, int level, String type)
    {
        this.Name = name;
        this.Level = level;
        this.HeroType = type;
        Console.WriteLine("================\nNome: " + this.Name + "\nLevel: " + this.Level + "\nClasse: " + this.HeroType);
    }
}
