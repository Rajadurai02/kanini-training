using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpLogicsAug31
{
    class Program
    {
        //string binaryConversion()
        //{
        //    int number;
        //    Console.WriteLine("Enter a Number to convert to binary form");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    string binaryCode = "";
        //    while (number > 0)
        //    {
        //        int bin = number % 2;
        //        binaryCode =  bin + binaryCode;
        //        number = number / 2;
        //    }
        //    return binaryCode;
        //}
        //void BinaryGap()
        //{
        //    int count = 0, max = 0;
        //    bool OneAppear = false, ZeroAppear = false;
        //    string BinaryCode = binaryConversion();
        //    for(int i = 0; i < BinaryCode.Length; i++)
        //    {
        //       if (BinaryCode[i] == '1')
        //        {
        //            if (OneAppear && ZeroAppear)
        //            {
        //                max = Math.Max(count, max);
        //                count = 0;
        //                ZeroAppear = false;
        //                OneAppear = false;
        //            }
        //            OneAppear = true;
        //        }
        //        else
        //        {
        //            ZeroAppear = true;
        //            if (OneAppear)
        //                count++;
        //        }
        //    }
        //    Console.WriteLine(max);
        //}


        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int number = N;
            int count = 0, max = 0;
            string BinaryCode = "";
            while (number > 0)
            {
                int bin = number % 2;
                BinaryCode = bin + BinaryCode;
                number = number / 2;
            }
            bool OneAppear = false, ZeroAppear = false;
            for (int i = 0; i < BinaryCode.Length; i++)
            {
                if (BinaryCode[i] == '1')
                {
                    if (OneAppear && ZeroAppear)
                    {
                        max = Math.Max(count, max);
                        count = 0;
                        ZeroAppear = false;
                        OneAppear = false;
                    }
                    OneAppear = true;
                }
                else
                {
                    ZeroAppear = true;
                    if (OneAppear)
                        count++;
                }
            }
            return max;
        }

        void FrogJump()
        {
            int X, Y, D;
            Console.WriteLine("Enter the value of starting Position X");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of target Position Y");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of D a frogJump");
            D = Convert.ToInt32(Console.ReadLine());
            int DistanceToBeCompleted;
            DistanceToBeCompleted = Y - X;
            int MinJumps;
            if (DistanceToBeCompleted % D == 0)
            {
                MinJumps = DistanceToBeCompleted / D;
            }
            else
                MinJumps = (DistanceToBeCompleted / D) + 1;
            Console.WriteLine("Minimum Jump is needed: " + MinJumps);
        }
        //void CyclicRotation()
        //{
        //    Console.WriteLine("Cyclic Rotation");
        //    Console.WriteLine("-------------------------------------");
        //    int[] Nums = { 12, 4, 7, 9, 45 };
        //    Console.WriteLine("Array Before Rotation");
        //    foreach (int nums in Nums)
        //    {
        //        Console.Write(nums + " ");
        //    }
        //    Console.WriteLine("\nEnter Number of Rotations");
        //    int TotalRotate = Convert.ToInt32(Console.ReadLine());
        //    int len = Nums.Length;
        //    //save last element value
        //    for (int rotate = 0; rotate < TotalRotate; rotate++)
        //    {
        //        int tmp = Nums[len - 1];
        //        for (int i = len - 1; i > 0; i--) //starting from the end to begining
        //        {
        //            Nums[i] = Nums[i - 1]; //assign value of the previous element
        //        }
        //        Nums[0] = tmp;
        //    }
        //    foreach (int nums in Nums)
        //    {
        //        Console.Write(nums + " ");
        //    }
        //}
        void OddOccurencesInArray()
        {
            int[] Nums = { 1, 2, 3, 2, 1 };
            for (int i = 0; i < Nums.Length; i++)
            {
                bool Flag = true;
                for (int j = 0; j < Nums.Length; j++)
                {
                    if (Nums[i] == Nums[j] && i != j)
                        Flag = false;
                }
                if (Flag)
                    Console.WriteLine("The Unpaired Element is : " + Nums[i]);
            }
        }
        void PermMissingElement()
        {
            int[] Nums = { 12, 13, 10, 14, 15 };
            for (int i = 0; i < Nums.Length - 1; i++)
            {
                for (int j = 0; j < Nums.Length - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        int temp;
                        temp = Nums[j + 1];
                        Nums[j + 1] = Nums[j];
                        Nums[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Nums.Length - 1; i++)
            {
                if (Nums[i] - Nums[i + 1] != -1)
                {
                    Console.WriteLine($"The Missing Number is : {Nums[i] + 1}");
                }
            }
        }
        int TapeEquibiliriam()
        {
            int[] Nums = { -1000,1000};
            List<int> diffs = new List<int>();
            int left = 0;
            int sum = Nums.Sum();
            foreach (int item in Nums)
            {
                left += item;
                int value;
                value = sum - (left * 2);
                if (sum != 0 || left !=0)
                    diffs.Add(Math.Abs(value));
            }
            if (diffs.Count == 1)
                Console.WriteLine(diffs[0]);
            else
                Console.WriteLine(diffs.Min());
            return 0;
        }
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 1)
            {
                return A[0];
            }
            Array.Sort(A);
            int oddOccurNumber = 0;
            for (int i = 0; i < A.Length; i = i + 2)
            {
                if (i+1 == A.Length)
                {
                    oddOccurNumber = A[i];
                    break;
                }
                if (A[i] != A[i + 1])
                {
                    oddOccurNumber = A[i];
                    break;
                }
            }
            return oddOccurNumber;
        }


        static void Main(string[] args)
        {
            // new Program().BinaryGap();
            //new Program().FrogJump();
            //new Program().CyclicRotation();
            //new Program().OddOccurencesInArray();
            //new Program().PermMissingElement();
            new Program().TapeEquibiliriam();
            //int[] array = { 2, 3, 4, 5, 6, 5, 4, 3, 2 };
            //Program p1 = new Program();
            //Console.WriteLine(p1.solution(array));
            Console.ReadKey();
        }
    }
}
