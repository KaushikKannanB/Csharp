using System;

class Program
{
    static void Main()
    {
        List<string>movies = new List<string>();

        while(true)
        {
            Console.WriteLine("Binge diary");
            Console.WriteLine("1. Add movie");
            Console.WriteLine("2. Remove movie");
            Console.WriteLine("3. Display all movies");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine().Trim();

            int choice = int.Parse(input);

            if(choice==1)
            {
                Console.WriteLine("What movie did you watch recently?");
                string movie = Console.ReadLine().Trim().ToUpper();
                if(movies.Find(i => i==movie)==null)
                {
                    movies.Add(movie);
                    
                }
                else
                    Console.WriteLine("Already watched!");
                
            }
            else if(choice==2)
            {
                string movie = Console.ReadLine().Trim().ToUpper();
                if(movies.Remove(movie))
                {
                    Console.WriteLine("Removed");
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }
            }
            else if(choice==3)
            {
                if(movies.Count>0)
                {
                    foreach(var movie in movies)
                    {
                        Console.WriteLine("* "+movie);
                    }
                }
                else
                    Console.WriteLine("No movies watched!");
            }
            else if(choice==4)
            {
                Console.WriteLine("See you next time!");
                return ;
            }
            else
                Console.WriteLine("Enter a valid number");
        }
    }
}