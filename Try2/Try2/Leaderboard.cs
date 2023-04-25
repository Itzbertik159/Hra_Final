using System;
namespace Try2
{
    internal class Leaderboard
    {
        public static void leaderboard()
        {
            Console.Clear();
            Console.WriteLine("   __   _______   ___  _______  ___  ____  ___   ___  ___ \n  / /  / __/ _ | / _ \\/ __/ _ \\/ _ )/ __ \\/ _ | / _ \\/ _ \\\n / /__/ _// __ |/ // / _// , _/ _  / /_/ / __ |/ , _/ // /\n/____/___/_/ |_/____/___/_/|_/____/\\____/_/ |_/_/|_/____/ \n                                                          \n-----------------------------------------------------");

            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader("Leaderboard.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        lines.Add(line);
                    }

                }
            }
            List<Tuple<string, int>> scores = new List<Tuple<string, int>>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");
                string name = parts[0];
                int score = int.Parse(parts[1]);
                scores.Add(new Tuple<string, int>(name, score));
            }

            scores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            foreach (Tuple<string, int> score in scores)
            {
                Console.WriteLine(score.Item1 + " - " + score.Item2);
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("- BACK -");
            Console.ReadKey();
        }
    }  
}

