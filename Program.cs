using System;

namespace C_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wantingToPlay = true;
            int timesWon = 0;
            while (wantingToPlay) {
            Console.Clear();

            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            // 1 = rock, 2 = paper, 3 = scissors
            Console.WriteLine("Pick Rock, Paper, Scissors");
        
            var playerChoice = Console.ReadLine().ToLower();
            if (randomNumber == 1 && playerChoice == "paper" || randomNumber == 2 && playerChoice == "scissors" || randomNumber == 3 && playerChoice == "rock"){
                Console.WriteLine("You Win!");
                timesWon++;
            }
            else if(randomNumber == 1 && playerChoice == "rock" || randomNumber == 2 && playerChoice == "paper" || randomNumber == 3 && playerChoice == "scissors"){
                Console.WriteLine("You Tie!");
            } else {
                Console.WriteLine("You Suck Loser!");
            }
            System.Console.WriteLine("Times you've won: " + timesWon);
            Console.Write("Play Again? Y/n: ");
            var choice = Console.ReadKey();
            if (choice.Key != ConsoleKey.Y){
                wantingToPlay = false;
            }
            }
            System.Console.WriteLine(" Okay by loser!!");
            timesWon = 0;
        }
    }
}
