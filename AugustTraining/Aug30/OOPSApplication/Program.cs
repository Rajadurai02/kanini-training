using System;

namespace OOPSApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cycle cycle = new MountainCycle();
            //Console.WriteLine(cycle.Speed);
            //cycle.Run();
            //cycle = new MotorCycle();
            //cycle.Run();
            //casting
            //if (cycle.GetType().ToString() == "OOPSApplication.MotorCycle")
            //{
            //((MotorCycle)cycle).Run();
            //}
            //((MountainCycle)cycle).Run();
            //Console.WriteLine(cycle.Speed);

            //Account Acc = new Account("Raja");
            //Console.WriteLine("The name of the account holder is " + Acc.Name);
            //Acc.CreateAccount(12000.4f);
            //Acc.CreateAccount(13900.5f, "Aadhaar");

            //Account acc1 = new Account();
            //acc1.CreateAccount(12000.4f);
            //Account acc2 = new Account();
            //acc2.CreateAccount(12000.4f);
            //Account acc3 = new Account();
            //acc3 = acc1 + acc2;
            //Console.WriteLine("After adding the balance is " + acc3.Balance);
            Dog dog = new Pug();
            dog.Look();
            dog = new GreatDane();
            dog.Look();
            Console.ReadKey();
        }

    }
}
