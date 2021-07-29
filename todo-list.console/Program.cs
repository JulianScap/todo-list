using System;
using System.Collections.Generic;

namespace TodoTool
{
    internal static class Program
    {
        private static readonly List<string> todoList = new List<string>
        {
            "Go to school",
            "Eat bread",
            "Have a nap"
        };

        static void Main()
        {
            DisplayMenu();
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            while (keyPressed.Key != ConsoleKey.Q)
            {
                if (keyPressed.Key == ConsoleKey.A)
                {
                    DisplayAddMenu();
                }
                else if (keyPressed.Key == ConsoleKey.R)
                {
                    DisplayRemoveMenu();
                }

                DisplayMenu();
                keyPressed = Console.ReadKey(true);
            }
        }

        private static void DisplayRemoveMenu()
        {
            Console.Clear();
            PrintTodoList();

            Console.WriteLine("What item number do you want to remove?");
            string numberAsString = Console.ReadLine();

            if (int.TryParse(numberAsString, out int itemNumber)
                && itemNumber >= 1
                && itemNumber <= todoList.Count)
            {
                todoList.RemoveAt(itemNumber - 1);
            }
        }

        private static void PrintTodoList()
        {
            var counter = 1;

            foreach (string item in todoList)
            {
                Console.WriteLine($"{counter} - {item}");
                counter += 1;
            }
        }

        private static void DisplayAddMenu()
        {
            Console.Clear();
            Console.WriteLine("Please enter your todo:");
            todoList.Add(Console.ReadLine());
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            PrintTodoList();
            Console.WriteLine("MENU - [A]dd - [R]emove - [Q]uit");
        }
    }
}
