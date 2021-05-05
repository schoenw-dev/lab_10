using System;
using System.Collections.Generic;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to the Movie List Application! \nThere are 100 movies in this list.";

            Movie lotrRotk = new Movie("Lord of the Rings: Return of the King", "fantasy");
            Movie swRots = new Movie("Star Wars: Revenge of the Sith", "sci-fi");
            Movie gladiator = new Movie("Gladiator", "drama");
            Movie revenant = new Movie("Revenant", "drama");
            Movie shining = new Movie("The Shining", "horror");
            Movie drive = new Movie("Drive", "drama");
            Movie superbad = new Movie("Superbad", "comedy");
            Movie darkKnight = new Movie("The Dark Kight", "drama");
            Movie toyStory = new Movie("Toy Story", "animated");
            Movie upMovie = new Movie("Up", "animated");
            Movie hpHbp = new Movie("Harry Potter: The Half-Blood Prince", "fantatsy");
            Movie exMachina = new Movie("Ex Machina", "sci-fi");
            Movie bladeRunner = new Movie("Bladerunner 2049", "sci-fi");
            Movie heavyweights = new Movie("Heavyweights", "comedy");
            Movie aladin = new Movie("Aladin", "animated");

            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(lotrRotk);
            MovieList.Add(swRots);
            MovieList.Add(gladiator);
            MovieList.Add(revenant);
            MovieList.Add(shining);
            MovieList.Add(drive);
            MovieList.Add(superbad);
            MovieList.Add(darkKnight);
            MovieList.Add(toyStory);
            MovieList.Add(upMovie);
            MovieList.Add(hpHbp);
            MovieList.Add(exMachina);
            MovieList.Add(bladeRunner);
            MovieList.Add(heavyweights);
            MovieList.Add(aladin);
            


            Console.WriteLine(welcome);

            bool repeat = true;

            while (repeat)
            {

                Console.WriteLine("What category are you interested in? Please enter a number from our menu:");
                Console.WriteLine("1.) Drama");
                Console.WriteLine("2.) Horror");
                Console.WriteLine("3.) Comedy");
                Console.WriteLine("4.) Sci-Fi");
                Console.WriteLine("5.) Animated");

                string userAnswer = Console.ReadLine();
                
                if(userAnswer == "1")
                {
                    userAnswer = "drama";
                }
                else if(userAnswer == "2")
                {
                    userAnswer = "horror";
                }
                else if(userAnswer == "3")
                {
                    userAnswer = "comedy";
                }
                else if(userAnswer == "4")
                {
                    userAnswer = "sci-fi";
                }
                else if(userAnswer == "5")
                {
                    userAnswer = "animated";
                }
                else
                {
                    Console.WriteLine("error, invalid answer.");
                   
                }

                FindMovies(MovieList, userAnswer);

                Console.WriteLine("Continue? (y|n):");
                string userResponse = Console.ReadLine();

                if(userResponse.ToLower() == "y")
                {
                    repeat = true;
                }
                else if (userResponse.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("error, invalid answer. Goodbye!");
                    repeat = false;

                    
                }



            }



        }

        public static void FindMovies(List<Movie> MovieList, string catagory)
        {
            List<Movie> FoundMovies = new List<Movie>();
            foreach(Movie foundMovie in MovieList)
            {
                if(foundMovie.Catagory == catagory.ToLower())
                {
                    FoundMovies.Add(foundMovie);
                    Console.WriteLine(foundMovie.MovieTitle);
                }

            }

            
        }
    }
}
