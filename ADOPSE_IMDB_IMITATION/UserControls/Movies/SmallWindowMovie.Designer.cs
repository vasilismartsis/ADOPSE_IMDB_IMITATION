
namespace ADOPSE_IMDB_IMITATION
{
    partial class SmallWindowMovie
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
        private void InitializeComponent1()
        {
            this.ImageOfMovie = new System.Windows.Forms.PictureBox();
            this.NameOfMovie = new System.Windows.Forms.Label();
            this.RatingOfMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageOfMovie
            // 
            this.ImageOfMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageOfMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOfMovie.Location = new System.Drawing.Point(3, 3);
            this.ImageOfMovie.Name = "ImageOfMovie";
            this.ImageOfMovie.Size = new System.Drawing.Size(194, 144);
            this.ImageOfMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOfMovie.TabIndex = 0;
            this.ImageOfMovie.TabStop = false;
            // 
            // NameOfMovie
            // 
            this.NameOfMovie.AutoSize = true;
            this.NameOfMovie.Location = new System.Drawing.Point(259, 43);
            this.NameOfMovie.Name = "NameOfMovie";
            this.NameOfMovie.Size = new System.Drawing.Size(75, 13);
            this.NameOfMovie.TabIndex = 1;
            this.NameOfMovie.Text = "NameOfMovie";
            this.NameOfMovie.Click += new System.EventHandler(this.NameOfMovie_Click);
            // 
            // RatingOfMovie
            // 
            this.RatingOfMovie.AutoSize = true;
            this.RatingOfMovie.Location = new System.Drawing.Point(259, 95);
            this.RatingOfMovie.Name = "RatingOfMovie";
            this.RatingOfMovie.Size = new System.Drawing.Size(78, 13);
            this.RatingOfMovie.TabIndex = 2;
            this.RatingOfMovie.Text = "RatingOfMovie";
            // 
            // SmallWindowMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingOfMovie);
            this.Controls.Add(this.NameOfMovie);
            this.Controls.Add(this.ImageOfMovie);
            this.Name = "SmallWindowMovie";
            this.Size = new System.Drawing.Size(373, 150);
            this.Load += new System.EventHandler(this.SmallWindowMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Label NameOfMovie;
        private System.Windows.Forms.Label SummaryOfMovie;
        private System.Windows.Forms.Label RatingOfMovie;
        private System.Windows.Forms.PictureBox ImageOfMovie;
        private System.Windows.Forms.Button RateMovieBtn;
    }
}
