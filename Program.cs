using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("<<Welcome>>");
           Console.ResetColor();

           Console.WriteLine("What is your name?");
           string inputName = Console.ReadLine();
           Console.WriteLine("Hello {0}, let's play a game...", inputName);

           Random random = new Random();
           int correctNumber = random.Next(1,10);
           int guess = 0;
           Console.WriteLine("Guess a number between 1 and 10");
           while(guess != correctNumber){
               string input = Console.ReadLine();
               if(!int.TryParse(input, out guess)){
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Not a number, Try again");
                   Console.ResetColor();
                   continue;
               }
               guess = Int32.Parse(input);
               if(guess != correctNumber){
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Wrong number, Try again");
                   Console.ResetColor();
               }
           }
           Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("You are CORRECT!");
                   Console.ResetColor();
        }
    }
}
