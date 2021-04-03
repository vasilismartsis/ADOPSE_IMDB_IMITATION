
namespace ADOPSE_IMDB_IMITATION
{
    partial class Movie
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
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(287, 48);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(35, 13);
            this.MovieNameLabel.TabIndex = 0;
            this.MovieNameLabel.Text = "label1";
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieNameLabel);
            this.Name = "Movie";
            this.Size = new System.Drawing.Size(647, 529);
            this.Load += new System.EventHandler(this.Movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieNameLabel;
    }
}
