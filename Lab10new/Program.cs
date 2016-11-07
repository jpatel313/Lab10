using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10new
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();

            //Add movies to MovieList ("title", "category").
            //Movies listed below start at index 0 etc.
            MovieList.Add(new Movie("Despicable Me", "animated"));
            MovieList.Add(new Movie("Waking Life", "animated"));
            MovieList.Add(new Movie("Trolls", "animated"));
            MovieList.Add(new Movie("The Matrix", "scifi"));
            MovieList.Add(new Movie("13th Floor", "scifi"));
            MovieList.Add(new Movie("Dark City", "scifi"));
            MovieList.Add(new Movie("Ghost in the Shell", "scifi"));
            MovieList.Add(new Movie("Hacksaw Ridge", "drama"));
            MovieList.Add(new Movie("The Take", "drama"));
            MovieList.Add(new Movie("Man Down", "drama"));

            Console.WriteLine("Welcome to the Movie List Application!\n");
            string y = "y";

            while (y == "y")
            {
                //Input= user category.
                Console.WriteLine("What category are you interested in?\n\ncategories:\nscifi, animated, drama ");
                string category = Console.ReadLine();
                SearchMethod(MovieList, category);

                Console.Write("Continue? (y/n):");
                y = Console.ReadLine();
                if (y != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("What category are you interested in?...\nscifi, animated, drama ");
                    category = Console.ReadLine();
                }
            }
        }

        public static void SearchMethod(List<Movie> MovieDatabase, string category)
        {//Method takes MovieList and category search as input,
        //And prints all movie titles matching category string.



            for (int i = 0; i < MovieDatabase.Count; i++)
            {
                if (MovieDatabase[i].Category1 == category)
                {
                    Console.WriteLine(MovieDatabase[i].Title1);
                }
            }
        }
    }
}
