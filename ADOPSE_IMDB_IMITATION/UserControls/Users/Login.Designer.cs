
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new PlaceholderTextBox();
            this.PasswordTextBox = new PlaceholderTextBox();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(15, 77);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(58, 13);
            UsernameLabel.TabIndex = 14;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(15, 103);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(56, 13);
            PasswordLabel.TabIndex = 16;
            PasswordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.Location = new System.Drawing.Point(123, 143);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 24;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Login";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(90, 74);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Placeholder = "";
            this.UsernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.UsernameTextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(90, 100);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Placeholder = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.PasswordTextBox.TabIndex = 17;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(308, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox UsernameTextBox;

        private PlaceholderTextBox PasswordTextBox;

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
    }
}
