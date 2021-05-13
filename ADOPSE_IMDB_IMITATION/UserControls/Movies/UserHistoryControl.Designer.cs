
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class UserHistoryControl
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
            this.HistoryLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // HistoryLayoutPanel
            // 
            this.HistoryLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryLayoutPanel.AutoSize = true;
            this.HistoryLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HistoryLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HistoryLayoutPanel.Name = "HistoryLayoutPanel";
            this.HistoryLayoutPanel.Size = new System.Drawing.Size(474, 546);
            this.HistoryLayoutPanel.TabIndex = 0;
            // 
            // UserHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.HistoryLayoutPanel);
            this.Name = "UserHistoryControl";
            this.Size = new System.Drawing.Size(480, 552);
            this.Load += new System.EventHandler(this.UserHistoryControlLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HistoryLayoutPanel;
    }
}
