using System;
using System.Linq;
using WordGussingApplication.Models;

namespace WordGussingApplication
{
    class Program
    {
        WordGameContext context;
        public Program()
        {
            context = new WordGameContext();
        }
        /// <summary>
        /// To get the number input from the user
        /// </summary>
        /// <returns>integer</returns>
        static int GetNumberInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid Entry !.enter number again");
            }
            return num;
        }
        /// <summary>
        /// To get the string input from the user
        /// </summary>
        /// <returns>string</returns>
        static string GetStringInput()
        {
            string input = Console.ReadLine();
            while (input.Trim().Length == 0)
            {
                Console.WriteLine("Field cannot be empty!. Enter Again");
                input = Console.ReadLine();
            }
            return input;
        }
        /// <summary>
        /// Method for showing login menu
        /// </summary>
        void LoginMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("     Word  Game      ");
                Console.WriteLine("---------------------\n");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit\n");
                Console.WriteLine("Please select a option");
                choice = GetNumberInput();
                switch (choice)
                {
                    case 1:
                        UserLogin();
                        break;
                    case 2:
                        UserRegistration();
                        break;
                    case 3:
                        Console.WriteLine("You entered exit!!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!. Please try Again");
                        LoginMenu();
                        break;
                }
            } while (choice != 3);
        }
        /// <summary>
        /// method for registering new user
        /// </summary>
        void UserRegistration()
        {
            UserDetail user = new();
            ScoreBoard score = new();
            UserWord word = new();
            Console.WriteLine("Enter your In game Name (That considered as UserName)");
            string userName = GetStringInput();
            user.UserName = userName;
            score.UserName = userName;
            word.UserName = userName;
            score.Score = 0;
            Console.WriteLine("Enter your Name");
            user.Name = GetStringInput();
            Console.WriteLine("Enter your Password");
            user.Password = GetStringInput();
            Console.WriteLine("Reenter Password");
            string password = GetStringInput();
            Console.WriteLine("Enter your phone");
            user.Phone = GetStringInput();
            if (user.Password == password)
            {
                context.UserDetails.Add(user);
                context.ScoreBoards.Add(score);
                context.UserWords.Add(word);
                context.SaveChanges();
                Console.WriteLine("\n User Account Created !!\n");
            }
            else
            {
                Console.WriteLine("\nPassword Does not match");
                Console.WriteLine("User Account Not Created");
            }
        }
        /// <summary>
        /// Method for validating user login details
        /// </summary>
        void UserLogin()
        {
            string userName, password;
            Console.WriteLine("Please enter your UserName");
            userName = GetStringInput();
            Console.WriteLine("Please enter your password");
            password = GetStringInput();
            var user = context.UserDetails.Find(userName);
            if (user != null)
            {
                if (user.Password == password)
                {
                    Console.WriteLine("Login Successful!\n");
                    GameMenu(userName);
                }
                else
                    Console.WriteLine("Incorrect Password!");
            }
            else
            {
                Console.WriteLine("UserName not present in the database");
                Console.WriteLine("Create a new one use Register option");
            }
        }
        void GameMenu(string userName)
        {
            int choice;
            do
            {
                Console.WriteLine("1) Words ready for you to play");
                Console.WriteLine("2) Assign word for another player");
                Console.WriteLine("3) See score board");
                Console.WriteLine("0) Exit\n");
                Console.WriteLine("Please select a option");
                choice = GetNumberInput();
                switch (choice)
                {
                    case 1:
                        LetsPlay(userName);
                        break;
                    case 2:
                        AssignWordForFriend();
                        break;
                    case 3:
                        SeeScoreBoard();
                        break;
                    case 0:
                        Console.WriteLine("You entered exit!!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!. Please try Again");
                        GameMenu(userName);
                        break;
                }
            } while (choice != 0);
        }
        void SeeScoreBoard()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("UserName\tScore");
            Console.WriteLine("-----------------------------------");
            foreach (var item in context.ScoreBoards)
            {
                Console.WriteLine(item.UserName + "\t" + item.Score);
            }
            Console.WriteLine("----------------------------------\n");
        }
        void AssignWordForFriend()
        {
            string userName, word;
            Console.WriteLine("Please enter  UserName of your friend");
            userName = GetStringInput();
            int Id = 0;
            foreach (var item in context.UserWords)
            {
                if (item.UserName == userName)
                {
                    Id = item.UserId;
                    break;
                }
            }
            var user = context.UserWords.Find(Id);
            if (user != null)
            {
                do
                {
                    Console.WriteLine("Enter the word (greater than 2 letters)");
                    word = GetStringInput();
                } while (word.Length < 2);
                user.Word = word;
                context.UserWords.Update(user);
                context.SaveChanges();
                Console.WriteLine("\nWord Assigned!!!\n");
            }
            else
            {
                Console.WriteLine("UserName not present in the database");
            }
        }
        void LetsPlay(string userName)
        {
            int Id = 0;
            foreach (var item in context.UserWords)
            {
                if (item.UserName == userName)
                {
                    Id = item.UserId;
                    break;
                }
            }
            var user = context.UserWords.Find(Id);
            string word = user.Word;
            int WordLength = user.Word.Length;
            Console.WriteLine("The Words Given to you are");
            Console.Write("1. ");
            for (int i = 0; i < WordLength; i++)
            {
                Console.Write('X');
            }
            Console.WriteLine("\n2. Go to Previous Menu");
            int choice;
            do
            {
                Console.WriteLine("Please select a option");
                choice = GetNumberInput();
                switch (choice)
                {
                    case 1:
                        GuessWord(word,userName);
                        break;
                    case 2:
                        GameMenu(userName);
                        break;
                    default:
                        Console.WriteLine("Invalid option!. Please try Again");
                        GameMenu(userName);
                        break;
                }
            } while (choice > 2 || choice < 1);
        }

        void GuessWord(string word,string userName)
        {
            Console.WriteLine("Enter Your guess");
            int cow = 0, bull = 0;
            string guess;
            guess = GetStringInput();
            char[] OriginalWord = word.ToCharArray();
            char[] GuessArray = guess.ToCharArray();
            if (word == guess)
            {
                Console.WriteLine("\nThat is the word. Congrats!!!!!");
                Console.WriteLine("---------------------------------\n");
                int scoreUpdate = 0;
                foreach (var item in context.ScoreBoards)
                {
                    if (item.UserName == userName)
                    {
                        scoreUpdate = item.Score;
                    }
                }
                var user = context.ScoreBoards.Find(userName, scoreUpdate);
                user.Score += 10;
                context.ScoreBoards.Update(user);
                context.SaveChanges();
            }
            else
            {
                for (int i = 0; i < OriginalWord.Length; i++)
                {
                    for (int j = 0; j < GuessArray.Length; j++)
                    {
                        if (OriginalWord[i] == GuessArray[j] && i == j)
                        {
                            cow++;
                        }
                        else if (OriginalWord[i] == GuessArray[j] && i != j)
                        {
                            bull++;
                        }
                    }
                }
                Console.WriteLine($"The word you entered is {word} - Cow - {cow} , Bull - {bull}");
                GuessWord(word,userName);
            }
        }

        static void Main()
        {
            new Program().LoginMenu();
            Console.ReadKey();
        }
    }
}
