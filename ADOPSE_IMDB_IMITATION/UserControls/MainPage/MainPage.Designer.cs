
namespace ADOPSE_IMDB_IMITATION
{
    partial class MainPage
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
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.AutoScroll = true;
            this.CategoriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(819, 561);
            this.CategoriesPanel.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoriesPanel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(819, 561);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CategoriesPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
