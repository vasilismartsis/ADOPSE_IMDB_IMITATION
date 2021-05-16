using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    class UserSuggetions
    {
        int[,] genrecounter;

        UserSuggetions mostsearched;
        UserSuggetions secondmostsearched;
        UserSuggetions thirdmostsearched;
        Genre mostSearchedGenre;
        Genre secondMostSearchedGenre;
        Genre thirdMostSearchedGenre;
        List<int> MoviesofthatGenre = new List<int>();
        List<int> userPrefferedGenresid = new List<int>();
        Genre genre;
        String genrename;
        int genreid;
        List<int> movies = new List<int>();
        List<int> userHistory = UserDataAccess.GetUserHistory();
        List<UserSuggetions> list = new List<UserSuggetions>();
        List<int> genreIds = new List<int>();

        private int counter { get; set; }
        private int id { get; set; }
        private string genreName { get; set; }
        public static List<int> MovieSuggestions()
        {
            List<int> movie = new List<int>();
            return movie;
        }
        /*public static List<int> MovieSuggestions() 
        {
            UserSuggetions sug = new UserSuggetions();
           


            foreach (int movieid in sug.userHistory)
            {
                genreIds= GenresDataAccess.GetGenreIdsByMovieID(movieid);
                //sug.genreid = GenresDataAccess.GetGenreIdByName(sug.genrename);
                //genre.Id = genreid;
                //genre.Name = genrename;
                sug.userPrefferedGenresid.Add(sug.genreid);
                

                
            }
            var g = sug.userPrefferedGenresid.GroupBy(i=>i);
            foreach (var grp in g)
            {
                if (sug.genreName.Equals(sug.list))
                {
                    sug.counter++;
                }
                else
                {
                    sug.list.Add(new UserSuggetions { genreName = GenresDataAccess.GetGenreNameById(grp.Key), counter = 1 });
                }
            }
            sug.list.Sort();
            if (sug.list[0] != null)
            {
                sug.mostsearched = sug.list[0];
                sug.mostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(sug.list[0].genreName), Name= sug.list[0].genreName };
            }
            if (sug.list[1] != null) 
            {
                sug.secondmostsearched = sug.list[1];
                sug.secondMostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(sug.list[1].genreName), Name = sug.list[1].genreName };
            }
           
            if (sug.list[2] != null)
            {
                sug.thirdmostsearched = sug.list[2];
                sug.thirdMostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(sug.list[2].genreName), Name = sug.list[2].genreName };
            }
            sug.MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(sug.mostSearchedGenre);
            sug.movies.Add(sug.MoviesofthatGenre[0]);
            sug.movies.Add(sug.MoviesofthatGenre[1]);
            sug.movies.Add(sug.MoviesofthatGenre[2]);
            sug.MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(sug.secondMostSearchedGenre);
            sug.movies.Add(sug.MoviesofthatGenre[3]);
            sug.movies.Add(sug.MoviesofthatGenre[4]);
            sug.MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(sug.thirdMostSearchedGenre);
            sug.movies.Add(sug.MoviesofthatGenre[5]);


            return sug.movies;
        }*/

        
    }
}
