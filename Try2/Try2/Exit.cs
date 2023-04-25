using System;
namespace Try2
{
	internal class Exit
	{
		public static void exit()
		{
            string[] moznosti = { "Yes", "No" };
            int vyber = 0;

            while (vyber < 2)
            {
                if (vyber == 0)
                {
                    Console.Clear();
                    Console.WriteLine("   _____  ____________\n  / __/ |/_/  _/_  __/\n / _/_>  <_/ /  / /   \n/___/_/|_/___/ /_/    \n                      ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Are you sure that you want to leave?");
                    Console.WriteLine("- YES -");
                    Console.WriteLine("NO");
                }

                ConsoleKeyInfo keypressed = Console.ReadKey();
                if (keypressed.Key == ConsoleKey.S || keypressed.Key == ConsoleKey.DownArrow) vyber++;
                if (keypressed.Key == ConsoleKey.W || keypressed.Key == ConsoleKey.UpArrow) vyber--;
                if (vyber == 2) vyber = 0;
                if (vyber == -1) vyber = 1;
                if (keypressed.Key == ConsoleKey.Escape) Menu.menu();

                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 0)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 1)
                {
                    Console.Clear();
                    Menu.menu();
                }

                if (vyber == 1)
                {
                    Console.Clear();
                    Console.WriteLine("   _____  ____________\n  / __/ |/_/  _/_  __/\n / _/_>  <_/ /  / /   \n/___/_/|_/___/ /_/    \n                      ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Are you sure that you want to leave?");
                    Console.WriteLine("YES");
                    Console.WriteLine("- NO-");
                }
            }
        }
	}
}

