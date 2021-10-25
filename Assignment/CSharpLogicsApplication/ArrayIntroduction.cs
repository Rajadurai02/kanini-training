using System;


namespace CSharpLogicsApplication
{
    class ArrayIntroduction
    {
        /// <summary>
        /// Counting consecutive Number of 1's
        /// </summary>
        void CountConsecutiveOnes()
        {
            int[] nums = { 1, 0, 0, 0, 1, 1 };
            int count = 0, max = 0;
            Console.WriteLine("Counting Consecutive Number of 1's");
            foreach(int num in nums) {
                Console.Write(num+" ");
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    count = 0;
                else
                {
                    count++; 
                    max = Math.Max(max, count);
                }
            }
            Console.WriteLine("\nNo of Consecutive 1's are: " + max);
        }
        /// <summary>
        /// Counting Even Digit Numbers
        /// </summary>
        void CountEvenNumberOfDigits()
        {
            int[] nums = { 123, 34, 4567, 23 };
            int count = 0;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Counting Even digit Numbers");
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsEvenCount(nums[i]))
                {
                    count++;
                }
            }
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nTotal Number of Even Digit Numbers: " + count);
        }
        private bool IsEvenCount(int num)
         {
                int count = 0;
                while (num != 0)
                {
                    count++;
                    num = num / 10;
                }

                return count % 2 == 0;
         }
        /// <summary>
        /// Squaring and sorting the Array
        /// </summary>
        void SquaresOfSortedArray()
        {
            int[] nums = { -2, 5, 6, -9 };
            int[] squaredNums = new int[nums.Length];
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Squaring and Sorting the Array");
            Console.WriteLine("Values before sorting and squaring:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nValues after sorting and squaring:");
            for (int i = 0; i < nums.Length; i++)
            {
                squaredNums[i] = nums[i] * nums[i];
            }
            for (int i = 0; i < squaredNums.Length - 1; i++)
            {
                for (int j = 0; j < squaredNums.Length - 1; j++)
                {
                    if (squaredNums[j] > squaredNums[j + 1])
                    {
                        int temp;
                        temp = squaredNums[j + 1];
                        squaredNums[j + 1] = squaredNums[j];
                        squaredNums[j] = temp;
                    }
                }
            }
            foreach (int num in squaredNums)
            {
                Console.Write(num + " ");
            }
        }
            static void Main(string[] args)
        {
            ArrayIntroduction Array = new ArrayIntroduction();
            Array.CountConsecutiveOnes();
            Array.CountEvenNumberOfDigits();
            Array.SquaresOfSortedArray();
            Console.ReadKey();
        }
    }
}
