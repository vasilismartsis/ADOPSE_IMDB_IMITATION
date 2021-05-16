
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class Suggestions
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
            this.suggestionslayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // suggestionslayoutpanel
            // 
            this.suggestionslayoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.suggestionslayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.suggestionslayoutpanel.Name = "suggestionslayoutpanel";
            this.suggestionslayoutpanel.Size = new System.Drawing.Size(262, 630);
            this.suggestionslayoutpanel.TabIndex = 0;
            // 
            // Suggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.suggestionslayoutpanel);
            this.Name = "Suggestions";
            this.Size = new System.Drawing.Size(262, 630);
            this.Load += new System.EventHandler(this.Suggestions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel suggestionslayoutpanel;
    }
}
