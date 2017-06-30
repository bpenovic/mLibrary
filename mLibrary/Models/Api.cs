using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using System.ComponentModel;
using System.Collections.ObjectModel;

//Json dlls
using Newtonsoft.Json;
using Json.NET;

namespace mLibrary.Models
{
   public class Api
    {
        // List for saving movies after searching by name or year
        ObservableCollection<Movie> moviesList = null;
        WebClient webClient = new System.Net.WebClient();

        // Start API URI https://moviesapi.com/
        string apiUrl = "";

        // Function return list of movies, to get movies user have to write title or year of movie
        public ObservableCollection<Movie> FindMovies(string movieTitle)
        {
            apiUrl = "https://moviesapi.com/";

            StringBuilder searchName = null;


            if (movieTitle != "")
            {
                searchName = new StringBuilder(movieTitle);

                for (int i = 0; i < searchName.Length; i++)
                    if (searchName[i] == ' ')
                        searchName[i] = '+';
            }

            apiUrl = apiUrl + "m.php?t=" + searchName + "&y=";

       
            apiUrl = apiUrl + "&type=movie&r=json";


            var json = webClient.DownloadString(apiUrl);

            if (json != "[]")
            {
                moviesList = new ObservableCollection<Movie>();
                dynamic dynJson = JsonConvert.DeserializeObject(json);

                foreach (var item in dynJson)
                {
                    Movie movie = new Movie();
                    movie.Id = item.id;
                    movie.Title = item.title;
                    movie.Year = item.year;
                    movie.Type = item.type;
                    movie.Poster = item.poster;

                    moviesList.Add(movie);
                }
            }

            return moviesList;
        }

        public Movie_info FindOne(string id)
        {
            Movie_info targetMovie = null;

            apiUrl = "https://moviesapi.com/";
            apiUrl = apiUrl + "m.php?i=" + id + "&type=movie&r=json";

            var json = webClient.DownloadString(apiUrl);

            if (json != "[]")
            {
                dynamic dynJson = JsonConvert.DeserializeObject(json);

                targetMovie = new Movie_info();

                targetMovie.Id = dynJson.id;
                targetMovie.Title = dynJson.title;
                targetMovie.Year = dynJson.year;
                targetMovie.Type = dynJson.type;
                targetMovie.Poster = dynJson.poster;
                targetMovie.Director = dynJson.director;
                targetMovie.Writer = dynJson.writer;
                targetMovie.Cined = dynJson.cined;
                targetMovie.Production = dynJson.prod;
                targetMovie.Countries = dynJson.countries;
                targetMovie.Duration = dynJson.dur;
                targetMovie.Rate = dynJson.rate;
                targetMovie.Cover = dynJson.cov;
                targetMovie.Gen = dynJson.gen;
                targetMovie.Plot = dynJson.plot;
                targetMovie.Plotout = dynJson.plotout;
                targetMovie.Cast = dynJson.cast;
            }

            return targetMovie;
        }
    }
}
