using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExceptionApplication
{
    public class Bird : IFlying,IAnimal
    {
        public string Name { get; set; }
        public Bird()
        {
            Console.WriteLine("You have crated a bird");
        }
        public Bird(string name)
        {
            Name = name;
        }
        public void TakeOff()
        {
            Console.WriteLine("started flying");
        }
        public void Fly()
        {
            Console.WriteLine("Fly Fly Fly....");
        }
        public void Land()
        {
            Console.WriteLine("Landing....");
        }
        public void Eat()
        {
            Console.WriteLine("The bird is eating..");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzz");
        }
    }
}
