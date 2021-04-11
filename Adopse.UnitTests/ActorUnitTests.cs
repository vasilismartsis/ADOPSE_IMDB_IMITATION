using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adopse.UnitTests
{
    [TestClass]
    public class ActorUnitTests
    {
        [TestMethod]
        public void ActorSaveMandatoryFieldValidation1()
        {
            var myViewModel = new ActorViewModel(true);

            myViewModel.SelectedActor = new Actor();

            myViewModel.SelectedActor.FirstName = "nena";

            bool testResult = myViewModel.SaveSelectedActor();

            Assert.IsTrue(testResult == false);
        }

        [TestMethod]
        public void ActorSaveMandatoryFieldValidation2()
        {
            var myViewModel = new ActorViewModel(true);

            myViewModel.SelectedActor = new Actor();

            myViewModel.SelectedActor.FirstName = "nena";
            myViewModel.SelectedActor.LastName = "michailidou";
            myViewModel.SelectedActor.Birthday = new DateTime(1988, 7, 25);

            bool testResult = myViewModel.SaveSelectedActor();

            Assert.IsTrue(testResult == true);
        }

        [TestMethod]
        public void LoadActorFromDB()
        {
            var myViewModel = new ActorViewModel(true);

            myViewModel.SelectedActor = new Actor();

            string toSaveFirstName = "nena";

            myViewModel.SelectedActor.FirstName = toSaveFirstName;
            myViewModel.SelectedActor.LastName = "michailidou";
            myViewModel.SelectedActor.Birthday = new DateTime(1988, 7, 25);

            myViewModel.SaveSelectedActor();
            //till here, we dont neet to test it, it is tested from ActorSaveMandatoryFieldValidation2

            int savedActorID = myViewModel.SelectedActor.ID;        //this is the newly added Actor's ID

            myViewModel.LoadSelectedActor(savedActorID);            //here we must have a valid ID

            int loadedActorID = myViewModel.SelectedActor.ID;       //this is the loaded actor's ID
            string loadedFirstName = myViewModel.SelectedActor.FirstName;

            Assert.IsTrue(savedActorID == loadedActorID);
            Assert.IsTrue(toSaveFirstName.Equals(loadedFirstName.Trim()));
        }
    }
}
