//------------Find Items--------------
// using System;
// using System.Diagnostics.Contracts;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter sold count to search: ");
//         long soldCount = Convert.ToInt64(Console.ReadLine());

//         var foundItems = FindItemDetails(soldCount);

//         if (foundItems.Count == 0)
//         {
//             Console.WriteLine("Invalid sold count");
//         }
//         else
//         {
//             Console.WriteLine("Item Details:");
//             foreach (var item in foundItems)
//             {
//                 Console.WriteLine(item.Key + " - " + item.Value);
//             }
//         }

//         Console.WriteLine();

//         // Min and Max
//         var minMax = FindMinMaxSoldItems();
//         Console.WriteLine("Minimum sold item: " + minMax[0]);
//         Console.WriteLine("Maximum sold item: " + minMax[1]);

//         Console.WriteLine();

//         // Sorted Items
//         Console.WriteLine("Items sorted by sold count:");
//         var sortedItems = SortByCount();
//         foreach (var item in sortedItems)
//         {
//             Console.WriteLine(item.Key + " - " + item.Value);
//         }
//     }
//     public static SortedDictionary<string,long>itemDetails=new SortedDictionary<string, long>()
//     {
//         {"Laptop", 150},
//         {"Mobile", 300},
//         {"Tablet", 120},
//         {"Headphone", 80},
//         {"Camera", 200}
//     };
//     public static SortedDictionary<string,long>FindItemDetails(long soldCount)
//     {
//         SortedDictionary<string, long> result =
//             new SortedDictionary<string, long>();
        
//         foreach(var i in result)
//         {
//             if (i.Value == soldCount)
//             {
//                 result.Add(i.Key,i.Value);
//             }
//         }
//         return result;
//     }
//     public static List<string> FindMinMaxSoldItems()
//     {
//         List<string> result = new List<string>();
//         long maxE = itemDetails.Values.Max();
//         long minE = itemDetails.Values.Min();
//         string maxEl = itemDetails.First(a=>a.Value==maxE).Key;
//         string minEl = itemDetails.First(a=>a.Value==minE).Key;
//         result.Add(maxEl);
//         result.Add(minEl);
//         return result;

//     }
//     public static Dictionary<string, long> SortByCount()
//     {
//         Dictionary<string,long> result = new Dictionary<string, long>();
//         return itemDetails.OrderBy(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
//     }
// }

//-------------------Movie Stock------------
// using System;
// class Movie
// {
//     public string Title{get;set;}
//     public string Artist{get;set;}
//     public string Genre{get;set;}
//     public int Ratings{get;set;}

// }
// class Program
// {
//     public static List<Movie> MovieList= new List<Movie>();
//     public static void AddMovie(string MovieDetails)
//     {
//         string[] movies = MovieDetails.Split(',');
//         Movie movie = new Movie()
//         {
//             Title = movies[0],
//             Artist = movies[1],
//             Genre = movies[2],
//             Ratings = Convert.ToInt32(movies[3])
//         };
//         MovieList.Add(movie);
//     }
//     public static List<Movie>ViewMoviesByGenre(string genre)
//     {
//         return MovieList.Where(a=>a.Genre==genre).ToList();
//     }
//     public static List<Movie> ViewMoviesByRating()
//     {
//         return MovieList.OrderBy(a=>a.Ratings).ToList();
//     }
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number of movies: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Enter movie details (Title,Artist,Genre,Ratings):");
//             string input = Console.ReadLine();
//             AddMovie(input);
//         }

//         Console.Write("Enter genre to search: ");
//         string genre = Console.ReadLine();

//         var genreMovies = ViewMoviesByGenre(genre);

//         if (genreMovies.Count == 0)
//         {
//             Console.WriteLine($"No Movies found in genre {genre}");
//         }
//         else
//         {
//             Console.WriteLine("Movies in genre:");
//             foreach (var m in genreMovies)
//             {
//                 Console.WriteLine($"{m.Title} | {m.Artist} | {m.Ratings}");
//             }
//         }

//         Console.WriteLine();
//         Console.WriteLine("Movies sorted by ratings:");

//         var sortedMovies = ViewMoviesByRating();
//         foreach (var m in sortedMovies)
//         {
//             Console.WriteLine($"{m.Title} | {m.Genre} | {m.Ratings}");
//         }
//     }
// }

//---------Calculate Numbers-----------------
using System;
class Program
{
    public static List<int> NumberList = new List<int>();
    public static void AddNumbers(int Numbers)
    {
        NumberList.Add(Numbers);
    }
    public static double GetGPAScored()
    {
        double Gpa = 0;
        foreach(int i in NumberList)
        {
            Gpa+=(i*3);
        }
        return Gpa/(NumberList.Count*3);
    }
    public static char GetGradeScored(double gpa)
    {
        if (gpa == 10)
        {
            return 'S';
        }
        else if(gpa>=9 && gpa <= 10)
        {
            return 'A';
        }
        else if(gpa>=8 && gpa <= 9)
        {
            return 'B';
        }
        else if(gpa>=7 && gpa <= 8)
        {
            return 'C';
        }
        else if(gpa>=6 && gpa <= 7)
        {
            return 'D';
        }
        else if(gpa>=5 && gpa<6)
        {
            return 'E';
        }
        return 'F';
    }
    static void Main()
    {
        Console.Write("Enter number of subjects: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter score: ");
            int value = Convert.ToInt32(Console.ReadLine());
            AddNumbers(value);
        }

        double gpa = GetGPAScored();

        if (gpa == -1)
        {
            Console.WriteLine("No Numbers Available");
            return;
        }

        Console.WriteLine($"GPA Scored: {gpa}");

        char grade = GetGradeScored(gpa);

        if (grade == '\0')
        {
            Console.WriteLine("Invalid GPA");
        }
        else
        {
            Console.WriteLine($"Grade Scored: {grade}");
        }
    }
}