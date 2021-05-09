
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class EpisodesUserControl
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
            this.PreviousEpisode = new System.Windows.Forms.Button();
            this.NextEpisode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreviousEpisode
            // 
            this.PreviousEpisode.ForeColor = System.Drawing.Color.Black;
            this.PreviousEpisode.Location = new System.Drawing.Point(3, 3);
            this.PreviousEpisode.Name = "PreviousEpisode";
            this.PreviousEpisode.Size = new System.Drawing.Size(123, 23);
            this.PreviousEpisode.TabIndex = 0;
            this.PreviousEpisode.Text = "Previous Episode";
            this.PreviousEpisode.UseVisualStyleBackColor = true;
            // 
            // NextEpisode
            // 
            this.NextEpisode.ForeColor = System.Drawing.Color.Black;
            this.NextEpisode.Location = new System.Drawing.Point(132, 3);
            this.NextEpisode.Name = "NextEpisode";
            this.NextEpisode.Size = new System.Drawing.Size(124, 23);
            this.NextEpisode.TabIndex = 1;
            this.NextEpisode.Text = "Next Episode";
            this.NextEpisode.UseVisualStyleBackColor = true;
            // 
            // EpisodesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextEpisode);
            this.Controls.Add(this.PreviousEpisode);
            this.Name = "EpisodesUserControl";
            this.Size = new System.Drawing.Size(261, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PreviousEpisode;
        private System.Windows.Forms.Button NextEpisode;
    }
}
