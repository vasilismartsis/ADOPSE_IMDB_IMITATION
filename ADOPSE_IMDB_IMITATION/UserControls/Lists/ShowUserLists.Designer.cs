
namespace ADOPSE_IMDB_IMITATION
{
    partial class MyLists
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
            this.ListLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListLayoutPanel
            // 
            this.ListLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListLayoutPanel.AutoScroll = true;
            this.ListLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListLayoutPanel.Location = new System.Drawing.Point(0, 61);
            this.ListLayoutPanel.Name = "ListLayoutPanel";
            this.ListLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ListLayoutPanel.Size = new System.Drawing.Size(674, 439);
            this.ListLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Lists";
            // 
            // MyLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListLayoutPanel);
            this.Name = "MyLists";
            this.Size = new System.Drawing.Size(674, 500);
            this.Load += new System.EventHandler(this.MyLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}
