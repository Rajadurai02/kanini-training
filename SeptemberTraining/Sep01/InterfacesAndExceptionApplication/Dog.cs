using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExceptionApplication
{
    public abstract  class Dog
    {
        public void Eat()
        {
            Console.WriteLine("Dos is eating...");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }
        public abstract void Look();
    }
}
