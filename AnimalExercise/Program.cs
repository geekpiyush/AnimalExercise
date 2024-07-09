using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var MoviesList = new List<Movies<double,DateTime>>();
            var MoviesList2 = new List<Movies<float, int>>();

            var LordOfTheRings = new Movies<double,DateTime>();
            LordOfTheRings.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            LordOfTheRings.Director = "Peter Jackson";
            LordOfTheRings.Rate = 8.8;
            LordOfTheRings.ReleaseDate = new DateTime(2001,12,19);

            var LordOfTheRings2 = new Movies<double, DateTime>();
            LordOfTheRings2.MovieName = "The Lord of the Rings: The Two Tower";
            LordOfTheRings2.Director = "Peter Jackson";
            LordOfTheRings2.Rate = 8.7;
            LordOfTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            var LordOfTheRings3 = new Movies<double, DateTime>();
            LordOfTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            LordOfTheRings3.Director = "Peter Jackson";
            LordOfTheRings3.Rate = 8.9;
            LordOfTheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            MoviesList.Add(LordOfTheRings);
            MoviesList.Add(LordOfTheRings2);
            MoviesList.Add(LordOfTheRings3);

            
            var Batman = new Movies<float, int>();
            Batman.MovieName = "Batman Begins";
            Batman.Director = "Christopher Nolan";
            Batman.Rate = 8.3f;
            Batman.ReleaseDate = 2005;

            var Batman2 = new Movies<float, int>();
            Batman2.MovieName = "The Dark Knight";
            Batman2.Director = "Christopher Nolan";
            Batman2.Rate = 9.0f;
            Batman2.ReleaseDate = 2008;

            var Batman3 = new Movies<float, int>();
            Batman3.MovieName = "The Dark Knight Rises";
            Batman3.Director = "Christopher Nolan"; 
            Batman3.Rate = 8.4f;
            Batman3.ReleaseDate = 2012;

            MoviesList2.Add(Batman);
            MoviesList2.Add(Batman2);
            MoviesList2.Add(Batman3);

            foreach (var item in MoviesList)
            {
                item.DisplayMoviesDetails(item.MovieName,item.Director,item.Rate,item.ReleaseDate);
            }
            foreach (var item in MoviesList2)
            {
                item.DisplayMoviesDetails(item.MovieName, item.Director, item.Rate, item.ReleaseDate);5
            }
        }
    }
}

class Movies<T, U>
{
    private string movieName;

    public string MovieName
    {
        get { return movieName; }
        set { movieName = value; }
    }

    private string director;

    public string Director
    {
        get { return director; }
        set { director = value; }
    }

    private T rate;

    public T Rate
    {
        get { return rate; }
        set { rate = value; }
    }

    private U releaseDate;

    public U ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }

   public void DisplayMoviesDetails<T,U>(string movieName,string director, T Rating, U ReleaseOn)
    {
        Console.WriteLine($"Movie Name: {movieName}\nDirector: {director}\nRating: {Rating}\nRelease Date: {ReleaseOn}\n");
    }
}
