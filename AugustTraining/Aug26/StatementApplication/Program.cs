using System;

namespace StatementApplication
{
    class Program
    {
        void UnderstandingIf()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
        void UnderstandingSwitch()
        {
            Console.WriteLine("Enter a day");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Monday":
                    Console.WriteLine("week start");
                    break;
                case "Tuesday":
                    Console.WriteLine("Day 2");
                    break;
                case "Wednesday":
                    Console.WriteLine("Mid Week");
                    break;
                case "Thursday":
                    Console.WriteLine("Day 4");
                    break;
                case "Friday":
                    Console.WriteLine("Final Working day");
                    break;
                case "Saturday":
                    Console.WriteLine("weekend");
                    break;
                case "Sunday":
                    Console.WriteLine("weekend");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
       void UnderstandingForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The value of i is:" + i);
            }
        } 
        void UnderstandingWhileLoop()
        {
            int num = 10;
            while (num < 100)
            {
                Console.WriteLine("The value of Num is " + num);
                Console.WriteLine("Changing the value enter a number");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }
        void UnderstandingDoWhileLoop()
        {
            int num;
            do
            {
                Console.WriteLine("Changing the value enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of Num is " + num);
            } while (num < 100);
        }

        void CsharpFeatures()
        {
            //int inum;// = int.MaxValue;
            //checked
            //{
            //inum++;
            //}
            //Console.WriteLine("Enter a number: ");
            //inum = Convert.ToInt32(Console.ReadLine());
            //bool res = int.TryParse(Console.ReadLine(), out inum);
            //if (res == true)
            //Console.WriteLine("you entered " + inum);
            //else
            //Console.WriteLine(" number assigned in"+ inum);
            //int? inum2 = null;
            int? inum2 = 1000;
            int inum1 = inum2 ?? 10;
            Console.WriteLine("The value is " + inum1);
        }
        int getInput()
        {
            int num;
            Console.WriteLine("Enter a number");
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid Entry !.enter number again");
            }
            return num;
        }
        void AverageDivisibleBySeven()
        {
            int num,sum = 0,count = 0;
            float Average;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 7 == 0)
                {
                    sum = sum + num;
                    count = count + 1;
                }
            }
            Average = sum / count;
            Console.WriteLine("The Average of 10 Numbers That are divided by 7 is :" + Average);
        }
        /// <summary>
        /// finding prime number or not
        /// </summary>
        void PrimeOrNot()
        {
            int Num,count = 0;
            Console.WriteLine("Finding Prime Number Or Not");
            Num = getInput();
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
                Console.WriteLine($"{Num} is a prime number");
            else
                Console.WriteLine($"{Num} is not a prime number");
        }
        void CountOddEven()
        {
            int num = 0, odd = 0, even = 0;
            Console.WriteLine("Counting ODD and EVEN numbers");
            while (num >= 0)
            {
                num = getInput();
                if (num > 0)
                {
                    if (num % 2 == 0)
                        even = even + 1;
                    else
                        odd = odd + 1;
                }

            }
            Console.WriteLine($"Totally there are {odd} numbers");
            Console.WriteLine($"Totally there are {even} numbers");
        }

        void understandingArray()
        {
            int[] numbers = { 12, 34, 45, 56, 78 };
            Console.WriteLine("The size of the Array: " + numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("The value is " + numbers[i]);
            }
        }
        void CreatingStringArray()
        {
            string[] Names = new string[5];
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine($"Enter the {i+1} Name");
                Names[i] = Console.ReadLine();
            }
            for (int i = 0; i < Names.Length-1; i++)
            {
                Console.Write(Names[i]+",");               
            }
            Console.WriteLine(Names[Names.Length - 1]);

        }
        void FindNextArrayElement()
        {
            const int LIMIT = 5;
            int count = 0;
            int[] Numbers = new int[5];
            for (int i = 0; i < LIMIT; i++)
            {
                Numbers[i] = getInput();
            }
            for (int i = 0; i < Numbers.Length-1; i++)
            {
                for (int j = i+1; j < Numbers.Length; j++){
                    if(Numbers[i]-Numbers[j] == 1 || Numbers[i] - Numbers[j] == -1)
                    {
                        count++;
                    }
            }
            }
            Console.WriteLine($"{count} times the array has next number ");
        }
        void CheckPrimeOrNot()
        {

        }
        static void Main(string[] args)
        {
            //new Program().UnderstandingIf();
            //Console.WriteLine("Hello World!");
            //new Program().UnderstandingSwitch();
            //new Program().UnderstandingForLoop();
            //new Program().UnderstandingWhileLoop();
            //new Program().UnderstandingDoWhileLoop();
            //new Program().CsharpFeatures();
            //new Program().AverageDivisibleBySeven();
            //new Program().PrimeOrNot();
            //new Program().CountOddEven();
            //new Program().understandingArray();
            //new Program().CreatingStringArray();
            new Program().FindNextArrayElement();
            Console.ReadKey();
        }
    }
}
