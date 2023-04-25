using System;
namespace Try2
{
	internal class Menu
	{
		public static void menu()
		{
            string[] moznosti = { "PLAY", "LEADERBOARD", "CREDITS","EXIT" };
            int vyber = 0;
          
            while (vyber < 4)
            {
                Console.CursorVisible = false;
                if (vyber == 0)
                {
                    Console.Clear();
                    Console.WriteLine("  _      ________   ___    _      ________________\n | | /| / /  _/ /  / _ \\  | | /| / / __/ __/_  __/\n | |/ |/ // // /__/ // /  | |/ |/ / _/_\\ \\  / /   \n |__/|__/___/____/____/   |__/|__/___/___/ /_/    \n                                                  ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("- PLAY -");
                    Console.WriteLine("LEADERBOARD");
                    Console.WriteLine("CREDITS");
                    Console.WriteLine("EXIT");
                    Console.WriteLine("-----------------------------------------------------");
                }

                ConsoleKeyInfo keypressed = Console.ReadKey();
                if (keypressed.Key == ConsoleKey.S || keypressed.Key == ConsoleKey.DownArrow) vyber++;
                if (keypressed.Key == ConsoleKey.W || keypressed.Key == ConsoleKey.UpArrow) vyber--;
                if (vyber == 4) vyber = 0;
                if (vyber == -1) vyber = 3;
                if (keypressed.Key == ConsoleKey.Escape) Exit.exit();

                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 0)
                {
                    Console.Clear();
                    Game.game();
                }

                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 1)
                {
                    Console.Clear();
                    Leaderboard.leaderboard();
                }

                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 2)
                {
                    Console.Clear();
                    Credits.credits();
                }

                if ((keypressed.Key == ConsoleKey.Enter || keypressed.Key == ConsoleKey.Spacebar) && vyber == 3)
                {
                    Console.Clear();
                    Exit.exit();
                }

                if (vyber == 1)
                {
                    Console.Clear();
                    Console.WriteLine("  _      ________   ___    _      ________________\n | | /| / /  _/ /  / _ \\  | | /| / / __/ __/_  __/\n | |/ |/ // // /__/ // /  | |/ |/ / _/_\\ \\  / /   \n |__/|__/___/____/____/   |__/|__/___/___/ /_/    \n                                                  ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("PLAY");
                    Console.WriteLine("- LEADERBOARD -");
                    Console.WriteLine("CREDITS");
                    Console.WriteLine("EXIT");
                    Console.WriteLine("-----------------------------------------------------");
                }

                if (vyber == 2)
                {
                    Console.Clear();
                    Console.WriteLine("  _      ________   ___    _      ________________\n | | /| / /  _/ /  / _ \\  | | /| / / __/ __/_  __/\n | |/ |/ // // /__/ // /  | |/ |/ / _/_\\ \\  / /   \n |__/|__/___/____/____/   |__/|__/___/___/ /_/    \n                                                  ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("PLAY");
                    Console.WriteLine("LEADERBOARD");
                    Console.WriteLine("- CREDITS -");
                    Console.WriteLine("EXIT");
                    Console.WriteLine("-----------------------------------------------------");
                }

                if (vyber == 3)
                {
                    Console.Clear();
                    Console.WriteLine("  _      ________   ___    _      ________________\n | | /| / /  _/ /  / _ \\  | | /| / / __/ __/_  __/\n | |/ |/ // // /__/ // /  | |/ |/ / _/_\\ \\  / /   \n |__/|__/___/____/____/   |__/|__/___/___/ /_/    \n                                                  ");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("PLAY");
                    Console.WriteLine("LEADERBOARD");
                    Console.WriteLine("CREDITS");
                    Console.WriteLine("- EXIT -");
                    Console.WriteLine("-----------------------------------------------------");
                }
            }
        }
	}
}

