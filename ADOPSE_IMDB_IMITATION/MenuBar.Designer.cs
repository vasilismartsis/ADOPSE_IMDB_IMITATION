
namespace ADOPSE_IMDB_IMITATION
{
    partial class MenuBar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomePageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchIMDBInput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageButton,
            this.ProfileButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomePageButton
            // 
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(48, 20);
            this.HomePageButton.Text = "IMDB";
            // 
            // ProfileButton
            // 
            this.ProfileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(53, 20);
            this.ProfileButton.Text = "Profile";
            // 
            // SearchIMDBInput
            // 
            this.SearchIMDBInput.AcceptsReturn = true;
            this.SearchIMDBInput.AcceptsTab = true;
            this.SearchIMDBInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchIMDBInput.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchIMDBInput.Location = new System.Drawing.Point(203, 2);
            this.SearchIMDBInput.Name = "SearchIMDBInput";
            this.SearchIMDBInput.Size = new System.Drawing.Size(163, 20);
            this.SearchIMDBInput.TabIndex = 1;
            this.SearchIMDBInput.Text = "Search IMDB";
            this.SearchIMDBInput.Enter += new System.EventHandler(this.SearchIMDBInput_Enter);
            this.SearchIMDBInput.Leave += new System.EventHandler(this.SearchIMDBInput_Leave);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchIMDBInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomePageButton;
        private System.Windows.Forms.ToolStripMenuItem ProfileButton;
        private System.Windows.Forms.TextBox SearchIMDBInput;
    }
}
