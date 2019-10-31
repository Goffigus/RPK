using System;
using static System.Console;

namespace RPK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int op;
            Random ranNumberGenerator = new Random();


            do
            {
                WriteLine("Choose Rock, Paper, or Knife: ");
                input = ReadLine();
                input = input.ToLower(); //makes user input all lower case

                op = ranNumberGenerator.Next(1, 3);

                if(input == "rock" && op == 1)
                {
                    WriteLine("Computer picked Rock");
                    WriteLine("You Tie");
                } else if (input == "rock" && op == 2)
                {
                    WriteLine("Computer picked Paper");
                    WriteLine("You Loose");
                } else if (input == "rock" && op == 3)
                {
                    WriteLine("Computer picked Knife");
                    WriteLine("You Win");
                } else if (input == "paper" && op == 1)
                {
                    WriteLine("Computer picked Rock");
                    WriteLine("You Win");
                }
                else if (input == "paper" && op == 2)
                {
                    WriteLine("Computer picked Paper");
                    WriteLine("You Tie");
                }
                else if (input == "paper" && op == 3)
                {
                    WriteLine("Computer picked knife");
                    WriteLine("You Loose");
                }
                else if (input == "knife" && op == 1)
                {
                    WriteLine("Computer picked Rock");
                    WriteLine("You Loose");
                }
                else if (input == "knife" && op == 2)
                {
                    WriteLine("Computer picked Paper");
                    WriteLine("You Win");
                }
                else if (input == "knife" && op == 3)
                {
                    WriteLine("Computer picked knife");
                    WriteLine("You Tie");
                } else if (input == "exit")
                {
                    WriteLine("Closing Program");
                } else
                {
                    WriteLine("That is not a valid choice");
                }


            } while (input != "exit");
        }
    }
}
