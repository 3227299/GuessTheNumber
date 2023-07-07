//GuessNumberGenerator.cs
//G. Li
//7/7/23
//Guessing the value application

using System;

//namespace
namespace GuessTheNumber
{
    //GuessValueGenerator class
    class GuessValueGenerator
    {

        static void Main(string[] args)
        {
            GetAppInfo(); //getting the info

            GetUserName(); //Get user's name

            while (true)
            {
                //random object
                Random random = new Random();

                //random value 
                int correctValue = random.Next(1, 10);
                int guess = 0;

                //text color
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                //choose a value and guessing
                Console.WriteLine("Guess an value between 1-10");

                //guess a correct value
                while (guess != correctValue)
                {

                    //input a value
                    string userInput = Console.ReadLine();

                    //Only number value
                    if (!int.TryParse(userInput, out guess))
                    {
                        //print wrong message
                        GetColorMessage(ConsoleColor.Magenta, "Use a number value not a String");

                        continue;
                    }

                    //Cast to int and put guess value
                    guess = Int32.Parse(userInput);

                    //Match guess to correct value
                    if (guess != correctValue)
                    {
                        //Set error message
                        GetColorMessage(ConsoleColor.Green, "Wrong Value Please Reconsider!");

                    }
                }

                GetColorMessage(ConsoleColor.Red, "Correct!!!!");

                Console.ForegroundColor = ConsoleColor.Gray;

                //Ask to play again?
                Console.WriteLine("Want to try again? [Y/N]");

                //get reponse
                string response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //application info
        static void GetAppInfo()
        {
            //name of the app
            string appName = "Guess The Number";
            double appVersion = 1.0;
            string ownerName = "Gary Li";

            //text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //info about the app
            Console.WriteLine("{0}: Version {1}", appName, appVersion);
            Console.WriteLine("\t" + ownerName);

            //color reset
            Console.ResetColor();
        }

        //get the name of the user 
        static void GetUserName()
        {
            //text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //username
            Console.WriteLine("Please enter your name");

            //Get user input
            String nameInput = Console.ReadLine();

            Console.WriteLine("{0}", nameInput);
        }

        //get the color of the message
        static void GetColorMessage(ConsoleColor color, string message)
        {
            //text color
            Console.ForegroundColor = color;

            //Not a value
            Console.WriteLine(message);

            //color reset
            Console.ResetColor();
        }
    }
}