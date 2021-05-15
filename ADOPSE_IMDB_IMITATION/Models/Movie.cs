using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
        public string Director { get; set; }
        public bool IsSeries { get; set; }
        public string Description { get; set; }
        public double? Score { get; set; }
        public string ImdbID { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }

        public string GetRatingDisplayName { get { return Score.HasValue ? $"Rating : {Score}/10" : "-- no rating yet --"; } }
    }
}