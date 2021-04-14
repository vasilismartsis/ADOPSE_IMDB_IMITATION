
namespace ADOPSE_IMDB_IMITATION
{
    partial class List
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
            this.MoviesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoviesLayoutPanel
            // 
            this.MoviesLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.MoviesLayoutPanel.Name = "MoviesLayoutPanel";
            this.MoviesLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MoviesLayoutPanel.Size = new System.Drawing.Size(557, 444);
            this.MoviesLayoutPanel.TabIndex = 0;
            this.MoviesLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MoviesLayoutPanel_Paint);
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Location = new System.Drawing.Point(230, 16);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(77, 13);
            this.ListNameLabel.TabIndex = 1;
            this.ListNameLabel.Text = "ListNameLabel";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListNameLabel);
            this.Controls.Add(this.MoviesLayoutPanel);
            this.Name = "List";
            this.Size = new System.Drawing.Size(557, 489);
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MoviesLayoutPanel;
        private System.Windows.Forms.Label ListNameLabel;
    }
}
