
namespace ADOPSE_IMDB_IMITATION
{
    partial class MovieUserControl
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
            this.SeriesLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NameOfMovie = new System.Windows.Forms.Label();
            this.DescriptionOfMovie = new System.Windows.Forms.Label();
            this.RatingOfMovie = new System.Windows.Forms.Label();
            this.DirectorOfMovie = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.ImageOfMovie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // SeriesLayout
            // 
            this.SeriesLayout.Location = new System.Drawing.Point(58, 420);
            this.SeriesLayout.Name = "SeriesLayout";
            this.SeriesLayout.Size = new System.Drawing.Size(260, 53);
            this.SeriesLayout.TabIndex = 2;
            // 
            // NameOfMovie
            // 
            this.NameOfMovie.AutoSize = true;
            this.NameOfMovie.Location = new System.Drawing.Point(459, 21);
            this.NameOfMovie.Name = "NameOfMovie";
            this.NameOfMovie.Size = new System.Drawing.Size(75, 13);
            this.NameOfMovie.TabIndex = 3;
            this.NameOfMovie.Text = "NameOfMovie";
            // 
            // DescriptionOfMovie
            // 
            this.DescriptionOfMovie.AutoSize = true;
            this.DescriptionOfMovie.Location = new System.Drawing.Point(324, 72);
            this.DescriptionOfMovie.Name = "DescriptionOfMovie";
            this.DescriptionOfMovie.Size = new System.Drawing.Size(100, 13);
            this.DescriptionOfMovie.TabIndex = 4;
            this.DescriptionOfMovie.Text = "DescriptionOfMovie";
            // 
            // RatingOfMovie
            // 
            this.RatingOfMovie.AutoSize = true;
            this.RatingOfMovie.Location = new System.Drawing.Point(459, 140);
            this.RatingOfMovie.Name = "RatingOfMovie";
            this.RatingOfMovie.Size = new System.Drawing.Size(78, 13);
            this.RatingOfMovie.TabIndex = 5;
            this.RatingOfMovie.Text = "RatingOfMovie";
            // 
            // DirectorOfMovie
            // 
            this.DirectorOfMovie.AutoSize = true;
            this.DirectorOfMovie.Location = new System.Drawing.Point(459, 204);
            this.DirectorOfMovie.Name = "DirectorOfMovie";
            this.DirectorOfMovie.Size = new System.Drawing.Size(84, 13);
            this.DirectorOfMovie.TabIndex = 6;
            this.DirectorOfMovie.Text = "DirectorOfMovie";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(459, 266);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(69, 13);
            this.ReleaseDate.TabIndex = 7;
            this.ReleaseDate.Text = "ReleaseDate";
            // 
            // ImageOfMovie
            // 
            this.ImageOfMovie.Location = new System.Drawing.Point(58, 21);
            this.ImageOfMovie.Name = "ImageOfMovie";
            this.ImageOfMovie.Size = new System.Drawing.Size(260, 357);
            this.ImageOfMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageOfMovie.TabIndex = 8;
            this.ImageOfMovie.TabStop = false;
            // 
            // MovieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ImageOfMovie);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.DirectorOfMovie);
            this.Controls.Add(this.RatingOfMovie);
            this.Controls.Add(this.DescriptionOfMovie);
            this.Controls.Add(this.NameOfMovie);
            this.Controls.Add(this.SeriesLayout);
            this.Name = "MovieUserControl";
            this.Size = new System.Drawing.Size(712, 529);
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel SeriesLayout;
        private System.Windows.Forms.Label NameOfMovie;
        private System.Windows.Forms.Label DescriptionOfMovie;
        private System.Windows.Forms.Label RatingOfMovie;
        private System.Windows.Forms.Label DirectorOfMovie;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.PictureBox ImageOfMovie;
    }
}
