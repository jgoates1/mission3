// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using mission4;

class Program
{
    static void Main()
    {
        List<FoodItem> inventory = new List<FoodItem>();
        while (true)
        {
            Console.WriteLine("Food Bank Inventory Menu:");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print Food Items");
            Console.WriteLine("4. Exit");
            
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter food name: ");
                string name = Console.ReadLine();
                Console.Write("Enter food category: ");
                string category = Console.ReadLine();
                // Safe quantity input
                int quantity;
                while (true)
                {
                    Console.Write("Enter quantity: ");
                    string qtyInput = Console.ReadLine();
                    if (int.TryParse(qtyInput, out quantity) && quantity >= 0) break;
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }
                // safe expirationDate stuff
                DateOnly expirationDate;
                while (true)
                {
                    Console.Write("Enter expiration date (MM/DD/YYYY): ");
                    string dateInput = Console.ReadLine();
                    if (DateOnly.TryParse(dateInput, out expirationDate)) break;
                    Console.WriteLine("Invalid date. Please enter in MM/DD/YYYY format.");
                }
                FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
                inventory.Add(newItem);
                Console.WriteLine("Food Item added");
            }
            else if (input == "2")
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("No items to delete");
                }
                else
                {
                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {inventory[i]}");
                    }
                
                    Console.WriteLine("Enter the number of the item to delete: ");
                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= inventory.Count)
                    {
                        inventory.RemoveAt(choice - 1);
                        Console.WriteLine("Food Item deleted");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again.");
                    }
                }
            }
            else if (input == "3")
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("No inventory found");
                }
                else
                {
                    foreach (FoodItem item in inventory)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
