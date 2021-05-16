
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
            this.browseMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTop10MoviesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTop10ActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.createIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportAProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchIMDBInput = new PlaceholderTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ComboBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageButton,
            this.browseMoviesToolStripMenuItem,
            this.showTop10MoviesMenuItem,
            this.ProfileButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // HomePageButton
            // 
            this.HomePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(49, 20);
            this.HomePageButton.Text = "IMDb";
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // browseMoviesToolStripMenuItem
            // 
            this.browseMoviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.seriesToolStripMenuItem,
            this.actorsToolStripMenuItem});
            this.browseMoviesToolStripMenuItem.Name = "browseMoviesToolStripMenuItem";
            this.browseMoviesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.browseMoviesToolStripMenuItem.Text = "Browse ...";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            this.seriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seriesToolStripMenuItem.Text = "Series";
            this.seriesToolStripMenuItem.Click += new System.EventHandler(this.seriesToolStripMenuItem_Click);
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actorsToolStripMenuItem.Text = "Actors";
            this.actorsToolStripMenuItem.Click += new System.EventHandler(this.actorsToolStripMenuItem_Click);
            // 
            // showTop10MoviesMenuItem
            // 
            this.showTop10MoviesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem1,
            this.seriesToolStripMenuItem1,
            this.ShowTop10ActorsToolStripMenuItem});
            this.showTop10MoviesMenuItem.Name = "showTop10MoviesMenuItem";
            this.showTop10MoviesMenuItem.Size = new System.Drawing.Size(97, 20);
            this.showTop10MoviesMenuItem.Text = "Show Top 10 ...";
            this.showTop10MoviesMenuItem.Click += new System.EventHandler(this.showTop10MoviesMenuItem_Click);
            // 
            // moviesToolStripMenuItem1
            // 
            this.moviesToolStripMenuItem1.Name = "moviesToolStripMenuItem1";
            this.moviesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.moviesToolStripMenuItem1.Text = "Movies";
            this.moviesToolStripMenuItem1.Click += new System.EventHandler(this.moviesToolStripMenuItem1_Click);
            // 
            // seriesToolStripMenuItem1
            // 
            this.seriesToolStripMenuItem1.Name = "seriesToolStripMenuItem1";
            this.seriesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.seriesToolStripMenuItem1.Text = "Series";
            this.seriesToolStripMenuItem1.Click += new System.EventHandler(this.seriesToolStripMenuItem1_Click);
            // 
            // ShowTop10ActorsToolStripMenuItem
            // 
            this.ShowTop10ActorsToolStripMenuItem.Name = "ShowTop10ActorsToolStripMenuItem";
            this.ShowTop10ActorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowTop10ActorsToolStripMenuItem.Text = "Actors";
            this.ShowTop10ActorsToolStripMenuItem.Click += new System.EventHandler(this.ShowTop10ActorsToolStripMenuItem_Click);
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
            this.showAllActorsToolStripMenuItem,
            this.createIndexToolStripMenuItem});
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
            // createIndexToolStripMenuItem
            // 
            this.createIndexToolStripMenuItem.Name = "createIndexToolStripMenuItem";
            this.createIndexToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.createIndexToolStripMenuItem.Text = "Create Index";
            this.createIndexToolStripMenuItem.Click += new System.EventHandler(this.createIndexToolStripMenuItem_Click);
            // 
            // ReportAProblemToolStripMenuItem
            // 
            this.ReportAProblemToolStripMenuItem.Name = "ReportAProblemToolStripMenuItem";
            this.ReportAProblemToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ReportAProblemToolStripMenuItem.Text = "Report a Problem";
            this.ReportAProblemToolStripMenuItem.Click += new System.EventHandler(this.reportAProblemToolStripMenuItem_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchPanel.AutoSize = true;
            this.SearchPanel.Controls.Add(this.SearchIMDBInput);
            this.SearchPanel.Controls.Add(this.button2);
            this.SearchPanel.Controls.Add(this.TypeComboBox);
            this.SearchPanel.Location = new System.Drawing.Point(340, 1);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(294, 23);
            this.SearchPanel.TabIndex = 3;
            // 
            // SearchIMDBInput
            // 
            this.SearchIMDBInput.AcceptsReturn = true;
            this.SearchIMDBInput.AcceptsTab = true;
            this.SearchIMDBInput.AccessibleName = "";
            this.SearchIMDBInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchIMDBInput.ForeColor = System.Drawing.Color.Black;
            this.SearchIMDBInput.Location = new System.Drawing.Point(44, 0);
            this.SearchIMDBInput.Multiline = true;
            this.SearchIMDBInput.Name = "SearchIMDBInput";
            this.SearchIMDBInput.Placeholder = "";
            this.SearchIMDBInput.Size = new System.Drawing.Size(151, 23);
            this.SearchIMDBInput.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(198, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Title",
            "Genre",
            "Year"});
            this.TypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(44, 21);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.Text = "Title";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            this.TypeComboBox.Enter += new System.EventHandler(this.TypeComboBox_Enter);
            this.TypeComboBox.Leave += new System.EventHandler(this.TypeComboBox_Leave);
            // 
            // ComboBoxTimer
            // 
            this.ComboBoxTimer.Tick += new System.EventHandler(this.ComboBoxTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get_Series_in_database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(1207, 26);
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
        private System.Windows.Forms.ToolStripMenuItem showTop10MoviesMenuItem;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ShowTop10ActorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIndexToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
