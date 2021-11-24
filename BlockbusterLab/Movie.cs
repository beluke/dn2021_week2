using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Genre
    {
        Drama = 0,
        Comedy = 1,
        Horror = 2,
        Romance = 3,
        Action = 4,
        Thriller = 5
    }

    public enum Media
    {
        VHS = 0,
        DVD = 1
    }

    abstract class Movie
    {
        protected string Title { get; set; }
        protected Genre Category { get; set; }
        protected int RunTime { get; set; }
        protected string[] Scenes { get; set; }
        protected Media MediaType { get; set; }
        public virtual void PrintInfo() 
        {
            Console.Write(
                "\nTitle: " + this.Title +
                "\nCategory: " + this.GetCategory() +
                "\nRuntime: " + this.RunTime + " minutes\n");
        }
        public string PrintScenes()
        {
            string scenes = "";
            int i = 1;
            foreach (var scene in this.Scenes)
            {
                scenes += $"\n\tScene {i++}: {scene}";
            }
            return scenes;
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
                case Genre.Thriller:
                    return "Thriller";
                default:
                    return "Default case reached in BlockbusterLab.Movies.GetCategory()";
            }
        }

        public string GetMediaType()
        {
            switch (this.MediaType)
            {
                case Media.VHS:
                    return "VHS";
                case Media.DVD:
                    return "DVD";
                default:
                    return "Default case reached in BlockbusterLab.Movies.GetMediaType()";
            }
        }

        public abstract void Play();
    }
}
