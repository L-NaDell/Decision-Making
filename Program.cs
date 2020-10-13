using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();

            string again = "y";

            while (again.ToLower() == "y")
            {
                Console.WriteLine($"{name}, please enter a number between 1 and 100:");
                int number = int.Parse(Console.ReadLine());

                if (number > 0 && number < 101)
                {
                    if (number <= 25 && number % 2 == 0)
                    {
                        Console.WriteLine($"{name}, {number} is even and less than 25.");
                    }

                    else if (number <= 60 && number % 2 == 0)
                    {
                        Console.WriteLine($"{name}, {number} is even.");
                    }

                    else if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is even, {name}.");
                    }

                    else
                    {
                        Console.WriteLine($"{number} is odd, {name}.");
                    }

                    Console.WriteLine("Do you want to enter another number? (y/n)");
                    again = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{name}, {number} is not between 1 and 100. Please try again.");
                    again = "y";
                }
            }

            Console.WriteLine($"Goodbye {name}!");
        }
    }
}

