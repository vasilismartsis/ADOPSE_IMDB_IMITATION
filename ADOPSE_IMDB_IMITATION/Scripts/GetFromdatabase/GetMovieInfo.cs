using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Scripts
{
    class GetMovieInfo
    {
        public Movie retrieveAllMovieColumnsDataAndSet(int movieid) // retrieves all the columns from table Movies of a specific movie using id
        {
            Movie m = new Movie();
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                string commandText = "" + "SELECT * " +
                            "FROM Movies " +
                            "WHERE Movies.Id=" + "@id";
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@id", movieid);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        m.setMovieId(reader.GetInt32(0));
                        m.setMovieName(reader.GetString(1));
                        m.setDateOfRelease(reader.GetDateTime(2));
                        m.setImagePath(reader.GetString(3));
                        m.setTrailerPath(reader.GetString(4));
                        //m.setDirector(reader.GetString(5));
                        //m.setisSeries(reader.GetBoolean(6));
                    }
            }
            return m;
        }
    }
}
