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
        private int counter { get; set; }
        private int id { get; set; }
        private string genreName { get; set; }
        public List<int> MovieSuggestions() 
        {
           
            
            foreach (int movieid in userHistory)
            {
                genrename = GenresDataAccess.GetGenreNameById(movieid);
                genreid = GenresDataAccess.GetGenreIdByName(genrename);
                //genre.Id = genreid;
                //genre.Name = genrename;
                userPrefferedGenresid.Add(genreid);
                

                
            }
            var g = userPrefferedGenresid.GroupBy(i=>i);
            foreach (var grp in g)
            {
                if (genreName.Equals(list))
                {
                    this.counter++;
                }
                else
                {
                    list.Add(new UserSuggetions { genreName = GenresDataAccess.GetGenreNameById(grp.Key), counter = 1 });
                }
            }
            list.Sort();
            if (list[0] != null)
            {
                mostsearched = list[0];
                mostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(list[0].genreName), Name= list[0].genreName };
            }
            if (list[1] != null) 
            { 
                secondmostsearched = list[1];
                secondMostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(list[1].genreName), Name = list[1].genreName };
            }
           
            if (list[2] != null)
            {
                thirdmostsearched = list[2];
                thirdMostSearchedGenre = new Genre { Id = GenresDataAccess.GetGenreIdByName(list[2].genreName), Name = list[2].genreName };
            }
            MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(mostSearchedGenre);
            movies.Add(MoviesofthatGenre[0]);
            movies.Add(MoviesofthatGenre[1]);
            movies.Add(MoviesofthatGenre[2]);
            MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(secondMostSearchedGenre);
            movies.Add(MoviesofthatGenre[3]);
            movies.Add(MoviesofthatGenre[4]);
            MoviesofthatGenre = MovieDataAccess.GetMoviesByGenre(thirdMostSearchedGenre);
            movies.Add(MoviesofthatGenre[5]);


            return movies;
        }

        
    }
}
