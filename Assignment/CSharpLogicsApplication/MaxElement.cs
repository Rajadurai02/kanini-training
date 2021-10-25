using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicsApplication
{
    class MaxElement
    {
        /// <summary>
        /// performing adding removing and finding max element from the stack
        /// </summary>
        void GetMaxElement()
        {
            int NumberOfOperations;
            string[] input = new string[2];
            int[] Operations = new int[2];
            List<int> stack = new List<int>();
            Console.WriteLine("Enter total no operations");
            NumberOfOperations = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 x - Push the element x into the stack.");
            Console.WriteLine("2 - Delete the element present at the top of the stack.\n3 - Print the maximum element in the stack.");
            while (NumberOfOperations>0)
            {
                input = Console.ReadLine().Split(" ");
                for (int i = 0; i < input.Length; i++)
                {
                    Operations[i] = Convert.ToInt32(input[i]);
                }
                if (Operations[0] == 1)
                {
                    stack.Add(Operations[1]);
                    Console.WriteLine($"{Operations[1]} added to the stack");
                }
                else if (Operations[0] == 2)
                {
                    if (stack.Count >= 1)
                    {
                        stack.RemoveAt(stack.Count - 1);
                        Console.WriteLine("Element Removed.");
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty");
                    }
                }
                else if (Operations[0] == 3)
                {
                    if (stack.Count >= 1)
                    {
                        Console.WriteLine("Maximum element is : " + stack.Max());
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty");
                    }
                }
                else
                    Console.WriteLine("Invalid Option");
                        
                            
                NumberOfOperations--;
            }
        }
        static void Main(string[] args)
        {
            new MaxElement().GetMaxElement();
            Console.ReadKey();
        }

    }
}
