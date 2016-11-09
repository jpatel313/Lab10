using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();

            Console.WriteLine("Welcome to the Movie List Application!\n");
            string y = "y";

            while (y == "y")
            {
                //User to search by entering category.
                Console.WriteLine("\nWhat category are you interested in?\n\nPlease type one of the following categories:\n\nanimated, scifi, drama, musical, comedy");
                string category = Console.ReadLine();

                if (category != null)
                {
                    Console.WriteLine("\nMovies in this genre:\n");
                    SearchMethod(category);

                    Console.Write("\nContinue? (y/n):");
                    y = Console.ReadLine();
                    Console.Clear();

                    if (y != "y")
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                }
            }
        }
      
        public static void SearchMethod(string category)
        {
            for (int i = 1; i < 100; i++)
            {
                if (Movies.getMovie(i).Category1 == category)
                {
                    Console.WriteLine(Movies.getMovie(i).Title1);
                }
            }
        }

    }
}
