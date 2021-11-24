using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        private List<Movie> Movies = new List<Movie>
        {
            new VHS("Movie 1", Genre.Action, 92, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" }),
            new VHS("Movie 2", Genre.Comedy, 108, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" }),
            new VHS("Movie 3", Genre.Horror, 109, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" }),
            new DVD("Movie 4", Genre.Romance, 150, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" }),
            new DVD("Movie 5", Genre.Drama, 87, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" }),
            new DVD("Movie 6", Genre.Thriller, 89, new string[]{ "begin", "begin-mid", "middle", "mid-end", "end" })
        };

        public void PrintMovies()
        {
            foreach (var movie in Movies)
            {
                movie.PrintInfo();
            }
        }
    }
}
