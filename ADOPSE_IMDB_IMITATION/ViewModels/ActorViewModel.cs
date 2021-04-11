using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.ViewModels
{
    public class ActorViewModel
    {
        #region Public Properties
        public List<Actor> AllActors { get; set; }
        public Actor SelectedActor { get; set; }
        public bool IsInTestMode { get; set; }
        #endregion

        #region Ctor
        public ActorViewModel(bool isInTestMode = false)
        {
            IsInTestMode = isInTestMode;
        }
        #endregion

        #region Methods
        public void LoadAllActors()
        {
            AllActors = new List<Actor>();

            foreach (var actorFromDB in ActorDataAccess.GetAll())
            {
                Actor newActor = new Actor();

                newActor.MapActorFromDB(actorFromDB);

                AllActors.Add(newActor);
            }
        }

        public void LoadSelectedActor(int actorId)
        {
            var actorFromDB = ActorDataAccess.GetById(actorId);

            SelectedActor = new Actor();
            SelectedActor.MapActorFromDB(actorFromDB);
        }

        public void InitialiseNewActor()
        {
            SelectedActor = new Actor();
        }

        public bool SaveSelectedActor()
        {
            bool result = true;     //the actor was saved succesfully

            if (SelectedActor == null)
                throw new NotSupportedException();

            var actorFromDBToSave = SelectedActor.MapActorToDB();

            if (SelectedActor.ValidateMandatoryField())
            {
                if (SelectedActor.IsNew)
                {
                    int newActorID = ActorDataAccess.AddNewActor(actorFromDBToSave);

                    SelectedActor.ID = newActorID;

                    if (!IsInTestMode)
                        MessageBox.Show($"The new Actor's ID is = {newActorID}");
                }
                else
                {
                    ActorDataAccess.SaveExistingActor(actorFromDBToSave);

                    if (!IsInTestMode)
                        MessageBox.Show($"The new Actor with ID {actorFromDBToSave.Id} was updated succesfully");
                }
            }
            else
            {
                result = false;

                if (!IsInTestMode)
                    MessageBox.Show("Please fill in the mandatory fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }
        #endregion
    }
}
