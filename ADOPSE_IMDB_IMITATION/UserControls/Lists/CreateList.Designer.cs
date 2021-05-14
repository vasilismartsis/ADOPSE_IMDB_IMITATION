
namespace ADOPSE_IMDB_IMITATION
{
    partial class CreateList
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
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.ListNameText = new PlaceholderTextBox();
            this.CreateListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ListNameLabel.Location = new System.Drawing.Point(-2, 0);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(245, 25);
            this.ListNameLabel.TabIndex = 0;
            this.ListNameLabel.Text = "Give a name to your list:";
            // 
            // ListNameText
            // 
            this.ListNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListNameText.ForeColor = System.Drawing.Color.DarkGray;
            this.ListNameText.Location = new System.Drawing.Point(12, 91);
            this.ListNameText.Name = "ListNameText";
            this.ListNameText.Placeholder = "";
            this.ListNameText.Size = new System.Drawing.Size(220, 20);
            this.ListNameText.TabIndex = 1;
            // 
            // CreateListButton
            // 
            this.CreateListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateListButton.Location = new System.Drawing.Point(86, 167);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(75, 23);
            this.CreateListButton.TabIndex = 2;
            this.CreateListButton.Text = "Create List";
            this.CreateListButton.UseVisualStyleBackColor = true;
            this.CreateListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // CreateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateListButton);
            this.Controls.Add(this.ListNameText);
            this.Controls.Add(this.ListNameLabel);
            this.Name = "CreateList";
            this.Size = new System.Drawing.Size(243, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListNameLabel;
        private PlaceholderTextBox ListNameText;
        private System.Windows.Forms.Button CreateListButton;
    }
}
