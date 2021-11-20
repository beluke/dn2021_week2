using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public string[] Scenes { get; set; }
        public virtual void PrintInfo()
        {
            Console.Write(
                "\nTitle: " + this.Title +
                "\nCategory: " + this.GetCategory() +
                "\nRuntime: " + this.RunTime + " minutes");
        }

        public void PrintScenes()
        {
            int i = 1;
            foreach (var scene in this.Scenes)
            {
                Console.WriteLine($"\tScene {i++}: {scene}");
            }
        }

        public string GetCategory()
        {
            switch (this.Category)
            {
                case Genre.Drama:
                    return "Drama";
                case Genre.Comedy:
                    return "Comedy";
                case Genre.Horror:
                    return "Horror";
                case Genre.Romance:
                    return "Romance";
                case Genre.Action:
                    return "Action";
                default:
                    return "Default";
            }
        }
    }
}
