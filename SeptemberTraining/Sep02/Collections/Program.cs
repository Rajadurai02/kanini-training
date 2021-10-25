using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        ArrayList myArray;
        public Program()
        {
            myArray = new ArrayList();
        }
        void AddElementsToArray()
        {
            int num = 0;
            Console.WriteLine("Enter a number. if you want to stop enter a Negative Number");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                myArray.Add(num);
            } while (num > 0);
        }
        void PrintAllArrayElements()
        {
            //for (int i = 0; i < myArray.Count; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            int sum = 0;
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
                sum += num;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.AddElementsToArray();
            //program.PrintAllArrayElements();
            WorkingWithList working = new WorkingWithList();
            //working.UnderstandingList();
            //working.UnderstandingSet();
            //working.UnderstandingLinkedList();
            //working.WorkingWithDictnories();
            working.EqualsObject();
            Console.ReadKey();
        }
    }
}
