
namespace ADOPSE_IMDB_IMITATION
{
    partial class Complaints
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
            this.BodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectTextBox = new PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // BodyRichTextBox
            // 
            this.BodyRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BodyRichTextBox.Location = new System.Drawing.Point(209, 217);
            this.BodyRichTextBox.Name = "BodyRichTextBox";
            this.BodyRichTextBox.Size = new System.Drawing.Size(317, 141);
            this.BodyRichTextBox.TabIndex = 1;
            this.BodyRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Send your complaints";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendButton.Location = new System.Drawing.Point(259, 406);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(74, 138);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(43, 13);
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubjectTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SubjectTextBox.Location = new System.Drawing.Point(209, 135);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Placeholder = "Write subject";
            this.SubjectTextBox.Size = new System.Drawing.Size(317, 20);
            this.SubjectTextBox.TabIndex = 6;
            this.SubjectTextBox.Text = "Write subject";
            // 
            // Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BodyRichTextBox);
            this.Name = "Complaints";
            this.Size = new System.Drawing.Size(609, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox BodyRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SubjectLabel;
        private PlaceholderTextBox SubjectTextBox;
    }
}
