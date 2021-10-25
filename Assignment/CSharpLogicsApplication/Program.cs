using System;

namespace CSharpLogicsApplication
{
    class Program
    {
        /// <summary>
        /// Get input from the user
        /// </summary>
        /// <returns></returns>
        int getInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid Entry !.enter number again");
            }
            return num;
        }
        /// <summary>
        /// Finding the Prime Numbers Between Two Numbers
        /// </summary>
        void PrimeNumbersBetweenTwoNumbers()
        {
            int Min, Max;
            Console.WriteLine("Finding the Prime Numbers Between Two Numbers");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter a minimum number");
            Min = getInput();
            Console.WriteLine("Enter a maximum number");
            Max = getInput();
            if (Min > Max)
            {
                Console.WriteLine("Please enter a max value greater than min");
                Max = getInput();
            }
            Console.WriteLine($"The Prime Numbers between {Min} and {Max} are :");
            for (int Num = Min; Num<= Max; Num++)
            {
                bool flag = true;
                for (int i = 2; i <= Num / 2; i++)
                {
                    if (Num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.Write(Num + ",");                  
            }
        }
        
        static void Main(string[] args)
        {
            new Program().PrimeNumbersBetweenTwoNumbers();
            Console.ReadKey();
        }
    }
}
