using System;


namespace CSharpLogicsApplication
{
    class NonRepeatingNumber
    {
        /// <summary>
        /// geting input from the user
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
        /// printing the non repeating number
        /// </summary>
        void PrintNonRepeatingNumber()
        {
            int[] Numbers = new int[11];
            Console.WriteLine("Printing the Non Repeating Number");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}: ");
                Numbers[i] = getInput();
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (Numbers[i] == Numbers[j] && i != j)
                        flag = false;
                }
                if (flag)
                    Console.WriteLine($"The Non Repeating Number is : {Numbers[i]}");
            }
        }
        static void Main(string[] args)
        {
            new NonRepeatingNumber().PrintNonRepeatingNumber();
            Console.ReadKey();
        }
    }
}
