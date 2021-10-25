using System;

namespace FirstApplication
{
    class Program
    {
        void Add()
        {
            int num1, num2;
            Console.WriteLine("Addition");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of the {num1} and {num2} is {sum}");
        }
        void Subtract()
        {
            int num1, num2;
            Console.WriteLine("Subtraction");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int diff = num1 - num2;
            Console.WriteLine($"The difference of the {num1} and {num2} is {diff}");
        }
        void Multiply()
        {
            int num1, num2;
            Console.WriteLine("Multiplication");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int mul = num1 * num2;
            Console.WriteLine($"The multiplication of the {num1} and {num2} is {mul}");
        }
        void Div()
        {
            int num1, num2;
            Console.WriteLine("Divition");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int div = num1 / num2;
            Console.WriteLine($"The divition of the {num1} and {num2} is {div}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("My name is Rajadurai");
            //Console.WriteLine("I am from Thoothukudi");
            //int num = int.MaxValue;
            //Console.WriteLine("The value of num is " + num);
            //num = num + 1;
            //Console.WriteLine("The value after adding 1 is " + num);
            //float pi = float.MaxValue;
            //Console.WriteLine("The value of pi is "+pi);
            //pi = pi + 1;
            //Console.WriteLine("The value of pi after adding 1 " + pi);
            //Mobile obj = new Mobile();
            //obj.Speed = 4;
            //obj.Name = "Honor";
            //obj.Price = 12000.45f;
            //obj.Call();
            //obj.About();
            //car c = new car();
            //c.Name = "Mahindra";
            //c.Model = "SUV";
            //c.Price = 2000000f;
            //c.TopSpeed = 200;
            //c.Drive();
            //c.About();
            Program pr = new Program();
            pr.Add();
            pr.Subtract();
            pr.Multiply();
            pr.Div();
            Console.ReadKey();
        }
    }
}
