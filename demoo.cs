using System;

enum Move
{
    Rock = 1,
    Paper = 2,
    Scissors = 3
}

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerScore = 0;
        int computerScore = 0;

        Console.WriteLine("=== Rock-Paper-Scissors ===");

        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine($"\nRound {round}");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.Write("Choose your move: ");

            if (!int.TryParse(Console.ReadLine(), out int choice)
                || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Try again.");
                round--;
                continue;
            }

            Move player = (Move)choice;
            Move computer = (Move)random.Next(1, 4);

            Console.WriteLine($"You chose: {player}");
            Console.WriteLine($"Computer chose: {computer}");

            if (player == computer)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (
                (player == Move.Rock && computer == Move.Scissors) ||
                (player == Move.Paper && computer == Move.Rock) ||
                (player == Move.Scissors && computer == Move.Paper))
            {
                Console.WriteLine("You win this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computerScore++;
            }
        }

        Console.WriteLine("\n=== Final Results ===");
        Console.WriteLine($"Your score: {playerScore}");
        Console.WriteLine($"Computer score: {computerScore}");

        if (playerScore > computerScore)
            Console.WriteLine("Congratulations! You won the game.");
        else if (playerScore < computerScore)
            Console.WriteLine("Computer won the game.");
        else
            Console.WriteLine("The game ended in a draw.");
    }
}