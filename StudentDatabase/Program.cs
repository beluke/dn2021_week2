using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2d student data array
            // [student_name, hometown, favorite_food]
            string[,] studentData = {
                { "John Doe", "Gibraltar, MI", "Apples" },
                { "Caleb Johnson","Detroi, MI","Pizza" },
                { "Sara Silverman","Sagniaw, MI","Tomatoes" },
                { "Kim Petras","Grand Rapids, MI","Gluten Free Bananas" },
                { "Beyonce Knowles","San Francisco, CA","Bread" },
                { "Charli XCX","Los Angeles, CA","Cotton Candy" }
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
                Console.WriteLine($"\n\tStudent name: {studentData[idx-1,0]}");

                do
                {
                    string category;
                    // enter try catch for getting category name
                    try
                    {
                        Console.Write("\nPlease enter category: ");
                        category = Console.ReadLine().ToLower();

                        // throw new exception if category is invalid

                        category = "favorite food".Contains(category) ? "favorite food" : "hometown".Contains(category) ? "hometown" : "";

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
                            Console.WriteLine($"\n\tHometown: {studentData[idx - 1, 1]}");
                            break;
                        case "favorite food":
                            Console.WriteLine($"\n\tFavorite food: {studentData[idx - 1,2]}");
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
