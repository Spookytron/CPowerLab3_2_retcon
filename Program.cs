using System;
using System.Collections.Generic;

namespace Lab3_2
{
    class Program
    {
        static bool KeepGoing()
        {

            while (true)
            {
               Console.WriteLine("Would you like to try again? (y/n)");

                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "no" || response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");
                }
            }

        }


        static void Main(string[] args)
        {   //Making a deli counter menu, displaying list of menu items and prices.
            // users can add new menu items
            //users can remove menu items
            //users can change the prices of menu items.
            Dictionary<string, decimal> deli = new Dictionary<string, decimal>();
            deli["SAMMICH"] = 5.99m;
            deli["VEGGIES"] = 7.99m;
            deli["SINGLE POTATO"] = 15.00m;
            Console.WriteLine("Welcome to the DevBuild Deli!");
            do
            {


                Console.WriteLine("Here is the menu!");
                foreach (var pair in deli)
                {
                    Console.WriteLine($"{pair.Key} is {pair.Value} dollars.");
                }
                Console.WriteLine("Would you like to Add a new item (A), Remove an item (R), Change an item's price (C) or Quit (Q)?");
                string response = Console.ReadLine();
                response = response.ToUpper();
                switch (response)
                {
                    case "A":
                        Console.WriteLine("What item would you like to add?");
                        string add = Console.ReadLine();
                        Console.WriteLine("How much is it?");
                        decimal price = decimal.Parse(Console.ReadLine());
                        deli.Add(add, price);
                        Console.WriteLine($"Product {add} was added to the menu at {price} dollars and cents.");
                        break;
                    case "R":
                        Console.WriteLine("What item would you like to remove?");
                        string entry = Console.ReadLine();
                        entry = entry.ToUpper();
                        switch (entry)
                        {
                            case "SAMMICH":
                                deli.Remove("SAMMICH");
                                Console.WriteLine("'SAMMICH' was removed from the menu.");
                                break;
                            case "VEGGIES":
                                deli.Remove("VEGGIES");
                                Console.WriteLine("'VEGGIES' were removed from the menu.");
                                break;
                            case "SINGLE POTATO":
                                deli.Remove("SINGLE POTATO");
                                Console.WriteLine("A 'SINGLE POTATO' was removed from the menu.");
                                break;
                            default:
                                Console.WriteLine("That selection does not exist.");
                                break;

                        }
                        break;
                    case "C":
                        Console.WriteLine("What item's price would you like to change?");
                        string ent = Console.ReadLine();
                        ent = ent.ToUpper();
                        Console.WriteLine("What is the new price?");
                        decimal price2 = decimal.Parse(Console.ReadLine());
                        deli[ent] = price2;
                        Console.WriteLine($"The new price of {ent} is {price2}");
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for visiting the DevBuild Deli!");
                        break;
                    default:
                        Console.WriteLine("That is not an acceptable response, please try again.");
                        break;
                }
            }
            while (KeepGoing());

        }
    }
}
