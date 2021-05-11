using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Models
{
   public class UserHistory
    {
        public int userId = Session.userId;
        public int movieId { get; set; }

    }
}
