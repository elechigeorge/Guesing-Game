using System;

public class Program
{
    public static void Main()
    {
        string word = "fiddle";
        bool isCorrect = false;
        string gueseWord;
        int count = 0;

        Console.WriteLine("Welcome to .Net Guesing Game.");


        while (isCorrect == false && count < 6)
        {
            Console.WriteLine("Type your guesing word ");
            gueseWord = Console.ReadLine();

            if (gueseWord == word)
            {
                Console.WriteLine("Congrat! Your guese is right...");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Oh Snap! Your guese is wrong...");
                count = count + 1;
            }
        }

        Console.WriteLine("Oh.. You have exceeded your guese limit... Try restarting the console");


    }
}