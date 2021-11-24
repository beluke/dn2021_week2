using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        private int CurrentScene { get; set; }

        public VHS(string title, Genre genre, int runtime, string[] scenes)
        {
            this.Title = title;
            this.Category = genre;
            this.RunTime = runtime;
            this.Scenes = scenes;
            this.CurrentScene = 0;
            this.MediaType = Media.VHS;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Media: {this.GetMediaType()}");
        }

        public override void Play()
        {
            if (CurrentScene >= Scenes.Length) Console.WriteLine("Movie has ended, please rewind...");
            Console.WriteLine($"Current scene: {Scenes[CurrentScene++]}");
        }

        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
