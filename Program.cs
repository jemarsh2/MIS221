class Program
{
    static void Main()
    {
        System.Random rand = new System.Random();

        while (true)
        {
            System.Console.WriteLine("Enter 1 to display a random shape");
            System.Console.WriteLine("Enter 2 to exit");
            System.Console.Write("Choice: ");
            string choice = System.Console.ReadLine();

            if (choice == "1")
            {
                int shape = rand.Next(4); // 0 to 3

                if (shape == 0)
                    DisplayBrickWall(rand);
                else if (shape == 1)
                    DisplayWindow(rand);
                else if (shape == 2)
                    DisplayLadder(rand);
                else
                    DisplayScaffold(rand);
            }
            else if (choice == "2")
            {
                System.Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                System.Console.WriteLine("Invalid choice, please enter 1 or 2.");
            }

            System.Console.WriteLine();
        }
    }

    static void DisplayBrickWall(System.Random rand)
    {
        System.Console.WriteLine("\nBrick Wall:");

        int rows = rand.Next(5, 9);
        int cols = rand.Next(5, 9);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                // Random chance for a hole in the wall
                if (rand.Next(10) < 2)  // About 20% chance
                    System.Console.Write("       ");  // hole space
                else
                    System.Console.Write("[===]");
            }
            System.Console.WriteLine();
        }
    }

    static void DisplayWindow(System.Random rand)
    {
        System.Console.WriteLine("\nWindow:");

        int rows = rand.Next(5, 9);
        int cols = rand.Next(5, 9);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (r == 0 || r == rows - 1)
                    System.Console.Write("[  ]");
                else if (c == 0 || c == cols - 1)
                    System.Console.Write("[  ]");
                else
                    System.Console.Write("////");
            }
            System.Console.WriteLine();
        }
    }

    static void DisplayLadder(System.Random rand)
    {
        System.Console.WriteLine("\nLadder:");

        int steps = rand.Next(5, 9);

        for (int i = 0; i < steps; i++)
        {
            System.Console.WriteLine("|      |");
            System.Console.WriteLine("|------|");
        }
        System.Console.WriteLine("|      |");
    }

    static void DisplayScaffold(System.Random rand)
    {
        System.Console.WriteLine("\nScaffold:");

        int blocks = rand.Next(2, 5);

        for (int i = 0; i < blocks; i++)
        {
            System.Console.WriteLine("| \\    / |");
            System.Console.WriteLine("|  \\  /  |");
            System.Console.WriteLine("|   XX   |");
            System.Console.WriteLine("|  /  \\  |");
            System.Console.WriteLine("| /    \\ |");
        }
    }
}

