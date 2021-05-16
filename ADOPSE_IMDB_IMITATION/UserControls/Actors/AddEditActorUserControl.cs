using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOPSE_IMDB_IMITATION.ViewModels;

namespace ADOPSE_IMDB_IMITATION.UserControls.Nena
{
    public partial class AddEditActorUserControl : UserControl
    {
        #region Private Fields
        private ActorViewModel _myViewModel = new ActorViewModel();
        private bool _isInAddMode;
        #endregion

        public AddEditActorUserControl(int? actorId = null)
        {
            InitializeComponent();

            Session.SetThemeColor(this);

            _myViewModel = new ActorViewModel();
            _isInAddMode = !actorId.HasValue;

            UserControlHeader.Text = _isInAddMode ? "Add new Actor" : "Edit Actor";

            if (!_isInAddMode)
            {
                //#1 Load actor through ActorId from parameter OK :)
                _myViewModel.LoadSelectedActor(actorId.Value);

                //#2 Show all the Actor's information to the equivalent UI Kontrols OK :)
                FirstNameTextBox.Text = _myViewModel.SelectedActor.FirstName;
                LastNameTextBox.Text = _myViewModel.SelectedActor.LastName;
                BirthDateDatePicker.Value = _myViewModel.SelectedActor.Birthday;
            }
            else
                _myViewModel.InitialiseNewActor();

            //#3 Implement the Save btn functionality => CreateNew/UpdateExisting OK :)

            //#4.1 Nice to have: control validations OK :)
            //#4.2 Nice to have: Some icons in the UI + btns
        }

        private void Save()
        {
            _myViewModel.SelectedActor.FirstName = FirstNameTextBox.Text;
            _myViewModel.SelectedActor.LastName = LastNameTextBox.Text;
            _myViewModel.SelectedActor.Birthday = BirthDateDatePicker.Value;

            _myViewModel.SaveSelectedActor();
        }

        private void SaveActorBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void AddNewActorBtn_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditActorUserControl());
        }

        private void ShowAllActorsBtn_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new ShowAllActorsUserControl());
        }
    }
}
