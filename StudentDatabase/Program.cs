using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // student data arrays
            string[] studentNames = {
                "John Doe", 
                "Caleb Johnson",
                "Sara Silverman",
                "Kim Petras",
                "Beyonce Knowles",
                "Charli XCX",
            };
            
            string[] hometowns = {
                "Gibraltar, MI",
                "Detroi, MI",
                "Sagniaw, MI",
                "Grand Rapids, MI",
                "San Francisco, CA",
                "Los Angeles, CA"
            };
            
            string[] favoriteFoods = {
                "Apples",
                "Pizza",
                "Tomatoes",
                "Gluten Free Bananas",
                "Bread",
                "Cotton Candy"
            };

            do
            {
                // index variable
                int idx;
                try
                {
                    // prompt user
                    Console.Write("Please enter the student number (1-6): ");
                    idx = int.Parse(Console.ReadLine());

                    // throw new exception if input is out of range
                    if (idx <= 0 || idx > 6) throw new Exception($"{idx} is out of range. Please try again!");
                }
                // handle any exception
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                // output student name
                Console.WriteLine($"\n\tStudent name: {studentNames[idx-1]}");

                do
                {
                    string category;
                    // enter try catch for getting category name
                    try
                    {
                        // prompt user for category
                        Console.Write("\nPlease enter category (\"hometown\" or \"favorite food\"): ");
                        category = Console.ReadLine().ToLower();
                         
                        // determine which category
                        category = "favorite food".Contains(category) ? "favorite food" : "hometown".Contains(category) ? "hometown" : "";

                        // throw new exception if category is invalid
                        if (category.Length <= 0)
                            throw new Exception($"Invalid category. Please try again!");
                    }
                    // handle any exception
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    // dispaly info based on category
                    switch (category) {
                        case "hometown":
                            Console.WriteLine($"\n\tHometown: {hometowns[idx-1]}");
                            break;
                        case "favorite food":
                            Console.WriteLine($"\n\tFavorite food: {favoriteFoods[idx-1]}");
                            break;
                        default:
                            // should never be reached
                            Console.WriteLine("\n\tDefault case reached in second menu...");
                            break;
                    };

                    // default is break loop
                    break;

                } while (true);

                Console.Write("\nWould you like to inquire about another stduent? (y/n) (default = n): ");
                string input = Console.ReadLine().ToLower();

                // only continue if input is not y or yes
                if (input != "y" && input != "yes") break;

                // add new line if conintuing for clean output
                Console.WriteLine();
            } while (true);
            

        }
    }
}
