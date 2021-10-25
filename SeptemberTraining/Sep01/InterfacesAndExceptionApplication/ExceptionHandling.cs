using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExceptionApplication
{
    class ExceptionHandling
    {
//        ArrayIndexOutOFBounds
//FormatException
//DivideByZero
//ArithmaticException
//IOException
//NullReferenceException
        public void ArrayIndexException()
        {
            int[] array = { 12, 34, 56, 87, 87, 54, 223, 54, 12, 45 };
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(array[i]);
            }
           
        }
        public int DivisionByZeroException()
        {
            int value = 10;
            int ans;
            int divisor = 0;
            try
            {
               
                ans = value / divisor;
                Console.WriteLine(ans);
                return ans;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("All done");
            }
            return 0;
            
        }
        public void FormatException()
        {
            int Age;
            Console.WriteLine("Enter your Age?");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void ArithmeticException()
        {
            double myNan = Double.NaN;
            Console.WriteLine(Math.Sign(myNan));
        }
        public void NullException()
        {
            string Name = null;
            Name.ToLower();
        }
        public void IOException()
        {
            string dir = @"D: \erfgg5";
            Directory.SetCurrentDirectory(dir);
        }
    }
}
