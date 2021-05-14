
namespace ADOPSE_IMDB_IMITATION
{
    partial class MenuBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomePageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddActorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditActorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportAProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseSeriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTop10MoviesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTop10SeriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTop10ActorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ComboBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SearchIMDBInput = new PlaceholderTextBox();
            this.menuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageButton,
            this.ProfileButton,
            this.browseMoviesToolStripMenuItem,
            this.browseSeriesMenuItem,
            this.browseActorsToolStripMenuItem,
            this.showTop10MoviesMenuItem,
            this.showTop10SeriesMenuItem,
            this.showTop10ActorsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomePageButton
            // 
            this.HomePageButton.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(53, 20);
            this.HomePageButton.Text = "IMDb";
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProfileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterToolStripMenuItem,
            this.LoginToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.CreateListToolStripMenuItem,
            this.MyListsToolStripMenuItem,
            this.AdministratorFunctionsToolStripMenuItem,
            this.ReportAProblemToolStripMenuItem});
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(53, 20);
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.MouseEnter += new System.EventHandler(this.ProfileButton_MouseEnter);
            // 
            // RegisterToolStripMenuItem
            // 
            this.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem";
            this.RegisterToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RegisterToolStripMenuItem.Text = "Register";
            this.RegisterToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.LoginToolStripMenuItem.Text = "Login";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.Visible = false;
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // CreateListToolStripMenuItem
            // 
            this.CreateListToolStripMenuItem.Name = "CreateListToolStripMenuItem";
            this.CreateListToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.CreateListToolStripMenuItem.Text = "Create List";
            this.CreateListToolStripMenuItem.Click += new System.EventHandler(this.CreateListToolStripMenuItem_Click);
            // 
            // MyListsToolStripMenuItem
            // 
            this.MyListsToolStripMenuItem.Name = "MyListsToolStripMenuItem";
            this.MyListsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.MyListsToolStripMenuItem.Text = "My Lists";
            this.MyListsToolStripMenuItem.Click += new System.EventHandler(this.MyListsToolStripMenuItem_Click);
            // 
            // AdministratorFunctionsToolStripMenuItem
            // 
            this.AdministratorFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMovieToolStripMenuItem,
            this.EditMovieToolStripMenuItem,
            this.AddActorToolStripMenuItem,
            this.EditActorToolStripMenuItem,
            this.showAllActorsToolStripMenuItem});
            this.AdministratorFunctionsToolStripMenuItem.Name = "AdministratorFunctionsToolStripMenuItem";
            this.AdministratorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.AdministratorFunctionsToolStripMenuItem.Text = "Administrator Functions";
            // 
            // AddMovieToolStripMenuItem
            // 
            this.AddMovieToolStripMenuItem.Name = "AddMovieToolStripMenuItem";
            this.AddMovieToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.AddMovieToolStripMenuItem.Text = "Add Movie";
            this.AddMovieToolStripMenuItem.Click += new System.EventHandler(this.AddMovieToolStripMenuItem_Click);
            // 
            // EditMovieToolStripMenuItem
            // 
            this.EditMovieToolStripMenuItem.Name = "EditMovieToolStripMenuItem";
            this.EditMovieToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.EditMovieToolStripMenuItem.Text = "Edit Movie";
            this.EditMovieToolStripMenuItem.Click += new System.EventHandler(this.EditMovieToolStripMenuItem_Click);
            // 
            // AddActorToolStripMenuItem
            // 
            this.AddActorToolStripMenuItem.Name = "AddActorToolStripMenuItem";
            this.AddActorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.AddActorToolStripMenuItem.Text = "Add Actor";
            this.AddActorToolStripMenuItem.Click += new System.EventHandler(this.AddActorToolStripMenuItem_Click);
            // 
            // EditActorToolStripMenuItem
            // 
            this.EditActorToolStripMenuItem.Name = "EditActorToolStripMenuItem";
            this.EditActorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.EditActorToolStripMenuItem.Text = "Edit Actor";
            this.EditActorToolStripMenuItem.Click += new System.EventHandler(this.EditActorToolStripMenuItem_Click);
            // 
            // showAllActorsToolStripMenuItem
            // 
            this.showAllActorsToolStripMenuItem.Name = "showAllActorsToolStripMenuItem";
            this.showAllActorsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showAllActorsToolStripMenuItem.Text = "Show all Actors";
            // 
            // ReportAProblemToolStripMenuItem
            // 
            this.ReportAProblemToolStripMenuItem.Name = "ReportAProblemToolStripMenuItem";
            this.ReportAProblemToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ReportAProblemToolStripMenuItem.Text = "Report a Problem";
            this.ReportAProblemToolStripMenuItem.Click += new System.EventHandler(this.reportAProblemToolStripMenuItem_Click);
            // 
            // browseMoviesToolStripMenuItem
            // 
            this.browseMoviesToolStripMenuItem.Name = "browseMoviesToolStripMenuItem";
            this.browseMoviesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.browseMoviesToolStripMenuItem.Text = "Browse Movies";
            this.browseMoviesToolStripMenuItem.Click += new System.EventHandler(this.browseMoviesToolStripMenuItem_Click);
            // 
            // browseSeriesMenuItem
            // 
            this.browseSeriesMenuItem.Name = "browseSeriesMenuItem";
            this.browseSeriesMenuItem.Size = new System.Drawing.Size(90, 20);
            this.browseSeriesMenuItem.Text = "Browse Series";
            this.browseSeriesMenuItem.Click += new System.EventHandler(this.browseSeriesMenuItem_Click);
            // 
            // browseActorsToolStripMenuItem
            // 
            this.browseActorsToolStripMenuItem.Name = "browseActorsToolStripMenuItem";
            this.browseActorsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.browseActorsToolStripMenuItem.Text = "Browse Actors";
            this.browseActorsToolStripMenuItem.Click += new System.EventHandler(this.browseActorsToolStripMenuItem_Click);
            // 
            // showTop10MoviesMenuItem
            // 
            this.showTop10MoviesMenuItem.Name = "showTop10MoviesMenuItem";
            this.showTop10MoviesMenuItem.Size = new System.Drawing.Size(126, 20);
            this.showTop10MoviesMenuItem.Text = "Show Top 10 Movies";
            this.showTop10MoviesMenuItem.Click += new System.EventHandler(this.showTop10MoviesMenuItem_Click);
            // 
            // showTop10SeriesMenuItem
            // 
            this.showTop10SeriesMenuItem.Name = "showTop10SeriesMenuItem";
            this.showTop10SeriesMenuItem.Size = new System.Drawing.Size(118, 20);
            this.showTop10SeriesMenuItem.Text = "Show Top 10 Series";
            this.showTop10SeriesMenuItem.Click += new System.EventHandler(this.showTop10SeriesMenuItem_Click);
            // 
            // showTop10ActorsMenuItem
            // 
            this.showTop10ActorsMenuItem.Name = "showTop10ActorsMenuItem";
            this.showTop10ActorsMenuItem.Size = new System.Drawing.Size(122, 20);
            this.showTop10ActorsMenuItem.Text = "Show Top 10 Actors";
            this.showTop10ActorsMenuItem.Click += new System.EventHandler(this.showTop10ActorsMenuItem_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchPanel.AutoSize = true;
            this.SearchPanel.Controls.Add(this.SearchIMDBInput);
            this.SearchPanel.Controls.Add(this.TypeComboBox);
            this.SearchPanel.Location = new System.Drawing.Point(330, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(213, 21);
            this.SearchPanel.TabIndex = 3;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "All",
            "Movies",
            "Series",
            "Actors"});
            this.TypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(39, 21);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.Text = "All";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            this.TypeComboBox.Enter += new System.EventHandler(this.TypeComboBox_Enter);
            this.TypeComboBox.Leave += new System.EventHandler(this.TypeComboBox_Leave);
            // 
            // ComboBoxTimer
            // 
            this.ComboBoxTimer.Tick += new System.EventHandler(this.ComboBoxTimer_Tick);
            // 
            // SearchIMDBInput
            // 
            this.SearchIMDBInput.AcceptsReturn = true;
            this.SearchIMDBInput.AcceptsTab = true;
            this.SearchIMDBInput.AccessibleName = "";
            this.SearchIMDBInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchIMDBInput.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchIMDBInput.Location = new System.Drawing.Point(39, 0);
            this.SearchIMDBInput.Multiline = true;
            this.SearchIMDBInput.Name = "SearchIMDBInput";
            this.SearchIMDBInput.Placeholder = "Search IMDB";
            this.SearchIMDBInput.Size = new System.Drawing.Size(174, 21);
            this.SearchIMDBInput.TabIndex = 1;
            this.SearchIMDBInput.Text = "Search IMDB";
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(784, 192);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomePageButton;
        private System.Windows.Forms.ToolStripMenuItem ProfileButton;
        private PlaceholderTextBox SearchIMDBInput;
        private System.Windows.Forms.ToolStripMenuItem RegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddActorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportAProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseMoviesToolStripMenuItem;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Timer ComboBoxTimer;
        private System.Windows.Forms.ToolStripMenuItem EditActorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllActorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseActorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseSeriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTop10MoviesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTop10SeriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTop10ActorsMenuItem;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}
