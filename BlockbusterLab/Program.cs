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
    
}
