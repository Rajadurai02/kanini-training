using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicsApplication
{
    class Subarray
    {
		/// <summary>
		/// geting input from the user
		/// </summary>
		/// <returns></returns>
		int getInput()
		{
			int num;
			Console.WriteLine("Enter a number");
			while (!int.TryParse(Console.ReadLine(), out num))
			{
				Console.WriteLine("Invalid Entry !.enter number again");
			}
			return num;
		}

		/// <summary>
		/// finding subarray with zero sum
		/// </summary>
		void SubArrayWithZeroSum()
		{
			Console.WriteLine("Finding SubArray with Zero Sum");
			Console.WriteLine("--------------------------------");
			Console.WriteLine("Enter five numbers for array");
			int[] Numbers = new int[5];
			for (int i = 0; i < 5; i++)
			{
			Numbers[i] = getInput();
			}
			
			HashSet<int> subarray = new HashSet<int>();
			int sum = 0;
			bool result = false;
			for (int i = 0; i < Numbers.Length; i++)
			{
				sum += Numbers[i];
				if (Numbers[i] == 0	|| sum == 0 || subarray.Contains(sum))
					result = true;
				subarray.Add(sum);
			}
			if (result)
				Console.WriteLine("Sub array with Zero sum found");
			else
				Console.WriteLine("There is no subarray with Zero sum");
		}
		public static void Main(string[] args)
		{
			new Subarray().SubArrayWithZeroSum();
			Console.ReadKey();
		}
	}
}

