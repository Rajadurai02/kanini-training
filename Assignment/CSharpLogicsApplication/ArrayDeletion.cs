using System;

using System.Linq;


namespace CSharpLogicsApplication
{
    class ArrayDeletion
    {
        /// <summary>
        /// Deleting a particular element in Array
        /// </summary>
        void DeleteParticularElement()
        {
            int[] nums = { 12, 5, 6, 8, 9, 3, 2, 5 };
            int delnum = 5;
            Console.WriteLine("Deleting a Particular Element In Array");
            Console.WriteLine("Array before deleting");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            nums = nums.Where(val => val != delnum).ToArray();
            Console.WriteLine("\nArray after deleting");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
        /// <summary>
        /// deleting duplicate items in Array
        /// </summary>
        void deleteDuplicateElements()
        {
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 , 7 , 8 , 12 , 45 , 6 , 7 , 3 };
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Array Elements");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            int[] DistinctNums = nums.Distinct().ToArray();
            Console.WriteLine("\nArray after removing Duplicate items");
            foreach (int num in DistinctNums)
            {
                Console.Write(num + " ");
            }
        }
        static void Main(string[] args)
        {
            ArrayDeletion array = new ArrayDeletion();
            array.DeleteParticularElement();
            array.deleteDuplicateElements();
            Console.ReadKey();
        }
    }
}
