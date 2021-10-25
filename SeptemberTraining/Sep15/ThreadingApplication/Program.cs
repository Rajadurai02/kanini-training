using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApplication
{
    class Program
    {
        void Sample1()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + " From " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }
        void Sample2()
        {
            for (int i = 0; i < 100; i+=10)
            {
                Console.WriteLine(i + " From " + Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }
        void UnderstandingTask()
        {
            //Task task = new Task(() =>
            //{
            //    for (int i = 0; i < 100; i += 10)
            //    {
            //        Console.WriteLine(i + " From " + Thread.CurrentThread.Name);
            //        Thread.Sleep(1000);
            //    }
            //});
            //task.Start();
            Task<int> task = Task.Run(() => 10);
            Console.WriteLine("The value from the task is "+task.Result);
        }
        //understanding async and await
        Task<string> GetTheTaskDone()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Hello from Task";
            });
        }
        //it will wait for the getthetaskdone function to be done. then the print function executed when you use await you must use async
        async void PrintTaskValue()
        {
            string value = await GetTheTaskDone();
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintTaskValue();
            //program.UnderstandingTask();
            //Thread t1 = new Thread(program.Sample1);
            //t1.Name = "Thread1";
            ////Thread t2 = new Thread(program.Sample2);
            //Thread t2 = new Thread(program.Sample1);
            //t2.Name = "Thread2";
            //t1.Start();
            //t2.Start();
            Console.ReadKey();
        }
    }
}
