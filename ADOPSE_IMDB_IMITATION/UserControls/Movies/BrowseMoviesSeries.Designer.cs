
namespace ADOPSE_IMDB_IMITATION.UserControls
{
    partial class BrowseMoviesSeries
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
            this.flowLayoutBrowseMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutBrowseMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutBrowseMovies
            // 
            this.flowLayoutBrowseMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBrowseMovies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBrowseMovies.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutBrowseMovies.Name = "flowLayoutBrowseMovies";
            this.flowLayoutBrowseMovies.Size = new System.Drawing.Size(365, 639);
            this.flowLayoutBrowseMovies.TabIndex = 0;
            // 
            // BrowseMoviesSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutBrowseMovies);
            this.Name = "BrowseMoviesSeries";
            this.Size = new System.Drawing.Size(365, 639);
            this.flowLayoutBrowseMovies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutBrowseMovies;
    }
}
