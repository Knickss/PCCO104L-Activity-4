using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        string message = "";

        Console.WriteLine("Enter something:");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                sum += number;
                Console.WriteLine($"Adding {number} to {sum - number} = {sum}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current Message: {message}");
            }
        }
    }
}

