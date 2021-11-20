using System;

namespace CasinoDiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            do
            {
                // variable to store number of sides
                int nSides;
                try
                {
                    // prompt user for number of sides on dice
                    Console.Write("\nInput how many sides should each die have: ");
                    nSides = int.Parse(Console.ReadLine());
                }
                // handle improper input
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    // restart if exception caught
                    continue;
                }

                // number of rolls initialized at 1
                int nRolls = 1;
                do
                {
                    // dice variables
                    var die1 = GenerateRandomeDie(nSides);
                    var die2 = GenerateRandomeDie(nSides);

                    // output roll number and dice rolls, while simultaneously incrementing nRolls
                    Console.WriteLine($"\nRoll {nRolls++}:\nYou rolled: {die1} and {die2} ({die1 + die2} total)");

                    // act on 6 sided dice 
                    if (nSides == 6)
                    {
                        // dice result output
                        if (die1 == 1 && die2 == 1) Console.WriteLine("Snake Eyes: Two 1s");
                        else if (die1 == 1 && die2 == 2) Console.WriteLine("Ace Deuce: A 1 and 2.");
                        else if (die1 == 6 && die2 == 6) Console.WriteLine("Boxcars: Two 6s.");

                        // dice summation output
                        if (die1 + die2 == 2 || die1 + die2 == 3 || die1 + die2 == 12) Console.WriteLine("Craps!");
                        else if (die1 + die2 == 7 || die1 + die2 == 11) Console.WriteLine("Win!");
                    }

                    // ask user if they want to continue
                    Console.Write("\nWould you like to roll again? (y/n) (default = n): ");

                    // break of input is not "y" or "Y"
                    if (Console.ReadLine().ToLower() != "y")
                    {
                        // goodbye message
                        Console.WriteLine("\nThanks for playing!");
                        break;
                    }

                    // clear console for clean output
                    Console.Clear();

                } while (true);

                // break main loop on default
                break;

            } while (true);

        }

        static int GenerateRandomeDie(int nSides)
        {
            // create new random number generator
            var rand = new Random();
            // return next random number
            return rand.Next(1, nSides + 1);
        }
    }
}
