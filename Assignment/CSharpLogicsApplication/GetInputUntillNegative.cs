using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicsApplication
{
    class GetInputUntillNegative
    {
        //creating list because there no need to specify the length
        List<int> Numbers = new List<int>();
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
        /// getting input from user untill the user entering a negative value and finally sorting the list
        /// </summary>
        public void GetInputUntillNegativeAndSort()
        {
            int num;
            Console.WriteLine("Sorting an Array");
            Console.WriteLine("Enter a negative value to stop inserting");
            Console.WriteLine("-----------------------------");
            do
            {
                Console.WriteLine("Enter a Number");
                num = getInput();
                if (num > 0)
                {
                    Numbers.Add(num);
                }
            } while (num >= 0);
            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                for (int j = 0; j < Numbers.Count - 1; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        int temp;
                        temp = Numbers[j + 1];
                        Numbers[j + 1] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting :");
            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.Write(Numbers[i] + "  ");
            }
        }
        /// <summary>
        /// finding median of the list
        /// </summary>
        void FindMedian()
        {
            Double median;
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Finding Median of the Array");
            if (Numbers.Count % 2 == 0)
            {
                median = (Numbers[Numbers.Count / 2] + Numbers[(Numbers.Count / 2) - 1]) / 2;
            }
            else
                median = Numbers[Numbers.Count / 2];
            Console.WriteLine("Medain of the Array is :" + median);
        }
        /// <summary>
        /// finding the mode of the list
        /// </summary>
        void FindMode()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Finding Mode");
            int max = Numbers.Max();
            int[] modeArray = new int[max+1];
            for (int i = 0; i < max + 1; i++)
                modeArray[i] = 0;
            for (int i = 0; i < Numbers.Count; i++)
                modeArray[Numbers[i]]++;
            int mode = 0;
            int k = modeArray[0];
            for (int i = 1; i < max + 1; i++)
            {
                if (modeArray[i] > k)
                {
                    k = modeArray[i];
                    mode = i;
                }
            }
            if (k > 1)
                Console.WriteLine("The mode is "+mode);
            else
                Console.WriteLine("There is no mode in the array!");
        }
        static void Main(string[] args)
        {
            GetInputUntillNegative sort = new GetInputUntillNegative();
            sort.GetInputUntillNegativeAndSort();
            sort.FindMedian();
            sort.FindMode();
            Console.ReadKey();
        }
    }
}