using System;

namespace RockPaperScissors{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain  = true;
            string player;
            string computer;
            string answer;

            while(playAgain == true)
            {
            player = "";
            computer = "";
            answer = "";

            while(player != "Rock" && player !="Paper" && player != "Scissors")
            {
                Console.WriteLine("Please enter Rock,Paper or Scissors");
                player = Console.ReadLine();
                player.ToUpper();
            }

            switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "Rock";
                        break;
                    case 2:
                        computer = "Paper";
                        break;
                    case 3:
                        computer = "Scissors";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "Rock":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "Paper":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "Scissors":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

            Console.Write("Would you like to play again (Yes/No): ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Yes")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
            
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
            }            
        }
    }
}