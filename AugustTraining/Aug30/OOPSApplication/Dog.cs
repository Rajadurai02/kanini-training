using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSApplication
{
    public class Dog
    {
        public string Name { get; set; }

        public virtual void Look()
        {
            Console.WriteLine($"The Dog look like {Name}");
        }
    }
    public class Pug : Dog
    {
        public Pug()
        {
            Name = "Pug";
        }
        public override void Look()
        {
            Console.WriteLine($"The Dog  look like {Name}");
        }
    }
    public class GreatDane : Dog
    {
        public GreatDane()
        {
            Name = "GreatDane";
        }
        public override void Look()
        {
            Console.WriteLine($"The  Dog look like {Name}");
        }
    }
}
