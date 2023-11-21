using System;
using System.Collections.Generic;

namespace DelegateKeypress
{
    class DelegateKeypress
    {
        private static int x = 20;
        private static int y = 20;

        // Define the console boundaries
        private static int consoleWidth = Console.WindowWidth;
        private static int consoleHeight = Console.WindowHeight;

        // Delegate for the actions
        delegate void ActionDelegate();

        // Dictionary to store the association between the KeyPress and the Action
        private static Dictionary<ConsoleKey, ActionDelegate> myControls = new Dictionary<ConsoleKey, ActionDelegate>();

        private static void Main(string[] args)
        {
            // Set up control scheme
            myControls.Add(ConsoleKey.W, Up);
            myControls.Add(ConsoleKey.S, Down);
            myControls.Add(ConsoleKey.A, Left);
            myControls.Add(ConsoleKey.D, Right);
            myControls.Add(ConsoleKey.Escape, Exit); // Use Escape key to terminate the app

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("@");

                var key = Console.ReadKey(true);

                int oldX = x;
                int oldY = y;

                // Use a delegate to perform the correct action
                if (myControls.ContainsKey(key.Key))
                {
                    myControls[key.Key]();
                }

                Console.SetCursorPosition(oldX, oldY);
                Console.Write(" ");
            }
        }

        private static void Right()
        {
            if (x < consoleWidth - 1) x++;
        }

        private static void Left()
        {
            if (x > 0) x--;
        }

        private static void Down()
        {
            if (y < consoleHeight - 1) y++;
        }

        private static void Up()
        {
            if (y > 0) y--;
        }

        private static void Exit()
        {
            Environment.Exit(0); // Terminate the application
        }
    }
}
