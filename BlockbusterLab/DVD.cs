using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string title, Genre genre, int runtime, string[] scenes)
        {
            Title = title;
            Category = genre;
            RunTime = runtime;
            Scenes = scenes;
            CurrentTime = 0;
            this.MediaType = Media.DVD;
        }
        public int CurrentTime { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Media: {this.GetMediaType()}");
        }

        public override void Play()
        {

            int s = -1;

            do
            {
                Console.WriteLine("Which scene would you like to play?");
                PrintScenes();
                try
                {
                    Console.Write("Please choose from above: ");
                    s = int.Parse(Console.ReadLine());
                    if (s < 0 || s > Scenes.Length)
                    {
                        throw new Exception("Scene does not exist...");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                break;

            } while (true);

            Console.WriteLine($"Scene: {Scenes[s]}");
        }
    }
}
