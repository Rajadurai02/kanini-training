using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public float Price { get; set; }

        public void Drive()
        {
            Console.WriteLine("The car engine is started and drives smoothly ");
        }
        public void About()
        {

            Console.WriteLine("Name of the Car is: " + Name);
            Console.WriteLine("Name of the Car model is: " + Model);
            Console.WriteLine("Price of the Car is: " + Price);
            Console.WriteLine("TopSpeed of the car is: " + TopSpeed);
        }
    }
}
