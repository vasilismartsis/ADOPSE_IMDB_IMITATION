
namespace ADOPSE_IMDB_IMITATION
{
    partial class ProfileSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProfileSettingsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.StateComboBox);
            this.panel1.Controls.Add(this.StateLabel);
            this.panel1.Location = new System.Drawing.Point(85, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 22);
            this.panel1.TabIndex = 0;
            // 
            // StateComboBox
            // 
            this.StateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "Public",
            "Friends",
            "Private"});
            this.StateComboBox.Location = new System.Drawing.Point(42, 0);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(121, 21);
            this.StateComboBox.TabIndex = 1;
            this.StateComboBox.Text = "Public";
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(1, 3);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(35, 13);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "State:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.ThemeComboBox);
            this.panel2.Controls.Add(this.ThemeLabel);
            this.panel2.Location = new System.Drawing.Point(84, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 22);
            this.panel2.TabIndex = 2;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.ThemeComboBox.Location = new System.Drawing.Point(42, 0);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThemeComboBox.TabIndex = 1;
            this.ThemeComboBox.Text = "Light";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(1, 3);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(43, 13);
            this.ThemeLabel.TabIndex = 0;
            this.ThemeLabel.Text = "Theme:";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.Lime;
            this.SaveButton.Location = new System.Drawing.Point(84, 257);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(174, 257);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProfileSettingsLabel
            // 
            this.ProfileSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfileSettingsLabel.AutoSize = true;
            this.ProfileSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProfileSettingsLabel.Location = new System.Drawing.Point(91, 21);
            this.ProfileSettingsLabel.Name = "ProfileSettingsLabel";
            this.ProfileSettingsLabel.Size = new System.Drawing.Size(158, 25);
            this.ProfileSettingsLabel.TabIndex = 3;
            this.ProfileSettingsLabel.Text = "Profile Settings";
            // 
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProfileSettingsLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "ProfileSettings";
            this.Size = new System.Drawing.Size(339, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ProfileSettingsLabel;
    }
}
