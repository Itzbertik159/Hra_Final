using System;
using System.Media;
using static System.Formats.Asn1.AsnWriter;

namespace Try2
{
	internal class Wait
	{
		public static void wait()
		{

            //     Console.Write("Score:\nLifes:\n\n\n             _0                          0_            \n            |/|_           HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //     Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();


            //     Console.Write("Score:\nLifes:\n\n\n             _0                          0_            \n            |/|            HIT          _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //     Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            //     Console.Write("Score:\nLifes:\n\n\n             _0                          0_            \n            |/|_╔         HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //     Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n             _0__╔                      0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n             _0__╔<                     0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n             _0__╔<.                    0_            \n            |/             HIT          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            // Thread.Sleep(100);
            //// //Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n           _0__╔                         >0_            \n          / |              HIT            || |          \n            /\\                             /\\           \n           /  |                           |  \\          \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n           0__╔                         ___0.         \n          / \\              HIT             /|       \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n            0__╔                            \\       \n           /|              HIT             /|0      \n            /\\                           _|\\           \n           /  |                            |          \n-----------------------------------------------------\n");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n            0                             \\\\       \n           /||_╔          HIT         /|__\\0      \n            /\\                           |           \n           /  |                          |           \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n            0                             \\\\       \n           /|l             HIT         /\\__\\0      \n            /\\                         /             \n           /  |                                      \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n            0                                   \n           /||_            HIT            \\\\  \n            /\\                         /\\__\\0             \n           /  |                       —-             \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();

            // Console.Write("Score:\nLifes:\n\n\n             _0                                   \n            |/|_           HIT              \n            /\\                              __      \n           /  |                       —/\\--0__             \n-----------------------------------------------------");
            // Thread.Sleep(100);
            // ////Console.ReadKey();
            // Console.Clear();
















            int xlifes = 1;
            int score = 2;

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_           M            _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|            MI           _|\\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0                          0_            \n            |/|_╔         MIS          _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0__╔                      0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0__╔<                     0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n             _0__╔<.                    0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                            >\n\n             _0__╔                      0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();
            ////\\\\\\\\\\\\
            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0__╔                      0_            \n            |/             LATE         _|\\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|_╔         LATE          |\\|           \n            /\\                           l/\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0                          0_            \n            |/|            LATE       ㄱ_|\\|           \n            /\\╔                          /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            LATE           \\|           \n            /\\l                           /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|            LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0                      ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -                    ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -F                   ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FU                  ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUC                 ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK                ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK.               ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK..              ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "                                                    \n\n             _0 -FUCK...             ㄱ__0_            \n            |/|_           LATE           \\|           \n            /\\                            /\\           \n           /  |                          |  \\          \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////SoundPlayer player = new SoundPlayer("path/to/sound/file.wav");
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            ////x
            //Console.Write("\nScore: " + score + "\n\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n\n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        Y                        \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YO                       \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOU                        \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOUR                       \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE                       \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE D                        \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE DE                        \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEA                       \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();

            //Console.Clear();
            //Console.Write("Lifes: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(xlifes);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
            //Thread.Sleep(100);
            ////Console.ReadKey();















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
            Console.Write("\nScore: " + score + "\n\n\n                        YOURE DEAD                      \n\n       \n-----------------------------------------------------");
            Thread.Sleep(100);
            Console.ReadKey();

        }
    }
}
			
            
            
            
          
