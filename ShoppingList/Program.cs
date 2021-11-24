using System;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // map for items and prices
            var items = new Dictionary<string, decimal> {
                {"apple", 0.99m},
                {"coca-cola", 1.99m},
                {"grapes", 3.99m},
                {"doritos", 2.99m},
                {"bubble gum", 0.99m},
                {"book", 10.99m},
                {"candle", 11.99m},
                {"sun glasses", 8.99m}
            };

            // list for saving current order
            var order = new List<string>();
            
            // enter main loop
            do
            {
                // output menu to user
                PrintMenu(ref items);

                // prompt user to input item
                Console.Write("\nWhat item would you like to order: ");
                string item = Console.ReadLine().ToLower();

                // input validation
                if (items.Keys.Contains(item))
                {
                    order.Add(item);
                }
                else
                {
                    Console.WriteLine("\nSorry, that item is not in the list...\n");
                    continue;
                }
                
                // prompt user to add another item
                Console.Write("\nWould you like to add another item to your list? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") break;

                Console.WriteLine("\n");
            
            // continue loop on non input of "y"
            } while (true);

            // ouput information to user
            Console.WriteLine("\nThanks for your order!\nHere's what you got:\n");
            foreach (var item in order)
            {
                Console.WriteLine("\t{0,-12} ${1,-5}", item, items[item]);
            }
            Console.WriteLine("\t{0,-20}", "===================");
            Console.WriteLine("\t{0,-12} ${1,-5}", "total", getTotalPrice(ref items, ref order).ToString("######.00"));

            Console.WriteLine("\nAverage price per item: $" + getAvgPrice(ref items, ref order).ToString("######.00"));
        }

        // method for printing menu using map provided from main
        static void PrintMenu(ref Dictionary<string, decimal> items) {
            Console.WriteLine("{0,-11}  {1,-5}", "Item", "Price");
            Console.WriteLine("{0,-20}", "===================");
            foreach (var item in items)
            {
                Console.WriteLine("{0,-11}  ${1,-5}", item.Key, item.Value);
            }
        }
        
        static decimal getAvgPrice(ref Dictionary<string, decimal> items, ref List<string> order) {
            decimal total = 0;
            foreach(var item in order)
            {
                total += items[item];
            }
            return total / order.Count;
        }
        
        static decimal getTotalPrice(ref Dictionary<string, decimal> items, ref List<string> order) {
            decimal total = 0;
            foreach (var item in order)
            {
                total += items[item];
            }
            return total;
        }
    }
}
