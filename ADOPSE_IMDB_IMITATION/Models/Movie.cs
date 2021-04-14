using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public string image { get; set; }
        public string trailer { get; set; }
        public string director { get; set; }
        public bool isSeries { get; set; }
        public string description { get; set; }
    }
}