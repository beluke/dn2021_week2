using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public VHS(string title, Genre genre, int runtime, string[] scenes)
        {
            Title = title;
            Category = genre;
            RunTime = runtime;
            Scenes = scenes;
            CurrentTime = 0;
        }
        public int CurrentTime { get; set; }

        public override void PrintInfo()
        {
            Console.Write(
                "\nTitle: " + this.Title +
                "\nCategory: " + this.GetCategory() +
                "\nRuntime: " + this.RunTime + " minutes\n");
        }

        public void Play()
        {
            if (CurrentTime >= Scenes.Length) Console.WriteLine("Movie has ended, please rewind...");
            Console.WriteLine($"Current scene: {Scenes[CurrentTime++]}");
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
