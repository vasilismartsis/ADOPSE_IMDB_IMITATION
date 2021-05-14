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
using ADOPSE_IMDB_IMITATION.Models;

namespace ADOPSE_IMDB_IMITATION.UserControls.Nena
{
    public partial class ShowAllActorsUserControl : UserControl
    {
        public ShowAllActorsUserControl()
        {
            InitializeComponent();

            Session.SetThemeColor(this, new List<object> { new DataGridView() });

            var myViewModel = new ActorViewModel();

            //#1 Load all Actors from DB with an sql script
            myViewModel.LoadAllActors();

            //#2 Assign the above list to the MainGrid
            AllActorsDataGridView.DataSource = myViewModel.AllActors;
            AllActorsDataGridView.CellDoubleClick += AllActorsDataGridView_CellDoubleClick;
            AllActorsDataGridView.MultiSelect = false;

            //#3 Subscribe double click event to grid, so that with double click the AddnewActorUserControl opens

            //#4.1 AddNewActor schortcut btn
            //#4.2 Delete Actor btn (+ delete selected row in grid, when del btn is pressed)
            //#4.3 Add Search actor in grid possibility

            //#5.1 Nice to have: show amount of registered actors
            //#5.2 Nice to have: Some icons in the UI + btns
        }

        private void AllActorsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditActorUserControl(((Actor)AllActorsDataGridView.CurrentRow.DataBoundItem).ID));
        }

        private void OpenSelectedActorBtn_Click(object sender, EventArgs e)
        {
            var selectedActor = AllActorsDataGridView.CurrentRow.DataBoundItem as Actor;

            if (selectedActor != null)
                MainPanelUserControlOpener.OpenUserControl(new AddEditActorUserControl(selectedActor.ID));
            else
                PopupMessage1.ShowToolTip(ParentForm, "Please select an actor!", Color.Red);
        }
    }
}
