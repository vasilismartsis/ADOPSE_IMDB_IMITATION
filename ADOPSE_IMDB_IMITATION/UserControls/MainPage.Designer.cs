
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewActorBtn = new System.Windows.Forms.Button();
            this.ShowAllActorsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(371, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO IMDB";
            // 
            // AddNewActorBtn
            // 
            this.AddNewActorBtn.Location = new System.Drawing.Point(132, 80);
            this.AddNewActorBtn.Name = "AddNewActorBtn";
            this.AddNewActorBtn.Size = new System.Drawing.Size(118, 39);
            this.AddNewActorBtn.TabIndex = 1;
            this.AddNewActorBtn.Text = "Add new Actor";
            this.AddNewActorBtn.UseVisualStyleBackColor = true;
            this.AddNewActorBtn.Click += new System.EventHandler(this.AddNewActorBtn_Click);
            // 
            // ShowAllActorsBtn
            // 
            this.ShowAllActorsBtn.Location = new System.Drawing.Point(269, 80);
            this.ShowAllActorsBtn.Name = "ShowAllActorsBtn";
            this.ShowAllActorsBtn.Size = new System.Drawing.Size(120, 39);
            this.ShowAllActorsBtn.TabIndex = 2;
            this.ShowAllActorsBtn.Text = "Show all Actors";
            this.ShowAllActorsBtn.UseVisualStyleBackColor = true;
            this.ShowAllActorsBtn.Click += new System.EventHandler(this.ShowAllActorsBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowAllActorsBtn);
            this.Controls.Add(this.AddNewActorBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(891, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewActorBtn;
        private System.Windows.Forms.Button ShowAllActorsBtn;
    }
}
