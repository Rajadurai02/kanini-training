using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSApplication
{
    public class Cycle
    {
        public int Speed { get; set; }
        public virtual void Run()
        {
            Console.WriteLine($"Cycle runs {Speed} speed");
        }
    }
    public class MountainCycle:Cycle
    {
        public MountainCycle()
        {
            Speed = 40;
            Console.WriteLine("From Mountain cycle class");
        }
        public override  void Run()
        {
            Console.WriteLine($"MountainCycle runs {Speed} speed");
        }
    }
    public class MotorCycle : Cycle
    {
        public string Brand  { get; set;}
        public MotorCycle()
        {
            Speed = 60;
            Console.WriteLine("Motor Cycle");
        }
        public override  void Run()
        {
            Console.WriteLine($"MotorCycle runs {Speed} speed");
        }
    }
    public class SuperCylce:MotorCycle
    {
        public SuperCylce()
        {
            Brand = "BMW";
            Speed = 90;
            Console.WriteLine("From super cycle class");
        }
    }
}
