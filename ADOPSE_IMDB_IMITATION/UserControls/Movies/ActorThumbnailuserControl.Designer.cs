
namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    partial class ActorThumbnailuserControl
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
            this.RateActorBtn = new System.Windows.Forms.Button();
            this.DateOfBirthTextBox = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RateActorBtn
            // 
            this.RateActorBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RateActorBtn.Location = new System.Drawing.Point(176, 90);
            this.RateActorBtn.Name = "RateActorBtn";
            this.RateActorBtn.Size = new System.Drawing.Size(75, 23);
            this.RateActorBtn.TabIndex = 12;
            this.RateActorBtn.Text = "rate me";
            this.RateActorBtn.UseVisualStyleBackColor = false;
            this.RateActorBtn.Visible = false;
            this.RateActorBtn.Click += new System.EventHandler(this.RateActorBtn_Click);
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.AutoSize = true;
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(176, 71);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(101, 13);
            this.DateOfBirthTextBox.TabIndex = 11;
            this.DateOfBirthTextBox.Text = "DateOfBirthTextBox";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AutoSize = true;
            this.LastNameTextBox.Location = new System.Drawing.Point(176, 47);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(94, 13);
            this.LastNameTextBox.TabIndex = 10;
            this.LastNameTextBox.Text = "LastNameTextBox";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.AutoSize = true;
            this.FirstNameTextBox.Location = new System.Drawing.Point(176, 19);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(93, 13);
            this.FirstNameTextBox.TabIndex = 9;
            this.FirstNameTextBox.Text = "FirstNameTextBox";
            // 
            // ActorThumbnailuserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RateActorBtn);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "ActorThumbnailuserControl";
            this.Size = new System.Drawing.Size(340, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RateActorBtn;
        private System.Windows.Forms.Label DateOfBirthTextBox;
        private System.Windows.Forms.Label LastNameTextBox;
        private System.Windows.Forms.Label FirstNameTextBox;
    }
}
