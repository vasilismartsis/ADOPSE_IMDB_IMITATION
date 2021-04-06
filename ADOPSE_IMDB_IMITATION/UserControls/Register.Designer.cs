
namespace ADOPSE_IMDB_IMITATION
{
    partial class Register
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
            System.Windows.Forms.Label UsernameLabel;
            System.Windows.Forms.Label PasswordLabel;
            System.Windows.Forms.Label FirstNameLabel;
            System.Windows.Forms.Label LastNameLabel;
            System.Windows.Forms.Label DateOfBirthLabel;
            this.UsernameTextBox = new PlaceholderTextBox();
            this.PasswordTextBox = new PlaceholderTextBox();
            this.FirstNameTextBox = new PlaceholderTextBox();
            this.LastNameTextBox = new PlaceholderTextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            FirstNameLabel = new System.Windows.Forms.Label();
            LastNameLabel = new System.Windows.Forms.Label();
            DateOfBirthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(7, 12);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(56, 13);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(7, 38);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(55, 13);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "password:";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new System.Drawing.Point(7, 64);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            FirstNameLabel.TabIndex = 7;
            FirstNameLabel.Text = "first Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new System.Drawing.Point(7, 90);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new System.Drawing.Size(57, 13);
            LastNameLabel.TabIndex = 9;
            LastNameLabel.Text = "last Name:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new System.Drawing.Point(7, 117);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            DateOfBirthLabel.TabIndex = 11;
            DateOfBirthLabel.Text = "date Of Birth:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(82, 9);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(82, 35);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameTextBox.Location = new System.Drawing.Point(82, 61);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameTextBox.Location = new System.Drawing.Point(82, 87);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(82, 113);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 12;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterButton.Location = new System.Drawing.Point(118, 156);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(DateOfBirthLabel);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(295, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private PlaceholderTextBox UsernameTextBox;
        private PlaceholderTextBox PasswordTextBox;
        private PlaceholderTextBox FirstNameTextBox;
        private PlaceholderTextBox LastNameTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.Button RegisterButton;
    }
}
