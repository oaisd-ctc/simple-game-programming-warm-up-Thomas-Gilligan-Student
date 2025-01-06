using System;

class Program
{
    public static int yourScore = 0;
    public static int rivalScore = 0;

    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Dice Game\n\nIn this game you and a computer Rival will play 10 rounds\nwhere you will each roll a 6-sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!\n\nPress any key to start...");
        Console.ReadKey(true);
        GameRounds();
    }

    public static void GameRounds()
    {
        Random rnd = new Random();
        for (int i = 1; i <= 10; i++)
        {
            int rivalRoll = rnd.Next(1, 7);
            Console.WriteLine($"\nRound {i}\nRival rolled a {rivalRoll}\nPress any key to roll the dice...");
            Console.ReadKey(true);
            int yourRoll = rnd.Next(1, 7);
            Console.WriteLine($"You rolled a {yourRoll}");
            if (rivalRoll < yourRoll) { Console.WriteLine("You won this round."); yourScore++; }
            if (rivalRoll > yourRoll) { Console.WriteLine("The Rival won this round."); rivalScore++; }
            if (rivalRoll == yourRoll) { Console.WriteLine("This round is a draw!"); }
            Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.\nPress any key to continue...");
            Console.ReadKey(true);
        }
        Console.WriteLine($"\nGame over.");
        Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}.");
        if (rivalScore < yourScore) Console.WriteLine("You won!");
        else if (rivalScore > yourScore) Console.WriteLine("You lost!");
        else if (rivalScore == yourScore) Console.WriteLine("This game is a draw.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}