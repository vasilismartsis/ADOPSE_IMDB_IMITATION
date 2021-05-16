using ADOPSE_IMDB_IMITATION.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ADOPSE_IMDB_IMITATION.Models
{
    public class Actor
    {
        #region Public Properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public double? Score { get; set; }

        [Browsable(false)]
        public bool IsNew { get { return ID == 0; } }

        public string GetRatingDisplayName { get { return Score.HasValue ? $"Rating : {Score}/10" : "-- no rating yet --"; } }
        #endregion

        #region Ctor
        public Actor()
        {

        }
        #endregion

        #region Methods
        public void MapActorFromDB(ActorFromDB actorFromDB)
        {
            if (actorFromDB == null)
                throw new NotSupportedException();

            ID = actorFromDB.Id;
            FirstName = actorFromDB.firstName;
            LastName = actorFromDB.lastName;
            Birthday = actorFromDB.dateOfBirth;
            Score = actorFromDB.Score;
        }

        public ActorFromDB MapActorToDB()
        {
            var result = new ActorFromDB();

            result.Id = ID;
            result.firstName = FirstName;
            result.lastName = LastName;
            result.dateOfBirth = Birthday;
            result.Score = Score;

            return result;
        }

        public bool ValidateMandatoryField()
        {
            bool result = true;     //validation is succesfull

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || Birthday == DateTime.MinValue)
                result = false;

            return result;
        }
        #endregion
    }
}
