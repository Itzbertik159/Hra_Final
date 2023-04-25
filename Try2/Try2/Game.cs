using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Try2
{
    internal class Game
    {
        public static void game()
        {
            Random random = new Random();
            double reactionTimex = 1000;
            int score = 0;
            int lifes = 5;
            string xlifes = "";
            bool Wrong = false;

            while (lifes != 0)
            {
                int key = random.Next(0, 4); 
                if (key == 0)
                {
                    if (lifes == 6) xlifes = "♥♥♥♥♥♥";
                    if (lifes == 5) xlifes = "♥♥♥♥♥";
                    if (lifes == 4) xlifes = "♥♥♥♥";
                    if (lifes == 3) xlifes = "♥♥♥";
                    if (lifes == 2) xlifes = "♥♥";
                    if (lifes == 1) xlifes = "♥";

                    Console.Clear();
                    Console.CursorVisible = false;
                    TimeSpan reqieredReactionTime = TimeSpan.FromMilliseconds(reactionTimex);
                    TimeSpan signal = TimeSpan.FromMilliseconds(random.Next(2500, 7500));
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_          wait          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < signal && tooFast == false)
                    {
                        if (Console.KeyAvailable)
                        {
                            tooFast = true;
                        }
                    }

                    Console.Clear();
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_          SPACE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    stopwatch.Restart();
                    bool tooSlow = true;
                    TimeSpan reactionTime = default;

                        while (tooFast == false && stopwatch.Elapsed < reqieredReactionTime && tooSlow == true)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key is ConsoleKey.Spacebar)
                        {
                            tooSlow = false;
                            reactionTime = stopwatch.Elapsed;
                        }
                        
                    }
                    if (tooFast == true || tooSlow == true)
                    {
                        lifes--;
                    }
                    else if (tooFast == false || tooSlow == false)
                    {
                        score++;
                        if (score % 2 == 0) reactionTimex /= 1.1;
                    }

                    if (tooFast == true && tooSlow == true)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           M            _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            MI           _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         MIS          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                            >\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        //\\\\\\\\\\\\
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_╔         MISS          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|            MISS       ㄱ_|\\|           \n            /\\╔                          /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -                    ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -F                   ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FU                  ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUC                 ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK                ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK.               ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK..              ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //SoundPlayer player = new SoundPlayer("path/to/sound/file.wav");
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);


                    }

                    if (tooSlow == true && tooFast == false && Wrong == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE       ㄱ_|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();


                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);

                    }
                  
                    else if (tooSlow == false && tooFast == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: "+score+"\n\n             _0                          0_            \n            |/|_           HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            HIT          _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        // Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           _0__╔                         >0_            \n          / |              HIT            || |          \n            /\\                             /\\           \n           /  |                           |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           0__╔                         ___0.         \n          / \\              HIT             /|       \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0__╔                            \\       \n           /|              HIT             /|0      \n            /\\                           _|\\           \n           /  |                            |          \n-----------------------------------------------------\n");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /||_╔          HIT         /|__\\0      \n            /\\                           |           \n           /  |                          |           \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /|l             HIT         /\\__\\0      \n            /\\                         /             \n           /  |                                      \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                                   \n           /||_            HIT            \\\\  \n            /\\                         /\\__\\0             \n           /  |                       —-             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                                   \n            |/|_           HIT              \n            /\\                              __      \n           /  |                       —/\\--0__             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("");
                        //Console.ReadKey();
                        string reactionTimeF = reactionTime.ToString("fff");
                        Console.WriteLine("Reaction Time: " + reactionTimeF + " milliseconds");
                        Thread.Sleep(200);
                        Console.WriteLine("Press any key to continue...");
                    }
                    ConsoleKeyInfo keypressed = Console.ReadKey();
                    if (keypressed.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    if (keypressed.Key == ConsoleKey.Escape)
                    {

                        Menu.menu();
                    }
                }
                if (key == 1)
                {

                    if (lifes == 6) xlifes = "♥♥♥♥♥♥";
                    if (lifes == 5) xlifes = "♥♥♥♥♥";
                    if (lifes == 4) xlifes = "♥♥♥♥";
                    if (lifes == 3) xlifes = "♥♥♥";
                    if (lifes == 2) xlifes = "♥♥";
                    if (lifes == 1) xlifes = "♥";

                    Console.Clear();
                    Console.CursorVisible = false;
                    TimeSpan reqieredReactionTime = TimeSpan.FromMilliseconds(reactionTimex);
                    TimeSpan signal = TimeSpan.FromMilliseconds(random.Next(2500, 7500));
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_          wait          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < signal && tooFast == false)
                    {
                        if (Console.KeyAvailable)
                        {
                            tooFast = true;
                        }
                    }
                    Console.Clear();
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_            Q           _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    stopwatch.Restart();
                    bool tooSlow = true;
                    TimeSpan reactionTime = default;
                    while (tooFast == false && stopwatch.Elapsed < reqieredReactionTime && tooSlow == true)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key is ConsoleKey.Q)
                        {
                            tooSlow = false;
                            reactionTime = stopwatch.Elapsed;
                        }

                    }
                    if (tooFast == true || tooSlow == true)
                    {
                        lifes--;
                    }
                    else if (tooFast == false || tooSlow == false)
                    {
                        score++;
                        if (score % 2 == 0) reactionTimex /= 1.25;
                    }

                    Console.Clear();
                    //Console.WriteLine(
                    //    tooFast ? loseTooFast :
                    //    tooSlow ? loseTooSlow :
                    //    "Win Reaction Time: " + reactionTime + "milliseconds");
                    if (tooFast == true && tooSlow == true)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           M            _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            MI           _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         MIS          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                            >\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        //\\\\\\\\\\\\
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_╔         MISS          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|            MISS       ㄱ_|\\|           \n            /\\╔                          /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -                    ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -F                   ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FU                  ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUC                 ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK                ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK.               ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK..              ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);
                    }


                    if (tooSlow == true && tooFast == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE       ㄱ_|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();


                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);
                    }
                    else if (tooSlow == false && tooFast == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            HIT          _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        // Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           _0__╔                         >0_            \n          / |              HIT            || |          \n            /\\                             /\\           \n           /  |                           |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           0__╔                         ___0.         \n          / \\              HIT             /|       \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0__╔                            \\       \n           /|              HIT             /|0      \n            /\\                           _|\\           \n           /  |                            |          \n-----------------------------------------------------\n");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /||_╔          HIT         /|__\\0      \n            /\\                           |           \n           /  |                          |           \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /|l             HIT         /\\__\\0      \n            /\\                         /             \n           /  |                                      \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                                   \n           /||_            HIT            \\\\  \n            /\\                         /\\__\\0             \n           /  |                       —-             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                                   \n            |/|_           HIT              \n            /\\                              __      \n           /  |                       —/\\--0__             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("");
                        //Console.ReadKey();
                        string reactionTimeF = reactionTime.ToString("fff");
                        Console.WriteLine("Reaction Time: " + reactionTimeF + " milliseconds");
                        Thread.Sleep(200);
                        Console.WriteLine("Press any key to continue...");
                    }



                    ConsoleKeyInfo keypressed = Console.ReadKey();
                    if (keypressed.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    if (keypressed.Key == ConsoleKey.Escape)
                    {

                        Menu.menu();
                    }
                }
                if (key == 2)
                {
                    if (lifes == 6) xlifes = "♥♥♥♥♥♥";
                    if (lifes == 5) xlifes = "♥♥♥♥♥";
                    if (lifes == 4) xlifes = "♥♥♥♥";
                    if (lifes == 3) xlifes = "♥♥♥";
                    if (lifes == 2) xlifes = "♥♥";
                    if (lifes == 1) xlifes = "♥";

                    Console.Clear();
                    Console.CursorVisible = false;
                    TimeSpan reqieredReactionTime = TimeSpan.FromMilliseconds(reactionTimex);
                    TimeSpan signal = TimeSpan.FromMilliseconds(random.Next(2500, 7500));
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_          wait          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < signal && tooFast == false)
                    {
                        if (Console.KeyAvailable)
                        {
                            tooFast = true;
                        }
                    }

                    Console.Clear();
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_            W           _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    stopwatch.Restart();
                    bool tooSlow = true;
                    TimeSpan reactionTime = default;
                    while (tooFast == false && stopwatch.Elapsed < reqieredReactionTime && tooSlow == true)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key is ConsoleKey.W)
                        {
                            tooSlow = false;
                            reactionTime = stopwatch.Elapsed;
                        }
                    }
                    if (tooFast == true || tooSlow == true)
                    {
                        lifes--;
                    }
                    else if (tooFast == false || tooSlow == false)
                    {
                        score++;
                        if (score % 2 == 0) reactionTimex /= 1.25;
                    }

                    if (tooFast == true && tooSlow == true)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           M            _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            MI           _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         MIS          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                            >\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_╔         MISS          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|            MISS       ㄱ_|\\|           \n            /\\╔                          /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -                    ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -F                   ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FU                  ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUC                 ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK                ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK.               ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK..              ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);

                    }

                    if (tooSlow == true && tooFast == false && Wrong == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE       ㄱ_|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();


                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);

                    }

                    else if (tooSlow == false && tooFast == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            HIT          _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        // Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           _0__╔                         >0_            \n          / |              HIT            || |          \n            /\\                             /\\           \n           /  |                           |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           0__╔                         ___0.         \n          / \\              HIT             /|       \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0__╔                            \\       \n           /|              HIT             /|0      \n            /\\                           _|\\           \n           /  |                            |          \n-----------------------------------------------------\n");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /||_╔          HIT         /|__\\0      \n            /\\                           |           \n           /  |                          |           \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /|l             HIT         /\\__\\0      \n            /\\                         /             \n           /  |                                      \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                                   \n           /||_            HIT            \\\\  \n            /\\                         /\\__\\0             \n           /  |                       —-             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                                   \n            |/|_           HIT              \n            /\\                              __      \n           /  |                       —/\\--0__             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("");
                        //Console.ReadKey();
                        string reactionTimeF = reactionTime.ToString("fff");
                        Console.WriteLine("Reaction Time: " + reactionTimeF + " milliseconds");
                        Thread.Sleep(200);
                        Console.WriteLine("Press any key to continue...");
                    }

                    ConsoleKeyInfo keypressed = Console.ReadKey();
                    if (keypressed.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    if (keypressed.Key == ConsoleKey.Escape)
                    {
                        Menu.menu();
                    }
                }
                if (key == 3)
                {
                    if (lifes == 6) xlifes = "♥♥♥♥♥♥";
                    if (lifes == 5) xlifes = "♥♥♥♥♥";
                    if (lifes == 4) xlifes = "♥♥♥♥";
                    if (lifes == 3) xlifes = "♥♥♥";
                    if (lifes == 2) xlifes = "♥♥";
                    if (lifes == 1) xlifes = "♥";

                    Console.Clear();
                    Console.CursorVisible = false;
                    TimeSpan reqieredReactionTime = TimeSpan.FromMilliseconds(reactionTimex);
                    TimeSpan signal = TimeSpan.FromMilliseconds(random.Next(2500, 7500));
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_          wait          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < signal && tooFast == false)
                    {
                        if (Console.KeyAvailable)
                        {
                            tooFast = true;
                        }
                    }

                    Console.Clear();
                    Console.Write("Lifes: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(xlifes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Score: " + score);
                    Console.WriteLine("\n             _0                          0_            \n            |/|_            E           _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                    stopwatch.Restart();
                    bool tooSlow = true;
                    TimeSpan reactionTime = default;

                    while (tooFast == false && stopwatch.Elapsed < reqieredReactionTime && tooSlow == true)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key is ConsoleKey.E)
                        {
                            tooSlow = false;
                            reactionTime = stopwatch.Elapsed;
                        }
                    }
                    if (tooFast == true || tooSlow == true)
                    {
                        lifes--;
                    }
                    else if (tooFast == false || tooSlow == false)
                    {
                        score++;
                        if (score % 2 == 0) reactionTimex /= 1.25;
                    }

                    if (tooFast == true && tooSlow == true)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           M            _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            MI           _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         MIS          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                            >\n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        //\\\\\\\\\\\\
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             MISS         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_╔         MISS          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|            MISS       ㄱ_|\\|           \n            /\\╔                          /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -                    ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -F                   ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FU                  ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUC                 ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK                ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK.               ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK..              ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           MISS           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);


                    }

                    if (tooSlow == true && tooFast == false && Wrong == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_           LATE       ㄱ_|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();


                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //SoundPlayer player = new SoundPlayer("path/to/sound/file.wav");
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        //x
                        Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();

                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("Press any key to continue...");//
                        Console.ReadKey(true);

                    }

                    else if (tooSlow == false && tooFast == false)
                    {
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            HIT          _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        // Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           _0__╔                         >0_            \n          / |              HIT            || |          \n            /\\                             /\\           \n           /  |                           |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n           0__╔                         ___0.         \n          / \\              HIT             /|       \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0__╔                            \\       \n           /|              HIT             /|0      \n            /\\                           _|\\           \n           /  |                            |          \n-----------------------------------------------------\n");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /||_╔          HIT         /|__\\0      \n            /\\                           |           \n           /  |                          |           \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                             \\\\       \n           /|l             HIT         /\\__\\0      \n            /\\                         /             \n           /  |                                      \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n            0                                   \n           /||_            HIT            \\\\  \n            /\\                         /\\__\\0             \n           /  |                       —-             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        //Console.ReadKey();
                        Console.Clear();
                        Console.Write("Lifes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(xlifes);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nScore: " + score + "\n\n             _0                                   \n            |/|_           HIT              \n            /\\                              __      \n           /  |                       —/\\--0__             \n-----------------------------------------------------");
                        Thread.Sleep(100);
                        Console.WriteLine("");
                        //Console.ReadKey();
                        string reactionTimeF = reactionTime.ToString("fff");
                        Console.WriteLine("Reaction Time: " + reactionTimeF + " milliseconds");
                        Thread.Sleep(200);
                        Console.WriteLine("Press any key to continue...");
                    }
                    ConsoleKeyInfo keypressed = Console.ReadKey();
                    if (keypressed.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    if (keypressed.Key == ConsoleKey.Escape)
                    {

                        Menu.menu();
                    }
                }
            }

            Console.Clear();
            Console.WriteLine(" __  ______  __  __  __   ____  __________\n \\ \\/ / __ \\/ / / / / /  / __ \\/ __/_  __/\n  \\  / /_/ / /_/ / / /__/ /_/ /\\ \\  / /   \n  /_/\\____/\\____/ /____/\\____/___/ /_/    \n                                          ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("YOUR SCORE: " + score);
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            StreamWriter sw = new StreamWriter("Leaderboard.txt",true);
            sw.WriteLine(name + " - "+score);
            sw.Close();

            Menu.menu();



        }
    }
}
