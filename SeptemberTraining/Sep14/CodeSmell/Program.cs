using System;

namespace Sep14
{
    class Program
    {
        string msg;
        public Program()
        {
            Console.WriteLine();
        }
        public Program(int num)
        {
            int _num = num;
        }
        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("Hello World!");
        }
    }
}
