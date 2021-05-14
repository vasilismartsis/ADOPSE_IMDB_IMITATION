
namespace ADOPSE_IMDB_IMITATION
{
    partial class ListUserControl
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
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.MoviesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ListNameLabel.Location = new System.Drawing.Point(205, 18);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(155, 25);
            this.ListNameLabel.TabIndex = 1;
            this.ListNameLabel.Text = "ListNameLabel";
            // 
            // MoviesLayoutPanel
            // 
            this.MoviesLayoutPanel.Location = new System.Drawing.Point(0, 63);
            this.MoviesLayoutPanel.Name = "MoviesLayoutPanel";
            this.MoviesLayoutPanel.Size = new System.Drawing.Size(557, 426);
            this.MoviesLayoutPanel.TabIndex = 2;
            // 
            // ListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesLayoutPanel);
            this.Controls.Add(this.ListNameLabel);
            this.Name = "ListUserControl";
            this.Size = new System.Drawing.Size(557, 489);
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListNameLabel;
        private System.Windows.Forms.FlowLayoutPanel MoviesLayoutPanel;
    }
}
