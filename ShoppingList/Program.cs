using System;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, string> {
                {"apple", "0.99"},
                {"coca-cola", "1.99"},
                {"grapes", "3.99"},
                {"doritos", "2.99"},
                {"bubble gum", "0.99"},
                {"book", "10.99"},
                {"candle", "11.99"},
                {"sun glasses", "8.99"}
            };

            var order = new List<string>();

            do
            {
                PrintMenu(ref items);

                Console.Write("\nWhat item would you like to order: ");
                string item = Console.ReadLine().ToLower();

                if (items.Keys.Contains(item))
                {
                    order.Add(item);
                }
                else
                {
                    Console.WriteLine("\nSorry, that item is not in the list...\n");
                    continue;
                }

                Console.Write("\nWould you like to add another item to your list? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") break;

                Console.WriteLine("\n");

            } while (true);

            decimal totalPrice = new Func<decimal>(() => {
                decimal total = 0;
                foreach (var item in order)
                {
                    total += decimal.Parse(items[item]);
                }

                return total;
            })();

            decimal avgPrice = new Func<decimal>(() => {
                decimal total = 0;
                foreach(var item in order)
                {
                    total += decimal.Parse(items[item]);
                }

                return total / order.Count;
            })();

            Console.WriteLine("\nThanks for your order!\nHere's what you got:\n");
            foreach (var item in order)
            {
                Console.WriteLine("\t{0,-12} ${1,-5}", item, items[item]);
            }
            Console.WriteLine("\t{0,-20}", "===================");
            Console.WriteLine("\t{0,-12} ${1,-5}", "total", totalPrice.ToString("######.00"));

            Console.WriteLine("\nAverage price per item: $" + avgPrice.ToString("######.00"));
        }

        static void PrintMenu(ref Dictionary<string, string> items) {
            Console.WriteLine("{0,-11}  {1,-5}", "Item", "Price");
            Console.WriteLine("{0,-20}", "===================");
            foreach (var item in items)
            {
                Console.WriteLine("{0,-11}  ${1,-5}", item.Key, item.Value);
            }
        }
    }
}
