
namespace ADOPSE_IMDB_IMITATION.UserControls
{
    partial class BrowseActorsUserControl
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
            this.flowLayoutBrowseActors = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutBrowseMovies
            // 
            this.flowLayoutBrowseActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBrowseActors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBrowseActors.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutBrowseActors.Name = "flowLayoutBrowseMovies";
            this.flowLayoutBrowseActors.Size = new System.Drawing.Size(365, 639);
            this.flowLayoutBrowseActors.TabIndex = 0;
            // 
            // BrowseMoviesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutBrowseActors);
            this.Name = "BrowseMoviesUI";
            this.Size = new System.Drawing.Size(365, 639);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutBrowseActors;
    }
}
