using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Scripts
{
    class GetIdsFromDB
    {
        private List<int> list = new List<int>();
        public void setlist(List<int> l)
        {
            list = l;
        }
        public List<int> getlist(){
            return list;
        }
        public GetIdsFromDB() { }
        public GetIdsFromDB(List<int> l)
        {
            this.list = l;
        }
        public List<int> returnList()//return all the movies from the Database !!!
        {
            List<int> lista = new List<int>();
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                string commandText = "" + "SELECT Id FROM MOVIES";
                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        lista.Add(reader.GetInt32(0));
                        
                    }
                }
            }
            return lista;
        }
    }
}
