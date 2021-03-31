
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iMDBButton = new System.Windows.Forms.ToolStripMenuItem();
            this.profileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.iMDBSearchInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMDBButton,
            this.profileButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iMDBButton
            // 
            this.iMDBButton.Name = "iMDBButton";
            this.iMDBButton.Size = new System.Drawing.Size(48, 20);
            this.iMDBButton.Text = "IMDB";
            // 
            // profileButton
            // 
            this.profileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(53, 20);
            this.profileButton.Text = "Profile";
            // 
            // iMDBSearchInput
            // 
            this.iMDBSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iMDBSearchInput.ForeColor = System.Drawing.Color.DarkGray;
            this.iMDBSearchInput.Location = new System.Drawing.Point(223, 2);
            this.iMDBSearchInput.Name = "iMDBSearchInput";
            this.iMDBSearchInput.Size = new System.Drawing.Size(229, 20);
            this.iMDBSearchInput.TabIndex = 1;
            this.iMDBSearchInput.Text = "IMDB Search";
            this.iMDBSearchInput.Enter += new System.EventHandler(this.iMDBSearchInput_Enter);
            this.iMDBSearchInput.Leave += new System.EventHandler(this.iMDBSearchInput_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iMDBSearchInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iMDBButton;
        private System.Windows.Forms.ToolStripMenuItem profileButton;
        private System.Windows.Forms.TextBox iMDBSearchInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
