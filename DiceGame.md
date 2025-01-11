using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }
    }

    static void PlayGame()
    {
        var play = true;

        while (play)
        {
            int target = random.Next(1, 7); // Target number to beat
            int roll = random.Next(1, 7); // Dice roll

            Console.WriteLine($"Roll a number greater than {target} to win!");
            Console.WriteLine($"You rolled a {roll}");
            Console.WriteLine(WinOrLose(roll, target) ? "You win!" : "You lose!");
            Console.WriteLine("\nPlay again? (Y/N)");

            play = ShouldPlay();
        }
    }

    static bool WinOrLose(int roll, int target)
    {
        return roll > target;
    }

    static bool ShouldPlay()
    {
        string input = Console.ReadLine().Trim().ToUpper();
        return input == "Y";
    }
}