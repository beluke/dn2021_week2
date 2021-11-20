using System;

namespace BlockbusterLab
{
    public enum Genre
    {
        Drama = 0,
        Comedy = 1,
        Horror = 2,
        Romance = 3,
        Action = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            VHS vhs = new VHS("movie", Genre.Horror, 92, new string[]{ "hello", "goobye" });
            vhs.PrintInfo();
        }
    }

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
            foreach(var scene in this.Scenes) {
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

    class DVD : Movie
    {
        public DVD(string title, Genre genre, int runtime, string[] scenes)
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
                "\nRuntime: " + this.RunTime +
                "\nScenes: "); this.PrintScenes();
        }

        public void Play()
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
