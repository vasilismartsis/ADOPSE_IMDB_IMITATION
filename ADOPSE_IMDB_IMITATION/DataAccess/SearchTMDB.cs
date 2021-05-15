using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
//using Newtonsoft.Json;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public partial class SearchTMDB
    {

        public static void SearchMovies(String MovieName)
        {
            int counter = 45100;
            int success = 0;
            do
            {

                counter++;

                //int alreadyExists = 0;
                //char pad = '0';
                string ss = counter.ToString();
                //string ss = (100000 + counter).ToString();
                //string tt = "tt" + ss.PadLeft(7, pad);

                //var rand = new Random();
                //int rr = rand.Next(0, 10000000);

                string url = "https://api.themoviedb.org/3/movie/" + ss + "?api_key=b55278248781020077030462c2f64f46";

                using (WebClient wc = new WebClient())
                {
                    int alreadyExists = 0;
                    try
                    {
                        var jsonString = wc.DownloadString(url);
                        TmdbEntity obj = JsonSerializer.Deserialize<TmdbEntity>(jsonString);
                        //TmdbEntity obj = JsonConvert.DeserializeObject<TmdbEntity>(jsonString);
                
                        int id = obj.id;

                        alreadyExists = MovieDataAccess.GetMovieByImdbId(id.ToString());
                        if (alreadyExists != 0) continue;

                        string Title = obj.title;
                        string release_date = obj.release_date;

                        string overview = obj.overview;
                        string director = "-";
                        string poster_path = TmdbEntity.base_poster_path + obj.poster_path;
                        string ImdbId = id.ToString();
                        string imdbRating = obj.vote_average.ToString();
                        string imdbVotes = obj.vote_count.ToString();

                        long votes = Int64.Parse(imdbVotes);

                        Console.WriteLine("Total Records searched : " + counter +"   " + votes + " " + Title);


                        if (votes > 5000)
                        {
                            //float rate = float.Parse(imdbRating);
                            success++;
                            Console.WriteLine("Success : " + success);
                            //MenuBar.SearchIMDBInput.Text=
                            //MessageBox.Show("rate FOUND !!! ImdbId: " + ImdbId + " " + imdbRating + " " + rate + " " + obj.Type + " votes: " + int.Parse(obj.imdbVotes));
                        }
                        else continue;

                        //  create a list for all genre ids to be inserted to entries tables
                        List<int> gens = new List<int>();

                        var genr = obj.genres;
                        Console.WriteLine(genr.Count);
                        Console.WriteLine(genr[0].id + "--" + genr[0].name);
                        for (int i = 0; i < genr.Count; i++)
                        {
                            var returnedId = GenresDataAccess.GetGenreIdByName(genr[i].name);

                            // if returns 0, then the genre doesn't exist and has to be added
                            if (returnedId == 0)
                            {
                                returnedId = GenresDataAccess.AddGenreIdByName(genr[i].name);
                            }
                            gens.Add(returnedId);
                        }

                        //  make a second search to search for cast and crew by the movie's id
                        string url_credits = "https://api.themoviedb.org/3/movie/" + ImdbId + "/credits?api_key=b55278248781020077030462c2f64f46";

                        var jsonString2 = wc.DownloadString(url_credits);
                        TmdbCredits obj2 = JsonSerializer.Deserialize<TmdbCredits>(jsonString2);
                        //TmdbCredits obj2 = JsonConvert.DeserializeObject<TmdbCredits>(jsonString2);

                        List<int> acts = new List<int>();

                        var actor = obj2.cast;
                        Console.WriteLine(actor.Count);
                        Console.WriteLine(actor[0].id + "--" + actor[0].name);

                        for (int i = 0; i < 5; i++)
                        {
                            var returnedId = ActorDataAccess.GetActorIdByName(actor[i].name);

                            // if returns 0, then the actor doesn't exist and has to be added
                            if (returnedId == 0)
                            {
                                //returnedId = ActorDataAccess.AddActorIdByName2(actor[i].name, actor[i].id.ToString());
                                Person actorToAdd = Person.GetActorDetails(actor[i].id.ToString());
                                returnedId = ActorDataAccess.AddActorIdByName3(actorToAdd);
                            }
                            acts.Add(returnedId);
                        }


                        var direct = obj2.crew;
                        Console.WriteLine(direct.Count);
                        //Console.WriteLine(director[0].job + "--" + director[0].name);

                        //search which one of the crew is the director
                        for (int i = 0; i < direct.Count; i++)
                        {
                            if (direct[i].job == "Director")
                            {
                                director = direct[i].name;
                            }
                        }

                        Movie mymovie = new Movie
                        {
                            Name = Title,                               //obj.title,
                            ReleaseDate = release_date,
                            Image = poster_path,                        //obj.Poster,
                            Director = director,                        // obj.Director,
                            //IsSeries = (obj.Type == "Movie" ? true : false),
                            Description = overview,                     //obj.Plot,
                            ImdbID = ImdbId,
                            ImdbRating = imdbRating,
                            ImdbVotes = imdbVotes
                        };

                        //  add the movie to the DB and update entries with the ids
                        MovieDataAccess.AddMovie2(mymovie, gens, acts);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        //counter++;
                        continue;
                    }
                }
            }
            while (success < 1000);
        }

    }

    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        //public string biography { get; set; }
        public string birthday { get; set; }
        public string profile_path { get; set; }

        public static string poster_base = "https://image.tmdb.org/t/p/original/";

        public static Person GetActorDetails(String actor_id)
        {
            using (WebClient wc = new WebClient())
            {
                string url = "https://api.themoviedb.org/3/person/" + actor_id + "?api_key=b55278248781020077030462c2f64f46";

                var jsonString = wc.DownloadString(url);
                Person actor = JsonSerializer.Deserialize<Person>(jsonString);

                string id = actor.id.ToString();
                string name = actor.name;
                string birthday = actor.birthday;
                actor.profile_path = Person.poster_base + actor.profile_path;

                return actor;
            }
        }
    }

    public class Genres
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Cast
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Crew
    {
        public int id { get; set; }
        public string name { get; set; }
        public string job { get; set; }
    }


    public class TmdbCredits
    {
        public int id { get; set; }                     // movie id
        public List<Cast> cast { get; set; }
        public List<Crew> crew { get; set; }        //crew.job
    }


    public class TmdbEntity
    {
        public int id { get; set; }          // tmdbID
        public string title { get; set; }
        public string release_date { get; set; }

        public List<Genres> genres { get; set; }

        public string Credits { get; set; }          //to get cast names

        public string overview { get; set; }        // description
        public string poster_path { get; set; }     //image

        public static string base_poster_path = "https://image.tmdb.org/t/p/original/"; //base poster path

        public long vote_count { get; set; }      // imdb votes count
        public double vote_average { get; set; }    // imdb rating
        //public string Type { get; set; }
        public string Response { get; set; }
        public Boolean success { get; set; }
    }
}
