/*
* This program lets you participate in the Coin Flip Challenge.
* You'll be asked for your name, and then whether you want to take the challenge.
* If you agree, you'll have five rounds to guess if the coin flip is heads or tails.
* Every correct guess increases your score by 1. Your final score will be displayed at the end.
*/
using System;



class Program
{
    static void Main()
    {
        //  Ask for the user's name and store it
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string? userName = Console.ReadLine();

        // Are we doing the Coin Flip Challenge
        Console.WriteLine($"Welcome {userName}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string? userResponse = Console.ReadLine()?.Trim().ToLower();

        //  Check if the user agrees to play the game
        if (userResponse == "no")
        {
            Console.WriteLine($"You are a coward, {userName}.");
            return; // End the program if the user does not want to play
        }

        //  Start the game if the user agrees to play
        int score = 0; // Initialize the score

        Random random = new(); // Create a random number generator

        // Loop the challenge 5 times
        for (int round = 1; round <= 5; round++)
        {
            // Generate a random number
            int coinFlipResult = random.Next(0, 2);

            //  Ask the user to guess heads or tails
            Console.WriteLine("Heads or Tails?");
            string? userGuess = Console.ReadLine()?.Trim().ToLower();

            //  Compare the guess to the coin flip result
            int userGuessValue = (userGuess == "heads") ? 0 : 1;

            // 8. Check if the guess is correct
            if (userGuessValue == coinFlipResult)
            {
                Console.WriteLine("Correct!");
                score++; // Add one to the score if the guess is correct
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        // 9. Display the final score
        Console.WriteLine($"Thank you, {userName}. You got a score of {score}!");
    }
}
