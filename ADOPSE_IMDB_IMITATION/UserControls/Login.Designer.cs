
namespace ADOPSE_IMDB_IMITATION
{
    partial class Login
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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(15, 16);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(56, 13);
            UsernameLabel.TabIndex = 14;
            UsernameLabel.Text = "username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(15, 42);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(55, 13);
            PasswordLabel.TabIndex = 16;
            PasswordLabel.Text = "password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(90, 13);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.UsernameTextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(90, 39);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.PasswordTextBox.TabIndex = 17;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.Location = new System.Drawing.Point(123, 82);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 24;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(308, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;

        private System.Windows.Forms.TextBox PasswordTextBox;

        private System.Windows.Forms.Button LoginButton;
    }
}
