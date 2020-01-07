using System;
public class Class1
{
    {
        Random numbergemerator = new Random();
        int num1 = numbergenerator.Next(1, 11);
        int num2 = numbergenerator.Next(1, 11);
        int score = 0;

        Console.WriteLine("Whats " + num1 + " times " + num2 + "?");
        var answer = Convert.ToInt32(Console.ReadLine());

        if (answer == num1 * num2) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your card is higher, you won that round!");
            Console.ResetColor();
            ++score;
            Console.WriteLine("Your score: " + score);
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Uh oh, your card is smaller than the opponent's, try again.");
            Console.ResetColor();
          ++score;
            Console.WriteLine("Your score: " + score);
        }
        go to start;

    }
}