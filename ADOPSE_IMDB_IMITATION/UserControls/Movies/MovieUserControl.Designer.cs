
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
            this.NameOfMovie = new System.Windows.Forms.Label();
            this.ImageOfMovie = new System.Windows.Forms.PictureBox();
            this.SummaryOfMovie = new System.Windows.Forms.Label();
            this.RatingOfMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfMovie
            // 
            this.NameOfMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameOfMovie.AutoSize = true;
            this.NameOfMovie.Location = new System.Drawing.Point(426, 41);
            this.NameOfMovie.Name = "NameOfMovie";
            this.NameOfMovie.Size = new System.Drawing.Size(75, 13);
            this.NameOfMovie.TabIndex = 0;
            this.NameOfMovie.Text = "NameOfMovie";
            // 
            // ImageOfMovie
            // 
            this.ImageOfMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOfMovie.Location = new System.Drawing.Point(22, 25);
            this.ImageOfMovie.Name = "ImageOfMovie";
            this.ImageOfMovie.Size = new System.Drawing.Size(322, 204);
            this.ImageOfMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOfMovie.TabIndex = 1;
            this.ImageOfMovie.TabStop = false;
            // 
            // SummaryOfMovie
            // 
            this.SummaryOfMovie.AutoSize = true;
            this.SummaryOfMovie.Location = new System.Drawing.Point(423, 122);
            this.SummaryOfMovie.Name = "SummaryOfMovie";
            this.SummaryOfMovie.Size = new System.Drawing.Size(90, 13);
            this.SummaryOfMovie.TabIndex = 2;
            this.SummaryOfMovie.Text = "SummaryOfMovie";
            // 
            // RatingOfMovie
            // 
            this.RatingOfMovie.AutoSize = true;
            this.RatingOfMovie.Location = new System.Drawing.Point(423, 216);
            this.RatingOfMovie.Name = "RatingOfMovie";
            this.RatingOfMovie.Size = new System.Drawing.Size(78, 13);
            this.RatingOfMovie.TabIndex = 3;
            this.RatingOfMovie.Text = "RatingOfMovie";
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingOfMovie);
            this.Controls.Add(this.SummaryOfMovie);
            this.Controls.Add(this.ImageOfMovie);
            this.Controls.Add(this.NameOfMovie);
            this.Name = "Movie";
            this.Size = new System.Drawing.Size(647, 529);
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfMovie;
        private System.Windows.Forms.PictureBox ImageOfMovie;
        private System.Windows.Forms.Label SummaryOfMovie;
        private System.Windows.Forms.Label RatingOfMovie;
    }
}
