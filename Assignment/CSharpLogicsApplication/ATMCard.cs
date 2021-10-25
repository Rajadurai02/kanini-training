using System;


namespace CSharpLogicsApplication
{
    class ATMCard
    {
        /// <summary>
        /// Processing ATM card number
        /// </summary>
        void ATMCardNumberProcess()
        {
            Console.WriteLine("Enter a 16 digit card number without space");
            //getting 16 digit card number
            string card = Console.ReadLine();
            if (card.Length != 16) 
            {
                Console.WriteLine("Please enter a Correct card number");
                card = Console.ReadLine();
            }
            //converting to array so reversing is done easily
            char[] charArray = card.ToCharArray();
            Array.Reverse(charArray);
            string reversedcard = "";
            //converting array to string
            foreach (char tempChar in charArray)
            {
                reversedcard += tempChar;
            }
            Console.WriteLine("Card Number After Reversing : "+reversedcard );
            int sum = 0;
            int convertedNumber;
            //multiplying even position digit number by two
            for (int i = 0; i < reversedcard.Length; i++)
            {
                convertedNumber = Convert.ToInt32(reversedcard[i]-'0');
                //adding odd digit numbers to sum
                if (i % 2 == 0)
                {
                    sum +=  convertedNumber;
                }
                else
                {
                    //if number produces two digits after multiplying adding the digits
                    if (convertedNumber > 4)
                    {
                        int square = convertedNumber * 2;
                        int temp = 0;
                        while (square > 0)
                        {
                            int rem = square % 10;
                            temp = temp + rem;
                            square = square / 10;
                        }
                        sum += temp;
                    }
                    else
                        sum += convertedNumber * 2;
                }
            }
            int result;
            Console.WriteLine("Even digits multiplied by 2 and finally adding all digits the the sum is: " + sum);
            //finally divide by 10 to get the reminder
            result = sum % 10;
            Console.WriteLine("Result After processing Card Number the Remainder value is : " + result);
        }
        static void Main(string[] args)
        {
            new ATMCard().ATMCardNumberProcess();
            Console.ReadKey();
        }
    }
}
