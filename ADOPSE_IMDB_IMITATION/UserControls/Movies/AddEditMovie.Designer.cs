
namespace ADOPSE_IMDB_IMITATION
{
    partial class AddEditMovie
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
            this.AddMovieLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEditMovieButton = new System.Windows.Forms.Button();
            this.ReleaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenresListBox = new System.Windows.Forms.CheckedListBox();
            this.GenresLabel = new System.Windows.Forms.Label();
            this.IsSeriesCheckBox = new System.Windows.Forms.CheckBox();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new PlaceholderTextBox();
            this.DirectorTextBox = new PlaceholderTextBox();
            this.TrailerTextBox = new PlaceholderTextBox();
            this.ImageTextBox = new PlaceholderTextBox();
            this.NameTextBox = new PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // AddMovieLabel
            // 
            this.AddMovieLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddMovieLabel.AutoSize = true;
            this.AddMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddMovieLabel.Location = new System.Drawing.Point(1, 46);
            this.AddMovieLabel.Name = "AddMovieLabel";
            this.AddMovieLabel.Size = new System.Drawing.Size(246, 25);
            this.AddMovieLabel.TabIndex = 0;
            this.AddMovieLabel.Text = "Add a movie or a series:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Image";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trailer";
            // 
            // AddEditMovieButton
            // 
            this.AddEditMovieButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditMovieButton.BackColor = System.Drawing.Color.Chartreuse;
            this.AddEditMovieButton.Location = new System.Drawing.Point(16, 614);
            this.AddEditMovieButton.Name = "AddEditMovieButton";
            this.AddEditMovieButton.Size = new System.Drawing.Size(72, 23);
            this.AddEditMovieButton.TabIndex = 11;
            this.AddEditMovieButton.Text = "Add movie";
            this.AddEditMovieButton.UseVisualStyleBackColor = false;
            this.AddEditMovieButton.Click += new System.EventHandler(this.AddEditMovieButton_Click);
            // 
            // ReleaseDateTimePicker
            // 
            this.ReleaseDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleaseDateTimePicker.Location = new System.Drawing.Point(23, 208);
            this.ReleaseDateTimePicker.Name = "ReleaseDateTimePicker";
            this.ReleaseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDateTimePicker.TabIndex = 12;
            // 
            // GenresListBox
            // 
            this.GenresListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenresListBox.Location = new System.Drawing.Point(67, 477);
            this.GenresListBox.Name = "GenresListBox";
            this.GenresListBox.Size = new System.Drawing.Size(120, 49);
            this.GenresListBox.TabIndex = 0;
            // 
            // GenresLabel
            // 
            this.GenresLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenresLabel.AutoSize = true;
            this.GenresLabel.Location = new System.Drawing.Point(104, 461);
            this.GenresLabel.Name = "GenresLabel";
            this.GenresLabel.Size = new System.Drawing.Size(41, 13);
            this.GenresLabel.TabIndex = 13;
            this.GenresLabel.Text = "Genres";
            // 
            // IsSeriesCheckBox
            // 
            this.IsSeriesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsSeriesCheckBox.AutoSize = true;
            this.IsSeriesCheckBox.Location = new System.Drawing.Point(95, 157);
            this.IsSeriesCheckBox.Name = "IsSeriesCheckBox";
            this.IsSeriesCheckBox.Size = new System.Drawing.Size(66, 17);
            this.IsSeriesCheckBox.TabIndex = 16;
            this.IsSeriesCheckBox.Text = "Is Series";
            this.IsSeriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(101, 539);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(44, 13);
            this.DirectorLabel.TabIndex = 18;
            this.DirectorLabel.Text = "Director";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(101, 288);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 19;
            this.DescriptionLabel.Text = "Description";
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteMovieButton.BackColor = System.Drawing.Color.Red;
            this.DeleteMovieButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteMovieButton.Location = new System.Drawing.Point(86, 614);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteMovieButton.TabIndex = 21;
            this.DeleteMovieButton.Text = "Delete movie";
            this.DeleteMovieButton.UseVisualStyleBackColor = false;
            this.DeleteMovieButton.Visible = false;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(160, 614);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.DescriptionTextBox.Location = new System.Drawing.Point(23, 304);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Placeholder = "Add Description";
            this.DescriptionTextBox.Size = new System.Drawing.Size(200, 94);
            this.DescriptionTextBox.TabIndex = 20;
            this.DescriptionTextBox.Text = "Add Description";
            // 
            // DirectorTextBox
            // 
            this.DirectorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectorTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.DirectorTextBox.Location = new System.Drawing.Point(77, 555);
            this.DirectorTextBox.Name = "DirectorTextBox";
            this.DirectorTextBox.Placeholder = "Add Director";
            this.DirectorTextBox.Size = new System.Drawing.Size(100, 20);
            this.DirectorTextBox.TabIndex = 17;
            this.DirectorTextBox.Text = "Add Director";
            // 
            // TrailerTextBox
            // 
            this.TrailerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrailerTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TrailerTextBox.Location = new System.Drawing.Point(77, 428);
            this.TrailerTextBox.Name = "TrailerTextBox";
            this.TrailerTextBox.Placeholder = "Add Trailer";
            this.TrailerTextBox.Size = new System.Drawing.Size(100, 20);
            this.TrailerTextBox.TabIndex = 5;
            this.TrailerTextBox.Text = "Add Trailer";
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ImageTextBox.Location = new System.Drawing.Point(77, 256);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Placeholder = "Add Image URL";
            this.ImageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImageTextBox.TabIndex = 4;
            this.ImageTextBox.Text = "Add Image URL";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.Location = new System.Drawing.Point(77, 116);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Placeholder = "Add Name";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Add Name";
            // 
            // AddEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteMovieButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.DirectorTextBox);
            this.Controls.Add(this.IsSeriesCheckBox);
            this.Controls.Add(this.GenresLabel);
            this.Controls.Add(this.GenresListBox);
            this.Controls.Add(this.ReleaseDateTimePicker);
            this.Controls.Add(this.AddEditMovieButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrailerTextBox);
            this.Controls.Add(this.ImageTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddMovieLabel);
            this.Name = "AddEditMovie";
            this.Size = new System.Drawing.Size(249, 690);
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddMovieLabel;
        private PlaceholderTextBox NameTextBox;
        private PlaceholderTextBox ImageTextBox;
        private PlaceholderTextBox TrailerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddEditMovieButton;
        private System.Windows.Forms.DateTimePicker ReleaseDateTimePicker;
        private System.Windows.Forms.CheckedListBox GenresListBox;
        private System.Windows.Forms.Label GenresLabel;
        private System.Windows.Forms.CheckBox IsSeriesCheckBox;
        private PlaceholderTextBox DirectorTextBox;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private PlaceholderTextBox DescriptionTextBox;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
