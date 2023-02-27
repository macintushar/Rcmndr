using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcmndr
{
    public class Paths
    {
        public class Path
        {
            public string[] Name;
            public string[] Poster_Path;
            public string[] URL;
            public static string base_path = "C:\\Users\\tusha\\OneDrive\\Documents\\Christ University\\Semester - IV\\Dot Net\\Programs\\Rcmndr\\Rcmndr\\assets\\Posters\\Movies";
        }
        public static string[,] moviePaths = { { "Star Wars Episode 5: Empire Strikes Back","The Dark Knight", "Fight Club", "The Godfather", "The Godfather Part 2", "Goodfellas", "Inception", "Pulp Fiction", "Se7en", "Shawshank Redemption" },
                                               { "C:\\Users\\tusha\\OneDrive\\Documents\\Christ University\\Semester - IV\\Dot Net\\Posters\\Movies\\star wars ep 5", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", } };

        public static Path Movies = new Path()
        {
            Name = new string[] { "Star Wars Episode 5: Empire Strikes Back", "The Dark Knight", "Fight Club", "The Godfather", "The Godfather Part 2", "Goodfellas", "Inception", "Pulp Fiction", "Se7en", "Shawshank Redemption" },
            Poster_Path = new string[] { Path.base_path + "/star wars ep 5.jpeg", Path.base_path + "/dark knight.jpg", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", },
        };

    }
}
